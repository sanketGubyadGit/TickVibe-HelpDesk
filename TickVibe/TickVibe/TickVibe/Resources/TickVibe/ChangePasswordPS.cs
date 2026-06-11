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

namespace TickVibe
{
    public partial class frmChangePasswordPS : Form
    {

        ErrorProvider errorProvider1 = new ErrorProvider();
        public string UserCode {  get; set; }

        public frmChangePasswordPS(string UserCode)
        {
            this.UserCode = UserCode;
            InitializeComponent();

            
        }
   
       
        private void frmChangePasswordPS_Load(object sender, EventArgs e)
        {

            //txtOldPassword.UseSystemPasswordChar = true;
            //txtNewPassword.UseSystemPasswordChar = true;
            //txtConfirmPassword.UseSystemPasswordChar = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                errorProvider1.SetError(txtOldPassword, "OldPassword required");
                txtOldPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
            }
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "NewPassword required");
                txtNewPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password required");
                txtConfirmPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtOldPassword, "");
            }
            //if (txtNewPassword.Text == "Checks if New Password is empty")
            //{
            //    MessageBox.Show("Enter New Password");
            //    txtNewPassword.Focus();
            //    return;
            //}

            //if (txtConfirmPassword.Text == "Checks if Confirm Password is empty")
            //{
            //    MessageBox.Show("Enter Confirm Password");
            //    txtConfirmPassword.Focus();
            //    return;
            //}

            //if (txtNewPassword.Text != txtConfirmPassword.Text)
            //{
            //    MessageBox.Show("New Password and Confirm Password must be same");
            //    txtConfirmPassword.Focus();
            //    return;
            //}

            clsTeamLeader obj = new clsTeamLeader();
             obj. UserCode = UserCode;
            obj.OldPassword = txtOldPassword.Text;
            obj.NewPassword = txtNewPassword.Text;
            clsTeamLeader obj2= new clsTeamLeader(obj);
            int result = obj2.ChangePasswordPS();

            if (result > 0)
            {
                MessageBox.Show("Password Changed Successfully");

            }
            else
            {
                MessageBox.Show("Old Password is incorrect");
            }
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match"); 
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            if (txtConfirmPassword.PasswordChar == '*')
            {
                txtConfirmPassword.PasswordChar = '\0';
                pictureBox1.Image = Image.FromFile (@"E:\TicketingToolFinalMergeProject\TickVibe\TickVibe\TickVibe\Content\icon\show - Copy.png");
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
                 pictureBox1.Image =Image.FromFile (@"E:\TicketingToolFinalMergeProject\TickVibe\TickVibe\TickVibe\Content\icon\hide - Copy.png");;
            }
        }
    }


    
}

