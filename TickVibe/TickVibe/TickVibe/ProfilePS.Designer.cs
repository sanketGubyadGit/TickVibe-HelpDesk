namespace TickVibe
{
    partial class ProfilePS
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
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.lblLogOut = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblChangePassword = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblEditProfile = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.lblLogOut);
            this.siticonePanel1.Controls.Add(this.lblChangePassword);
            this.siticonePanel1.Controls.Add(this.lblEditProfile);
            this.siticonePanel1.Location = new System.Drawing.Point(4, 3);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(164, 173);
            this.siticonePanel1.TabIndex = 8;
            //this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // lblLogOut
            // 
            this.lblLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(0, 108);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(164, 42);
            this.lblLogOut.TabIndex = 2;
            this.lblLogOut.Text = "Log Out";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChangePassword.ForeColor = System.Drawing.Color.White;
            this.lblChangePassword.Location = new System.Drawing.Point(0, 59);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(164, 42);
            this.lblChangePassword.TabIndex = 1;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblEditProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblEditProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblEditProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblEditProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEditProfile.ForeColor = System.Drawing.Color.White;
            this.lblEditProfile.Location = new System.Drawing.Point(0, 11);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(164, 42);
            this.lblEditProfile.TabIndex = 0;
            this.lblEditProfile.Text = "Edit Profile";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // ProfilePS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 186);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProfilePS";
            this.Load += new System.EventHandler(this.ProfilePS_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton lblLogOut;
        private Siticone.Desktop.UI.WinForms.SiticoneButton lblChangePassword;
        private Siticone.Desktop.UI.WinForms.SiticoneButton lblEditProfile;
    }
}