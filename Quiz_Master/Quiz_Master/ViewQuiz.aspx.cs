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
    public partial class ViewQuiz : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["Name"] = "Anish";
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Quiz", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                
                // Repeater Rpt1 = (Repeater)Master.FindControl("Repeater_1");
                Repeater_2.DataSource = dt;
                Repeater_2.DataBind();


            }
        }
    }
}