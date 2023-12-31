namespace Group_11___COSC_31112
{
    partial class frmAddNewSubT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewSubT));
            this.frmaddNewAcc = new System.Windows.Forms.Panel();
            this.cmbSubTCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDatabaseDataSet = new Group_11___COSC_31112.projectDatabaseDataSet();
            this.txtNewSubDesc = new System.Windows.Forms.TextBox();
            this.txtNewSubT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewSubT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.subNewSubT = new System.Windows.Forms.Button();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConfirmSavedAcc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSubtaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDetailedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTableAdapter = new Group_11___COSC_31112.projectDatabaseDataSetTableAdapters.AccountTableAdapter();
            this.frmaddNewAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmaddNewAcc
            // 
            this.frmaddNewAcc.BackColor = System.Drawing.Color.LightGreen;
            this.frmaddNewAcc.Controls.Add(this.cmbSubTCat);
            this.frmaddNewAcc.Controls.Add(this.label5);
            this.frmaddNewAcc.Controls.Add(this.txtAmount);
            this.frmaddNewAcc.Controls.Add(this.label4);
            this.frmaddNewAcc.Controls.Add(this.cmbAccounts);
            this.frmaddNewAcc.Controls.Add(this.txtNewSubDesc);
            this.frmaddNewAcc.Controls.Add(this.txtNewSubT);
            this.frmaddNewAcc.Controls.Add(this.label1);
            this.frmaddNewAcc.Controls.Add(this.label2);
            this.frmaddNewAcc.Controls.Add(this.btnAddNewSubT);
            this.frmaddNewAcc.Controls.Add(this.label3);
            this.frmaddNewAcc.Controls.Add(this.subNewSubT);
            this.frmaddNewAcc.Controls.Add(this.Balancelbl);
            this.frmaddNewAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmaddNewAcc.Location = new System.Drawing.Point(417, 28);
            this.frmaddNewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.frmaddNewAcc.Name = "frmaddNewAcc";
            this.frmaddNewAcc.Size = new System.Drawing.Size(674, 578);
            this.frmaddNewAcc.TabIndex = 8;
            // 
            // cmbSubTCat
            // 
            this.cmbSubTCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbSubTCat.FormattingEnabled = true;
            this.cmbSubTCat.Items.AddRange(new object[] {
            "Income",
            "Expence"});
            this.cmbSubTCat.Location = new System.Drawing.Point(245, 294);
            this.cmbSubTCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubTCat.Name = "cmbSubTCat";
            this.cmbSubTCat.Size = new System.Drawing.Size(213, 33);
            this.cmbSubTCat.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Catagary";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(245, 223);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(385, 30);
            this.txtAmount.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.DataSource = this.accountBindingSource;
            this.cmbAccounts.DisplayMember = "Account_name";
            this.cmbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(245, 151);
            this.cmbAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(385, 33);
            this.cmbAccounts.TabIndex = 12;
            this.cmbAccounts.ValueMember = "Account_name";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.projectDatabaseDataSet;
            // 
            // projectDatabaseDataSet
            // 
            this.projectDatabaseDataSet.DataSetName = "projectDatabaseDataSet";
            this.projectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNewSubDesc
            // 
            this.txtNewSubDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSubDesc.Location = new System.Drawing.Point(44, 377);
            this.txtNewSubDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewSubDesc.Multiline = true;
            this.txtNewSubDesc.Name = "txtNewSubDesc";
            this.txtNewSubDesc.Size = new System.Drawing.Size(588, 110);
            this.txtNewSubDesc.TabIndex = 11;
            // 
            // txtNewSubT
            // 
            this.txtNewSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSubT.Location = new System.Drawing.Point(245, 91);
            this.txtNewSubT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewSubT.Name = "txtNewSubT";
            this.txtNewSubT.Size = new System.Drawing.Size(385, 30);
            this.txtNewSubT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sub Task  Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account";
            // 
            // btnAddNewSubT
            // 
            this.btnAddNewSubT.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSubT.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSubT.Location = new System.Drawing.Point(245, 507);
            this.btnAddNewSubT.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewSubT.Name = "btnAddNewSubT";
            this.btnAddNewSubT.Size = new System.Drawing.Size(187, 42);
            this.btnAddNewSubT.TabIndex = 4;
            this.btnAddNewSubT.Text = "New";
            this.btnAddNewSubT.UseVisualStyleBackColor = false;
            this.btnAddNewSubT.Click += new System.EventHandler(this.btnAddNewSubT_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sub Task Name";
            // 
            // subNewSubT
            // 
            this.subNewSubT.BackColor = System.Drawing.Color.DodgerBlue;
            this.subNewSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNewSubT.ForeColor = System.Drawing.Color.White;
            this.subNewSubT.Location = new System.Drawing.Point(460, 508);
            this.subNewSubT.Margin = new System.Windows.Forms.Padding(4);
            this.subNewSubT.Name = "subNewSubT";
            this.subNewSubT.Size = new System.Drawing.Size(187, 42);
            this.subNewSubT.TabIndex = 4;
            this.subNewSubT.Text = "Submit";
            this.subNewSubT.UseVisualStyleBackColor = false;
            this.subNewSubT.Click += new System.EventHandler(this.subNewSubT_Click_1);
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(219, 18);
            this.Balancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(241, 31);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Add new Sub Task\r\n";
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
            this.panel1.Size = new System.Drawing.Size(417, 578);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 379);
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
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAcc,
            this.deleteAccountToolStripMenuItem,
            this.deleteSubtaskToolStripMenuItem,
            this.getDetailedReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newAcc
            // 
            this.newAcc.Name = "newAcc";
            this.newAcc.Size = new System.Drawing.Size(225, 26);
            this.newAcc.Text = "New Account";
            this.newAcc.Click += new System.EventHandler(this.newAcc_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // deleteSubtaskToolStripMenuItem
            // 
            this.deleteSubtaskToolStripMenuItem.Name = "deleteSubtaskToolStripMenuItem";
            this.deleteSubtaskToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteSubtaskToolStripMenuItem.Text = "Delete Subtask";
            this.deleteSubtaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSubtaskToolStripMenuItem_Click);
            // 
            // getDetailedReportToolStripMenuItem
            // 
            this.getDetailedReportToolStripMenuItem.Name = "getDetailedReportToolStripMenuItem";
            this.getDetailedReportToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.getDetailedReportToolStripMenuItem.Text = "Get Detailed Report";
            this.getDetailedReportToolStripMenuItem.Click += new System.EventHandler(this.getDetailedReportToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddNewSubT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 606);
            this.Controls.Add(this.frmaddNewAcc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewSubT";
            this.Text = "Add New Subtask";
            this.Load += new System.EventHandler(this.frmAddNewSubT_Load);
            this.frmaddNewAcc.ResumeLayout(false);
            this.frmaddNewAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.TextBox txtNewSubDesc;
        private System.Windows.Forms.TextBox txtNewSubT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewSubT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button subNewSubT;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConfirmSavedAcc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAcc;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private projectDatabaseDataSet projectDatabaseDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private projectDatabaseDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.TextBox txtAmount;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSubTCat;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSubtaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDetailedReportToolStripMenuItem;
    }
}