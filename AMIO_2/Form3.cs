using System.ComponentModel;


namespace AMIO_2
{
    public partial class Form3 : Form
    {
        public string UserRole;
        BindingList<Contract> _contracts = new();
        private string _UserRole { get; set; }
        private void Grisage(Control element)
        {
            if (_UserRole == "user")
            {
                element.Enabled = false;
            }
            else element.Enabled = true;
        }
        public Form3()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void LBstart_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (UserRole == "user") { this.Text = "Utilisateur: consultation des contrats."; }
            else if (UserRole == "admin") { this.Text = "Administration des contrats."; }
        }
        private void InitializeBinding()
        {//Liaison de la BindingSource àla Binding List:
            BScontract.DataSource = _contracts;
            //Liaison du numéric up and down de l'id du contrat.
            NUIDid.DataBindings.Add("Value", BScontract, "ContractId", false, DataSourceUpdateMode.Never);
            //Liaison de la text box du nom du contrat.
            TXTname.DataBindings.Add("text", BScontract, "Name", false, DataSourceUpdateMode.Never);
            //Liaison du datetime picker du début de contrat:
            DTPstart.DataBindings.Add("Value", BScontract, "StartDate", false, DataSourceUpdateMode.Never);
            //Liaison du datetime picker de la fin de contrat:
            DTPend.DataBindings.Add("Value", BScontract, "EndDate", false, DataSourceUpdateMode.Never);
            //Liaison de la text box de la description du contrat.
            TXTdescription.DataBindings.Add("text", BScontract, "Description", false, DataSourceUpdateMode.Never);
        }

        private void BTdelete_Click(object sender, EventArgs e)
        {

        }
    }
}
