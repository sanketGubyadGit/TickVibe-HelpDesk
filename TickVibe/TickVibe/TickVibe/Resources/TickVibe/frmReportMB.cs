using iTextSharp.text;
using iTextSharp.text.pdf;
using Siticone.UI.WinForms;

using ClosedXML.Excel;
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
using System.Windows.Forms.DataVisualization.Charting;
using TickVibeLib;
namespace TickVibe
{
    public partial class frmReportMB : Form
    {
        private Dictionary<DataGridView, CheckBox> headerBoxes
  = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public string loginusercode { get; set; }
    
        public DateTime fromdate, todate;
        public int categoryid { get; set; }
        public frmReportMB()
        {

            InitializeComponent();

    

        }


        public frmReportMB(string UserCode)
        {
          
            InitializeComponent();
         
            loginusercode = UserCode;


        }

        
        
        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReport1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReportMB_Load(object sender, EventArgs e)
        {
            
            //chart1GraphicalView.Visible = false;
            lblSelectedAgent.Visible = false;
            lblCategoryName.Visible = false;


            lblEMPCode.Visible = false;

            lblSelectAgent.Visible = false;
            cmbSelectAgent.Visible = false;

            lblFilter.Visible = false;
            cmbFilterDaywise.Visible = false;

            lblFromDate.Visible = false;
            lblToDate.Visible = false;
            dtpFromDate.Visible = false;
            dtpToDate.Visible = false;


            lblCompanyName.Visible = false;
            lblCategoryId.Visible = false;
            lbltlname.Visible = false;



            clsTeamLeader objempcode = new clsTeamLeader();
            objempcode.empcode = loginusercode;
            clsTeamLeader obj2 = new clsTeamLeader(objempcode);
      

            DataTable dt55 = obj2.ShowLoginUserDetailsByUserCodeMB();
            if (dt55.Rows.Count > 0)
            {
                lblEMPCode.Text = dt55.Rows[0]["UserCode"].ToString();
                lbltlname.Text = dt55.Rows[0]["FullName"].ToString();
                lblCategoryName.Text = dt55.Rows[0]["CategoryName"].ToString();
                lblCompanyName.Text = dt55.Rows[0]["CompName"].ToString();
                categoryid = Convert.ToInt32(dt55.Rows[0]["CategoryId"]);
            }

           

            cmbFilterDaywise.Items.Add("Daywise");
            cmbFilterDaywise.Items.Add("Monthwise");
            cmbFilterDaywise.Items.Add("Yearwise");

            clsTeamLeader objlist = new clsTeamLeader();
            objlist.empcode= loginusercode;
            clsTeamLeader obj3 = new clsTeamLeader(objlist);
            DataTable dt88 = new DataTable();

            dt88 = obj3.ShowAgentListMB();

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


            grdSelectAgent.ColumnHeadersHeight = 40;
            grdSelectAgent.DataSource = dt88;
            grdSelectAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ✅ REMOVE OLD COLUMNS FIRST
            if (grdSelectAgent.Columns.Contains("chk"))
                grdSelectAgent.Columns.Remove("chk");

            if (grdSelectAgent.Columns.Contains("Action"))
                grdSelectAgent.Columns.Remove("Action");

            // ✅ ADD CHECKBOX FIRST
            AddCheckBoxWithHeaderMB(grdSelectAgent);

            // ✅ ADD ACTION BUTTON ONLY ONCE
            DataGridViewButtonColumn objbutton = new DataGridViewButtonColumn();
            objbutton.Text = "👁 View";
            objbutton.Name = "Action";
            objbutton.UseColumnTextForButtonValue = true;
            grdSelectAgent.Columns.Add(objbutton);

           
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlReport1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cmbSelectAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           


        }
        private void cmbFilterDaywise_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSelectAgent.SelectedValue == null) return;

