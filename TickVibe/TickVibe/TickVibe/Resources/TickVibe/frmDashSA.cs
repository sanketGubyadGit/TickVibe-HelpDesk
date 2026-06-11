using DocumentFormat.OpenXml.Wordprocessing;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmDashSA : Form
    {
        public string userCode { get; set; }
        public int CategoryId { get; set; }

        public string PageTitle { get; set; }

        private frmLstView ticketForm;  

        public frmDashSA(string User)
        {

            InitializeComponent();
            userCode = User;



        }


        private void BarTkt_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime FromDate = dtpFromDate.Value.Date;
            DateTime ToDate = dtpToDate.Value.Date;
            string userCode = cmbbxAgentSA.SelectedValue.ToString();
            //int categoryId = Convert.ToInt32(cmbbxAgentSA.
            var result = BarTkt.HitTest(e.X, e.Y);

            if (result.ChartElementType != ChartElementType.DataPoint)
                return;

            int index = result.PointIndex;
            string status = BarTkt.Series[0].Points[index].AxisLabel;



            userCode = cmbbxAgentSA.SelectedValue.ToString();


            int statusId = Convert.ToInt32(
      BarTkt.Series[0].Points[index].Tag);


            if (status == "New")
                statusId = 1;
            else if (status == "In Progress")
                statusId = 2;
            else if (status == "Open")
                statusId = 3;
            else if (status == "Due Soon")
                statusId = 4;
            else if (status == "Over Due")
                statusId = 5;
            else if (status == "Hold")
                statusId = 6;
            else if (status == "Closed")
                statusId = 7;
            else if (status == "Escalated")
                statusId = 8;
            else if (status == "Resolved")
                statusId = 9;
            else if (status == "Accepted")
                statusId = 10;
            else if (status == "Assign")
                statusId = 11;
            else if (status == "Reassign")
                statusId = 12;







            //frmLstView obj = new frmLstView(userCode, statusId, FromDate, ToDate);
            frmLstView obj = new frmLstView(userCode, statusId, FromDate, ToDate, "Chart");
            
            obj.PageTitle = status + " Tickets";
            obj.Show();
            //obj.TopLevel = false;
            //obj.FormBorderStyle = FormBorderStyle.None;
            //obj.Dock = DockStyle.Fill;

        }


        private void cmbbxAgentSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxAgentSA.SelectedValue == null)
            {
                MessageBox.Show("Select agent first");
                return;
            }
            DateTime FromDate = dtpFromDate.Value.Date;
            DateTime ToDate = dtpToDate.Value.Date;
            BarTkt.Titles.Clear();
            Title t = new Title();
            t.Text = "Agent Tickets : " + cmbbxAgentSA.Text;
            //t.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            //t.ForeColor = Color.DimGray;
            t.Alignment = ContentAlignment.TopCenter;

            BarTkt.Titles.Add(t);




            String UserCode = cmbbxAgentSA.SelectedValue.ToString();




            clsTeamLeader obj = new clsTeamLeader();

            clsTeamLeader obj2 = new clsTeamLeader(obj);
            obj2.UserCode = UserCode;
            obj2.FromDate = FromDate;
            obj2.ToDate = ToDate;
            obj2.CategoryId = CategoryId;
            DataTable dt2 = new DataTable();
            dt2 = obj2.DropDownIntoChartSA();
            BarTkt.Series["Tickets"].XValueMember = "StatusName";
            BarTkt.Series["Tickets"].YValueMembers = "TotalTickets";
            BarTkt.Series["Tickets"].ChartArea = "ChartArea1";
            BarTkt.Series["Tickets"].Points.Clear();


            BarTkt.DataSource = dt2;
            BarTkt.DataBind();
            for (int i = 0; i < BarTkt.Series[0].Points.Count; i++)
            {
                BarTkt.Series[0].Points[i].Tag = dt2.Rows[i]["StatusId"];
            }



            clsTeamLeader progressObj = new clsTeamLeader();
            progressObj.UserCode = UserCode;
            progressObj.FromDate = FromDate;
            progressObj.ToDate = ToDate;
            clsTeamLeader obj1 = new clsTeamLeader(progressObj);


            DataTable dt4 = new DataTable();
            dt4 = obj1.ProgressBarSA();

            if (dt4.Rows.Count > 0)
            {
                int TotalTkt = Convert.ToInt32(dt4.Rows[0]["TotalTickets"]);
                int ClosedTkt = Convert.ToInt32(dt4.Rows[0]["ClosedTickets"]);

                ProgressBarSA.Minimum = 0;
                ProgressBarSA.Maximum = 100;

                if (TotalTkt > 0)
                {
                    int percentage = (ClosedTkt * 100) / TotalTkt;
                    ProgressBarSA.Value = percentage;
                    lblPercent.Text = percentage + "%";

                }
                else
                {
                    ProgressBarSA.Value = 0; // no tickets case
                }
            }

            //DateTime FromDate = dtpFromDate.Value.Date;
            //DateTime ToDate = dtpToDate.Value.Date;

            //clsTeamLeader Type = new clsTeamLeader(UserCode, FromDate, ToDate);
            //DataTable dt5 = new DataTable();
            //dt5 = Type.AgentSA();
            //BarTkt.DataSource = dt5;

            //BarTkt.DataBind();
            //BarTkt.Show();

        }

        private void cmbbxTypeSA_SelectedIndexChanged_1(object sender, EventArgs e)
        {



        }

        private void cmbbxAgentSA_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }



        private void BarTkt_Click(object sender, EventArgs e)
        {

        }





        private void frmDashSA_Load(object sender, EventArgs e)
        {
          
            clsTeamLeader objTkt = new clsTeamLeader();
            objTkt.UserCode = userCode;

            clsTeamLeader obj = new clsTeamLeader(objTkt);
            DataTable dt1 = new DataTable();


            dt1 = obj.DashBoardCardsSA();

            if (dt1.Rows.Count > 0)
            {


                lblTotalTickets.Text = dt1.Rows[0]["TotalTickets"].ToString();
                lblNewTickets.Text = dt1.Rows[0]["NewTickets"].ToString();
                lblInProgressTickets.Text = dt1.Rows[0]["InProgressTickets"].ToString();
                lblOpen.Text = dt1.Rows[0]["OpenTickets"].ToString();
                lblDueSoon.Text = dt1.Rows[0]["DueSoonTickets"].ToString();
                lblOverDue.Text = dt1.Rows[0]["OverDueTickets"].ToString();
                lblHoldT.Text = dt1.Rows[0]["HoldTickets"].ToString();
                lblClosed.Text = dt1.Rows[0]["ClosedTickets"].ToString();
                lblEscalated.Text = dt1.Rows[0]["EscalatedTickets"].ToString();
                lblResolved.Text = dt1.Rows[0]["ResolvedTickets"].ToString();
                lblAccepted.Text = dt1.Rows[0]["AcceptedTickets"].ToString();
                lblAssign.Text = dt1.Rows[0]["AssignTickets"].ToString();
                lblReassign.Text = dt1.Rows[0]["ReassignTickets"].ToString();
                lblTotalTickets.Show();
            }
            else
            {
                MessageBox.Show("No dashboard data found.");
            }



            cmbbxAgentSA.Items.Clear();
            //Fetching data into combobox
            clsTeamLeader objDropDown = new clsTeamLeader();
            //objDropDown.CategoryId = Convert.ToInt32(lblCategoryId.Text);
            objDropDown.UserCode = userCode;
            clsTeamLeader obj1 = new clsTeamLeader(objDropDown);
            DataTable dt2 = new DataTable();
            dt2 = obj1.DropDownSA();
            // MessageBox.Show(dt2.Rows.Count.ToString());


            cmbbxAgentSA.DisplayMember = "FullName";
            cmbbxAgentSA.ValueMember = "UserCode";
            cmbbxAgentSA.DataSource = dt2;
            cmbbxAgentSA.Show();
        }

        private void siticoneLabel6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel15_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblAssign_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel14_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void siticonePanel3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOverDue_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel16_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel17_Click(object sender, EventArgs e)
        {

        }

        private void lblDueSoon_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashBoard_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void siticonePanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenTicketList(int statusId)
        {
            if (ticketForm != null && !ticketForm.IsDisposed)
            {
                ticketForm.Close();
            }
            DateTime FromDate = dtpFromDate.Value.Date;
            DateTime ToDate = dtpToDate.Value.Date;

            string userCode = cmbbxAgentSA.SelectedValue.ToString();

            frmLstView obj = new frmLstView(
                userCode,
                statusId,
                FromDate,
                ToDate,
                "Card"      // Card Click Mode
            );
            obj.PageTitle = "New Tickets";
            if (statusId == 0)
            {
                obj.PageTitle = "Total Tickets";
            }


            switch (statusId)
            {
                case 1:
                    obj.PageTitle = "New Tickets";
                    break;

                case 2:
                    obj.PageTitle = "In Progress Tickets";
                    break;

                case 3:
                    obj.PageTitle = "Open Tickets";
                    break;

                case 4:
                    obj.PageTitle = "Due Soon Tickets";
                    break;

                case 5:
                    obj.PageTitle = "Overdue Tickets";
                    break;

                case 6:
                    obj.PageTitle = "Hold Tickets";
                    break;

                case 7:
                    obj.PageTitle = "Closed Tickets";
                    break;

                case 8:
                    obj.PageTitle = "Escalated Tickets";
                    break;

                case 9:
                    obj.PageTitle = "Resolved Tickets";
                    break;

                case 10:
                    obj.PageTitle = "Accepted Tickets";
                    break;

                case 11:
                    obj.PageTitle = "Assigned Tickets";
                    break;

                case 12:
                    obj.PageTitle = "Reassigned Tickets";
                    break;
            }


            

            obj.Show();
        }

        private void siticoneCustomGradientPanel2_DoubleClick(object sender, EventArgs e)
        {

        }











        private void siticoneCustomGradientPanel6_Click(object sender, EventArgs e)
        {
            OpenTicketList(5);
        }

        private void siticoneCustomGradientPanel9_Click(object sender, EventArgs e)
        {
            OpenTicketList(8);
        }

        private void siticoneCustomGradientPanel8_Click(object sender, EventArgs e)
        {
            OpenTicketList(7);
        }

        private void siticoneCustomGradientPanel3_Click(object sender, EventArgs e)
        {
            OpenTicketList(2);
        }

        private void siticoneCustomGradientPanel10_Click(object sender, EventArgs e)
        {
            OpenTicketList(9);
        }

        private void siticoneCustomGradientPanel13_Click(object sender, EventArgs e)
        {
            OpenTicketList(12);
        }

        private void siticoneCustomGradientPanel7_Click(object sender, EventArgs e)
        {
            OpenTicketList(6);
        }

        private void siticoneCustomGradientPanel11_Click(object sender, EventArgs e)
        {
            OpenTicketList(10);
        }

        private void siticoneCustomGradientPanel2_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(1);
        }

        private void siticoneCustomGradientPanel12_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(11);
        }

        private void siticoneCustomGradientPanel4_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(3);
        }

        private void siticoneCustomGradientPanel5_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(4);//Duesoon
        }

        private void siticoneCustomGradientPanel6_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(5);//OverDue
        }

        private void siticoneCustomGradientPanel9_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(8);
        }

        private void siticoneCustomGradientPanel8_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(7);
        }

        private void siticoneCustomGradientPanel3_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(2);
        }

        private void siticoneCustomGradientPanel10_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(9);
        }



        private void siticoneCustomGradientPanel13_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(12);
        }
        private void siticoneCustomGradientPanel7_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(6);
        }

        private void siticoneCustomGradientPanel11_Click_1(object sender, EventArgs e)
        {
            OpenTicketList(10);
        }

        private void siticoneCustomGradientPanel1_Click(object sender, EventArgs e)
        {
            OpenTicketList(0);
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}