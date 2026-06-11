namespace TickVibe
{
    partial class frmEmployeeTicketViewSB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTicketViewSB));
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.lblEmpTktCode = new System.Windows.Forms.Label();
            this.lblEmpContactNo = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.grdEmployeeTicketDetails = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.lblTicketcode = new System.Windows.Forms.Label();
            this.lblEmployeTicketDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adtToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.adtFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.lbltoDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtSearchName = new Siticone.UI.WinForms.SiticoneTextBox();
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.pcbExcel = new System.Windows.Forms.PictureBox();
            this.pcbPdf = new System.Windows.Forms.PictureBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeTicketDetails)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(371, 266);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.lblEmpTktCode);
            this.panel1.Controls.Add(this.lblEmpContactNo);
            this.panel1.Controls.Add(this.lblEmpEmail);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.grdEmployeeTicketDetails);
            this.panel1.Controls.Add(this.lblTicketcode);
            this.panel1.Controls.Add(this.lblEmployeTicketDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(11, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 852);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::TickVibe.Properties.Resources.close___Copy;
            this.btnclose.Location = new System.Drawing.Point(1462, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 26);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 28;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblEmpTktCode
            // 
            this.lblEmpTktCode.AutoSize = true;
            this.lblEmpTktCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmpTktCode.Location = new System.Drawing.Point(1371, 269);
            this.lblEmpTktCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpTktCode.Name = "lblEmpTktCode";
            this.lblEmpTktCode.Size = new System.Drawing.Size(51, 20);
            this.lblEmpTktCode.TabIndex = 27;
            this.lblEmpTktCode.Text = "label1";
            // 
            // lblEmpContactNo
            // 
            this.lblEmpContactNo.AutoSize = true;
            this.lblEmpContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmpContactNo.Location = new System.Drawing.Point(973, 266);
            this.lblEmpContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpContactNo.Name = "lblEmpContactNo";
            this.lblEmpContactNo.Size = new System.Drawing.Size(51, 20);
            this.lblEmpContactNo.TabIndex = 26;
            this.lblEmpContactNo.Text = "label1";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmpEmail.Location = new System.Drawing.Point(453, 266);
            this.lblEmpEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmpEmail.TabIndex = 25;
            this.lblEmpEmail.Text = "label1";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmpName.Location = new System.Drawing.Point(104, 266);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(51, 20);
            this.lblEmpName.TabIndex = 24;
            this.lblEmpName.Text = "label1";
            this.lblEmpName.Click += new System.EventHandler(this.lblEmpName_Click);
            // 
            // grdEmployeeTicketDetails
            // 
            this.grdEmployeeTicketDetails.AllowUserToResizeColumns = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeeTicketDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grdEmployeeTicketDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmployeeTicketDetails.BackgroundColor = System.Drawing.Color.White;
            this.grdEmployeeTicketDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEmployeeTicketDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeeTicketDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmployeeTicketDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdEmployeeTicketDetails.ColumnHeadersHeight = 4;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmployeeTicketDetails.DefaultCellStyle = dataGridViewCellStyle15;
            this.grdEmployeeTicketDetails.EnableHeadersVisualStyles = false;
            this.grdEmployeeTicketDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeeTicketDetails.Location = new System.Drawing.Point(10, 345);
            this.grdEmployeeTicketDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grdEmployeeTicketDetails.Name = "grdEmployeeTicketDetails";
            this.grdEmployeeTicketDetails.RowHeadersVisible = false;
            this.grdEmployeeTicketDetails.RowHeadersWidth = 51;
            this.grdEmployeeTicketDetails.RowTemplate.Height = 24;
            this.grdEmployeeTicketDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeeTicketDetails.Size = new System.Drawing.Size(1477, 485);
            this.grdEmployeeTicketDetails.TabIndex = 15;
            this.grdEmployeeTicketDetails.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdEmployeeTicketDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeeTicketDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdEmployeeTicketDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdEmployeeTicketDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdEmployeeTicketDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdEmployeeTicketDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdEmployeeTicketDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdEmployeeTicketDetails.ThemeStyle.HeaderStyle.Height = 4;
            this.grdEmployeeTicketDetails.ThemeStyle.ReadOnly = false;
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.Height = 24;
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdEmployeeTicketDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdEmployeeTicketDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployeeTicketDetails_CellContentClick);
            // 
            // lblTicketcode
            // 
            this.lblTicketcode.AutoSize = true;
            this.lblTicketcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTicketcode.Location = new System.Drawing.Point(1267, 266);
            this.lblTicketcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketcode.Name = "lblTicketcode";
            this.lblTicketcode.Size = new System.Drawing.Size(86, 20);
            this.lblTicketcode.TabIndex = 13;
            this.lblTicketcode.Text = "TktCode :";
            this.lblTicketcode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmployeTicketDetails
            // 
            this.lblEmployeTicketDetails.AutoSize = true;
            this.lblEmployeTicketDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblEmployeTicketDetails.Location = new System.Drawing.Point(538, 30);
            this.lblEmployeTicketDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeTicketDetails.Name = "lblEmployeTicketDetails";
            this.lblEmployeTicketDetails.Size = new System.Drawing.Size(324, 37);
            this.lblEmployeTicketDetails.TabIndex = 12;
            this.lblEmployeTicketDetails.Text = "Employee Ticket Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adtToDate);
            this.panel2.Controls.Add(this.adtFromDate);
            this.panel2.Controls.Add(this.lbltoDate);
            this.panel2.Controls.Add(this.lblFromDate);
            this.panel2.Controls.Add(this.txtSearchName);
            this.panel2.Controls.Add(this.pcbRefresh);
            this.panel2.Controls.Add(this.pcbExcel);
            this.panel2.Controls.Add(this.pcbPdf);
            this.panel2.Location = new System.Drawing.Point(16, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1471, 67);
            this.panel2.TabIndex = 8;
            // 
            // adtToDate
            // 
            this.adtToDate.CheckedState.Parent = this.adtToDate;
            this.adtToDate.FillColor = System.Drawing.Color.White;
            this.adtToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.adtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.adtToDate.HoveredState.Parent = this.adtToDate;
            this.adtToDate.Location = new System.Drawing.Point(896, 14);
            this.adtToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adtToDate.MaxDate = new System.DateTime(2026, 6, 30, 0, 0, 0, 0);
            this.adtToDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.adtToDate.Name = "adtToDate";
            this.adtToDate.ShadowDecoration.Enabled = true;
            this.adtToDate.ShadowDecoration.Parent = this.adtToDate;
            this.adtToDate.Size = new System.Drawing.Size(233, 42);
            this.adtToDate.TabIndex = 69;
            this.adtToDate.Value = new System.DateTime(2026, 6, 29, 19, 6, 0, 0);
            // 
            // adtFromDate
            // 
            this.adtFromDate.CheckedState.Parent = this.adtFromDate;
            this.adtFromDate.FillColor = System.Drawing.Color.White;
            this.adtFromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.adtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.adtFromDate.HoveredState.Parent = this.adtFromDate;
            this.adtFromDate.Location = new System.Drawing.Point(466, 14);
            this.adtFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adtFromDate.MaxDate = new System.DateTime(2026, 3, 31, 0, 0, 0, 0);
            this.adtFromDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.adtFromDate.Name = "adtFromDate";
            this.adtFromDate.ShadowDecoration.Enabled = true;
            this.adtFromDate.ShadowDecoration.Parent = this.adtFromDate;
            this.adtFromDate.Size = new System.Drawing.Size(233, 42);
            this.adtFromDate.TabIndex = 44;
            this.adtFromDate.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // lbltoDate
            // 
            this.lbltoDate.AutoSize = true;
            this.lbltoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbltoDate.Location = new System.Drawing.Point(806, 25);
            this.lbltoDate.Name = "lbltoDate";
            this.lbltoDate.Size = new System.Drawing.Size(83, 20);
            this.lbltoDate.TabIndex = 10;
            this.lbltoDate.Text = "To Date :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.Location = new System.Drawing.Point(355, 22);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(104, 20);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From Date :";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchName.DefaultText = "";
            this.txtSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.DisabledState.Parent = this.txtSearchName;
            this.txtSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.FocusedState.Parent = this.txtSearchName;
            this.txtSearchName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.HoveredState.Parent = this.txtSearchName;
            this.txtSearchName.IconLeft = global::TickVibe.Properties.Resources.search;
            this.txtSearchName.Location = new System.Drawing.Point(8, 15);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderText = "";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.ShadowDecoration.Parent = this.txtSearchName;
            this.txtSearchName.Size = new System.Drawing.Size(236, 36);
            this.txtSearchName.TabIndex = 6;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.Image = global::TickVibe.Properties.Resources.refresh;
            this.pcbRefresh.Location = new System.Drawing.Point(1422, 14);
            this.pcbRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(36, 35);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefresh.TabIndex = 5;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click);
            // 
            // pcbExcel
            // 
            this.pcbExcel.Image = ((System.Drawing.Image)(resources.GetObject("pcbExcel.Image")));
            this.pcbExcel.Location = new System.Drawing.Point(1378, 16);
            this.pcbExcel.Margin = new System.Windows.Forms.Padding(2);
            this.pcbExcel.Name = "pcbExcel";
            this.pcbExcel.Size = new System.Drawing.Size(36, 35);
            this.pcbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbExcel.TabIndex = 4;
            this.pcbExcel.TabStop = false;
            this.pcbExcel.Click += new System.EventHandler(this.pcbExcel_Click);
            // 
            // pcbPdf
            // 
            this.pcbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pcbPdf.Image")));
            this.pcbPdf.Location = new System.Drawing.Point(1336, 16);
            this.pcbPdf.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPdf.Name = "pcbPdf";
            this.pcbPdf.Size = new System.Drawing.Size(36, 35);
            this.pcbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPdf.TabIndex = 2;
            this.pcbPdf.TabStop = false;
            this.pcbPdf.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblContact.Location = new System.Drawing.Point(841, 265);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(109, 20);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact No :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(35, 266);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name :";
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmEmployeeTicketViewSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 865);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmEmployeeTicketViewSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeTicketViewSB";
            this.Load += new System.EventHandler(this.frmEmployeeTicketViewSB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeTicketDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbPdf;
        private System.Windows.Forms.PictureBox pcbRefresh;
        private System.Windows.Forms.PictureBox pcbExcel;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmployeTicketDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTicketcode;
        private Siticone.UI.WinForms.SiticoneDataGridView grdEmployeeTicketDetails;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpTktCode;
        private System.Windows.Forms.Label lblEmpContactNo;
        private System.Windows.Forms.Label lblEmpEmail;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearchName;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label lbltoDate;
        private System.Windows.Forms.Label lblFromDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker adtFromDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker adtToDate;
        private System.Windows.Forms.PictureBox btnclose;
    }
}