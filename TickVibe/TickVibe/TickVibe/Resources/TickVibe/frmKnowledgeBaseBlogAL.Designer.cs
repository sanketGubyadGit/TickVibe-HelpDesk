namespace TickVibe
{
    partial class frmKnowledgeBaseBlogAL
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
            this.txtSB = new Siticone.UI.WinForms.SiticoneTextBox();
            this.cmbbxallcategories = new Siticone.UI.WinForms.SiticoneComboBox();
            this.cmbbxallstatuses = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPPublish = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEMPCode = new System.Windows.Forms.Label();
            this.pcbrefresh = new Siticone.UI.WinForms.SiticonePictureBox();
            this.flpBlog = new System.Windows.Forms.FlowLayoutPanel();
            this.BlogFilter = new System.Windows.Forms.PictureBox();
            this.btnBlogList = new System.Windows.Forms.Button();
            this.pcbSearchPublish = new Siticone.UI.WinForms.SiticonePictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateNewBlog = new Siticone.UI.WinForms.SiticoneButton();
            this.cmbbxallratings = new Siticone.UI.WinForms.SiticoneComboBox();
            this.ucBlog1 = new TickVibe.USBlog();
            this.siticonePanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPPublish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrefresh)).BeginInit();
            this.flpBlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlogFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchPublish)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSB
            // 
            this.txtSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSB.DefaultText = "";
            this.txtSB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSB.DisabledState.Parent = this.txtSB;
            this.txtSB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSB.FocusedState.Parent = this.txtSB;
            this.txtSB.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSB.HoveredState.Parent = this.txtSB;
            this.txtSB.Location = new System.Drawing.Point(230, 39);
            this.txtSB.Name = "txtSB";
            this.txtSB.PasswordChar = '\0';
            this.txtSB.PlaceholderText = "";
            this.txtSB.SelectedText = "";
            this.txtSB.ShadowDecoration.Parent = this.txtSB;
            this.txtSB.Size = new System.Drawing.Size(279, 38);
            this.txtSB.TabIndex = 0;
            this.txtSB.TextChanged += new System.EventHandler(this.txtSB_TextChanged);
            // 
            // cmbbxallcategories
            // 
            this.cmbbxallcategories.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxallcategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxallcategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxallcategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxallcategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxallcategories.FormattingEnabled = true;
            this.cmbbxallcategories.HoveredState.Parent = this.cmbbxallcategories;
            this.cmbbxallcategories.ItemHeight = 30;
            this.cmbbxallcategories.ItemsAppearance.Parent = this.cmbbxallcategories;
            this.cmbbxallcategories.Location = new System.Drawing.Point(6, 2);
            this.cmbbxallcategories.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxallcategories.Name = "cmbbxallcategories";
            this.cmbbxallcategories.ShadowDecoration.Parent = this.cmbbxallcategories;
            this.cmbbxallcategories.Size = new System.Drawing.Size(137, 36);
            this.cmbbxallcategories.TabIndex = 1;
            this.cmbbxallcategories.SelectedIndexChanged += new System.EventHandler(this.cmbbxallcategories_SelectedIndexChanged);
            // 
            // cmbbxallstatuses
            // 
            this.cmbbxallstatuses.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxallstatuses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxallstatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxallstatuses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxallstatuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxallstatuses.FormattingEnabled = true;
            this.cmbbxallstatuses.HoveredState.Parent = this.cmbbxallstatuses;
            this.cmbbxallstatuses.ItemHeight = 30;
            this.cmbbxallstatuses.ItemsAppearance.Parent = this.cmbbxallstatuses;
            this.cmbbxallstatuses.Location = new System.Drawing.Point(147, 2);
            this.cmbbxallstatuses.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxallstatuses.Name = "cmbbxallstatuses";
            this.cmbbxallstatuses.ShadowDecoration.Parent = this.cmbbxallstatuses;
            this.cmbbxallstatuses.Size = new System.Drawing.Size(144, 36);
            this.cmbbxallstatuses.TabIndex = 2;
            this.cmbbxallstatuses.SelectedIndexChanged += new System.EventHandler(this.cmbbxallstatuses_SelectedIndexChanged);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticonePanel1.Controls.Add(this.tabControl);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1677, 949);
            this.siticonePanel1.TabIndex = 3;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPPublish);
            this.tabControl.Location = new System.Drawing.Point(11, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1664, 945);
            this.tabControl.TabIndex = 5;
            this.tabControl.Tag = "";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPPublish
            // 
            this.tabPPublish.Controls.Add(this.label1);
            this.tabPPublish.Controls.Add(this.label2);
            this.tabPPublish.Controls.Add(this.lblEMPCode);
            this.tabPPublish.Controls.Add(this.pcbrefresh);
            this.tabPPublish.Controls.Add(this.flpBlog);
            this.tabPPublish.Controls.Add(this.BlogFilter);
            this.tabPPublish.Controls.Add(this.btnBlogList);
            this.tabPPublish.Controls.Add(this.pcbSearchPublish);
            this.tabPPublish.Controls.Add(this.txtSB);
            this.tabPPublish.Controls.Add(this.tableLayoutPanel1);
            this.tabPPublish.Location = new System.Drawing.Point(4, 22);
            this.tabPPublish.Margin = new System.Windows.Forms.Padding(2);
            this.tabPPublish.Name = "tabPPublish";
            this.tabPPublish.Padding = new System.Windows.Forms.Padding(2);
            this.tabPPublish.Size = new System.Drawing.Size(1656, 919);
            this.tabPPublish.TabIndex = 0;
            this.tabPPublish.Text = "Blogs";
            this.tabPPublish.UseVisualStyleBackColor = true;
            this.tabPPublish.Click += new System.EventHandler(this.tabPPublish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ratings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blogs";
            // 
            // lblEMPCode
            // 
            this.lblEMPCode.AutoSize = true;
            this.lblEMPCode.Location = new System.Drawing.Point(1157, 17);
            this.lblEMPCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMPCode.Name = "lblEMPCode";
            this.lblEMPCode.Size = new System.Drawing.Size(54, 13);
            this.lblEMPCode.TabIndex = 7;
            this.lblEMPCode.Text = "UserCode";
            this.lblEMPCode.Visible = false;
            // 
            // pcbrefresh
            // 
            this.pcbrefresh.Image = global::TickVibe.Properties.Resources.refresh;
            this.pcbrefresh.Location = new System.Drawing.Point(1160, 38);
            this.pcbrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pcbrefresh.Name = "pcbrefresh";
            this.pcbrefresh.ShadowDecoration.Parent = this.pcbrefresh;
            this.pcbrefresh.Size = new System.Drawing.Size(41, 38);
            this.pcbrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbrefresh.TabIndex = 2;
            this.pcbrefresh.TabStop = false;
            this.pcbrefresh.Click += new System.EventHandler(this.pcbrefresh_Click);
            // 
            // flpBlog
            // 
            this.flpBlog.AutoScroll = true;
            this.flpBlog.BackColor = System.Drawing.Color.White;
            this.flpBlog.Controls.Add(this.ucBlog1);
            this.flpBlog.Location = new System.Drawing.Point(41, 91);
            this.flpBlog.Margin = new System.Windows.Forms.Padding(2);
            this.flpBlog.Name = "flpBlog";
            this.flpBlog.Size = new System.Drawing.Size(1610, 823);
            this.flpBlog.TabIndex = 0;
            // 
            // BlogFilter
            // 
            this.BlogFilter.Image = global::TickVibe.Properties.Resources.filter;
            this.BlogFilter.Location = new System.Drawing.Point(1205, 137);
            this.BlogFilter.Margin = new System.Windows.Forms.Padding(2);
            this.BlogFilter.Name = "BlogFilter";
            this.BlogFilter.Size = new System.Drawing.Size(39, 21);
            this.BlogFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlogFilter.TabIndex = 2;
            this.BlogFilter.TabStop = false;
            this.BlogFilter.Visible = false;
            this.BlogFilter.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBlogList
            // 
            this.btnBlogList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlogList.Location = new System.Drawing.Point(73, 39);
            this.btnBlogList.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlogList.Name = "btnBlogList";
            this.btnBlogList.Size = new System.Drawing.Size(120, 40);
            this.btnBlogList.TabIndex = 6;
            this.btnBlogList.Text = "Blog List";
            this.btnBlogList.UseVisualStyleBackColor = false;
            this.btnBlogList.Click += new System.EventHandler(this.btnBlogList_Click);
            // 
            // pcbSearchPublish
            // 
            this.pcbSearchPublish.Image = global::TickVibe.Properties.Resources.search;
            this.pcbSearchPublish.Location = new System.Drawing.Point(236, 49);
            this.pcbSearchPublish.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSearchPublish.Name = "pcbSearchPublish";
            this.pcbSearchPublish.ShadowDecoration.Parent = this.pcbSearchPublish;
            this.pcbSearchPublish.Size = new System.Drawing.Size(25, 23);
            this.pcbSearchPublish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSearchPublish.TabIndex = 0;
            this.pcbSearchPublish.TabStop = false;
            this.pcbSearchPublish.Click += new System.EventHandler(this.pcbSearchPublish_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.053435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.94656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreateNewBlog, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbbxallratings, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbbxallcategories, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbbxallstatuses, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(554, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 40);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCreateNewBlog
            // 
            this.btnCreateNewBlog.CheckedState.Parent = this.btnCreateNewBlog;
            this.btnCreateNewBlog.CustomImages.Parent = this.btnCreateNewBlog;
            this.btnCreateNewBlog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateNewBlog.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewBlog.HoveredState.Parent = this.btnCreateNewBlog;
            this.btnCreateNewBlog.Location = new System.Drawing.Point(451, 2);
            this.btnCreateNewBlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewBlog.Name = "btnCreateNewBlog";
            this.btnCreateNewBlog.ShadowDecoration.Parent = this.btnCreateNewBlog;
            this.btnCreateNewBlog.Size = new System.Drawing.Size(128, 36);
            this.btnCreateNewBlog.TabIndex = 4;
            this.btnCreateNewBlog.Text = "Create New Blog";
            this.btnCreateNewBlog.Click += new System.EventHandler(this.btnCreateNewBlog_Click);
            // 
            // cmbbxallratings
            // 
            this.cmbbxallratings.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxallratings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxallratings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxallratings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxallratings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxallratings.FormattingEnabled = true;
            this.cmbbxallratings.HoveredState.Parent = this.cmbbxallratings;
            this.cmbbxallratings.ItemHeight = 30;
            this.cmbbxallratings.ItemsAppearance.Parent = this.cmbbxallratings;
            this.cmbbxallratings.Location = new System.Drawing.Point(297, 2);
            this.cmbbxallratings.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxallratings.Name = "cmbbxallratings";
            this.cmbbxallratings.ShadowDecoration.Parent = this.cmbbxallratings;
            this.cmbbxallratings.Size = new System.Drawing.Size(144, 36);
            this.cmbbxallratings.TabIndex = 3;
            this.cmbbxallratings.SelectedIndexChanged += new System.EventHandler(this.cmbbxallratings_SelectedIndexChanged);
            // 
            // ucBlog1
            // 
            this.ucBlog1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucBlog1.Location = new System.Drawing.Point(2, 2);
            this.ucBlog1.Margin = new System.Windows.Forms.Padding(2);
            this.ucBlog1.Name = "ucBlog1";
            this.ucBlog1.Size = new System.Drawing.Size(353, 343);
            this.ucBlog1.TabIndex = 1;
            // 
            // frmKnowledgeBaseBlogAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 949);
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKnowledgeBaseBlogAL";
            this.Text = "frmKnowledgeBaseBlogAL";
            this.Load += new System.EventHandler(this.frmKnowledgeBaseBlogAL_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPPublish.ResumeLayout(false);
            this.tabPPublish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrefresh)).EndInit();
            this.flpBlog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlogFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchPublish)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTextBox txtSB;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxallcategories;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxallstatuses;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPPublish;
        private Siticone.UI.WinForms.SiticoneButton btnCreateNewBlog;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxallratings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.UI.WinForms.SiticonePictureBox pcbSearchPublish;
        private System.Windows.Forms.FlowLayoutPanel flpBlog;
        private USBlog ucBlog1;
        private System.Windows.Forms.Button btnBlogList;
        private System.Windows.Forms.PictureBox BlogFilter;
        private System.Windows.Forms.Label lblEMPCode;
        private Siticone.UI.WinForms.SiticonePictureBox pcbrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}