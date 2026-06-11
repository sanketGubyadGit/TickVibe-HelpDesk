using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using TickVibeLib;

namespace TickVibe
{
    public partial class frmResetpasswordVN : Form
    {
        string username = frmForgotPasswordVN.to;
        bool pass = false;
        public frmResetpasswordVN()
        {
            InitializeComponent();
        }

        private void Resetpassword_Load(object sender, EventArgs e)
        {

        }




        private void btnEye_Click_1(object sender, EventArgs e)
        {
            //when user click on btneye1 it will show the new passoword in star pattern to  character from
            //again click the tbneye1 then it hide the password
            btnEyeIcon3.Show();
            btnEyeIcon1.Hide();
            
              
            txtNewpass.PasswordChar = '*';
            pass = false;

        }

        private void btnEye2_Click(object sender, EventArgs e)
        {
            //when user click on btneye2 it will show the new passoword in star pattern to  character from
            //again click the tbneye2 then it hide the password
            btnEyeIcon4.Show();
            btnEyeIcon2.Hide();
                txtCompass.PasswordChar = '*';
                pass = false;
            
               
            
        }

        private void label1_Click(object sender, EventArgs e)
 
        {
            //go back to the frmLogin 
            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Hide();
        }
      
        private void btnsave_Click(object sender, EventArgs e)
        {
            //check the both text box values are same or not  
            //if the values match the with special character then it will save in database 
            if (txtNewpass.Text == "" || txtCompass.Text == "")
            {
                MessageBox.Show("Please enter your password.",
                "Password Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            if (txtNewpass.Text != txtCompass.Text)
            {
                MessageBox.Show("Incorrect password. Please check and try again.",
                  "Login Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }

            var num = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (!num.IsMatch(txtNewpass.Text))
            {
                MessageBox.Show("Your password is too weak. Please use a stronger password.",
                  "Weak Password",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }

            else
            {
                clsTeamLeader obj = new clsTeamLeader();
                obj.Mail = username;
                obj.Pass = txtCompass.Text;
                obj.UpdateVN();
                MessageBox.Show("New password created successfully.",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                frmLoginVN obj1=new frmLoginVN();
                obj1.Show();
                this.Close();

            }




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEyeIcon3_Click(object sender, EventArgs e)
        {

            txtNewpass.PasswordChar = '\0';
            pass = true;
            
            btnEyeIcon1.Show();
            btnEyeIcon3.Hide();
        }

        private void btnEyeIcon4_Click(object sender, EventArgs e)
        {
            txtCompass.PasswordChar = '\0';
            pass = true;
           
             
            btnEyeIcon2.Show();
            btnEyeIcon4.Hide();
        }

        private void txtCompass_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
