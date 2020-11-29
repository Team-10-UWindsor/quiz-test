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
    public partial class Employer_Login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Sign In button is clicked
        protected void signin_Click(object sender, EventArgs e)
        {
            string Employer_Name = string.Empty;
            int Employer_Id;

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Select * from Employer where Employer_Name ='"+user_name.Text.Trim()+"' AND Employer_Password='"+password.Text.Trim()+"'", con);

                SqlDataReader dr = cmd.ExecuteReader();
                Response.Redirect("Dashboard.aspx");
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                       // Response.Write("<script>alert('" + dr.GetValue(1).ToString() + "');</script>");
                    }

                    Response.Redirect("Dashboard.aspx");
                    Employer_Name = dr[1].ToString();
                    Session["activeUser"] = Employer_Name;
                }
                else
                {
                   // Response.Write("<script>alert('Invalid Credentials')</script>");
                }

            }
            catch(Exception ex)
            {
                //Response.Write("<script>alert('" + ex.Message + " ');</script>");
            }
        }

    }
}