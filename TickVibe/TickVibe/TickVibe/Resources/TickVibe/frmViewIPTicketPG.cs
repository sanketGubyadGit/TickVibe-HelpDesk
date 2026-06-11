using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms.Suite;
using TickVibeLib;



namespace TickVibe
{

    public partial class frmViewIPTicketPG : Form
    {
        string path;
        string TktCode;
        public frmViewIPTicketPG(string tktcode, string usercode)
        {
            InitializeComponent();
            this.TktCode = tktcode;
            //lblEMPCode.Text = usercode;
            this.BackColor = Color.FromArgb(240, 242, 245);

            

        }



        private void frmViewIPTicketPG_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            obj.TktCode = TktCode;

            clsTeamLeader obj1 = new clsTeamLeader(obj);
            SqlDataReader dr = obj.FetchAllViewPG();

            if (dr.Read())
            {


                DateTime dt = Convert.ToDateTime(dr["CreatedAt"]);
                lblTicketCode1.Text = dr["TktCode"].ToString();
                lblName1.Text = dr["FullName"].ToString();
                lblEmail1.Text = dr["Email"].ToString();
                lblContact1.Text = dr["ContactNo"].ToString();
                lblPriority1.Text = dr["PriorityName"].ToString();
                lblCategory1.Text = dr["CategoryName"].ToString();
                lblSubject1.Text = dr["SubName"].ToString();
                lblCreatedOn1.Text = dt.ToString("dd-MM-yyyy");
                txtDescription.Text = dr["Description"].ToString();
                lblAttachment1.Text = dr["FileName"].ToString();
                lblStatus1.Text = dr["StatusName"].ToString();
                path = dr["FilePath"].ToString();


                //MessageBox.Show("Image Path : " + path);

                //string filename = lblAttachment1.Text;

                //string path = @"E:\RAHITCH .NET\TickVibe\TickVibe\Content\img\" + filename;

                //if (System.IO.File.Exists(path))
                //{
                //    pcbimage.Image = Image.FromFile(path);
                //}


            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAttachment1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = lblAttachment1.Text;
            pcbimage.Image = Image.FromFile(path);
            //string path = @"E:\TicketingToolFinalMergeProject\TickVibe\TickVibe\TickVibe\Content\img\" + filename;


            //if (System.IO.File.Exists(path))
            //{
            //    pcbimage.Image = Image.FromFile(path);
            //}
            //else
            //{
            //    MessageBox.Show("Image not found: " + path);
            //}
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtDescription.ReadOnly = true;
        }

        private void pnlPTViewTicket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCreatedOn_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pcbimage_Click(object sender, EventArgs e)
        {

        }

        private void lblAttachment1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Attachment path is empty.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!File.Exists(path))
                {
                    MessageBox.Show("Image file not found.\n\n" + path,
                        "File Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Release old image if already loaded
                if (pcbimage.Image != null)
                {
                    pcbimage.Image.Dispose();
                    pcbimage.Image = null;
                }

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pcbimage.Image = Image.FromStream(fs);
                }

                pcbimage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load image.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDescription_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblAttachment_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblCreatedOn1_Click(object sender, EventArgs e)
        {

        }

        private void lblCreatedOn_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSubject1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblPriority1_Click(object sender, EventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }

        private void lblContact1_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblTicketCode1_Click(object sender, EventArgs e)
        {

        }

        private void lblTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void lblTicketDetails_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}