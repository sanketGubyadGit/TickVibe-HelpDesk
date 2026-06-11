using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmBlogListAL : Form
    {
        public frmBlogListAL()
        {
            InitializeComponent();
        }

        private void frmBlogList_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dtr = obj.ShowBlogListInfoAL();
            if (!dtr.Columns.Contains("Sr.No"))
            {
                DataColumn col = new DataColumn("Sr.No", typeof(int));
                dtr.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i = 0; i < dtr.Rows.Count; i++)
            {

                dtr.Rows[i]["Sr.No"] = i + 1;
            }
            DataGridViewButtonColumn dgv = new DataGridViewButtonColumn();
            GRDBlogList.DataSource = dtr;
            GridviewRN(GRDBlogList);
            GRDBlogList.AllowUserToAddRows = false;
            dgv.Name = "View";
            dgv.Text = "View Blog ";
            dgv.HeaderText= "Action";
            dgv.FlatStyle = FlatStyle.Flat;
            dgv.DefaultCellStyle.BackColor = Color.MediumPurple;
            dgv.UseColumnTextForButtonValue= true;
            GRDBlogList.Columns.Add(dgv);



            GRDBlogList.ColumnHeadersHeight = 40;
            GRDBlogList.BorderStyle = BorderStyle.FixedSingle;

            //GRDBlogList.Columns.Add(dgv);
            //GRDBlogList.DataSource = dtr;
            //dgv.Text = "Blog";
            //dgv.Name = "Blog";
            //dgv.Text = "Show Blog";
            //dgv.UseColumnTextForButtonValue = true;
            //GRDBlogList.Show();


        }
        private void GridviewRN(DataGridView grid)
        {
            if (grid.Columns.Contains("SrNo"))
                grid.Columns["SrNo"].ReadOnly = true;

            if (grid.Columns.Contains("BlogCode"))
                grid.Columns["BlogCode"].ReadOnly = true;

            if (grid.Columns.Contains("BlogId"))
                grid.Columns["BlogId"].ReadOnly = true;

            if (grid.Columns.Contains("Title"))
                grid.Columns["Title"].ReadOnly = true;

            if (grid.Columns.Contains("Content"))
                grid.Columns["Content"].ReadOnly = true;

            if (grid.Columns.Contains("CategoryId"))
                grid.Columns["CategoryId"].ReadOnly = true;

            if (grid.Columns.Contains("BlogStatusId"))
                grid.Columns["BlogStatusId"].ReadOnly = true;

            if (grid.Columns.Contains("BlogId"))
                grid.Columns["BlogId"].ReadOnly = true;

            if (grid.Columns.Contains("AuthorName"))
                grid.Columns["AuthorName"].ReadOnly = true;

            if (grid.Columns.Contains("CreatedBy"))
                grid.Columns["CreatedBy"].ReadOnly = true;

            if (grid.Columns.Contains("CreatedAt"))
                grid.Columns["CreatedAt"].ReadOnly = true;

            if (grid.Columns.Contains("PublishedAt"))
                grid.Columns["PublishedAt"].ReadOnly = true;

            if (grid.Columns.Contains("IsDelete"))
                grid.Columns["IsDelete"].ReadOnly = true;

            if (grid.Columns.Contains("ImagePath"))
                grid.Columns["ImagePath"].ReadOnly = true;

            if(grid.Columns.Contains("Rating"))
               grid.Columns["Rating"].ReadOnly = true;
        }
        private void GRDBlogList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow SelectedRow = GRDBlogList.Rows[e.RowIndex];

            //    string BlogCode = SelectedRow.Cells["BlogCode"].Value.ToString();

            //    frmShowBlogListViewAL frs = new frmShowBlogListViewAL(BlogCode);
            //    frs.Show();
            //}

            //if (e.RowIndex >= 0 && GRDBlogList.Columns[e.ColumnIndex].Name == "View")
            //{
            //    DataGridViewRow SelectedRow = GRDBlogList.Rows[e.RowIndex];

            //    string BlogCode = SelectedRow.Cells["BlogCode"].Value.ToString();

            //    frmShowBlogListViewAL frs = new frmShowBlogListViewAL(BlogCode);
            //    frs.Show();
            //}
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow SelectedRow = GRDBlogList.Rows[e.RowIndex];
            //    int BlogCode = Convert.ToInt32(GRDBlogList.Rows[e.RowIndex].Cells["BlogCode"].Value);

            //}
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GRDBlogList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && GRDBlogList.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow SelectedRow = GRDBlogList.Rows[e.RowIndex];

                string BlogCode = SelectedRow.Cells["BlogCode"].Value.ToString();

                frmShowBlogListViewAL frs = new frmShowBlogListViewAL(BlogCode);
                frs.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
