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
    public partial class EmployerLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int checkbox_flag =0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sign_Up.aspx");
        }

        protected void signin_Click(object sender, EventArgs e)
        {
            {
                string Employer_Name = string.Empty;
                string Employer_Id;
                if (checkbox_flag == 1)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlCommand cmd = new SqlCommand("Select * from Employer where Employer_Name ='" + user_name.Text.Trim() + "' AND Employer_Password='" + password.Text.Trim() + "'", con);
                        SqlCommand cmd1 = new SqlCommand("Select Employer_Id from Employer where Employer_Name ='" + user_name.Text.Trim() + "' AND Employer_Password='" + password.Text.Trim() + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();

                        //Response.Redirect("Dashboard.aspx");
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Employer_Name = user_name.Text;
                                Session["activeUser"] = Employer_Name;
                                Employer_Id = dr[0].ToString();
                                Session["activeUserId"] = Employer_Id;

                                // Response.Write("<script>alert('" + dr.GetValue(1).ToString() + "');</script>");
                            }
                            Response.Redirect("Dashboard.aspx");



                        }
                        else
                        {
                            Response.Write("<script>alert('Invalid Credentials')</script>");
                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + " ');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Please accept the term and condition by clicking the checkbox');</script>");
                }
            }
        }

        protected void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                checkbox_flag = 1;
            }
        }
    }
}