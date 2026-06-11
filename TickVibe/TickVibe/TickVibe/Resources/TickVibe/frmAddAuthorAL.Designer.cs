namespace TickVibe
{
    partial class frmAddAuthorAL
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
            this.btnADDAuthor = new Siticone.UI.WinForms.SiticoneButton();
            this.txtAuthorNameAdd = new Siticone.UI.WinForms.SiticoneTextBox();
            this.lblAuthorNamefrm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.btnADDAuthor);
            this.siticonePanel1.Controls.Add(this.txtAuthorNameAdd);
            this.siticonePanel1.Controls.Add(this.lblAuthorNamefrm);
            this.siticonePanel1.Location = new System.Drawing.Point(2, 2);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(306, 202);
            this.siticonePanel1.TabIndex = 0;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // btnADDAuthor
            // 
            this.btnADDAuthor.CheckedState.Parent = this.btnADDAuthor;
            this.btnADDAuthor.CustomImages.Parent = this.btnADDAuthor;
            this.btnADDAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnADDAuthor.ForeColor = System.Drawing.Color.White;
            this.btnADDAuthor.HoveredState.Parent = this.btnADDAuthor;
            this.btnADDAuthor.Location = new System.Drawing.Point(104, 121);
            this.btnADDAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADDAuthor.Name = "btnADDAuthor";
            this.btnADDAuthor.ShadowDecoration.Parent = this.btnADDAuthor;
            this.btnADDAuthor.Size = new System.Drawing.Size(95, 37);
            this.btnADDAuthor.TabIndex = 2;
            this.btnADDAuthor.Text = "ADD Author";
            this.btnADDAuthor.Click += new System.EventHandler(this.btnADDAuthor_Click);
            // 
            // txtAuthorNameAdd
            // 
            this.txtAuthorNameAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorNameAdd.DefaultText = "";
            this.txtAuthorNameAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthorNameAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthorNameAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthorNameAdd.DisabledState.Parent = this.txtAuthorNameAdd;
            this.txtAuthorNameAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthorNameAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthorNameAdd.FocusedState.Parent = this.txtAuthorNameAdd;
            this.txtAuthorNameAdd.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthorNameAdd.HoveredState.Parent = this.txtAuthorNameAdd;
            this.txtAuthorNameAdd.Location = new System.Drawing.Point(121, 56);
            this.txtAuthorNameAdd.Name = "txtAuthorNameAdd";
            this.txtAuthorNameAdd.PasswordChar = '\0';
            this.txtAuthorNameAdd.PlaceholderText = "";
            this.txtAuthorNameAdd.SelectedText = "";
            this.txtAuthorNameAdd.ShadowDecoration.Parent = this.txtAuthorNameAdd;
            this.txtAuthorNameAdd.Size = new System.Drawing.Size(177, 36);
            this.txtAuthorNameAdd.TabIndex = 1;
            // 
            // lblAuthorNamefrm
            // 
            this.lblAuthorNamefrm.AutoSize = true;
            this.lblAuthorNamefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorNamefrm.Location = new System.Drawing.Point(25, 65);
            this.lblAuthorNamefrm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorNamefrm.Name = "lblAuthorNamefrm";
            this.lblAuthorNamefrm.Size = new System.Drawing.Size(91, 18);
            this.lblAuthorNamefrm.TabIndex = 0;
            this.lblAuthorNamefrm.Text = "AuthorName";
            this.lblAuthorNamefrm.Click += new System.EventHandler(this.lblAuthorNamefrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Author";
            // 
            // frmAddAuthorAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 206);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddAuthorAL";
            this.Text = "frmAddAuthorAL";
            this.Load += new System.EventHandler(this.frmAddAuthorAL_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblAuthorNamefrm;
        private Siticone.UI.WinForms.SiticoneButton btnADDAuthor;
        private Siticone.UI.WinForms.SiticoneTextBox txtAuthorNameAdd;
        private System.Windows.Forms.Label label1;
    }
}