using domain.Entities;
using System.ComponentModel;

namespace AMIO_2
{
    public partial class Form2 : Form
    {
        public string _UserRole { get; set; }
        //Fonction pour le grisage éventuel des boutton selon les rôle de l'utilisateur:
        private void Grisage(Control element)
        {
            if (_UserRole == "user")
            {
                element.Enabled = false;
            }
            else element.Enabled = true;
        }
        //Alert message if unotorize clik accordind user role:
        public async void UserRoleAlert()
        {
            if (_UserRole == "user")
            {
                this.Text = "Materiel : consultation (simple utilisateur)";
                //MessageBox.Show("Votre niveau d'accéssibilité vous autorisera  seulement à consulter les éléments et non pas à les modifier ou créer.");
            }
            else
            {
                this.Text = "Materiel : administration (admin)";
                //MessageBox.Show("Votre niveau d'accéssibilité vous autorisera  seulement à créer,consulter, modifier et supprimer les éléments.");
            }

        }

        BindingList<Materiel> _materiels = new();
        BindingList<Category> _categories = new();
        BindingList<Category> _categoryChoice = new();
        BindingList<User> _Users = new();
        private static readonly MaterielApi materielApi = new();
        MaterielApi _api = materielApi;
        public Form2()
        {
            InitializeComponent();
            InitializeBinding();
            CBcategory.DisplayMember = "Name";
            CBowner.DisplayMember = "Name";
            DGVmat.SelectionChanged += DGVmat_SelectionChanged;
        }

