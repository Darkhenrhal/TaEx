namespace Group_11___COSC_31112
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAccSummary = new System.Windows.Forms.Panel();
            this.clearbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.expense_rdbtn = new System.Windows.Forms.RadioButton();
            this.income_rdbtn = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.catergorylbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expenselbl = new System.Windows.Forms.Label();
            this.incomelbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.frmAccSummary.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.editAccontsToolStripMenuItem,
            this.addSubTaskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmAccSummary
            // 
            this.frmAccSummary.BackColor = System.Drawing.Color.Gainsboro;
            this.frmAccSummary.Controls.Add(this.clearbtn);
            this.frmAccSummary.Controls.Add(this.submitbtn);
            this.frmAccSummary.Controls.Add(this.expense_rdbtn);
            this.frmAccSummary.Controls.Add(this.income_rdbtn);
            this.frmAccSummary.Controls.Add(this.comboBox2);
            this.frmAccSummary.Controls.Add(this.catergorylbl);
            this.frmAccSummary.Controls.Add(this.comboBox1);
            this.frmAccSummary.Controls.Add(this.accountlbl);
            this.frmAccSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.frmAccSummary.Location = new System.Drawing.Point(0, 28);
            this.frmAccSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmAccSummary.Name = "frmAccSummary";
            this.frmAccSummary.Size = new System.Drawing.Size(417, 526);
            this.frmAccSummary.TabIndex = 1;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(214, 437);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(127, 42);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(65, 437);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(127, 42);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            // 
            // expense_rdbtn
            // 
            this.expense_rdbtn.AutoSize = true;
            this.expense_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_rdbtn.Location = new System.Drawing.Point(67, 269);
            this.expense_rdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_rdbtn.Name = "expense_rdbtn";
            this.expense_rdbtn.Size = new System.Drawing.Size(94, 24);
            this.expense_rdbtn.TabIndex = 3;
            this.expense_rdbtn.TabStop = true;
            this.expense_rdbtn.Text = "Expense";
            this.expense_rdbtn.UseVisualStyleBackColor = true;
            // 
            // income_rdbtn
            // 
            this.income_rdbtn.AutoSize = true;
            this.income_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_rdbtn.Location = new System.Drawing.Point(67, 223);
            this.income_rdbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.income_rdbtn.Name = "income_rdbtn";
            this.income_rdbtn.Size = new System.Drawing.Size(84, 24);
            this.income_rdbtn.TabIndex = 3;
            this.income_rdbtn.TabStop = true;
            this.income_rdbtn.Text = "Income";
            this.income_rdbtn.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "University",
            "Business"});
            this.comboBox2.Location = new System.Drawing.Point(67, 167);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // catergorylbl
            // 
            this.catergorylbl.AutoSize = true;
            this.catergorylbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catergorylbl.Location = new System.Drawing.Point(61, 139);
            this.catergorylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catergorylbl.Name = "catergorylbl";
            this.catergorylbl.Size = new System.Drawing.Size(97, 24);
            this.catergorylbl.TabIndex = 0;
            this.catergorylbl.Text = "Catergory";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "University",
            "Business"});
            this.comboBox1.Location = new System.Drawing.Point(67, 95);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // accountlbl
            // 
            this.accountlbl.AutoSize = true;
            this.accountlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlbl.Location = new System.Drawing.Point(61, 66);
            this.accountlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(80, 24);
            this.accountlbl.TabIndex = 0;
            this.accountlbl.Text = "Account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.expenselbl);
            this.panel2.Controls.Add(this.incomelbl);
            this.panel2.Controls.Add(this.Balancelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(417, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 526);
            this.panel2.TabIndex = 2;
            // 
            // expenselbl
            // 
            this.expenselbl.AutoSize = true;
            this.expenselbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.expenselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenselbl.Location = new System.Drawing.Point(328, 107);
            this.expenselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenselbl.Name = "expenselbl";
            this.expenselbl.Size = new System.Drawing.Size(300, 52);
            this.expenselbl.TabIndex = 1;
            this.expenselbl.Text = "Total Expense";
            this.expenselbl.Click += new System.EventHandler(this.incomelbl_Click);
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.incomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelbl.Location = new System.Drawing.Point(8, 107);
            this.incomelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(274, 52);
            this.incomelbl.TabIndex = 1;
            this.incomelbl.Text = "Total Income";
            this.incomelbl.Click += new System.EventHandler(this.incomelbl_Click);
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(211, 30);
            this.Balancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(210, 31);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Current Balance";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newAccountToolStripMenuItem.Text = "New Account";
            // 
            // editAccontsToolStripMenuItem
            // 
            this.editAccontsToolStripMenuItem.Name = "editAccontsToolStripMenuItem";
            this.editAccontsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editAccontsToolStripMenuItem.Text = "Edit Acconts";
            this.editAccontsToolStripMenuItem.Click += new System.EventHandler(this.editAccontsToolStripMenuItem_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addSubTaskToolStripMenuItem.Text = "Add Sub Task";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.frmAccSummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check  Account Details";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.frmAccSummary.ResumeLayout(false);
            this.frmAccSummary.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel frmAccSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Label incomelbl;
        private System.Windows.Forms.Label expenselbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label accountlbl;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.RadioButton expense_rdbtn;
        private System.Windows.Forms.RadioButton income_rdbtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label catergorylbl;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
    }
}