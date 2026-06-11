using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TicketingTool;
using TickVibeLib;

namespace TickVibe
{
    public partial class USBlog : UserControl
    {
        public USBlog()
        {
            InitializeComponent();
        }

        private void USBlog_Load(object sender, EventArgs e)
        {

            lblBlogNameShow.Text = Title;
            lblCategoryNameShow.Text = Categore;
            lblStatusBlogShow.Text = Status;
            RatingStarBlogPage.Value = Rating;
            lblContentShow.Text = Content;
            lblAuthorShow.Text = Author;
            lblCreatedAtShow.Text = CreatedAt;
            lblImagepath.Text = imagePath;
            lblEMPCode.Text = CreatedBy;

            if (Status == "Publish")
            {
                PBBlogEdit.Visible = false; 
            }
            else
            {
                PBBlogEdit.Visible = true; 
            }

        }

        public string Title;
        public string Categore;
        public string Status;
        public int Rating;
        public string Content;
        public string Author;
        public string CreatedAt;
        public string imagePath;
        public string BlogCode;
        public string CreatedBy;

        public USBlog(USBlog obj)
        {
            imagePath = obj.imagePath;
            Title = obj.Title;
            Categore = obj.Categore;
            Status = obj.Status;
            Rating = obj.Rating;
            Content = obj.Content;
            Author = obj.Author;
            CreatedAt = obj.CreatedAt;
            CreatedBy = obj.CreatedBy;
        }

        private void USBlog_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void USBlog_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void PBBlogEdit_Click(object sender, EventArgs e)
        {
            frmEditBlogPostAL obj = new frmEditBlogPostAL(Title, Categore, Author, Content,imagePath,BlogCode, CreatedBy);
            obj.Show();
        }
        
        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            string blogcode = BlogCode;
            int IsDelete = 0;

            clsTeamLeader obj = new clsTeamLeader();
            obj.DeleteBlogAL(BlogCode, IsDelete);
            MessageBox.Show("Delete Blog Successfully!");
        }

        private void USBlog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmBlogPageAL obj = new frmBlogPageAL(Title, Categore, Status, Rating, Author, CreatedAt, Content,imagePath, BlogCode, CreatedBy);
            obj.Show();
        }

        private void RatingStarBlogPage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
