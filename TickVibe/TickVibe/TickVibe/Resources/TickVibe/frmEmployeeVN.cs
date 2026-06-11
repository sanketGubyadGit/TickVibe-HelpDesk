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
    public partial class frmEmployeeVN : Form
    {
        public frmEmployeeVN(string UserCode)
        {
            InitializeComponent();
            lblEMPcode.Text = UserCode;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
