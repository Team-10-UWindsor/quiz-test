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
    public partial class Quiz_Main : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Question ", con);
                //SqlCommand cmd1 = new SqlCommand("Select * from Options ", con);


                //SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                //SqlDataAdapter sdr1 = new SqlDataAdapter(cmd1);
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border='1'>");
                table.Append("<tr><th>Question 1 </th></tr>");
                table.Append("<tr><th>-------------------------------------------------------------------------------------------------------------------- </th></tr>");

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("</tr>");
                        //  Response.Write("<script>alert('" + rd.GetValue(1).ToString() + "');</script>");
                    }

                }

                table.Append("</table>");

                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

                rd.Close();


            }

        }
    }
}