using System;
using DrawingFont = System.Drawing.Font;
using PdfFont = iTextSharp.text.Font;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TickVibeLib;
using static Siticone.UI.Native.WinApi;







namespace TickVibe
{

    public partial class frmNewTicketPG : Form
    {



        private Dictionary<DataGridView, CheckBox> headerBoxes
         = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public string UserCode;
        public string filepath;
        public frmNewTicketPG(string usercode)
        {
            InitializeComponent();
            UserCode = usercode;
            //filepath = Filepath;

            //lblEMPCode.Text = usercode;

        }

        private void frmNewTicketPG_Load(object sender, EventArgs e)
        {
            
            //grdNewTicket.AutoGenerateColumns = true;
            //grdConfirmTicket.AutoGenerateColumns = true;
            //grdIPTickets.AutoGenerateColumns = true;
            //grdHoldtickets.AutoGenerateColumns = true;
            //grdClosedTickets.AutoGenerateColumns = true;

            //Filter butn
            //pnlNewfilter.Visible = false;
            //pnlConfirmFilter.Visible = false;
            //pnlIPFilter.Visible = false;
            //pnlHoldFilter.Visible = false;
            //pnlClosedFilter.Visible = false;

            //Priority in Combobox
            clsTeamLeader cls = new clsTeamLeader();
            DataTable dt = cls.FPriorityPG();

            cmbbxNTPriority.DisplayMember = "PriorityName";
            cmbbxNTPriority.ValueMember = "PriorityId";
            cmbbxNTPriority.DataSource = dt;

            cmbbxCTPriority.DisplayMember = "PriorityName";
            cmbbxCTPriority.ValueMember = "PriorityId";
            cmbbxCTPriority.DataSource = dt;

            cmbbxIPTPriority.DisplayMember = "PriorityName";
            cmbbxIPTPriority.ValueMember = "PriorityId";
            cmbbxIPTPriority.DataSource = dt;

            cmbbxHTPriority.DisplayMember = "PriorityName";
            cmbbxHTPriority.ValueMember = "PriorityId";
            cmbbxHTPriority.DataSource = dt;

            cmbbxClosedTPriority.DisplayMember = "PriorityName";
            cmbbxClosedTPriority.ValueMember = "PriorityId";
            cmbbxClosedTPriority.DataSource = dt;

            //// New Ticket Code
            clsTeamLeader tkt = new clsTeamLeader();
            tkt.UserCode = UserCode;
            DataTable dt1 = tkt.FNewTCode();
            cmbbxNTTCode.DisplayMember = "TktCode";
            cmbbxNTTCode.ValueMember = "TktCode";
            cmbbxNTTCode.DataSource = dt1;


            //Confirm  Ticket Code
            clsTeamLeader tkt1 = new clsTeamLeader();
            tkt1.UserCode = UserCode;
            DataTable dt2 = tkt1.FConfirmTktCodePG();
            cmbbxCTTCode.DisplayMember = "TktCode";
            cmbbxCTTCode.ValueMember = "TktCode";
            cmbbxCTTCode.DataSource = dt2;

            // In Progress ticket Code
            clsTeamLeader tkt2 = new clsTeamLeader();
            tkt2.UserCode = UserCode;
            DataTable dt3 = tkt2.FInProgressTktCodePG();
            cmbbxIPTTCode.DisplayMember = "TktCode";
            cmbbxIPTTCode.ValueMember = "TktCode";
            cmbbxIPTTCode.DataSource = dt3;

            //Hold Ticket Code
            clsTeamLeader tkt3 = new clsTeamLeader();
            tkt3.UserCode = UserCode;
            DataTable dt4 = tkt3.FHTktCodePG();
            cmbbxHTTCode.DisplayMember = "TktCode";
            cmbbxHTTCode.ValueMember = "TktCode";
            cmbbxHTTCode.DataSource = dt4;

            //Closed Ticket Code
            clsTeamLeader tkt4 = new clsTeamLeader();
            tkt4.UserCode = UserCode;
            DataTable dt10 = tkt4.FClosedTktCodePG();
            cmbbxClosedTCode.DisplayMember = "TktCode";
            cmbbxClosedTCode.ValueMember = "TktCode";
            cmbbxClosedTCode.DataSource = dt10;


            //Fetched New Ticket call
            clsTeamLeader grdn = new clsTeamLeader();
            grdn.UserCode = UserCode;
            clsTeamLeader grdn1 = new clsTeamLeader(grdn);
            DataTable dt5 = grdn1.FNewTPG();
            //grdNewTickets.AutoGenerateColumns = true;
            if (!dt5.Columns.Contains("SrNo"))
            {
                DataColumn srcol = new DataColumn("SrNo", typeof(int));
                dt5.Columns.Add(srcol);
                srcol.SetOrdinal(0);
            }
            for (int i = 0; i < dt5.Rows.Count; i++)
            {

                dt5.Rows[i]["SrNo"] = i + 1;
            }
            grdNewTicket.DataSource = dt5;
            AddCheckBoxWithHeaderPG(grdNewTicket);
            GridviewPG(grdNewTicket);
            AddActionColumnsPG(grdNewTicket);
            SetGridFont(grdNewTicket);


            // Fetch Confirm Ticket call
            clsTeamLeader grdc = new clsTeamLeader();
            grdc.UserCode = UserCode;
            clsTeamLeader grdc1 = new clsTeamLeader(grdc);
            DataTable dt6 = grdc1.FConfirmTPG();
            if (!dt6.Columns.Contains("SrNo"))
            {
                DataColumn srcol = new DataColumn("SrNo", typeof(int));
                dt6.Columns.Add(srcol);
                srcol.SetOrdinal(0);
            }
            for (int i = 0; i < dt6.Rows.Count; i++)
            {
                dt6.Rows[i]["SrNo"] = i + 1;
            }
            grdConfirmTicket.DataSource = dt6;
            AddCheckBoxWithHeaderPG(grdConfirmTicket);
            GridviewPG(grdConfirmTicket);
            AddActionColumnsPG(grdConfirmTicket);
            SetGridFont(grdConfirmTicket);


            //fetch Inprogress Ticket call
            clsTeamLeader grdI = new clsTeamLeader();
            grdI.UserCode = UserCode;
            clsTeamLeader grdI1 = new clsTeamLeader(grdI);
            DataTable dt7 = grdI1.FIProgressTPG();
            if (!dt7.Columns.Contains("SrNo"))
            {
                DataColumn col = new DataColumn("SrNo", typeof(int));
                dt7.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i = 0; i < dt7.Rows.Count; i++)
            {
                dt7.Rows[i]["SrNo"] = i + 1;
            }
            grdIPTickets.DataSource = dt7;
            AddCheckBoxWithHeaderPG(grdIPTickets);
            GridviewPG(grdIPTickets);
            AddActionColumnsPG(grdIPTickets);
            SetGridFont(grdIPTickets);


            // Hold Ticket
            clsTeamLeader grdH = new clsTeamLeader();
            grdH.UserCode = UserCode;
            clsTeamLeader grdH1 = new clsTeamLeader(grdH);
            DataTable dt8 = grdH1.FHoldTPG();
            if (!dt8.Columns.Contains("SrNo"))
            {
                DataColumn col = new DataColumn("SrNo", typeof(int));
                dt8.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i = 0; i < dt8.Rows.Count; i++)
            {
                dt8.Rows[i]["SrNo"] = i + 1;
            }
            grdHoldtickets.DataSource = dt8;
            AddCheckBoxWithHeaderPG(grdHoldtickets);
            GridviewPG(grdHoldtickets);
            AddActionColumnsPG(grdHoldtickets);
            grdHoldtickets.Show();
            SetGridFont(grdHoldtickets);


            // Closed ticket
            clsTeamLeader grdcl = new clsTeamLeader();
            grdcl.UserCode = UserCode;
            clsTeamLeader grdcl1 = new clsTeamLeader(grdcl);
            DataTable dt9 = grdcl1.FClosedTPG();
            if (!dt9.Columns.Contains("SrNo"))
            {
                DataColumn col = new DataColumn("SrNo", typeof(int));
                dt9.Columns.Add(col);
                col.SetOrdinal(0);
            }
            for (int i = 0; i < dt9.Rows.Count; i++)
            {
                dt9.Rows[i]["SrNo"] = i + 1;
            }
            grdClosedTickets.DataSource = dt9;
            AddCheckBoxWithHeaderPG(grdClosedTickets);
            GridviewPG(grdClosedTickets);
            SetGridFont(grdClosedTickets);


            if (!grdClosedTickets.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn actioncol4 = new DataGridViewButtonColumn();
                actioncol4.HeaderText = "Action";
                actioncol4.Name = "Action";
                actioncol4.Text = " ❌";
                actioncol4.UseColumnTextForButtonValue = true;
                grdClosedTickets.AllowUserToAddRows = false;
                grdClosedTickets.Columns.Add(actioncol4);
            }
            // REMOVE VIEW COLUMN FROM CLOSED GRID
            if (grdClosedTickets.Columns.Contains("View"))
            {
                grdClosedTickets.Columns.Remove("View");
            }

            // ACTION COLUMN ALWAYS LAST
            if (grdClosedTickets.Columns.Contains("Action"))
            {
                grdClosedTickets.Columns["Action"].DisplayIndex =
                    grdClosedTickets.Columns.Count - 1;
            }


            //Gridview  column set
            grdNewTicket.ColumnHeadersHeight = 40;
            grdNewTicket.BorderStyle = BorderStyle.FixedSingle;

            grdConfirmTicket.ColumnHeadersHeight = 40;
            grdConfirmTicket.BorderStyle = BorderStyle.FixedSingle;
            grdHoldtickets.ColumnHeadersHeight = 40;
            grdHoldtickets.BorderStyle = BorderStyle.FixedSingle;
            grdIPTickets.ColumnHeadersHeight = 40;
            grdIPTickets.BorderStyle = BorderStyle.FixedSingle;
            grdClosedTickets.ColumnHeadersHeight = 40;
            grdClosedTickets.BorderStyle = BorderStyle.FixedSingle;

            // Data Row Font Size


            grdNewTicket.Columns["View"].DisplayIndex = grdNewTicket.Columns.Count - 1;
            grdNewTicket.Columns["View"].DisplayIndex =
    grdNewTicket.Columns.Count - 1;

            ApplyProfessionalUI();
        }



