
namespace TickVibe
{
    partial class frmViewTicketVN
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtsearchBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEMPCode = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShadowPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.gridViewAllRaisedTicket = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnSearchBox = new System.Windows.Forms.Button();
            this.siticoneShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllRaisedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton1.BorderRadius = 5;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(1094, 137);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(165, 37);
            this.siticoneButton1.TabIndex = 25;
            this.siticoneButton1.Text = "CreateTicket";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // txtsearchBox
            // 
            this.txtsearchBox.BorderColor = System.Drawing.Color.Black;
            this.txtsearchBox.BorderRadius = 6;
            this.txtsearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchBox.DefaultText = "";
            this.txtsearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtsearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtsearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchBox.Location = new System.Drawing.Point(98, 150);
            this.txtsearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearchBox.Name = "txtsearchBox";
            this.txtsearchBox.PasswordChar = '\0';
            this.txtsearchBox.PlaceholderText = "";
            this.txtsearchBox.SelectedText = "";
            this.txtsearchBox.Size = new System.Drawing.Size(247, 35);
            this.txtsearchBox.TabIndex = 21;
            this.txtsearchBox.TextOffset = new System.Drawing.Point(60, 0);
            this.txtsearchBox.TextChanged += new System.EventHandler(this.txtsearchBox_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(396, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(346, 79);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(335, 63);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact";
            this.lblContact.Visible = false;
            // 
            // lblEMPCode
            // 
            this.lblEMPCode.AutoSize = true;
            this.lblEMPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEMPCode.Location = new System.Drawing.Point(207, 109);
            this.lblEMPCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMPCode.Name = "lblEMPCode";
            this.lblEMPCode.Size = new System.Drawing.Size(77, 17);
            this.lblEMPCode.TabIndex = 16;
            this.lblEMPCode.Text = "EMPCode";
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(1269, 8);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 17);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 175;
            this.label1.Text = "View_Tickets";
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.AutoSize = true;
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siticoneShadowPanel1.Controls.Add(this.gridViewAllRaisedTicket);
            this.siticoneShadowPanel1.Controls.Add(this.label1);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneButton2);
            this.siticoneShadowPanel1.Controls.Add(this.lblExit);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneButton1);
            this.siticoneShadowPanel1.Controls.Add(this.lblEMPCode);
            this.siticoneShadowPanel1.Controls.Add(this.btnExcel);
            this.siticoneShadowPanel1.Controls.Add(this.lblContact);
            this.siticoneShadowPanel1.Controls.Add(this.btnPdf);
            this.siticoneShadowPanel1.Controls.Add(this.lblEmail);
            this.siticoneShadowPanel1.Controls.Add(this.btnSearchBox);
            this.siticoneShadowPanel1.Controls.Add(this.lblName);
            this.siticoneShadowPanel1.Controls.Add(this.txtsearchBox);
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 5;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(1300, 700);
            this.siticoneShadowPanel1.TabIndex = 1;
            this.siticoneShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneShadowPanel1_Paint);
            // 
            // gridViewAllRaisedTicket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.gridViewAllRaisedTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAllRaisedTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewAllRaisedTicket.ColumnHeadersHeight = 4;
            this.gridViewAllRaisedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewAllRaisedTicket.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewAllRaisedTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.gridViewAllRaisedTicket.Location = new System.Drawing.Point(66, 269);
            this.gridViewAllRaisedTicket.Name = "gridViewAllRaisedTicket";
            this.gridViewAllRaisedTicket.RowHeadersVisible = false;
            this.gridViewAllRaisedTicket.Size = new System.Drawing.Size(1193, 375);
            this.gridViewAllRaisedTicket.TabIndex = 176;
            this.gridViewAllRaisedTicket.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.gridViewAllRaisedTicket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.gridViewAllRaisedTicket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewAllRaisedTicket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewAllRaisedTicket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewAllRaisedTicket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewAllRaisedTicket.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewAllRaisedTicket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewAllRaisedTicket.ThemeStyle.HeaderStyle.Height = 4;
            this.gridViewAllRaisedTicket.ThemeStyle.ReadOnly = false;
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.Height = 22;
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.gridViewAllRaisedTicket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewAllRaisedTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAllRaisedTicket_CellClick);
            this.gridViewAllRaisedTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAllRaisedTicket_CellContentClick_1);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton2.BackgroundImage = global::TickVibe.Properties.Resources.send;
            this.siticoneButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siticoneButton2.BorderRadius = 5;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(1101, 143);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(29, 25);
            this.siticoneButton2.TabIndex = 165;
            this.siticoneButton2.Text = " ";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::TickVibe.Properties.Resources.xls__2_;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(1186, 213);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(47, 38);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = global::TickVibe.Properties.Resources.pdf__3_;
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Location = new System.Drawing.Point(1135, 213);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(47, 38);
            this.btnPdf.TabIndex = 23;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnSearchBox
            // 
            this.btnSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBox.BackgroundImage = global::TickVibe.Properties.Resources.search;
            this.btnSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchBox.FlatAppearance.BorderSize = 0;
            this.btnSearchBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBox.Location = new System.Drawing.Point(105, 158);
            this.btnSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBox.Name = "btnSearchBox";
            this.btnSearchBox.Size = new System.Drawing.Size(28, 16);
            this.btnSearchBox.TabIndex = 22;
            this.btnSearchBox.UseVisualStyleBackColor = false;
            this.btnSearchBox.Click += new System.EventHandler(this.btnSearchBox_Click);
            // 
            // frmViewTicketVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(171, 148);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewTicketVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewTicketVN";
            this.Load += new System.EventHandler(this.frmViewTicketVN_Load);
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllRaisedTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEMPCode;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSearchBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtsearchBox;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridViewAllRaisedTicket;
    }
}