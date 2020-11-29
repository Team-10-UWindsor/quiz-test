using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Quiz_Master
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int checkbox_flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sign_up_Click(object sender, EventArgs e)
        {
            if (checkbox_flag == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Insert into Employer (Employer_Name, Employer_Password,Phone,Email) values (@EmployerName,@EmployerPassword,@Phone,@Email)", con);

                    //cmd.Parameters.AddWithValue("@EmoloyerId", "1");
                    cmd.Parameters.AddWithValue("@EmployerName", username.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmployerPassword", password.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", phone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", emailId.Text.Trim());


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Sign Up Successfull !!!! ');</script>");
                    con.Close();
                    Response.Redirect("Employer_Login.aspx");
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

        protected void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox.Checked)
            {
                checkbox_flag = 1;
            }
        }
    }
}