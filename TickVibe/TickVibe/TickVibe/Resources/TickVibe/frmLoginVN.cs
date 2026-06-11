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
using TickVibeLib;
using System.Text.RegularExpressions;


namespace TickVibe
{
    public partial class frmLoginVN : Form
        
    {
      
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSNVSK3;Initial Catalog=TickVibe;Integrated Security=True");
        public frmLoginVN()
        {
            InitializeComponent();
        }
    
        private void Home_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check the enter mail is valid or not  
            //give the login based no role 
            //check the enter passowrd is match with mail 
            //pass the usercode through the datareader from frmLogin page to frmTeamLeader through constructor 
            //add special character validation  login mail and password
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please enter both Username and Password.",
                 "Input Required",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                var verification = new Regex(@"^(?=.*[A-Za-z])(?=.*[@])(?=.*[A-Za-z\d@])");
                if (!verification.IsMatch(txtUserName.Text))
                {
                    MessageBox.Show("Please enter a valid email address.",
                "Invalid Email",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    try
                    {

                        clsTeamLeader bj = new clsTeamLeader();
                        bj.Mail = txtUserName.Text.Trim();
                        bj.Pass = txtPassword.Text.Trim();
                        SqlDataReader dr;
                        dr = bj.LoginVN();

                        if (dr.Read())
                        {
                            int role = Convert.ToInt32(dr["RoleId"]);
                            string UserCode = dr["UserCode"].ToString();
                            int CategoryId =Convert.ToInt32( dr["CategoryId"]);

                            if (role == 3)
                            {

                                MessageBox.Show("Login successful.",
                                   "Success",
                                     MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                                frmAgentVN obj = new frmAgentVN(UserCode);
                                obj.Show();
                                this.Hide();
                            }
                            else if (role == 2)
                            {
                                MessageBox.Show("Login successful.",
                                "Success",
                                  MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                
                              frmSideBar obj=new frmSideBar(UserCode);
                                obj.Show();
                                this.Hide();
                            }
                            

                        }

                        else
                        {
                            MessageBox.Show("Check  the write info ", "error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        dr.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("something wrong" + ex, " error messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            //stop the program
            Application.Exit();
        }

        private void chkbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //convert the Password * pattern to character and also hide password
            txtPassword.PasswordChar = chkbShowPassword.Checked ? '\0' : '*';

        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            //open Forgot passwordVNFrom TO change user password 
            frmForgotPasswordVN obj = new frmForgotPasswordVN();
            obj.Show();
            this.Hide();
        }

        private void siticoneGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
