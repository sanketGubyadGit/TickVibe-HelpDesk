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
using static Siticone.UI.Native.WinApi;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Rectangle = System.Drawing.Rectangle;
using ClosedXML.Excel;


namespace TickVibe
{
    public partial class frmMemberManagementRN : Form
    {
        // checkbox 
        private Dictionary<DataGridView, CheckBox> headerBoxes
          = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public frmMemberManagementRN(string EmpCode, int CategoryId)
        {
            InitializeComponent();
            lblEmpCode.Text = EmpCode;
            lblCategory.Text = CategoryId.ToString();
        }

        private void frmMemberManagementRN_Load(object sender, EventArgs e)
        {

            

            //Gridview  column set
          grdMManagement.ColumnHeadersHeight = 30;
            grdMManagement.BorderStyle = BorderStyle.FixedSingle;
           


            pnlDate.Visible = false;

            grdMManagement.CellContentClick += grdMManagement_CellContentClick;

            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = new DataTable();
            dt = obj.ShowAddAgentRN();
            if (!dt.Columns.Contains("SrNo"))
            {
                DataColumn srCol = new DataColumn("SrNo", typeof(int));
                dt.Columns.Add(srCol);
                srCol.SetOrdinal(0);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }

            grdMManagement.DataSource = dt;
          
            AddCheckBoxWithHeaderRN(grdMManagement);
            GridviewRN(grdMManagement);
            AddActionColumnsRN(grdMManagement);
            //grdMManagement.ReadOnly = true;
            //grdMManagement.Columns["chk"].ReadOnly = false;

            grdMManagement.AllowUserToAddRows = false;







        }





        private void grdMManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void btnaddagent_Click(object sender, EventArgs e)
        {
            int category = Convert.ToInt32(lblCategory.Text);
            frmAddAgentRN frmAddAgent = new frmAddAgentRN(category, lblEmpCode.Text);
            frmAddAgent.Show();
           
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pcbcsv_Click(object sender, EventArgs e)
        {



        }

        private void pnlMemberManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlForm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearchbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearchbox.Text))
            {
                (grdMManagement.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (grdMManagement.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName Like '%{0}%' OR UserCode Like '%{0}%'", txtsearchbox.Text);
            }
        }

        private void LoaddateRN()
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FDateRN(dtpFromDate.Value.Date,
                                       dtpToDate.Value.Date);

            if (!dt.Columns.Contains("SrNo"))
            {
                DataColumn srCol = new DataColumn("SrNo", typeof(int));
                dt.Columns.Add(srCol);
                srCol.SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }

            grdMManagement.DataSource = dt;

            SetColumnOrder();   
        }

