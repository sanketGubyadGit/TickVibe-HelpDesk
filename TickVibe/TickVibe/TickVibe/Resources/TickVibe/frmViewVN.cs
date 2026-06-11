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
    public partial class frmViewVN : Form
    {
        public frmViewVN(string EMPCode,string user,string email,long contact,string priority,string category,string subject,string status,string description,DateTime createdAt,string attachment,string companyname)
        {
            InitializeComponent();
            lblEMPCode.Text = EMPCode;
            lblNameView.Text = user;
            lblEmailView.Text = email;
            lblContactView.Text = contact.ToString();
            lblPriorityView.Text = priority;
            lblCategoryView.Text = category;
            txtSubjectView.Text = subject;
            lblStatusView.Text = status;
           txtDescriptionView.Text = description;
            lblCreatedAtView.Text = createdAt.ToString();
            lblFilepath.Text = attachment;
            lblCompanyName.Text = companyname;
        }

        private void frmViewVN_Load(object sender, EventArgs e)
        {
            lblCategoryView.Focus();
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            long contact = Convert.ToInt64(lblContactView.Text);

             
            frmViewTicketVN obj = new frmViewTicketVN(lblEMPCode.Text,contact, lblNameView.Text,lblEmailView.Text);
            obj.Show();
            this.Hide();
        }
 
        private void lblStatusView_Click(object sender, EventArgs e)
        {

        }
         
        private void siticoneButton6_Click(object sender, EventArgs e)
        {

            frmAttachmentViewVN obj = new frmAttachmentViewVN(lblFilepath.Text);
            obj.Show();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPriorityView_Click(object sender, EventArgs e)
        {

        }
    }
}
