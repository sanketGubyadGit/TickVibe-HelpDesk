//using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using TickVibeLib;
using DrawingFont = System.Drawing.Font;
using PdfFont = iTextSharp.text.Font;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TickVibe
{

    public partial class frmLstView : Form
    {
        private Dictionary<DataGridView, CheckBox> headerBoxes
      = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public string ChartMode;
        public String UserCode { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ViewType { get; set; }
        public string PageTitle { get; set; }
        public frmLstView(string usercode,
                    int statusid,
                    DateTime fromdate,
                    DateTime todate,
                    string viewType)
        {
            InitializeComponent();

            UserCode = usercode;
            StatusId = statusid;
            FromDate = fromdate;
            ToDate = todate;
            ViewType = viewType;
        }
        private bool isFormLoaded = false;
        private void frmLstView_Load(object sender, EventArgs e)
        {
            if (StatusId == 0) // Total Tickets
            {
                cmbbxStatus.Visible = true;
                siticoneLabel1.Visible = true;
            }
            else
            {
                cmbbxStatus.Visible = false;
                siticoneLabel1.Visible = false;
            }
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FetchStatusSA();

            cmbbxStatus.DisplayMember = "StatusName";
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DataSource = dt;

            // Select current status from card/chart click
            cmbbxStatus.SelectedValue = StatusId;

            dtpFromDate.Value = FromDate;
            dtpToDate.Value = ToDate;

            lblCard.Text = PageTitle;

            LoadTicketData();

            isFormLoaded = true;
        }
        private void LoadTicketData()
        {
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("From Date cannot be greater than To Date.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            clsTeamLeader obj = new clsTeamLeader();
            obj.UserCode = UserCode;
            if (cmbbxStatus.SelectedValue != null)
            {
                obj.StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue);
            }
            else
            {
                obj.StatusId = StatusId;
            }
            obj.FromDate = dtpFromDate.Value.Date;
            obj.ToDate = dtpToDate.Value.Date;

            clsTeamLeader obj1 = new clsTeamLeader(obj);

            DataTable dt = new DataTable();

            if (ViewType == "Chart")
                dt = obj1.ColumnChartClick();
            else if (ViewType == "Card")
                dt = obj1.CardClickSA();

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

            grdTicketsShow.DataSource = dt;

            if (!grdTicketsShow.Columns.Contains("chk"))
                AddCheckBoxWithHeaderSA(grdTicketsShow);

            grdTicketsShow.AllowUserToAddRows = false;
        }

        // Export Data in PDFFile
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
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                // HEADER
                iTextSharp.text.Font mainHeaderFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Font subHeaderFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Font titleFont =
                    new PdfFont(PdfFont.FontFamily.HELVETICA, 12, PdfFont.BOLD);

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

                MessageBox.Show("PDF Downloaded Successfully !!!", "Info");
            }
        }
        //Export Data excelfile 
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
        private void pcbPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdTicketsShow, "Tickets.pdf",FromDate,ToDate);
        }

        private void pcbXl_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdTicketsShow, "Tickets",FromDate,ToDate);
        }
        //   add Selecte Checkbox
        private void AddCheckBoxWithHeaderSA(DataGridView grid)
        {
            if (!grid.Columns.Contains("chk"))
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

            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = Color.Transparent;

            System.Drawing.Rectangle rect = grid.GetCellDisplayRectangle(0, -1, true);

            headerCheckBox.Location = new Point(
                rect.X + (rect.Width / 2) - 9,
                rect.Y + (rect.Height / 2) - 9
            );

            grid.Controls.Add(headerCheckBox);

            grid.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (grid.IsCurrentCellDirty)
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            headerCheckBox.CheckedChanged += (s, e) =>
            {
                if (isHeaderClick) return;

                isHeaderClick = true;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                        row.Cells["chk"].Value = headerCheckBox.Checked;
                }

                isHeaderClick = false;
            };

            grid.CellValueChanged += (s, e) =>
            {
                if (e.RowIndex >= 0 && grid.Columns[e.ColumnIndex].Name == "chk" && !isHeaderClick)
                {
                    int total = 0;
                    int checkedCount = 0;

                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            total++;

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
            };
        }

        private void pcbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void pcbRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            obj.UserCode = UserCode;
            obj.StatusId = StatusId;
            obj.FromDate = FromDate;
            obj.ToDate = ToDate;
            clsTeamLeader obj1 = new clsTeamLeader(obj);


            DataTable dt = new DataTable();
            dt = obj1.ColumnChartClick();

            if (dt != null)
            {
                // ✅ ALWAYS RESET SrNo
                if (dt.Columns.Contains("SrNo"))
                    dt.Columns.Remove("SrNo");

                DataColumn srcol = new DataColumn("SrNo", typeof(int));
                dt.Columns.Add(srcol);
                srcol.SetOrdinal(0);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["SrNo"] = i + 1;
                }

                grdTicketsShow.DataSource = dt;
                grdTicketsShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // ✅ REMOVE OLD COLUMNS
                if (grdTicketsShow.Columns.Contains("chk"))
                    grdTicketsShow.Columns.Remove("chk");



                // ✅ ADD AGAIN CLEAN
                AddCheckBoxWithHeaderSA(grdTicketsShow);


            }

            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            grdTicketsShow.CurrentCell = null;

            foreach (DataGridViewRow row in grdTicketsShow.Rows)
            {
                if (row.IsNewRow) continue;

                string srno = row.Cells["SrNo"].Value?.ToString().ToLower();
                // string Company = row.Cells["Company"].Value?.ToString().ToLower();
                //string fullname = row.Cells["Full Name"].Value?.ToString().ToLower();
                //string email = row.Cells["Email"].Value?.ToString().ToLower();
                //string contact = row.Cells["Contact"].Value?.ToString().ToLower();
                string tkt = row.Cells["TktCode"].Value?.ToString().ToLower();

                if ((srno != null && srno.Contains(search)) ||
                    //(Company != null && Company.Contains(search)) ||
                    //(fullname != null && fullname.Contains(search)) ||
                    //(email != null && email.Contains(search)) ||
                    //(contact != null && contact.Contains(search)) ||
                    (tkt != null && tkt.Contains(search)))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }

        private void grdTicketsShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded) return;

            if (dtpFromDate.Value.Date <= dtpToDate.Value.Date)
                LoadTicketData();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded) return;

            if (dtpFromDate.Value.Date <= dtpToDate.Value.Date)
                LoadTicketData();
        }

        private void pcbRefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadTicketData();
        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded)
                return;

            LoadTicketData();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}