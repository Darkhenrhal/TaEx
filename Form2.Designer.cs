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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incomelbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.expenselbl = new System.Windows.Forms.Label();
            this.accountlbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.catergorylbl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tasklbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.income_rdbtn = new System.Windows.Forms.RadioButton();
            this.expense_rdbtn = new System.Windows.Forms.RadioButton();
            this.submitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.submitbtn);
            this.panel1.Controls.Add(this.expense_rdbtn);
            this.panel1.Controls.Add(this.income_rdbtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.typelbl);
            this.panel1.Controls.Add(this.tasklbl);
            this.panel1.Controls.Add(this.catergorylbl);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.accountlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 426);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.expenselbl);
            this.panel2.Controls.Add(this.incomelbl);
            this.panel2.Controls.Add(this.Balancelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(313, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 426);
            this.panel2.TabIndex = 2;
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.incomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelbl.Location = new System.Drawing.Point(6, 87);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(217, 39);
            this.incomelbl.TabIndex = 1;
            this.incomelbl.Text = "Total Income";
            this.incomelbl.Click += new System.EventHandler(this.incomelbl_Click);
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(158, 24);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(167, 25);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Current Balance";
            // 
            // expenselbl
            // 
            this.expenselbl.AutoSize = true;
            this.expenselbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.expenselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenselbl.Location = new System.Drawing.Point(246, 87);
            this.expenselbl.Name = "expenselbl";
            this.expenselbl.Size = new System.Drawing.Size(238, 39);
            this.expenselbl.TabIndex = 1;
            this.expenselbl.Text = "Total Expense";
            this.expenselbl.Click += new System.EventHandler(this.incomelbl_Click);
            // 
            // accountlbl
            // 
            this.accountlbl.AutoSize = true;
            this.accountlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlbl.Location = new System.Drawing.Point(46, 54);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(66, 19);
            this.accountlbl.TabIndex = 0;
            this.accountlbl.Text = "Account";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "University",
            "Business"});
            this.comboBox1.Location = new System.Drawing.Point(50, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // catergorylbl
            // 
            this.catergorylbl.AutoSize = true;
            this.catergorylbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catergorylbl.Location = new System.Drawing.Point(46, 113);
            this.catergorylbl.Name = "catergorylbl";
            this.catergorylbl.Size = new System.Drawing.Size(78, 19);
            this.catergorylbl.TabIndex = 0;
            this.catergorylbl.Text = "Catergory";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "University",
            "Business"});
            this.comboBox2.Location = new System.Drawing.Point(50, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // tasklbl
            // 
            this.tasklbl.AutoSize = true;
            this.tasklbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasklbl.Location = new System.Drawing.Point(46, 181);
            this.tasklbl.Name = "tasklbl";
            this.tasklbl.Size = new System.Drawing.Size(88, 19);
            this.tasklbl.TabIndex = 0;
            this.tasklbl.Text = "Task Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelbl.Location = new System.Drawing.Point(46, 248);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(88, 19);
            this.typelbl.TabIndex = 0;
            this.typelbl.Text = "Task Name";
            // 
            // income_rdbtn
            // 
            this.income_rdbtn.AutoSize = true;
            this.income_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_rdbtn.Location = new System.Drawing.Point(50, 271);
            this.income_rdbtn.Name = "income_rdbtn";
            this.income_rdbtn.Size = new System.Drawing.Size(69, 20);
            this.income_rdbtn.TabIndex = 3;
            this.income_rdbtn.TabStop = true;
            this.income_rdbtn.Text = "Income";
            this.income_rdbtn.UseVisualStyleBackColor = true;
            // 
            // expense_rdbtn
            // 
            this.expense_rdbtn.AutoSize = true;
            this.expense_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_rdbtn.Location = new System.Drawing.Point(125, 271);
            this.expense_rdbtn.Name = "expense_rdbtn";
            this.expense_rdbtn.Size = new System.Drawing.Size(78, 20);
            this.expense_rdbtn.TabIndex = 3;
            this.expense_rdbtn.TabStop = true;
            this.expense_rdbtn.Text = "Expense";
            this.expense_rdbtn.UseVisualStyleBackColor = true;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(49, 310);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(95, 34);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(150, 310);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(95, 34);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Label tasklbl;
        private System.Windows.Forms.Label catergorylbl;
        private System.Windows.Forms.Button clearbtn;
    }
}