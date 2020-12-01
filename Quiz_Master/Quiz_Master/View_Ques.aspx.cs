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
    public partial class View_Ques : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            emp_name.Text = Session["activeUser"].ToString();
            emp_id.Text = Session["activeUserId"].ToString();
            Quiz_Name.Text = Session["Quiz_Name"].ToString();

            if (!IsPostBack)
            {
                String query = "SELECT Question_Description FROM   Question WHERE  Question_Id IN (SELECT Question_Id FROM[dbo].[Quiz_Question] Where Quiz_Id ="+ Session["Quiz_Name"].ToString()+")";
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // Repeater Rpt1 = (Repeater)Master.FindControl("Repeater_1");
                Repeater_3.DataSource = dt;
                Repeater_3.DataBind();


            }
        }

        protected void publish_Click(object sender, EventArgs e)
        {
           // Response.Write("<script>alert('Quiz Created successfully')</script>");
           // Response.Redirect("Dashboard.aspx");
            ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('Quiz Created Successfully');window.location ='Dashboard.aspx';",true);
        }
    }
}