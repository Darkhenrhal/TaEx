namespace Group_11___COSC_31112
{
    partial class deleteAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteAcc));
            this.frmaddNewAcc = new System.Windows.Forms.Panel();
            this.cmbAccName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelAcc = new System.Windows.Forms.Button();
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
            this.frmaddNewAcc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmaddNewAcc
            // 
            this.frmaddNewAcc.BackColor = System.Drawing.Color.LightGreen;
            this.frmaddNewAcc.Controls.Add(this.cmbAccName);
            this.frmaddNewAcc.Controls.Add(this.label1);
            this.frmaddNewAcc.Controls.Add(this.label3);
            this.frmaddNewAcc.Controls.Add(this.btnDelAcc);
            this.frmaddNewAcc.Controls.Add(this.Balancelbl);
            this.frmaddNewAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmaddNewAcc.Location = new System.Drawing.Point(417, 28);
            this.frmaddNewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.frmaddNewAcc.Name = "frmaddNewAcc";
            this.frmaddNewAcc.Size = new System.Drawing.Size(682, 567);
            this.frmaddNewAcc.TabIndex = 8;
            // 
            // cmbAccName
            // 
            this.cmbAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbAccName.FormattingEnabled = true;
            this.cmbAccName.Items.AddRange(new object[] {
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
            this.cmbAccName.Location = new System.Drawing.Point(245, 141);
            this.cmbAccName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccName.Name = "cmbAccName";
            this.cmbAccName.Size = new System.Drawing.Size(387, 33);
            this.cmbAccName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coution : After delete Account you will not be able to recover the\r\n             " +
    "   data of that Account ";
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
            // btnDelAcc
            // 
            this.btnDelAcc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelAcc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAcc.ForeColor = System.Drawing.Color.White;
            this.btnDelAcc.Location = new System.Drawing.Point(443, 499);
            this.btnDelAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(187, 42);
            this.btnDelAcc.TabIndex = 4;
            this.btnDelAcc.Text = "Delete";
            this.btnDelAcc.UseVisualStyleBackColor = false;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
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
            this.Balancelbl.Text = "Delete Account";
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
            this.panel1.Size = new System.Drawing.Size(417, 567);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 104);
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
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 6;
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
            this.getDetailedReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getDetailedReportToolStripMenuItem.Text = "Home";
            this.getDetailedReportToolStripMenuItem.Click += new System.EventHandler(this.getDetailedReportToolStripMenuItem_Click_1);
            // 
            // newAccountToolStripMenuItem1
            // 
            this.newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            this.newAccountToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.newAccountToolStripMenuItem1.Text = "New Account";
            this.newAccountToolStripMenuItem1.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addSubTaskToolStripMenuItem.Text = "New Sub Task";
            this.addSubTaskToolStripMenuItem.Click += new System.EventHandler(this.addSubTaskToolStripMenuItem_Click);
            // 
            // deleteSubtaskToolStripMenuItem
            // 
            this.deleteSubtaskToolStripMenuItem.Name = "deleteSubtaskToolStripMenuItem";
            this.deleteSubtaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteSubtaskToolStripMenuItem.Text = "Delete Subtask";
            this.deleteSubtaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSubtaskToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // deleteAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 595);
            this.Controls.Add(this.frmaddNewAcc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "deleteAcc";
            this.Text = "Delete Account";
            this.Load += new System.EventHandler(this.deleteAcc_Load);
            this.frmaddNewAcc.ResumeLayout(false);
            this.frmaddNewAcc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frmaddNewAcc;
        private System.Windows.Forms.ComboBox cmbAccName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConfirmSavedAcc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSubtaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDetailedReportToolStripMenuItem;
    }
}