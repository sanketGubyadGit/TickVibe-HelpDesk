namespace TickVibe
{
    partial class frmEmployeeViewChartTypeColumnMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeViewChartTypeColumnMB));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlReport1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.lblToDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFilter = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblFromDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.cmbFilterDaywise = new Siticone.UI.WinForms.SiticoneComboBox();
            this.dtpToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.dtpFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.chart1GraphicalView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlReport1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1GraphicalView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReport1
            // 
            this.pnlReport1.Controls.Add(this.siticonePanel2);
            this.pnlReport1.Controls.Add(this.siticonePanel1);
            this.pnlReport1.Location = new System.Drawing.Point(149, 12);
            this.pnlReport1.Name = "pnlReport1";
            this.pnlReport1.ShadowDecoration.Parent = this.pnlReport1;
            this.pnlReport1.Size = new System.Drawing.Size(1396, 753);
            this.pnlReport1.TabIndex = 18;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneLabel1);
            this.siticonePanel2.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel2.Controls.Add(this.lblToDate);
            this.siticonePanel2.Controls.Add(this.lblFilter);
            this.siticonePanel2.Controls.Add(this.lblFromDate);
            this.siticonePanel2.Controls.Add(this.cmbFilterDaywise);
            this.siticonePanel2.Controls.Add(this.dtpToDate);
            this.siticonePanel2.Controls.Add(this.dtpFromDate);
            this.siticonePanel2.Location = new System.Drawing.Point(23, 9);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(1356, 175);
            this.siticonePanel2.TabIndex = 24;
            this.siticonePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel2_Paint);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(488, 3);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(361, 35);
            this.siticoneLabel1.TabIndex = 23;
            this.siticoneLabel1.Text = "Employee Graphical View";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(1284, 3);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(21, 14);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 19;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Location = new System.Drawing.Point(357, 147);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(45, 15);
            this.lblToDate.TabIndex = 22;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Location = new System.Drawing.Point(79, 74);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(25, 15);
            this.lblFilter.TabIndex = 16;
            this.lblFilter.Text = "Filter";
            // 
            // lblFromDate
            // 
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.Location = new System.Drawing.Point(79, 147);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(55, 15);
            this.lblFromDate.TabIndex = 21;
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
            this.cmbFilterDaywise.Location = new System.Drawing.Point(150, 62);
            this.cmbFilterDaywise.Name = "cmbFilterDaywise";
            this.cmbFilterDaywise.ShadowDecoration.Parent = this.cmbFilterDaywise;
            this.cmbFilterDaywise.Size = new System.Drawing.Size(140, 36);
            this.cmbFilterDaywise.TabIndex = 17;
            this.cmbFilterDaywise.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDaywise_SelectedIndexChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.FillColor = System.Drawing.Color.White;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.HoveredState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(439, 137);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(145, 36);
            this.dtpToDate.TabIndex = 20;
            this.dtpToDate.Value = new System.DateTime(2026, 2, 13, 21, 29, 1, 1);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.FillColor = System.Drawing.Color.White;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.HoveredState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(150, 137);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(150, 36);
            this.dtpFromDate.TabIndex = 19;
            this.dtpFromDate.Value = new System.DateTime(2026, 2, 13, 21, 28, 53, 267);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.chart1GraphicalView);
            this.siticonePanel1.Location = new System.Drawing.Point(23, 200);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1356, 550);
            this.siticonePanel1.TabIndex = 23;
            // 
            // chart1GraphicalView
            // 
            chartArea1.AxisX.Title = "Ticket Status";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Ticket Count";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1GraphicalView.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1GraphicalView.Legends.Add(legend1);
            this.chart1GraphicalView.Location = new System.Drawing.Point(18, 25);
            this.chart1GraphicalView.Name = "chart1GraphicalView";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Tickets";
            this.chart1GraphicalView.Series.Add(series1);
            this.chart1GraphicalView.Size = new System.Drawing.Size(1315, 498);
            this.chart1GraphicalView.TabIndex = 18;
            this.chart1GraphicalView.Text = "chart1";
            title1.Name = "Employee Name";
            this.chart1GraphicalView.Titles.Add(title1);
            this.chart1GraphicalView.Click += new System.EventHandler(this.chart1GraphicalView_Click);
            this.chart1GraphicalView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1GraphicalView_MouseClick);
            // 
            // frmEmployeeViewChartTypeColumnMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 777);
            this.Controls.Add(this.pnlReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeViewChartTypeColumnMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeViewChartTypeColumnMB";
            this.Load += new System.EventHandler(this.frmEmployeeViewChartTypeColumnMB_Load);
            this.pnlReport1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1GraphicalView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel pnlReport1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneLabel lblToDate;
        private Siticone.UI.WinForms.SiticoneLabel lblFilter;
        private Siticone.UI.WinForms.SiticoneLabel lblFromDate;
        private Siticone.UI.WinForms.SiticoneComboBox cmbFilterDaywise;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpToDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dtpFromDate;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1GraphicalView;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}