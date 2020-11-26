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
    public partial class Test : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        System.Text.StringBuilder t1 = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!Page.IsPostBack)
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Question ", con);
                    SqlCommand cmd1 = new SqlCommand("Select * from Options ", con);


                    //SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    //SqlDataAdapter sdr1 = new SqlDataAdapter(cmd1);
                    
                    SqlDataReader rd = cmd.ExecuteReader();
                    
                    t1.Append("<table border='0' >");
                    t1.Append("<tr><th>Question 1 </th></tr>");

                    StringBuilder table = new StringBuilder();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            table.AppendLine(@"<tr>");
                           // table.AppendLine(@"<td>{0} Question</td></tr>");
                            table.AppendLine(@"<td><input type=""radio"" id=""rb1_{2}"" name=""options{2}"" value=""A""> A) <label for=""rb1_{2}"">{3}</label></td>");
                            table.Append("<td>" + rd[1] + "</td>");
                            table.Append("</tr>");
                            //  Response.Write("<script>alert('" + rd.GetValue(1).ToString() + "');</script>");
                        }

                    }
                    rd.Close();
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    if (rd1.HasRows)
                    {
                        while (rd1.Read())
                        {
                            table.Append("<tr>");
                            table.Append("<td>");
                            table.AppendLine(@"<asp:RadioButton ID='RadioButton1' runat='server' Text='" + rd1[1] + "'/>");
                            table.Append("</td>");
                            //table.Append("<td>" + rd1[1] + "</td>");
                            table.Append("<td>" + rd1[2] + "</td>");
                            table.Append("<td>" + rd1[3] + "</td>");
                            table.Append("<td>" + rd1[4] + "</td>");
                            table.Append("</tr>");
                            //  Response.Write("<script>alert('" + rd.GetValue(1).ToString() + "');</script>");
                        }

                    }


                    t1.Append("</table>");

                    PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

                    


                }
            }
        }
    }
}