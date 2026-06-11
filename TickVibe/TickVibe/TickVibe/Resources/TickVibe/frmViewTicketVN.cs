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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace TickVibe
{
    public partial class frmViewTicketVN : Form
    {
        string cat;
        string prop;
        string sub;
        private Dictionary<DataGridView, CheckBox> headerBoxes
   = new Dictionary<DataGridView, CheckBox>();

        private bool isHeaderClick = false;
        public frmViewTicketVN(string Usercode, long contact, string name, string email)
        {
            InitializeComponent();
            lblEMPCode.Text = Usercode;
            lblContact.Text = contact.ToString();
            lblName.Text = name;
            lblEmail.Text = email;
        }
        //here user can view his won  new raised ticket list
        // add two button   in action coloumn to view and update raised new ticket info 
        //fetch data in girdview to show new raised ticket info 
        
        private void frmViewTicketVN_Load(object sender, EventArgs e)
        {
            gridViewAllRaisedTicket.CellPainting += gridViewAllRaisedTicket_CellPainting;
            clsTeamLeader obj = new clsTeamLeader();
            obj.EMPCode = lblEMPCode.Text;
            DataTable dt;
            dt = obj.FetchViewticketUserVN();
            gridViewAllRaisedTicket.DataSource = dt;
            AddCheckBoxWithHeaderVN(gridViewAllRaisedTicket);
            gridViewAllRaisedTicket.Show();

            gridViewAllRaisedTicket.RowHeadersVisible = false;
            
            gridViewAllRaisedTicket.Columns["FullName"].Visible = false;
            gridViewAllRaisedTicket.Columns["Email"].Visible = false;
            gridViewAllRaisedTicket.Columns["ContactNo"].Visible = false;
            gridViewAllRaisedTicket.Columns["FilePath"].Visible = false;

           
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "Action";
            btn.FlatStyle = FlatStyle.Flat;
            btn.DefaultCellStyle.BackColor = Color.White;
            btn.DefaultCellStyle.SelectionBackColor = Color.White;
            btn.UseColumnTextForButtonValue = true;
            gridViewAllRaisedTicket.Columns.Add(btn);




            //Gridview  column set
            gridViewAllRaisedTicket.ColumnHeadersHeight = 40;
            gridViewAllRaisedTicket.BorderStyle = BorderStyle.FixedSingle;

  
        }
         
        //open create ticket from to raise new ticket 
        
        private void lblExit_Click(object sender, EventArgs e)
        {

            string FilePath = "";
             
            frmCreateTicketVN obj = new frmCreateTicketVN(lblEMPCode.Text,FilePath, cat, prop, sub);
            obj.Show();
            this.Close();
        }
        //when user click view icon it wil show the read only type info on frmViewVN
        //when user click on edit icon it will show editable  info on frmUpdateTicketVN for make changes in rsaised ticket 
       
       
 
        //added two button in one column for view and update ticket raised  for that use grid methods for thwat firsst use cellpainting  event
        //
        private void gridViewAllRaisedTicket_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == gridViewAllRaisedTicket.Columns["Action"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                System.Drawing.Image viewImg = Properties.Resources.view___Copy;
                System.Drawing.  Image updateImg = Properties.Resources.edit___Copy;

                int y = e.CellBounds.Top + (e.CellBounds.Height - 16) / 2;

                e.Graphics.DrawImage(viewImg, e.CellBounds.Left + 10, y, 16, 16);
                e.Graphics.DrawImage(updateImg, e.CellBounds.Left + 50, y, 16, 16);
                gridViewAllRaisedTicket.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridViewAllRaisedTicket.Columns["Action"].Width = 100;
                e.Handled = true;
            }
        }

        private void gridViewAllRaisedTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         }

        private void btnSearchBox_Click(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            obj.EMPCode = lblEMPCode.Text;
            DataTable dt;
            dt = obj.FetchViewticketUserVN();
            gridViewAllRaisedTicket.DataSource = dt;
            gridViewAllRaisedTicket.Show();
            txtsearchBox.Focus();
            string searchText = txtsearchBox.Text.Replace("'", "''");

            dt.DefaultView.RowFilter = $"FullName LIKE '%{searchText}%' OR Email LIKE '%{searchText}%' OR PriorityName LIKE '%{searchText}%'" +
    $" OR CategoryName LIKE '%{searchText}%' OR SubName LIKE '%{searchText}%' OR StatusName LIKE '%{searchText}%' " +
    $"OR Description LIKE '%{searchText}%'  OR TktCode LIKE '%{searchText}%' OR CompName LIKE '%{searchText}%'";
        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            obj.EMPCode = lblEMPCode.Text;
            DataTable dt;
            dt = obj.FetchViewticketUserVN();
            gridViewAllRaisedTicket.DataSource = dt;
            gridViewAllRaisedTicket.Show();
            string searchText = txtsearchBox.Text.Replace("'", "''");
           
            dt.DefaultView.RowFilter = $"FullName LIKE '%{searchText}%' OR Email LIKE '%{searchText}%' OR PriorityName LIKE '%{searchText}%'" +
    $" OR CategoryName LIKE '%{searchText}%' OR SubName LIKE '%{searchText}%' OR StatusName LIKE '%{searchText}%' " +
    $"OR Description LIKE '%{searchText}%'  OR TktCode LIKE '%{searchText}%' OR CompName LIKE '%{searchText}%'";
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExportGridToPDFVN(DataGridView grid, string fileName)
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

                
                int colCount = 0;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column is DataGridViewButtonColumn ||
                        column is DataGridViewCheckBoxColumn ||
                        column.Name == "SrNo" ||
                      //  column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "Edit" ||
                        column.Name == "delete" ||
                        column.Name == "FilePath" ||
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
                        column.Name == "FilePath" ||

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
                              //  grid.Columns[cell.ColumnIndex].Name == "Action" ||
                                grid.Columns[cell.ColumnIndex].Name == "View" ||
                                grid.Columns[cell.ColumnIndex].Name == "Edit" ||
                                 grid.Columns[cell.ColumnIndex].Name == "FilePath" ||
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
             foreach(DataGridViewRow row in grid.Rows)
            {
                if(!row.IsNewRow && row.Cells["chk"] != null)
                {
                row.Cells["chk"].Value = false;
                }
            }
        }
        
        private void AddCheckBoxWithHeaderVN(DataGridView grid)
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportGridToPDFVN(gridViewAllRaisedTicket, "New Ticket pdf");
        }


        private void ExportGridToExcelVN(DataGridView grid, string fileName)
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
                        //column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "Edit" ||
                        column.Name == "FilePath" ||
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

                //// Date Range
                //ws.Cell(3, 1).Value = "Date Range : " +
                //    fromDate.ToString("dd MMM yyyy") + " To " +
                //    toDate.ToString("dd MMM yyyy");

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
                       // column.Name == "Action" ||
                        column.Name == "View" ||
                        column.Name == "Edit" ||
                        column.Name == "FilePath" ||
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
                            //    grid.Columns[cell.ColumnIndex].Name == "Action" ||
                                grid.Columns[cell.ColumnIndex].Name == "View" ||
                                grid.Columns[cell.ColumnIndex].Name == "Edit" ||
                                grid.Columns[cell.ColumnIndex].Name == "FilePath" ||
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
            this.Refresh();
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportGridToExcelVN(gridViewAllRaisedTicket, "New Tickets detail.Excel");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string FilePath = "";

            frmCreateTicketVN obj = new frmCreateTicketVN(lblEMPCode.Text, FilePath, cat, prop, sub);
            obj.Show();
            this.Close();
        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridViewAllRaisedTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridViewAllRaisedTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex < 0)
                return;
            if (gridViewAllRaisedTicket.Columns[e.ColumnIndex].Name == "Action")
            {
                System.Drawing.Rectangle cellRectangle = gridViewAllRaisedTicket.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int clickX = gridViewAllRaisedTicket.PointToClient(Cursor.Position).X - cellRectangle.X;

                if (clickX < cellRectangle.Width / 2)
                {

                    DataGridViewRow row = gridViewAllRaisedTicket.Rows[e.RowIndex];
                    string userName = row.Cells["FullName"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();
                    long contact = Convert.ToInt64(row.Cells["ContactNo"].Value);
                    string Priority = row.Cells["PriorityName"].Value.ToString();
                    string category = row.Cells["CategoryName"].Value.ToString();
                    string subject = row.Cells["SubName"].Value.ToString();
                    string status = row.Cells["StatusName"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    DateTime createdAt = Convert.ToDateTime(row.Cells["CreatedAt"].Value);
                    string attactment = row.Cells["FilePath"].Value.ToString();
                    string company = row.Cells["CompName"].Value.ToString();
                    frmViewVN bj = new frmViewVN(lblEMPCode.Text, userName, email, contact, Priority, category, subject, status, description, createdAt, attactment, company);
                    bj.Show();
                    this.Hide();
                }
                else
                {
                    DataGridViewRow row = gridViewAllRaisedTicket.Rows[e.RowIndex];
                    string userName = row.Cells["FullName"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();
                    long contact = Convert.ToInt64(row.Cells["ContactNo"].Value);
                    string Priority = row.Cells["PriorityName"].Value.ToString();
                    string category = row.Cells["CategoryName"].Value.ToString();
                    string subject = row.Cells["SubName"].Value.ToString();
                    string status = row.Cells["StatusName"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    DateTime createdAt = Convert.ToDateTime(row.Cells["CreatedAt"].Value);
                    string attactment = row.Cells["FilePath"].Value.ToString();
                    string TktCode = row.Cells["TktCode"].Value.ToString();
                    string company = row.Cells["CompName"].Value.ToString();
                    frmUpdateTicketsVN bj = new frmUpdateTicketsVN(TktCode, lblEMPCode.Text, userName, email, contact, Priority, category, subject, status, description, createdAt, attactment, company);
                    bj.Show();
                    this.Close();
                }
            }
        }

        private void gridViewAllRaisedTicket_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
