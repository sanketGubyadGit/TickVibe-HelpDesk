
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmEmployeeViewChartTypeColumnMB : Form
    {
        public string empcode { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public string tlcode { get; set; }
        public string empname { get; set; }
        public frmEmployeeViewChartTypeColumnMB()
        {
            InitializeComponent();
           
        }

        public frmEmployeeViewChartTypeColumnMB(String ac, string tlcode1,DateTime fd, DateTime td)
        {
            InitializeComponent();
            empcode = ac;
            tlcode = tlcode1;
            fromdate = fd;
            todate = td;
        }

        private void cmbFilterDaywise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(empcode)) return;
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

        
            clsTeamLeader obj = new clsTeamLeader();
            obj.empcode = empcode;
            obj.tlempcode = tlcode;
            obj.fromdate = fromdate;
            obj.todate = todate;
           
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            DataTable dt = obj2.ShowGraphicalViewChartEmployee22MB();


            if (dt.Rows.Count == 0)
            {
                chart1GraphicalView.Series[0].Points.Clear();

                chart1GraphicalView.Titles.Clear();
                chart1GraphicalView.Titles.Add("Employee Name : " + empname);
                chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);
                chart1GraphicalView.Titles.Add("No Tickets Available For Selected Date");

                return;
            }
            else
            {
                chart1GraphicalView.Titles.Clear();
                chart1GraphicalView.Titles.Add("Employee Name : " + empname);
                chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);
            }


            chart1GraphicalView.DataSource = dt;
            chart1GraphicalView.Series[0].XValueMember = "StatusName";
            chart1GraphicalView.Series[0].YValueMembers = "TicketCount";
            chart1GraphicalView.Series[0].ChartType = SeriesChartType.Column;
            chart1GraphicalView.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1GraphicalView.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //chart1GraphicalView.ChartAreas[0].AxisX.Title = "Ticket Status";
            //chart1GraphicalView.ChartAreas[0].AxisY.Title = "Ticket Count";

            chart1GraphicalView.Series["Tickets"]["PixelPointWidth"] = "60";
            chart1GraphicalView.DataBind();








        }




        private void chart1GraphicalView_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1GraphicalView.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {

                DataPoint point = chart1GraphicalView.Series[0].Points[result.PointIndex];
                string status = point.AxisLabel;
               

                frmGridViewStatusEmployeeMB obj = new frmGridViewStatusEmployeeMB(status, tlcode, empcode, fromdate, todate);
                obj.Show();
            }


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
            dtpToDate.MinDate = dtpFromDate.Value;

            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void frmEmployeeViewChartTypeColumnMB_Load(object sender, EventArgs e)
        {

            chart1GraphicalView.Titles.Clear();
            chart1GraphicalView.Titles.Add("Employee Name : " + empname);

           // chart1GraphicalView.Titles[0].Font = new Font("Times New Roman", 11, FontStyle.Bold);

            cmbFilterDaywise.Items.Add("Daywise");
            cmbFilterDaywise.Items.Add("Monthwise");
            cmbFilterDaywise.Items.Add("Yearwise");
            chart1GraphicalView.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1GraphicalView.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            chart1GraphicalView.Series["Tickets"]["PixelPointWidth"] = "60";
            

            cmbFilterDaywise.SelectedItem = "Yearwise";

            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void chart1GraphicalView_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
