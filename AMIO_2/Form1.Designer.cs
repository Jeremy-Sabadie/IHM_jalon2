namespace AMIO_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TLPMain = new TableLayoutPanel();
            TLPformConnection = new TableLayoutPanel();
            TXTpassword = new TextBox();
            LBpassword = new Label();
            textBox1 = new TextBox();
            LBid = new Label();
            LBconnection = new Label();
            CBpwdVisible = new CheckBox();
            textBox2 = new TextBox();
            BTvalid = new Button();
            TLPMain.SuspendLayout();
            TLPformConnection.SuspendLayout();
            SuspendLayout();
            // 
            // TLPMain
            // 
            TLPMain.ColumnCount = 1;
            TLPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPMain.Controls.Add(TLPformConnection, 0, 0);
            TLPMain.Controls.Add(textBox2, 0, 2);
            TLPMain.Controls.Add(BTvalid, 0, 1);
            TLPMain.Dock = DockStyle.Fill;
            TLPMain.Location = new Point(0, 0);
            TLPMain.Margin = new Padding(2);
            TLPMain.Name = "TLPMain";
            TLPMain.RowCount = 3;
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            TLPMain.Size = new Size(467, 225);
            TLPMain.TabIndex = 0;
            // 
            // TLPformConnection
            // 
            TLPformConnection.ColumnCount = 3;
            TLPformConnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.900709F));
            TLPformConnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.09929F));
            TLPformConnection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            TLPformConnection.Controls.Add(TXTpassword, 1, 4);
            TLPformConnection.Controls.Add(LBpassword, 1, 3);
            TLPformConnection.Controls.Add(textBox1, 1, 2);
            TLPformConnection.Controls.Add(LBid, 1, 1);
            TLPformConnection.Controls.Add(LBconnection, 1, 0);
            TLPformConnection.Controls.Add(CBpwdVisible, 2, 4);
            TLPformConnection.Location = new Point(120, 2);
            TLPformConnection.Margin = new Padding(120, 2, 2, 2);
            TLPformConnection.Name = "TLPformConnection";
            TLPformConnection.RowCount = 5;
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 26.44628F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8760328F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9669418F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 14.34426F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 19.26229F));
            TLPformConnection.Size = new Size(316, 150);
            TLPformConnection.TabIndex = 0;
            // 
            // TXTpassword
            // 
            TXTpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTpassword.Location = new Point(9, 121);
            TXTpassword.Margin = new Padding(2);
            TXTpassword.Name = "TXTpassword";
            TXTpassword.Size = new Size(188, 23);
            TXTpassword.TabIndex = 5;
            TXTpassword.TextChanged += TXTpassword_TextChanged;
            // 
            // LBpassword
            // 
            LBpassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBpassword.AutoSize = true;
            LBpassword.Location = new Point(9, 104);
            LBpassword.Margin = new Padding(2, 0, 2, 0);
            LBpassword.Name = "LBpassword";
            LBpassword.Size = new Size(188, 15);
            LBpassword.TabIndex = 1;
            LBpassword.Text = "Mot de passe";
            LBpassword.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(9, 73);
            textBox1.Margin = new Padding(2, 5, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // LBid
            // 
            LBid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBid.AutoSize = true;
            LBid.Location = new Point(9, 47);
            LBid.Margin = new Padding(2, 0, 2, 0);
            LBid.Name = "LBid";
            LBid.Size = new Size(188, 15);
            LBid.TabIndex = 0;
            LBid.Text = "email";
            LBid.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LBconnection
            // 
            LBconnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBconnection.AutoSize = true;
            LBconnection.Location = new Point(9, 15);
            LBconnection.Margin = new Padding(2, 15, 2, 0);
            LBconnection.Name = "LBconnection";
            LBconnection.Size = new Size(188, 15);
            LBconnection.TabIndex = 4;
            LBconnection.Text = "CONNECTION";
            LBconnection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBpwdVisible
            // 
            CBpwdVisible.AutoSize = true;
            CBpwdVisible.Location = new Point(202, 122);
            CBpwdVisible.Name = "CBpwdVisible";
            CBpwdVisible.Size = new Size(111, 19);
            CBpwdVisible.TabIndex = 6;
            CBpwdVisible.Text = "voir le mot de passe";
            CBpwdVisible.UseVisualStyleBackColor = true;
            CBpwdVisible.CheckedChanged += CBpwdVisible_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(2, 230);
            textBox2.Margin = new Padding(2, 15, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(463, 23);
            textBox2.TabIndex = 3;
            // 
            // BTvalid
            // 
            BTvalid.Location = new Point(180, 164);
            BTvalid.Margin = new Padding(180, 10, 2, 2);
            BTvalid.Name = "BTvalid";
            BTvalid.Size = new Size(76, 29);
            BTvalid.TabIndex = 1;
            BTvalid.Text = "VALIDER";
            BTvalid.UseVisualStyleBackColor = true;
            BTvalid.Click += BTvalid_Click_1;
            BTvalid.KeyPress += BTvalid_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(TLPMain);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Connection";
            Load += Form1_Load;
            TLPMain.ResumeLayout(false);
            TLPMain.PerformLayout();
            TLPformConnection.ResumeLayout(false);
            TLPformConnection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPMain;
        private TableLayoutPanel TLPformConnection;
        private Label LBid;
        private Label LBpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LBconnection;
        private Button BTvalid;
        private TextBox TXTpassword;
        private CheckBox CBpwdVisible;
    }
}