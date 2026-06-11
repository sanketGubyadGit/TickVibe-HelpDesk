using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TicketingTool;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmKnowledgeBaseBlogAL : Form
    {
        DataTable dtAllBlogs = new DataTable();
        public frmKnowledgeBaseBlogAL(string UserCode)
        {
            InitializeComponent();
            lblEMPCode.Text = UserCode;

        }

     
        private void frmKnowledgeBaseBlogAL_Load(object sender, EventArgs e)
        {


            ShowUSBlog();


            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.ShowCategoriesAL();
            //  Add All option
            DataRow dr = dt.NewRow();    
            dr["CategoryId"] = 0;         
            dr["CategoryName"] = "Category";  
            dt.Rows.InsertAt(dr, 0);    
            cmbbxallcategories.DisplayMember = "CategoryName";
            cmbbxallcategories.ValueMember = "CategoryId";
            cmbbxallcategories.DataSource = dt;



            clsTeamLeader obje = new clsTeamLeader();
            DataTable dta = obje.ShowStatusAL();
            DataRow drs = dta.NewRow();
            drs["BlogStatusId"] = 0;  
            drs["BlogStatusName"] = "BlogStatus";
            dta.Rows.InsertAt(drs, 0);

            cmbbxallstatuses.DisplayMember = "BlogStatusName";
            cmbbxallstatuses.ValueMember = "BlogStatusId";
            cmbbxallstatuses.DataSource = dta;



            clsTeamLeader objs = new clsTeamLeader();
            DataTable dte = objs.ShowRatingAL();
            // Add All option    
            DataRow drn = dte.NewRow();
            drn["Rating"] = 0;
            drn["Rating"] = 0;
            dte.Rows.InsertAt(drn, 0);
            cmbbxallratings.DisplayMember = "Rating";
            cmbbxallratings.ValueMember = "Rating";
            cmbbxallratings.DataSource = dte;
            // Add All option
            cmbbxallratings.Format += (s, e2) =>
            {
                if ((int)e2.Value == 0)
                    e2.Value = "All";
            };

            //clsTeamLeader objs = new clsTeamLeader();
            //DataTable dte = objs.ShowRatingAL();
            //DataRow drn = dte.NewRow();
            //drn["RatingId"] = 0;
            //drn["Rating"] = 0;

            //dte.Rows.InsertAt(drn, 0);

            //cmbbxallratings.DisplayMember = "Rating";
            //cmbbxallratings.ValueMember = "RatingId";
            //cmbbxallratings.DataSource = dte;
            //cmbbxallratings.SelectedIndex = 0;

        }


        private void ShowUSBlog()
        {

            flpBlog.Controls.Clear();

            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.ShowBlogInfoAL();
            dtAllBlogs = obj.ShowBlogInfoAL(); // add

            foreach (DataRow row in dt.Rows)
            {
                USBlog uSBlogS = new USBlog();

                uSBlogS.Title = row["Title"].ToString();
                uSBlogS.Categore = row["CategoryName"].ToString();
                uSBlogS.Status = row["BlogStatusName"].ToString();
                //uSBlogS.Rating = row["Rating"].ToString();
                uSBlogS.Rating = row["Rating"] == DBNull.Value
                 ? 0 : Convert.ToInt32(row["Rating"]);
                uSBlogS.Content = row["Content"].ToString();
                uSBlogS.Author = row["AuthorName"].ToString();
                uSBlogS.CreatedAt = Convert.ToDateTime(row["PublishedAt"]).ToString("yyyy-MM-dd");
                uSBlogS.imagePath = row["ImagePath"].ToString();
                uSBlogS.BlogCode = row["BlogCode"].ToString();
                uSBlogS.CreatedBy = row["CreatedBy"].ToString();
                flpBlog.Controls.Add(uSBlogS);


            }
        }

        private void LoadBlogsToPanel(DataTable dt)
        {
            
            flpBlog.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                USBlog uSBlogS = new USBlog();

                uSBlogS.Title = row["Title"].ToString();
                uSBlogS.Categore = row["CategoryName"].ToString();
                uSBlogS.Status = row["BlogStatusName"].ToString();
                uSBlogS.Rating = row["Rating"] == DBNull.Value
                    ? 0 : Convert.ToInt32(row["Rating"]);
                uSBlogS.Content = row["Content"].ToString();
                uSBlogS.Author = row["AuthorName"].ToString();
                uSBlogS.CreatedAt = Convert.ToDateTime(row["PublishedAt"]).ToString("yyyy-MM-dd");
                uSBlogS.imagePath = row["ImagePath"].ToString();
                uSBlogS.BlogCode = row["BlogCode"].ToString();
                uSBlogS.CreatedBy = row["CreatedBy"].ToString();

                flpBlog.Controls.Add(uSBlogS);
            }
        }

        //private void BlogsStatus(DataTable dt)
        //{
        //    flpBlog.Controls.Clear();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        USBlog uSBlogS = new USBlog();

        //        uSBlogS._Title = row["Title"].ToString();
        //        uSBlogS._Categore = row["CategoryName"].ToString();
        //        uSBlogS._Status = row["BlogStatusName"].ToString();
        //        uSBlogS._Rating = row["Rating"] == DBNull.Value
        //            ? 0 : Convert.ToInt32(row["Rating"]);
        //        uSBlogS._Content = row["Content"].ToString();
        //        uSBlogS._Author = row["AuthorName"].ToString();
        //        uSBlogS._CreatedAt = Convert.ToDateTime(row["PublishedAt"]).ToString("yyyy-MM-dd");
        //        uSBlogS._imagePath = row["ImagePath"].ToString();
        //        uSBlogS._BlogCode = row["BlogCode"].ToString();
        //        uSBlogS._CreatedBy = row["CreatedBy"].ToString();

        //        flpBlog.Controls.Add(uSBlogS);
        //    }
        //}

        private void BlogsRating(DataTable dt)
        {
            flpBlog.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                USBlog uSBlogS = new USBlog();

                uSBlogS.Title = row["Title"].ToString();
                uSBlogS.Categore = row["CategoryName"].ToString();
                uSBlogS.Status = row["BlogStatusName"].ToString();
                uSBlogS.Rating = row["Rating"] == DBNull.Value
                    ? 0 : Convert.ToInt32(row["Rating"]);
                uSBlogS.Content = row["Content"].ToString();
                uSBlogS.Author = row["AuthorName"].ToString();
                uSBlogS.CreatedAt = Convert.ToDateTime(row["PublishedAt"]).ToString("yyyy-MM-dd");
                uSBlogS.imagePath = row["ImagePath"].ToString();
                uSBlogS.BlogCode = row["BlogCode"].ToString();
                uSBlogS.CreatedBy = row["CreatedBy"].ToString();

                flpBlog.Controls.Add(uSBlogS);
            }
        }
        private void btnCreateNewBlog_Click(object sender, EventArgs e)
        {
            frmCreateBlogPostAL1 obj = new frmCreateBlogPostAL1(lblEMPCode.Text);
            obj.Show();
        }


        private void cmbbxallstatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxallstatuses.SelectedItem == null)
                return;
           

           DataRowView drv = cmbbxallstatuses.SelectedItem as DataRowView;
            int selected_StatusId = Convert.ToInt32(drv["BlogStatusId"]);

            if (selected_StatusId == 0)
            {
                LoadBlogsToPanel(dtAllBlogs);
               
            }

            else
            {
                DataView dv = dtAllBlogs.DefaultView;
                dv.RowFilter = "BlogStatusId = " + selected_StatusId;
                LoadBlogsToPanel(dv.ToTable());

            }
        }

        private void txtSB_TextChanged(object sender, EventArgs e)
        {
            
            if (dtAllBlogs == null) return;

            if (string.IsNullOrWhiteSpace(txtSB.Text))
            {
                LoadBlogsToPanel(dtAllBlogs);
            }
            else
            {
                string searchText = txtSB.Text.Replace("'", "''");

                DataView dv = new DataView(dtAllBlogs);
                dv.RowFilter =
                    $"Title LIKE '%{searchText}%' OR BlogCode LIKE '%{searchText}%'";

                LoadBlogsToPanel(dv.ToTable());
            }
        }

        private void pcbSearchPublish_Click(object sender, EventArgs e)
        {
            pcbSearchPublish.Visible = false;
        }

       
        


        private void cmbbxallratings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtAllBlogs == null) return;
            if (!(cmbbxallratings.SelectedValue is int)) return;

            int Rating= Convert.ToInt32(cmbbxallratings.SelectedValue);

            if (Rating == 0) 
            {
                BlogsRating(dtAllBlogs);
            }
            else
            {
                DataView dv = new DataView(dtAllBlogs);
                dv.RowFilter = "Rating = " + Rating;
                BlogsRating(dv.ToTable());
            }

           
        }

        private void cmbbxallcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtAllBlogs == null) return;
            if (!(cmbbxallcategories.SelectedValue is int)) return;

            int categoryId = Convert.ToInt32(cmbbxallcategories.SelectedValue);

            if (categoryId == 0)  // All selected
            {
                LoadBlogsToPanel(dtAllBlogs);
            }
            else
            {
                DataView dv = new DataView(dtAllBlogs);
                dv.RowFilter = "CategoryId = " + categoryId;
                LoadBlogsToPanel(dv.ToTable());
            }

        }

        private void btnBlogList_Click(object sender, EventArgs e)
        {
            frmBlogListAL obj = new frmBlogListAL();
            obj.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmKnowledgeBaseBlogAL_Load(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // ShowUSBlog();
        }

        private void pcbrefresh_Click(object sender, EventArgs e)
        {
            ShowUSBlog();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPPublish_Click(object sender, EventArgs e)
        {

        }
    }
}

