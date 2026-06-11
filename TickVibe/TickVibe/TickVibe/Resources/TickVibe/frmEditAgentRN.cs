using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;
namespace TickVibe
{
    public partial class frmEditAgentRN : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        string UserCode;


        public frmEditAgentRN(string usercode)
        {
            InitializeComponent();
             this.UserCode = usercode;
            
           
        }

        private void frmEditAgentRN_Load(object sender, EventArgs e)
        {



            // Load Country
            clsTeamLeader obj = new clsTeamLeader();
            DataTable dt = obj.ShowCountryRN();

            cmbbxCountryNameEAgent.DisplayMember = "CountryName";
            cmbbxCountryNameEAgent.ValueMember = "CountryId";
            cmbbxCountryNameEAgent.DataSource = dt;


            // Load Agent Data
            clsTeamLeader obj1 = new clsTeamLeader();
            obj1.UserCode = UserCode;
            DataTable dt1 = obj1.VAgentRN();




            if (dt1.Rows.Count > 0)
            {
                lblFullNameEAgent.Text = dt1.Rows[0]["FullName"].ToString();
               
                txtUserCodeEAgent.Text = dt1.Rows[0]["UserCode"].ToString();
                txtEmailEAgent.Text = dt1.Rows[0]["Email"].ToString();

                long contact = Convert.ToInt64(dt1.Rows[0]["ContactNo"]);
                txtContactNoEAgent.Text = contact.ToString();

                cmbbxCountryNameEAgent.Text = dt1.Rows[0]["CountryName"].ToString();
                cmbbxStateNameEAgent.Text = dt1.Rows[0]["StateName"].ToString();
                cmbbxCityNameEAgent.Text = dt1.Rows[0]["CityName"].ToString();

                lblEAgentFilePath.Text = dt1.Rows[0]["FileName"].ToString();

                txtAddressEAgent.Text = dt1.Rows[0]["Address"].ToString();

                int pin = Convert.ToInt32(dt1.Rows[0]["PinCode"]);
                txtPINCodeEAgent.Text = pin.ToString();
                string filePath = dt1.Rows[0]["FilePath"].ToString();

                string fullPath = Path.Combine(
                    Application.StartupPath,
                    filePath);

                if (File.Exists(fullPath))
                {
                    using (var bmpTemp = new Bitmap(fullPath))
                    {
                        pcbFEAgent.Image = new Bitmap(bmpTemp);
                    }
                }
                else
                {
                    MessageBox.Show("Image Not Found : " + fullPath);
                }
               
            }



        }