        private async void DGVmat_SelectionChanged(object? sender, EventArgs e)
        {
            if (DGVmat.SelectedRows.Count <= 0) return;

            //Récupération du matériel correspondant à celui de la ligne sélectionné de la data grid view:
            Materiel selectedMateriel = DGVmat.SelectedRows[0]?.DataBoundItem as Materiel;
            //Si le matériel est biensélectionné
            if (selectedMateriel != null)
            {//Récupération de l'id du matériel sélectionné:
                int idMat = selectedMateriel.Id;
                //Récupération des catégories du matériel sélectionné:
                var materierialCategories = await _api.GetMaterialCategories(idMat);
                //Propriétaire du matériel:
                var ownerId = selectedMateriel.ProprietaireId;


                //Affichage du nom u propriétaire dans la combobox dédiée:
                var MateralOwnerId = selectedMateriel.ProprietaireId;
                if (MateralOwnerId > 0)
                {
                    for (int i = 0; i < CBowner.Items.Count; i++)
                    {
                        var item = CBowner.Items[i] as User;
                        if (item != null && item.Id == MateralOwnerId)
                        {
                            CBowner.SelectedItem = item;
                            break;
                        }
                    }
                }

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }

                // Parcours de chaque Catégorie de la liste récupérée par l'API
                foreach (var category in materierialCategories)
                {//Parcour de chaque item de la checkedListBox
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        var item = checkedListBox1.Items[i] as Category;
                        //Si le nom de l'item correspond au nom de la catégorie parcourue:
                        if (item != null && item.Name == category.Name)
                        {//Si les valeurs correspondent l'item est coché:
                            checkedListBox1.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBXnum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FLPcontainerCRUD_Paint(object sender, PaintEventArgs e)
        {

        }
        #region read matériels.
        private async void BTread_Click(object sender, EventArgs e)
        {
            var materials = await _api.GetMaterialsAsync();
            foreach (Materiel materiel in materials)
                _materiels.Add(materiel);
        }
        #endregion
        #region create matériel
        private async void BTcreate_Click(object sender, EventArgs e)
        {

            int userId = (CBowner.SelectedItem as User).Id;
            var materiel = new Materiel()
            {
                Name = TXTname.Text,
                EndGarantee = DTPendGarantee.Value,
                ServiceDat = DTPservDat.Value,
                ProprietaireId = userId,
                categories = checkedListBox1.SelectedItems.Cast<Category>().ToList()
            };

            var material = await _api.CreateMaterielAsync(materiel);
            if (material != null)
            {   //Ajout du nouveau matériel créé à la BindingList _matériels:
                _materiels.Add(material);
                //Récupération de l'index du matériel:
                int newIndex = _materiels.IndexOf(material);

                // Désélection de toutes les lignes.
                DGVmat.ClearSelection();

                //Si l'index est compri entre le premier et le dernier, la ligne sélectionné sera celle du novel index créé:
                if (newIndex >= 0 && newIndex < _materiels.Count)
                {
                    // Sélection de la dernière ligne créée.
                    DGVmat.Rows[newIndex].Selected = true;

                    // Rafraîchir la DataGridView avec une simulation de cli sur le bouton "Read" (BTread):
                    BTread.PerformClick();

                    // Positionnement de la DataGridView sur la ligne de l'élément créé.
                    DGVmat.FirstDisplayedScrollingRowIndex = newIndex;
                    if (newIndex >= 0 && newIndex < _materiels.Count)
                    {


                        // Récupérer l'objet material créé
                        var newCreatedMaterial = _materiels[newIndex];

                        // Afficher les valeurs dans les contrôles
                        TXTname.Text = newCreatedMaterial.Name;
                        DTPendGarantee.Value = newCreatedMaterial.EndGarantee;
                        DTPservDat.Value = newCreatedMaterial.ServiceDat;
                    }

                }
            }
            //Positionnement sur l'élément céé:
            DGVmat.ClearSelection();

            BTread.PerformClick();

            DGVmat.ClearSelection();

            int lastIndex = _materiels.Count - 1;

            if (lastIndex >= 0)
            {
                // Sélectionne la dernière ligne.
                DGVmat.Rows[lastIndex].Selected = true;

                // Fait défiler jusqu'à la dernière ligne.
                DGVmat.FirstDisplayedScrollingRowIndex = lastIndex;

                // Récupére l'objet material créé
                var newCreatedMaterial = _materiels[lastIndex];

                // Affiche les valeurs dans les contrôles
                TXTname.Text = newCreatedMaterial.Name;
                DTPendGarantee.Value = newCreatedMaterial.EndGarantee;
                DTPservDat.Value = newCreatedMaterial.ServiceDat;
            }


        }
        #endregion

        private async void BTupdate_ClickAsync(object sender, EventArgs e)
        {
            if (DTPendGarantee.Value < DTPservDat.Value)
            {
                MessageBox.Show("La date de finde garantie ne peut pas être antérieure à la date de mise en service du matériel.");
                return;
            }

            int userId = (CBowner.SelectedItem as User).Id;
            // Vérification si une ligne est sélectionnée:
            if (DGVmat.SelectedRows.Count > 0)
            {// Récupération de l'index de la ligne sélectionnée:
                var selectedRowIndex = DGVmat.SelectedRows[0].Index;
                // Récupération de l'élément lié à la ligne sélectionnée:
                var selectedMateriel = DGVmat.SelectedRows[0].DataBoundItem as Materiel;
                // Création d'un nouvel objet Materiel avec les valeurs des contrôles de la fenêtre pour la mise à jour:
                var updatedMateriel = new Materiel()


                {
                    Id = selectedMateriel.Id,
                    Name = TXTname.Text,
                    ServiceDat = DTPservDat.Value,
                    EndGarantee = DTPendGarantee.Value,
                    lastUpdate = selectedMateriel.lastUpdate,
                    ProprietaireId = userId,
                    categories = new()
                };



                foreach (var i in checkedListBox1.CheckedItems.Cast<Category>())
                {

                    updatedMateriel.categories.Add(i);

                }


                var material = await _api.UpdateMaterielAsync(updatedMateriel);
                // Vérification que la mise à jour a réussi.
                if (material != null)
                {
                    // Met à jour l'élément dans la liste _materiels:
                    _materiels[selectedRowIndex] = material;

                    // Rafraîchissement de la DataGridView pour afficher les modifications:
                    DGVmat.Refresh();
                    //Message de réussitec:
                    MessageBox.Show("Matériel mis à jour avec succès.");
                    BTread.PerformClick();
                }
                else
                {
                    MessageBox.Show("La mise à jour a échoué.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à mettre à jour.");
            }
        }
        #region delete matériel.
        private async void BTdelete_Click(object sender, EventArgs e)
        {

            if (DGVmat.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show($"Confirmez-vous la suppression du matériel: {DGVmat.CurrentRow.Cells["Name"].Value} ?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int id = (int)DGVmat.CurrentRow.Cells["Id"].Value;
                    var deleted = await _api.DeleteMaterielAsync(id);
                    if (deleted)
                    {// Suppression de l'élément de la BindingList
                        _materiels.RemoveAt(DGVmat.CurrentRow.Index);
                        MessageBox.Show("Matériel supprimé avec succès.");
                        BTread.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("La suppression a échoué.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné.");
            }
        }
        #endregion
        private void TXTowner_TextChanged(object sender, EventArgs e)
        {

        }

        private void TLPmat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlPInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBfltrNameMat_Click(object sender, EventArgs e)
        {

        }
        private void InitializeBinding()
        {
            //Laison de la binding source des matériels avec la binding list dédiée.
            BSMateriels.DataSource = _materiels;
            BSUsers.DataSource = _Users;
            DGVmat.DataSource = BSMateriels;
            DGVmat.Columns[4].Visible = false;
            TXTname.DataBindings.Add("text", BSMateriels, "name", false, DataSourceUpdateMode.Never);

            //DTPendGarantee.DataBindings.Add("Value", _materiels, "endGarantee");
            //DTPservDat.DataBindings.Add("Value", _materiels, "serviceDat");
            CBcategory.DataSource = _categories;




        }

        private async void BTfiltre_Click(object sender, EventArgs e)
        {
            int idCat = (CBcategory.SelectedItem as Category).Reference;
            var materials = await _api.GetMaterielWereCatAsync(idCat);
            foreach (Materiel materiel in materials)
                _materiels.Add(materiel);
        }

        private void CBcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBcategoyChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void DGVmat_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        private async void BTfiltre_Click_1(object sender, EventArgs e)
        {
            var reference = (CBcategory.SelectedItem as Category).Reference;

            var sortedMateriels = await _api.GetMaterielWereCatAsync(reference);
            _materiels.Clear();
            foreach (Materiel m in sortedMateriels)
            {
                _materiels.Add(m);
            }
            DGVmat.Refresh();
        }

        private async void Form2_Load_1(object sender, EventArgs e)
        {//Grisage des bouttons du CRUD en fonction du rôle de l'utilisateur:
            Grisage(BTcreate);
            Grisage(BTupdate);
            Grisage(BTdellete);
            UserRoleAlert();

            IEnumerable<Category> allCategories = await _api.GetCategoriesAsync();
            foreach (Category category in allCategories)
            {
                _categories.Add(category);
            }
            // Vidage de  checkedListBox1:
            checkedListBox1.Items.Clear();
            checkedListBox1.DisplayMember = "Name";
            // Parcours de chaque Category dans la BindingList pour les ajouter à checkedListBox1 comme item:
            foreach (Category category in _categories)
            {// Ajout du nom de la Category comme item
                checkedListBox1.Items.Add(category);

            }
            IEnumerable<User> allUsers = await _api.GetAllUsersAsync();
            foreach (User u in allUsers)
            {
                CBowner.Items.Add(u);
                _Users.Add(u);
            }
            //Simulation du clic sur le bouton de lecture des données.
            BTread.PerformClick();

        }


        private void DTPservDat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBcategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private async void BTsearch_Click(object sender, EventArgs e)
        {
            var keyValue = TXTsearch.Text;
            _materiels.Clear();
            if (string.IsNullOrEmpty(keyValue))
            {
                BTread.PerformClick();
                return;
            }
            //Appel de la fonction GetMaterielByKeyValueAsync de l'API.
            IEnumerable<Materiel> retrievedMateriel = await _api.GetMaterielByKeyValueAsync(keyValue);
            foreach (Materiel m in retrievedMateriel)
            {
                _materiels.Add(m);
            }

        }

        //private void BTcontracts_Click(object sender, EventArgs e)
        //{

        //}

        private void BTcontracts_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();


            form3.UserRole = this._UserRole;

            form3.Show();
        }
    }
}

