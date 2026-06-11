namespace TickVibe
{
    partial class frmLstView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstView));
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.lblExit = new System.Windows.Forms.Label();
            this.grdTicketsShow = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneGradientPanel2 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.cmbbxStatus = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dtpToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.dtpFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.siticoneLabel20 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblCard = new System.Windows.Forms.Label();
            this.txtSearch = new Siticone.UI.WinForms.SiticoneTextBox();
            this.pcbXl = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcbRefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcbPdf = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicketsShow)).BeginInit();
            this.siticoneGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbXl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneGradientPanel1.Controls.Add(this.lblExit);
            this.siticoneGradientPanel1.Controls.Add(this.grdTicketsShow);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientPanel2);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1536, 801);
            this.siticoneGradientPanel1.TabIndex = 1;
            this.siticoneGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneGradientPanel1_Paint);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(1506, 10);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(18, 17);
            this.lblExit.TabIndex = 150;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // grdTicketsShow
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdTicketsShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTicketsShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdTicketsShow.ColumnHeadersHeight = 40;
            this.grdTicketsShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTicketsShow.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdTicketsShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdTicketsShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdTicketsShow.Location = new System.Drawing.Point(49, 264);
            this.grdTicketsShow.Name = "grdTicketsShow";
            this.grdTicketsShow.RowHeadersVisible = false;
            this.grdTicketsShow.RowHeadersWidth = 51;
            this.grdTicketsShow.RowTemplate.Height = 30;
            this.grdTicketsShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdTicketsShow.Size = new System.Drawing.Size(1452, 472);
            this.grdTicketsShow.TabIndex = 2;
            this.grdTicketsShow.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdTicketsShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdTicketsShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdTicketsShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdTicketsShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdTicketsShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdTicketsShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdTicketsShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdTicketsShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdTicketsShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdTicketsShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTicketsShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdTicketsShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdTicketsShow.ThemeStyle.HeaderStyle.Height = 40;
            this.grdTicketsShow.ThemeStyle.ReadOnly = false;
            this.grdTicketsShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdTicketsShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdTicketsShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTicketsShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdTicketsShow.ThemeStyle.RowsStyle.Height = 30;
            this.grdTicketsShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdTicketsShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdTicketsShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTicketsShow_CellContentClick);
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.Controls.Add(this.siticoneLabel1);
            this.siticoneGradientPanel2.Controls.Add(this.cmbbxStatus);
            this.siticoneGradientPanel2.Controls.Add(this.dtpToDate);
            this.siticoneGradientPanel2.Controls.Add(this.dtpFromDate);
            this.siticoneGradientPanel2.Controls.Add(this.siticoneLabel20);
            this.siticoneGradientPanel2.Controls.Add(this.siticoneLabel3);
            this.siticoneGradientPanel2.Controls.Add(this.lblCard);
            this.siticoneGradientPanel2.Controls.Add(this.txtSearch);
            this.siticoneGradientPanel2.Controls.Add(this.pcbXl);
            this.siticoneGradientPanel2.Controls.Add(this.pcbRefresh);
            this.siticoneGradientPanel2.Controls.Add(this.pcbPdf);
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(49, 35);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(1452, 181);
            this.siticoneGradientPanel2.TabIndex = 1;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Black;
            this.siticoneLabel1.Location = new System.Drawing.Point(52, 122);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(56, 27);
            this.siticoneLabel1.TabIndex = 74;
            this.siticoneLabel1.Text = "Status";
            this.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel1.Visible = false;
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxStatus.ItemHeight = 30;
            this.cmbbxStatus.Location = new System.Drawing.Point(143, 113);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(167, 36);
            this.cmbbxStatus.TabIndex = 73;
            this.cmbbxStatus.Visible = false;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.FillColor = System.Drawing.Color.White;
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpToDate.HoveredState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(1023, 116);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpToDate.MaxDate = new System.DateTime(2026, 6, 30, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Enabled = true;
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(233, 42);
            this.dtpToDate.TabIndex = 72;
            this.dtpToDate.Value = new System.DateTime(2026, 6, 29, 19, 6, 0, 0);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.FillColor = System.Drawing.Color.White;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFromDate.HoveredState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(555, 116);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFromDate.MaxDate = new System.DateTime(2026, 3, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Enabled = true;
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(233, 42);
            this.dtpFromDate.TabIndex = 69;
            this.dtpFromDate.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // siticoneLabel20
            // 
            this.siticoneLabel20.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel20.ForeColor = System.Drawing.Color.Black;
            this.siticoneLabel20.Location = new System.Drawing.Point(428, 122);
            this.siticoneLabel20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneLabel20.Name = "siticoneLabel20";
            this.siticoneLabel20.Size = new System.Drawing.Size(94, 27);
            this.siticoneLabel20.TabIndex = 70;
            this.siticoneLabel20.Text = "From Date";
            this.siticoneLabel20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.Color.Black;
            this.siticoneLabel3.Location = new System.Drawing.Point(926, 122);
            this.siticoneLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(70, 27);
            this.siticoneLabel3.TabIndex = 71;
            this.siticoneLabel3.Text = "To Date";
            this.siticoneLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(611, 16);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(159, 42);
            this.lblCard.TabIndex = 4;
            this.lblCard.Text = "Card List";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoveredState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(17, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(280, 38);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pcbXl
            // 
            this.pcbXl.Image = ((System.Drawing.Image)(resources.GetObject("pcbXl.Image")));
            this.pcbXl.Location = new System.Drawing.Point(1322, 16);
            this.pcbXl.Name = "pcbXl";
            this.pcbXl.ShadowDecoration.Parent = this.pcbXl;
            this.pcbXl.Size = new System.Drawing.Size(40, 38);
            this.pcbXl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbXl.TabIndex = 2;
            this.pcbXl.TabStop = false;
            this.pcbXl.Click += new System.EventHandler(this.pcbXl_Click);
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcbRefresh.Image")));
            this.pcbRefresh.Location = new System.Drawing.Point(1378, 16);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.ShadowDecoration.Parent = this.pcbRefresh;
            this.pcbRefresh.Size = new System.Drawing.Size(40, 38);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefresh.TabIndex = 1;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click_1);
            this.pcbRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcbRefresh_MouseClick);
            // 
            // pcbPdf
            // 
            this.pcbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pcbPdf.Image")));
            this.pcbPdf.Location = new System.Drawing.Point(1268, 16);
            this.pcbPdf.Name = "pcbPdf";
            this.pcbPdf.ShadowDecoration.Parent = this.pcbPdf;
            this.pcbPdf.Size = new System.Drawing.Size(40, 38);
            this.pcbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPdf.TabIndex = 0;
            this.pcbPdf.TabStop = false;
            this.pcbPdf.Click += new System.EventHandler(this.pcbPdf_Click);
            // 
            // frmLstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 801);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmLstView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLstView";
            this.Load += new System.EventHandler(this.frmLstView_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicketsShow)).EndInit();
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbXl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private Siticone.UI.WinForms.SiticonePictureBox pcbXl;
        private Siticone.UI.WinForms.SiticonePictureBox pcbRefresh;
        private Siticone.UI.WinForms.SiticonePictureBox pcbPdf;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView grdTicketsShow;
        private System.Windows.Forms.Label lblCard;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpToDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpFromDate;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel20;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbbxStatus;
        private System.Windows.Forms.Label lblExit;
    }
}