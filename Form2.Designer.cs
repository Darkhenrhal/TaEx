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
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSubtaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubTask = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccExpence = new System.Windows.Forms.Label();
            this.lblAccIncome = new System.Windows.Forms.Label();
            this.expenselbl = new System.Windows.Forms.Label();
            this.incomelbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.btnAccSum = new System.Windows.Forms.Button();
            this.frmAccSummary = new System.Windows.Forms.Panel();
            this.lblAccDec = new System.Windows.Forms.Label();
            this.lblAccDescription = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.accountlbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.frmAccSummary.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1212, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.addSubTaskToolStripMenuItem,
            this.deleteAccountToolStripMenuItem,
            this.deleteSubtaskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.newAccountToolStripMenuItem.Text = "New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addSubTaskToolStripMenuItem.Text = "New Subtask";
            this.addSubTaskToolStripMenuItem.Click += new System.EventHandler(this.addSubTaskToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // deleteSubtaskToolStripMenuItem
            // 
            this.deleteSubtaskToolStripMenuItem.Name = "deleteSubtaskToolStripMenuItem";
            this.deleteSubtaskToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.deleteSubtaskToolStripMenuItem.Text = "Delete Subtask";
            this.deleteSubtaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSubtaskToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.btnSubTask);
            this.panel2.Controls.Add(this.btnSummary);
            this.panel2.Controls.Add(this.lblAccBalance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblAccExpence);
            this.panel2.Controls.Add(this.lblAccIncome);
            this.panel2.Controls.Add(this.expenselbl);
            this.panel2.Controls.Add(this.incomelbl);
            this.panel2.Controls.Add(this.Balancelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(417, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 588);
            this.panel2.TabIndex = 4;
            // 
            // btnSubTask
            // 
            this.btnSubTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTask.ForeColor = System.Drawing.Color.White;
            this.btnSubTask.Location = new System.Drawing.Point(500, 647);
            this.btnSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubTask.Name = "btnSubTask";
            this.btnSubTask.Size = new System.Drawing.Size(307, 42);
            this.btnSubTask.TabIndex = 8;
            this.btnSubTask.Text = "Subtask Report";
            this.btnSubTask.UseVisualStyleBackColor = false;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Location = new System.Drawing.Point(66, 647);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(307, 42);
            this.btnSummary.TabIndex = 7;
            this.btnSummary.Text = "Account Report";
            this.btnSummary.UseVisualStyleBackColor = false;
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccBalance.Location = new System.Drawing.Point(373, 283);
            this.lblAccBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(0, 52);
            this.lblAccBalance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(27, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Balance           :";
            // 
            // lblAccExpence
            // 
            this.lblAccExpence.AutoSize = true;
            this.lblAccExpence.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccExpence.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccExpence.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccExpence.Location = new System.Drawing.Point(373, 190);
            this.lblAccExpence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccExpence.Name = "lblAccExpence";
            this.lblAccExpence.Size = new System.Drawing.Size(0, 52);
            this.lblAccExpence.TabIndex = 4;
            // 
            // lblAccIncome
            // 
            this.lblAccIncome.AutoSize = true;
            this.lblAccIncome.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccIncome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccIncome.Location = new System.Drawing.Point(373, 107);
            this.lblAccIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccIncome.Name = "lblAccIncome";
            this.lblAccIncome.Size = new System.Drawing.Size(0, 52);
            this.lblAccIncome.TabIndex = 3;
            // 
            // expenselbl
            // 
            this.expenselbl.AutoSize = true;
            this.expenselbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.expenselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.expenselbl.Location = new System.Drawing.Point(27, 195);
            this.expenselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenselbl.Name = "expenselbl";
            this.expenselbl.Size = new System.Drawing.Size(298, 46);
            this.expenselbl.TabIndex = 1;
            this.expenselbl.Text = "Total Expense :";
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.incomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelbl.Location = new System.Drawing.Point(27, 117);
            this.incomelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(295, 46);
            this.incomelbl.TabIndex = 1;
            this.incomelbl.Text = "Total Income   :";
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(277, 20);
            this.Balancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(333, 51);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Current Balance";
            // 
            // btnAccSum
            // 
            this.btnAccSum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAccSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccSum.ForeColor = System.Drawing.Color.White;
            this.btnAccSum.Location = new System.Drawing.Point(66, 533);
            this.btnAccSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccSum.Name = "btnAccSum";
            this.btnAccSum.Size = new System.Drawing.Size(277, 42);
            this.btnAccSum.TabIndex = 7;
            this.btnAccSum.Text = "Account Report";
            this.btnAccSum.UseVisualStyleBackColor = false;
            this.btnAccSum.Click += new System.EventHandler(this.btnAccSum_Click);
            // 
            // frmAccSummary
            // 
            this.frmAccSummary.BackColor = System.Drawing.Color.Gainsboro;
            this.frmAccSummary.Controls.Add(this.btnAccSum);
            this.frmAccSummary.Controls.Add(this.clearbtn);
            this.frmAccSummary.Controls.Add(this.submitbtn);
            this.frmAccSummary.Controls.Add(this.lblAccDec);
            this.frmAccSummary.Controls.Add(this.lblAccDescription);
            this.frmAccSummary.Controls.Add(this.cmbAccount);
            this.frmAccSummary.Controls.Add(this.accountlbl);
            this.frmAccSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.frmAccSummary.Location = new System.Drawing.Point(0, 28);
            this.frmAccSummary.Margin = new System.Windows.Forms.Padding(4);
            this.frmAccSummary.Name = "frmAccSummary";
            this.frmAccSummary.Size = new System.Drawing.Size(417, 588);
            this.frmAccSummary.TabIndex = 3;
            // 
            // lblAccDec
            // 
            this.lblAccDec.AutoSize = true;
            this.lblAccDec.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccDec.Location = new System.Drawing.Point(34, 190);
            this.lblAccDec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccDec.Name = "lblAccDec";
            this.lblAccDec.Size = new System.Drawing.Size(0, 28);
            this.lblAccDec.TabIndex = 6;
            // 
            // lblAccDescription
            // 
            this.lblAccDescription.AutoSize = true;
            this.lblAccDescription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccDescription.Location = new System.Drawing.Point(62, 242);
            this.lblAccDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccDescription.Name = "lblAccDescription";
            this.lblAccDescription.Size = new System.Drawing.Size(0, 22);
            this.lblAccDescription.TabIndex = 5;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(66, 483);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(127, 42);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click_1);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(216, 483);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(127, 42);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click_1);
            // 
            // cmbAccount
            // 
            this.cmbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "University",
            "Business"});
            this.cmbAccount.Location = new System.Drawing.Point(39, 135);
            this.cmbAccount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(345, 28);
            this.cmbAccount.TabIndex = 1;
            // 
            // accountlbl
            // 
            this.accountlbl.AutoSize = true;
            this.accountlbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlbl.Location = new System.Drawing.Point(34, 93);
            this.accountlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(94, 28);
            this.accountlbl.TabIndex = 0;
            this.accountlbl.Text = "Account";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.frmAccSummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check  Account Details";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.frmAccSummary.ResumeLayout(false);
            this.frmAccSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSubtaskToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSubTask;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccExpence;
        private System.Windows.Forms.Label lblAccIncome;
        private System.Windows.Forms.Label expenselbl;
        private System.Windows.Forms.Label incomelbl;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Panel frmAccSummary;
        private System.Windows.Forms.Label lblAccDec;
        private System.Windows.Forms.Label lblAccDescription;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label accountlbl;
        private System.Windows.Forms.Button btnAccSum;
    }
}