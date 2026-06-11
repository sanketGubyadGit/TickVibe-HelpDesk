namespace TickVibe.Resources.TickVibe
{
    partial class frmgridviewAllAgentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgridviewAllAgentReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbRefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcExcel = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pbPdf = new Siticone.UI.WinForms.SiticonePictureBox();
            this.txtSearchBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdShowChartStatusEmployee = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.lblToDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFilter = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFromDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.cmbFilterDaywise = new Siticone.UI.WinForms.SiticoneComboBox();
            this.dtpToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.dtpFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowChartStatusEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(640, 71);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(295, 35);
            this.siticoneLabel1.TabIndex = 9;
            this.siticoneLabel1.Text = "Agent Overall Report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbRefresh);
            this.panel2.Controls.Add(this.pcExcel);
            this.panel2.Controls.Add(this.pbPdf);
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Location = new System.Drawing.Point(49, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 72);
            this.panel2.TabIndex = 8;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(1365, 15);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.ShadowDecoration.Parent = this.pbRefresh;
            this.pbRefresh.Size = new System.Drawing.Size(48, 36);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRefresh.TabIndex = 3;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pcExcel
            // 
            this.pcExcel.Image = ((System.Drawing.Image)(resources.GetObject("pcExcel.Image")));
            this.pcExcel.Location = new System.Drawing.Point(1285, 15);
            this.pcExcel.Name = "pcExcel";
            this.pcExcel.ShadowDecoration.Parent = this.pcExcel;
            this.pcExcel.Size = new System.Drawing.Size(48, 36);
            this.pcExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcExcel.TabIndex = 2;
            this.pcExcel.TabStop = false;
            this.pcExcel.Click += new System.EventHandler(this.pcExcel_Click);
            // 
            // pbPdf
            // 
            this.pbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pbPdf.Image")));
            this.pbPdf.Location = new System.Drawing.Point(1231, 15);
            this.pbPdf.Name = "pbPdf";
            this.pbPdf.ShadowDecoration.Parent = this.pbPdf;
            this.pbPdf.Size = new System.Drawing.Size(48, 36);
            this.pbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPdf.TabIndex = 1;
            this.pbPdf.TabStop = false;
            this.pbPdf.Click += new System.EventHandler(this.pbPdf_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.grdShowChartStatusEmployee);
            this.panel1.Location = new System.Drawing.Point(49, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 513);
            this.panel1.TabIndex = 7;
            // 
            // grdShowChartStatusEmployee
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdShowChartStatusEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdShowChartStatusEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdShowChartStatusEmployee.BackgroundColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdShowChartStatusEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdShowChartStatusEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShowChartStatusEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdShowChartStatusEmployee.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdShowChartStatusEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdShowChartStatusEmployee.EnableHeadersVisualStyles = false;
            this.grdShowChartStatusEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdShowChartStatusEmployee.Location = new System.Drawing.Point(20, 45);
            this.grdShowChartStatusEmployee.Name = "grdShowChartStatusEmployee";
            this.grdShowChartStatusEmployee.RowHeadersVisible = false;
            this.grdShowChartStatusEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShowChartStatusEmployee.Size = new System.Drawing.Size(1424, 305);
            this.grdShowChartStatusEmployee.TabIndex = 0;
            this.grdShowChartStatusEmployee.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grdShowChartStatusEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdShowChartStatusEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdShowChartStatusEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdShowChartStatusEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdShowChartStatusEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdShowChartStatusEmployee.ThemeStyle.HeaderStyle.Height = 4;
            this.grdShowChartStatusEmployee.ThemeStyle.ReadOnly = false;
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.Height = 22;
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdShowChartStatusEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(1455, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(26, 21);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 10;
            this.siticonePictureBox1.TabStop = false;
            // 
            // lblToDate
            // 
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(669, 207);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(72, 22);
            this.lblToDate.TabIndex = 34;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(51, 207);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 22);
            this.lblFilter.TabIndex = 29;
            this.lblFilter.Text = "Filter";
            // 
            // lblFromDate
            // 
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(319, 207);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(93, 22);
            this.lblFromDate.TabIndex = 33;
            this.lblFromDate.Text = "From Date:";
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
            this.cmbFilterDaywise.Location = new System.Drawing.Point(101, 201);
            this.cmbFilterDaywise.Name = "cmbFilterDaywise";
            this.cmbFilterDaywise.ShadowDecoration.Parent = this.cmbFilterDaywise;
            this.cmbFilterDaywise.Size = new System.Drawing.Size(200, 36);
            this.cmbFilterDaywise.TabIndex = 30;
            this.cmbFilterDaywise.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDaywise_SelectedIndexChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.FillColor = System.Drawing.Color.White;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.HoveredState.FillColor = System.Drawing.Color.Silver;
            this.dtpToDate.HoveredState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(758, 201);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(223, 36);
            this.dtpToDate.TabIndex = 32;
            this.dtpToDate.Value = new System.DateTime(2026, 2, 13, 21, 29, 1, 1);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.FillColor = System.Drawing.Color.White;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.HoveredState.FillColor = System.Drawing.Color.Silver;
            this.dtpFromDate.HoveredState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(428, 201);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(223, 36);
            this.dtpFromDate.TabIndex = 31;
            this.dtpFromDate.Value = new System.DateTime(2026, 2, 13, 21, 28, 53, 267);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // frmgridviewAllAgentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 768);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbFilterDaywise);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmgridviewAllAgentReport";
            this.Text = "frmgridviewAllAgentReport";
            this.Load += new System.EventHandler(this.frmgridviewAllAgentReport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdShowChartStatusEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.Panel panel2;
        private Siticone.UI.WinForms.SiticonePictureBox pbRefresh;
        private Siticone.UI.WinForms.SiticonePictureBox pcExcel;
        private Siticone.UI.WinForms.SiticonePictureBox pbPdf;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearchBox;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneDataGridView grdShowChartStatusEmployee;
        private Siticone.UI.WinForms.SiticoneLabel lblToDate;
        private Siticone.UI.WinForms.SiticoneLabel lblFilter;
        private Siticone.UI.WinForms.SiticoneLabel lblFromDate;
        private Siticone.UI.WinForms.SiticoneComboBox cmbFilterDaywise;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpToDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpFromDate;
    }
}