using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using TickVibeLib;
using DocumentFormat.OpenXml.Bibliography;

namespace TickVibe
{
    public partial class frmForgotPasswordVN : Form
    {
      private  string Randomcode;
     private  int timer=60;
      private  bool found=false;


        public static string to;
        
    public frmForgotPasswordVN()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            // Going back to the frmLoginVN
            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Hide();
            Tmrotp.Stop();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //Verifiy the Enter OTP with Send code OTP
            //if the code match open frmResetpasswordVN for new password Enter 
            string OTP = txtCode1.Text +
                txtCode2.Text +
                txtCode3.Text +
                txtCode4.Text +
                txtCode5.Text +
                txtCode6.Text;
            if (Randomcode ==  OTP && timer > 0)
            {
                to = txtmail.Text;
                frmResetpasswordVN obj = new frmResetpasswordVN();
                obj.Show();
                this.Hide();
                Tmrotp.Stop();
                
            }
            else
            {
                MessageBox.Show("The code you entered is incorrect. Please check and try again.",
                "Invalid Code",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Tmrotp.Stop();
            }
            
        }
         

        public void btnSend_Click_1(object sender, EventArgs e)
        {


            if (found && timer > 0)
            {
                MessageBox.Show($"Please wait seconds before requesting new OTP",
                            "Cooldown Period",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else
            {


                txtCode1.Focus();
                //Send OTP For Forgot password Verification
                if (txtmail.Text == "")
                {
                    MessageBox.Show("Please enter your email address.",
                      "Email Required",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                }
                else
                {


                    clsTeamLeader bj = new clsTeamLeader();
                    SqlDataReader dr;
                    bj.Mail = txtmail.Text;
                    dr = bj.CheckValidmailVN();
                    while (dr.Read())
                    {
                        string mail = dr["Email"].ToString();
                        string UserName = dr["FullName"].ToString();
                        string company = dr["CompName"].ToString() ;
                        // string UserName = dr["FullName"].ToString();
                        if (txtmail.Text == mail)
                        {
                            found = true;


                            string from, pass, messagebody;

                            Random rand = new Random();
                            Randomcode = (rand.Next(100000, 999999)).ToString();
                            MailMessage message = new MailMessage();
                            to = (txtmail.Text).ToString();
                            from = "vishalnale1432@gmail.com";
                            pass = "jbalyrzwwllfcube";
                            messagebody = $"Dear {UserName},\n\n" +
                      $"We received a request to reset your account password.\n\n" +
                      $"Your verification code is:\n\n" +
                      $"{Randomcode}\n\n" +
                      $"Please enter this code in the application to proceed with resetting your password. " +
                      $"This code is valid for the next  60 Seconds.\n\n" +
                      $"If you did not request a password reset, please ignore this email. Your account will remain secure.\n\n" +
                      $"For security reasons, do not share this code with anyone.\n\n" +
                      $"Thank you,\n" +
                      $"Support Team\n" +
                      $"Your Company {company}";
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messagebody;
                            message.Subject = "password reseting code";
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.UseDefaultCredentials = false;
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                smtp.Send(message);
                                lblTime.Visible = true;
                                lblCount.Visible = true;
                                lblCount.Text = timer.ToString();


                                MessageBox.Show("The verification code has been sent to your registered email address.",
                                                     "OTP Sent",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);
                                Tmrotp.Start();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }

                    }

                    dr.Close();
                    if (!found)
                    {
                        MessageBox.Show("Please enter a valid email address.",
                     "Invalid Email",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    }
                }
            }
        }
        
        private void btnReSend_Click(object sender, EventArgs e)
        {
            if (found && timer > 0)
            {
                MessageBox.Show($"Please wait seconds before requesting new OTP",
                          "Cooldown Period",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
            }
            else
            {


                txtCode1.Focus();
                bool exist = false;
                //When the OTP time session is over btnResend send New OTP TO User

                string from, pass, messagebody;
                if (txtmail.Text != "")
                {

                    clsTeamLeader bj = new clsTeamLeader();
                    SqlDataReader dr;
                    bj.Mail = txtmail.Text;
                    dr = bj.CheckValidmailVN();
                    while (dr.Read())
                    {
                        string mail = dr["Email"].ToString();
                        string UserName = dr["FullName"].ToString();
                        string company = dr["CompName"].ToString();
                        if (txtmail.Text == mail)
                        {
                            exist = true;

                            Random rand = new Random();
                            Randomcode = (rand.Next(100000, 999999)).ToString();
                            MailMessage message = new MailMessage();
                            to = (txtmail.Text).ToString();
                            from = "vishalnale1432@gmail.com";
                            pass = "jbalyrzwwllfcube";
                            messagebody = $"Dear {UserName},\n\n" +
                        $"We received a request to reset your account password.\n\n" +
                        $"Your verification code is:\n\n" +
                        $"{Randomcode}\n\n" +
                        $"Please enter this code in the application to proceed with resetting your password. " +
                        $"This code is valid for the next  60 Seconds.\n\n" +
                        $"If you did not request a password reset, please ignore this email. Your account will remain secure.\n\n" +
                        $"For security reasons, do not share this code with anyone.\n\n" +
                        $"Thank you,\n" +
                        $"Support Team\n" +
                        $"Your Company  {company}";
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messagebody;
                            message.Subject = "password reseting code";
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.UseDefaultCredentials = false;
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                smtp.Send(message);
                                timer = 60;
                                lblCount.Text = timer.ToString();
                                Tmrotp.Stop();
                                Tmrotp.Start();
                                
                                btnVerify.Show();
                                MessageBox.Show("The verification code has been sent to your registered email address.",
                      "OTP Sent",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    dr.Close();
                    if (!exist)
                    {
                        MessageBox.Show("Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the required fields.",
                      "Input Required",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                }
                txtCode1.Clear();
                txtCode2.Clear();
                txtCode3.Clear();
                txtCode4.Clear();
                txtCode5.Clear();
                txtCode6.Clear();
                txtCode1.Focus();
            }
        }
       
        private void Tmrotp_Tick(object sender, EventArgs e)
        {
            //timer start when the user click on btnsend Code or btnResend for OTP
            if (timer > 0)
                {
                    timer--;
                    lblCount.Text = timer.ToString();
                }
                else
                {
                    Tmrotp.Stop();
                MessageBox.Show("OTP has expired. Please try again.",
             "Expired OTP",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning);

                btnSend.Hide();
                    btnReSend.Show();
                    btnVerify.Hide();
                }
                
            
             
            
        }
 
        private void forgot_Load(object sender, EventArgs e)
        {

        }
 
        private void txtCode2_TextChanged(object sender, EventArgs e)
        {
            txtCode3.Focus();
        }

        private void txtCode3_TextChanged(object sender, EventArgs e)
        {
            txtCode4.Focus();
        }

        private void txtCode4_TextChanged(object sender, EventArgs e)
        {
            txtCode5.Focus();
        }

        private void txtCode5_TextChanged(object sender, EventArgs e)
        {
            txtCode6.Focus();
        }

        private void txtCode6_TextChanged(object sender, EventArgs e)
        {
            btnVerify.Focus();
           
           
        }

        private void txtCode1_TextChanged_1(object sender, EventArgs e)
        {
            txtCode2.Focus();
        }
    }

}