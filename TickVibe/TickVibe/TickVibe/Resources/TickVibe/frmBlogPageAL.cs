using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibe;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmBlogPageAL : Form
    {
        string _title, _category, _status, _author, _createdAt, _content, _imagePath, _BlogCode, _CreatedBy;
        int _rating;
        int selectedRating = 0;

        private void btnSubmitRating_Click(object sender, EventArgs e)
        {

            if (RatingStareUpdate.Value == 0)
            {
                MessageBox.Show("Please select rating");
                return;
            }

            clsTeamLeader obj = new clsTeamLeader();

            obj.BlogCode = _BlogCode;
            obj.CreatedBy = _CreatedBy;
            // obj.Rating = RatingStareUpdate.Value;
            obj.Rating = Convert.ToInt32(RatingStareUpdate.Value);
            obj.Review = txtComment.Text;

            obj.InsertRatingAL();

            MessageBox.Show("Rating Submitted Successfully");
        }

        private void RatingStarShowAll_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCreatedAt_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public frmBlogPageAL(string title, string category, string status,
                             int rating, string author, string createdAt, string content, string imagepath, string _blogCode, string _createdBy)
        {
            InitializeComponent();

            _title = title;
            _category = category;
            _status = status;
            _rating = rating;
            _author = author;
            _createdAt = createdAt;
            _content = content;
            _imagePath = imagepath;
            _BlogCode = _blogCode;
            _CreatedBy = _createdBy;
        }

        private void BlogPage_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _title;
            lblCategory.Text = _category;
            lblStatus.Text = _status;
            RatingStarShowAll.Value = _rating;
            lblAuthor.Text = _author;
            lblCreatedAt.Text = _createdAt;
            lblContent.Text = _content;
            // lblAttachinfo.Text = _imagePath;
            if (!string.IsNullOrEmpty(_imagePath))
            {
                lblAttachinfo.Text = _imagePath;
                lblAttachinfo.ForeColor = Color.Blue;
                lblAttachinfo.Font = new Font(lblAttachinfo.Font, FontStyle.Underline);
                lblAttachinfo.Cursor = Cursors.Hand;
                // Attach click event to open the file/URL
               lblAttachinfo.Click += (s, ev) => OpenAttachment(_imagePath);
            }
            else
            {
                lblAttachinfo.Text = "No attachment";
                lblAttachinfo.ForeColor = Color.Gray;
                lblAttachinfo.Cursor = Cursors.Default;
            }
            lblBlog.Text = _BlogCode;
            lblUsercode.Text = _CreatedBy;
            ApplyUIStyleAL();
            // lblUsercode.Text = _createdAt;

        }
        private void ApplyUIStyleAL()
        {
            // Form Background
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Title Style
            //lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            //lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 45, 45);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Category Badge
            lblCategory.BackColor = Color.FromArgb(0, 120, 215);
            lblCategory.ForeColor = Color.White;
            lblCategory.Padding = new Padding(6);


            // Status Badge
            lblStatus.BackColor = Color.FromArgb(40, 167, 69);
            lblStatus.ForeColor = Color.White;
            lblStatus.Padding = new Padding(6);

            // Content Style
            //lblContent.MaximumSize = new Size(300, 0);
            //lblContent.AutoSize = true;
            //lblContent.Font = new Font("Segoe UI", 10);

            lblContent.MaximumSize = new Size(600, 0);
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 11);
            lblContent.ForeColor = Color.FromArgb(60, 60, 60);

            // Comment Box
            txtComment.Multiline = true;
            txtComment.Height = 50;


            // Button Style
            btnSubmitRating.BackColor = Color.FromArgb(0, 120, 215);
            btnSubmitRating.ForeColor = Color.White;
            btnSubmitRating.FlatStyle = FlatStyle.Flat;

            //  CreatedAt
            lblCreatedAt.BackColor = Color.FromArgb(0, 120, 215);
            lblCreatedAt.ForeColor = Color.White;
            lblCreatedAt.Padding = new Padding(6);

            // lblAuthor
            lblAuthor.BackColor = Color.FromArgb(255, 128, 0);
            lblAuthor.ForeColor = Color.White;
            lblAuthor.Padding = new Padding(6);


        }
        private void OpenAttachment(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open attachment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblComment_Click(object sender, EventArgs e)
        {

        }
    }
}
