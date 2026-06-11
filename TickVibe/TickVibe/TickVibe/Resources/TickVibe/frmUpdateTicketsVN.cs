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
using System.IO;
namespace TickVibe
{
    public partial class frmUpdateTicketsVN : Form
    {
       
        public frmUpdateTicketsVN(string Tktcode,string EMPCode,string user, string email, long contact, string priority, string category, string subject, string status, string description, DateTime createdAt, string attachment,string companyname)
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
            txtDescription.Text = description;
            lblCreatedAtView.Text = createdAt.ToString();
            lblAttachmentView.Text = attachment;
            lblCompanyName.Text = companyname;
        }
        //exit from frmUpdateTicketVN and go back to Previous page
        private void lblExit_Click(object sender, EventArgs e)
        {
            long contact = Convert.ToInt64(lblContactView.Text);

            this.Close();
            frmViewTicketVN obj = new frmViewTicketVN(lblEMPCode.Text, contact, lblNameView.Text, lblEmailView.Text);
            obj.Show();
             
        }
        // fetch data for make changes in raised ticket 
        //fetch data from tblSubject to change subject
        //fetch data from tblCategory change category 
        //fetch  data from tblPriority change priority

        private void frmUpdateTicketsVN_Load(object sender, EventArgs e)
        {
           
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt;
            dt = obj.FetchSubjetVN();

            cmbbxSubject.DataSource = dt;
            cmbbxSubject.DisplayMember = "SubName";
            cmbbxSubject.ValueMember = "SubId";

            clsTeamLeader bj = new clsTeamLeader();
            DataTable td;
            td = bj.FetchPriorityVN();

            cmbbxPriority.DataSource = td;
            cmbbxPriority.DisplayMember = "PriorityName";
            cmbbxPriority.ValueMember = "PriorityId";

            clsTeamLeader cb = new clsTeamLeader();
            DataTable cdt;
            cdt = cb.FetchCategoryVN();

            cmbbxCategory.DataSource = cdt;
            cmbbxCategory.DisplayMember = "CategoryName";
            cmbbxCategory.ValueMember = "CategoryId";

            cmbbxCategory.Text =lblCategoryView.Text;
            cmbbxPriority.Text = lblPriorityView.Text;
            cmbbxSubject.Text = lblSubjectView.Text;

        }

        //when user click on btnsubmit it will store data in tblAttachment 
        //in attachment table it will change file name if ticket category change  file path change  if attachment change 
        //and also store data in tblticket 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string General = "General";
            string Support = "Support";
            string Advertising = "Advertising";
            string Billing = "Billing";
            string Hardware = "Hardware";
            string Technical = "Technical";
            string Software = "Software";
            string FileName = "";
            string cmb = (((DataRowView)cmbbxCategory.SelectedItem)["CategoryName"].ToString());
            if (cmb == General)
            {
                FileName = "General.jpg";
            }
            else if (cmb == Support)
            {
                FileName = "Support.jpg";
            }
            else if (cmb == Advertising)
            {
                FileName = "Advertising.jpg";
            }
            else if (cmb == Billing)
            {
                FileName = "Billing.jpg";
            }
            else if (cmb == Hardware)
            {
                FileName = "Hardware.jpg";
            }
            else if (cmb == Technical)
            {
                FileName = "Technical.jpg";
            }
            else if (cmb == Software)
            {
                FileName = "Software.jpg";
            }
            else
            {
                MessageBox.Show("check the filename");
            }
            int subid = Convert.ToInt32(cmbbxSubject.SelectedValue);
            int priorityid = Convert.ToInt32(cmbbxPriority.SelectedValue);
            int category = Convert.ToInt32(cmbbxCategory.SelectedValue);
            clsTeamLeader obj = new clsTeamLeader();
            obj.TktCode = lblTC.Text;
            obj.Filepath =lblAttachmentView.Text;
            obj.FileName = FileName;
            obj.CategoryId = category;
            obj.Priorityid= priorityid;
            obj.Description= txtDescription.Text;
            obj.Subjectid= subid;
            obj.UpdateTicketVN();
            MessageBox.Show("Attachment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // it will show the added attachment to next from  
        //from their can change  and view added attachment
        
        private void btnView_Click(object sender, EventArgs e)
        { 
            

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {

            if (lblAttachmentView.Text != "")
            {
                
                long contact = Convert.ToInt64(lblContactView.Text);
                DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
                frmAttachmentShowVN obj = new frmAttachmentShowVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, txtDescription.Text, date, lblAttachmentView.Text, lblCompanyName.Text);
                obj.Show();
                this.Close();


            }
            else if (lblAttachmentView.Text == "")
            {
                
                lblAttachmentView.Text = "";
                long contact = Convert.ToInt64(lblContactView.Text);
                DateTime date = Convert.ToDateTime(lblCreatedAtView.Text);
                frmAttachmentShowVN obj = new frmAttachmentShowVN(lblTC.Text, lblEMPCode.Text, lblNameView.Text, lblEmailView.Text, contact, lblPriorityView.Text, lblCategoryView.Text, lblSubjectView.Text, lblStatusView.Text, txtDescription.Text, date, lblAttachmentView.Text, lblCompanyName.Text);
                obj.Show();
                this.Close();


            }

        }

        private void lblCreatedAt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

            string General = "General";
            string Support = "Support";
            string Advertising = "Advertising";
            string Billing = "Billing";
            string Hardware = "Hardware";
            string Technical = "Technical";
            string Software = "Software";
            string FileName = "";
            string cmb = (((DataRowView)cmbbxCategory.SelectedItem)["CategoryName"].ToString());
            if (cmb == General)
            {
                FileName = "General.jpg";
            }
            else if (cmb == Support)
            {
                FileName = "Support.jpg";
            }
            else if (cmb == Advertising)
            {
                FileName = "Advertising.jpg";
            }
            else if (cmb == Billing)
            {
                FileName = "Billing.jpg";
            }
            else if (cmb == Hardware)
            {
                FileName = "Hardware.jpg";
            }
            else if (cmb == Technical)
            {
                FileName = "Technical.jpg";
            }
            else if (cmb == Software)
            {
                FileName = "Software.jpg";
            }
            else
            {
                MessageBox.Show("check the filename");
            }
            int subid = Convert.ToInt32(cmbbxSubject.SelectedValue);
            int priorityid = Convert.ToInt32(cmbbxPriority.SelectedValue);
            int category = Convert.ToInt32(cmbbxCategory.SelectedValue);
            clsTeamLeader obj = new clsTeamLeader();
            obj.TktCode = lblTC.Text;
            obj.Filepath = lblAttachmentView.Text;
            obj.FileName = FileName;
            obj.CategoryId = category;
            obj.Priorityid = priorityid;
            obj.Description = txtDescription.Text;
            obj.Subjectid = subid;
            obj.UpdateTicketVN();
            MessageBox.Show("Attachment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // it will show the added attachment to next from  
        //from their can change  and view added attachment




        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbbxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNameView_Click(object sender, EventArgs e)
        {

        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }
    }
}
