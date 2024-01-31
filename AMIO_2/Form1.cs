using domain.DTO.DTOrequests;
namespace AMIO_2
{
    public partial class Form1 : Form
    {
        private static readonly MaterielApi materielApi = new();
        MaterielApi _api = materielApi;
        ReadTokenValues _extractRole = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TLPformConnection_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void BTvalid_Click(object sender, EventArgs e)
        {
        }

        private async void BTvalid_Click_1(object sender, EventArgs e)
        {
            if (TXTpassword.Text == null || textBox1.Text == null)
            {
                MessageBox.Show("Veuillez renseigner tous les champs du formulaire pour vous connecter.");
            }
            //Création d'un DTOConnectRequest pour envoyer les valeurs
            DTOconnectionRequest UserConnectionValues = new()
            {
                name = textBox1.Text,
                password = TXTpassword.Text
            };
            //Apel de l'api pour la connection:
            string JWToken = await _api.UserConnectFromForm(UserConnectionValues);
            //Extraction du role du user:
            string userRole = _extractRole.GetRoleFromToken(JWToken);
            //Si le rôle de l'utilisateur n'est pas null, la Form2 est ouverte avec l'accessibilité correspondante à son rôle:
            if (userRole != null)
            {
                Form2 form2 = new Form2();
                form2._UserRole = userRole;
                this.Hide();
                form2.Show();
            }
            //Sauvegarde le mail de l'utilisateur si le champ est bien renseigné:
            if (textBox1 != null && TXTpassword != null)
            {
                Properties.Settings.Default.userMail = textBox1.Text;
                Properties.Settings.Default.Save();
            }

            else if (TXTpassword == null || textBox1.Text == null)
            {
                MessageBox.Show("Retentez de vous connecter avec des informations valides.");
                this.Text = "Nouvelle tentative de connection.";
                this.Hide(); // Cache la Form1
                await Task.Delay(1000); // 1 secondes d'attente...

                this.Show(); // Réouvre la Form1

            }
            {//Sauvegarde le mail de l'utilisateur si le champ est bien renseigné:


                Properties.Settings.Default.userMail = textBox1.Text;
                Properties.Settings.Default.Save();
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TXTpassword.PlaceholderText = "votre mot de passe";
            textBox1.PlaceholderText = "email";
            BTvalid.Enabled = false;

            CBpwdVisible.Checked = false;
            string savedMail = Properties.Settings.Default.userMail;
            if (!string.IsNullOrEmpty(savedMail))
            {
                textBox1.Text = savedMail;
                if (CBpwdVisible.Checked != true)
                {
                    TXTpassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void TXTpassword_TextChanged(object sender, EventArgs e)
        {
            if (TXTpassword.Text != null)
            {
                BTvalid.Enabled = true;
            }
        }

        private void CBpwdVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpwdVisible.Checked == true)
            {
                TXTpassword.UseSystemPasswordChar = false;
            }
            else
                TXTpassword.UseSystemPasswordChar = true;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null || TXTpassword.Text == null)
            {
                BTvalid.Enabled = false;
            }
        }

        private void BTvalid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BTvalid.PerformClick();
            }
        }
    }
}