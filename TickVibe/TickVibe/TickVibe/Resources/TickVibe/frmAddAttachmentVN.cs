using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TickVibe
{
    public partial class frmAddAttachmentVN : Form
    {
         

        public frmAddAttachmentVN(string EMPCode,string catogry,string priority,string subject,string attachment)
        {
            InitializeComponent();
            lblCatogry.Text = catogry;
            lblPriority.Text = priority;
            lblSubject.Text = subject;
            lblEMPCode.Text = EMPCode;
            lblFilePath.Text = attachment;
                picbAttachment.Image = Image.FromFile(attachment);
            
        }
        //here user can add attachment for ticket
        private void picbAttachment_Click(object sender, EventArgs e)
        {
             

            //OpenFileDialog obj = new OpenFileDialog();
            //obj.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|*.png|*.PNG Image";
            //if (obj.ShowDialog() == DialogResult.OK)
            //{
            //    picbAttachment.Image = new Bitmap(obj.FileName);
            //    lblFilePath.Text = obj.FileName;
            //}
        }

        //going back to previous page 
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttechment_Click(object sender, EventArgs e)
        {

            frmCreateTicketVN obj = new frmCreateTicketVN(lblEMPCode.Text, lblFilePath.Text, lblCatogry.Text, lblPriority.Text, lblSubject.Text);

            obj.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filepath = lblFilePath.Text = "";
            frmCreateTicketVN obj = new frmCreateTicketVN(lblEMPCode.Text, filepath, lblCatogry.Text, lblPriority.Text, lblSubject.Text);

            obj.Show();
            this.Close();
        }

        private void frmAddAttachmentVN_Load(object sender, EventArgs e)
        {

        }
    }
}
