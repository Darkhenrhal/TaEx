namespace Group_11___COSC_31112
{
    partial class Form7
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDatabaseDataSet1 = new Group_11___COSC_31112.projectDatabaseDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.lblAccExpence = new System.Windows.Forms.Label();
            this.lblAccIncome = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.accountTableAdapter = new Group_11___COSC_31112.projectDatabaseDataSet1TableAdapters.AccountTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.projectDatabaseDataSet1;
            // 
            // projectDatabaseDataSet1
            // 
            this.projectDatabaseDataSet1.DataSetName = "projectDatabaseDataSet1";
            this.projectDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Controls.Add(this.lblAccBalance);
            this.panel2.Controls.Add(this.lblAccExpence);
            this.panel2.Controls.Add(this.lblAccIncome);
            this.panel2.Controls.Add(this.Balancelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 704);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Khaki;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.accountBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Group_11___COSC_31112.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 587);
            this.reportViewer1.TabIndex = 7;
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
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(13, 9);
            this.Balancelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(333, 51);
            this.Balancelbl.TabIndex = 0;
            this.Balancelbl.Text = "Current Balance";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1001, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 704);
            this.Controls.Add(this.panel2);
            this.Name = "Form7";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label lblAccExpence;
        private System.Windows.Forms.Label lblAccIncome;
        private System.Windows.Forms.Label Balancelbl;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private projectDatabaseDataSet1 projectDatabaseDataSet1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private projectDatabaseDataSet1TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.Button btnBack;
    }
}