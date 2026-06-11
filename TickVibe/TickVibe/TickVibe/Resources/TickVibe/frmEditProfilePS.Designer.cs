namespace TickVibe
{
    partial class frmEditProfilePS
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtProfilePhoto = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblCompanyCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblProfilePhoto = new System.Windows.Forms.Label();
            this.lblPINCODE = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEditPeofileSetting = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCCode = new System.Windows.Forms.Label();
            this.lblUCode = new System.Windows.Forms.Label();
            this.lblFEProfile = new System.Windows.Forms.Label();
            this.lblEProfile = new System.Windows.Forms.Label();
            this.lblEPFilePath = new System.Windows.Forms.LinkLabel();
            this.pcbEditProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 186);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 23);
            this.txtName.TabIndex = 17;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(263, 216);
            this.txtEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.ReadOnly = true;
            this.txtEmailID.Size = new System.Drawing.Size(185, 23);
            this.txtEmailID.TabIndex = 18;
            this.txtEmailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailID_KeyPress);
            this.txtEmailID.Leave += new System.EventHandler(this.txtEmailID_Leave);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(263, 256);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(128, 23);
            this.txtContactNo.TabIndex = 19;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtProfilePhoto
            // 
            this.txtProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfilePhoto.Location = new System.Drawing.Point(263, 336);
            this.txtProfilePhoto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfilePhoto.Name = "txtProfilePhoto";
            this.txtProfilePhoto.Size = new System.Drawing.Size(185, 23);
            this.txtProfilePhoto.TabIndex = 20;
            this.txtProfilePhoto.TextChanged += new System.EventHandler(this.txtProfilePhoto_TextChanged);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(263, 301);
            this.txtPinCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPinCode.MaxLength = 6;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(128, 23);
            this.txtPinCode.TabIndex = 21;
            this.txtPinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPinCode_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(615, 285);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(125, 24);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.DisplayMember = "it";
            this.cmbbxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.IntegralHeight = false;
            this.cmbbxCountry.ItemHeight = 18;
            this.cmbbxCountry.Location = new System.Drawing.Point(615, 184);
            this.cmbbxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(110, 26);
            this.cmbbxCountry.TabIndex = 24;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(615, 216);
            this.cmbbxState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(110, 26);
            this.cmbbxState.TabIndex = 25;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(615, 249);
            this.cmbbxCity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(110, 26);
            this.cmbbxCity.TabIndex = 26;
            this.cmbbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbbxCity_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(226, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCode.Location = new System.Drawing.Point(164, 115);
            this.lblUserCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(79, 17);
            this.lblUserCode.TabIndex = 45;
            this.lblUserCode.Text = "UserCode";
            // 
            // lblCompanyCode
            // 
            this.lblCompanyCode.AutoSize = true;
            this.lblCompanyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyCode.Location = new System.Drawing.Point(162, 152);
            this.lblCompanyCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyCode.Name = "lblCompanyCode";
            this.lblCompanyCode.Size = new System.Drawing.Size(116, 17);
            this.lblCompanyCode.TabIndex = 46;
            this.lblCompanyCode.Text = "Company Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(164, 184);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name";
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailID.Location = new System.Drawing.Point(164, 221);
            this.lblEmailID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(67, 17);
            this.lblEmailID.TabIndex = 48;
            this.lblEmailID.Text = "Email ID";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(164, 260);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(88, 17);
            this.lblContactNo.TabIndex = 49;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblProfilePhoto
            // 
            this.lblProfilePhoto.AutoSize = true;
            this.lblProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilePhoto.Location = new System.Drawing.Point(164, 336);
            this.lblProfilePhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilePhoto.Name = "lblProfilePhoto";
            this.lblProfilePhoto.Size = new System.Drawing.Size(102, 17);
            this.lblProfilePhoto.TabIndex = 50;
            this.lblProfilePhoto.Text = "Profile Photo";
            // 
            // lblPINCODE
            // 
            this.lblPINCODE.AutoSize = true;
            this.lblPINCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPINCODE.Location = new System.Drawing.Point(166, 303);
            this.lblPINCODE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPINCODE.Name = "lblPINCODE";
            this.lblPINCODE.Size = new System.Drawing.Size(81, 17);
            this.lblPINCODE.TabIndex = 51;
            this.lblPINCODE.Text = "PIN CODE";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(504, 150);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(120, 17);
            this.lblCompanyName.TabIndex = 52;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(506, 189);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 17);
            this.lblCountry.TabIndex = 53;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(506, 221);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 17);
            this.lblState.TabIndex = 54;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(509, 254);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 55;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(512, 288);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 56;
            this.lblAddress.Text = "Address";
            // 
            // lblEditPeofileSetting
            // 
            this.lblEditPeofileSetting.AutoSize = true;
            this.lblEditPeofileSetting.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPeofileSetting.Location = new System.Drawing.Point(388, 54);
            this.lblEditPeofileSetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditPeofileSetting.Name = "lblEditPeofileSetting";
            this.lblEditPeofileSetting.Size = new System.Drawing.Size(127, 25);
            this.lblEditPeofileSetting.TabIndex = 59;
            this.lblEditPeofileSetting.Text = "Edit Profile ";
            this.lblEditPeofileSetting.Click += new System.EventHandler(this.lblEditPeofileSetting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblCName);
            this.panel1.Controls.Add(this.lblCCode);
            this.panel1.Controls.Add(this.lblUCode);
            this.panel1.Controls.Add(this.lblFEProfile);
            this.panel1.Controls.Add(this.lblEProfile);
            this.panel1.Controls.Add(this.lblEPFilePath);
            this.panel1.Controls.Add(this.pcbEditProfile);
            this.panel1.Controls.Add(this.lblEditPeofileSetting);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.lblPINCODE);
            this.panel1.Controls.Add(this.lblProfilePhoto);
            this.panel1.Controls.Add(this.lblContactNo);
            this.panel1.Controls.Add(this.lblEmailID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCompanyCode);
            this.panel1.Controls.Add(this.lblUserCode);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbbxCity);
            this.panel1.Controls.Add(this.cmbbxState);
            this.panel1.Controls.Add(this.cmbbxCountry);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPinCode);
            this.panel1.Controls.Add(this.txtProfilePhoto);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.txtEmailID);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(260, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(441, 520);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TickVibe.Properties.Resources.close___Copy2;
            this.pictureBox2.Location = new System.Drawing.Point(939, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(639, 150);
            this.lblCName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(54, 17);
            this.lblCName.TabIndex = 66;
            this.lblCName.Text = "CName";
            // 
            // lblCCode
            // 
            this.lblCCode.AutoSize = true;
            this.lblCCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCode.Location = new System.Drawing.Point(288, 150);
            this.lblCCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCode.Name = "lblCCode";
            this.lblCCode.Size = new System.Drawing.Size(50, 17);
            this.lblCCode.TabIndex = 65;
            this.lblCCode.Text = "CCode";
            this.lblCCode.Click += new System.EventHandler(this.lblCCode_Click);
            // 
            // lblUCode
            // 
            this.lblUCode.AutoSize = true;
            this.lblUCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCode.Location = new System.Drawing.Point(288, 115);
            this.lblUCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUCode.Name = "lblUCode";
            this.lblUCode.Size = new System.Drawing.Size(51, 17);
            this.lblUCode.TabIndex = 64;
            this.lblUCode.Text = "UCode";
            // 
            // lblFEProfile
            // 
            this.lblFEProfile.AutoSize = true;
            this.lblFEProfile.Location = new System.Drawing.Point(649, 409);
            this.lblFEProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFEProfile.Name = "lblFEProfile";
            this.lblFEProfile.Size = new System.Drawing.Size(43, 13);
            this.lblFEProfile.TabIndex = 63;
            this.lblFEProfile.Text = "EProfile";
            this.lblFEProfile.Visible = false;
            // 
            // lblEProfile
            // 
            this.lblEProfile.AutoSize = true;
            this.lblEProfile.Location = new System.Drawing.Point(646, 394);
            this.lblEProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEProfile.Name = "lblEProfile";
            this.lblEProfile.Size = new System.Drawing.Size(23, 13);
            this.lblEProfile.TabIndex = 62;
            this.lblEProfile.Text = "File";
            this.lblEProfile.Visible = false;
            // 
            // lblEPFilePath
            // 
            this.lblEPFilePath.AutoSize = true;
            this.lblEPFilePath.Location = new System.Drawing.Point(644, 427);
            this.lblEPFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEPFilePath.Name = "lblEPFilePath";
            this.lblEPFilePath.Size = new System.Drawing.Size(55, 13);
            this.lblEPFilePath.TabIndex = 61;
            this.lblEPFilePath.TabStop = true;
            this.lblEPFilePath.Text = "linkLabel1";
            this.lblEPFilePath.Visible = false;
            this.lblEPFilePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEPFilePath_LinkClicked);
            // 
            // pcbEditProfile
            // 
            this.pcbEditProfile.Location = new System.Drawing.Point(280, 375);
            this.pcbEditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pcbEditProfile.Name = "pcbEditProfile";
            this.pcbEditProfile.Size = new System.Drawing.Size(97, 90);
            this.pcbEditProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditProfile.TabIndex = 60;
            this.pcbEditProfile.TabStop = false;
            this.pcbEditProfile.Click += new System.EventHandler(this.pcbEditProfile_Click);
            // 
            // frmEditProfilePS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(165, 144);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmEditProfilePS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfilePS";
            this.Load += new System.EventHandler(this.frmEditProfilePS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtProfilePhoto;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblCompanyCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblProfilePhoto;
        private System.Windows.Forms.Label lblPINCODE;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblEditPeofileSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbEditProfile;
        private System.Windows.Forms.Label lblFEProfile;
        private System.Windows.Forms.Label lblEProfile;
        private System.Windows.Forms.LinkLabel lblEPFilePath;
        private System.Windows.Forms.Label lblUCode;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancel;
    }
}

