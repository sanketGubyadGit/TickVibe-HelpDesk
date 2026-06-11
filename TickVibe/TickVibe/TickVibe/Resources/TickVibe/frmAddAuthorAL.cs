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
    public partial class frmAddAuthorAL : Form
    {
        public frmAddAuthorAL()
        {
            InitializeComponent();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddAuthorAL_Load(object sender, EventArgs e)
        {

        }

        private void btnADDAuthor_Click(object sender, EventArgs e)
        {
            clsTeamLeader obj1 = new clsTeamLeader();
            obj1.AuthorName = txtAuthorNameAdd.Text;

            clsTeamLeader obj = new clsTeamLeader(obj1);   // Copy Constructor

            obj.AddAuthorNameAL();

            MessageBox.Show("Add successfully..!");

            //clsTeamLeader obj = new clsTeamLeader(txtAuthorNameAdd.Text);
            //obj.AddAuthorNameAL();
            //MessageBox.Show("Add successfully..!");

        }

        private void lblAuthorNamefrm_Click(object sender, EventArgs e)
        {

        }
    }
}
