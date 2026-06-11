using DocumentFormat.OpenXml.Office2021.MipLabelMetaData;
using Siticone.Desktop.UI.WinForms;
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

using TickVibeLib;

namespace TickVibe
{
    public partial class frmSideBar : Form
    {
        
        private Form activeForm = null;
        public string UserCode {  get; set; }
        public int CategoryId { get; set; }
        private Button siticoneactiveButton = null;
        //private Panel pnlIndicator;
        //public frmSideBar()
        //{
        //    InitializeComponent();
        //}

        public  frmSideBar(string UCode)
        {
            InitializeComponent();
            UserCode = UCode;
            //CategoryId = CId;
        }
        private void HighlightMenu(Control btn)
        {

            //pnlIndicator.Top = btn.Top;
            //pnlIndicator.Left = 0;
            //pnlIndicator.Height = btn.Height;
            ResetMenu();

           
                btnDashBoard.BackColor = Color.Transparent;
            btnMemberManagement.BackColor = Color.Transparent;
            btnTicketManagement.BackColor = Color.Transparent;
            btnEmployee.BackColor = Color.Transparent;
            btnTicket.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            siticonebtnBlog.BackColor = Color.Transparent;

            btnDashBoard.ForeColor = Color.White;
            btnMemberManagement.ForeColor = Color.White;
            btnTicketManagement.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnTicket.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;
            siticonebtnBlog.ForeColor = Color.White;

            btn.BackColor = Color.FromArgb(103, 58, 183);
            btn.ForeColor = Color.Yellow;
            ResetMenu();

            if (btn is Siticone.Desktop.UI.WinForms.SiticoneButton sb)
            {
                sb.FillColor = Color.FromArgb(103, 58, 183);
                sb.ForeColor = Color.Yellow;
            }

            //btn.Checked = true;
        }
        private void ResetMenu()
        {
            btnDashBoard.FillColor = Color.Transparent;
            btnMemberManagement.FillColor = Color.Transparent;
            btnTicketManagement.FillColor = Color.Transparent;
            btnEmployee.FillColor = Color.Transparent;
            btnReport.FillColor = Color.Transparent;

            btnTicket.FillColor = Color.Transparent;      // Ticket
            siticonebtnBlog.FillColor = Color.Transparent; // Blog


            btnDashBoard.ForeColor = Color.White;
            btnMemberManagement.ForeColor = Color.White;
            btnTicketManagement.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;

            btnTicket.ForeColor = Color.White;
            siticonebtnBlog.ForeColor = Color.White;
            siticoneButton1.ForeColor = Color.White;
        }
        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            HighlightMenu(btnReport);
            //frmReportMB obj=new frmReportMB(UserCode);



            //frmAgentTabularViewFixMB obj = new frmAgentTabularViewFixMB(UserCode,CategoryId);
            //obj.FormBorderStyle = FormBorderStyle.None;
            //obj.TopLevel = false;
            //siticoneCustomGradientPanel2.Controls.Clear();
            //siticoneCustomGradientPanel2.Controls.Add(obj);
            //obj.StartPosition = FormStartPosition.Manual;
            //obj.Location = this.Location;
            //obj.Size = this.Size;
            //obj.Show();
            var form = new frmAgentTabularViewFixMB(UserCode, CategoryId);
            form.SetParentSideBar(this);
            loadform(form);
            
           


        }

        public void loadform(Form f)
        {
            //siticonePanel1.BackColor = Color.FromArgb(24, 28, 33);
            if (activeForm != null)
            {
                siticoneCustomGradientPanel2.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = f;

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            siticoneCustomGradientPanel2.Controls.Clear(); // optional but clean
            siticoneCustomGradientPanel2.Controls.Add(f);
            siticoneCustomGradientPanel2.Tag = f;

            f.BringToFront();
            f.Show();

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            frmEditProfilePS obj = new frmEditProfilePS(UserCode);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
            
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            HighlightMenu(btnTicket);
            //HighlightMenu(btn);
            frmNewTicketPG obj=new frmNewTicketPG(UserCode);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
            
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            HighlightMenu(btnLogout);
            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Close();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

            
            HighlightMenu(btnDashBoard);
            frmDashSA obj = new frmDashSA(UserCode);
           
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;

            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);

            obj.Show();




        }

        private void siticonePictureBox12_Click(object sender, EventArgs e)
        {

        }
            // Sidebar
      

