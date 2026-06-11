namespace TickVibe
{
    partial class frmEmployeeDetailsSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDetailsSB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adtToDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.adtFromDate = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rtbSerchBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.pcbExcel = new System.Windows.Forms.PictureBox();
            this.pcbPdf = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnxl = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEMPCode = new System.Windows.Forms.Label();
            this.grdEmployeDetailes = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeDetailes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adtToDate);
            this.panel1.Controls.Add(this.adtFromDate);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Controls.Add(this.rtbSerchBox);
            this.panel1.Controls.Add(this.pcbRefresh);
            this.panel1.Controls.Add(this.pcbExcel);
            this.panel1.Controls.Add(this.pcbPdf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnxl);
            this.panel1.Controls.Add(this.btnCsv);
            this.panel1.Location = new System.Drawing.Point(34, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 187);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // adtToDate
            // 
            this.adtToDate.CheckedState.Parent = this.adtToDate;
            this.adtToDate.FillColor = System.Drawing.Color.White;
            this.adtToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.adtToDate.HoveredState.Parent = this.adtToDate;
            this.adtToDate.Location = new System.Drawing.Point(986, 126);
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
            this.adtFromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.adtFromDate.HoveredState.Parent = this.adtFromDate;
            this.adtFromDate.Location = new System.Drawing.Point(500, 126);
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
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(881, 137);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(83, 20);
            this.lblToDate.TabIndex = 19;
            this.lblToDate.Text = "To Date :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(377, 137);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(98, 18);
            this.lblFromDate.TabIndex = 18;
            this.lblFromDate.Text = "From Date :";
            // 
            // rtbSerchBox
            // 
            this.rtbSerchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbSerchBox.DefaultText = "";
            this.rtbSerchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtbSerchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtbSerchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtbSerchBox.DisabledState.Parent = this.rtbSerchBox;
            this.rtbSerchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtbSerchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSerchBox.FocusedState.Parent = this.rtbSerchBox;
            this.rtbSerchBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSerchBox.HoveredState.Parent = this.rtbSerchBox;
            this.rtbSerchBox.IconLeft = global::TickVibe.Properties.Resources.search;
            this.rtbSerchBox.Location = new System.Drawing.Point(61, 132);
            this.rtbSerchBox.Name = "rtbSerchBox";
            this.rtbSerchBox.PasswordChar = '\0';
            this.rtbSerchBox.PlaceholderText = "";
            this.rtbSerchBox.SelectedText = "";
            this.rtbSerchBox.ShadowDecoration.Parent = this.rtbSerchBox;
            this.rtbSerchBox.Size = new System.Drawing.Size(236, 36);
            this.rtbSerchBox.TabIndex = 17;
            this.rtbSerchBox.TextChanged += new System.EventHandler(this.rtbSerchBox_TextChanged);
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.Image = global::TickVibe.Properties.Resources.refresh;
            this.pcbRefresh.Location = new System.Drawing.Point(1529, 126);
            this.pcbRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(40, 40);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRefresh.TabIndex = 16;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click);
            // 
            // pcbExcel
            // 
            this.pcbExcel.Image = ((System.Drawing.Image)(resources.GetObject("pcbExcel.Image")));
            this.pcbExcel.Location = new System.Drawing.Point(1482, 126);
            this.pcbExcel.Margin = new System.Windows.Forms.Padding(2);
            this.pcbExcel.Name = "pcbExcel";
            this.pcbExcel.Size = new System.Drawing.Size(40, 40);
            this.pcbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbExcel.TabIndex = 15;
            this.pcbExcel.TabStop = false;
            this.pcbExcel.Click += new System.EventHandler(this.pcbExcel_Click);
            // 
            // pcbPdf
            // 
            this.pcbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pcbPdf.Image")));
            this.pcbPdf.Location = new System.Drawing.Point(1433, 126);
            this.pcbPdf.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPdf.Name = "pcbPdf";
            this.pcbPdf.Size = new System.Drawing.Size(40, 40);
            this.pcbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPdf.TabIndex = 13;
            this.pcbPdf.TabStop = false;
            this.pcbPdf.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(660, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 40);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(720, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Employee List ";
            // 
            // btnxl
            // 
            this.btnxl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxl.FlatAppearance.BorderSize = 0;
            this.btnxl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxl.Location = new System.Drawing.Point(616, 28);
            this.btnxl.Margin = new System.Windows.Forms.Padding(2);
            this.btnxl.Name = "btnxl";
            this.btnxl.Size = new System.Drawing.Size(40, 63);
            this.btnxl.TabIndex = 11;
            this.btnxl.UseVisualStyleBackColor = true;
            this.btnxl.Click += new System.EventHandler(this.btnxl_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCsv.FlatAppearance.BorderSize = 0;
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsv.Location = new System.Drawing.Point(380, 40);
            this.btnCsv.Margin = new System.Windows.Forms.Padding(2);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(38, 40);
            this.btnCsv.TabIndex = 10;
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 535);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            this.lblCategory.Visible = false;
            // 
            // lblEMPCode
            // 
            this.lblEMPCode.AutoSize = true;
            this.lblEMPCode.Location = new System.Drawing.Point(17, 441);
            this.lblEMPCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMPCode.Name = "lblEMPCode";
            this.lblEMPCode.Size = new System.Drawing.Size(55, 13);
            this.lblEMPCode.TabIndex = 17;
            this.lblEMPCode.Text = "EMPCode";
            this.lblEMPCode.Visible = false;
            // 
            // grdEmployeDetailes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeDetailes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEmployeDetailes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmployeDetailes.BackgroundColor = System.Drawing.Color.White;
            this.grdEmployeDetailes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEmployeDetailes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeDetailes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmployeDetailes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEmployeDetailes.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmployeDetailes.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdEmployeDetailes.EnableHeadersVisualStyles = false;
            this.grdEmployeDetailes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeDetailes.Location = new System.Drawing.Point(34, 269);
            this.grdEmployeDetailes.Margin = new System.Windows.Forms.Padding(2);
            this.grdEmployeDetailes.Name = "grdEmployeDetailes";
            this.grdEmployeDetailes.RowHeadersVisible = false;
            this.grdEmployeDetailes.RowHeadersWidth = 51;
            this.grdEmployeDetailes.RowTemplate.Height = 24;
            this.grdEmployeDetailes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeDetailes.Size = new System.Drawing.Size(1596, 604);
            this.grdEmployeDetailes.TabIndex = 2;
            this.grdEmployeDetailes.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdEmployeDetailes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdEmployeDetailes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdEmployeDetailes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdEmployeDetailes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdEmployeDetailes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdEmployeDetailes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdEmployeDetailes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdEmployeDetailes.ThemeStyle.HeaderStyle.Height = 4;
            this.grdEmployeDetailes.ThemeStyle.ReadOnly = false;
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.Height = 24;
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdEmployeDetailes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdEmployeDetailes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployeDetailes_CellContentClick_1);
            // 
            // frmEmployeeDetailsSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 884);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.grdEmployeDetailes);
            this.Controls.Add(this.lblEMPCode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(165, 144);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmployeeDetailsSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeDetailsSB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeDetailes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnxl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbRefresh;
        private System.Windows.Forms.PictureBox pcbExcel;
        private System.Windows.Forms.PictureBox pcbPdf;
        private Siticone.UI.WinForms.SiticoneDataGridView grdEmployeDetailes;
        private System.Windows.Forms.Label lblEMPCode;
        private System.Windows.Forms.Label lblCategory;
        private Siticone.UI.WinForms.SiticoneTextBox rtbSerchBox;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker adtFromDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker adtToDate;
    }
}

