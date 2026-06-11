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
    public partial class frmAgentVN : Form
    {
        public string AUserCode;
        public frmAgentVN(string UserCode)
        {
            InitializeComponent();
            lblEMPcode.Text = UserCode;
            AUserCode = UserCode;
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            clsTeamLeader obj = new clsTeamLeader();
            clsTeamLeader AssignSG = new clsTeamLeader(obj);
            AssignSG.Id = 11;
            AssignSG.UserCode = AUserCode;
            DataTable dt = new DataTable();
            dt = AssignSG.Agentdaata();
            if (siticoneDataGridView1.Columns.Contains("Assign"))
            {
                siticoneDataGridView1.Columns.Remove("Assign");
            }
            if (siticoneDataGridView1.Columns.Contains("EsclateTickets"))
            {
                siticoneDataGridView1.Columns.Remove("EsclateTickets");
            }
            siticoneDataGridView1.DataSource = dt;
            // AddCheckBoxWithHeaderPG(grdNewTicket);
            siticoneDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            siticoneDataGridView1.ColumnHeadersHeight = 40;
            siticoneDataGridView1.BorderStyle = BorderStyle.FixedSingle;


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Resolve";
            btn.Name = "Resolve";
            btn.UseColumnTextForButtonValue = true;
            siticoneDataGridView1.Columns.Add(btn);
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Action";
            btn1.Text = "Open";
            btn1.Name = "Open";
            btn1.UseColumnTextForButtonValue = true;
            siticoneDataGridView1.Columns.Add(btn1);
        }




        private void lblExit_Click(object sender, EventArgs e)
        {
            frmLoginVN obj = new frmLoginVN();
            obj.Show();
            this.Hide();
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && siticoneDataGridView1.Columns[e.ColumnIndex].Name == "Resolve")
            {
                string id = siticoneDataGridView1.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                //string Tcode = lblTicketCodeAC.Text.ToString();
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader obj1 = new clsTeamLeader(obj);
                obj1.TicketCode = id;
                obj1.Id = 9;
                obj1.UserCode = AUserCode;

                obj1.closeRejectAcceptSG();
                MessageBox.Show("Ticket Is  Resolved" + id);
               

               
            }
            if (e.RowIndex >= 0 && siticoneDataGridView1.Columns[e.ColumnIndex].Name == "Open")
            {
                string id = siticoneDataGridView1.Rows[e.RowIndex].Cells["TicketCode"].Value.ToString();
                //string Tcode = lblTicketCodeAC.Text.ToString();
                clsTeamLeader obj = new clsTeamLeader();
                clsTeamLeader obj1 = new clsTeamLeader(obj);
                obj1.TicketCode = id;
                obj1.Id = 3;
                obj1.UserCode = AUserCode;
                obj1.closeRejectAcceptSG();
                MessageBox.Show("Ticket Is  Opened" + id);



            }
        }
    }
}