using Siticone.UI.WinForms.Suite;
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
using System.IO;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
namespace TickVibe
{
    public partial class frmAddAgentRN : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S769TUP9;Initial Catalog=TickVibe;Integrated Security=True");
        public frmAddAgentRN(int categoryid,string EMPCode)
        {
            InitializeComponent();
            lblCategory.Text = categoryid.ToString();
            lblEmpCode.Text = EMPCode;
        }
        



        private void frmAddAgentRN_Load(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry.SelectedValue);
            clsTeamLeader obj = new clsTeamLeader();
            obj.countryId = countryId;
            DataTable dt = obj. ShowCountryRN();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;



        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbbxCountry.SelectedValue);

            clsTeamLeader obj = new clsTeamLeader();
            obj.countryId = countryId;
            DataTable dt = obj.ShowStatesRN();
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DataSource = dt;

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxState.SelectedValue != null)
            {
                int stateId = Convert.ToInt32(cmbbxState.SelectedValue);

                clsTeamLeader obj3 = new clsTeamLeader();
                obj3.stateid = stateId;

                DataTable dt = obj3.ShowCityRN();

                cmbbxCity.DisplayMember = "CityName";
                cmbbxCity.ValueMember = "CityId";
                cmbbxCity.DataSource = dt;
            }
        }

        private void pcbProfilePhoto_Click(object sender, EventArgs e)
        {
            string imagePath = "";


            {
                OpenFileDialog obj = new OpenFileDialog();
                obj.Filter = "Image Files|*.jpg;*.png;*.jpeg";

                if (obj.ShowDialog() == DialogResult.OK)
                {
                    imagePath = obj.FileName;          // image cha FULL path
                    pcbProfilePhoto.ImageLocation = imagePath;
                    lblimgpath.Text = imagePath;
                }
            }


        }





        private void btnAddAgentSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                //clsTeamLeader obj = new clsTeamLeader();

                //string userCode = obj.GetUserCodeRN();




                //con.Open();
                //SqlCommand cmd = new SqlCommand("SpTickVibe", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Flag", "UserCodeStoreRN");
                //cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
                //cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

                //string userCode = cmd.ExecuteScalar().ToString();

                //con.Close();

                string filename = "Profile.jpeg";

                string company = "COMP001";
                int Categoryid = 7;
                int active = 1;
                int role = 3;
                int pin = Convert.ToInt32(txtPinCode.Text);
                long contact = Convert.ToInt64(txtContactNo.Text);
                int city = Convert.ToInt32(((DataRowView)cmbbxCity.SelectedItem)["CityId"]);
                DateTime date = dtpCreatedAt.Value;
                DateTime DateofBirth =dtpBirthDate.Value;

                clsTeamLeader obj1 = new clsTeamLeader();
                // obj1.UserCode = userCode;
                obj1.FullName = txtAgentName.Text;
                obj1.Email = txtEmailId.Text;
                obj1.Password = txtPassword.Text;
                obj1.RoleId = role;
                obj1.CategoryId = Categoryid;
                obj1.Active = active;
                obj1.ContactNo = contact;
                obj1.CityId = city;
                obj1.CreatedAt = date;
                obj1.DateofBirth = DateofBirth;
                obj1.CompCode = company;
                obj1.Address = txtAddress.Text;
                obj1.PinCode = pin;
                //obj1.TEBCode = userCode;
                obj1.FileName = filename;
                obj1.FilePath = lblimgpath.Text;
                obj1.UploadedBy = lblEmpCode.Text;
                obj1.UploadedAt = date;

                //clsTeamLeader obj2 = new clsTeamLeader(obj1);


                //new
                string sourcePath = lblimgpath.Text;

                string fileName = Path.GetFileName(sourcePath);

                string destFolder = Path.Combine(Application.StartupPath, "TickVibe", "Content", "img");

                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                string destPath = Path.Combine(destFolder, fileName);

                File.Copy(sourcePath, destPath, true);

                obj1.FileName = fileName;
                obj1.FilePath = @"TickVibe\Content\img\" + fileName;


                obj1.AddAgentFrmRN();
                MessageBox.Show("Agent Added Succesfully");
                
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
             

            







            //VALIDATION IN AGENT//

            {


                if (string.IsNullOrWhiteSpace(txtAgentName.Text))
                {
                    MessageBox.Show("Enter Agent Name");
                    return;
                }

                if (txtContactNo.Text.Length != 10 || !long.TryParse(txtContactNo.Text, out _))
                {
                    MessageBox.Show("Contact number must be 10 digits");
                    return;
                }

                if (!txtEmailId.Text.Contains("@"))
                {
                    MessageBox.Show("Enter valid Email");
                    return;
                }


                if (pcbProfilePhoto.Image == null)
                {
                    MessageBox.Show("Select Profile Photo");
                    return;
                }

                if (txtPinCode.Text.Length != 6)
                {
                    MessageBox.Show("Enter valid Pin Code");
                    return;
                }
                txtAgentName.Clear();
                txtEmailId.Clear();
                txtContactNo.Clear();
                txtPassword.Clear();
                txtAddress.Clear();
                txtPinCode.Clear();

                cmbbxCountry.SelectedIndex = -1;
                cmbbxState.SelectedIndex = -1;
                cmbbxCity.SelectedIndex = -1;

                pcbProfilePhoto.Image = null;

                frmMemberManagementRN obj = new frmMemberManagementRN(lblEmpCode.Text, Convert.ToInt32(lblCategory.Text));
                obj.Show();
                // MessageBox.Show("All validation passed!");
            }

        }
        
        
            
        private void pnladdagent2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCreatedAt_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPinCode.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Only numbers allowed");
                txtPinCode.Text = "";
            }



        }

        private void btnAddAgentClear_Click(object sender, EventArgs e)
        {
            //frmMemberManagementRN obj = new frmMemberManagementRN(lblEmpCode.Text, Convert.ToInt32(lblCategory.Text));
            //obj.Show();
            cmbbxCity.Text = null;
            cmbbxState.Text = null;
            cmbbxCountry.Text = null;
            txtAgentName.Text = null;
            txtContactNo.Text = null;
            txtEmailId.Text = null;
            txtPinCode.Text = null;
            txtAddress.Text = null;
            pcbProfilePhoto.Image = null;
            txtPassword.Text = null;

            txtAgentName.Clear();
            txtEmailId.Clear();
            txtContactNo.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtPinCode.Clear();

            cmbbxCountry.SelectedIndex = -1;
            cmbbxState.SelectedIndex = -1;
            cmbbxCity.SelectedIndex = -1;

            pcbProfilePhoto.Image = null;

            //dateTimePicker1.Value = DateTime.Now;


        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            int category=Convert.ToInt32(lblCategory.Text);
            frmMemberManagementRN obj = new frmMemberManagementRN(lblEmpCode.Text, category);
            obj.Show();
            this.Hide();
        }

        private void lblEmailId_Click(object sender, EventArgs e)
        {

        }

        private void lblAgentName_Click(object sender, EventArgs e)
        {

        }

        private void lblDateofBirth_Click(object sender, EventArgs e)
        {

        }

        private void dtpCreatedAt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPinCode_Click(object sender, EventArgs e)
        {

        }

        private void lblProfilePhoto_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
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

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtAgentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
            
           
        }
    }
}