        private void cmbbxNTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdNewTicket.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"Priority='{cmbbxNTPriority.Text}'";
            }

        }
        private void cmbbxNTTCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdNewTicket.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"TicketCode='{cmbbxNTTCode.Text}'";
            }
        }

        private void cmbbxCTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdConfirmTicket.DataSource as DataTable;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"Priority='{cmbbxCTPriority.Text}'";
            }
        }
        private void cmbbxCTTCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdConfirmTicket.DataSource as DataTable;

            if (dt != null)

            {
                dt.DefaultView.RowFilter = $"TicketCode='{cmbbxCTTCode.Text}'";
            }
        }

        private void cmbbxIPTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdIPTickets.DataSource as DataTable;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"priority='{cmbbxIPTPriority.Text}'";
            }
        }
        private void cmbbxIPTTCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdIPTickets.DataSource as DataTable;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"TicketCode='{cmbbxIPTTCode.Text}'";
            }
        }

        private void cmbbxHTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdHoldtickets.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"priority='{cmbbxHTPriority.Text}'";
            }
        }
        private void cmbbxHTTCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdHoldtickets.DataSource as DataTable;
            if (dt != null)

            {
                dt.DefaultView.RowFilter = $"TicketCode='{cmbbxHTTCode.Text}'";
            }

        }
        private void cmbbxClosedTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdClosedTickets.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"priority='{cmbbxClosedTPriority.Text}'";
            }

        }

        private void cmbbxClosedTCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdClosedTickets.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"TicketCode='{cmbbxClosedTCode.Text}'";
            }
        }

        private void grdClosedTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == grdClosedTickets.Columns["Action"].Index)
            //{
            //    grdClosedTickets.Rows.RemoveAt(e.RowIndex);
            //}

            if (e.RowIndex >= 0 && grdClosedTickets.Columns.Contains("Action") &&
               e.ColumnIndex == grdClosedTickets.Columns["Action"].Index)
            {
                grdClosedTickets.Rows.RemoveAt(e.RowIndex);
            }
        }

        //  show Tickets Detail for View Ticket Detail Form
        private void grdNewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdConfirmTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdConfirmTicket.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow selectedRow = grdConfirmTicket.Rows[e.RowIndex];

                string TktCode = selectedRow.Cells["TicketCode"].Value.ToString();

                frmViewIPTicketPG frm = new frmViewIPTicketPG(TktCode, UserCode);
                frm.Show();
            }
        }

        private void grdIPTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && grdIPTickets.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow selectedRow = grdIPTickets.Rows[e.RowIndex];

                string TktCode = selectedRow.Cells["TicketCode"].Value.ToString();

                frmViewIPTicketPG frm = new frmViewIPTicketPG(TktCode, UserCode);
                frm.Show();
            }

        }

        private void grdHoldtickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdHoldtickets.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow selectedRow = grdHoldtickets.Rows[e.RowIndex];

                string TktCode = selectedRow.Cells["TicketCode"].Value.ToString();

                frmViewIPTicketPG frm = new frmViewIPTicketPG(TktCode, UserCode);
                frm.Show();
            }
        }

        //  Filters 
        private void btnNTFilters_Click_1(object sender, EventArgs e)
        {
            pnlNewfilter.Visible = !pnlNewfilter.Visible;
        }

        private void btnCTFilter_Click(object sender, EventArgs e)
        {
            pnlConfirmFilter.Visible = !pnlConfirmFilter.Visible;
        }

        private void btnIPTFilter_Click(object sender, EventArgs e)
        {
            pnlIPFilter.Visible = !pnlIPFilter.Visible;
        }

        private void btnHTFilter_Click(object sender, EventArgs e)
        {
            pnlHoldFilter.Visible = !pnlHoldFilter.Visible;
        }

        private void btnClosedTFilter_Click(object sender, EventArgs e)
        {
            pnlClosedFilter.Visible = !pnlClosedFilter.Visible;
        }


        // Search text Validation
        private void txtSearchBoxNT_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchBoxNT.Text))
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }
            else
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode LIKE '%{0}%'  OR Priority LIKE '%{0}%'", txtSearchBoxNT.Text);

            }
        }


        private void txtSearchBoxCT_TextChanged_1(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtSearchBoxCT.Text))
            {

                (grdConfirmTicket.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (grdConfirmTicket.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode Like '%{0}%' OR Priority Like '%{0}%'", txtSearchBoxCT.Text);
            }

        }

        private void txtSearchBoxIPT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBoxIPT.Text))
            {
                (grdIPTickets.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (grdIPTickets.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode Like '%{0}%' OR Priority Like '%{0}%'", txtSearchBoxIPT.Text);
            }
        }

        private void txtSearchBoxHT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBoxHT.Text))
            {
                (grdHoldtickets.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (grdHoldtickets.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode Like '%{0}%' OR Priority Like '%{0}%'", txtSearchBoxHT.Text);
            }
        }

        private void txtSearchBoxCloseT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBoxCloseT.Text))
            {
                (grdClosedTickets.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (grdClosedTickets.DataSource as DataTable).DefaultView.RowFilter = String.Format("TicketCode like '%{0}%' OR Priority Like '%{0}%'", txtSearchBoxCloseT.Text);
            }
        }

        // gridview data show using Fromdate Todate 
        private void LoadNDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FNDatePG(dtpNFromdate.Value.Date,
                                        dtpNToDate.Value.Date,
                                        UserCode);

            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }

            //grdNewTicket.Columns.Clear();
            grdNewTicket.DataSource = null;

            grdNewTicket.AutoGenerateColumns = true;
            grdNewTicket.DataSource = dt;

            if (grdNewTicket.Columns.Contains("CompanyName"))
            {
                grdNewTicket.Columns["CompanyName"].Visible = true;
            }

            AddCheckBoxWithHeaderPG(grdNewTicket);
            GridviewPG(grdNewTicket);
            AddActionColumnsPG(grdNewTicket);
            SetGridFont(grdNewTicket);
            grdNewTicket.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadConfirmDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FCDatePG(dtpCFromDate.Value.Date, dtpCToDate.Value.Date, UserCode);

            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }
            //grdConfirmTicket.Columns.Clear();
            grdConfirmTicket.DataSource = null;

            grdConfirmTicket.AutoGenerateColumns = true;
            grdConfirmTicket.DataSource = dt;

            if (grdConfirmTicket.Columns.Contains("CompanyName"))
            {
                grdConfirmTicket.Columns["CompanyName"].Visible = true;
            }

            AddCheckBoxWithHeaderPG(grdConfirmTicket);
            GridviewPG(grdConfirmTicket);
            AddActionColumnsPG(grdConfirmTicket);
            SetGridFont(grdConfirmTicket);
            grdConfirmTicket.AutoSizeColumnsMode =
                 DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadIPDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FIPDatePG(dtpIPFromDate.Value.Date, dtpIPToDate.Value.Date, UserCode);
            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }
            //grdIPTickets.Columns.Clear();
            grdIPTickets.DataSource = null;

            grdIPTickets.AutoGenerateColumns = true;
            grdIPTickets.DataSource = dt;

            if (grdIPTickets.Columns.Contains("CompanyName"))
            {
                grdIPTickets.Columns["CompanyName"].Visible = true;
            }

            AddCheckBoxWithHeaderPG(grdIPTickets);
            GridviewPG(grdIPTickets);
            AddActionColumnsPG(grdIPTickets);
            SetGridFont(grdIPTickets);
            grdIPTickets.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadHoldTDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FHDatePG(dtpHFromDate.Value.Date, dtpHToDate.Value.Date, UserCode);


            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }
            //grdHoldtickets.Columns.Clear();
            grdHoldtickets.DataSource = null;

            grdHoldtickets.AutoGenerateColumns = true;
            grdHoldtickets.DataSource = dt;
            if (grdHoldtickets.Columns.Contains("CompanyName"))
            {
                grdHoldtickets.Columns["CompanyName"].Visible = true;
            }



            AddCheckBoxWithHeaderPG(grdHoldtickets);
            GridviewPG(grdHoldtickets);
            AddActionColumnsPG(grdHoldtickets);
            SetGridFont(grdHoldtickets);
            grdHoldtickets.AutoSizeColumnsMode =
                 DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadClosedTDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();

            DataTable dt = obj.FClosedDatePG(
                dtpCloseFromDate.Value.Date,
                dtpcloseToDate.Value.Date,
                UserCode);

            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }

            grdClosedTickets.DataSource = null;

            grdClosedTickets.AutoGenerateColumns = true;
            grdClosedTickets.DataSource = dt;

            if (grdClosedTickets.Columns.Contains("CompanyName"))
            {
                grdClosedTickets.Columns["CompanyName"].Visible = true;
            }

            AddCheckBoxWithHeaderPG(grdClosedTickets);
            GridviewPG(grdClosedTickets);
            SetGridFont(grdClosedTickets);

            // REMOVE VIEW COLUMN
            if (grdClosedTickets.Columns.Contains("View"))
            {
                grdClosedTickets.Columns.Remove("View");
            }

            // ADD ONLY ACTION COLUMN
            if (!grdClosedTickets.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn actioncol = new DataGridViewButtonColumn();

                actioncol.HeaderText = "Action";
                actioncol.Name = "Action";
                actioncol.Text = " ❌";
                actioncol.UseColumnTextForButtonValue = true;

                grdClosedTickets.Columns.Add(actioncol);
            }

            // ACTION COLUMN ALWAYS LAST
            grdClosedTickets.Columns["Action"].DisplayIndex =
                grdClosedTickets.Columns.Count - 1;

            grdClosedTickets.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dtpNFromdate_ValueChanged(object sender, EventArgs e)
        {
            LoadNDatePG();
        }

        private void dtpNToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadNDatePG();
        }

        private void dtpCFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadConfirmDatePG();
        }

        private void dtpCToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadConfirmDatePG();
        }

        private void dtpIPFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadIPDatePG();
        }

        private void dtpIPToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadIPDatePG();
        }

        private void dtpHFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadHoldTDatePG();
        }

        private void dtpHToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadHoldTDatePG();
        }

        private void dtpCloseFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadClosedTDatePG();
        }


        private void dtpcloseToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadClosedTDatePG();
        }


        // Refresh Data 
        private void pcbNTRefresh_Click(object sender, EventArgs e)
        {
            //grdNewTicket.AutoGenerateColumns = false;
            //grdNewTickets.AutoGenerateColumns = true;


            try
            {
                clsTeamLeader grdn = new clsTeamLeader();
                DataTable dt5 = grdn.FNewTPG();

                grdNewTicket.DataSource = dt5;
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetGridFont(grdNewTicket);
                //this.Refresh();
                txtSearchBoxNT.Clear();
                cmbbxNTPriority.SelectedIndex = -1;
                cmbbxNTTCode.SelectedIndex = -1;
                dtpNFromdate.Value = new DateTime(2026, 01, 01);
                dtpNToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
        }
        private void pcbCTRefresh_Click(object sender, EventArgs e)
        {
            grdConfirmTicket.AutoGenerateColumns = false;
            try
            {
                clsTeamLeader grdc = new clsTeamLeader();
                DataTable dt6 = grdc.FConfirmTPG();
                grdConfirmTicket.DataSource = dt6;
                grdConfirmTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetGridFont(grdConfirmTicket);
                txtSearchBoxCT.Clear();
                cmbbxCTPriority.SelectedIndex = -1;
                cmbbxCTTCode.SelectedIndex = -1;
                dtpCFromDate.Value = new DateTime(2026, 01, 01);
                dtpCToDate.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
        }

        private void pcbIPTRefresh_Click(object sender, EventArgs e)
        {

            grdIPTickets.AutoGenerateColumns = false;
            try
            {
                clsTeamLeader grdI = new clsTeamLeader();
                DataTable dt7 = grdI.FIProgressTPG();
                grdIPTickets.DataSource = dt7;
                grdIPTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetGridFont(grdIPTickets);

                txtSearchBoxIPT.Clear();
                cmbbxIPTPriority.SelectedIndex = -1;
                cmbbxIPTTCode.SelectedIndex = -1;
                dtpIPFromDate.Value = new DateTime(2026, 01, 01);
                dtpIPToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
        }

        private void pcbHTRefresh_Click(object sender, EventArgs e)
        {
            grdHoldtickets.AutoGenerateColumns = false;

            try
            {
                clsTeamLeader grdH = new clsTeamLeader();
                DataTable dt8 = grdH.FHoldTPG();
                grdHoldtickets.DataSource = dt8;
                grdHoldtickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetGridFont(grdHoldtickets);
                txtSearchBoxHT.Clear();
                cmbbxHTPriority.SelectedIndex = -1;
                cmbbxHTTCode.SelectedIndex = -1;
                dtpHFromDate.Value = new DateTime(2026, 01, 01);
                dtpHToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Refreshing:" + ex.Message);
            }
        }

        private void pcbClosedTRefresh_Click(object sender, EventArgs e)
        {

            grdClosedTickets.AutoGenerateColumns = false;
            try
            {
                clsTeamLeader grdcl = new clsTeamLeader();
                DataTable dt9 = grdcl.FClosedTPG();
                grdClosedTickets.DataSource = dt9;
                grdClosedTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SetGridFont(grdClosedTickets);
                txtSearchBoxCloseT.Clear();
                cmbbxClosedTPriority.SelectedIndex = -1;
                cmbbxClosedTCode.SelectedIndex = -1;
                dtpCloseFromDate.Value = new DateTime(2026, 01, 01);
                dtpcloseToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }

        }

        //   add Selecte Checkbox
        private void AddCheckBoxWithHeaderPG(DataGridView grid)
        {
            grid.ReadOnly = false;
            grid.AllowUserToAddRows = false;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;


            if (!grid.Columns.Contains("chk"))
            //if (grid == null || grid.Columns.Count == 0)

            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.Name = "chk";
                col.HeaderText = "";
                col.Width = 30;
                col.TrueValue = true;
                col.FalseValue = false;
                col.ThreeState = false;
                grid.Columns.Insert(0, col);
            }
            //return;
            //int chkIndex = grid.Columns["chk"].Index;

            if (!grid.Columns.Contains("chk"))
                return;

            int chkIndex = grid.Columns["chk"].Index;


            grid.CurrentCellDirtyStateChanged -= Grid_CurrentCellDirtyStateChanged;
            grid.CurrentCellDirtyStateChanged += Grid_CurrentCellDirtyStateChanged;

            void Grid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (grid.IsCurrentCellDirty)
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }


            foreach (Control c in grid.Controls)
            {
                if (c is CheckBox && c.Tag?.ToString() == "header")
                {
                    grid.Controls.Remove(c);
                    break;
                }
            }


            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = Color.Transparent;
            headerCheckBox.Tag = "header";
            grid.Controls.Add(headerCheckBox);


            grid.CellPainting -= Grid_CellPainting;
            grid.CellPainting += Grid_CellPainting;

            void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
            {
                if (e.RowIndex == -1 && e.ColumnIndex == chkIndex)
                {
                    System.Drawing.Rectangle rect = grid.GetCellDisplayRectangle(chkIndex, -1, true);
                    headerCheckBox.Location = new Point(
                        rect.X + (rect.Width / 2) - 9,
                        rect.Y + (rect.Height / 2) - 9);
                }
            }


            headerCheckBox.CheckedChanged += (s, e) =>
            {
                if (isHeaderClick) return;

                isHeaderClick = true;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.Cells["chk"].Value = headerCheckBox.Checked;
                }

                isHeaderClick = false;
            };


            grid.CellValueChanged -= Grid_CellValueChanged;
            grid.CellValueChanged += Grid_CellValueChanged;

            void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == chkIndex && !isHeaderClick)
                {
                    int total = 0;
                    int checkedCount = 0;

                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            total++;

                            //bool isChecked = Convert.ToBoolean(row.Cells["chk"].Value);
                            bool isChecked = row.Cells["chk"].Value != null &&
                               Convert.ToBoolean(row.Cells["chk"].Value);

                            if (isChecked)
                                checkedCount++;
                        }
                    }

                    isHeaderClick = true;
                    headerCheckBox.Checked = (total > 0 && total == checkedCount);
                    isHeaderClick = false;
                }
            }
        }


        // Export Data in PDFFile
        private void ExportGridToPDFPG(DataGridView grid, string fileName, DateTime fromDate, DateTime toDate)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("No Record To Export !!!", "Info");
                return;
            }

            bool anyRowChecked = false;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow &&
                    row.Cells["chk"].Value != null &&
                    Convert.ToBoolean(row.Cells["chk"].Value))
                {
                    anyRowChecked = true;
                    break;
                }
            }

            if (!anyRowChecked)
            {
                MessageBox.Show("Please select at least one record to export!", "Info");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";

            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            sfd.FileName = fileName + "_" + timeStamp + ".pdf";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 20f, 30f, 10f);

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    //MessageBox.Show("Writer Created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "TYPE: " + ex.GetType().FullName +
                        "\n\nMESSAGE:\n" + ex.Message +
                        "\n\nINNER:\n" +
                        (ex.InnerException == null
                            ? "NULL"
                            : ex.InnerException.ToString()));
                }
                pdfDoc.Open();

                // HEADER
                iTextSharp.text.Font mainHeaderFont =
    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Font subHeaderFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Font titleFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Font infoFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);

                Paragraph PName = new Paragraph("TICKVIBE", mainHeaderFont);
                PName.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(PName);

                Paragraph CompanyName = new Paragraph(" TCS", subHeaderFont);
                CompanyName.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(CompanyName);


                Paragraph title = new Paragraph(fileName.Replace(".pdf", ""), titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 5f;
                pdfDoc.Add(title);

                string headerText = "Generated  On : " +
                    DateTime.Now.ToString("dd MMM yyyy hh:mm tt");

                Paragraph header = new Paragraph(headerText, infoFont);
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 5f;
                pdfDoc.Add(header);

                string dateRange = "Date Range : " +
                    fromDate.ToString("dd MMM yyyy") + " To " +
                    toDate.ToString("dd MMM yyyy");

                Paragraph datePara = new Paragraph(dateRange);
                datePara.Alignment = Element.ALIGN_CENTER;
                datePara.SpacingAfter = 10f;
                pdfDoc.Add(datePara);

                // COUNT COLUMNS
                int colCount = 0;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column is DataGridViewButtonColumn ||
                        column is DataGridViewCheckBoxColumn ||
                        column.Name == "SrNo" ||
                        column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "chk")
                        continue;

                    colCount++;
                }

                // CREATE TABLE
                PdfPTable pdfTable = new PdfPTable(colCount + 1);
                pdfTable.WidthPercentage = 100;


                int totalColumns = colCount + 1;
                float[] widths = new float[totalColumns];

                for (int i = 0; i < totalColumns; i++)
                {
                    widths[i] = 8f;
                }

                widths[0] = 3f;

                pdfTable.SetWidths(widths);

                // SERIAL HEADER
                PdfPCell srHeader = new PdfPCell(new Phrase("Sr. No"));
                srHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                srHeader.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(srHeader);

                // OTHER HEADERS
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column is DataGridViewButtonColumn ||
                        column is DataGridViewCheckBoxColumn ||
                        column.Name == "SrNo" ||
                        column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "chk")
                        continue;

                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    headerCell.NoWrap = false;
                    headerCell.SetLeading(0, 1.2f);
                    headerCell.Padding = 5;

                    pdfTable.AddCell(headerCell);
                }

                // DATA ROWS
                int serialNo = 1;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool isChecked = row.Cells["chk"].Value != null &&
                                         Convert.ToBoolean(row.Cells["chk"].Value);

                        if (!isChecked)
                            continue;

                        pdfTable.AddCell(serialNo.ToString());
                        serialNo++;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (grid.Columns[cell.ColumnIndex] is DataGridViewButtonColumn ||
                                grid.Columns[cell.ColumnIndex] is DataGridViewCheckBoxColumn ||
                                grid.Columns[cell.ColumnIndex].Name == "SrNo" ||
                                grid.Columns[cell.ColumnIndex].Name == "Action" ||
                                grid.Columns[cell.ColumnIndex].Name == "View" ||
                                grid.Columns[cell.ColumnIndex].Name == "chk")
                                continue;

                            PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? ""));
                            dataCell.NoWrap = false;
                            dataCell.Padding = 5;
                            dataCell.SetLeading(0, 1.2f); // 
                            dataCell.MinimumHeight = 20f;

                            pdfTable.AddCell(dataCell);
                        }
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells["chk"].Value = false;
                    }
                }

                foreach (Control c in grid.Controls)
                {
                    if (c is CheckBox cb && c.Tag?.ToString() == "header")
                    {
                        cb.Checked = false;
                        break;
                    }
                }

                grid.Refresh();
            }

            MessageBox.Show("PDF Downloaded Successfully !!!", "Info");
        }
        private void pcbNTPdf_Click(object sender, EventArgs e)
        {
            try
            {
                ExportGridToPDFPG(
                    grdNewTicket,
                    "NewTickets.pdf",
                    dtpNFromdate.Value,
                    dtpNToDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "ERROR");
            }
        }

        private void pcbCTPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdConfirmTicket, "ConfirmTickets.pdf", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbIPTPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdIPTickets, "InprogressTickets.pdf", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbHTPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdHoldtickets, "Holdtickets.pdf", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbClosedTPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdClosedTickets, "ClosedTicked.pdf", dtpNFromdate.Value, dtpNToDate.Value);
        }


        //Export Data excelfile 
        private void ExportGridToExcelPG(DataGridView grid, string fileName, DateTime fromDate, DateTime toDate)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("No Record To Export !!!", "Info");
                return;
            }

            bool anyRowChecked = false;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow &&
                    row.Cells["chk"].Value != null &&
                    Convert.ToBoolean(row.Cells["chk"].Value))
                {
                    anyRowChecked = true;
                    break;
                }
            }

            if (!anyRowChecked)
            {
                MessageBox.Show("Please select at least one record to export!", "Info");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel (*.xlsx)|*.xlsx";

            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            sfd.FileName = fileName + "_" + timeStamp + ".xlsx";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (XLWorkbook wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Sheet1");

                int totalColumns = 0;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column is DataGridViewButtonColumn ||
                        column is DataGridViewCheckBoxColumn ||
                        column.Name == "SrNo" ||
                        column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "chk")
                        continue;

                    totalColumns++;
                }

                // +1 for Serial No
                totalColumns += 1;

                // TITLE
                ws.Cell(1, 1).Value = fileName;
                ws.Range(1, 1, 1, totalColumns).Merge();
                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Font.FontSize = 14;

                // Downloaded On
                ws.Cell(2, 1).Value = "Generated  On : " + DateTime.Now.ToString("dd MMM yyyy hh:mm tt");
                ws.Range(2, 1, 2, totalColumns).Merge();
                ws.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // Date Range
                ws.Cell(3, 1).Value = "Date Range : " +
                    fromDate.ToString("dd MMM yyyy") + " To " +
                    toDate.ToString("dd MMM yyyy");

                ws.Range(3, 1, 3, totalColumns).Merge();
                ws.Cell(3, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                int colIndex = 1;

                //  SERIAL HEADER
                ws.Cell(5, colIndex).Value = "Sr. No";
                ws.Cell(5, colIndex).Style.Font.Bold = true;
                colIndex++;

                //  COLUMN HEADERS
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column is DataGridViewButtonColumn ||
                        column is DataGridViewCheckBoxColumn ||
                        column.Name == "SrNo" ||
                        column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "chk")
                        continue;

                    ws.Cell(5, colIndex).Value = column.HeaderText;
                    ws.Cell(5, colIndex).Style.Font.Bold = true;
                    ws.Cell(5, colIndex).Style.Fill.BackgroundColor = XLColor.LightGray;

                    colIndex++;
                }

                int rowIndex = 6;
                int serialNo = 1;

                // DATA ROWS
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool isChecked = row.Cells["chk"].Value != null &&
                                         Convert.ToBoolean(row.Cells["chk"].Value);

                        if (!isChecked)
                            continue;

                        colIndex = 1;

                        // Serial No
                        ws.Cell(rowIndex, colIndex).Value = serialNo++;
                        colIndex++;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (grid.Columns[cell.ColumnIndex] is DataGridViewButtonColumn ||
                                grid.Columns[cell.ColumnIndex] is DataGridViewCheckBoxColumn ||
                                grid.Columns[cell.ColumnIndex].Name == "SrNo" ||
                                grid.Columns[cell.ColumnIndex].Name == "Action" ||
                                grid.Columns[cell.ColumnIndex].Name == "View" ||
                                grid.Columns[cell.ColumnIndex].Name == "chk")
                                continue;

                            ws.Cell(rowIndex, colIndex).Value =
                                cell.Value == null ? "" : cell.Value.ToString();

                            colIndex++;
                        }

                        rowIndex++;
                    }
                }

                //  AUTO WIDTH + WRAP
                ws.Columns().AdjustToContents();
                ws.Style.Alignment.WrapText = true;

                wb.SaveAs(sfd.FileName);

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells["chk"].Value = false;
                    }
                }

                foreach (Control c in grid.Controls)
                {
                    if (c is CheckBox cb && c.Tag?.ToString() == "header")
                    {
                        cb.Checked = false;
                        break;
                    }
                }

                grid.Refresh();
            }

            MessageBox.Show("Excel Downloaded Successfully !!!", "Info");
        }
        private void pcbNTXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdNewTicket, "NewTickets", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbCTXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdConfirmTicket, "ConfirmTickets", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbIPTXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdIPTickets, "InprogressTickets", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbHTXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdHoldtickets, "Holdtickets", dtpNFromdate.Value, dtpNToDate.Value);
        }

        private void pcbClosedTXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdClosedTickets, "ClosedTicked", dtpNFromdate.Value, dtpNToDate.Value);
        }

        // Validation gridview
        private void GridviewPG(DataGridView grid)
        {
            string[] cols =
            {
        "SrNo",
        "TicketCode",
        "CompanyName",
        "Priority",
        "Category",
        "Subject",
        "CreatedAt",
        "Status"
    };

            foreach (string col in cols)
            {
                if (grid.Columns.Contains(col))
                {
                    grid.Columns[col].ReadOnly = true;
                }
            }
        }

        // add action column and buttons
        public void AddActionColumnsPG(DataGridView dgv)
        {

            if (!dgv.Columns.Contains("View"))
            {
                DataGridViewImageColumn viewCol = new DataGridViewImageColumn();

                viewCol.Name = "View";
                viewCol.HeaderText = "Action";

                viewCol.Image = System.Drawing.Image.FromFile(
                @"E:\TicketingToolFinalMergeProject\TickVibe\TickVibe\TickVibe\Content\icon\show - Copy.png");

                viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dgv.Columns.Add(viewCol);

                viewCol.Width = 60;
            }

            // Action column always last
            dgv.Columns["View"].DisplayIndex = dgv.Columns.Count - 1;
        }


        private void pnlformNTickets_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabNewTickets_Click(object sender, EventArgs e)
        {

        }

        private void lblEMPCode_Click(object sender, EventArgs e)
        {

        }

        private void lblFromdate_Click(object sender, EventArgs e)
        {

        }

        private void pnlNewfilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpToDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void lblHFromDate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            
            string cat = "";
            string prop = "";
            string sub = "";
          
            frmCreateTicketVN frm = new frmCreateTicketVN(UserCode, filepath, cat, prop, sub);
             
             
            frm.Show();
            
        }

        private void grdNewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow selectedRow = grdNewTicket.Rows[e.RowIndex];

                string TktCode = selectedRow.Cells["TicketCode"].Value.ToString();

                frmViewIPTicketPG frm = new frmViewIPTicketPG(TktCode, UserCode);
                frm.Show();
            }
        }

        private void lblNToDate_Click(object sender, EventArgs e)
        {

        }

        private void SetGridFont(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);

            grid.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular);

            grid.RowsDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular);

            grid.ColumnHeadersHeight = 50;
            grid.RowTemplate.Height = 35;
        }
        private void ApplyProfessionalUI()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(37, 99, 235);
                    btn.ForeColor = Color.White;
                    btn.Font = new DrawingFont("Segoe UI", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }

                if (ctrl is TextBox txt)
                {
                    txt.Font = new DrawingFont("Segoe UI", 10F);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }

                if (ctrl is ComboBox cmb)
                {
                    cmb.Font = new DrawingFont("Segoe UI", 10F);
                    cmb.FlatStyle = FlatStyle.Flat;
                }

                if (ctrl is Label lbl)
                {
                    lbl.Font = new DrawingFont("Segoe UI", 10F);
                    lbl.ForeColor = Color.FromArgb(55, 65, 81);
                }
            }

            StyleGrid(grdNewTicket);
            StyleGrid(grdConfirmTicket);
            StyleGrid(grdIPTickets);
            StyleGrid(grdHoldtickets);
            StyleGrid(grdClosedTickets);
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.RowHeadersVisible = false;

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(37, 99, 235);

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            grid.ColumnHeadersDefaultCellStyle.Font =
               new DrawingFont("Segoe UI", 10F, FontStyle.Bold);

            grid.ColumnHeadersHeight = 45;

            grid.DefaultCellStyle.Font =
                new DrawingFont("Segoe UI", 10F);

            grid.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            grid.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            grid.RowTemplate.Height = 35;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void siticonePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlNewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }

        private void tabCTickets_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlConfirmFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblCCreateDate_Click(object sender, EventArgs e)
        {

        }

        private void lblCTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void tabIPTickets_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlIPFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblToDate_Click(object sender, EventArgs e)
        {

        }

        private void lblIPPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblIPCDate_Click(object sender, EventArgs e)
        {

        }

        private void lblIPTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void tabHoldTickets_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHoldFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHToDate_Click(object sender, EventArgs e)
        {

        }

        private void lblHTPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblHTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void tabClosedTickets_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClosedFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClosedToDate_Click(object sender, EventArgs e)
        {

        }

        private void lblclosedPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblClosedFromDate_Click(object sender, EventArgs e)
        {

        }

        private void lblClosedTCode_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}