namespace AMIO_2
{
    partial class Form3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            DTPend = new DateTimePicker();
            DTPstart = new DateTimePicker();
            NUIDid = new NumericUpDown();
            TXTname = new TextBox();
            LBid = new Label();
            LBname = new Label();
            LBstart = new Label();
            LBend = new Label();
            LBdescription = new Label();
            TXTdescription = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            BTcreate = new Button();
            BTread = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            BTupdate = new Button();
            BTdelete = new Button();
            DGVcontracts = new DataGridView();
            BScontract = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUIDid).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVcontracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BScontract).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(DGVcontracts, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.9278F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.0722F));
            tableLayoutPanel1.Size = new Size(569, 277);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(DTPend, 1, 3);
            tableLayoutPanel2.Controls.Add(DTPstart, 1, 2);
            tableLayoutPanel2.Controls.Add(NUIDid, 1, 0);
            tableLayoutPanel2.Controls.Add(TXTname, 1, 1);
            tableLayoutPanel2.Controls.Add(LBid, 0, 0);
            tableLayoutPanel2.Controls.Add(LBname, 0, 1);
            tableLayoutPanel2.Controls.Add(LBstart, 0, 2);
            tableLayoutPanel2.Controls.Add(LBend, 0, 3);
            tableLayoutPanel2.Controls.Add(LBdescription, 0, 4);
            tableLayoutPanel2.Controls.Add(TXTdescription, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.29032F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new Size(280, 162);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // DTPend
            // 
            DTPend.Location = new Point(142, 106);
            DTPend.Margin = new Padding(2);
            DTPend.Name = "DTPend";
            DTPend.Size = new Size(136, 23);
            DTPend.TabIndex = 3;
            // 
            // DTPstart
            // 
            DTPstart.Dock = DockStyle.Fill;
            DTPstart.Location = new Point(142, 69);
            DTPstart.Margin = new Padding(2);
            DTPstart.Name = "DTPstart";
            DTPstart.Size = new Size(136, 23);
            DTPstart.TabIndex = 2;
            // 
            // NUIDid
            // 
            NUIDid.Location = new Point(142, 2);
            NUIDid.Margin = new Padding(2);
            NUIDid.Name = "NUIDid";
            NUIDid.Size = new Size(111, 23);
            NUIDid.TabIndex = 4;
            // 
            // TXTname
            // 
            TXTname.Dock = DockStyle.Fill;
            TXTname.Location = new Point(142, 28);
            TXTname.Margin = new Padding(2);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(136, 23);
            TXTname.TabIndex = 5;
            // 
            // LBid
            // 
            LBid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBid.AutoSize = true;
            LBid.Location = new Point(82, 0);
            LBid.Margin = new Padding(2, 0, 2, 0);
            LBid.Name = "LBid";
            LBid.Size = new Size(56, 15);
            LBid.TabIndex = 6;
            LBid.Text = "référence";
            // 
            // LBname
            // 
            LBname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBname.AutoSize = true;
            LBname.Location = new Point(48, 26);
            LBname.Margin = new Padding(2, 0, 2, 0);
            LBname.Name = "LBname";
            LBname.Size = new Size(90, 15);
            LBname.TabIndex = 7;
            LBname.Text = "nom du contrat";
            // 
            // LBstart
            // 
            LBstart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBstart.AutoSize = true;
            LBstart.Location = new Point(42, 67);
            LBstart.Margin = new Padding(2, 0, 2, 0);
            LBstart.Name = "LBstart";
            LBstart.Size = new Size(96, 15);
            LBstart.TabIndex = 8;
            LBstart.Text = "début du contrat";
            LBstart.Click += LBstart_Click;
            // 
            // LBend
            // 
            LBend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBend.AutoSize = true;
            LBend.Location = new Point(59, 104);
            LBend.Margin = new Padding(2, 0, 2, 0);
            LBend.Name = "LBend";
            LBend.Size = new Size(79, 15);
            LBend.TabIndex = 9;
            LBend.Text = "fin du contrat";
            // 
            // LBdescription
            // 
            LBdescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBdescription.AutoSize = true;
            LBdescription.Location = new Point(72, 138);
            LBdescription.Margin = new Padding(2, 0, 2, 0);
            LBdescription.Name = "LBdescription";
            LBdescription.Size = new Size(66, 15);
            LBdescription.TabIndex = 10;
            LBdescription.Text = "description";
            // 
            // TXTdescription
            // 
            TXTdescription.Dock = DockStyle.Fill;
            TXTdescription.Location = new Point(142, 140);
            TXTdescription.Margin = new Padding(2);
            TXTdescription.Name = "TXTdescription";
            TXTdescription.Size = new Size(136, 23);
            TXTdescription.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0456848F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9543152F));
            tableLayoutPanel4.Controls.Add(BTcreate, 0, 0);
            tableLayoutPanel4.Controls.Add(BTread, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 188);
            tableLayoutPanel4.Margin = new Padding(2, 22, 2, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(280, 89);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // BTcreate
            // 
            BTcreate.Location = new Point(2, 2);
            BTcreate.Margin = new Padding(2);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(88, 55);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "créer";
            BTcreate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            BTread.Location = new Point(150, 2);
            BTread.Margin = new Padding(2);
            BTread.Name = "BTread";
            BTread.Size = new Size(88, 55);
            BTread.TabIndex = 1;
            BTread.Text = "actualiser";
            BTread.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BTupdate, 0, 0);
            tableLayoutPanel3.Controls.Add(BTdelete, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(303, 188);
            tableLayoutPanel3.Margin = new Padding(19, 22, 2, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(264, 89);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // BTupdate
            // 
            BTupdate.Location = new Point(2, 2);
            BTupdate.Margin = new Padding(2);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(88, 55);
            BTupdate.TabIndex = 0;
            BTupdate.Text = "mettre à jour";
            BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTdelete
            // 
            BTdelete.Location = new Point(134, 2);
            BTdelete.Margin = new Padding(2);
            BTdelete.Name = "BTdelete";
            BTdelete.Size = new Size(88, 55);
            BTdelete.TabIndex = 1;
            BTdelete.Text = "supprimer";
            BTdelete.UseVisualStyleBackColor = true;
            BTdelete.Click += BTdelete_Click;
            // 
            // DGVcontracts
            // 
            DGVcontracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVcontracts.Location = new Point(286, 2);
            DGVcontracts.Margin = new Padding(2);
            DGVcontracts.Name = "DGVcontracts";
            DGVcontracts.RowHeadersWidth = 72;
            DGVcontracts.Size = new Size(281, 110);
            DGVcontracts.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 277);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUIDid).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVcontracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)BScontract).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TXTdescription;
        private DateTimePicker DTPstart;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DGVcontracts;
        private DateTimePicker DTPend;
        private NumericUpDown NUIDid;
        private TextBox TXTname;
        private Label LBid;
        private Label LBname;
        private Label LBstart;
        private Label LBend;
        private Label LBdescription;
        private Button BTupdate;
        private Button BTdelete;
        private Button BTcreate;
        private Button BTread;
        private BindingSource BScontract;
    }
}