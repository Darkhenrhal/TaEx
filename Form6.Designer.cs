namespace Group_11___COSC_31112
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.frmDeleteSubTask = new System.Windows.Forms.Panel();
            this.cmbSubName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccNameofSub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelSub = new System.Windows.Forms.Button();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConfirmSavedAcc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDetailedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSubtaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDeleteSubTask.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmDeleteSubTask
            // 
            this.frmDeleteSubTask.BackColor = System.Drawing.Color.LightGreen;
            this.frmDeleteSubTask.Controls.Add(this.cmbSubName);
            this.frmDeleteSubTask.Controls.Add(this.label2);
            this.frmDeleteSubTask.Controls.Add(this.cmbAccNameofSub);
            this.frmDeleteSubTask.Controls.Add(this.label1);
            this.frmDeleteSubTask.Controls.Add(this.label3);
            this.frmDeleteSubTask.Controls.Add(this.btnDelSub);
            this.frmDeleteSubTask.Controls.Add(this.Balancelbl);
            this.frmDeleteSubTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmDeleteSubTask.Location = new System.Drawing.Point(417, 28);
            this.frmDeleteSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.frmDeleteSubTask.Name = "frmDeleteSubTask";
            this.frmDeleteSubTask.Size = new System.Drawing.Size(687, 560);
            this.frmDeleteSubTask.TabIndex = 11;
            // 
            // cmbSubName
            // 
            this.cmbSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbSubName.FormattingEnabled = true;
            this.cmbSubName.Location = new System.Drawing.Point(245, 219);
            this.cmbSubName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubName.Name = "cmbSubName";
            this.cmbSubName.Size = new System.Drawing.Size(387, 33);
            this.cmbSubName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Subtask";
            // 
            // cmbAccNameofSub
            // 
            this.cmbAccNameofSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbAccNameofSub.FormattingEnabled = true;
            this.cmbAccNameofSub.Items.AddRange(new object[] {
            "Advertising",
            "Consulting Fees",
            "Employee Salaries",
            "Equipment Maintenance",
            "Insurance",
            "Legal and Consultation Fees",
            "Marketing",
            "Office Supplies",
            "Rent/Mortgage",
            "Repairs and Maintenance",
            "Travel and Accommodation",
            "Utilities",
            "Affiliate Marketing",
            "Consulting Revenue",
            "Dividends",
            "Grants and Sponsorships",
            "Interest Income",
            "Investment Income",
            "Product Sales",
            "Rental Income",
            "Royalties",
            "Service Revenue"});
            this.cmbAccNameofSub.Location = new System.Drawing.Point(245, 141);
            this.cmbAccNameofSub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccNameofSub.Name = "cmbAccNameofSub";
            this.cmbAccNameofSub.Size = new System.Drawing.Size(387, 33);
            this.cmbAccNameofSub.TabIndex = 13;
            this.cmbAccNameofSub.SelectedIndexChanged += new System.EventHandler(this.cmbAccNameofSub_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coution : After delete Subtask you will not be able to recover the\r\n             " +
    "   data of that Subtask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Account";
            // 
            // btnDelSub
            // 
            this.btnDelSub.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelSub.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSub.ForeColor = System.Drawing.Color.White;
            this.btnDelSub.Location = new System.Drawing.Point(443, 499);
            this.btnDelSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelSub.Name = "btnDelSub";
            this.btnDelSub.Size = new System.Drawing.Size(187, 42);
            this.btnDelSub.TabIndex = 4;
            this.btnDelSub.Text = "Delete";
            this.btnDelSub.UseVisualStyleBackColor = false;
            this.btnDelSub.Click += new System.EventHandler(this.btnDelSub_Click_1);
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(219, 18);
            this.Balancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(199, 31);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Delete Subtask";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblConfirmSavedAcc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 560);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblConfirmSavedAcc
            // 
            this.lblConfirmSavedAcc.AutoSize = true;
            this.lblConfirmSavedAcc.BackColor = System.Drawing.Color.LightGreen;
            this.lblConfirmSavedAcc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmSavedAcc.Location = new System.Drawing.Point(23, 508);
            this.lblConfirmSavedAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmSavedAcc.Name = "lblConfirmSavedAcc";
            this.lblConfirmSavedAcc.Size = new System.Drawing.Size(0, 24);
            this.lblConfirmSavedAcc.TabIndex = 7;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDetailedReportToolStripMenuItem,
            this.newAccountToolStripMenuItem1,
            this.addSubTaskToolStripMenuItem,
            this.deleteSubtaskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // getDetailedReportToolStripMenuItem
            // 
            this.getDetailedReportToolStripMenuItem.Name = "getDetailedReportToolStripMenuItem";
            this.getDetailedReportToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.getDetailedReportToolStripMenuItem.Text = "Home";
            this.getDetailedReportToolStripMenuItem.Click += new System.EventHandler(this.getDetailedReportToolStripMenuItem_Click_1);
            // 
            // newAccountToolStripMenuItem1
            // 
            this.newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            this.newAccountToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.newAccountToolStripMenuItem1.Text = "New Account";
            this.newAccountToolStripMenuItem1.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addSubTaskToolStripMenuItem.Text = "New Sub Task";
            this.addSubTaskToolStripMenuItem.Click += new System.EventHandler(this.addSubTaskToolStripMenuItem_Click);
            // 
            // deleteSubtaskToolStripMenuItem
            // 
            this.deleteSubtaskToolStripMenuItem.Name = "deleteSubtaskToolStripMenuItem";
            this.deleteSubtaskToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.deleteSubtaskToolStripMenuItem.Text = "Delete Account";
            this.deleteSubtaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSubtaskToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 588);
            this.Controls.Add(this.frmDeleteSubTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form6";
            this.Text = "Delete Subtask";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.frmDeleteSubTask.ResumeLayout(false);
            this.frmDeleteSubTask.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frmDeleteSubTask;
        private System.Windows.Forms.ComboBox cmbAccNameofSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelSub;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConfirmSavedAcc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSubtaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSubName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem getDetailedReportToolStripMenuItem;
    }
}