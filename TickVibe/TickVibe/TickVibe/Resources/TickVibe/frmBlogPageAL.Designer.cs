namespace TickVibe
{
    partial class frmBlogPageAL
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
            this.lblAttachments = new System.Windows.Forms.Label();
            this.lblSubmitYourRating = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblYourRating = new System.Windows.Forms.Label();
            this.btnSubmitRating = new System.Windows.Forms.Button();
            this.txtComment = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEMPCode = new System.Windows.Forms.Label();
            this.lblUsercode = new System.Windows.Forms.Label();
            this.lblBlog = new System.Windows.Forms.Label();
            this.lblAttachinfo = new System.Windows.Forms.Label();
            this.RatingStarShowAll = new Siticone.UI.WinForms.SiticoneRatingStar();
            this.RatingStareUpdate = new Siticone.UI.WinForms.SiticoneRatingStar();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachments.Location = new System.Drawing.Point(24, 310);
            this.lblAttachments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(111, 20);
            this.lblAttachments.TabIndex = 1;
            this.lblAttachments.Text = "Attachments";
            // 
            // lblSubmitYourRating
            // 
            this.lblSubmitYourRating.AutoSize = true;
            this.lblSubmitYourRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitYourRating.Location = new System.Drawing.Point(25, 396);
            this.lblSubmitYourRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubmitYourRating.Name = "lblSubmitYourRating";
            this.lblSubmitYourRating.Size = new System.Drawing.Size(166, 20);
            this.lblSubmitYourRating.TabIndex = 2;
            this.lblSubmitYourRating.Text = "Submit Your Rating";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(26, 492);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(174, 20);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "Comment ( Optional)";
            this.lblComment.Click += new System.EventHandler(this.lblComment_Click);
            // 
            // lblYourRating
            // 
            this.lblYourRating.AutoSize = true;
            this.lblYourRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRating.Location = new System.Drawing.Point(26, 431);
            this.lblYourRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourRating.Name = "lblYourRating";
            this.lblYourRating.Size = new System.Drawing.Size(105, 20);
            this.lblYourRating.TabIndex = 4;
            this.lblYourRating.Text = "Your Rating";
            this.lblYourRating.Visible = false;
            this.lblYourRating.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmitRating
            // 
            this.btnSubmitRating.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmitRating.Location = new System.Drawing.Point(1109, 595);
            this.btnSubmitRating.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitRating.Name = "btnSubmitRating";
            this.btnSubmitRating.Size = new System.Drawing.Size(120, 40);
            this.btnSubmitRating.TabIndex = 6;
            this.btnSubmitRating.Text = "Submit Rating";
            this.btnSubmitRating.UseVisualStyleBackColor = false;
            this.btnSubmitRating.Click += new System.EventHandler(this.btnSubmitRating_Click);
            // 
            // txtComment
            // 
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.Parent = this.txtComment;
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.FocusedState.Parent = this.txtComment;
            this.txtComment.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.HoveredState.Parent = this.txtComment;
            this.txtComment.Location = new System.Drawing.Point(27, 526);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "";
            this.txtComment.SelectedText = "";
            this.txtComment.ShadowDecoration.Parent = this.txtComment;
            this.txtComment.Size = new System.Drawing.Size(1209, 55);
            this.txtComment.TabIndex = 7;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Controls.Add(this.label4);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.lblEMPCode);
            this.siticonePanel1.Controls.Add(this.lblUsercode);
            this.siticonePanel1.Controls.Add(this.lblBlog);
            this.siticonePanel1.Controls.Add(this.lblAttachinfo);
            this.siticonePanel1.Controls.Add(this.RatingStarShowAll);
            this.siticonePanel1.Controls.Add(this.RatingStareUpdate);
            this.siticonePanel1.Controls.Add(this.lblContent);
            this.siticonePanel1.Controls.Add(this.lblCreatedAt);
            this.siticonePanel1.Controls.Add(this.lblAuthor);
            this.siticonePanel1.Controls.Add(this.lblRating);
            this.siticonePanel1.Controls.Add(this.lblStatus);
            this.siticonePanel1.Controls.Add(this.lblCategory);
            this.siticonePanel1.Controls.Add(this.lblTitle);
            this.siticonePanel1.Controls.Add(this.lblSubmitYourRating);
            this.siticonePanel1.Controls.Add(this.txtComment);
            this.siticonePanel1.Controls.Add(this.lblAttachments);
            this.siticonePanel1.Controls.Add(this.btnSubmitRating);
            this.siticonePanel1.Controls.Add(this.lblYourRating);
            this.siticonePanel1.Controls.Add(this.lblComment);
            this.siticonePanel1.Location = new System.Drawing.Point(1, 2);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1268, 650);
            this.siticonePanel1.TabIndex = 8;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TickVibe.Properties.Resources.close___Copy3;
            this.pictureBox1.Location = new System.Drawing.Point(1226, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "View Blog";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Category  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(906, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Author  :";
            // 
            // lblEMPCode
            // 
            this.lblEMPCode.AutoSize = true;
            this.lblEMPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMPCode.Location = new System.Drawing.Point(1106, 21);
            this.lblEMPCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMPCode.Name = "lblEMPCode";
            this.lblEMPCode.Size = new System.Drawing.Size(46, 17);
            this.lblEMPCode.TabIndex = 30;
            this.lblEMPCode.Text = "label1";
            this.lblEMPCode.Visible = false;
            // 
            // lblUsercode
            // 
            this.lblUsercode.AutoSize = true;
            this.lblUsercode.Location = new System.Drawing.Point(1015, 147);
            this.lblUsercode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsercode.Name = "lblUsercode";
            this.lblUsercode.Size = new System.Drawing.Size(13, 13);
            this.lblUsercode.TabIndex = 29;
            this.lblUsercode.Text = "_";
            this.lblUsercode.Visible = false;
            // 
            // lblBlog
            // 
            this.lblBlog.AutoSize = true;
            this.lblBlog.Location = new System.Drawing.Point(912, 155);
            this.lblBlog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlog.Name = "lblBlog";
            this.lblBlog.Size = new System.Drawing.Size(13, 13);
            this.lblBlog.TabIndex = 28;
            this.lblBlog.Text = "_";
            this.lblBlog.Visible = false;
            // 
            // lblAttachinfo
            // 
            this.lblAttachinfo.AutoSize = true;
            this.lblAttachinfo.Location = new System.Drawing.Point(271, 344);
            this.lblAttachinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttachinfo.Name = "lblAttachinfo";
            this.lblAttachinfo.Size = new System.Drawing.Size(38, 13);
            this.lblAttachinfo.TabIndex = 27;
            this.lblAttachinfo.Text = "Attach";
            // 
            // RatingStarShowAll
            // 
            this.RatingStarShowAll.Location = new System.Drawing.Point(1123, 479);
            this.RatingStarShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.RatingStarShowAll.Name = "RatingStarShowAll";
            this.RatingStarShowAll.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.RatingStarShowAll.Size = new System.Drawing.Size(106, 28);
            this.RatingStarShowAll.TabIndex = 26;
            this.RatingStarShowAll.ValueChanged += new System.EventHandler(this.RatingStarShowAll_ValueChanged);
            // 
            // RatingStareUpdate
            // 
            this.RatingStareUpdate.Location = new System.Drawing.Point(28, 461);
            this.RatingStareUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.RatingStareUpdate.Name = "RatingStareUpdate";
            this.RatingStareUpdate.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            this.RatingStareUpdate.Size = new System.Drawing.Size(103, 22);
            this.RatingStareUpdate.TabIndex = 25;
            this.RatingStareUpdate.ValueChanged += new System.EventHandler(this.siticoneRatingStar1_ValueChanged);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(36, 123);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 17);
            this.lblContent.TabIndex = 24;
            this.lblContent.Text = "Content";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.Location = new System.Drawing.Point(992, 76);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(64, 15);
            this.lblCreatedAt.TabIndex = 23;
            this.lblCreatedAt.Text = "CreatedAt";
            this.lblCreatedAt.Click += new System.EventHandler(this.lblCreatedAt_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(725, 76);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 15);
            this.lblAuthor.TabIndex = 22;
            this.lblAuthor.Text = " Author";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(1013, 487);
            this.lblRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(117, 20);
            this.lblRating.TabIndex = 21;
            this.lblRating.Text = "  Total Rating";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(442, 80);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(182, 79);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmBlogPageAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 659);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBlogPageAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlogPage";
            this.Load += new System.EventHandler(this.BlogPage_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Label lblSubmitYourRating;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblYourRating;
        private System.Windows.Forms.Button btnSubmitRating;
        private Siticone.UI.WinForms.SiticoneTextBox txtComment;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblContent;
        private Siticone.UI.WinForms.SiticoneRatingStar RatingStareUpdate;
        private Siticone.UI.WinForms.SiticoneRatingStar RatingStarShowAll;
        private System.Windows.Forms.Label lblAttachinfo;
        private System.Windows.Forms.Label lblBlog;
        private System.Windows.Forms.Label lblUsercode;
        private System.Windows.Forms.Label lblEMPCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}