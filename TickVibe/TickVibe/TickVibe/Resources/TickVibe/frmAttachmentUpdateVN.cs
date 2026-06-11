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
using TickVibeLib;

namespace TickVibe
{
    public partial class frmAttachmentShowVN : Form
    {
        public frmAttachmentShowVN(string Tktcode, string EMPCode, string user, string email, long contact, string priority, string category, string subject, string status, string description, DateTime createdAt, string attachment,string companyname)
        {
            InitializeComponent();
            lblTC.Text = Tktcode;
            lblEMPCode.Text = EMPCode;
            lblNameView.Text = user;
            lblEmailView.Text = email;
            lblContactView.Text = contact.ToString();
            lblPriorityView.Text = priority;
            lblCategoryView.Text = category;
            lblSubjectView.Text = subject;
            lblStatusView.Text = status;
            lblDescriptionView.Text = description;
            lblCreatedAtView.Text = createdAt.ToString();
            lblAttachmentView.Text = attachment;
            lblCompanyName.Text = companyname;
            if (!string.IsNullOrEmpty(attachment) && File.Exists(attachment))
            {
                picbAttachment.Image = Image.FromFile(attachment);
            }
            else
            {
                picbAttachment.Image = null; // shows blank space if no image
            }
        }

        private void frmAttachmentShowVN_Load(object sender, EventArgs e)
        {
             
        }

        private void picbAttachment_Click(object sender, EventArgs e)
        {
            

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            //       DialogResult result = MessageBox.Show(
            //"Do you want to replace the existing attachment?",
            //  "Update Attachment",
            //  MessageBoxButtons.YesNoCancel,
            //      MessageBoxIcon.Question
            //            );

            //       if (result == DialogResult.Yes)
            //       {

            //       }
            //       else if(result== DialogResult.No)
            //       {

            //           long contact = Convert.ToInt64(lblContactView.Text);
            //           DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
            //           frmUpdateTicketsVN obj = new frmUpdateTicketsVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, lblDescriptionView.Text, date, lblAttachmentView.Text, lblCompanyName.Text);

            //           obj.Show();
            //           this.Hide();
            //       }
            
            long contact = Convert.ToInt64(lblContactView.Text);
            DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
            frmUpdateTicketsVN obj2 = new frmUpdateTicketsVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, lblDescriptionView.Text, date, lblAttachmentView.Text, lblCompanyName.Text);

            obj2.Show();

            this.Close();
          

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|*.png|*.PNG Image";
            if (obj.ShowDialog() == DialogResult.OK)
            {
                picbAttachment.Image = new Bitmap(obj.FileName);
                lblAttachmentView.Text = obj.FileName;

                
            }
            long contact = Convert.ToInt64(lblContactView.Text);
            DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
            frmUpdateTicketsVN obj2 = new frmUpdateTicketsVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, lblDescriptionView.Text, date, lblAttachmentView.Text, lblCompanyName.Text);

            obj2.Show();

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblAttachmentView.Text = "";
            long contact = Convert.ToInt64(lblContactView.Text);
            DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
            frmUpdateTicketsVN obj = new frmUpdateTicketsVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, lblDescriptionView.Text, date, lblAttachmentView.Text, lblCompanyName.Text);

            obj.Show();
            this.Close();
        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picbAttachment_Click_1(object sender, EventArgs e)
        {

        }
    }
}
