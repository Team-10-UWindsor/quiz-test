using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Quiz_Master
{
    public partial class Reports : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {


            emp_name.Text = Session["activeUser"].ToString();
            emp_id.Text = Session["activeUserId"].ToString();

            if (!IsPostBack)
            {

                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter sda = new SqlDataAdapter("Select Participant.Participant_Name, [dbo].[Evaluation].Percentage from Evaluation Inner Join Participant On [dbo].[Participant].Participant_Id =[dbo].[Evaluation].Participant_Id", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // Repeater Rpt1 = (Repeater)Master.FindControl("Repeater_1");
                Repeater_1.DataSource = dt;
                Repeater_1.DataBind();
                Repeater_2.DataSource = dt;
                Repeater_2.DataBind();


            }

        }


        protected void done_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}