        private void frmSideBar_Load(object sender, EventArgs e)
        {
            
            //pnlIndicator.Left = 0;
            //pnlIndicator = new Panel();
            //pnlIndicator.Size = new Size(5, btnDashBoard.Height);
            //pnlIndicator.BackColor = Color.Yellow;
            //pnlIndicator.Top = btnDashBoard.Left;
            //siticoneCustomGradientPanel3.Controls.Add(pnlIndicator);
            //pnlIndicator.BringToFront();

            clsTeamLeader obj = new clsTeamLeader();
            obj.UserCode= UserCode;
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            DataTable dt1 = new DataTable();
            dt1= obj2.SideBarSG();
            if (dt1 != null && dt1.Rows.Count > 0)
            {
                lblTeamLeader.Text = dt1.Rows[0]["FullName"].ToString();
                lblCategoryName.Text = dt1.Rows[0]["CategoryName"].ToString();
               
            }
            else
            {
                MessageBox.Show("No data found for this user");
            }

            clsTeamLeader obj3 = new clsTeamLeader();
            DataTable dt12 = new DataTable();
            dt12 = obj3.profilemain();
            string imagePath = dt12.Rows[0]["FilePath"].ToString();


            PcbTlProfile.ImageLocation = imagePath;
            PcbTlProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            // Sidebar
            // Color.Black;

            // Hover
            //Color.FromArgb(30, 30, 30);

            // Indicator
            //Color.Cyan;

            // Text
            // Color.White;
            IsMdiContainer = true;

            PNotification.Visible = false;

            clsTeamLeader objc = new clsTeamLeader();
            DataTable dt= objc.SelectCountAL();

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
                DataColumn col = new DataColumn("Sr.No", typeof(int));
                dtr.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i = 0; i < dtr.Rows.Count; i++)
            {

                dtr.Rows[i]["Sr.No"] = i + 1;
            }
            grdNotification1.DataSource = dtr;
            grdNotification1.Show();
            grdNotification1.Columns["NotificationId"].Visible = false;
            lblEMPCode.Text=UserCode;

            //dashboard
            frmDashSA obj1 = new frmDashSA(UserCode);
            obj1.TopLevel = false;
            obj1.FormBorderStyle = FormBorderStyle.None;
            obj1.Dock = DockStyle.Fill;

            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj1);

            obj1.Show();
            //end
        }


        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void siticonePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_FontChanged(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTicketManagement_Click(object sender, EventArgs e)
        {
            HighlightMenu(btnTicketManagement);
            frmNewticketSG obj = new frmNewticketSG(UserCode);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
            
        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            HighlightMenu(btnMemberManagement);
            frmMemberManagementRN obj=new frmMemberManagementRN(UserCode,CategoryId);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
           
        }

        private void btnEmployee_Click_2(object sender, EventArgs e)
        {
            HighlightMenu(btnEmployee);
            frmEmployeeDetailsSB obj = new frmEmployeeDetailsSB(UserCode,CategoryId);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            HighlightMenu(siticonebtnBlog);
            //frmBlogAL obj = new frmBlogAL(UserCode);
            //obj.Show();
            frmKnowledgeBaseBlogAL obj = new frmKnowledgeBaseBlogAL(lblEMPCode.Text);
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.TopLevel = false;
            siticoneCustomGradientPanel2.Controls.Clear();
            siticoneCustomGradientPanel2.Controls.Add(obj);
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Size = this.Size;
            obj.Show();
            //this.Hide();

            //siticonebtnBlog.Visible = false;
        }

        private void lblEMPCode_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUnReadCount_Click(object sender, EventArgs e)
        {
            // PNotification.Visible = !PNotification.Visible;
            frmNotificationAL obj = new frmNotificationAL();
            obj.Show();
        }

        private void lblTeamLeader_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBNotification1_MouseHover(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            //pProfilePhoto.Visible=!pProfilePhoto.Visible;
        }

        private void siticonePanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTickvibee_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneCustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            siticonePanel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PcbTlProfile_Click(object sender, EventArgs e)
        {
            //HighlightMenu(btnEditProfile_Clic);
            //siticonePanel1.Visible = !siticonePanel1.Visible;
            ProfilePS obj = new ProfilePS(UserCode);
           
            obj.Show();
           



        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            //frmEditProfilePS obj = new frmEditProfilePS(UserCode);
            //obj.FormBorderStyle = FormBorderStyle.None;
            //obj.TopLevel = false;
            //siticoneCustomGradientPanel2.Controls.Clear();
            //siticoneCustomGradientPanel2.Controls.Add(obj);
            //obj.StartPosition = FormStartPosition.Manual;
            //obj.Location = this.Location;
            //obj.Size = this.Size;
            //obj.Show();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            //frmChangePasswordPS objA = new frmChangePasswordPS(UserCode);
            //objA.Show();
        }

        private void grdNotification1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
{
                DataGridViewRow SelectedRow = grdNotification1.Rows[e.RowIndex];
                int NotificationId = Convert.ToInt32(grdNotification1.Rows[e.RowIndex].Cells["NotificationId"].Value);
            }
        }

        private void PNotification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            if (grdNotification1.SelectedRows.Count > 0)
            {
                int notificationId = Convert.ToInt32(
                grdNotification1.SelectedRows[0].Cells["NotificationId"].Value);

                clsTeamLeader obj = new clsTeamLeader();
                obj.UpdateNotificationAL(notificationId);

                MessageBox.Show("Marked as Read Successfully ");
            }
            else
            {
                MessageBox.Show("Please select a row first ");
            }
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReport_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Close();
            
        }
    }
}
