using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siticone.UI.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClosedXML.Excel;

using TickVibeLib;

using System.Windows.Forms;

namespace TickVibe
{
    public partial class frmGridViewStatusMB : Form
    {
        public string ViewType { get; set; }

        private Dictionary<DataGridView, CheckBox> headerBoxes
   = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;

        public string agentcode { get; set; }
        public string tlcode { get; set; }
        public string statusname { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public int categoryid { get; set; }

        public frmGridViewStatusMB()
        {
            InitializeComponent();

        }
        public frmGridViewStatusMB(string sname, string ac, string tlcode1, DateTime fd1, DateTime td1, int cid)
        {
            InitializeComponent();
            statusname = sname;
            agentcode = ac;
            tlcode = tlcode1;
            fromdate = fd1;
            todate = td1;
            categoryid = cid;
        }




        private void frmGridViewStatusMB_Load(object sender, EventArgs e)
        {
            dtpFromDate.Visible = true;
            dtpToDate.Visible = true;
            lblFromDate.Visible = true;
            lblToDate.Visible = true;




            cmbFilterDaywise.Items.Add("Daywise");
            cmbFilterDaywise.Items.Add("Monthwise");
            cmbFilterDaywise.Items.Add("Yearwise");

            // ADD these lines after adding items:
            dtpFromDate.Value = fromdate;
            dtpToDate.Value = todate;

            cmbFilterDaywise.SelectedIndexChanged += cmbFilterDaywise_SelectedIndexChanged;
            cmbFilterDaywise.SelectedIndex = 2;

           
            // Add status filter options
            cmbStatusNameAll.Items.Clear();
            cmbStatusNameAll.Items.Add("All Tickets");
            cmbStatusNameAll.Items.Add("Open & Closed Tickets");
            cmbStatusNameAll.Items.Add("New");
            cmbStatusNameAll.Items.Add("InProgress");
            cmbStatusNameAll.Items.Add("Open");
            cmbStatusNameAll.Items.Add("DueSoon");
            cmbStatusNameAll.Items.Add("OverDue");
            cmbStatusNameAll.Items.Add("Hold");
            cmbStatusNameAll.Items.Add("Closed");
            cmbStatusNameAll.Items.Add("Escalated");
            cmbStatusNameAll.Items.Add("Resolved");
            cmbStatusNameAll.Items.Add("Accepted");
            cmbStatusNameAll.Items.Add("Assign");
            cmbStatusNameAll.Items.Add("Reassign");

            grdShowChartStatus1.ColumnHeadersHeight = 40;

            // Set the selected item in combo box
            if (!string.IsNullOrEmpty(statusname))
            {
                if (cmbStatusNameAll.Items.Contains(statusname))
                    cmbStatusNameAll.SelectedItem = statusname;
                else
                    cmbStatusNameAll.SelectedIndex = 0; // Default to "All Tickets"
            }
            else
            {
                cmbStatusNameAll.SelectedIndex = 0;
            }

            LoadGridData(statusname);


            if (this.Tag != null && this.Tag.ToString() == "GraphicalView")
            {
                cmbStatusNameAll.Visible = false; // Hide the combobox for graphical view
            }
            else
            {
                cmbStatusNameAll.Visible = true; // Show on first form
            }
        }


        private void grdShowChartStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }









        // Export Data in PDFFile
     

        private void pbPdf_Click(object sender, EventArgs e)
        {

        }

        private void pbPdf_MouseClick(object sender, MouseEventArgs e)
        {
            ExportGridToPDFMB(grdShowChartStatus1, "GridViewStatus.pdf", dtpFromDate.Value, dtpToDate.Value);
        }





        //   add Selecte Checkbox
        private void AddCheckBoxWithHeaderMB(DataGridView grid)
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

        private void pcExcel_Click(object sender, EventArgs e)
        {

        }

        private void pcExcel_MouseClick(object sender, MouseEventArgs e)
        {
            ExportGridToExcelMB(grdShowChartStatus1, "GridViewStatus", dtpFromDate.Value, dtpToDate.Value);
        }




        //Export Data excelfile 
        // Export Data in PDFFile
        private void ExportGridToPDFMB(DataGridView grid, string fileName, DateTime fromDate, DateTime toDate)
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
                PdfWriter.GetInstance(pdfDoc, stream);
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

                //string dateRange = "Date Range : " +
                //    fromDate.ToString("dd MMM yyyy") + " To " +
                //    toDate.ToString("dd MMM yyyy");

                //Paragraph datePara = new Paragraph(dateRange);
                //datePara.Alignment = Element.ALIGN_CENTER;
                //datePara.SpacingAfter = 10f;
                //pdfDoc.Add(datePara);

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
                            dataCell.SetLeading(0, 1.2f); // t
                            dataCell.MinimumHeight = 20f;

