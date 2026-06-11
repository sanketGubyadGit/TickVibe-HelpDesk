using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickVibeLib;

namespace TickVibe
{
    public partial class Reassign1SG : Form
    {
        public string TypeCode { get; set; }
        public string userCode {  get; set; }
        public string  id {  get; set; }    
        public Reassign1SG(string usercode , string uid)
        {
            InitializeComponent();
            userCode=usercode;
            id = uid;
        }
        private void Reassign1SG_Load(object sender, EventArgs e)
        {
     
         lblTicketCodeAC.Text = TypeCode;
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader(obj);
            obj1.RoleId=3;
            obj1.UserCode = userCode;
            obj1.TicketCode = id;
            DataTable tb = new DataTable();
            tb = obj1.AgentsSG();
            cmbNewAgents.DisplayMember = "FullName";
            cmbNewAgents.ValueMember = "UserCode";
            cmbNewAgents.DataSource = tb;
            tb = obj1.assignagentsSG();
           lblCurrentAssign.Text= tb.Rows[0]["AssignedTo"].ToString();
            lblTicketCodeAC.Text = id;
            string AssignTo = cmbNewAgents.SelectedText.ToString();
        }

        private void cmbNewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string AssignTo = cmbNewAgents.GetItemText(cmbNewAgents.SelectedItem);
            string PriorityTl = "High";
            string Tcode = lblTicketCodeAC.Text;
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader(obj);
            obj1.TicketCode = Tcode;
            obj1.PriorityTl = PriorityTl;   
            obj1.AssignTo = AssignTo;
            obj1.UserCode = userCode;
            obj1.AssignSG();
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            obj2.Id = 12;
            obj2.TicketCode = Tcode;
            obj2.UserCode = userCode;
            obj2.closeRejectAcceptSG();
            MessageBox.Show("Ticket Is  Assigened To"+ " "+ AssignTo);
            this.Close();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