            string empcode = cmbSelectAgent.SelectedValue.ToString();
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


           
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            cmbFilterDaywise_SelectedIndexChanged(null, null);
        }

        private void chart1GraphicalView_Click(object sender, EventArgs e)
        {

        }

        private void chart1GraphicalView_MouseClick(object sender, MouseEventArgs e)
        {

          
        }

        private void cmbFilterDaywise_MouseClick(object sender, MouseEventArgs e)
        {
            dtpFromDate.Visible = true;
            dtpToDate.Visible = true;
            lblFromDate.Visible = true;
            lblToDate.Visible = true;
        }

        private void btnTabularView_Click(object sender, EventArgs e)
        {
            frmAgentTabularViewFixMB obj = new frmAgentTabularViewFixMB();
            obj.Show();
        }

        private void btnGraphicalView_Click(object sender, EventArgs e)
        {
            frmReportMB obj22 = new frmReportMB();
            obj22.ShowDialog();
        }

        private void btnTabularView_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdSelectAgent.CurrentRow == null)
            {
                MessageBox.Show("Please select an agent first");
                return;
            }

            

            frmAgentTabularViewFixMB obj = new frmAgentTabularViewFixMB(loginusercode, categoryid);
            obj.Show();
            this.Hide();


        }

        private void btnGraphicalView_MouseClick(object sender, MouseEventArgs e)
        {
            frmReportMB obj1 = new frmReportMB(loginusercode);
            obj1.Show();
            this.Hide();
           
            SiticoneButton ClickedButton = (SiticoneButton)sender;
            ClickedButton.ForeColor = Color.Black;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReport_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void grdAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSelectAgent.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
              
                string selectedAgentCode = grdSelectAgent.Rows[e.RowIndex].Cells["UserCode"].Value.ToString();
                string selectedAgentName = grdSelectAgent.Rows[e.RowIndex].Cells["Agent Name"].Value.ToString();
                frmAgentViewChartTypeColumnMB objAgentChart = new frmAgentViewChartTypeColumnMB(selectedAgentCode,loginusercode,fromdate, todate,categoryid);
                objAgentChart.agentname = selectedAgentName;
                objAgentChart.Show();
            }
        }

        private void btnAgent_MouseClick(object sender, MouseEventArgs e)
        {
            //frmReportMB obj2 = new frmReportMB(loginusercode);
            //obj2.Show();
            frmAgentTabularViewFixMB obj = new frmAgentTabularViewFixMB(loginusercode,categoryid);
            obj.Show();
            this.Hide();
        }

        private void btnEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            //frmEmployeeGraphicalViewMB obj3 = new frmEmployeeGraphicalViewMB(loginusercode);
            //obj3.Show();
            frmEmployeeFixStatusSpecificTabularView obj = new frmEmployeeFixStatusSpecificTabularView();
            this.Close();
        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBox.Text))
            {
                (grdSelectAgent.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }
            else
            {

                (grdSelectAgent.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format(
                    "Convert(UserCode,'System.String') LIKE '%{0}%' OR " +
                   
                    "[Agent Name] LIKE '%{0}%' "
                    ,
                    txtSearchBox.Text);

            }
        }

        private void pbPdf_Click(object sender, EventArgs e)
        {

        }

        private void pbPdf_MouseClick(object sender, MouseEventArgs e)
        {
            ExportGridToPDFMB(grdSelectAgent, "AgentNameReport.pdf", dtpFromDate.Value, dtpToDate.Value);
        }



































        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            frmEmployeeGraphicalViewMB objEmployeeGraphicalView = new frmEmployeeGraphicalViewMB(loginusercode);
            objEmployeeGraphicalView.Show();
        }





        // Export Data in PDFFile
      
        //   add Selecte Checkbox
        private void AddCheckBoxWithHeaderMB(DataGridView grid)
        {
            grid.ReadOnly = false;
            grid.AllowUserToAddRows = false;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;

            // Add checkbox column if not exists
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

            int chkIndex = grid.Columns["chk"].Index;

            // Commit checkbox instantly
            grid.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (grid.IsCurrentCellDirty)
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Remove old header checkbox (avoid duplicates)
            foreach (Control c in grid.Controls)
            {
                if (c is CheckBox cb && cb.Tag?.ToString() == "header")
                {
                    grid.Controls.Remove(c);
                    break;
                }
            }

            // Create header checkbox
            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = Color.Transparent;
            headerCheckBox.Tag = "header";

            grid.Controls.Add(headerCheckBox);

            // Position checkbox in header
            grid.CellPainting += (s, e) =>
            {
                if (e.RowIndex == -1 && e.ColumnIndex == chkIndex)
                {
                    System.Drawing.Rectangle rect = grid.GetCellDisplayRectangle(chkIndex, -1, true);

                    headerCheckBox.Location = new Point(
                        rect.X + (rect.Width / 2) - 9,
                        rect.Y + (rect.Height / 2) - 9
                    );
                }
            };

            //  Header checkbox click → select all
            headerCheckBox.CheckedChanged += (s, e) =>
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                        row.Cells["chk"].Value = headerCheckBox.Checked;
                }
            };

            //  Row checkbox → update header checkbox
            grid.CellValueChanged += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == chkIndex)
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

                    headerCheckBox.Checked = (total > 0 && total == checkedCount);
                }
            };
        }
        private void pcExcel_Click(object sender, EventArgs e)
        {
            ExportGridToExcelMB(grdSelectAgent, "AgentName", dtpFromDate.Value, dtpToDate.Value);
        }

        private void pbRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            clsTeamLeader objlist = new clsTeamLeader();
            objlist.empcode = loginusercode;
            clsTeamLeader obj3 = new clsTeamLeader(objlist);

            DataTable dt = obj3.ShowAgentListMB();

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

                grdSelectAgent.DataSource = dt;
                grdSelectAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // ✅ REMOVE OLD COLUMNS
                if (grdSelectAgent.Columns.Contains("chk"))
                    grdSelectAgent.Columns.Remove("chk");

                if (grdSelectAgent.Columns.Contains("Action"))
                    grdSelectAgent.Columns.Remove("Action");

                // ✅ ADD AGAIN CLEAN
                AddCheckBoxWithHeaderMB(grdSelectAgent);

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Action";
                btn.Text = "👁";
                btn.UseColumnTextForButtonValue = true;
                grdSelectAgent.Columns.Add(btn);
            }

            txtSearchBox.Clear();
        }

        private void grdSelectAgent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcExcel_MouseClick(object sender, MouseEventArgs e)
        {
              ExportGridToExcelMB(grdSelectAgent, "AgentName", dtpFromDate.Value, dtpToDate.Value);
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

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grdSelectAgent.Columns.Contains("chk"))
            {
                grdSelectAgent.Columns["chk"].DisplayIndex = 0;
                grdSelectAgent.Columns["chk"].Frozen = true;
            }

            if (grdSelectAgent.Columns.Contains("SrNo"))
            {
                grdSelectAgent.Columns["SrNo"].DisplayIndex = 1;
                grdSelectAgent.Columns["SrNo"].Frozen = true;
            }
        }











    }
}
