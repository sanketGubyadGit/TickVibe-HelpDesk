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
    public partial class frmNotificationAL : Form
    {
        public frmNotificationAL()
        {
            InitializeComponent();
        }

        private void frmNotificationAL_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            //lblShowNotification.Text = obj.GetLatestNotificationMessage();
            clsTeamLeader objBal = new clsTeamLeader();
            DataTable dt = objBal.FetchNotificationAL();
            dataGridView1.DataSource = dt;

            this.StartPosition = FormStartPosition.Manual;

            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width - 30,
                120
            );

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int notificationId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["NotificationId"].Value);

                clsTeamLeader obj = new clsTeamLeader();
                obj.UpdateNotificationAL(notificationId);

                MessageBox.Show("Marked as Read Successfully ");
            }
            else
            {
                MessageBox.Show("Please select a row first ");
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string blogCode = dataGridView1.Rows[e.RowIndex]
                                 .Cells["TktCode"].Value.ToString();

                frmShowBlogListViewAL frm =
                    new frmShowBlogListViewAL(blogCode);

                frm.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string blogCode = dataGridView1.Rows[e.RowIndex]
                                 .Cells["TktCode"].Value.ToString();

                frmShowBlogListViewAL frm =
                    new frmShowBlogListViewAL(blogCode);

                frm.Show();
            }
        }
    }
}
