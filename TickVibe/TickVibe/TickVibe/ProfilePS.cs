using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickVibe
{
    public partial class ProfilePS : Form
    {
        public string UserCode { get; set; }
        public ProfilePS(string UCode)
        {

            InitializeComponent();
            UserCode = UCode;


        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            ProfilePS obj1 = new ProfilePS(UserCode);
            this.Hide();
            frmEditProfilePS obj = new frmEditProfilePS(UserCode);
            //obj.FormBorderStyle = FormBorderStyle.None;
            //obj.TopLevel = false;
            //siticonePanel1.Controls.Clear();
            //siticonePanel1.Controls.Add(obj);
            //obj.StartPosition = FormStartPosition.Manual;
            //obj.Location = this.Location;
            //obj.Size = this.Size;
            obj.Show();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordPS objA = new frmChangePasswordPS(UserCode);
            objA.Show();
             if (frmNotificationAL.ActiveForm == null)
    {
        frmNotificationAL frm = new frmNotificationAL();
        frm.Show();
    }
        }

        private void ProfilePS_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;

            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width-50,
                115
            );

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
