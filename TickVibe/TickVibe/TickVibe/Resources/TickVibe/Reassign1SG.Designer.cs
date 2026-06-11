namespace TickVibe
{
    partial class Reassign1SG
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.lblTicketCode = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltext2 = new System.Windows.Forms.Label();
            this.siticoneMaterialTextBox1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblTicketCodeAC = new System.Windows.Forms.Label();
            this.lblCurrentAssign = new System.Windows.Forms.Label();
            this.cmbNewAgents = new Siticone.UI.WinForms.SiticoneComboBox();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(315, 40);
            this.lblheading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(201, 31);
            this.lblheading.TabIndex = 1;
            this.lblheading.Text = "Reassign Ticket";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(274, 88);
            this.lbltext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(291, 20);
            this.lbltext.TabIndex = 2;
            this.lbltext.Text = "Reassign Ticket To another Agents";
            // 
            // lblTicketCode
            // 
            this.lblTicketCode.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblTicketCode.AutoSize = true;
            this.lblTicketCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCode.Location = new System.Drawing.Point(162, 141);
            this.lblTicketCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketCode.Name = "lblTicketCode";
            this.lblTicketCode.Size = new System.Drawing.Size(104, 20);
            this.lblTicketCode.TabIndex = 3;
            this.lblTicketCode.Text = "Ticket Code";
            this.lblTicketCode.Click += new System.EventHandler(this.lblTicketCode_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(158, 200);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrent.Size = new System.Drawing.Size(128, 20);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current Assign";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Agents";
            // 
            // lbltext2
            // 
            this.lbltext2.AutoSize = true;
            this.lbltext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext2.Location = new System.Drawing.Point(162, 358);
            this.lbltext2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltext2.Name = "lbltext2";
            this.lbltext2.Size = new System.Drawing.Size(183, 20);
            this.lbltext2.TabIndex = 8;
            this.lbltext2.Text = "Reason For Reassign";
            // 
            // siticoneMaterialTextBox1
            // 
            this.siticoneMaterialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneMaterialTextBox1.DefaultText = "";
            this.siticoneMaterialTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Location = new System.Drawing.Point(158, 418);
            this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
            this.siticoneMaterialTextBox1.PasswordChar = '\0';
            this.siticoneMaterialTextBox1.PlaceholderText = "";
            this.siticoneMaterialTextBox1.SelectedText = "";
            this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Size = new System.Drawing.Size(544, 50);
            this.siticoneMaterialTextBox1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(437, 499);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAssign.Location = new System.Drawing.Point(298, 499);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(79, 38);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Reassign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblTicketCodeAC
            // 
            this.lblTicketCodeAC.AutoSize = true;
            this.lblTicketCodeAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCodeAC.Location = new System.Drawing.Point(583, 141);
            this.lblTicketCodeAC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketCodeAC.Name = "lblTicketCodeAC";
            this.lblTicketCodeAC.Size = new System.Drawing.Size(57, 20);
            this.lblTicketCodeAC.TabIndex = 12;
            this.lblTicketCodeAC.Text = "label2";
            // 
            // lblCurrentAssign
            // 
            this.lblCurrentAssign.AutoSize = true;
            this.lblCurrentAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAssign.Location = new System.Drawing.Point(583, 200);
            this.lblCurrentAssign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentAssign.Name = "lblCurrentAssign";
            this.lblCurrentAssign.Size = new System.Drawing.Size(57, 20);
            this.lblCurrentAssign.TabIndex = 13;
            this.lblCurrentAssign.Text = "label2";
            // 
            // cmbNewAgents
            // 
            this.cmbNewAgents.BackColor = System.Drawing.Color.Transparent;
            this.cmbNewAgents.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNewAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewAgents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNewAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNewAgents.FormattingEnabled = true;
            this.cmbNewAgents.HoveredState.Parent = this.cmbNewAgents;
            this.cmbNewAgents.ItemHeight = 30;
            this.cmbNewAgents.ItemsAppearance.Parent = this.cmbNewAgents;
            this.cmbNewAgents.Location = new System.Drawing.Point(532, 269);
            this.cmbNewAgents.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNewAgents.Name = "cmbNewAgents";
            this.cmbNewAgents.ShadowDecoration.Parent = this.cmbNewAgents;
            this.cmbNewAgents.Size = new System.Drawing.Size(160, 36);
            this.cmbNewAgents.TabIndex = 14;
            this.cmbNewAgents.SelectedIndexChanged += new System.EventHandler(this.cmbNewAgents_SelectedIndexChanged);
            // 
            // Reassign1SG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 645);
            this.Controls.Add(this.cmbNewAgents);
            this.Controls.Add(this.lblCurrentAssign);
            this.Controls.Add(this.lblTicketCodeAC);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.siticoneMaterialTextBox1);
            this.Controls.Add(this.lbltext2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblTicketCode);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.lblheading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Reassign1SG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reassign1SG";
            this.Load += new System.EventHandler(this.Reassign1SG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblTicketCode;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltext2;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblTicketCodeAC;
        private System.Windows.Forms.Label lblCurrentAssign;
        private Siticone.UI.WinForms.SiticoneComboBox cmbNewAgents;
    }
}