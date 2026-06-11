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
using System.Data.SqlClient;

namespace TickVibe
{
    public partial class frmCreateTicketVN : Form
    {
        string catValue;
        string propValue;
        string subValue;

        public frmCreateTicketVN(string Usercode,string FilePath,string cat,string prop,string sub)
        {
            InitializeComponent();
            lblEMPCode.Text = Usercode;
            lblFilepath.Text = FilePath;
            catValue = cat;
            propValue = prop;
            subValue = sub;
           
        }
        // fetch data for make changes in raise ticket 
        //fetch data from tblSubject to add subject
        //fetch data from tblCategory add category 
        //fetch  data from tblPriority give priority

        private void frmCreateTicketVN_Load(object sender, EventArgs e)
        {

            clsTeamLeader con = new clsTeamLeader();
            SqlDataReader dr;
            con.UserCode = lblEMPCode.Text;
            dr = con.FullNameContactVN();
            if (dr.Read())
            {
                long contact = Convert.ToInt64(dr["ContactNo"]);
                string name = dr["FullName"].ToString();
                string email = dr["Email"].ToString();
              
                txtContact.Text = contact.ToString();
                txtEmail.Text = email;
                txtName.Text = name;
                 
            
            }
             
            txtCreatedAt.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
 
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

            cmbbxCategory.Text = null;
            cmbbxPriority.Text = null;
            cmbbxSubject.Text = null;

            if (!string.IsNullOrEmpty(catValue))
                cmbbxCategory.SelectedValue = catValue;

            if (!string.IsNullOrEmpty(propValue))
                cmbbxPriority.SelectedValue = propValue;

            if (!string.IsNullOrEmpty(subValue))
                cmbbxSubject.SelectedValue = subValue;
        }
 
   
        private void cmbbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         

        private void lblExit_Click(object sender, EventArgs e)
        {
            
          
            this.Close();
             
        }
         
        

        private void lblcategory_Click(object sender, EventArgs e)
        {

        } 
 
        private void panCreateTicket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbbxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long contact = Convert.ToInt64(txtContact.Text);
            frmViewTicketVN obj = new frmViewTicketVN(lblEMPCode.Text, contact, lblName.Text, lblEmail.Text);
            obj.Show();
            this.Close();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            lblFilepath.Text = null;
            cmbbxCategory.Text = null;
            cmbbxPriority.Text = null;
            cmbbxSubject.Text = null;
            txtDescription.Clear();

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || cmbbxCategory.Text == "" || cmbbxPriority.Text == "" || cmbbxSubject.Text == "")
            {
                MessageBox.Show("Please enter the required information.", "Selection Required",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            }
            else
            {


                string FilePath = "FilePath";
                if (lblFilepath.Text == FilePath)
                {
                    lblFilepath.Text = null;
                }


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
                int statusid = 1;
                DateTime CreateAt = DateTime.Now;
                long contact = Convert.ToInt64(txtContact.Text);
                clsTeamLeader obj = new clsTeamLeader();
                obj.Createby = lblEMPCode.Text;
                obj.CategoryId = category;
                obj.Priorityid = priorityid;
                obj.Statusid = statusid;
                obj.Description = txtDescription.Text;
                obj.CreateAt = CreateAt;
                obj.Subjectid = subid;
                obj.Contact = contact;
                obj.FileName = FileName;
                obj.Filepath = lblFilepath.Text;
                obj.Uploadedby = lblEMPCode.Text;
                obj.UploadedAt = CreateAt;
                obj.insertTicketVN();

                MessageBox.Show(
                           "Ticket created! We’ll start working on it right away.",
                          "Success",
                            MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                lblFilepath.Text = null;
                cmbbxCategory.Text = null;
                cmbbxPriority.Text = null;
                cmbbxSubject.Text = null;
                txtDescription.Clear();

            }

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {

            if (cmbbxCategory.SelectedValue == null || cmbbxPriority.SelectedValue == null || cmbbxSubject.SelectedValue == null)
            {
                MessageBox.Show("Please enter the required information.", "Selection Required",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            }
            else if (lblFilepath.Text != "")
            {

                string catogry = cmbbxCategory.SelectedValue.ToString();
                string priority = cmbbxPriority.SelectedValue.ToString();
                string subject = cmbbxSubject.SelectedValue.ToString();
                frmAddAttachmentVN obj1 = new frmAddAttachmentVN(lblEMPCode.Text, catogry, priority, subject, lblFilepath.Text);
                obj1.Show();
            }
            else
            {
                OpenFileDialog obj = new OpenFileDialog();
                obj.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|*.png|*.PNG Image";
                if (obj.ShowDialog() == DialogResult.OK)
                {

                    string FilePath = obj.FileName;
                    string catogry = cmbbxCategory.SelectedValue.ToString();
                    string priority = cmbbxPriority.SelectedValue.ToString();
                    string subject = cmbbxSubject.SelectedValue.ToString();
                    frmAddAttachmentVN obj1 = new frmAddAttachmentVN(lblEMPCode.Text, catogry, priority, subject, FilePath);

                    obj1.Show();

                }


            }
        }
 
        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            frmAddNewSubjectVN obj = new frmAddNewSubjectVN(lblEMPCode.Text, lblFilepath.Text, catValue, propValue, subValue);
            obj.Show();
            this.Close();
        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
