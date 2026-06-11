using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmEmployeeGraphicalViewMB : Form
    {
        private Dictionary<DataGridView, CheckBox> headerBoxes
  = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;

        public string loginusercode { get; set; }  // Team Lead code (logged in user)
        public DateTime fromdate, todate;
        public string selectedEmployeeCode { get; set; }  // Selected employee code
        private frmSideBar parentSideBar = null;

        public void SetParentSideBar(frmSideBar parent)
        {
            parentSideBar = parent;
        }
        public frmEmployeeGraphicalViewMB()
        {
            InitializeComponent();

        }

        public frmEmployeeGraphicalViewMB(string UserCode)
        {
            InitializeComponent();
            loginusercode = UserCode;
        }

        private void btnGraphicalView_Click(object sender, EventArgs e)
        {

        }

        private void chart1GraphicalView_Click(object sender, EventArgs e)
        {

        }

        private void chart1GraphicalView_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployeeGraphicalViewMB_Load(object sender, EventArgs e)
        {
            //chart1GraphicalView.Visible = false;
            lblCompanyName.Visible = false;
            lbltlname.Visible = false;
            lblCategoryName.Visible = false;
            lbltlname.Visible = false;
            lblEMPCode.Visible = false;


            lblFilter.Visible = false;
            cmbFilterDaywise.Visible = false;

            lblFromDate.Visible = false;
            lblToDate.Visible = false;
            dtpFromDate.Visible = false;
            dtpToDate.Visible = false;



            dtpFromDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpToDate.Value = new DateTime(DateTime.Today.Year, 12, 31);
            fromdate = dtpFromDate.Value;
            todate = dtpToDate.Value;

            cmbFilterDaywise.Items.Add("Daywise");
            cmbFilterDaywise.Items.Add("Monthwise");
            cmbFilterDaywise.Items.Add("Yearwise");
            cmbFilterDaywise.SelectedIndex = 2;



            clsTeamLeader objlist = new clsTeamLeader();
            objlist.empcode = loginusercode;

            clsTeamLeader objlist2 = new clsTeamLeader(objlist);
            DataTable dt88 = new DataTable();

            dt88 = objlist2.ShowEmployeeListMB();
            if (!dt88.Columns.Contains("SrNo"))
            {
                DataColumn srcol = new DataColumn("SrNo", typeof(int));
                dt88.Columns.Add(srcol);
                srcol.SetOrdinal(0);
            }
            for (int i = 0; i < dt88.Rows.Count; i++)
            {
                dt88.Rows[i]["SrNo"] = i + 1;
            }




            grdSelectEmployee.ColumnHeadersHeight = 40;
            grdSelectEmployee.DataSource = dt88;
            grdSelectEmployee.Show();

            DataGridViewButtonColumn objbutton = new DataGridViewButtonColumn();
            objbutton.Text = "👁 View";
            objbutton.Name = "Action";
            objbutton.UseColumnTextForButtonValue = true;
            grdSelectEmployee.Columns.Add(objbutton);



            AddCheckBoxWithHeaderMB(grdSelectEmployee);




            clsTeamLeader objempcode = new clsTeamLeader();
            objempcode.empcode = loginusercode;
            clsTeamLeader obj2 = new clsTeamLeader(objempcode);


            DataTable dt55 = obj2.ShowLoginUserDetailsByUserCodeMB();
            if (dt55.Rows.Count > 0)
            {

                lbltlname.Text = dt55.Rows[0]["FullName"].ToString();

                lblCompanyName.Text = dt55.Rows[0]["CompName"].ToString();

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

        private void btnTabularView_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmployeeTabularViewMB objemptab = new frmEmployeeTabularViewMB(loginusercode);
            objemptab.Show();
            this.Hide();
        }

        private void btnTabularView_Click(object sender, EventArgs e)
        {

        }

        private void grdSelectEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSelectEmployee.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                string selectedEmployeeCode = grdSelectEmployee.Rows[e.RowIndex].Cells["UserCode"].Value.ToString();
                string selectedEmployeeName = grdSelectEmployee.Rows[e.RowIndex].Cells["Employee Name"].Value.ToString();

                frmEmployeeViewChartTypeColumnMB objEmployeeChart = new frmEmployeeViewChartTypeColumnMB(selectedEmployeeCode, loginusercode, fromdate, todate);
                objEmployeeChart.empname = selectedEmployeeName;
                objEmployeeChart.Show();
            }
        }

        private void btnGraphicalView_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmployeeGraphicalViewMB obj = new frmEmployeeGraphicalViewMB(loginusercode);
            obj.Show();
            this.Hide();
        }

        private void btnAgent_MouseClick(object sender, MouseEventArgs e)
        {
            //frmReportMB objAgentGraphical = new frmReportMB(loginusercode); 
            //objAgentGraphical.Show();
            frmAgentTabularViewFixMB obj = new frmAgentTabularViewFixMB(loginusercode);
            obj.Show();
            this.Hide();
        }

        private void pnlReport1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFilterDaywise_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            obj.empcode = selectedEmployeeCode;
            obj.tlempcode = loginusercode;
            obj.fromdate = fromdate;
            obj.todate = todate;
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            DataTable dt = obj2.ShowGraphicalViewChartEmployee22MB();




        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (grdSelectEmployee.DataSource is DataTable dt)
            {
                if (string.IsNullOrEmpty(txtSearchBox.Text))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format(
                        "Convert(UserCode,'System.String') LIKE '%{0}%' OR " +
                        "[Employee Name] LIKE '%{0}%'",
                        txtSearchBox.Text.Replace("'", "''"));
                }
            }
        }

        private void pbPdf_MouseClick(object sender, MouseEventArgs e)
        {
            ExportGridToPDFMB(grdSelectEmployee, "EmployeeNameReport.pdf", dtpFromDate.Value, dtpToDate.Value);
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





        // Export Data in PDFFile

        private void pcExcel_MouseClick(object sender, MouseEventArgs e)
        {
            ExportGridToExcelMB(grdSelectEmployee, "AgentName", dtpFromDate.Value, dtpToDate.Value);
        }

        private void pbRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            grdSelectEmployee.AutoGenerateColumns = false;

            clsTeamLeader objlist = new clsTeamLeader();
            objlist.empcode = loginusercode;
            clsTeamLeader obj3 = new clsTeamLeader(objlist);
            DataTable dt = new DataTable();

            dt = obj3.ShowEmployeeListMB();

            if (dt != null)
            {
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

                grdSelectEmployee.DataSource = dt;
                grdSelectEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // ADD THIS - Remove old Action button if exists
                if (grdSelectEmployee.Columns.Contains("Action"))
                    grdSelectEmployee.Columns.Remove("Action");

                // ADD THIS - Add Action button back
                DataGridViewButtonColumn objbutton = new DataGridViewButtonColumn();
                objbutton.Text = "👁";
                objbutton.Name = "Action";
                objbutton.UseColumnTextForButtonValue = true;
                grdSelectEmployee.Columns.Add(objbutton);

                AddCheckBoxWithHeaderMB(grdSelectEmployee);
            }

            txtSearchBox.Clear();
            this.Refresh();




















        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPdf_Click(object sender, EventArgs e)
        {

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

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

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

    

    }
}
