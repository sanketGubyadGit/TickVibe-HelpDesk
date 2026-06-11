using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TickVibeLib;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TickVibeLib

{

    public class clsTeamLeader
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LTB9SGR;Initial Catalog=TickVibe;Integrated Security=True;");
        public int Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Name { get; set; }
        public string TicketCode { get; set; }
        public string AssignTo { get; set; }
        public string PriorityTl { get; set; }

        public int PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string TktCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long ContactNo { get; set; }
        public string CategoryName { get; set; }
        public string StatusName { get; set; }
        public string SubName { get; set; }
        public DateTime CreateAt { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public int StatusId { get; set; }
        public String UserId { get; set; }
        public int CategoryId { get; set; }
        public int RoleId { get; set; }
        public string UserCode { get; set; }
        public string CreatedBy { get; set; }
       // public DateTime FromDate { get; set; }
        //public DateTime ToDate { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Subject { get; set; }
        public string Attachment { get; set; }
        public string usercode { get; set; }
        public string Ticketcode { get; set; }
        public string mail { get; set; }
        public string pass { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
        public int Rating { get; set; }
        public int AuthorId { get; set; }

        public string BlogPdfPath { get; set; }

        // public string BlogCode { get; set; }

        public int BlogRating { get; set; }

        public int BlogId { get; set; }

        public string BlogCode { get; set; }
        public int BlogStatusId { get; set; }


        public DateTime CreatedAt { get; set; }

        public DateTime PublishedAt { get; set; }
        public int IsDelete { get; set; }

        public string AuthorName { get; set; }
        public DataTable DataSource { get; set; }


        public string Blogtitle { get; set; }
        public string Message { get; set; }
        public int NotificationId { get; set; }

        public string Review { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string Password { get; set; }
        //public int UserId { get; set; }
        //public string UserCode { get; set; }
        public string EmployeeCode { get; set; }
        public string UserName { get; set; }
        public string CompanyCode { get; set; }
        //public string Name { get; set; }
        public string EmailId { get; set; }
        //public long ContactNo { get; set; }
        public int PINCODE { get; set; }
        public string CompanyName { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string ProfilePhoto { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string FilePath { get; set; }
        public int stateid { get; set; }
        




        public string empcode { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public string statusname { get; set; }
        public string tlempcode { get; set; }
        public int categoryid { get; set; }
        public string empname { get; set; }










        public int PinCode { get; set; }
        public string CompCode { get; set; }

        




        public int Active { get; set; }

        public int AttachmentId { get; set; }

        public string TEBCode { get; set; }



        public string UploadedBy { get; set; }

        public DateTime UploadedAt { get; set; }

        public int countryId { get; set; }



        public string Mail { get; set; }
        public string Pass { get; set; }


        public string Createby { get; set; }
       
        public int Priorityid { get; set; }
        public int Statusid { get; set; }
        public int Subjectid { get; set; }
        public long Contact { get; set; }
        
         
        public string Filepath { get; set; }
        public string Uploadedby { get; set; }
        
        public string SubjectName { get; set; }
        
        public string EMPCode { get; set; }

        public DateTime DateofBirth { get; set; }
        
        public clsTeamLeader() { }
        public clsTeamLeader(int Statusid)
        {
            Id = Statusid;
            
        }

        public clsTeamLeader(string Tcode) { TicketCode = Tcode; usercode = Tcode; }
        public clsTeamLeader(string Tcode,int sid) { TicketCode = Tcode; Id = sid; }
       //// public clsTeamLeader(int PriorityId, DateTime? NwFromDate, DateTime? NwToDate, string Ecode)
       // {
       //     Id = PriorityId;
       //     FromDate = NwFromDate;
       //     ToDate = NwToDate;
       //     //Name = Ecode;
       // }
        public clsTeamLeader(string TKcode, string PriorityTlSG , string AssignToSG )
        {
            TicketCode = TKcode;
            PriorityTl = PriorityTlSG;
            AssignTo = AssignToSG;
        }
        
        public clsTeamLeader(clsTeamLeader clstl)
        {

            TktCode = clstl.TktCode;
            UserCode = clstl.UserCode;
            CategoryId = clstl.CategoryId;
            FromDate = clstl.FromDate;
            ToDate = clstl.ToDate;
            UserCode = clstl.UserCode;
            Title = clstl.Title;
            AuthorName = clstl.AuthorName;
            //mail = clstl.mail;
            //pass= clstl.pass;
            CategoryId = clstl.CategoryId;
            Content = clstl.Content;
            AuthorId = clstl.AuthorId;
            BlogPdfPath = clstl.BlogPdfPath;
            BlogId = clstl.BlogId;
            BlogStatusId = clstl.BlogStatusId;
            CreatedBy = clstl.CreatedBy;
            CreatedAt = clstl.CreatedAt;
            PublishedAt = clstl.PublishedAt;
            IsDelete = clstl.IsDelete;
            Blogtitle = clstl.Blogtitle;
            BlogCode = clstl.BlogCode;
            Rating = clstl.Rating;
            Review = clstl.Review;
            NotificationId = clstl.NotificationId;
            DateofBirth = clstl.DateofBirth;
            //  -----------------------------------------Profile------//
            UserCode = clstl.UserCode;
            Name = clstl.Name;
            EmailId = clstl.EmailId;
            ContactNo = clstl.ContactNo;
            FilePath = clstl.FilePath;
            PINCODE = clstl.PINCODE;
            CountryName = clstl.CountryName;
            StateName = clstl.StateName;
            CityName = clstl.CityName;
            Address = clstl.Address;
            Password = clstl.Password;
            OldPassword = clstl.OldPassword;
            NewPassword = clstl.NewPassword;
            UserCode = clstl.UserCode;
            stateid = clstl.stateid;
            ContactNo = clstl.ContactNo;
            FullName = clstl.FullName;
            Email = clstl.Email;
            Password = clstl.Password;
            Address = clstl.Address;
            PinCode = clstl.PinCode;
            CompCode = clstl.CompCode;
            CreatedAt = clstl.CreatedAt;
            RoleId = clstl.RoleId;
            CategoryId = clstl.CategoryId;
            CityId = clstl.CityId;
            Active = clstl.Active;
            AttachmentId = clstl.AttachmentId;
            TEBCode = clstl.TEBCode;
            FileName = clstl.FileName;
            FilePath = clstl.FilePath;
            UploadedBy = clstl.UploadedBy;
            UploadedAt = clstl.UploadedAt;
            FromDate = clstl.FromDate;
            ToDate = clstl.ToDate;
            countryId = clstl.countryId;
                        UserCode = clstl.UserCode;

            CategoryId = clstl.CategoryId;
            StatusId = clstl.StatusId;
            FromDate = clstl.FromDate;
            ToDate = clstl.ToDate;
            Mail = clstl.Mail;
            Pass = clstl.Pass;
            Name = clstl.Name;
            CategoryName = clstl.CategoryName;
            //-----------------------------------report-----------------------
                statusname = clstl.statusname;
            empcode = clstl.empcode;
            fromdate = clstl.fromdate;
            todate = clstl.todate;
            tlempcode = clstl.tlempcode;
            categoryid = clstl.categoryid;
            empname = clstl.empname;

            //-----------------------------------ticket-----------------------

            SubjectName = clstl.SubjectName;
            EMPCode = clstl.EMPCode;
            Createby = clstl.Createby;
            CategoryId = clstl.CategoryId;
            Priorityid = clstl.Priorityid;
            Statusid = clstl.Statusid;
            Description = clstl.Description;
            CreateAt = clstl.CreateAt;
            Subjectid = clstl.Subjectid;
            Contact = clstl.Contact;
            FileName = clstl.FileName;
            Filepath = clstl.Filepath;
            Uploadedby = clstl.Uploadedby;
            UploadedAt = clstl.UploadedAt;
            TktCode = clstl.TktCode;
            UserCode = clstl.UserCode;
            PriorityTl = clstl.PriorityTl;

        }

        //public clsTeamLeader(string authorname)
        //{
        //    AuthorName = authorname;
        //}



        public DataTable SideBarSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SideBar");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);

            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

            }

        /// <summary>
        /// Sanket Gubyad
        /// </summary>
        /// <returns>It Shows The all NewTickets </returns>
        public DataTable NewTicketSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "NewTicketSG");
            cmd.Parameters.AddWithValue("@statusID", Id);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.CommandTimeout = 60; // optional

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable AllTicketSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AllTicket");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.CommandTimeout = 60; // optional

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        /// <summary>
        /// Sanket Gubyad
        /// </summary>
        /// <returns>It shows the priority</returns>


        public DataTable PrioritySG()
        {
            
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PrioritySG");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// sanket Gubyad
        /// </summary>
        /// <returns>it shows the specific data on click of filter Button</returns>
        public DataTable FilterSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterSG");
            cmd.Parameters.AddWithValue("@Priority", Id);
            cmd.Parameters.AddWithValue("@FromDate", FromDate.HasValue ? (object) FromDate.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", ToDate.HasValue ? (object)ToDate.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@name", Name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Sanket Gubyad
        /// </summary>
        /// <returns> it shows the all ticket data on ticket view page </returns>
        public DataTable viewSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewSG");
            cmd.Parameters.AddWithValue("@name", TicketCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable AgentsSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AgentsSG");
            cmd.Parameters.AddWithValue("@RoleId", RoleId);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader AssignSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","AssignSG");
            cmd.Parameters.AddWithValue("@TktCode", TicketCode);
            cmd.Parameters.AddWithValue("@PriorityTl", PriorityTl);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@EmpCode", AssignTo);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader rd = cmd.ExecuteReader();
            con.Close();
            return rd;

        }

        public SqlDataReader EsclateSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EsclateSG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@name", TicketCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader rd= cmd.ExecuteReader();
            con.Close();
            return rd;
            
        }
        public SqlDataReader closeRejectAcceptSG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "closeRejectAcceptSG");
            cmd.Parameters.AddWithValue("@name", TicketCode);
            cmd.Parameters.AddWithValue("@StateId", Id);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader rd = cmd.ExecuteReader();
            con.Close();
            return rd;
        }
      
        public DataTable assignagentsSG()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "assignagentsSG");
            cmd.Parameters.AddWithValue("@name", TicketCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FPriorityPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPriorityPG");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns>   Fetched New Ticket Code</returns>

        public DataTable FNewTCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchNTktCodePG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
                 cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns>Confirm Ticket Code Fetched into combobox</returns>
        public DataTable FConfirmTktCodePG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCTktCodePG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        /// <summary>
        /// Prarbdha 
        /// </summary>
        /// <returns>In Progress Ticket Code Fetched</returns>
        public DataTable FInProgressTktCodePG()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchITktCodePG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns>Hold Ticket  Code Fetched </returns>
        public DataTable FHTktCodePG()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchHTktCodePG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }


        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <return >Closed ticket Code Fetched</returns>
        public DataTable FClosedTktCodePG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchClosedTktCodePG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// prarbdha
        /// </summary>
        /// <returns>  New Ticket Fetched into  Gridview </returns>

        public DataTable FNewTPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchNewTPG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
                 cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns>Confirm Ticket Fetched Into Gridview</returns>

        public DataTable FConfirmTPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchConfirmTPG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns> In progress Ticket Fetched into Gridview </returns>

        public DataTable FIProgressTPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchInProgressTPG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns> Hold Ticket Fetched Into Gridview</returns>

        public DataTable FHoldTPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchHoldTicketPG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns> Closed Tickets Fetched into Gridview</returns>

        public DataTable FClosedTPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchClosedTPG");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }


        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <returns>inprogress Tickets Fetched into View Detail form</returns>

        public SqlDataReader FetchAllViewPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchAllTicketPG");
            cmd.Parameters.AddWithValue("@TktCode", TktCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns> fetch new ticket date </returns>

        public DataTable FNDatePG(DateTime fromdate, DateTime todate, string usercode)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchNDatePG");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@UserCode", usercode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }


        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns>Fetched confirm ticket Date</returns>
        public DataTable FCDatePG(DateTime fromdate, DateTime todate, string usercode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCDatePG");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@UserCode", usercode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns> fetched In Progress Tickets date</returns>
        public DataTable FIPDatePG(DateTime fromdate, DateTime todate, string usercode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchIPDatePG");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@UserCode", usercode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns> Fetched Hold ticket Date</returns>
        public DataTable FHDatePG(DateTime fromdate, DateTime todate, string usercode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchHTDatePG");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@UserCode", usercode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Prarbdha
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns> fetched Closed Ticket Date</returns>

        public DataTable FClosedDatePG(DateTime fromdate, DateTime todate, string usercode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchClosedTDatePG");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@UserCode", usercode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }





        //vishal's login methods
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns> IT Update The Customer PassWord</returns>
        public void UpdateVN()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePasswordVN");
            cmd.Parameters.AddWithValue("@Email", Mail);
            cmd.Parameters.AddWithValue("@Password", Pass);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>Give The Login Based On User Role</returns>
        public SqlDataReader LoginVN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "loginUserVN");
            cmd.Parameters.AddWithValue("@Email", Mail);
            cmd.Parameters.AddWithValue("@Password", Pass);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns> Check the Enter Mail For Forgot Password Is Register Or Not </returns>
        public SqlDataReader CheckValidmailVN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ValidateEmailVN");
            cmd.Parameters.AddWithValue("@Email", Mail);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
                       SqlDataReader dr;
            dr = cmd.ExecuteReader();

            return dr;
        }
        //end of vishal's methods


        /// <summary>
        /// Somnath
        /// </summary>
        /// <param></param>
        /// <returns>Fetch data in to the data gridview</returns>
        public DataTable EmployeeDetailesSB(DateTime fromDate, DateTime toDate)
        {
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = "EmployeeDetailesSB";

            cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;

            cmd.Parameters.Add("@UserCode", SqlDbType.NVarChar).Value = usercode;

            // 🔥 IMPORTANT FIX (THE ERROR FIX)
            cmd.Parameters.Add("@OldPassword", SqlDbType.NVarChar).Value = DBNull.Value;
            cmd.Parameters.Add("@NewPassword", SqlDbType.NVarChar).Value = DBNull.Value;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        /// <summary>
        /// Somnath
        /// </summary>
        /// <param name="Ticketcode"></param>
        /// <returns>Fetch data in to the data gridview</returns>
        public DataTable ViewTicketsSB(string userCode, DateTime fromDate, DateTime toDate)
        {
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@flag", "ViewTicketsSB");
            cmd.Parameters.AddWithValue("@UserCode", userCode);

            cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
            cmd.Parameters.AddWithValue("@ToDate", toDate.Date.AddDays(1).AddSeconds(-1));

            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable ShowCategoriesAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "clsTeamLeaderAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;


        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns>select status</returns>
        public DataTable ShowStatusAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "StatusAL");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            DataTable dta = new DataTable();
            adpt.Fill(dta);
            con.Close();
            return dta;

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns>select Rating</returns>
        public DataTable ShowRatingAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RatingsAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> select Author </returns>
        public DataTable showAuthorAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AuthorAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> Create Blog </returns>

        public void CreateBlogAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CreateBlogInfoAL");
            cmd.Parameters.AddWithValue("@Title", Blogtitle);
           cmd.Parameters.AddWithValue("@CategoryIds", CategoryId);
            cmd.Parameters.AddWithValue("@Content", Content);
            cmd.Parameters.AddWithValue("@ImagePath", BlogPdfPath);
            cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
            cmd.Parameters.AddWithValue("@BlogStatusId", BlogStatusId);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            // cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);
            //cmd.Parameters.AddWithValue("@PublishedAt", PublishedAt);
            cmd.Parameters.AddWithValue("@IsDelete", 1);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> Update Blog </returns>
        public void UpdateBlogInformationAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateBlogInfoAL");
            cmd.Parameters.AddWithValue("@Title", Blogtitle);
            cmd.Parameters.AddWithValue("@CategoryIds", CategoryId);
            cmd.Parameters.AddWithValue("@Content", Content);
            cmd.Parameters.AddWithValue("@ImagePath", BlogPdfPath);
            cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
          //  cmd.Parameters.AddWithValue("@BlogStatusId", BlogStatusId);
            cmd.Parameters.AddWithValue("@BlogCode", BlogCode);

            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            //cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);
            //cmd.Parameters.AddWithValue("@PublishedAt", PublishedAt);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> Add Author  </returns>
        public void AddAuthorNameAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddAuthorAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@AuthorName", AuthorName);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> select Blog info </returns>
        public DataTable ShowBlogInfoAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShortBlogInfoAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> show blog list view </returns>
        public DataTable ShowBlogListInfoAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowBlogListAL");
            cmd.Parameters.AddWithValue("@BlogCode", BlogCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> Add Rating </returns>
        public void InsertRatingAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertRatingInfoAL");
            cmd.Parameters.AddWithValue("@BlogCode", BlogCode);
            cmd.Parameters.AddWithValue("@UserCode", CreatedBy);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Review", Review);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> select Count in notification  </returns>

        public DataTable SelectCountAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SelectCountAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> select table FetchNotification </returns>
        public DataTable FetchNotificationAL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SelectNotificationAL");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> Update Notification  </returns>
        public void UpdateNotificationAL(int notificationid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateIsreadAL");
            cmd.Parameters.AddWithValue("@NotificationId", notificationid);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            // SelectedRows[0].Cells["NotificationId"].Value
            //cmd.Parameters.AddWithValue("@IsRead", 1);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Abhishek
        /// </summary>
        /// <returns> DeleteBlog </returns>
        public void DeleteBlogAL(string BlogCode, int IsDelete)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("spTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteBlogAL");
            cmd.Parameters.AddWithValue("@BlogCode", BlogCode);
            cmd.Parameters.AddWithValue("@IsDelete", 0);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        //------------------------------------profile----------------------------////
        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>User Password Update</returns>

        public int ChangePasswordPS()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ChangePasswordPS");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", OldPassword);
            cmd.Parameters.AddWithValue("@NewPassword", NewPassword);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }


        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>Fetch Country On DropDown</returns>

        public DataTable FetchCountryPS()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCountryPS");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>Fetch State On DropDown</returns>
        public DataTable FetchStatePS()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStatePS");
            cmd.Parameters.AddWithValue("@CountryId", CountryId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>Fetch City ON DropDown</returns>

        public DataTable FetchCityPS()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCityPS");
            cmd.Parameters.AddWithValue("@StateID", StateId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>Fetch Profile Settings</returns>

        public DataTable fetchprofilePS()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchProfileps");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adpt.Fill(dt1);
            con.Close();
            return dt1;
            
        }


        public DataTable profilemain()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "profilemain");
           // cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adpt.Fill(dt1);
            con.Close();
            return dt1;

        }


        /// <summary>
        /// Pranali
        /// </summary>
        /// <returns>Update Profile Settings</returns>


        public void UpdateProfilePS()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateProfilePS");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@EmailID", EmailId);
            cmd.Parameters.AddWithValue("@FullName", Name);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            cmd.Parameters.AddWithValue("@StateName", StateName);
            cmd.Parameters.AddWithValue("@CityName", CityName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PINCODE", PINCODE);
            cmd.Parameters.AddWithValue("@FileName", FileName);
            cmd.Parameters.AddWithValue("@FilePath", FilePath);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ShowAddAgentRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchagentRN");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }

        /// <summary>
        /// Ramesh 
        /// </summary>
        /// <returns>fetched country </returns>
        public DataTable ShowCountryRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCmbbxCountryRN");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Ramesh
        /// </summary>
        /// <returns> fetched states </returns>

        public DataTable ShowStatesRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCmbbxStateRN");
            cmd.Parameters.AddWithValue("@CountryId", countryId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Ramesh
        /// </summary>
        /// <returns>Fetched City </returns>
        public DataTable ShowCityRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCmbbxCityRN");
            cmd.Parameters.AddWithValue("@StateId", stateid);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Ramesh 
        /// </summary>
        /// <return>Agents are Added </return>

        public void AddAgentFrmRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddAgentFormRN");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@RoleId", RoleId);
            cmd.Parameters.AddWithValue("@CategoryIds", CategoryId);
            cmd.Parameters.AddWithValue("@Active", Active);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);
            cmd.Parameters.AddWithValue("@DateofBirth ",DateofBirth);
            cmd.Parameters.AddWithValue("@CompCode", CompCode);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@TEBCode", TEBCode);
            cmd.Parameters.AddWithValue("@FileName", FileName);
            cmd.Parameters.AddWithValue("@FilePath", FilePath);
            cmd.Parameters.AddWithValue("@UploadedBy", UploadedBy);
            cmd.Parameters.AddWithValue("@UploadedAt", UploadedAt);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Ramesh
        /// </summary>
        /// <returns> Agents are added then click view button then agent are viewed</returns>
        public DataTable VAgentRN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewAgentRN");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// Ramesh
        /// </summary>
        /// <returns> firstly agents are added then select edit from then edit agents are updated <returns>
        public void UpdateAgentRN()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Flag", "UpdateAgentInfoRN");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@CityId", CityId);   // ADD THIS
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@FileName", FileName);
            cmd.Parameters.AddWithValue("@FilePath", FilePath);

            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            cmd.ExecuteNonQuery();

            con.Close();
        }
        /// <summary>
        /// Ramesh
        /// </summary>
        /// <param name="Fromdate"></param>
        /// <param name="Todate"></param>
        /// <returns> Fetching agent from, to date Agents</returns>
        public DataTable FDateRN(DateTime fromdate, DateTime todate)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchDateRN");
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }


        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Shows login TL usercode,tl name,tl category name on labels</returns>
        public DataTable ShowLoginUserDetailsByUserCodeMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUserDetailsByUserCodeMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }



        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show Agent List</returns>
        public DataTable ShowAgentListMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAgentListMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show Employee List</returns>
        public DataTable ShowEmployeeListMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowEmployeeListMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>ticket count and ticket status has to shown on the chart of the specific selected agent</returns>
        public DataTable ShowGraphicalViewChartMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "chartcount&statusMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Chart type column depending on from date and to date chart updates by ticket count and ticket status of agent:frmReportMB.cs</returns>
        public DataTable ShowGraphicalViewChart22MB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DayMonthYearWiseMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Chart type column depending on from date and to date chart updates by ticket count and ticket status of agent overall status graphical view:frmReportMB.cs</returns>
        public DataTable ShowGraphicalViewChartAllStatusAgentMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DayMonthYearWiseAllAgentsMB");

            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }


        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>specific column chart click status for agent overall status after graphical view   :frmgridviewallagentreport.cs</returns>
        public DataTable StatusWiseTicketDetails22MB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "StatusWiseTicketDetails22MB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }















        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show data on datagridview statuswise when click on chart type column on specific column</returns>
        public DataTable ShowDataGridViewStatusWiseMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowDataGridViewStatusWiseMB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show on tabular view agent code,agent name,agent performance</returns>
        public DataTable ShowAllAgentOnTabularViewMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TabularViewAllAgentNameListMB");
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>When click on view button in tabular view it shows that agent assigned all ticket list:frmTabularView2.cs</returns>
        public DataTable ShowDataGridViewAgentWiseTabularViewMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TabularViewAgentSpecificListMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Shows Agents specific all ticket status list frmAllagentassignedticked.cs</returns>
        public DataTable ShowgrdAgentSpecificTicketListMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TabularViewAgentSpecificListMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Chart type column depending on from date and to date chart updates by ticket count and ticket status of Employee:frmReportMB.cs</returns>
        public DataTable ShowGraphicalViewChartEmployee22MB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DaymonthyearwiseemployeeMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show data on datagridview statuswise when click on chart type column on specific column Employee</returns>
        public DataTable ShowDataGridViewStatusWiseEmployeeMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowEmployeeStatuswiseMB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show on tabular view Employee Name,All ticket status</returns>
        public DataTable ShowAllEmployeeOnTabularViewMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TabularViewEmployeeGridMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show on tabular view Agent Name,All ticket status</returns>
        public DataTable ShowAllAgentlistOnTabularViewMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TabularViewAgentGridMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            //cmd.Parameters.AddWithValue("@CategoryId", categoryid);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari Bante
        /// </summary>
        /// <returns>show data on datagridview statuswise employee</returns>
        public DataTable ShowTabularViewEmployeeStatuswiseMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowEmployeeStatuswiseMB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>show data on datagridview statuswise agent</returns>
        public DataTable ShowTabularViewAgentStatuswiseMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAgentStatuswiseMB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }








        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>show data on datagridview statuswise agent on graphical view specific column click</returns>
        public DataTable ShowTabularViewAgentStatuswise2MB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAgentStatuswise2MB");
            cmd.Parameters.AddWithValue("@StatusName", statusname);
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }



























        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>show data on datagridview statuswise agent</returns>
        public DataTable ShowGraphicalViewAgentProgressBarMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowProgressBarAgentMB");

            cmd.Parameters.AddWithValue("@usercode", empcode);
            //cmd.Parameters.AddWithValue("@CategoryId", categoryid);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }






        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>show all tickets for an agent (for Total Tickets click)</returns>
        public DataTable ShowAllAgentTicketsMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllAgentTicketsMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }



        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>show open and closed tickets for an agent (Open & Closed Tickets)</returns>
        public DataTable ShowOpenAndClosedTicketsMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOpenAndClosedTicketsMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            //   cmd.Parameters.AddWithValue("@CategoryId", categoryid);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }





        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Shows all tickets of employee in tabular view</returns>
        public DataTable ShowAllEmployeeTicketsMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllEmployeeTicketsMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// Maheshwari
        /// </summary>
        /// <returns>Show open & closed tickets of employee in tabular view</returns>
        public DataTable ShowOpenAndClosedEmployeeTicketsMB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Flag", "ShowOpenAndClosedEmployeeTicketsMB");
            cmd.Parameters.AddWithValue("@usercode", empcode);
            cmd.Parameters.AddWithValue("@tlusercode", tlempcode);
            cmd.Parameters.AddWithValue("@FromDate", fromdate);
            cmd.Parameters.AddWithValue("@ToDate", todate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);


            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;
        }


        /// <summary>
        /// Sandeep Ashtagi
        /// </summary>
        /// <returns>Total tickets fetched and count into dasboard</returns>
        public DataTable DashBoardCardsSA()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DashBoardCardsSA");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            // cmd.Parameters.AddWithValue("@CategoryId",CategoryId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adpt.Fill(dt1);

            con.Close();
            return dt1;
        }
        /// <summary>
        /// Sandeep
        /// </summary>
        /// <returns>Fetching all agents into dropdown</returns>
        public DataTable DropDownSA()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DropDownSA");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            //cmd.Parameters.AddWithValue("@CategoryId",CategoryId );
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);

            con.Close();
            return dt2;
        }
        /// <summary>
        /// Sandeep
        /// </summary>
        /// <returns>Chart changes according to tickets</returns>
        public DataTable DropDownIntoChartSA()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DropDownIntoChartSA");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            cmd.CommandTimeout = 60; 

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                
            }
        }


        /// <summary>
        /// sandeep
        /// </summary>
        /// <returns>Fetch  total and resolved tickets into progressbar</returns>
        public DataTable ProgressBarSA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ProgressBarSA");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt4 = new DataTable();
            adpt.Fill(dt4);

            con.Close();  
            return dt4;
        }
        /// <summary>
        /// sandeep
        /// </summary>
        /// <returns>\</returns>
        public DataTable AgentSA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DateTimeSA");
            //cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            adpt.Fill(dt5);

            con.Close();
            return dt5;
        }
        /// <summary>
        /// sandeep
        /// </summary>
        /// <returns> After Clicking on particular Column it will show list</returns>
        public DataTable ColumnChartClick()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ChartClickSA");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt7 = new DataTable();
            adpt.Fill(dt7);

            con.Close();  
            return dt7;
        }

        public DataTable CardClickSA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CardClickSA");
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt7 = new DataTable();
            adpt.Fill(dt7);
            con.Close();

            return dt7;
        }

        public DataTable FetchStatusSA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStatus");
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt7 = new DataTable();
            adpt.Fill(dt7);
            con.Close();

            return dt7;
        }
        /// Create Ticket ////

        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>fetch the Fullname,Email,Contact from tblUser for create ticket</returns>

        public SqlDataReader FullNameContactVN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchFullNameContactVN");
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

        }

        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>fetch the all subject from tblSubject for create ticket to add subject in that</returns>
        public DataTable FetchSubjetVN()
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("SpTickVibe", con);
            adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adpt.SelectCommand.Parameters.AddWithValue("@flag", "FetchSubjectVN");
             
            adpt.SelectCommand.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            adpt.SelectCommand.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            DataTable dt = new DataTable();
            adpt.Fill(dt);


            con.Close();
            return dt;


        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>fetch all  types of Priority from tblPriority to create ticket in which priority user want </returns>
        public DataTable FetchPriorityVN()
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("SpTickVibe", con);
            adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adpt.SelectCommand.Parameters.AddWithValue("@flag", "FetchPriorityVN");
            adpt.SelectCommand.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            adpt.SelectCommand.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            DataTable td = new DataTable();
            adpt.Fill(td);


            con.Close();
            return td;

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>fetch all  types of Category from tblCategory to create ticket in which Category issue user having </returns>
        public DataTable FetchCategoryVN()
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("SpTickVibe", con);
            adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adpt.SelectCommand.Parameters.AddWithValue("@flag", "FetchCategoryVN");
            adpt.SelectCommand.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            adpt.SelectCommand.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            DataTable cdt = new DataTable();
            adpt.Fill(cdt);


            con.Close();
            return cdt;

        }

        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>store the all data of created  ticket in table tblTicket  </returns>

        public void insertTicketVN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "insertTicketVN");
            cmd.Parameters.AddWithValue("@CreatedBy", Createby);
            cmd.Parameters.AddWithValue("@CategoryIds", CategoryId);
            cmd.Parameters.AddWithValue("@PriorityId", Priorityid);
            cmd.Parameters.AddWithValue("@StatusId", Statusid);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@CreatedAt", CreateAt);
            cmd.Parameters.AddWithValue("@SubjectId", Subjectid);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@FileName", FileName);
            cmd.Parameters.AddWithValue("@FilPath", Filepath);
            cmd.Parameters.AddWithValue("@UploadedBy", Uploadedby);
            cmd.Parameters.AddWithValue("@UploadedAt", UploadedAt);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            cmd.ExecuteNonQuery();

            con.Close();

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>if user not found the subject related his issue then he will create his won subject for ticket from frmAddnewSubjcet </returns>
        public void insertsubjectVN()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "inserNewSubjectVN");
            cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>check user created new subject is already exist in list  of tblSubject  if exist then it will give message </returns>
        public SqlDataReader CheckSubjectExistVN()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ReadSubjectMatchingVN");
            cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>fetch all  types of Category from tblCategory to create ticket in which Category issue user having </returns>
        public DataTable FetchViewticketUserVN()
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("SpTickVibe", con);
            adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adpt.SelectCommand.Parameters.AddWithValue("@flag", "FetchViewTicketUserVN");
            adpt.SelectCommand.Parameters.AddWithValue("@CreatedBy", EMPCode);
            adpt.SelectCommand.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            adpt.SelectCommand.Parameters.AddWithValue("@NewPassword", DBNull.Value);

            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }
        /// <summary>
        /// Vishal
        /// </summary>
        ///<returns>it will update raised ticket miss take </returns>
        public void UpdateTicketVN()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdateTicketVN");
            cmd.Parameters.AddWithValue("@TktCode", TktCode);
            cmd.Parameters.AddWithValue("@FilPath", Filepath);
            cmd.Parameters.AddWithValue("@FileName", FileName);
            cmd.Parameters.AddWithValue("@CategoryIds", CategoryId);
            cmd.Parameters.AddWithValue("@PriorityId", Priorityid);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@SubjectId", Subjectid);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.ExecuteNonQuery();


            con.Close();

        }
        public DataTable Agentdaata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpTickVibe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AgentData");
            cmd.Parameters.AddWithValue("@statusID", Id);
            cmd.Parameters.AddWithValue("@UserCode", UserCode);
            cmd.Parameters.AddWithValue("@OldPassword", DBNull.Value);
            cmd.Parameters.AddWithValue("@NewPassword", DBNull.Value);
            cmd.CommandTimeout = 60; // optional

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }

}
