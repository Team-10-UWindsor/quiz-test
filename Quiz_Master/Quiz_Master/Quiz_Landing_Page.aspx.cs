using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class Quiz_Landing_Page : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["q_id"] != null && Request.QueryString["q_id"] != string.Empty)
                {
                    Session["Quiz_Id"] = Request.QueryString["q_id"].ToString();
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            
            try
            {
                con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Insert into Participant (Participant_Name, Participant_Email) values (@ParticipantName,@ParticipantEmail)", con);

                cmd.Parameters.AddWithValue("@ParticipantName", Participant_name.Text.Trim());
                cmd.Parameters.AddWithValue("@ParticipantEmail", Participant_Email.Text.Trim());
                cmd.ExecuteNonQuery();

                Session["P_EMAIL"] = Participant_Email.Text.Trim();
                Session["P_Name"] = Participant_name.Text.Trim();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + " ');</script>");
            }
            
            Response.Write("<script>alert('Good luck for the quiz, " + Participant_name.Text.Trim() + "! ');</script>");
            Response.Redirect("Quiz_Main.aspx");
        }
    }
}