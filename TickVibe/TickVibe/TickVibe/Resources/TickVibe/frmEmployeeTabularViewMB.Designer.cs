namespace TickVibe
{
    partial class frmEmployeeTabularViewMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTabularViewMB));
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.UI.WinForms.SiticonePanel();
            this.grdEmployeeTabularView = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcExcel = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pbPdf = new Siticone.UI.WinForms.SiticonePictureBox();
            this.txtSearchBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.lblAgentPerformance = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblToDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFilter = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFromDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.btnGraphicalView = new Siticone.UI.WinForms.SiticoneButton();
            this.cmbFilterDaywise = new Siticone.UI.WinForms.SiticoneComboBox();
            this.dtpToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.btnTabularView = new Siticone.UI.WinForms.SiticoneButton();
            this.btnAgent = new Siticone.UI.WinForms.SiticoneButton();
            this.dtpFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.btnEmployee = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeTabularView)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Location = new System.Drawing.Point(50, 40);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1495, 712);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.grdEmployeeTabularView);
            this.siticonePanel3.Location = new System.Drawing.Point(15, 286);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
            this.siticonePanel3.Size = new System.Drawing.Size(1456, 393);
            this.siticonePanel3.TabIndex = 26;
            // 
            // grdEmployeeTabularView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeeTabularView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEmployeeTabularView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdEmployeeTabularView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdEmployeeTabularView.BackgroundColor = System.Drawing.Color.White;
            this.grdEmployeeTabularView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEmployeeTabularView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeeTabularView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmployeeTabularView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEmployeeTabularView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmployeeTabularView.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdEmployeeTabularView.EnableHeadersVisualStyles = false;
            this.grdEmployeeTabularView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeeTabularView.Location = new System.Drawing.Point(0, 3);
            this.grdEmployeeTabularView.Name = "grdEmployeeTabularView";
            this.grdEmployeeTabularView.ReadOnly = true;
            this.grdEmployeeTabularView.RowHeadersVisible = false;
            this.grdEmployeeTabularView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeeTabularView.Size = new System.Drawing.Size(1453, 387);
            this.grdEmployeeTabularView.TabIndex = 0;
            this.grdEmployeeTabularView.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdEmployeeTabularView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeeTabularView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdEmployeeTabularView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdEmployeeTabularView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdEmployeeTabularView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdEmployeeTabularView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdEmployeeTabularView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdEmployeeTabularView.ThemeStyle.HeaderStyle.Height = 4;
            this.grdEmployeeTabularView.ThemeStyle.ReadOnly = true;
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.Height = 22;
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdEmployeeTabularView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdEmployeeTabularView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgentTabularView_CellContentClick);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.panel1);
            this.siticonePanel2.Controls.Add(this.lblAgentPerformance);
            this.siticonePanel2.Controls.Add(this.lblToDate);
            this.siticonePanel2.Controls.Add(this.lblFilter);
            this.siticonePanel2.Controls.Add(this.lblFromDate);
            this.siticonePanel2.Controls.Add(this.btnGraphicalView);
            this.siticonePanel2.Controls.Add(this.cmbFilterDaywise);
            this.siticonePanel2.Controls.Add(this.dtpToDate);
            this.siticonePanel2.Controls.Add(this.btnTabularView);
            this.siticonePanel2.Controls.Add(this.btnAgent);
            this.siticonePanel2.Controls.Add(this.dtpFromDate);
            this.siticonePanel2.Controls.Add(this.btnEmployee);
            this.siticonePanel2.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticonePanel2.Location = new System.Drawing.Point(15, 13);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(1453, 270);
            this.siticonePanel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbRefresh);
            this.panel1.Controls.Add(this.pcExcel);
            this.panel1.Controls.Add(this.pbPdf);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Location = new System.Drawing.Point(22, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 57);
            this.panel1.TabIndex = 30;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(1345, 18);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.ShadowDecoration.Parent = this.pbRefresh;
            this.pbRefresh.Size = new System.Drawing.Size(48, 36);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRefresh.TabIndex = 3;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRefresh_MouseClick);
            // 
            // pcExcel
            // 
            this.pcExcel.Image = ((System.Drawing.Image)(resources.GetObject("pcExcel.Image")));
            this.pcExcel.Location = new System.Drawing.Point(1279, 15);
            this.pcExcel.Name = "pcExcel";
            this.pcExcel.ShadowDecoration.Parent = this.pcExcel;
            this.pcExcel.Size = new System.Drawing.Size(48, 36);
            this.pcExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcExcel.TabIndex = 2;
            this.pcExcel.TabStop = false;
            this.pcExcel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcExcel_MouseClick);
            // 
            // pbPdf
            // 
            this.pbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pbPdf.Image")));
            this.pbPdf.Location = new System.Drawing.Point(1209, 15);
            this.pbPdf.Name = "pbPdf";
            this.pbPdf.ShadowDecoration.Parent = this.pbPdf;
            this.pbPdf.Size = new System.Drawing.Size(48, 36);
            this.pbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPdf.TabIndex = 1;
            this.pbPdf.TabStop = false;
            this.pbPdf.Click += new System.EventHandler(this.pbPdf_Click);
            this.pbPdf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbPdf_MouseClick);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.Parent = this.txtSearchBox;
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.FocusedState.Parent = this.txtSearchBox;
            this.txtSearchBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.HoveredState.Parent = this.txtSearchBox;
            this.txtSearchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchBox.IconLeft")));
            this.txtSearchBox.Location = new System.Drawing.Point(3, 15);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderText = "";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.ShadowDecoration.Parent = this.txtSearchBox;
            this.txtSearchBox.Size = new System.Drawing.Size(268, 36);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblAgentPerformance
            // 
            this.lblAgentPerformance.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentPerformance.Location = new System.Drawing.Point(646, 12);
            this.lblAgentPerformance.Name = "lblAgentPerformance";
            this.lblAgentPerformance.Size = new System.Drawing.Size(328, 35);
            this.lblAgentPerformance.TabIndex = 10;
            this.lblAgentPerformance.Text = "Employee Performance";
            // 
            // lblToDate
            // 
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(588, 225);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(63, 18);
            this.lblToDate.TabIndex = 22;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(25, 225);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(38, 18);
            this.lblFilter.TabIndex = 16;
            this.lblFilter.Text = "Filter";
            // 
            // lblFromDate
            // 
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(273, 225);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(79, 18);
            this.lblFromDate.TabIndex = 21;
            this.lblFromDate.Text = "From Date:";
            // 
            // btnGraphicalView
            // 
            this.btnGraphicalView.CheckedState.Parent = this.btnGraphicalView;
            this.btnGraphicalView.CustomImages.Parent = this.btnGraphicalView;
            this.btnGraphicalView.FillColor = System.Drawing.Color.MediumPurple;
            this.btnGraphicalView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGraphicalView.ForeColor = System.Drawing.Color.White;
            this.btnGraphicalView.HoveredState.Parent = this.btnGraphicalView;
            this.btnGraphicalView.Location = new System.Drawing.Point(296, 129);
            this.btnGraphicalView.Name = "btnGraphicalView";
            this.btnGraphicalView.ShadowDecoration.Parent = this.btnGraphicalView;
            this.btnGraphicalView.Size = new System.Drawing.Size(244, 61);
            this.btnGraphicalView.TabIndex = 8;
            this.btnGraphicalView.Text = "Graphical View";
            this.btnGraphicalView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGraphicalView_MouseClick);
            // 
            // cmbFilterDaywise
            // 
            this.cmbFilterDaywise.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterDaywise.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterDaywise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDaywise.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterDaywise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterDaywise.FormattingEnabled = true;
            this.cmbFilterDaywise.HoveredState.Parent = this.cmbFilterDaywise;
            this.cmbFilterDaywise.ItemHeight = 30;
            this.cmbFilterDaywise.ItemsAppearance.Parent = this.cmbFilterDaywise;
            this.cmbFilterDaywise.Location = new System.Drawing.Point(72, 216);
            this.cmbFilterDaywise.Name = "cmbFilterDaywise";
            this.cmbFilterDaywise.ShadowDecoration.Parent = this.cmbFilterDaywise;
            this.cmbFilterDaywise.Size = new System.Drawing.Size(150, 36);
            this.cmbFilterDaywise.TabIndex = 17;
            this.cmbFilterDaywise.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDaywise_SelectedIndexChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.HoveredState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(694, 216);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(145, 36);
            this.dtpToDate.TabIndex = 20;
            this.dtpToDate.Value = new System.DateTime(2026, 2, 13, 21, 29, 1, 1);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // btnTabularView
            // 
            this.btnTabularView.CheckedState.Parent = this.btnTabularView;
            this.btnTabularView.CustomImages.Parent = this.btnTabularView;
            this.btnTabularView.FillColor = System.Drawing.Color.MediumPurple;
            this.btnTabularView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabularView.ForeColor = System.Drawing.Color.White;
            this.btnTabularView.HoveredState.Parent = this.btnTabularView;
            this.btnTabularView.Location = new System.Drawing.Point(22, 129);
            this.btnTabularView.Name = "btnTabularView";
            this.btnTabularView.ShadowDecoration.Parent = this.btnTabularView;
            this.btnTabularView.Size = new System.Drawing.Size(244, 61);
            this.btnTabularView.TabIndex = 9;
            this.btnTabularView.Text = "Tabular View";
            this.btnTabularView.Click += new System.EventHandler(this.btnTabularView_Click);
            this.btnTabularView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTabularView_MouseClick);
            // 
            // btnAgent
            // 
            this.btnAgent.CheckedState.Parent = this.btnAgent;
            this.btnAgent.CustomImages.Parent = this.btnAgent;
            this.btnAgent.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgent.ForeColor = System.Drawing.Color.White;
            this.btnAgent.HoveredState.Parent = this.btnAgent;
            this.btnAgent.Location = new System.Drawing.Point(905, 129);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.ShadowDecoration.Parent = this.btnAgent;
            this.btnAgent.Size = new System.Drawing.Size(244, 61);
            this.btnAgent.TabIndex = 11;
            this.btnAgent.Text = "Agent";
            this.btnAgent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAgent_MouseClick);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.HoveredState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(355, 216);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(150, 36);
            this.dtpFromDate.TabIndex = 19;
            this.dtpFromDate.Value = new System.DateTime(2026, 2, 13, 21, 28, 53, 267);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // btnEmployee
            // 
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.MediumPurple;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoveredState.Parent = this.btnEmployee;
            this.btnEmployee.Location = new System.Drawing.Point(1174, 129);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(244, 61);
            this.btnEmployee.TabIndex = 12;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEmployee_MouseClick);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(1463, 13);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(21, 21);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 6;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // frmEmployeeTabularViewMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 764);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeTabularViewMB";
            this.Text = "frmEmployeeTabularViewMB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployeeTabularViewMB_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeTabularView)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.UI.WinForms.SiticoneDataGridView grdEmployeeTabularView;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneLabel lblAgentPerformance;
        private Siticone.UI.WinForms.SiticoneLabel lblToDate;
        private Siticone.UI.WinForms.SiticoneLabel lblFilter;
        private Siticone.UI.WinForms.SiticoneLabel lblFromDate;
        private Siticone.UI.WinForms.SiticoneButton btnGraphicalView;
        private Siticone.UI.WinForms.SiticoneComboBox cmbFilterDaywise;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpToDate;
        private Siticone.UI.WinForms.SiticoneButton btnTabularView;
        private Siticone.UI.WinForms.SiticoneButton btnAgent;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpFromDate;
        private Siticone.UI.WinForms.SiticoneButton btnEmployee;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticonePictureBox pbRefresh;
        private Siticone.UI.WinForms.SiticonePictureBox pcExcel;
        private Siticone.UI.WinForms.SiticonePictureBox pbPdf;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearchBox;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}