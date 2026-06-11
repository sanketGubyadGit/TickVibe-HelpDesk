namespace TickVibe
{
    partial class frmNewticketSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewticketSG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewTicketAC = new System.Windows.Forms.TabControl();
            this.Ticket = new System.Windows.Forms.TabPage();
            this.pnlNewfilter = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.lblNToDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.dateTimePicker1 = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.cmbbxpPriority = new Siticone.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new Siticone.UI.WinForms.SiticoneTextBox();
            this.btnFilter = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneCirclePictureBox2 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.btnReload = new Siticone.UI.WinForms.SiticonePictureBox();
            this.grdNewTicket = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.AssignTicket = new System.Windows.Forms.TabPage();
            this.DueSoonTickets = new System.Windows.Forms.TabPage();
            this.OverDou = new System.Windows.Forms.TabPage();
            this.HoldTicket = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Resolved = new System.Windows.Forms.TabPage();
            this.CloseTicket = new System.Windows.Forms.TabPage();
            this.NTICKET = new System.Windows.Forms.TabPage();
            this.NewTicketAC.SuspendLayout();
            this.Ticket.SuspendLayout();
            this.pnlNewfilter.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNewTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // NewTicketAC
            // 
            this.NewTicketAC.Controls.Add(this.Ticket);
            this.NewTicketAC.Controls.Add(this.AssignTicket);
            this.NewTicketAC.Controls.Add(this.DueSoonTickets);
            this.NewTicketAC.Controls.Add(this.OverDou);
            this.NewTicketAC.Controls.Add(this.HoldTicket);
            this.NewTicketAC.Controls.Add(this.tabPage5);
            this.NewTicketAC.Controls.Add(this.Resolved);
            this.NewTicketAC.Controls.Add(this.CloseTicket);
            this.NewTicketAC.Controls.Add(this.NTICKET);
            this.NewTicketAC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NewTicketAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTicketAC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewTicketAC.ItemSize = new System.Drawing.Size(120, 40);
            this.NewTicketAC.Location = new System.Drawing.Point(23, 11);
            this.NewTicketAC.Margin = new System.Windows.Forms.Padding(2);
            this.NewTicketAC.Name = "NewTicketAC";
            this.NewTicketAC.SelectedIndex = 0;
            this.NewTicketAC.ShowToolTips = true;
            this.NewTicketAC.Size = new System.Drawing.Size(1627, 925);
            this.NewTicketAC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NewTicketAC.TabIndex = 23;
            this.NewTicketAC.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // Ticket
            // 
            this.Ticket.Controls.Add(this.pnlNewfilter);
            this.Ticket.Controls.Add(this.siticonePanel1);
            this.Ticket.Controls.Add(this.grdNewTicket);
            this.Ticket.Location = new System.Drawing.Point(4, 44);
            this.Ticket.Margin = new System.Windows.Forms.Padding(2);
            this.Ticket.Name = "Ticket";
            this.Ticket.Padding = new System.Windows.Forms.Padding(2);
            this.Ticket.Size = new System.Drawing.Size(1619, 877);
            this.Ticket.TabIndex = 0;
            this.Ticket.Text = "Ticket";
            this.Ticket.UseVisualStyleBackColor = true;
            this.Ticket.Click += new System.EventHandler(this.NewTicket_Click);
            // 
            // pnlNewfilter
            // 
            this.pnlNewfilter.Controls.Add(this.dateTimePicker2);
            this.pnlNewfilter.Controls.Add(this.lblNToDate);
            this.pnlNewfilter.Controls.Add(this.dateTimePicker1);
            this.pnlNewfilter.Controls.Add(this.cmbbxpPriority);
            this.pnlNewfilter.Controls.Add(this.label2);
            this.pnlNewfilter.Controls.Add(this.label3);
            this.pnlNewfilter.Location = new System.Drawing.Point(27, 92);
            this.pnlNewfilter.Name = "pnlNewfilter";
            this.pnlNewfilter.Size = new System.Drawing.Size(1558, 149);
            this.pnlNewfilter.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CheckedState.Parent = this.dateTimePicker2;
            this.dateTimePicker2.FillColor = System.Drawing.Color.White;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker2.HoveredState.Parent = this.dateTimePicker2;
            this.dateTimePicker2.Location = new System.Drawing.Point(1016, 65);
            this.dateTimePicker2.MaxDate = new System.DateTime(2026, 8, 30, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShadowDecoration.Parent = this.dateTimePicker2;
            this.dateTimePicker2.Size = new System.Drawing.Size(227, 34);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2026, 8, 29, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dtpNToDate_ValueChanged);
            // 
            // lblNToDate
            // 
            this.lblNToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblNToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNToDate.Location = new System.Drawing.Point(924, 69);
            this.lblNToDate.Name = "lblNToDate";
            this.lblNToDate.Size = new System.Drawing.Size(72, 22);
            this.lblNToDate.TabIndex = 12;
            this.lblNToDate.Text = "To Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.FillColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoveredState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 69);
            this.dateTimePicker1.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 30);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2026, 1, 1, 7, 56, 0, 0);
            // 
            // cmbbxpPriority
            // 
            this.cmbbxpPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxpPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxpPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxpPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxpPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxpPriority.FormattingEnabled = true;
            this.cmbbxpPriority.HoveredState.Parent = this.cmbbxpPriority;
            this.cmbbxpPriority.ItemHeight = 30;
            this.cmbbxpPriority.ItemsAppearance.Parent = this.cmbbxpPriority;
            this.cmbbxpPriority.Location = new System.Drawing.Point(108, 65);
            this.cmbbxpPriority.Name = "cmbbxpPriority";
            this.cmbbxpPriority.ShadowDecoration.Parent = this.cmbbxpPriority;
            this.cmbbxpPriority.Size = new System.Drawing.Size(190, 36);
            this.cmbbxpPriority.TabIndex = 8;
            this.cmbbxpPriority.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priority : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "From Date:";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.TxtSearch);
            this.siticonePanel1.Controls.Add(this.btnFilter);
            this.siticonePanel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticonePanel1.Controls.Add(this.siticoneCirclePictureBox2);
            this.siticonePanel1.Controls.Add(this.btnReload);
            this.siticonePanel1.Location = new System.Drawing.Point(27, 14);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1558, 61);
            this.siticonePanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.Parent = this.TxtSearch;
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.FocusedState.Parent = this.TxtSearch;
            this.TxtSearch.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.HoveredState.Parent = this.TxtSearch;
            this.TxtSearch.IconLeft = global::TickVibe.Properties.Resources.search;
            this.TxtSearch.Location = new System.Drawing.Point(28, 14);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderText = "";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(236, 36);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged_1);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoveredState.Parent = this.btnFilter;
            this.btnFilter.Image = global::TickVibe.Properties.Resources.filter;
            this.btnFilter.Location = new System.Drawing.Point(1419, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(126, 45);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox1.Image")));
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(1263, 14);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox1.TabIndex = 4;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.Click += new System.EventHandler(this.siticoneCirclePictureBox1_Click_1);
            // 
            // siticoneCirclePictureBox2
            // 
            this.siticoneCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox2.Image")));
            this.siticoneCirclePictureBox2.Location = new System.Drawing.Point(1309, 14);
            this.siticoneCirclePictureBox2.Name = "siticoneCirclePictureBox2";
            this.siticoneCirclePictureBox2.ShadowDecoration.Parent = this.siticoneCirclePictureBox2;
            this.siticoneCirclePictureBox2.Size = new System.Drawing.Size(40, 40);
            this.siticoneCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox2.TabIndex = 4;
            this.siticoneCirclePictureBox2.TabStop = false;
            this.siticoneCirclePictureBox2.Click += new System.EventHandler(this.siticoneCirclePictureBox2_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(1367, 14);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(40, 40);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 15;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.pcbNTRefresh_Click);
            // 
            // grdNewTicket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdNewTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdNewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.grdNewTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdNewTicket.BackgroundColor = System.Drawing.Color.White;
            this.grdNewTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdNewTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdNewTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNewTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdNewTicket.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNewTicket.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdNewTicket.EnableHeadersVisualStyles = false;
            this.grdNewTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdNewTicket.Location = new System.Drawing.Point(28, 270);
            this.grdNewTicket.Margin = new System.Windows.Forms.Padding(2);
            this.grdNewTicket.Name = "grdNewTicket";
            this.grdNewTicket.RowHeadersVisible = false;
            this.grdNewTicket.RowHeadersWidth = 51;
            this.grdNewTicket.RowTemplate.Height = 24;
            this.grdNewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNewTicket.Size = new System.Drawing.Size(1557, 585);
            this.grdNewTicket.TabIndex = 10;
            this.grdNewTicket.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.grdNewTicket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.grdNewTicket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdNewTicket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdNewTicket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdNewTicket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdNewTicket.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdNewTicket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.grdNewTicket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grdNewTicket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdNewTicket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdNewTicket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdNewTicket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdNewTicket.ThemeStyle.HeaderStyle.Height = 4;
            this.grdNewTicket.ThemeStyle.ReadOnly = false;
            this.grdNewTicket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.grdNewTicket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdNewTicket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdNewTicket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdNewTicket.ThemeStyle.RowsStyle.Height = 24;
            this.grdNewTicket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.grdNewTicket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdNewTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNewTicket_CellContentClick);
            // 
            // AssignTicket
            // 
            this.AssignTicket.Location = new System.Drawing.Point(4, 44);
            this.AssignTicket.Margin = new System.Windows.Forms.Padding(2);
            this.AssignTicket.Name = "AssignTicket";
            this.AssignTicket.Padding = new System.Windows.Forms.Padding(2);
            this.AssignTicket.Size = new System.Drawing.Size(1633, 877);
            this.AssignTicket.TabIndex = 1;
            this.AssignTicket.Text = "AssignTicket";
            this.AssignTicket.UseVisualStyleBackColor = true;
            this.AssignTicket.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // DueSoonTickets
            // 
            this.DueSoonTickets.Location = new System.Drawing.Point(4, 44);
            this.DueSoonTickets.Margin = new System.Windows.Forms.Padding(2);
            this.DueSoonTickets.Name = "DueSoonTickets";
            this.DueSoonTickets.Padding = new System.Windows.Forms.Padding(2);
            this.DueSoonTickets.Size = new System.Drawing.Size(1633, 877);
            this.DueSoonTickets.TabIndex = 2;
            this.DueSoonTickets.Text = "Due Soon Tickets";
            this.DueSoonTickets.UseVisualStyleBackColor = true;
            // 
            // OverDou
            // 
            this.OverDou.Location = new System.Drawing.Point(4, 44);
            this.OverDou.Margin = new System.Windows.Forms.Padding(2);
            this.OverDou.Name = "OverDou";
            this.OverDou.Padding = new System.Windows.Forms.Padding(2);
            this.OverDou.Size = new System.Drawing.Size(1633, 877);
            this.OverDou.TabIndex = 3;
            this.OverDou.Text = "Over Due";
            this.OverDou.UseVisualStyleBackColor = true;
            // 
            // HoldTicket
            // 
            this.HoldTicket.Location = new System.Drawing.Point(4, 44);
            this.HoldTicket.Margin = new System.Windows.Forms.Padding(2);
            this.HoldTicket.Name = "HoldTicket";
            this.HoldTicket.Padding = new System.Windows.Forms.Padding(2);
            this.HoldTicket.Size = new System.Drawing.Size(1633, 877);
            this.HoldTicket.TabIndex = 4;
            this.HoldTicket.Text = "Hold Ticket";
            this.HoldTicket.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1633, 877);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Esclate Tickets ";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // Resolved
            // 
            this.Resolved.Location = new System.Drawing.Point(4, 44);
            this.Resolved.Margin = new System.Windows.Forms.Padding(2);
            this.Resolved.Name = "Resolved";
            this.Resolved.Padding = new System.Windows.Forms.Padding(2);
            this.Resolved.Size = new System.Drawing.Size(1633, 877);
            this.Resolved.TabIndex = 6;
            this.Resolved.Text = "Resolved";
            this.Resolved.UseVisualStyleBackColor = true;
            // 
            // CloseTicket
            // 
            this.CloseTicket.Location = new System.Drawing.Point(4, 44);
            this.CloseTicket.Margin = new System.Windows.Forms.Padding(2);
            this.CloseTicket.Name = "CloseTicket";
            this.CloseTicket.Padding = new System.Windows.Forms.Padding(2);
            this.CloseTicket.Size = new System.Drawing.Size(1633, 877);
            this.CloseTicket.TabIndex = 7;
            this.CloseTicket.Text = "Close Ticket";
            this.CloseTicket.UseVisualStyleBackColor = true;
            // 
            // NTICKET
            // 
            this.NTICKET.Location = new System.Drawing.Point(4, 44);
            this.NTICKET.Margin = new System.Windows.Forms.Padding(2);
            this.NTICKET.Name = "NTICKET";
            this.NTICKET.Padding = new System.Windows.Forms.Padding(2);
            this.NTICKET.Size = new System.Drawing.Size(1633, 877);
            this.NTICKET.TabIndex = 8;
            this.NTICKET.Text = "NewTicket";
            this.NTICKET.UseVisualStyleBackColor = true;
            this.NTICKET.Click += new System.EventHandler(this.NTICKET_Click);
            // 
            // frmNewticketSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 933);
            this.Controls.Add(this.NewTicketAC);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewticketSG";
            this.Text = "frmNewticketSG";
            this.Load += new System.EventHandler(this.frmNewticketSG_Load);
            this.NewTicketAC.ResumeLayout(false);
            this.Ticket.ResumeLayout(false);
            this.pnlNewfilter.ResumeLayout(false);
            this.pnlNewfilter.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNewTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl NewTicketAC;
        private Siticone.UI.WinForms.SiticoneDataGridView grdNewTicket;
        private System.Windows.Forms.TabPage Ticket;
        private System.Windows.Forms.TabPage AssignTicket;
        private System.Windows.Forms.TabPage DueSoonTickets;
        private System.Windows.Forms.TabPage OverDou;
        private System.Windows.Forms.TabPage HoldTicket;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage Resolved;
        private System.Windows.Forms.TabPage CloseTicket;
        private System.Windows.Forms.TabPage NTICKET;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneTextBox TxtSearch;
        private Siticone.UI.WinForms.SiticoneButton btnFilter;
        private Siticone.UI.WinForms.SiticonePictureBox siticoneCirclePictureBox1;
        private Siticone.UI.WinForms.SiticonePictureBox siticoneCirclePictureBox2;
        private Siticone.UI.WinForms.SiticonePictureBox btnReload;
        private System.Windows.Forms.Panel pnlNewfilter;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dateTimePicker2;
        private Siticone.UI.WinForms.SiticoneLabel lblNToDate;
        private Siticone.UI.WinForms.SiticoneDateTimePicker dateTimePicker1;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxpPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}