        private void SetColumnOrder()
        {
            if (grdMManagement.Columns.Contains("chk"))
                grdMManagement.Columns["chk"].DisplayIndex = 0;

            if (grdMManagement.Columns.Contains("SrNo"))
                grdMManagement.Columns["SrNo"].DisplayIndex = 1;

            if (grdMManagement.Columns.Contains("CompName"))
                grdMManagement.Columns["CompName"].DisplayIndex = 2;

            if (grdMManagement.Columns.Contains("UserCode"))
                grdMManagement.Columns["UserCode"].DisplayIndex = 3;

            if (grdMManagement.Columns.Contains("FullName"))
                grdMManagement.Columns["FullName"].DisplayIndex = 4;

            if (grdMManagement.Columns.Contains("Email"))
                grdMManagement.Columns["Email"].DisplayIndex = 5;

            if (grdMManagement.Columns.Contains("ContactNo"))
                grdMManagement.Columns["ContactNo"].DisplayIndex = 6;

            if (grdMManagement.Columns.Contains("View"))
                grdMManagement.Columns["View"].DisplayIndex = 7;

            if (grdMManagement.Columns.Contains("Edit"))
                grdMManagement.Columns["Edit"].DisplayIndex = 8;

            if (grdMManagement.Columns.Contains("delete"))
                grdMManagement.Columns["delete"].DisplayIndex = 8;
        }



        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoaddateRN();
        }

        private void dtpToDate_ValueChanged_1(object sender, EventArgs e)
        {
            LoaddateRN();
        }


        // refresh code RN 
        private void pcbRefresh_Click(object sender, EventArgs e)
        {

            grdMManagement.AutoGenerateColumns = false;

            try
            {
                clsTeamLeader obj = new clsTeamLeader();

                DataTable dt = new DataTable();
                dt = obj.ShowAddAgentRN();
                grdMManagement.DataSource = dt;


                AddCheckBoxWithHeaderRN(grdMManagement);
                grdMManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (!dt.Columns.Contains("SrNo"))
                {
                    DataColumn srCol = new DataColumn("SrNo", typeof(int));
                    dt.Columns.Add(srCol);
                    srCol.SetOrdinal(0);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["SrNo"] = i + 1;
                }

                txtsearchbox.Clear();



            }
            catch
            {


            }

        }

        private void btnfilters_Click(object sender, EventArgs e)
        {
            pnlDate.Visible = !pnlDate.Visible;
        }
        private void AddCheckBoxWithHeaderRN(DataGridView grid)
        {
            // Remove old header checkbox if exists
            foreach (Control c in grid.Controls.OfType<CheckBox>().ToList())
            {
                if (c.Name == "headerCheckBox")
                {
                    grid.Controls.Remove(c);
                    c.Dispose();
                }
            }

            // Add checkbox column if not exists
            if (!grid.Columns.Contains("chk"))
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.Name = "chk";
                col.HeaderText = "";
                col.Width = 50;

                // Center checkbox in cells
                col.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Center header
                col.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                grid.Columns.Insert(0, col);
            }

            grid.RowTemplate.Height = 30;

            // Create header checkbox
            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Name = "headerCheckBox";
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.BackColor = Color.Transparent;

            grid.Controls.Add(headerCheckBox);

            // Center header checkbox
            Rectangle rect = grid.GetCellDisplayRectangle(0, -1, true);

            headerCheckBox.Location = new Point(
                rect.X + (rect.Width - headerCheckBox.Width) / 2,
                rect.Y + (rect.Height - headerCheckBox.Height) / 2
            );

            // Select All / Unselect All
            headerCheckBox.CheckedChanged += (s, e) =>
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells["chk"].Value = headerCheckBox.Checked;
                    }
                }
            };

            // Commit checkbox value immediately
            grid.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (grid.IsCurrentCellDirty)
                {
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            // Re-center header checkbox when grid changes
            grid.Scroll += (s, e) =>
            {
                Rectangle r = grid.GetCellDisplayRectangle(0, -1, true);

                headerCheckBox.Location = new Point(
                    r.X + (r.Width - headerCheckBox.Width) / 2,
                    r.Y + (r.Height - headerCheckBox.Height) / 2
                );
            };

            grid.ColumnWidthChanged += (s, e) =>
            {
                Rectangle r = grid.GetCellDisplayRectangle(0, -1, true);

                headerCheckBox.Location = new Point(
                    r.X + (r.Width - headerCheckBox.Width) / 2,
                    r.Y + (r.Height - headerCheckBox.Height) / 2
                );
            };
        }

        private void ExportGridToPDFRN(DataGridView grid, string fileName,DateTime fromdate,DateTime todate)
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

                string dateRange = "Date Range : " +
                    fromdate.ToString("dd MMM yyyy") + " To " +
                    todate.ToString("dd MMM yyyy");

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
                        column.Name == "Edit" ||
                        column.Name == "delete" ||

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
                        column.Name == "Edit" ||
                        column.Name == "delete" ||

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
                                grid.Columns[cell.ColumnIndex].Name == "Edit" ||
                                grid.Columns[cell.ColumnIndex].Name == "delete" ||
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
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow && row.Cells["chk"] != null)
                {
                    row.Cells["chk"].Value = false;
                }
            }
        }
        private void pcbpdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFRN(grdMManagement, "Agent Details",dtpFromDate.Value,dtpToDate.Value);
        }
        private void ExportGridToExcelRN(DataGridView grid, string fileName,DateTime fromdate,DateTime todate)
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
                        column.Name == "Edit" ||
                        column.Name == "delete" ||
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
                ws.Cell(3, 1).Value = "Date Range : " +
                    fromdate.ToString("dd MMM yyyy") + " To " +
                    todate.ToString("dd MMM yyyy");

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
                        column.Name == "Edit" ||
                        column.Name == "delete" ||
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
                                             grid.Columns[cell.ColumnIndex].Name == "Edit" ||
                                grid.Columns[cell.ColumnIndex].Name == "delete" ||
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
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow && row.Cells["chk"] != null)
                {
                    row.Cells["chk"].Value = false;
                }
            }
        }

        private void pcbxlsx_Click(object sender, EventArgs e)
        {
            ExportGridToExcelRN(grdMManagement, "Agent Details",dtpFromDate.Value,dtpToDate.Value);
        }






        // GridViewValidation//
        private void GridviewRN(DataGridView grid)
        {
            if (grid.Columns.Contains("SrNo"))
                grid.Columns["SrNo"].ReadOnly = true;

            if (grid.Columns.Contains("UserCode"))
                grid.Columns["UserCode"].ReadOnly = true;

            if (grid.Columns.Contains("FullName"))
                grid.Columns["FullName"].ReadOnly = true;

            if (grid.Columns.Contains("Email"))
                grid.Columns["Email"].ReadOnly = true;

            if (grid.Columns.Contains("ContactNo"))
                grid.Columns["ContactNo"].ReadOnly = true;
        }

        // button grid view click 
        private void grdMManagement_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0 && grdMManagement.Columns[e.ColumnIndex].Name=="View")
            {
                DataGridViewRow SelectedRow = grdMManagement.Rows[e.RowIndex];

                string usercode = SelectedRow.Cells["UserCode"].Value.ToString();

                int category = Convert.ToInt32(lblCategory.Text);
                frmViewAgentRN frm = new frmViewAgentRN(usercode, category);
                frm.Show();
                this.Hide();

            }
            if (e.RowIndex>= 0 && grdMManagement.Columns[e.ColumnIndex].Name=="Edit")
            {
                DataGridViewRow SelectedRow = grdMManagement.Rows[e.RowIndex];

                string usercode = SelectedRow.Cells["UserCode"].Value.ToString();

               frmEditAgentRN frm = new frmEditAgentRN(usercode);
                frm.Show();

            }
        }

        // column added in grid view 
        public void AddActionColumnsRN(DataGridView dgv)
        {

            if (dgv.Columns.Contains("Edit"))
                dgv.RowTemplate.Height = 15;


            DataGridViewImageColumn viewCol = new DataGridViewImageColumn();
            viewCol.Name = "View";
            viewCol.HeaderText = "";
           viewCol.Image = Properties.Resources.view___Copy;
            viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            viewCol.Width = 20;


            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Name = "Edit";
            editCol.HeaderText = "Action";
            editCol.Image = Properties.Resources.edit___Copy;
            editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editCol.Width = 20;

            DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
            deleteCol.Name = "delete";
            deleteCol.HeaderText = "";
            deleteCol.Image = Properties.Resources.delete___Copy;
            deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteCol.Width = 20;

            //DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
            //// deleteCol.Name = "delete";
            //// deleteCol.HeaderText = "";
            //// deleteCol.Image = Properties.Resources.delete;
            //// deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //// deleteCol.Width = 20;

            ////grdMManagement.Columns.Add(deleteCol);
            ///

            


            dgv.Columns.Add(viewCol);
            dgv.Columns.Add(editCol);
            dgv.Columns.Add(deleteCol);

            if (dgv.Columns.Contains("View"))
                return;



        }

        private void grdMManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        
            if (e.ColumnIndex == grdMManagement.Columns["delete"].Index && e.RowIndex >= 0)
            {
                grdMManagement.Rows.RemoveAt(e.RowIndex);
            }
        
    }

        private void pnlDate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    
 
    

