namespace AMIO_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            TLPmat = new TableLayoutPanel();
            DGVmat = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            BTupdate = new Button();
            BTread = new Button();
            BTcreate = new Button();
            BTdellete = new Button();
            FLPcontainerCRUD = new FlowLayoutPanel();
            tlPFilterChoices = new TableLayoutPanel();
            TXTname = new TextBox();
            LBmatName = new Label();
            DTPservDat = new DateTimePicker();
            LBgserviceDat = new Label();
            DTPendGarantee = new DateTimePicker();
            LBendGarantee = new Label();
            LBownerName = new Label();
            LBcategoryMateriel = new Label();
            checkedListBox1 = new CheckedListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            CBcategory = new ComboBox();
            LBfltrNameMat = new Label();
            CBowner = new ComboBox();
            BTfiltre = new Button();
            label1 = new Label();
            TXTsearch = new TextBox();
            BTsearch = new Button();
            BTcontracts = new Button();
            BSMateriels = new BindingSource(components);
            BSUsers = new BindingSource(components);
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            FLPcontainerCRUD.SuspendLayout();
            tlPFilterChoices.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSMateriels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSUsers).BeginInit();
            SuspendLayout();
            // 
            // TLPmat
            // 
            TLPmat.ColumnCount = 1;
            TLPmat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPmat.Controls.Add(DGVmat, 0, 0);
            TLPmat.Controls.Add(tableLayoutPanel1, 0, 3);
            TLPmat.Controls.Add(FLPcontainerCRUD, 0, 2);
            TLPmat.Dock = DockStyle.Fill;
            TLPmat.Location = new Point(0, 0);
            TLPmat.Margin = new Padding(2);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 4;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5795135F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 2.0100503F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 62.53369F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            TLPmat.Size = new Size(784, 461);
            TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            DGVmat.AllowUserToResizeColumns = false;
            DGVmat.AllowUserToResizeRows = false;
            DGVmat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.GridColor = SystemColors.ControlLight;
            DGVmat.Location = new Point(2, 2);
            DGVmat.Margin = new Padding(2);
            DGVmat.Name = "DGVmat";
            DGVmat.ReadOnly = true;
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 20;
            DGVmat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVmat.Size = new Size(780, 128);
            DGVmat.TabIndex = 0;
            DGVmat.CellContentClick += DGVmat_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.1326523F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.87755F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4285717F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.17347F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.15306F));
            tableLayoutPanel1.Controls.Add(BTupdate, 2, 0);
            tableLayoutPanel1.Controls.Add(BTread, 1, 0);
            tableLayoutPanel1.Controls.Add(BTcreate, 0, 0);
            tableLayoutPanel1.Controls.Add(BTdellete, 3, 0);
            tableLayoutPanel1.Location = new Point(55, 373);
            tableLayoutPanel1.Margin = new Padding(55, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(727, 64);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BTupdate
            // 
            BTupdate.Image = Properties.Resources.refresh_arrow_15461;
            BTupdate.ImageAlign = ContentAlignment.BottomCenter;
            BTupdate.Location = new Point(274, 0);
            BTupdate.Margin = new Padding(0);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(58, 48);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.TextAlign = ContentAlignment.TopCenter;
            BTupdate.UseVisualStyleBackColor = true;
            BTupdate.Click += BTupdate_ClickAsync;
            // 
            // BTread
            // 
            BTread.Image = Properties.Resources.read;
            BTread.ImageAlign = ContentAlignment.BottomCenter;
            BTread.Location = new Point(138, 0);
            BTread.Margin = new Padding(0);
            BTread.Name = "BTread";
            BTread.Size = new Size(58, 48);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.TextAlign = ContentAlignment.TopCenter;
            BTread.UseVisualStyleBackColor = true;
            BTread.Click += BTread_Click;
            // 
            // BTcreate
            // 
            BTcreate.Image = Properties.Resources.create;
            BTcreate.ImageAlign = ContentAlignment.BottomCenter;
            BTcreate.Location = new Point(0, 0);
            BTcreate.Margin = new Padding(0);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(58, 48);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.TextAlign = ContentAlignment.TopCenter;
            BTcreate.UseVisualStyleBackColor = true;
            BTcreate.Click += BTcreate_Click;
            // 
            // BTdellete
            // 
            BTdellete.Image = (Image)resources.GetObject("BTdellete.Image");
            BTdellete.ImageAlign = ContentAlignment.BottomCenter;
            BTdellete.Location = new Point(428, 0);
            BTdellete.Margin = new Padding(0);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(58, 48);
            BTdellete.TabIndex = 3;
            BTdellete.Text = "DELETE";
            BTdellete.TextAlign = ContentAlignment.TopCenter;
            BTdellete.UseVisualStyleBackColor = true;
            BTdellete.Click += BTdelete_Click;
            // 
            // FLPcontainerCRUD
            // 
            FLPcontainerCRUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FLPcontainerCRUD.Controls.Add(tlPFilterChoices);
            FLPcontainerCRUD.Controls.Add(BTcontracts);
            FLPcontainerCRUD.Location = new Point(2, 141);
            FLPcontainerCRUD.Margin = new Padding(2);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(780, 228);
            FLPcontainerCRUD.TabIndex = 1;
            // 
            // tlPFilterChoices
            // 
            tlPFilterChoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tlPFilterChoices.ColumnCount = 4;
            tlPFilterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.65873F));
            tlPFilterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.34127F));
            tlPFilterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tlPFilterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlPFilterChoices.Controls.Add(TXTname, 1, 0);
            tlPFilterChoices.Controls.Add(LBmatName, 0, 0);
            tlPFilterChoices.Controls.Add(DTPservDat, 1, 1);
            tlPFilterChoices.Controls.Add(LBgserviceDat, 0, 1);
            tlPFilterChoices.Controls.Add(DTPendGarantee, 1, 2);
            tlPFilterChoices.Controls.Add(LBendGarantee, 0, 2);
            tlPFilterChoices.Controls.Add(LBownerName, 0, 3);
            tlPFilterChoices.Controls.Add(LBcategoryMateriel, 0, 4);
            tlPFilterChoices.Controls.Add(checkedListBox1, 1, 4);
            tlPFilterChoices.Controls.Add(tableLayoutPanel2, 3, 3);
            tlPFilterChoices.Controls.Add(CBowner, 1, 3);
            tlPFilterChoices.Controls.Add(BTfiltre, 3, 4);
            tlPFilterChoices.Controls.Add(label1, 3, 0);
            tlPFilterChoices.Controls.Add(TXTsearch, 3, 1);
            tlPFilterChoices.Controls.Add(BTsearch, 3, 2);
            tlPFilterChoices.Location = new Point(0, 2);
            tlPFilterChoices.Margin = new Padding(0, 2, 2, 2);
            tlPFilterChoices.Name = "tlPFilterChoices";
            tlPFilterChoices.RowCount = 5;
            tlPFilterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20.108696F));
            tlPFilterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6335411F));
            tlPFilterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 21.73913F));
            tlPFilterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 39.7515526F));
            tlPFilterChoices.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlPFilterChoices.Size = new Size(687, 225);
            tlPFilterChoices.TabIndex = 4;
            // 
            // TXTname
            // 
            TXTname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTname.Location = new Point(215, 2);
            TXTname.Margin = new Padding(2);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(283, 23);
            TXTname.TabIndex = 4;
            // 
            // LBmatName
            // 
            LBmatName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBmatName.AutoSize = true;
            LBmatName.Location = new Point(116, 0);
            LBmatName.Margin = new Padding(2, 0, 2, 0);
            LBmatName.Name = "LBmatName";
            LBmatName.Size = new Size(95, 15);
            LBmatName.TabIndex = 1;
            LBmatName.Text = "nom du matériel";
            // 
            // DTPservDat
            // 
            DTPservDat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DTPservDat.Location = new Point(215, 34);
            DTPservDat.Margin = new Padding(2);
            DTPservDat.MinDate = new DateTime(2023, 12, 16, 0, 0, 0, 0);
            DTPservDat.Name = "DTPservDat";
            DTPservDat.Size = new Size(283, 23);
            DTPservDat.TabIndex = 6;
            DTPservDat.ValueChanged += DTPservDat_ValueChanged;
            // 
            // LBgserviceDat
            // 
            LBgserviceDat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBgserviceDat.AutoSize = true;
            LBgserviceDat.Location = new Point(82, 32);
            LBgserviceDat.Margin = new Padding(2, 0, 2, 0);
            LBgserviceDat.Name = "LBgserviceDat";
            LBgserviceDat.Size = new Size(129, 15);
            LBgserviceDat.TabIndex = 2;
            LBgserviceDat.Text = "date de mise en service";
            // 
            // DTPendGarantee
            // 
            DTPendGarantee.Location = new Point(215, 64);
            DTPendGarantee.Margin = new Padding(2);
            DTPendGarantee.Name = "DTPendGarantee";
            DTPendGarantee.Size = new Size(283, 23);
            DTPendGarantee.TabIndex = 7;
            // 
            // LBendGarantee
            // 
            LBendGarantee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBendGarantee.AutoSize = true;
            LBendGarantee.Location = new Point(86, 62);
            LBendGarantee.Margin = new Padding(2, 0, 2, 0);
            LBendGarantee.Name = "LBendGarantee";
            LBendGarantee.Size = new Size(125, 15);
            LBendGarantee.TabIndex = 3;
            LBendGarantee.Text = "date de fin de garantie";
            // 
            // LBownerName
            // 
            LBownerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBownerName.AutoSize = true;
            LBownerName.Location = new Point(143, 97);
            LBownerName.Margin = new Padding(2, 0, 2, 0);
            LBownerName.Name = "LBownerName";
            LBownerName.Size = new Size(68, 15);
            LBownerName.TabIndex = 9;
            LBownerName.Text = "propriétaire";
            LBownerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LBcategoryMateriel
            // 
            LBcategoryMateriel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBcategoryMateriel.AutoSize = true;
            LBcategoryMateriel.Location = new Point(139, 167);
            LBcategoryMateriel.Margin = new Padding(3, 5, 3, 0);
            LBcategoryMateriel.Name = "LBcategoryMateriel";
            LBcategoryMateriel.Size = new Size(71, 15);
            LBcategoryMateriel.TabIndex = 13;
            LBcategoryMateriel.Text = "Catégorie(s)";
            LBcategoryMateriel.TextAlign = ContentAlignment.TopRight;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(215, 164);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(283, 59);
            checkedListBox1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CBcategory, 0, 1);
            tableLayoutPanel2.Controls.Add(LBfltrNameMat, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(539, 100);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5964928F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.4035072F));
            tableLayoutPanel2.Size = new Size(145, 59);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // CBcategory
            // 
            CBcategory.FormattingEnabled = true;
            CBcategory.Items.AddRange(new object[] { "toutes" });
            CBcategory.Location = new Point(2, 24);
            CBcategory.Margin = new Padding(2);
            CBcategory.Name = "CBcategory";
            CBcategory.Size = new Size(136, 23);
            CBcategory.TabIndex = 11;
            CBcategory.SelectedIndexChanged += CBcategory_SelectedIndexChanged_1;
            // 
            // LBfltrNameMat
            // 
            LBfltrNameMat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LBfltrNameMat.AutoSize = true;
            LBfltrNameMat.Location = new Point(10, 7);
            LBfltrNameMat.Margin = new Padding(10, 0, 2, 0);
            LBfltrNameMat.Name = "LBfltrNameMat";
            LBfltrNameMat.Size = new Size(111, 15);
            LBfltrNameMat.TabIndex = 10;
            LBfltrNameMat.Text = "Filtrer par Catégorie";
            LBfltrNameMat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBowner
            // 
            CBowner.DisplayMember = "Name";
            CBowner.FormattingEnabled = true;
            CBowner.Location = new Point(216, 100);
            CBowner.Name = "CBowner";
            CBowner.Size = new Size(121, 23);
            CBowner.TabIndex = 19;
            // 
            // BTfiltre
            // 
            BTfiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTfiltre.ImageAlign = ContentAlignment.BottomCenter;
            BTfiltre.Location = new Point(536, 187);
            BTfiltre.Margin = new Padding(0, 0, 0, 10);
            BTfiltre.Name = "BTfiltre";
            BTfiltre.Size = new Size(143, 28);
            BTfiltre.TabIndex = 4;
            BTfiltre.Text = "APPLIQUER LE FILTRE";
            BTfiltre.TextAlign = ContentAlignment.TopCenter;
            BTfiltre.UseVisualStyleBackColor = true;
            BTfiltre.Click += BTfiltre_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(539, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 20;
            label1.Text = "recherche par valeur clef";
            // 
            // TXTsearch
            // 
            TXTsearch.Dock = DockStyle.Fill;
            TXTsearch.Location = new Point(539, 35);
            TXTsearch.Name = "TXTsearch";
            TXTsearch.PlaceholderText = "SAISISSEZ UNE VALEUR";
            TXTsearch.Size = new Size(145, 23);
            TXTsearch.TabIndex = 21;
            // 
            // BTsearch
            // 
            BTsearch.Location = new Point(566, 65);
            BTsearch.Margin = new Padding(30, 3, 3, 3);
            BTsearch.Name = "BTsearch";
            BTsearch.Size = new Size(80, 29);
            BTsearch.TabIndex = 22;
            BTsearch.Text = "rechercher";
            BTsearch.UseVisualStyleBackColor = true;
            BTsearch.Click += BTsearch_Click;
            // 
            // BTcontracts
            // 
            BTcontracts.Location = new Point(691, 2);
            BTcontracts.Margin = new Padding(2);
            BTcontracts.Name = "BTcontracts";
            BTcontracts.Size = new Size(76, 55);
            BTcontracts.TabIndex = 5;
            BTcontracts.Text = "voir les contrats";
            BTcontracts.UseVisualStyleBackColor = true;
            BTcontracts.Click += BTcontracts_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(TLPmat);
            Margin = new Padding(2);
            MinimumSize = new Size(736, 481);
            Name = "Form2";
            Text = "Materiel";
            Load += Form2_Load_1;
            TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVmat).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            FLPcontainerCRUD.ResumeLayout(false);
            tlPFilterChoices.ResumeLayout(false);
            tlPFilterChoices.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSMateriels).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPmat;
        private DataGridView DGVmat;
        private FlowLayoutPanel FLPcontainerCRUD;
        private Button BTcreate;
        private Button BTread;
        private Button BTupdate;
        private Button BTdellete;
        private BindingSource BSMateriels;
        private TableLayoutPanel tlPFilterChoices;
        private Label LBmatName;
        private Label LBgserviceDat;
        private Label LBendGarantee;
        private TextBox TXTname;
        private DateTimePicker DTPservDat;
        private DateTimePicker DTPendGarantee;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTfiltre;
        private Label LBownerName;
        private Label LBfltrNameMat;
        private Label LBfiltrBy;
        private ComboBox CBcategory;
        private BindingSource BSUsers;
        private Label LBcategoryMateriel;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox checkedListBox1;
        private ComboBox CBowner;
        private Label label1;
        private TextBox TXTsearch;
        private Button BTsearch;
        private Button BTcontracts;
    }
}