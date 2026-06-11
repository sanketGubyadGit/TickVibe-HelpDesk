
namespace TickVibe
{
    partial class frmForgotPasswordVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPasswordVN));
            this.lblExit = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnReSend = new System.Windows.Forms.Button();
            this.Tmrotp = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtCode2 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.txtCode3 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.txtCode4 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.txtCode5 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.txtCode6 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.lblForgot = new System.Windows.Forms.Label();
            this.txtCode1 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(406, 10);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 18);
            this.lblExit.TabIndex = 12;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(54, 101);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 19);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "User Email ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(54, 231);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(79, 19);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "Enter OTP";
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.White;
            this.txtmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtmail.Location = new System.Drawing.Point(73, 129);
            this.txtmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(268, 34);
            this.txtmail.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(128, 184);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(147, 36);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send OTP";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerify.Location = new System.Drawing.Point(128, 341);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(147, 36);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnReSend
            // 
            this.btnReSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnReSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReSend.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReSend.Location = new System.Drawing.Point(128, 184);
            this.btnReSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReSend.Name = "btnReSend";
            this.btnReSend.Size = new System.Drawing.Size(147, 36);
            this.btnReSend.TabIndex = 21;
            this.btnReSend.Text = "Resend OTP";
            this.btnReSend.UseVisualStyleBackColor = false;
            this.btnReSend.Visible = false;
            this.btnReSend.Click += new System.EventHandler(this.btnReSend_Click);
            // 
            // Tmrotp
            // 
            this.Tmrotp.Interval = 1000;
            this.Tmrotp.Tick += new System.EventHandler(this.Tmrotp_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(161, 311);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "Time";
            this.lblTime.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(193, 311);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(34, 13);
            this.lblCount.TabIndex = 23;
            this.lblCount.Text = "00:00";
            this.lblCount.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtCode2
            // 
            this.txtCode2.BorderColor = System.Drawing.Color.Black;
            this.txtCode2.BorderRadius = 10;
            this.txtCode2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode2.DefaultText = "";
            this.txtCode2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode2.DisabledState.Parent = this.txtCode2;
            this.txtCode2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode2.FocusedState.Parent = this.txtCode2;
            this.txtCode2.ForeColor = System.Drawing.Color.Black;
            this.txtCode2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode2.HoveredState.Parent = this.txtCode2;
            this.txtCode2.Location = new System.Drawing.Point(118, 261);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.PasswordChar = '\0';
            this.txtCode2.PlaceholderText = "";
            this.txtCode2.SelectedText = "";
            this.txtCode2.ShadowDecoration.Parent = this.txtCode2;
            this.txtCode2.Size = new System.Drawing.Size(40, 36);
            this.txtCode2.TabIndex = 26;
            this.txtCode2.TextChanged += new System.EventHandler(this.txtCode2_TextChanged);
            // 
            // txtCode3
            // 
            this.txtCode3.BorderColor = System.Drawing.Color.Black;
            this.txtCode3.BorderRadius = 10;
            this.txtCode3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode3.DefaultText = "";
            this.txtCode3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode3.DisabledState.Parent = this.txtCode3;
            this.txtCode3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode3.FocusedState.Parent = this.txtCode3;
            this.txtCode3.ForeColor = System.Drawing.Color.Black;
            this.txtCode3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode3.HoveredState.Parent = this.txtCode3;
            this.txtCode3.Location = new System.Drawing.Point(163, 261);
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.PasswordChar = '\0';
            this.txtCode3.PlaceholderText = "";
            this.txtCode3.SelectedText = "";
            this.txtCode3.ShadowDecoration.Parent = this.txtCode3;
            this.txtCode3.Size = new System.Drawing.Size(40, 36);
            this.txtCode3.TabIndex = 27;
            this.txtCode3.TextChanged += new System.EventHandler(this.txtCode3_TextChanged);
            // 
            // txtCode4
            // 
            this.txtCode4.BorderColor = System.Drawing.Color.Black;
            this.txtCode4.BorderRadius = 10;
            this.txtCode4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode4.DefaultText = "";
            this.txtCode4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode4.DisabledState.Parent = this.txtCode4;
            this.txtCode4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode4.FocusedState.Parent = this.txtCode4;
            this.txtCode4.ForeColor = System.Drawing.Color.Black;
            this.txtCode4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode4.HoveredState.Parent = this.txtCode4;
            this.txtCode4.Location = new System.Drawing.Point(209, 261);
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.PasswordChar = '\0';
            this.txtCode4.PlaceholderText = "";
            this.txtCode4.SelectedText = "";
            this.txtCode4.ShadowDecoration.Parent = this.txtCode4;
            this.txtCode4.Size = new System.Drawing.Size(40, 36);
            this.txtCode4.TabIndex = 28;
            this.txtCode4.TextChanged += new System.EventHandler(this.txtCode4_TextChanged);
            // 
            // txtCode5
            // 
            this.txtCode5.BorderColor = System.Drawing.Color.Black;
            this.txtCode5.BorderRadius = 10;
            this.txtCode5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode5.DefaultText = "";
            this.txtCode5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode5.DisabledState.Parent = this.txtCode5;
            this.txtCode5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode5.FocusedState.Parent = this.txtCode5;
            this.txtCode5.ForeColor = System.Drawing.Color.Black;
            this.txtCode5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode5.HoveredState.Parent = this.txtCode5;
            this.txtCode5.Location = new System.Drawing.Point(254, 261);
            this.txtCode5.Name = "txtCode5";
            this.txtCode5.PasswordChar = '\0';
            this.txtCode5.PlaceholderText = "";
            this.txtCode5.SelectedText = "";
            this.txtCode5.ShadowDecoration.Parent = this.txtCode5;
            this.txtCode5.Size = new System.Drawing.Size(40, 36);
            this.txtCode5.TabIndex = 29;
            this.txtCode5.TextChanged += new System.EventHandler(this.txtCode5_TextChanged);
            // 
            // txtCode6
            // 
            this.txtCode6.BorderColor = System.Drawing.Color.Black;
            this.txtCode6.BorderRadius = 10;
            this.txtCode6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode6.DefaultText = "";
            this.txtCode6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode6.DisabledState.Parent = this.txtCode6;
            this.txtCode6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode6.FocusedState.Parent = this.txtCode6;
            this.txtCode6.ForeColor = System.Drawing.Color.Black;
            this.txtCode6.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode6.HoveredState.Parent = this.txtCode6;
            this.txtCode6.Location = new System.Drawing.Point(299, 261);
            this.txtCode6.Name = "txtCode6";
            this.txtCode6.PasswordChar = '\0';
            this.txtCode6.PlaceholderText = "";
            this.txtCode6.SelectedText = "";
            this.txtCode6.ShadowDecoration.Parent = this.txtCode6;
            this.txtCode6.Size = new System.Drawing.Size(40, 36);
            this.txtCode6.TabIndex = 30;
            this.txtCode6.TextChanged += new System.EventHandler(this.txtCode6_TextChanged);
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel2.BorderRadius = 10;
            this.siticoneGradientPanel2.BorderThickness = 2;
            this.siticoneGradientPanel2.Controls.Add(this.lblForgot);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode1);
            this.siticoneGradientPanel2.Controls.Add(this.lblExit);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode6);
            this.siticoneGradientPanel2.Controls.Add(this.txtmail);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode5);
            this.siticoneGradientPanel2.Controls.Add(this.lblEmail);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode4);
            this.siticoneGradientPanel2.Controls.Add(this.lblCode);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode3);
            this.siticoneGradientPanel2.Controls.Add(this.btnSend);
            this.siticoneGradientPanel2.Controls.Add(this.txtCode2);
            this.siticoneGradientPanel2.Controls.Add(this.btnVerify);
            this.siticoneGradientPanel2.Controls.Add(this.btnReSend);
            this.siticoneGradientPanel2.Controls.Add(this.lblCount);
            this.siticoneGradientPanel2.Controls.Add(this.lblTime);
            this.siticoneGradientPanel2.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.Color.SteelBlue;
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(215, 87);
            this.siticoneGradientPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(438, 432);
            this.siticoneGradientPanel2.TabIndex = 31;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.BackColor = System.Drawing.Color.Transparent;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.Location = new System.Drawing.Point(97, 30);
            this.lblForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(258, 30);
            this.lblForgot.TabIndex = 32;
            this.lblForgot.Text = "Forgot Your PassWord ?";
            // 
            // txtCode1
            // 
            this.txtCode1.BorderColor = System.Drawing.Color.Black;
            this.txtCode1.BorderRadius = 10;
            this.txtCode1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode1.DefaultText = "";
            this.txtCode1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode1.DisabledState.Parent = this.txtCode1;
            this.txtCode1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode1.FocusedState.Parent = this.txtCode1;
            this.txtCode1.ForeColor = System.Drawing.Color.Black;
            this.txtCode1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode1.HoveredState.Parent = this.txtCode1;
            this.txtCode1.Location = new System.Drawing.Point(73, 261);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.PasswordChar = '\0';
            this.txtCode1.PlaceholderText = "";
            this.txtCode1.SelectedText = "";
            this.txtCode1.ShadowDecoration.Parent = this.txtCode1;
            this.txtCode1.Size = new System.Drawing.Size(40, 36);
            this.txtCode1.TabIndex = 31;
            this.txtCode1.TextChanged += new System.EventHandler(this.txtCode1_TextChanged_1);
            // 
            // frmForgotPasswordVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TickVibe.Properties.Resources.WhatsApp_Image_2026_06_08_at_7_57_09_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 610);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmForgotPasswordVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.forgot_Load);
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnReSend;
        private System.Windows.Forms.Timer Tmrotp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode2;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode3;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode4;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode5;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode6;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private Siticone.UI.WinForms.SiticoneTextBox txtCode1;
        private System.Windows.Forms.Label lblForgot;
    }
}