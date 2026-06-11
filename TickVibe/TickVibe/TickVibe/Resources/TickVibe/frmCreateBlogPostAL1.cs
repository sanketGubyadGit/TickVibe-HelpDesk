using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmCreateBlogPostAL1 : Form
    {
        public frmCreateBlogPostAL1(string UserCode)
        {
            InitializeComponent();
            lblEMPCode.Text= UserCode;
        }

        private void frmCreateBlogPostAL1_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.ShowCategoriesAL();
            cmbbxCategory.DisplayMember = "CategoryName";
            cmbbxCategory.ValueMember = "CategoryId";
            cmbbxCategory.DataSource = dt;

            clsTeamLeader objs = new clsTeamLeader();
            DataTable dti = objs.showAuthorAL();
            cmbbxAuthorname.DisplayMember = "AuthorName";
            cmbbxAuthorname.ValueMember = "AuthorId";
            cmbbxAuthorname.DataSource = dti;

            richTxtContent.DetectUrls = true;  // add URIL Link
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            //string Blogtitle = txtTitleName.Text;
            //string Content = richTxtContent.Text;
            //string BlogPdfPath = btnSelectFiles.Text;
            //int categoryid = Convert.ToInt32(cmbbxCategory.SelectedValue);
            //int authorid = Convert.ToInt32(cmbbxAuthorname.SelectedValue);
            //int blogStatusId = 1;
            //clsTeamLeader obj = new clsTeamLeader();
            //obj.CreateBlogAL(Blogtitle, categoryid, authorid, Content, BlogPdfPath, blogStatusId);
            //MessageBox.Show("Add Blog Successfully!");

            clsTeamLeader obj1 = new clsTeamLeader();

            obj1.Blogtitle = txtTitleName.Text;
            obj1.Content = richTxtContent.Text;
            obj1.BlogPdfPath = btnSelectFiles.Text;
            obj1.CategoryId = Convert.ToInt32(cmbbxCategory.SelectedValue);
            obj1.AuthorId = Convert.ToInt32(cmbbxAuthorname.SelectedValue);
            obj1.BlogStatusId = 1;
            obj1.CreatedBy = lblEMPCode.Text;
            // Copy constructor use
            clsTeamLeader obj2 = new clsTeamLeader(obj1);

            obj2.CreateBlogAL();

            MessageBox.Show("Add Blog Successfully!");
        }

        private void pbcPuls_Click(object sender, EventArgs e)
        {
            frmAddAuthorAL obj = new frmAddAuthorAL();
            obj.Show();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                btnSelectFiles.Text = openFileDialog1.FileName;
            }
            else
            {
                btnSelectFiles.Text = "";
            }




            //string imagePath = "";

            //OpenFileDialog obj = new OpenFileDialog();
            //obj.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            //if (obj.ShowDialog() == DialogResult.OK)
            //{
            //    imagePath = obj.FileName;   // Full path
            //    pbox5.ImageLocation = imagePath;
            //    //btnSelectFiles.ImageLocation = imagePath;
            //    btnSelectFiles.Text = imagePath;

            //    string sourcePath = imagePath;
            //    string fileName = Path.GetFileName(sourcePath);

            //    string destFolder = Application.StartupPath + @"\TickVibe\Content\img\";

            //    if (!Directory.Exists(destFolder))
            //    {
            //        Directory.CreateDirectory(destFolder);
            //    }

            //    string destPath = Path.Combine(destFolder, fileName);

            //    File.Copy(sourcePath, destPath, true);

            //    // Database path
            //    string dbImagePath = @"TickVibe\Content\img\" + fileName;
            //}

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string user = "";
            frmKnowledgeBaseBlogAL objw = new frmKnowledgeBaseBlogAL(user);

            objw.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            //string Blogtitle = txtTitleName.Text;
            //string Content = richTxtContent.Text;
            //string BlogPdfPath = btnSelectFiles.Text;
            //int categoryid = Convert.ToInt32(cmbbxCategory.SelectedValue);
            //int authorid = Convert.ToInt32(cmbbxAuthorname.SelectedValue);
            //int blogStatusId = 2;
            //clsTeamLeader obj = new clsTeamLeader();
            //obj.CreateBlogAL(Blogtitle, categoryid, authorid, Content, BlogPdfPath, blogStatusId);
            //MessageBox.Show("Add Blog Successfully!");

            clsTeamLeader obj1 = new clsTeamLeader();

            obj1.Blogtitle = txtTitleName.Text;
            obj1.Content = richTxtContent.Text;
            obj1.BlogPdfPath = btnSelectFiles.Text;
            obj1.CategoryId = Convert.ToInt32(cmbbxCategory.SelectedValue);
            obj1.AuthorId = Convert.ToInt32(cmbbxAuthorname.SelectedValue);
            obj1.BlogStatusId = 2;   // Publish
            obj1.CreatedBy =lblEMPCode.Text;

            // Copy constructor
            clsTeamLeader obj2 = new clsTeamLeader(obj1);

            obj2.CreateBlogAL();

            MessageBox.Show("Blog Published Successfully!");
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            if (richTxtContent.SelectionFont != null)
            {
                Font currentFont = richTxtContent.SelectionFont;
                FontStyle newFontStyle;
                if (currentFont.Bold)
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                else
                    newFontStyle = currentFont.Style | FontStyle.Bold;

                richTxtContent.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size,
                    newFontStyle
                );
            }
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            if (richTxtContent.SelectionFont != null)
            {
                Font f = richTxtContent.SelectionFont;
                FontStyle style = f.Italic ? f.Style & ~FontStyle.Italic : f.Style | FontStyle.Italic;
                richTxtContent.SelectionFont = new Font(f, style);
            }
        }
        // add URIL Link
        private void PbAddlink_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = "Insert Link"
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Enter URL:" };
            TextBox textBox = new TextBox() { Left = 20, Top = 45, Width = 340 };
            Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 75 };

            confirmation.Click += (sender1, e1) =>
            {
                prompt.Close();
            };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            prompt.ShowDialog();

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                richTxtContent.AppendText(textBox.Text + " ");
            }
        }

        private void richTxtContent_TextChanged(object sender, EventArgs e)
        {

        }
        // add URIL Link
        private void richTxtContent_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.LinkText,
                UseShellExecute = true
            });
        }

        private void siticonePictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);

                Clipboard.SetImage(img);
                richTxtContent.Paste();
            }
        }

        private void txtTitleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbox5_Click(object sender, EventArgs e)
        {
            string imagePath = "";

            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (obj.ShowDialog() == DialogResult.OK)
            {
                imagePath = obj.FileName;   // Full path
                pbox5.ImageLocation = imagePath;
                //btnSelectFiles.ImageLocation = imagePath;
                btnSelectFiles.Text = imagePath;

                string sourcePath = imagePath;
                string fileName = Path.GetFileName(sourcePath);

                string destFolder = Application.StartupPath + @"\TickVibe\Content\img\";

                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                string destPath = Path.Combine(destFolder, fileName);

                File.Copy(sourcePath, destPath, true);

                // Database path
                string dbImagePath = @"TickVibe\Content\img\" + fileName;
                btnSelectFiles.Text = dbImagePath;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
