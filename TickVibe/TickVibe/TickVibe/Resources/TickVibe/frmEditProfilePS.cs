using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TickVibe
{
    public partial class frmEditProfilePS : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();

        public string UserCode { get; set; }


        public frmEditProfilePS(string UCode)
        {
            InitializeComponent();
            UserCode = UCode;

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Address required");
                txtAddress.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAddress, "");
            }
            if (string.IsNullOrWhiteSpace(txtEmailID.Text))
            {
                errorProvider1.SetError(txtEmailID, "EmailID required");
                txtEmailID.Focus();

                return;
            }
            else
            {
                errorProvider1.SetError(txtContactNo, "");
            }
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                errorProvider1.SetError(txtContactNo, "ContactNo required");
                txtContactNo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtPinCode, "");
            }
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                errorProvider1.SetError(txtPinCode, "PinCode required");
                txtPinCode.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtPinCode, "");
            }



            if (txtContactNo.Text.Length != 10)
            {
                MessageBox.Show("Contact Number must be exactly 10 digits");
                txtContactNo.Focus();
                return;
            }
            if (txtPinCode.Text.Length != 6)
            {
                MessageBox.Show("Pincode must be exactly 6 digits");
                txtPinCode.Focus();
                return;
            }
            {
                clsTeamLeader obj1 = new clsTeamLeader();

                clsTeamLeader obj = new clsTeamLeader(obj1);
                obj.UserCode = UserCode;
                obj.Name = txtName.Text;
                obj.EmailId = txtEmailID.Text;
                obj.ContactNo = Convert.ToInt64(txtContactNo.Text);
                string filename = lblEProfile.Text;
                obj.FileName = filename;
                //obj.FilePath = txtProfilePhoto.Text;
                //obj.FilePath = pcbEditProfile.ImageLocation;
                obj.FilePath = pcbEditProfile.ImageLocation;
                obj.PINCODE = Convert.ToInt32(txtPinCode.Text);
                obj.CountryName = cmbbxCountry.Text;
                obj.StateName = cmbbxState.Text;
                obj.CityName = cmbbxCity.Text;
                obj.Address = txtAddress.Text;
                obj.UpdateProfilePS();

                MessageBox.Show("Profile Updated Successfully");

               
            }
        }




        private void frmEditProfilePS_Load(object sender, EventArgs e)
        {
            //panel1.Visible = true;


            cmbbxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbxState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbxCity.DropDownStyle = ComboBoxStyle.DropDownList;



            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.FetchCountryPS();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                //clsTeamLeader obj2 = new clsTeamLeader(UserCode);  
                clsTeamLeader obj2 = new clsTeamLeader();
                obj2.UserCode = UserCode;
                clsTeamLeader obj3 = new clsTeamLeader(obj2);
                DataTable dt1 = obj3.fetchprofilePS();

                lblUCode.Text = dt1.Rows[0]["UserCode"].ToString();
                lblCCode.Text = dt1.Rows[0]["CompanyCode"].ToString();
                lblCName.Text = dt1.Rows[0]["CompanyName"].ToString();
                txtName.Text = dt1.Rows[0]["Name"].ToString();
                txtEmailID.Text = dt1.Rows[0]["EmailId"].ToString();
                txtContactNo.Text = dt1.Rows[0]["ContactNo"].ToString();
                cmbbxCountry.Text = dt1.Rows[0]["CountryName"].ToString();
                cmbbxState.Text = dt1.Rows[0]["StateName"].ToString();
                cmbbxCity.Text = dt1.Rows[0]["CityName"].ToString();
                txtProfilePhoto.Text = dt1.Rows[0]["FilePath"].ToString();
                txtAddress.Text = dt1.Rows[0]["Address"].ToString();
                txtPinCode.Text = dt1.Rows[0]["PinCode"].ToString();
                lblEPFilePath.Text = dt1.Rows[0]["FileName"].ToString();
                //string filename = dt1.Rows[0]["FileName"].ToString();
                ////string fileName = dt1.Rows[0]["FilePath"].ToString();
                //string path = Path.Combine(Application.StartupPath, "TickVibe", "Content", "img", filename);
                //if (File.Exists(path))
                //{
                //    pcbEditProfile.Image = Image.FromFile(path);
                //}
                string imagePath = dt1.Rows[0]["FilePath"].ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pcbEditProfile.ImageLocation = imagePath;
                    pcbEditProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Image not found : " + imagePath);
                }


            }
        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbbxCountry.SelectedValue != null && int.TryParse(cmbbxCountry.SelectedValue.ToString(), out int cId))
            {
                clsTeamLeader obj = new clsTeamLeader();
                obj.CountryId = cId;

                DataTable dt = obj.FetchStatePS();

                cmbbxState.DisplayMember = "StateName";
                cmbbxState.ValueMember = "StateId";
                cmbbxState.DataSource = dt;
            }
        }
        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbbxState.SelectedValue != null && int.TryParse(cmbbxState.SelectedValue.ToString(), out int sId))
            {
                clsTeamLeader obj = new clsTeamLeader();
                obj.StateId = sId;
                DataTable dt = obj.FetchCityPS();

                cmbbxCity.DisplayMember = "CityName";
                cmbbxCity.ValueMember = "CityId";
                cmbbxCity.DataSource = dt;
            }
        }



        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("only numbers allow ");
            }



        }



        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Only Aplhabets are allowed");
            }

        }

        private void txtEmailID_Leave(object sender, EventArgs e)
        {



            if (!txtEmailID.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com");
                txtEmailID.Focus();
            }
        }

        private void txtPinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("only numbers allow ");
            }


        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
        !char.IsControl(e.KeyChar) &&
        e.KeyChar != ' ' &&
        e.KeyChar != ',' &&
        e.KeyChar != '.' &&
        e.KeyChar != '/' &&
        e.KeyChar != '-' &&
        e.KeyChar != '#')
            {
                e.Handled = true;

            }
        }

        private void txtUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lblUserCode.Text.Length < 3)
            {

                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void lblEditPeofileSetting_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //panel2.Visible = !panel2.Visible;
        }

        private void txtProfilePhoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcbEditProfile_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            {
                OpenFileDialog obj = new OpenFileDialog();

                obj.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (obj.ShowDialog() == DialogResult.OK)
                {


                    imagePath = obj.FileName;
                    pcbEditProfile.ImageLocation = imagePath;
                    lblEProfile.Text = imagePath;
                    lblEProfile.Text = System.IO.Path.GetFileName(imagePath);
                }
            }
        }

        private void lblEPFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string filename = lblEProfile.Text;
            string path = Path.Combine(Application.StartupPath, "TickVibe", "Content", "img", filename);
            if (File.Exists(path))
            {
                pcbEditProfile.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Image not found:" + path);
            }
        }



        private void lblCCode_Click(object sender, EventArgs e)
        {

        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
