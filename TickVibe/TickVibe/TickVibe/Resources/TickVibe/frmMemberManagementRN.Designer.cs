namespace TickVibe
{
    partial class frmMemberManagementRN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberManagementRN));
            this.pnlForm1 = new Siticone.UI.WinForms.SiticonePanel();
            this.grdMManagement = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.pnlMemberManagement = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.pcbRefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.lblfilters = new System.Windows.Forms.Label();
            this.txtsearchbox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.btnfilters = new Siticone.UI.WinForms.SiticoneButton();
            this.pcbpdf = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcbxlsx = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pnlDate = new Siticone.UI.WinForms.SiticonePanel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblfromdate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lbltodate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.pcbagent = new Siticone.UI.WinForms.SiticonePictureBox();
            this.btnaddagent = new Siticone.UI.WinForms.SiticoneButton();
            this.lblMember = new System.Windows.Forms.Label();
            this.pnlForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMManagement)).BeginInit();
            this.pnlMemberManagement.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxlsx)).BeginInit();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbagent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm1
            // 
            this.pnlForm1.BackColor = System.Drawing.Color.Snow;
            this.pnlForm1.BorderThickness = 2;
            this.pnlForm1.Controls.Add(this.grdMManagement);
            this.pnlForm1.Controls.Add(this.pnlMemberManagement);
            this.pnlForm1.Location = new System.Drawing.Point(11, 88);
            this.pnlForm1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForm1.Name = "pnlForm1";
            this.pnlForm1.ShadowDecoration.Parent = this.pnlForm1;
            this.pnlForm1.Size = new System.Drawing.Size(1612, 834);
            this.pnlForm1.TabIndex = 0;
            this.pnlForm1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForm1_Paint);
            // 
            // grdMManagement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdMManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMManagement.BackgroundColor = System.Drawing.Color.White;
            this.grdMManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdMManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMManagement.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMManagement.EnableHeadersVisualStyles = false;
            this.grdMManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdMManagement.Location = new System.Drawing.Point(52, 231);
            this.grdMManagement.Margin = new System.Windows.Forms.Padding(2);
            this.grdMManagement.Name = "grdMManagement";
            this.grdMManagement.RowHeadersVisible = false;
            this.grdMManagement.RowHeadersWidth = 62;
            this.grdMManagement.RowTemplate.Height = 28;
            this.grdMManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMManagement.Size = new System.Drawing.Size(1543, 576);
            this.grdMManagement.TabIndex = 1;
            this.grdMManagement.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdMManagement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdMManagement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdMManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdMManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdMManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdMManagement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdMManagement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdMManagement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdMManagement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdMManagement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdMManagement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdMManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdMManagement.ThemeStyle.HeaderStyle.Height = 4;
            this.grdMManagement.ThemeStyle.ReadOnly = false;
            this.grdMManagement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdMManagement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdMManagement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdMManagement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdMManagement.ThemeStyle.RowsStyle.Height = 28;
            this.grdMManagement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdMManagement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdMManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMManagement_CellClick);
            this.grdMManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMManagement_CellContentClick_1);
            // 
            // pnlMemberManagement
            // 
            this.pnlMemberManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlMemberManagement.Controls.Add(this.siticonePanel1);
            this.pnlMemberManagement.Controls.Add(this.pnlDate);
            this.pnlMemberManagement.Controls.Add(this.lblCategory);
            this.pnlMemberManagement.Controls.Add(this.lblEmpCode);
            this.pnlMemberManagement.Controls.Add(this.pcbagent);
            this.pnlMemberManagement.Controls.Add(this.btnaddagent);
            this.pnlMemberManagement.Location = new System.Drawing.Point(52, 21);
            this.pnlMemberManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMemberManagement.Name = "pnlMemberManagement";
            this.pnlMemberManagement.ShadowDecoration.Parent = this.pnlMemberManagement;
            this.pnlMemberManagement.Size = new System.Drawing.Size(1543, 187);
            this.pnlMemberManagement.TabIndex = 0;
            this.pnlMemberManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMemberManagement_Paint);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.pcbRefresh);
            this.siticonePanel1.Controls.Add(this.lblfilters);
            this.siticonePanel1.Controls.Add(this.txtsearchbox);
            this.siticonePanel1.Controls.Add(this.btnfilters);
            this.siticonePanel1.Controls.Add(this.pcbpdf);
            this.siticonePanel1.Controls.Add(this.pcbxlsx);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1531, 58);
            this.siticonePanel1.TabIndex = 20;
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcbRefresh.Image")));
            this.pcbRefresh.Location = new System.Drawing.Point(1346, 9);
            this.pcbRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.ShadowDecoration.Parent = this.pcbRefresh;
            this.pcbRefresh.Size = new System.Drawing.Size(40, 40);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefresh.TabIndex = 19;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click);
            // 
            // lblfilters
            // 
            this.lblfilters.AutoSize = true;
            this.lblfilters.BackColor = System.Drawing.Color.White;
            this.lblfilters.Location = new System.Drawing.Point(1477, 21);
            this.lblfilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfilters.Name = "lblfilters";
            this.lblfilters.Size = new System.Drawing.Size(34, 13);
            this.lblfilters.TabIndex = 9;
            this.lblfilters.Text = "Filters";
            // 
            // txtsearchbox
            // 
            this.txtsearchbox.BackColor = System.Drawing.Color.White;
            this.txtsearchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchbox.DefaultText = "";
            this.txtsearchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbox.DisabledState.Parent = this.txtsearchbox;
            this.txtsearchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbox.FocusedState.Parent = this.txtsearchbox;
            this.txtsearchbox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbox.HoveredState.Parent = this.txtsearchbox;
            this.txtsearchbox.IconLeft = global::TickVibe.Properties.Resources.search;
            this.txtsearchbox.Location = new System.Drawing.Point(3, 13);
            this.txtsearchbox.Name = "txtsearchbox";
            this.txtsearchbox.PasswordChar = '\0';
            this.txtsearchbox.PlaceholderText = "";
            this.txtsearchbox.SelectedText = "";
            this.txtsearchbox.ShadowDecoration.Parent = this.txtsearchbox;
            this.txtsearchbox.Size = new System.Drawing.Size(236, 36);
            this.txtsearchbox.TabIndex = 4;
            this.txtsearchbox.TextChanged += new System.EventHandler(this.txtsearchbox_TextChanged);
            // 
            // btnfilters
            // 
            this.btnfilters.BorderThickness = 1;
            this.btnfilters.CheckedState.Parent = this.btnfilters;
            this.btnfilters.CustomImages.Parent = this.btnfilters;
            this.btnfilters.FillColor = System.Drawing.Color.White;
            this.btnfilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfilters.ForeColor = System.Drawing.Color.White;
            this.btnfilters.HoveredState.Parent = this.btnfilters;
            this.btnfilters.Image = global::TickVibe.Properties.Resources.filter;
            this.btnfilters.Location = new System.Drawing.Point(1404, 8);
            this.btnfilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnfilters.Name = "btnfilters";
            this.btnfilters.ShadowDecoration.Parent = this.btnfilters;
            this.btnfilters.Size = new System.Drawing.Size(120, 41);
            this.btnfilters.TabIndex = 7;
            this.btnfilters.Click += new System.EventHandler(this.btnfilters_Click);
            // 
            // pcbpdf
            // 
            this.pcbpdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbpdf.Image = ((System.Drawing.Image)(resources.GetObject("pcbpdf.Image")));
            this.pcbpdf.Location = new System.Drawing.Point(1252, 9);
            this.pcbpdf.Margin = new System.Windows.Forms.Padding(2);
            this.pcbpdf.Name = "pcbpdf";
            this.pcbpdf.ShadowDecoration.Parent = this.pcbpdf;
            this.pcbpdf.Size = new System.Drawing.Size(40, 40);
            this.pcbpdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbpdf.TabIndex = 1;
            this.pcbpdf.TabStop = false;
            this.pcbpdf.Click += new System.EventHandler(this.pcbpdf_Click);
            // 
            // pcbxlsx
            // 
            this.pcbxlsx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxlsx.Image = ((System.Drawing.Image)(resources.GetObject("pcbxlsx.Image")));
            this.pcbxlsx.Location = new System.Drawing.Point(1299, 9);
            this.pcbxlsx.Margin = new System.Windows.Forms.Padding(2);
            this.pcbxlsx.Name = "pcbxlsx";
            this.pcbxlsx.ShadowDecoration.Parent = this.pcbxlsx;
            this.pcbxlsx.Size = new System.Drawing.Size(40, 40);
            this.pcbxlsx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxlsx.TabIndex = 6;
            this.pcbxlsx.TabStop = false;
            this.pcbxlsx.Click += new System.EventHandler(this.pcbxlsx_Click);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dtpFromDate);
            this.pnlDate.Controls.Add(this.lblfromdate);
            this.pnlDate.Controls.Add(this.dtpToDate);
            this.pnlDate.Controls.Add(this.lbltodate);
            this.pnlDate.Location = new System.Drawing.Point(3, 85);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.ShadowDecoration.Parent = this.pnlDate;
            this.pnlDate.Size = new System.Drawing.Size(1383, 60);
            this.pnlDate.TabIndex = 3;
            this.pnlDate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDate_Paint);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(250, 26);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.MaxDate = new System.DateTime(2026, 3, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(135, 20);
            this.dtpFromDate.TabIndex = 15;
            this.dtpFromDate.Value = new System.DateTime(2026, 1, 1, 12, 31, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // lblfromdate
            // 
            this.lblfromdate.AutoSize = true;
            this.lblfromdate.BackColor = System.Drawing.Color.White;
            this.lblfromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfromdate.Location = new System.Drawing.Point(125, 26);
            this.lblfromdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfromdate.Name = "lblfromdate";
            this.lblfromdate.Size = new System.Drawing.Size(98, 18);
            this.lblfromdate.TabIndex = 10;
            this.lblfromdate.Text = "From Date :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(686, 27);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.MaxDate = new System.DateTime(2026, 8, 1, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(135, 20);
            this.dtpToDate.TabIndex = 16;
            this.dtpToDate.Value = new System.DateTime(2026, 7, 29, 12, 31, 0, 0);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged_1);
            // 
            // lbltodate
            // 
            this.lbltodate.AutoSize = true;
            this.lbltodate.BackColor = System.Drawing.Color.White;
            this.lbltodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltodate.Location = new System.Drawing.Point(599, 27);
            this.lbltodate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(83, 20);
            this.lbltodate.TabIndex = 11;
            this.lbltodate.Text = "To Date :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(669, 67);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 13);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "lblCategory";
            this.lblCategory.Visible = false;
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Location = new System.Drawing.Point(684, 80);
            this.lblEmpCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(35, 13);
            this.lblEmpCode.TabIndex = 17;
            this.lblEmpCode.Text = "label1";
            this.lblEmpCode.Visible = false;
            // 
            // pcbagent
            // 
            this.pcbagent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbagent.Image = ((System.Drawing.Image)(resources.GetObject("pcbagent.Image")));
            this.pcbagent.Location = new System.Drawing.Point(1401, 105);
            this.pcbagent.Margin = new System.Windows.Forms.Padding(2);
            this.pcbagent.Name = "pcbagent";
            this.pcbagent.ShadowDecoration.Parent = this.pcbagent;
            this.pcbagent.Size = new System.Drawing.Size(27, 27);
            this.pcbagent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbagent.TabIndex = 14;
            this.pcbagent.TabStop = false;
            // 
            // btnaddagent
            // 
            this.btnaddagent.CheckedState.Parent = this.btnaddagent;
            this.btnaddagent.CustomImages.Parent = this.btnaddagent;
            this.btnaddagent.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnaddagent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaddagent.ForeColor = System.Drawing.Color.White;
            this.btnaddagent.HoveredState.Parent = this.btnaddagent;
            this.btnaddagent.Location = new System.Drawing.Point(1391, 95);
            this.btnaddagent.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddagent.Name = "btnaddagent";
            this.btnaddagent.ShadowDecoration.Parent = this.btnaddagent;
            this.btnaddagent.Size = new System.Drawing.Size(140, 50);
            this.btnaddagent.TabIndex = 13;
            this.btnaddagent.Text = "Add Agent";
            this.btnaddagent.Click += new System.EventHandler(this.btnaddagent_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.BackColor = System.Drawing.Color.White;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(744, 24);
            this.lblMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(293, 31);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "Member Management";
            // 
            // frmMemberManagementRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1649, 933);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.pnlForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMemberManagementRN";
            this.Text = "frmMemberManagementRN";
            this.Load += new System.EventHandler(this.frmMemberManagementRN_Load);
            this.pnlForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMManagement)).EndInit();
            this.pnlMemberManagement.ResumeLayout(false);
            this.pnlMemberManagement.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxlsx)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbagent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel pnlForm1;
        private Siticone.UI.WinForms.SiticoneDataGridView grdMManagement;
        private Siticone.UI.WinForms.SiticonePanel pnlMemberManagement;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticonePictureBox pcbRefresh;
        private Siticone.UI.WinForms.SiticoneButton btnfilters;
        private System.Windows.Forms.Label lblfilters;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txtsearchbox;
        private Siticone.UI.WinForms.SiticonePictureBox pcbpdf;
        private Siticone.UI.WinForms.SiticonePictureBox pcbxlsx;
        private Siticone.UI.WinForms.SiticonePanel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblfromdate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lbltodate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblEmpCode;
        private Siticone.UI.WinForms.SiticonePictureBox pcbagent;
        private Siticone.UI.WinForms.SiticoneButton btnaddagent;
        private System.Windows.Forms.Label lblMember;
    }
}