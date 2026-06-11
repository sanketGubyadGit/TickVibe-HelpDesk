using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmAgentViewChartTypeColumnMB : Form
    {
        public string agentcode { get; set; }
        public string tlcode { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public int categoryid { get; set; }
        public string agentname { get; set; }
        public frmAgentViewChartTypeColumnMB()
        {
            InitializeComponent();


        }


        public frmAgentViewChartTypeColumnMB(String ac, string tlcode1, DateTime fd, DateTime td, int categoryid1)
        {
            InitializeComponent();
            agentcode = ac;
            tlcode = tlcode1;
            fromdate = fd;
            todate = td;
            categoryid = categoryid1;

        }

        private void chart1GraphicalView_Click(object sender, EventArgs e)
        {

        }

        private void chart1GraphicalView_MouseClick(object sender, MouseEventArgs e)
        {



            HitTestResult result = chart1GraphicalView.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {

                DataPoint point = chart1GraphicalView.Series[0].Points[result.PointIndex];
                string status = point.AxisLabel;
                string empcode = agentcode;


                frmGridViewStatusMB obj = new frmGridViewStatusMB(status, empcode, tlcode, fromdate, todate,categoryid);
                obj.Text = "Agent Graphical View"; // Set form title
                obj.Tag = "GraphicalView"; // Set tag to identify
                obj.Show();
            }









        }

        private void cmbFilterDaywise_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(agentcode)) return;
            string filter = cmbFilterDaywise.Text;


            if (filter == "Daywise")
            {
                dtpFromDate.CustomFormat = "dd/MM/yyyy";
                dtpToDate.CustomFormat = "dd/MM/yyyy";
                fromdate = dtpFromDate.Value.Date;
                todate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);
            }
            else if (filter == "Monthwise")
            {
                dtpFromDate.CustomFormat = "MM/yyyy";
                dtpToDate.CustomFormat = "MM/yyyy";
                fromdate = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, 1);
                int lastDay = DateTime.DaysInMonth(dtpToDate.Value.Year, dtpToDate.Value.Month);
                todate = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, lastDay, 23, 59, 59);
            }
            else
            {
                dtpFromDate.CustomFormat = "yyyy";
                dtpToDate.CustomFormat = "yyyy";
                fromdate = new DateTime(dtpFromDate.Value.Year, 1, 1);
                todate = new DateTime(dtpToDate.Value.Year, 12, 31, 23, 59, 59);
            }

            //clsTeamLeader obj = new clsTeamLeader(agentcode, fromdate, todate);
            clsTeamLeader obj = new clsTeamLeader();
            obj.empcode = agentcode;
            obj.tlempcode = tlcode;
            obj.categoryid = categoryid;
            obj.fromdate = fromdate;
            obj.todate = todate;
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            DataTable dt = obj2.ShowGraphicalViewChart22MB();

            if (dt.Rows.Count == 0)
            {
                chart1GraphicalView.Series[0].Points.Clear();

                chart1GraphicalView.Titles.Clear();
                chart1GraphicalView.Titles.Add("Agent Name : " + agentname);
                chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);
                chart1GraphicalView.Titles.Add("No Tickets Available For Selected Date");

                return;
            }
            else
            {
                chart1GraphicalView.Titles.Clear();
                chart1GraphicalView.Titles.Add("Agent Name : " + agentname);
                chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);
            }


           


          

         
            chart1GraphicalView.DataSource = dt;
            chart1GraphicalView.Series[0].XValueMember = "StatusName";
            chart1GraphicalView.Series[0].YValueMembers = "TicketCount";
            chart1GraphicalView.Series[0].ChartType = SeriesChartType.Column;
            chart1GraphicalView.DataBind();
            LoadAgentProgress();







        }



        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                dtpToDate.Value = dtpFromDate.Value;
            }
            dtpToDate.MinDate = dtpFromDate.Value;

            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                dtpToDate.Value = dtpFromDate.Value;
            }

            
            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void frmAgentViewChartTypeColumn_Load(object sender, EventArgs e)
        {
            cpbAgent.Minimum = 0;
            cpbAgent.Maximum = 100;

            chart1GraphicalView.Titles.Clear();
            chart1GraphicalView.Titles.Add("Agent Name : " + agentname);

            chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);

            cmbFilterDaywise.Items.Add("Daywise");
            cmbFilterDaywise.Items.Add("Monthwise");
            cmbFilterDaywise.Items.Add("Yearwise");
            chart1GraphicalView.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1GraphicalView.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            chart1GraphicalView.Series["Tickets"]["PixelPointWidth"] = "60";
           

            
            cmbFilterDaywise.SelectedItem = "Yearwise";

            cmbFilterDaywise_SelectedIndexChanged(null, null);
            

        }





        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void LoadAgentProgress()
        {
            clsTeamLeader obj = new clsTeamLeader();
            obj.empcode = agentcode;
            obj.categoryid = categoryid;
            obj.fromdate = fromdate;
            obj.todate = todate;

            clsTeamLeader obj2 = new clsTeamLeader(obj);
            DataTable dt = obj2.ShowGraphicalViewAgentProgressBarMB(); 

            if (dt.Rows.Count > 0)
            {
                int total = Convert.ToInt32(dt.Rows[0]["TotalTickets"]);
                int closed = Convert.ToInt32(dt.Rows[0]["ClosedTickets"]);

                if (total > 0)
                {
                    int percentage = (closed * 100) / total;

                    cpbAgent.Value = percentage;
                    lblPercentage.Text = percentage + " %";
                }
                else
                {
                    cpbAgent.Value = 0;
                    lblPercentage.Text = "0 %";
                }
            }
        }

        private void cpbAgent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPercentage_Click(object sender, EventArgs e)
        {

        }

        private void lblFilter_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }










      



    }
}
