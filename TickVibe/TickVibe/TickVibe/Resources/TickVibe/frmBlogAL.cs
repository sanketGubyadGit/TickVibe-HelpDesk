using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibe;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmBlogAL : Form
    {
        int IsRead;
        public frmBlogAL(string UserCode)
        {
            InitializeComponent();
            lblEMPCode.Text= UserCode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           IsMdiContainer=true;
     
           siticonePanel2.Visible = false;
           
            clsTeamLeader objc = new clsTeamLeader();
            DataTable dt = objc.SelectCountAL();

            if (dt.Rows.Count > 0)
            {
                lblUnReadCount.Text = dt.Rows[0]["UnreadCount"].ToString();
            }
            else
            {
                lblUnReadCount.Text = "0";
            }


            clsTeamLeader objU = new clsTeamLeader();
            DataTable dtr = objU.FetchNotificationAL();
            if (!dtr.Columns.Contains("Sr.No"))
            {
                DataColumn col = new DataColumn( "Sr.No",typeof(int));
                dtr.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i =0; i < dtr.Rows.Count;i++)
            {

                dtr.Rows[i]["Sr.No"] = i + 1;
            }
            grdNotification.DataSource = dtr;
            grdNotification.Show();
            grdNotification.Columns["NotificationId"].Visible = false;

        }

        private void siticonebtnBlog_Click(object sender, EventArgs e)
        {

            frmKnowledgeBaseBlogAL objt = new frmKnowledgeBaseBlogAL(lblEMPCode.Text);
            
            objt.Show();
            this.Hide();

            siticonebtnBlog.Visible = false;
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
           
            siticonePanel2.Visible =! siticonePanel2.Visible;



            //frmNotificationAL obj = new frmNotificationAL();
            //obj.Show();
            
            //clsTeamLeader objd = new clsTeamLeader();
            //objd.MarkNotificationMessage();

            //LoadNotificationCount();

        }
        private void LoadNotificationCount()
        {
        }

        private void PBNotification_MouseHover(object sender, EventArgs e)
        {
        }

        private void lblNotificationCount_Click(object sender, EventArgs e)
        {
        }

        private void lblUnReadCount_Click(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow SelectedRow = grdNotification.Rows[e.RowIndex];
                int NotificationId = Convert.ToInt32(grdNotification.Rows[e.RowIndex].Cells["NotificationId"].Value);
            }
        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (grdNotification.SelectedRows.Count > 0)
            {
                int notificationId = Convert.ToInt32(
                grdNotification.SelectedRows[0].Cells["NotificationId"].Value);

                clsTeamLeader obj = new clsTeamLeader();
                obj.UpdateNotificationAL(notificationId);

                MessageBox.Show("Marked as Read Successfully ");
            }
            else
            {
                MessageBox.Show("Please select a row first ");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //siticonePanel2.Close();
           
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonebtnBlog1_Click(object sender, EventArgs e)
        {
            frmKnowledgeBaseBlogAL objt = new frmKnowledgeBaseBlogAL(lblEMPCode.Text);

            objt.Show();
            this.Hide();

            siticonebtnBlog.Visible = false;
        }

        private void PBNotification1_Click(object sender, EventArgs e)
        {
            siticonePanel2.Visible = !siticonePanel2.Visible;
        }

        private void PBNotification1_MouseHover(object sender, EventArgs e)
        {

        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
