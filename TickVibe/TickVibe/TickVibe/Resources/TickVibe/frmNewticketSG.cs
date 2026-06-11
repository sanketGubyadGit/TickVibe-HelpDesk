using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.X509;
using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;
using PdfDocument = iTextSharp.text.Document;
using PdfParagraph = iTextSharp.text.Paragraph;
using WinCheckBox = System.Windows.Forms.CheckBox;
using WinControl = System.Windows.Forms.Control;
using WordControl = DocumentFormat.OpenXml.Wordprocessing.Control;
namespace TickVibe

{
    public partial class frmNewticketSG : Form

    {
        private Dictionary<DataGridView, System.Windows.Forms.CheckBox > headerBoxes
   = new Dictionary<DataGridView, System.Windows.Forms.CheckBox >();

        private bool isHeaderClick = false;
        public string UserCode { get; set; }
       public int hoverIndex = -1;
       
        public frmNewticketSG(string UCode)
        {
            InitializeComponent();
            UserCode = UCode;
            
        }



        private void frmNewticketSG_Load(object sender, EventArgs e)
        {
            LoadAllTickets();





            //  NewTicketAC.DrawMode = TabDrawMode.OwnerDrawFixed;
            // NewTicketAC.DrawItem += NewTicketAC_DrawItem;
            // NewTicketAC.MouseMove += NewTicketAC_MouseMove;
            NewTicketAC.DrawMode = TabDrawMode.OwnerDrawFixed;

            NewTicketAC.DrawItem += (s, ea) =>
            {
                bool isHover = (ea.Index == hoverIndex);

                System.Drawing. Color textColor = isHover ? System.Drawing.Color.Blue : System.Drawing.Color.Black;

                string text = NewTicketAC.TabPages[ea.Index].Text;

                TextRenderer.DrawText(
                    ea.Graphics,
                    text,
                    NewTicketAC.Font,
                    ea.Bounds,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            };

            NewTicketAC.MouseMove += (s, ea) =>
            {
                for (int i = 0; i < NewTicketAC.TabCount; i++)
                {
                    if (NewTicketAC.GetTabRect(i).Contains(ea.Location))
                    {
                        hoverIndex = i;
                        NewTicketAC.Invalidate();
                        return;
                    }
                }

                hoverIndex = -1;
                NewTicketAC.Invalidate();
            };
        


            grdNewTicket.CurrentCellDirtyStateChanged += (s, ev) =>
            {
                if (grdNewTicket.IsCurrentCellDirty)
                {
                    grdNewTicket.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            grdNewTicket.CellContentClick += (s, ev) =>
            {
                {
                    grdNewTicket.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
            clsTeamLeader TlPrioritySG = new clsTeamLeader(1);
            DataTable dt1 = new DataTable();
            dt1 = TlPrioritySG.PrioritySG();

            cmbbxpPriority.DisplayMember = "PriorityName";
            cmbbxpPriority.ValueMember = "PriorityId";
      

            foreach (DataGridViewRow row in grdNewTicket.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["chk"].Value);

                if (isChecked)
                {
                    string id = row.Cells["TktCode"].Value.ToString();
                    MessageBox.Show("Selected: " + id);
                }
            }
            //grdNewTicket.Columns.Insert(0, chk);

            cmbbxpPriority.DataSource = dt1;
            grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            grdNewTicket.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grdNewTicket.RowTemplate.Height = 38;
            grdNewTicket.ReadOnly = true;
            grdNewTicket.AllowUserToAddRows = false;
            //grdNewTicket.RowsDefaultCellStyle.BackColor = Color.White;
            //grdNewTicket.Columns[0].HeaderText = "Ticket Code";
           // grdNewTicket.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNewTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdNewTicket.Show();
            cmbbxpPriority.Show();




            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Action";
            //btn.Name = "Assign";
            //btn.Text = "Assign";
            //btn.UseColumnTextForButtonValue = true;
            //grdNewTicket.Columns.Add(btn);
        }
        private void LoadClosedTDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FClosedDatePG(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, UserCode);

            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }
            grdNewTicket.DataSource = dt;
        }
        private void LoadHoldTDatePG()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FHDatePG(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, UserCode);


            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }
            grdNewTicket.DataSource = dt;
        }


