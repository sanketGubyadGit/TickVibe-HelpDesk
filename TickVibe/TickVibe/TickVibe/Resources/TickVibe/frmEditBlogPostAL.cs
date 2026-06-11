using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibe;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmEditBlogPostAL : Form
    {
        public string BlogCode { get; set; }
        string Title, Category, Author , Content , imagepath , CreatedBy;
        public frmEditBlogPostAL(string title, string category,
                              string author, string content,string Imagepath,string blogCode ,string createdBy)
        {
            InitializeComponent();
            Title = title;
            Category = category;
            Author = author;
            Content = content;
            imagepath = Imagepath;
            BlogCode=blogCode;
            CreatedBy = createdBy;
        }

        private void btnUpdateEdit_Click(object sender, EventArgs e)
        {

            //string Blogtitle = txtTitleEdit.Text;
            //string Content = txtContentEdit.Text;
            //string BlogPdfPath = btnSelectFilesEdit.Text;
            //int categoryid = Convert.ToInt32(cmbbxCategoryEdit.SelectedValue);
            //int authorid = Convert.ToInt32(cmbbxAuthornameEdit.SelectedValue);
            //int blogStatusId = 1;
            //string blogcode = BlogCode;
            //clsTeamLeader obj = new clsTeamLeader();
            //obj.UpdateBlogInformationAL(Blogtitle, categoryid, authorid, Content, BlogPdfPath, blogStatusId, BlogCode);
            //MessageBox.Show("Update Blog Successfully!");
            clsTeamLeader obj1 = new clsTeamLeader();

            obj1.Blogtitle = txtTitleEdit.Text;
            obj1.Content = txtContentEdit.Text;
            obj1.BlogPdfPath = btnSelectFilesEdit.Text;
            obj1.CategoryId = Convert.ToInt32(cmbbxCategoryEdit.SelectedValue);
            obj1.AuthorId = Convert.ToInt32(cmbbxAuthornameEdit.SelectedValue);
            obj1.BlogStatusId = 1;
            obj1.BlogCode = BlogCode;
            obj1.CreatedBy = lblEMPCode.Text;

            // Copy constructor
            clsTeamLeader obj2 = new clsTeamLeader(obj1);

            obj2.UpdateBlogInformationAL();

            MessageBox.Show("Update Blog Successfully!");

        }

        private void frmEditBlogPostAL_Load(object sender, EventArgs e)
        {
            txtTitleEdit.Text = Title;
            txtContentEdit.Text = Content;

           
            // cmbbxbox Authore
            clsTeamLeader objs = new clsTeamLeader();
            DataTable dti = objs.showAuthorAL();
            cmbbxAuthornameEdit.DisplayMember = "AuthorName";
            cmbbxAuthornameEdit.ValueMember = "AuthorId";
            cmbbxAuthornameEdit.DataSource = dti;

           //cmbbxbox Category
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.ShowCategoriesAL();
            cmbbxCategoryEdit.DisplayMember = "CategoryName";
            cmbbxCategoryEdit.ValueMember = "CategoryId";
            cmbbxCategoryEdit.DataSource = dt;
            
            //categroy fetch only


            cmbbxAuthornameEdit.SelectedIndex =
            cmbbxAuthornameEdit.FindStringExact(Author);

            cmbbxCategoryEdit.SelectedIndex =
            cmbbxCategoryEdit.FindStringExact(Category);

            btnSelectFilesEdit.Text = imagepath;
            lblEMPCode.Text = CreatedBy;

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFilesEdit_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\\";   // or @"C:\"
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                btnSelectFilesEdit.Text = openFileDialog1.FileName;
            }
            else
            {
                btnSelectFilesEdit.Text = "";
            }
        }

        private void pbcPulsAthore_Click(object sender, EventArgs e)
        {
            frmAddAuthorAL obj = new frmAddAuthorAL();
            obj.Show();
        }

        private void btnSaveasDraftEdit_Click(object sender, EventArgs e)
        {
            //string Blogtitle = txtTitleEdit.Text;
            //string Content = txtContentEdit.Text;
            //string BlogPdfPath = btnSelectFilesEdit.Text;
            //int categoryid = Convert.ToInt32(cmbbxCategoryEdit.SelectedValue);
            //int authorid = Convert.ToInt32(cmbbxAuthornameEdit.SelectedValue);
            //int blogStatusId = 1;
            //clsTeamLeader obj = new clsTeamLeader();
            //obj.CreateBlogAL(Blogtitle, categoryid, authorid, Content, BlogPdfPath, blogStatusId);
            //MessageBox.Show("Add Blog Successfully!");

            clsTeamLeader obj1 = new clsTeamLeader();

            obj1.Blogtitle = txtTitleEdit.Text;
            obj1.Content = txtContentEdit.Text;
            obj1.BlogPdfPath = btnSelectFilesEdit.Text;
            obj1.CategoryId = Convert.ToInt32(cmbbxCategoryEdit.SelectedValue);
            obj1.AuthorId = Convert.ToInt32(cmbbxAuthornameEdit.SelectedValue);
            obj1.BlogStatusId = 1;   // Draft
            obj1.CreatedBy =lblEMPCode.Text;

            // Copy constructor
            clsTeamLeader obj2 = new clsTeamLeader(obj1);

            obj2.CreateBlogAL();

            MessageBox.Show("Blog Saved as Draft Successfully!");
        }

        private void siticonePictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
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
                txtContentEdit.AppendText(textBox.Text + " ");
            }
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
                txtContentEdit.Paste();
            }
        }

        private void pbox6_Click(object sender, EventArgs e)
        {
            string imagePath = "";

            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (obj.ShowDialog() == DialogResult.OK)
            {
                imagePath = obj.FileName;   // Full path
                pbox6.ImageLocation = imagePath;
                //btnSelectFiles.ImageLocation = imagePath;
                btnSelectFilesEdit.Text = imagePath;

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
                btnSelectFilesEdit.Text = dbImagePath;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContentEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxAuthornameEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PBblodedit_Click(object sender, EventArgs e)
        {
            if (txtContentEdit.SelectionFont != null)
            {
                Font currentFont = txtContentEdit.SelectionFont;
                FontStyle newFontStyle;
                if (currentFont.Bold)
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                else
                    newFontStyle = currentFont.Style | FontStyle.Bold;

                txtContentEdit.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size,
                    newFontStyle
                );
            }
        }

        private void pbItalicedit_Click(object sender, EventArgs e)
        {
            if (txtContentEdit.SelectionFont != null)
            {
                Font f = txtContentEdit.SelectionFont;
                FontStyle style = f.Italic ? f.Style & ~FontStyle.Italic : f.Style | FontStyle.Italic;
                txtContentEdit.SelectionFont = new Font(f, style);
            }
        }

        private void btnRemoveEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to remove all data?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning );

            if (result == DialogResult.No)
                return;

            txtTitleEdit.Text = string.Empty;

            // Category dropdown clear
            cmbbxCategoryEdit.SelectedIndex = -1;
            cmbbxAuthornameEdit.SelectedIndex = -1;
            
            txtContentEdit.Clear();  

            btnSelectFilesEdit.Text = "SelectFiles";
                       
            btnMakeVisibleToAll.Checked = false;
           
            txtTitleEdit.Focus();
        }
    }
}