        private void siticoneComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxCountryNameEAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxCountryNameEAgent.SelectedValue != null)
            {
                int countryId = Convert.ToInt32(cmbbxCountryNameEAgent.SelectedValue);


                clsTeamLeader obj2 = new clsTeamLeader();
                obj2.countryId = countryId;
                clsTeamLeader obj3 = new clsTeamLeader(obj2);
                DataTable dt = obj3.ShowStatesRN();
                cmbbxStateNameEAgent.DisplayMember = "StateName";
                cmbbxStateNameEAgent.ValueMember = "StateId";
                cmbbxStateNameEAgent.DataSource = dt;
            }

        }

        private void cmbbxStateNameEAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxStateNameEAgent.SelectedValue != null)
            {
                int stateId = Convert.ToInt32(cmbbxStateNameEAgent.SelectedValue);

                clsTeamLeader obj3 = new clsTeamLeader();
                obj3.stateid = stateId;

                DataTable dt = obj3.ShowCityRN();

                cmbbxCityNameEAgent.DisplayMember = "CityName";
                cmbbxCityNameEAgent.ValueMember = "CityId";
                cmbbxCityNameEAgent.DataSource = dt;
            }
        }



        private void btnUpdateEAgent_Click(object sender, EventArgs e)
        {
            // VALIDATION FIRST

            if (string.IsNullOrWhiteSpace(txtEmailEAgent.Text) ||
                !txtEmailEAgent.Text.Contains("@"))
            {
                MessageBox.Show("Enter valid Email Id");
                txtEmailEAgent.Focus();
                return;
            }

            if (txtContactNoEAgent.Text.Length != 10 ||
                !long.TryParse(txtContactNoEAgent.Text, out _))
            {
                MessageBox.Show("Contact number must be 10 digits");
                txtContactNoEAgent.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddressEAgent.Text))
            {
                MessageBox.Show("Enter Address");
                txtAddressEAgent.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPINCodeEAgent.Text))
            {
                MessageBox.Show("Enter PIN Code");
                txtPINCodeEAgent.Focus();
                return;
            }

            if (pcbFEAgent.Image == null)
            {
                MessageBox.Show("Please select Profile Photo");
                return;
            }

            try
            {
                int pin = Convert.ToInt32(txtPINCodeEAgent.Text);
                long contact = Convert.ToInt64(txtContactNoEAgent.Text);

                clsTeamLeader obj = new clsTeamLeader();

                obj.UserCode = txtUserCodeEAgent.Text;
                obj.Email = txtEmailEAgent.Text;
                obj.ContactNo = contact;
                obj.Address = txtAddressEAgent.Text;
                obj.PinCode = pin;

                // IMPORTANT
                if (cmbbxCityNameEAgent.SelectedValue != null)
                {
                    obj.CityId =
                        Convert.ToInt32(cmbbxCityNameEAgent.SelectedValue);
                }

                // IMAGE UPDATE
                if (!string.IsNullOrEmpty(pcbFEAgent.ImageLocation))
                {
                    string sourcePath = pcbFEAgent.ImageLocation;

                    string fileName = Path.GetFileName(sourcePath);

                    string destFolder = Path.Combine(
                        Application.StartupPath,
                        "TickVibe",
                        "Content",
                        "img");

                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }

                    string destPath = Path.Combine(destFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    obj.FileName = fileName;
                    obj.FilePath = @"TickVibe\Content\img\" + fileName;
                }

                // DEBUG
                //MessageBox.Show("UserCode = " + obj.UserCode);

                // UPDATE
                clsTeamLeader obj1 = new clsTeamLeader(obj);
                obj1.UpdateAgentRN();

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
           



        
        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        
            private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmailEAgent.Text == "")
            {
                MessageBox.Show("Enter Email Id");
                txtEmailEAgent.Focus();
            }
        }

        private void txtFullNameEAgent_TextChanged(object sender, EventArgs e)
        {
           // lblFullNameEAgent.ReadOnly = true;
        }

        private void txtUserCodeEAgent_TextChanged(object sender, EventArgs e)
        {
            //txtUserCodeEAgent.ReadOnly = true;
        }

        private void txtEmailEAgent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmailEAgent_Leave(object sender, EventArgs e)
        {
            if (!txtEmailEAgent.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("email must end with @gmail.com");
                txtEmailEAgent.Focus();
            }
        }

        private void txtContactNoEAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if(!char.IsControl(e.KeyChar)&& txtContactNoEAgent.Text.Length>=10)
            {
                   e.Handled= true;
            }
        }

        private void ft3(object sender, EventArgs e)
        {

        }

        private void txtFileNameEAgent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pcbFEAgent_Click(object sender, EventArgs e)
        {
            string imagePath = "";


            {
                OpenFileDialog obj = new OpenFileDialog();
                obj.Filter = "Image Files|*.jpg;*.png;*.jpeg";

                if (obj.ShowDialog() == DialogResult.OK)
                {
                    imagePath = obj.FileName;          // image cha FULL path
                    pcbFEAgent.ImageLocation = imagePath;
                    lblFEAgent.Text = imagePath;
                    lblFEAgent.Text = System.IO.Path.GetFileName(imagePath);
                }
            }
           
        }

        private void siticonePanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnClearEAgent_Click(object sender, EventArgs e)
        {
            txtAddressEAgent.Clear();
            txtPINCodeEAgent.Clear();
           // txtEmailEAgent.Clear();
            txtPINCodeEAgent.Clear();
            //txtContactNoEAgent.Clear();

            cmbbxCountryNameEAgent.SelectedIndex = -1;
            cmbbxStateNameEAgent.SelectedIndex = -1;
            cmbbxCityNameEAgent.SelectedIndex = -1;

            pcbFEAgent.Image = null;
        }

        private void lblFileAgnet_Click(object sender, EventArgs e)
        {

        }

        private void lblFEAgent_Click(object sender, EventArgs e)
        {

        }

        private void lblEAgentFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = lblEAgentFilePath.Text;

            string path = Path.Combine(Application.StartupPath, "TickVibe", "Content", "img", filename);

            if (File.Exists(path))
            {
                pcbFEAgent.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Image not found: " + path);
            }
        }

        private void txtPINCodeEAgent_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPINCodeEAgent.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Only numbers allowed");
                txtPINCodeEAgent.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //int category = Convert.ToInt32(lblCategory.Text);
            //frmMemberManagementRN obj = new frmMemberManagementRN(lblEmpCode.Text, category);
            //obj.Show();
            this.Close();
        }
    }
 }   

  

