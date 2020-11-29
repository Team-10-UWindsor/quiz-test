using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class Reports : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter sda = new SqlDataAdapter("Select Participant.Participant_Name, [dbo].[Evaluation].Percentage from Evaluation Inner Join Participant On [dbo].[Participant].Participant_Id =[dbo].[Evaluation].Participant_Id",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Repeater Rpt1 = (Repeater)Master.FindControl("Repeater_1");
                //Repeater_1.DataSource = dt;
                //Repeater_1.DataBind();


            }

        }


        protected void done_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}