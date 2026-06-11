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
using System.Xml.Linq;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmShowBlogListViewAL : Form
    {
        string BlogCode;
        public frmShowBlogListViewAL( string BlogCode)
        {
            InitializeComponent();
            this.BlogCode = BlogCode;
        }

        private void frmShowBlogListViewAL_Load(object sender, EventArgs e)
        {
           // string BlogCode;
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt=new DataTable();
            dt = obj.ShowBlogListInfoAL();
            ApplyUIStyleListAL();
            if (dt.Rows.Count>0)
            {
                DataRow[] dr = dt.Select("BlogCode='" + BlogCode + "'");
                // lblBlogCode.Text = dt.Rows[0]["BlogCode"].ToString();
                lblBlogTitle.Text=dr[0]["Title"].ToString();
                lblCategoryBlog.Text=dr[0]["CategoryName"].ToString();
                lblStatusBlog.Text = dr[0]["BlogStatusName"].ToString();
                lblContentBlog.Text = dr[0]["Content"].ToString();
                lblCreatedAt.Text = dr[0]["PublishedAt"].ToString();
                // lblLinkAttachments.Text = dt.Rows[0]["ImagePath"].ToString();
                string imagePath = dr[0]["ImagePath"].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    lblLinkAttachments.Text = imagePath;
                    lblLinkAttachments.ForeColor = Color.Blue;
                    lblLinkAttachments.Font = new Font(lblLinkAttachments.Font, FontStyle.Underline);
                    lblLinkAttachments.Cursor = Cursors.Hand;
                    // Attach click event to open the file/URL
                    lblLinkAttachments.Click += (s, ev) => OpenAttachment(imagePath);
                }
                else
                {
                    lblLinkAttachments.Text = "No attachment";
                    lblLinkAttachments.ForeColor = Color.Gray;
                    lblLinkAttachments.Cursor = Cursors.Default;
                }
                if (dr[0]["Rating"] != DBNull.Value)
                {
                    siticoneRatingStar5.Value = Convert.ToInt32(dr[0]["Rating"]);
                }
                else
                {
                    siticoneRatingStar5.Value = 0;
                }
                // siticoneRatingStar5.Value = Convert.ToInt32(dr[0]["Rating"]);
                

                lblAuthor.Text=dr[0]["AuthorName"].ToString();
                
            }

        }

        private void ApplyUIStyleListAL()
        {
            // Form Background
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Title Style
            lblBlogTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblBlogTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Category Badge
            lblCategoryBlog.BackColor = Color.FromArgb(0, 120, 215);
            lblCategoryBlog.ForeColor = Color.White;
            lblCategoryBlog.Padding = new Padding(5);

            // Status Badge
            lblStatusBlog.BackColor = Color.FromArgb(40, 167, 69);
            lblStatusBlog.ForeColor = Color.White;
            lblStatusBlog.Padding = new Padding(5);

            // Content Style
            lblContentBlog.MaximumSize = new Size(300, 0);
            lblContentBlog.AutoSize = true;
            lblContentBlog.Font = new Font("Segoe UI", 10);

            //  CreatedAt
            lblCreatedAt.BackColor = Color.FromArgb(0, 120, 215);
            lblCreatedAt.ForeColor = Color.White;
            lblCreatedAt.Padding = new Padding(5);

            // lblAuthor
            lblAuthor.BackColor = Color.FromArgb(255, 128, 0);
            lblAuthor.ForeColor = Color.White;
            lblAuthor.Padding = new Padding(5);
            //// Comment Box
            //txtComment.Multiline = true;
            //txtComment.Height = 40;

            //// Button Style
            //btnSubmitRating.BackColor = Color.FromArgb(0, 120, 215);
            //btnSubmitRating.ForeColor = Color.White;
            //btnSubmitRating.FlatStyle = FlatStyle.Flat;
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
        private void PBlogListView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneRatingStar5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showImg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