                            pdfTable.AddCell(dataCell);
                        }
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
            }

            MessageBox.Show("PDF Downloaded Successfully !!!", "Info");
        }

        //Export Data excelfile 
        private void ExportGridToExcelMB(DataGridView grid, string fileName, DateTime fromDate, DateTime toDate)
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
                ws.Cell(2, 1).Value = "Downloaded On : " + DateTime.Now.ToString("dd MMM yyyy hh:mm tt");
                ws.Range(2, 1, 2, totalColumns).Merge();
                ws.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // Date Range
                //ws.Cell(3, 1).Value = "Date Range : " +
                //fromDate.ToString("dd MMM yyyy") + " To " +
                //toDate.ToString("dd MMM yyyy");

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


        private void pbRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            LoadGridData(statusname);
            txtSearchBox.Clear();

        }



        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBox.Text))
            {
                (grdShowChartStatus1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }
            else
            {
                DataTable dt = grdShowChartStatus1.DataSource as DataTable;
                if (dt != null)
                {
                    string searchText = txtSearchBox.Text.Replace("'", "''");
                    dt.DefaultView.RowFilter = string.Format(
                        "Convert([Ticket Code],'System.String') LIKE '%{0}%' OR " +
                        "[Status] LIKE '%{0}%' OR " +
                        "[Priority] LIKE '%{0}%' OR " +
                        "[Subject] LIKE '%{0}%' OR " +
                        "[Description] LIKE '%{0}%' OR " +
                        "[Ticket Raised by] LIKE '%{0}%' OR " +
                        "[Ticket Assigned By] LIKE '%{0}%' OR " +
                        "[Assigned to] LIKE '%{0}%' "
                      ,
                        searchText);
                }
            }

            }

        


        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterMain_Click(object sender, EventArgs e)
        {
            DateTime fd;
            DateTime td;

            if (cmbFilterDaywise.Text == "Daywise")
            {
                fd = dtpFromDate.Value.Date;
                td = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);
            }
            else if (cmbFilterDaywise.Text == "Monthwise")
            {
                fd = new DateTime(
                    dtpFromDate.Value.Year,
                    dtpFromDate.Value.Month,
                    1);

                int lastDay =
                    DateTime.DaysInMonth(
                        dtpToDate.Value.Year,
                        dtpToDate.Value.Month);

                td = new DateTime(
                    dtpToDate.Value.Year,
                    dtpToDate.Value.Month,
                    lastDay,
                    23,
                    59,
                    59);
            }
            else
            {
                fd = new DateTime(
                    dtpFromDate.Value.Year,
                    1,
                    1);

                td = new DateTime(
                    dtpToDate.Value.Year,
                    12,
                    31,
                    23,
                    59,
                    59);
            }

            fromdate = fd;
            todate = td;

            LoadGridData(cmbStatusNameAll.Text);
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtSearchBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbStatusNameAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusname = cmbStatusNameAll.Text;
            LoadGridData(statusname);
        }




        private void LoadGridData(string selectedStatus)
        {
            //clsTeamLeader obj = new clsTeamLeader();
            //obj.empcode = agentcode;
            //obj.tlempcode = tlcode;
            //obj.fromdate = fromdate;
            //obj.todate = todate;
            //obj.categoryid = categoryid;

            //DataTable dt;

            //if (selectedStatus == "All Tickets")
            //{
            //    dt = obj.ShowAllAgentTicketsMB();
            //}
            //else if (selectedStatus == "Open & Closed Tickets")
            //{
            //    dt = obj.ShowOpenAndClosedTicketsMB();
            //}
            //else
            //{
            //    obj.statusname = selectedStatus;
            //    dt = obj.ShowTabularViewAgentStatuswiseMB();
            //}

            clsTeamLeader obj = new clsTeamLeader();
            obj.empcode = agentcode;
            obj.tlempcode = tlcode;
            obj.fromdate = dtpFromDate.Value;
            obj.todate = dtpToDate.Value;
            obj.categoryid = categoryid;

            DataTable dt;

            if (selectedStatus == "All Tickets")
            {
                dt = obj.ShowAllAgentTicketsMB();
            }
            else if (selectedStatus == "Open & Closed Tickets")
            {
                dt = obj.ShowOpenAndClosedTicketsMB();
            }
            else
            {
                obj.statusname = selectedStatus;

                // If opened from chart
                if (this.Tag != null && this.Tag.ToString() == "GraphicalView")
                {
                    dt = obj.ShowTabularViewAgentStatuswise2MB();
                }
                else
                {
                    dt = obj.ShowTabularViewAgentStatuswiseMB();
                }
            }
            if (dt != null)
            {
                // ✅ Remove old checkbox column (IMPORTANT)
                if (grdShowChartStatus1.Columns.Contains("chk"))
                {
                    grdShowChartStatus1.Columns.Remove("chk");
                }

                if (!dt.Columns.Contains("SrNo"))
                {
                    DataColumn srcol = new DataColumn("SrNo", typeof(int));
                    dt.Columns.Add(srcol);
                    srcol.SetOrdinal(0);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["SrNo"] = i + 1;
                }

                grdShowChartStatus1.DataSource = dt;
                //grdShowChartStatus1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Set auto-size mode to fit content
               // grdShowChartStatus1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Auto-resize columns
              //  grdShowChartStatus1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                AddCheckBoxWithHeaderMB(grdShowChartStatus1);
            }
        
    
    }

        private void siticonePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdShowChartStatus1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilterDaywise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterDaywise.Text == "Daywise")
            {
                dtpFromDate.CustomFormat = "dd/MM/yyyy";
                dtpToDate.CustomFormat = "dd/MM/yyyy";
            }
            else if (cmbFilterDaywise.Text == "Monthwise")
            {
                dtpFromDate.CustomFormat = "MM/yyyy";
                dtpToDate.CustomFormat = "MM/yyyy";
            }
            else
            {
                dtpFromDate.CustomFormat = "yyyy";
                dtpToDate.CustomFormat = "yyyy";
            }

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                dtpToDate.Value = dtpFromDate.Value;
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                dtpToDate.Value = dtpFromDate.Value;
            }

        }

        private void lblFilter_Click(object sender, EventArgs e)
        {

        }

        private void lblFromDate_Click(object sender, EventArgs e)
        {

        }

        private void lblToDate_Click(object sender, EventArgs e)
        {

        }

        private void lblAgentReportGraphicalView_Click(object sender, EventArgs e)
        {

        }
    }
}
