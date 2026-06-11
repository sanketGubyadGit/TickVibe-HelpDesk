using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmViewAgentRN : Form
    {
        string UserCode;

        public frmViewAgentRN(string UserCode,int category)
        {
            InitializeComponent();

            this.UserCode = UserCode;
            lblcategory.Text = category.ToString();
            
        }

        private void frmViewAgentRN_Load(object sender, EventArgs e)
        {
            
           

            clsTeamLeader obj = new clsTeamLeader();
            obj.UserCode = UserCode;
            DataTable dt = obj.VAgentRN();


            if (dt.Rows.Count > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    lblFullName.Text = dt.Rows[0]["FullName"].ToString();
                    lblUserCode.Text = dt.Rows[0]["UserCode"].ToString();
                    lblEmail.Text = dt.Rows[0]["Email"].ToString();
                    long contact = Convert.ToInt64(dt.Rows[0]["ContactNo"]);
                    lblContactNo.Text = contact.ToString();

                    lblCountry.Text = dt.Rows[0]["CountryName"].ToString();
                    lblState.Text = dt.Rows[0]["StateName"].ToString();
                    lblCity.Text = dt.Rows[0]["CityName"].ToString();
                    lblFileName.Text = dt.Rows[0]["FileName"].ToString();
                    lblAddress.Text = dt.Rows[0]["Address"].ToString();
                    int pin = Convert.ToInt32(dt.Rows[0]["PinCode"]);
                    lblPinCode.Text = pin.ToString();
                    lblDateofBirth1.Text = Convert.ToDateTime(dt.Rows[0]["DateofBirth"]).ToString("dd/MM/yyyy");
                }

            }
        }

        private void pnlViewAgent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVAgent_Click(object sender, EventArgs e)
        {
            int cat = Convert.ToInt32(lblcategory.Text);
            frmMemberManagementRN obj = new frmMemberManagementRN(UserCode, cat);
            obj.Show();
            this.Close();
        }

        private void lblDateofBirth1_Click(object sender, EventArgs e)
        {

        }

        private void lblPinCode_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblFileName_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUserCode_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
    }
}