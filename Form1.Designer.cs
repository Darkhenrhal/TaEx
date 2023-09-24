namespace Group_11___COSC_31112
{
    partial class Log
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Signbtn = new System.Windows.Forms.Button();
            this.Logbtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.AcceptBx = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.Signbtn);
            this.panel1.Controls.Add(this.Logbtn);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.AcceptBx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(489, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 450);
            this.panel1.TabIndex = 1;
            // 
            // Signbtn
            // 
            this.Signbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Signbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signbtn.Location = new System.Drawing.Point(158, 238);
            this.Signbtn.Name = "Signbtn";
            this.Signbtn.Size = new System.Drawing.Size(82, 34);
            this.Signbtn.TabIndex = 3;
            this.Signbtn.Text = "Sign In ";
            this.Signbtn.UseVisualStyleBackColor = false;
            this.Signbtn.Click += new System.EventHandler(this.Signbtn_Click);
            // 
            // Logbtn
            // 
            this.Logbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Logbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbtn.Location = new System.Drawing.Point(51, 238);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(82, 34);
            this.Logbtn.TabIndex = 3;
            this.Logbtn.Text = "Log In";
            this.Logbtn.UseVisualStyleBackColor = false;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(51, 162);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(189, 27);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(51, 92);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(189, 27);
            this.usernameTxt.TabIndex = 2;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcceptBx
            // 
            this.AcceptBx.AutoSize = true;
            this.AcceptBx.Location = new System.Drawing.Point(32, 303);
            this.AcceptBx.Name = "AcceptBx";
            this.AcceptBx.Size = new System.Drawing.Size(267, 17);
            this.AcceptBx.TabIndex = 1;
            this.AcceptBx.Text = "I have read and accepted the terms and conditions";
            this.AcceptBx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Group_11___COSC_31112.Properties.Resources.Home_Page;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 450);
            this.panel2.TabIndex = 2;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Money Manager";
            this.Load += new System.EventHandler(this.Log_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.CheckBox AcceptBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button Signbtn;
        private System.Windows.Forms.Panel panel2;
    }
}

