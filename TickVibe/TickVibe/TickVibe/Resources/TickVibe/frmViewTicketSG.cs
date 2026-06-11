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
    public partial class frmTransferToTl : Form
    {
        public string TicketId { get; set; }
        public string usercode {  get; set; }
        public frmTransferToTl(string id ,string ucode )
        {
            InitializeComponent();
            TicketId = id;
            usercode = ucode;
        }

        private void frmTransferToTl_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj2 = new clsTeamLeader(obj);
            obj2.TicketCode = TicketId;
            DataTable dt = new DataTable();
            dt = obj2.viewSG();
            if (dt.Rows.Count > 0)
            {
                lblTicketCodeAC.Text = dt.Rows[0]["TktCode"].ToString();
                lblCreateddateAc.Text = dt.Rows[0]["CreatedAt"].ToString();
                lblTypeAc.Text = "connectivty issues";
                cmbxPriority.Text=dt.Rows[0]["PriorityName"].ToString();
                lblEmailAc.Text = dt.Rows[0]["Email"].ToString();
                lblStatusAC.Text = dt.Rows[0]["StatusName"].ToString();
                lblCategoryAC.Text = dt.Rows[0]["CategoryName"].ToString();
                lblSubjectAC.Text = dt.Rows[0]["SubName"].ToString();
                lblEmployeeNameAC.Text = dt.Rows[0]["FullName"].ToString();
                lblContactAC.Text = dt.Rows[0]["ContactNo"].ToString();
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
            }
            clsTeamLeader TlAgents = new clsTeamLeader(obj);
            TlAgents.RoleId = 3;
            TlAgents.UserCode = usercode;
            DataTable dt1 = new DataTable();
            dt1 = TlAgents.AgentsSG();
            cmbxAssign.DisplayMember = "FullName";
            cmbxAssign.ValueMember = "UserCode";
            cmbxAssign.DataSource = dt1;
            //cmbxAssign.Items.Add(dt.Columns[0]);
            cmbxAssign.Show();
            dt = TlAgents.PrioritySG();
            cmbxTlpriority.DisplayMember = "PriorityName";
            cmbxTlpriority.ValueMember = "PriorityId";
            cmbxTlpriority.DataSource = dt;
            cmbxTlpriority.Show();
        }

        private void lblTicketCodeAC_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbaTicketCode_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeNameAC_Click(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string AssignTo = cmbxAssign.Text;
            string PriorityTl = cmbxTlpriority.Text;
            // DateTime AssignTime= DateTime.Now;
            string user_Code = usercode;
            string Tcode = lblTicketCodeAC.Text;
           // clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader();

            obj1.TicketCode = Tcode;
            obj1.PriorityTl = PriorityTl;
            obj1.AssignTo = AssignTo;
            obj1.UserCode = user_Code;
            obj1.AssignSG();
            MessageBox.Show("Successfully Assigned To" + "  " + AssignTo);
            this.Close();

        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            string Tcode = lblTicketCodeAC.Text.ToString();
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader(obj);
            obj1.TicketCode = Tcode;
            obj1.Id = 10;
            obj1.UserCode = usercode;
            obj1.closeRejectAcceptSG();
            MessageBox.Show("Ticket Is  Accepted" + Tcode);
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string Tcode = lblTicketCodeAC.Text.ToString();
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader(obj);
            obj1.Id = 6;
            obj1.TicketCode = Tcode;
            obj1.closeRejectAcceptSG();
            MessageBox.Show("Ticket Is On Hold" + Tcode);
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            string Tcode = lblTicketCodeAC.Text.ToString();
            //clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader();
            obj1.Id = 7;
            obj1.TicketCode = Tcode;
            obj1.UserCode = usercode;
            obj1.closeRejectAcceptSG();
            MessageBox.Show("Ticket is closed" + Tcode);
            this.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string Tcode = lblTicketCodeAC.Text.ToString();
           // clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader obj1 = new clsTeamLeader();
            obj1.Id = 6;
            obj1.TicketCode = Tcode;
            obj1.UserCode = usercode;
            obj1.closeRejectAcceptSG();
            MessageBox.Show("Ticket Is On Hold"+ Tcode);
            this.Close();
            
        }

        private void lblTlLeaderPriority_Click(object sender, EventArgs e)
        {

        }
    }
}  
