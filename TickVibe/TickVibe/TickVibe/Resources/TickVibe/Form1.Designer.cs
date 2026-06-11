namespace TickVibe
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbClosedTCsv = new System.Windows.Forms.PictureBox();
            this.pcbClosedTPdf = new Siticone.UI.WinForms.SiticonePictureBox();
            this.pcbClosedTRefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.btnClosedTFilter = new Siticone.UI.WinForms.SiticoneButton();
            this.txtSearchBoxCloseT = new Siticone.UI.WinForms.SiticoneTextBox();
            this.pcbClosedTXl = new Siticone.UI.WinForms.SiticonePictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.btnCreateTicket = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneDataGridView1 = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneComboBox3 = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox1 = new Siticone.UI.WinForms.SiticoneComboBox();
            this.lblTicketCode = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblCreatedDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblPriority = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTXl)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(91, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 43);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.987162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.988588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.559201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39372F));
            this.tableLayoutPanel1.Controls.Add(this.pcbClosedTCsv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcbClosedTPdf, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcbClosedTRefresh, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClosedTFilter, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchBoxCloseT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcbClosedTXl, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pcbClosedTCsv
            // 
            this.pcbClosedTCsv.Image = global::TickVibe.Properties.Resources.csv;
            this.pcbClosedTCsv.Location = new System.Drawing.Point(299, 3);
            this.pcbClosedTCsv.Name = "pcbClosedTCsv";
            this.pcbClosedTCsv.Size = new System.Drawing.Size(29, 33);
            this.pcbClosedTCsv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClosedTCsv.TabIndex = 18;
            this.pcbClosedTCsv.TabStop = false;
            // 
            // pcbClosedTPdf
            // 
            this.pcbClosedTPdf.Image = global::TickVibe.Properties.Resources.pdf;
            this.pcbClosedTPdf.Location = new System.Drawing.Point(361, 3);
            this.pcbClosedTPdf.Name = "pcbClosedTPdf";
            this.pcbClosedTPdf.ShadowDecoration.Parent = this.pcbClosedTPdf;
            this.pcbClosedTPdf.Size = new System.Drawing.Size(28, 33);
            this.pcbClosedTPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClosedTPdf.TabIndex = 29;
            this.pcbClosedTPdf.TabStop = false;
            // 
            // pcbClosedTRefresh
            // 
            this.pcbClosedTRefresh.Image = global::TickVibe.Properties.Resources.refresh;
            this.pcbClosedTRefresh.Location = new System.Drawing.Point(467, 3);
            this.pcbClosedTRefresh.Name = "pcbClosedTRefresh";
            this.pcbClosedTRefresh.ShadowDecoration.Parent = this.pcbClosedTRefresh;
            this.pcbClosedTRefresh.Size = new System.Drawing.Size(24, 33);
            this.pcbClosedTRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClosedTRefresh.TabIndex = 27;
            this.pcbClosedTRefresh.TabStop = false;
            // 
            // btnClosedTFilter
            // 
            this.btnClosedTFilter.CheckedState.Parent = this.btnClosedTFilter;
            this.btnClosedTFilter.CustomImages.Parent = this.btnClosedTFilter;
            this.btnClosedTFilter.FillColor = System.Drawing.Color.White;
            this.btnClosedTFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClosedTFilter.ForeColor = System.Drawing.Color.Black;
            this.btnClosedTFilter.HoveredState.Parent = this.btnClosedTFilter;
            this.btnClosedTFilter.Image = global::TickVibe.Properties.Resources.filter;
            this.btnClosedTFilter.Location = new System.Drawing.Point(526, 3);
            this.btnClosedTFilter.Name = "btnClosedTFilter";
            this.btnClosedTFilter.ShadowDecoration.Parent = this.btnClosedTFilter;
            this.btnClosedTFilter.Size = new System.Drawing.Size(125, 31);
            this.btnClosedTFilter.TabIndex = 2;
            this.btnClosedTFilter.Text = "Filter";
            this.btnClosedTFilter.Click += new System.EventHandler(this.btnClosedTFilter_Click);
            // 
            // txtSearchBoxCloseT
            // 
            this.txtSearchBoxCloseT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBoxCloseT.DefaultText = "";
            this.txtSearchBoxCloseT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBoxCloseT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBoxCloseT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBoxCloseT.DisabledState.Parent = this.txtSearchBoxCloseT;
            this.txtSearchBoxCloseT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBoxCloseT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBoxCloseT.FocusedState.Parent = this.txtSearchBoxCloseT;
            this.txtSearchBoxCloseT.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBoxCloseT.HoveredState.Parent = this.txtSearchBoxCloseT;
            this.txtSearchBoxCloseT.IconLeft = global::TickVibe.Properties.Resources.search;
            this.txtSearchBoxCloseT.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearchBoxCloseT.Location = new System.Drawing.Point(3, 3);
            this.txtSearchBoxCloseT.Name = "txtSearchBoxCloseT";
            this.txtSearchBoxCloseT.PasswordChar = '\0';
            this.txtSearchBoxCloseT.PlaceholderText = "";
            this.txtSearchBoxCloseT.SelectedText = "";
            this.txtSearchBoxCloseT.ShadowDecoration.Parent = this.txtSearchBoxCloseT;
            this.txtSearchBoxCloseT.Size = new System.Drawing.Size(234, 33);
            this.txtSearchBoxCloseT.TabIndex = 14;
            // 
            // pcbClosedTXl
            // 
           // this.pcbClosedTXl.Image = global::TickVibe.Properties.Resources.xlsx__1_;
            this.pcbClosedTXl.Location = new System.Drawing.Point(412, 3);
            this.pcbClosedTXl.Name = "pcbClosedTXl";
            this.pcbClosedTXl.ShadowDecoration.Parent = this.pcbClosedTXl;
            this.pcbClosedTXl.Size = new System.Drawing.Size(27, 33);
            this.pcbClosedTXl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClosedTXl.TabIndex = 28;
            this.pcbClosedTXl.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(44, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 35);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(824, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(824, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(824, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.siticonePanel1.Controls.Add(this.btnCreateTicket);
            this.siticonePanel1.Controls.Add(this.siticoneDataGridView1);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.panel1);
            this.siticonePanel1.Controls.Add(this.tabControl1);
            this.siticonePanel1.Location = new System.Drawing.Point(93, 12);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(923, 570);
            this.siticonePanel1.TabIndex = 2;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.CheckedState.Parent = this.btnCreateTicket;
            this.btnCreateTicket.CustomImages.Parent = this.btnCreateTicket;
            this.btnCreateTicket.FillColor = System.Drawing.Color.DimGray;
            this.btnCreateTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateTicket.ForeColor = System.Drawing.Color.White;
            this.btnCreateTicket.HoveredState.Parent = this.btnCreateTicket;
            this.btnCreateTicket.Location = new System.Drawing.Point(752, 29);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.ShadowDecoration.Parent = this.btnCreateTicket;
            this.btnCreateTicket.Size = new System.Drawing.Size(124, 34);
            this.btnCreateTicket.TabIndex = 4;
            this.btnCreateTicket.Text = " + Create Ticket";
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siticoneDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(52, 278);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(824, 205);
            this.siticoneDataGridView1.TabIndex = 3;
            this.siticoneDataGridView1.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.Controls.Add(this.siticoneComboBox3);
            this.siticonePanel2.Controls.Add(this.siticoneComboBox1);
            this.siticonePanel2.Controls.Add(this.lblTicketCode);
            this.siticonePanel2.Controls.Add(this.lblCreatedDate);
            this.siticonePanel2.Controls.Add(this.lblPriority);
            this.siticonePanel2.Location = new System.Drawing.Point(116, 196);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(658, 48);
            this.siticonePanel2.TabIndex = 2;
            // 
            // siticoneComboBox3
            // 
            this.siticoneComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox3.FormattingEnabled = true;
            this.siticoneComboBox3.HoveredState.Parent = this.siticoneComboBox3;
            this.siticoneComboBox3.ItemHeight = 30;
            this.siticoneComboBox3.ItemsAppearance.Parent = this.siticoneComboBox3;
            this.siticoneComboBox3.Location = new System.Drawing.Point(503, 9);
            this.siticoneComboBox3.Name = "siticoneComboBox3";
            this.siticoneComboBox3.ShadowDecoration.Parent = this.siticoneComboBox3;
            this.siticoneComboBox3.Size = new System.Drawing.Size(140, 36);
            this.siticoneComboBox3.TabIndex = 5;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.FormattingEnabled = true;
            this.siticoneComboBox1.HoveredState.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.ItemsAppearance.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Location = new System.Drawing.Point(43, 9);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.ShadowDecoration.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Size = new System.Drawing.Size(140, 36);
            this.siticoneComboBox1.TabIndex = 3;
            // 
            // lblTicketCode
            // 
            this.lblTicketCode.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketCode.Location = new System.Drawing.Point(436, 9);
            this.lblTicketCode.Name = "lblTicketCode";
            this.lblTicketCode.Size = new System.Drawing.Size(61, 15);
            this.lblTicketCode.TabIndex = 2;
            this.lblTicketCode.Text = "Ticket Code";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedDate.Location = new System.Drawing.Point(206, 9);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(66, 15);
            this.lblCreatedDate.TabIndex = 1;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // lblPriority
            // 
            this.lblPriority.BackColor = System.Drawing.Color.Transparent;
            this.lblPriority.Location = new System.Drawing.Point(3, 6);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(34, 15);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1153, 699);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClosedTXl)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearchBoxCloseT;
        private System.Windows.Forms.PictureBox pcbClosedTCsv;
        private Siticone.UI.WinForms.SiticonePictureBox pcbClosedTRefresh;
        private Siticone.UI.WinForms.SiticonePictureBox pcbClosedTPdf;
        private Siticone.UI.WinForms.SiticonePictureBox pcbClosedTXl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Siticone.UI.WinForms.SiticoneButton btnClosedTFilter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneLabel lblTicketCode;
        private Siticone.UI.WinForms.SiticoneLabel lblCreatedDate;
        private Siticone.UI.WinForms.SiticoneLabel lblPriority;
        private Siticone.UI.WinForms.SiticoneComboBox siticoneComboBox3;
        private Siticone.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.UI.WinForms.SiticoneButton btnCreateTicket;
        private Siticone.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
    }
}