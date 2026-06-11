using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using TickVibeLib;
using DrawingFont = System.Drawing.Font;
using PdfFont = iTextSharp.text.Font;


namespace TickVibe
{
    public partial class frmEmployeeDetailsSB : Form
    {
        //CheckBox headerCheckBox = new CheckBox();
        private Dictionary<DataGridView, CheckBox> headerBoxes
   = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public frmEmployeeDetailsSB(string User, int category)
        {
            InitializeComponent();
            lblEMPCode.Text = User;
            lblCategory.Text = category.ToString();



            grdEmployeDetailes.CellContentClick += grdEmployeDetailes_CellContentClick;

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            clsTeamLeader obj = new clsTeamLeader(lblEMPCode.Text);
            DataTable dt = obj.EmployeeDetailesSB(
                DateTime.Today.AddYears(-1),
                DateTime.Today);
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
            SetGridFont1(grdEmployeDetailes);
        

                LoadGridData();

            grdEmployeDetailes.DataSource = dt;
            SetGridFont(grdEmployeDetailes);


            grdEmployeDetailes.Columns["SrNo"].ReadOnly = true;
            grdEmployeDetailes.Columns["Company"].ReadOnly = true;
            grdEmployeDetailes.Columns["Full Name"].ReadOnly = true;
            grdEmployeDetailes.Columns["Contact"].ReadOnly = true;
            grdEmployeDetailes.Columns["Email"].ReadOnly = true;
            grdEmployeDetailes.Columns["Ticket Code"].ReadOnly = true;






            if (!grdEmployeDetailes.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Action";
                btn.HeaderText = "Action";
                btn.Text = "👁";
                btn.UseColumnTextForButtonValue = true;


                grdEmployeDetailes.Columns.Add(btn);


            }
            if (grdEmployeDetailes.Columns.Contains("Action") &&
                grdEmployeDetailes.Columns["Action"] is DataGridViewButtonColumn)
            {
                DataGridViewButtonColumn btn =
                    (DataGridViewButtonColumn)grdEmployeDetailes.Columns["Action"];

                btn.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
                btn.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;

            }
            grdEmployeDetailes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdEmployeDetailes.ColumnHeadersHeight = 30;
            grdEmployeDetailes.BorderStyle = BorderStyle.FixedSingle;
            grdEmployeDetailes.AllowUserToAddRows = false;
            AddCheckBoxWithHeaderSB(grdEmployeDetailes);


        }
        private void AddCheckBoxWithHeaderSB(DataGridView grid)
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
                if (c is CheckBox && c.Tag?.ToString() == "header")
                {
                    grid.Controls.Remove(c);
                    break;
                }
            }


            CheckBox headerCheckBox = new CheckBox();
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



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {




        }


        private void grdEmployeDetailes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (grdEmployeDetailes.Columns[e.ColumnIndex].Name == "Action")
            {

                string name = grdEmployeDetailes.Rows[e.RowIndex].Cells["Full Name"].Value.ToString();

                string Ecode = grdEmployeDetailes.Rows[e.RowIndex].Cells["User Code"].Value.ToString();
                string email = grdEmployeDetailes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string contact = grdEmployeDetailes.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
                string TktCode = grdEmployeDetailes.Rows[e.RowIndex].Cells["Ticket Code"].Value.ToString();
                grdEmployeDetailes.ReadOnly = true;


                frmEmployeeTicketViewSB frm = new frmEmployeeTicketViewSB(Ecode, name, email, contact, TktCode);
                frm.Show();
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pcbRefresh.Visible = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void btnCsv_Click(object sender, EventArgs e)
        {

        }

        private void btnxl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExportGridToPDFPG(grdEmployeDetailes, "Employe Details",adtFromDate.Value, adtToDate.Value);
        }
        private void pcbCsv_Click(object sender, EventArgs e)
        {

        }

        private void pcbRefresh_Click(object sender, EventArgs e)

        {
            grdEmployeDetailes.AutoGenerateColumns = false;
            //grdNewTickets.AutoGenerateColumns = true;


            try
            {

                clsTeamLeader obj = new clsTeamLeader(lblEMPCode.Text);
                DataTable dt = obj.EmployeeDetailesSB(adtFromDate.Value, adtToDate.Value);

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


                grdEmployeDetailes.DataSource = dt;
                grdEmployeDetailes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //this.Refresh();
                rtbSerchBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Refreshing:" + ex.Message);
            }
        }


        private void pcbExcel_Click(object sender, EventArgs e)
        {
            ExportGridToExcelPG(grdEmployeDetailes, "Employe Details", adtFromDate.Value, adtToDate.Value);

        }
        private void grdEmployeDetailes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close();

        }
        private void ExportGridToPDFPGSB(DataGridView grid, string fileName)
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
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow && row.Cells["chk"] != null)
                {
                    row.Cells["chk"].Value = false;
                }
            }
        }

        private void rtbSerchBox_TextChanged(object sender, EventArgs e)
        {
            string search = rtbSerchBox.Text.ToLower();

            grdEmployeDetailes.CurrentCell = null;

            foreach (DataGridViewRow row in grdEmployeDetailes.Rows)
            {
                if (row.IsNewRow) continue;

                string srno = row.Cells["SrNo"].Value?.ToString().ToLower();
                string Company = row.Cells["Company"].Value?.ToString().ToLower();
                string fullname = row.Cells["Full Name"].Value?.ToString().ToLower();
                string email = row.Cells["Email"].Value?.ToString().ToLower();
                string contact = row.Cells["Contact"].Value?.ToString().ToLower();
                string tkt = row.Cells["Ticket Code"].Value?.ToString().ToLower();

                if ((srno != null && srno.Contains(search)) ||
                    (Company != null && Company.Contains(search)) ||
                    (fullname != null && fullname.Contains(search)) ||
                    (email != null && email.Contains(search)) ||
                    (contact != null && contact.Contains(search)) ||
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
        private void LoadGridData()
        {
            clsTeamLeader obj = new clsTeamLeader(lblEMPCode.Text);

            DataTable dt = obj.EmployeeDetailesSB(
                adtFromDate.Value,
                adtToDate.Value
            );

            if (dt == null || dt.Rows.Count == 0)
            {
                grdEmployeDetailes.DataSource = null;
                MessageBox.Show("No Data Found");
                return;
            }

            // SrNo add
            if (!dt.Columns.Contains("SrNo"))
            {
                dt.Columns.Add("SrNo", typeof(int));
                dt.Columns["SrNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SrNo"] = i + 1;
            }

            // Grid bind
            grdEmployeDetailes.DataSource = dt;

            grdEmployeDetailes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadGrid()
        {
            clsTeamLeader obj = new clsTeamLeader();

            DataTable dt = obj.EmployeeDetailesSB(
                adtFromDate.Value,
                adtToDate.Value
            );

            grdEmployeDetailes.DataSource = null;
            grdEmployeDetailes.DataSource = dt;

            grdEmployeDetailes.Refresh();
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData();

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

                foreach (
                    Control c in grid.Controls)
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
        private void SetGridFont1(DataGridView grid)
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
       





    }
}
    