        private void cmbbxpPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdNewTicket.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"Priority='{cmbbxpPriority.Text}'";
            }





        }

        private void lblFromdate_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {



          //  string ecode = txtTkCode.Text;
            int ID = 0;

            if (cmbbxpPriority.SelectedValue != null)
            {
                ID = Convert.ToInt32(cmbbxpPriority.SelectedValue);
            }
            //clsTeamLeader objFilter = new clsTeamLeader(ID, fromDate , toDate,);
            //objFilter.Name = txtTkCode.Text;
            // DataTable dt = new DataTable();
            //dt = objFilter.FilterSG();
            //grdNewTicket.DataSource = dt;
            //grdNewTicket.Show();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
           

    

            grdNewTicket.AutoGenerateColumns = false;
            try
            {
                clsTeamLeader grdcl = new clsTeamLeader();
                DataTable dt9 = grdcl.FClosedTPG();
                grdNewTicket.DataSource = dt9;
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                TxtSearch.Clear();
                cmbbxpPriority.SelectedIndex = -1;
              //  cmbbxClosedTCode.SelectedIndex = -1;
              //  dtpCloseFromDate.Value = new DateTime(2026, 01, 01);
               // dtpcloseToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
            LoadAllTickets();

        }




        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }
            else
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode LIKE '%{0}%'  OR Priority LIKE '%{0}%'", TxtSearch.Text);

            }
        }

        private void pbsearchicon_Click(object sender, EventArgs e)
        {

        }

        private void grdNewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "Assign")
            {
                string id = grdNewTicket.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader obj1 = new clsTeamLeader(obj);
                obj1.TicketCode = id;
                obj1.Id = 10;
                obj1.closeRejectAcceptSG();
                frmTransferToTl viewobj = new frmTransferToTl(id, UserCode);
                viewobj.Show();
                viewobj.FormBorderStyle = FormBorderStyle.None;
                
                // grdNewTicket.Columns["Action"].Index)
                if (e.RowIndex >= 0 && grdNewTicket.Columns.Contains("Assign") &&
   e.ColumnIndex == grdNewTicket.Columns["Assign"].Index)
                {
                    grdNewTicket.Rows.RemoveAt(e.RowIndex);
                }
            }



            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "EsclateTickets")
            {
                DialogResult result = MessageBox.Show(
  "Are you sure you want to EsclateTickets this ticket? This action cannot be undone.",
  "EsclateTickets",
  MessageBoxButtons.YesNo,
  MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string id = grdNewTicket.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                    clsTeamLeader objeEsclate = new clsTeamLeader(id);
                    objeEsclate.EsclateSG();
                    if (e.RowIndex >= 0 && grdNewTicket.Columns.Contains("EsclateTickets") &&
      e.ColumnIndex == grdNewTicket.Columns["EsclateTickets"].Index)
                    {
                        grdNewTicket.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "close")
            {
                DialogResult result = MessageBox.Show(
    "Are you sure you want to close this ticket? This action cannot be undone.",
    "close Ticket",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string id = grdNewTicket.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                    //MessageBox.Show(id);
                    clsTeamLeader obj = new clsTeamLeader();
                    clsTeamLeader objeEsclate = new clsTeamLeader();
                    objeEsclate.Id = 7;
                    objeEsclate.TicketCode = id;
                    objeEsclate.closeRejectAcceptSG();
                    if (e.RowIndex >= 0 && grdNewTicket.Columns.Contains("close") &&
e.ColumnIndex == grdNewTicket.Columns["close"].Index)
                    {
                        grdNewTicket.Rows.RemoveAt(e.RowIndex);
                    }
                }

             
                
            }
            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "Resume")
            {
                DialogResult result = MessageBox.Show(
    "Are you sure you want to Resume this ticket? This action cannot be undone.",
    "Resume Ticket",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string id = grdNewTicket.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                    //MessageBox.Show(id);
                    clsTeamLeader obj = new clsTeamLeader();
                    clsTeamLeader objeEsclate = new clsTeamLeader();
                    objeEsclate.Id = 1;
                    objeEsclate.TicketCode = id;
                    objeEsclate.closeRejectAcceptSG();
                    if (e.RowIndex >= 0 && grdNewTicket.Columns.Contains("Resume") &&
e.ColumnIndex == grdNewTicket.Columns["Resume"].Index)
                    {
                        grdNewTicket.Rows.RemoveAt(e.RowIndex);
                    }
                }



            }
            if (e.RowIndex >= 0 && grdNewTicket.Columns[e.ColumnIndex].Name == "Reassign")
            {
                DialogResult result = MessageBox.Show(
  "Are you sure you want to Reassign this ticket? This action cannot be undone.",
  "Reassign Ticket",
  MessageBoxButtons.YesNo,
  MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string id = grdNewTicket.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                    
                    Reassign1SG objeReassign = new Reassign1SG(UserCode, id);
                    objeReassign.Show();
                    objeReassign.FormBorderStyle = FormBorderStyle.None;
                    if (e.RowIndex >= 0 && grdNewTicket.Columns.Contains("Reassign") &&
     e.ColumnIndex == grdNewTicket.Columns["Reassign"].Index)
                    {
                        grdNewTicket.Rows.RemoveAt(e.RowIndex);
                    }
                }
                

            }
           
        }
      


        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           // ExportGridToPDFPG(grdNewTicket, "NewTickets.pdf");
            ExportGridToPDFPG(grdNewTicket, "Report", DateTime.Now, DateTime.Now);
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

       
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
                iTextSharp.text.Document doc = new iTextSharp.text.Document();                 
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                // HEADER

                iTextSharp.text.Paragraph PName = new iTextSharp.text.Paragraph("TICKVIBE");
                PName.Alignment = Element.ALIGN_LEFT;
                doc.Add(PName);

                iTextSharp.text.Paragraph PNames = new iTextSharp.text.Paragraph("TICKVIBE");
                PNames.Alignment = Element.ALIGN_CENTER;
                PNames.SpacingAfter = 5f;
                doc.Add(PNames);

                string headerText = "Downloaded On : " +
                    DateTime.Now.ToString("dd MMM yyyy hh:mm tt");

                iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph(headerText);
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 5f;
                doc.Add(header);
                string dateRange = "Date Range : " +
                    fromDate.ToString("dd MMM yyyy") + " To " +
                    toDate.ToString("dd MMM yyyy");

                iTextSharp.text.Paragraph datePara = new iTextSharp.text.Paragraph(dateRange);
                datePara.Alignment = Element.ALIGN_CENTER;
                datePara.SpacingAfter = 10f;
                doc.Add(datePara);
                // COUNT COLUMNS (skip unwanted)
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

                // +1 for Serial No
                PdfPTable pdfTable = new PdfPTable(colCount + 1);
                pdfTable.WidthPercentage = 100;

                // SERIAL HEADER
                PdfPCell srHeader = new PdfPCell(new Phrase("Sr. No"));
                srHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                srHeader.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(srHeader);

                pdfTable.WidthPercentage = 100;

                // Example widths (adjust as per your columns)
                int totalColumns = colCount + 1; // including Sr. No

                float[] widths = new float[totalColumns];

                for (int i = 0; i < totalColumns; i++)
                {
                    widths[i] = 3f; // default width
                }

                // Make first column (Sr No) smaller
                widths[0] = 2f;

                pdfTable.SetWidths(widths);

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

                        // SERIAL NUMBER
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
                            pdfTable.AddCell(dataCell);
                        }
                    }
                }

                doc.Add(pdfTable);
                doc.Close();
            }

            MessageBox.Show("PDF Downloaded Successfully !!!", "Info");
        }
        private void LoadAllTickets()
        {
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader TlNewTicketSG = new clsTeamLeader(obj);

            TlNewTicketSG.UserCode = UserCode;

            DataTable dt = TlNewTicketSG.AllTicketSG();
            grdNewTicket.DataSource = dt;
            AddCheckBoxWithHeaderPG(grdNewTicket);



            // remove old buttons
            string[] cols = { "Assign", "EsclateTickets", "Reassign", "close", "Resume" };
            foreach (string col in cols)
            {
                if (grdNewTicket.Columns.Contains(col))
                    grdNewTicket.Columns.Remove(col);
            }

           

            grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNewTicket.ColumnHeadersHeight = 40;
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)

        {
            

            if (NewTicketAC.SelectedTab == NTICKET)
            {
                label1.Text = "New Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader TlNewTicketSG = new clsTeamLeader(obj);
                TlNewTicketSG.Id = 1;
                TlNewTicketSG.UserCode = UserCode;
                
                DataTable dt = new DataTable();
                
                dt = TlNewTicketSG.NewTicketSG();

              
                AddCheckBoxWithHeaderPG(grdNewTicket);
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                grdNewTicket.DataSource = dt;
                btn.HeaderText = "Assign";
                btn.Name = "Assign";
                btn.Text = "Assign";
                btn.UseColumnTextForButtonValue = true;
                grdNewTicket.Columns.Add(btn);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;


            }
            if (NewTicketAC.SelectedTab == AssignTicket)
            {
                label1.Text = "Assign Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader AssignSG = new clsTeamLeader(obj);
                AssignSG.Id = 11;
                AssignSG.UserCode = UserCode;

                DataTable dt = new DataTable();
              
                dt = AssignSG.NewTicketSG();
                AddCheckBoxWithHeaderPG(grdNewTicket);

                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                grdNewTicket.DataSource = dt;
                AddCheckBoxWithHeaderPG(grdNewTicket);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            }
            if (NewTicketAC.SelectedTab == DueSoonTickets)
            {
                label1.Text = "DueSoon Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader AssignSG = new clsTeamLeader();
                AssignSG.Id = 4;
                AssignSG.UserCode = UserCode;

                DataTable dt = new DataTable();
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                dt = AssignSG.NewTicketSG();
                AddCheckBoxWithHeaderPG(grdNewTicket);

                grdNewTicket.DataSource = dt;
                AddCheckBoxWithHeaderPG(grdNewTicket);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            }
            if (NewTicketAC.SelectedTab == OverDou)
            {
                label1.Text = "OverDue Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader TlNewTicketSG = new clsTeamLeader(obj);
                TlNewTicketSG.Id = 5;
                TlNewTicketSG.UserCode = UserCode;
                DataTable dt = new DataTable();
                dt = TlNewTicketSG.NewTicketSG();
            
                AddCheckBoxWithHeaderPG(grdNewTicket);
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                grdNewTicket.DataSource = dt;
                btn.HeaderText = "Esclate Tickets";
                btn.Name = "EsclateTickets";
                btn.Text = "EsclateTickets";
                btn.UseColumnTextForButtonValue = true;
                grdNewTicket.Columns.Add(btn);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            }
            if (NewTicketAC.SelectedTab == HoldTicket)
            {

                label1.Text = "Hold Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader AssignSG = new clsTeamLeader(obj);
                AssignSG.Id = 6;
                AssignSG.UserCode = UserCode;
                DataTable dt = new DataTable();
                dt = AssignSG.NewTicketSG();
              
                AddCheckBoxWithHeaderPG(grdNewTicket);

                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                grdNewTicket.DataSource = dt;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Resume";
                btn.Name = "Resume";
                btn.Text = "Resume";
                btn.UseColumnTextForButtonValue = true;
                grdNewTicket.Columns.Add(btn);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;

            }
            if (NewTicketAC.SelectedTab == tabPage5)
            {

                label1.Text = "Escalated Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader AssignSG = new clsTeamLeader(obj);
                AssignSG.Id = 8;
                AssignSG.UserCode = UserCode;
                DataTable dt = new DataTable();
             
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                dt = AssignSG.NewTicketSG();
                AddCheckBoxWithHeaderPG(grdNewTicket);
                grdNewTicket.DataSource = dt;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Reassign";
                btn.Name = "Reassign";
                btn.Text = "Reassign";
                btn.UseColumnTextForButtonValue = true;
                grdNewTicket.Columns.Add(btn);
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            }
            if (NewTicketAC.SelectedTab == Resolved)
            {
                label1.Text = "Resolved Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader AssignSG = new clsTeamLeader(obj);
                AssignSG.Id = 9;
                AssignSG.UserCode = UserCode;
                DataTable dt = new DataTable();
                dt = AssignSG.NewTicketSG();
                AddCheckBoxWithHeaderPG(grdNewTicket);
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                 grdNewTicket.DataSource = dt;
                 DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "closed Tickets";
                btn.Name = "close";
                btn.Text = "close";
                grdNewTicket.Columns.Add(btn);
                btn.UseColumnTextForButtonValue = true;
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
            }
            if (NewTicketAC.SelectedTab == CloseTicket)
            {
                label1.Text = "Closed Tickets";
                NewTicketAC.SelectedIndex = 0;
                clsTeamLeader AssignSG = new clsTeamLeader();
                DataTable dt = new DataTable();
                AssignSG.Id = 7;
                AssignSG.UserCode = UserCode;
                dt = AssignSG.NewTicketSG();
                AddCheckBoxWithHeaderPG(grdNewTicket);
                if (grdNewTicket.Columns.Contains("Assign"))
                {
                    grdNewTicket.Columns.Remove("Assign");
                }
                if (grdNewTicket.Columns.Contains("EsclateTickets"))
                {
                    grdNewTicket.Columns.Remove("EsclateTickets");
                }
                if (grdNewTicket.Columns.Contains("Reassign"))
                {
                    grdNewTicket.Columns.Remove("Reassign");
                }
                if (grdNewTicket.Columns.Contains("close"))
                {
                    grdNewTicket.Columns.Remove("close");
                }
                if (grdNewTicket.Columns.Contains("Resume"))
                {
                    grdNewTicket.Columns.Remove("Resume");
                }
                grdNewTicket.DataSource = dt;
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNewTicket.ColumnHeadersHeight = 40;
                grdNewTicket.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void NewTicket_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1cker1_ValueChanged(object sender, EventArgs e)
        {
           // LoadHoldTDatePG();
        }

        private void dateTimePicker1cker2_ValueChanged(object sender, EventArgs e)
        {
            LoadHoldTDatePG();
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdNewTicket, "Report", DateTime.Now, DateTime.Now);
        }
        private void NewTicketAC_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = NewTicketAC.TabPages[e.Index];
            System.Drawing.Rectangle tabRect = NewTicketAC.GetTabRect(e.Index);

            bool isSelected = (NewTicketAC.SelectedIndex == e.Index);

            System.Drawing.Color backColor;

            if (isSelected)
                backColor = System.Drawing.Color.FromArgb(0, 122, 204);   // Active tab
            else if (e.Index == hoverIndex)
                backColor = System.Drawing.Color.FromArgb(60, 60, 60);    // Hover
            else
                backColor = System.Drawing.Color.FromArgb(40, 40, 40);    // Normal

            using (Brush b = new SolidBrush(backColor))
            {
                g.FillRectangle(b, tabRect);
            }

            System.Drawing.Color textColor = isSelected ? System.Drawing.Color.White : System.Drawing.Color.LightGray;

            TextRenderer.DrawText(
                g,
                tabPage.Text,
                this.Font,
                tabRect,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
        private void NewTicketAC_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < NewTicketAC.TabPages.Count; i++)
            {
                if (NewTicketAC.GetTabRect(i).Contains(e.Location))
                {
                    hoverIndex = i;
                    NewTicketAC.Invalidate();
                    return;
                }
            }

            hoverIndex = -1;
            NewTicketAC.Invalidate();
        }
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


            foreach (System.Windows.Forms.Control c in grid.Controls)
            {
                if (c is System.Windows.Forms.CheckBox && c.Tag?.ToString() == "header")
                {
                    grid.Controls.Remove(c);
                    break;
                }
            }


            System.Windows.Forms.CheckBox headerCheckBox = new System.Windows.Forms.CheckBox();
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = System.Drawing.Color.Transparent;
            headerCheckBox.Tag = "header";
            grid.Controls.Add(headerCheckBox);


            grid.CellPainting -= Grid_CellPainting;
            grid.CellPainting += Grid_CellPainting;

            void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
            {
                if (e.RowIndex == -1 && e.ColumnIndex == chkIndex)
                {
                    System.Drawing.Rectangle rect = grid.GetCellDisplayRectangle(chkIndex, -1, true);
                    headerCheckBox.Location = new System.Drawing.Point(
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
            }

            MessageBox.Show("Excel Downloaded Successfully !!!", "Info");
        }
        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdNewTicket, "NewTickets", dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void NTICKET_Click(object sender, EventArgs e)
        {

        }

        private void pcbNTRefresh_Click(object sender, EventArgs e)
        {
            if (grdNewTicket.Columns.Contains("SrNo"))
            {
                grdNewTicket.Columns.Remove("SrNo");
            }


            grdNewTicket.AutoGenerateColumns = false;
            try
            {
                clsTeamLeader grdcl = new clsTeamLeader();
                DataTable dt9 = grdcl.FClosedTPG();
                grdNewTicket.DataSource = dt9;
                grdNewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                TxtSearch.Clear();
                cmbbxpPriority.SelectedIndex = -1;
                //  cmbbxClosedTCode.SelectedIndex = -1;
                //  dtpCloseFromDate.Value = new DateTime(2026, 01, 01);
                // dtpcloseToDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
            LoadAllTickets();

        }

        private void siticoneCirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdNewTicket, "Report", DateTime.Now, DateTime.Now);
        }

        private void siticoneCirclePictureBox2_Click_1(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdNewTicket, "NewTickets", dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            //  string ecode = txtTkCode.Text;
            int ID = 0;

            if (cmbbxpPriority.SelectedValue != null)
            {
                ID = Convert.ToInt32(cmbbxpPriority.SelectedValue);
            }
            //clsTeamLeader objFilter = new clsTeamLeader(ID, fromDate , toDate,);
            //objFilter.Name = txtTkCode.Text;
            // DataTable dt = new DataTable();
            //dt = objFilter.FilterSG();
            //grdNewTicket.DataSource = dt;
            //grdNewTicket.Show();

        }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }
            else
            {
                (grdNewTicket.DataSource as DataTable).DefaultView.RowFilter = string.Format("TicketCode LIKE '%{0}%'  OR Priority LIKE '%{0}%'", TxtSearch.Text);

            }
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = grdNewTicket.DataSource as DataTable;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"Priority='{cmbbxpPriority.Text}'";
            }
        }

        private void cmbbxNTPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadHoldTDatePG();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
        }
    


