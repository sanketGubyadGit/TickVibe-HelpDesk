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

namespace TickVibe
{
    public partial class frmAddNewSubjectVN : Form
    {
        string usercode;
        string filepath;
        string catgory;
        string prop;
        string sub;
     
        public frmAddNewSubjectVN(string EMPcode,string path,string catgoryvalue,string propvalue,string subvalue)
        {
            InitializeComponent();
            usercode= EMPcode;
            filepath= path;
            catgory= catgoryvalue;
            prop= propvalue;
            sub= subvalue;
        }
         

        private void lblExit_Click(object sender, EventArgs e)
        {
             

           
            this.Close();
            frmCreateTicketVN obj1 = new frmCreateTicketVN(usercode,filepath, catgory,prop,sub);
            obj1.Refresh();
            obj1.Show();

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            if (txtAddnewSubject.Text == "")
            {
                MessageBox.Show("Please Enter the Subject Name.",
                                        "Subject Required",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {


                clsTeamLeader bj = new clsTeamLeader();
                SqlDataReader dr;
                bj.SubjectName = txtAddnewSubject.Text;
                dr = bj.CheckSubjectExistVN();
                if (dr.Read())
                {

                    MessageBox.Show("The entered value already exists in the system.",
                    "Duplicate Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                }
                else
                {


                    clsTeamLeader obj = new clsTeamLeader();
                    obj.SubjectName = txtAddnewSubject.Text;
                    obj.insertsubjectVN();

                    MessageBox.Show(
                        "Subject created successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    frmCreateTicketVN obj1 = new frmCreateTicketVN(usercode,filepath,catgory,prop,sub);
                    obj1.Refresh();
                    this.Close();
                    txtAddnewSubject.Clear();
                    txtAddnewSubject.Focus();

                }
            }
        }

        private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
