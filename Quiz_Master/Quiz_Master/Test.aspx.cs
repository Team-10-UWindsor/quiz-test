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
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Question where Question_id=2", con);
                    SqlCommand cmd1 = new SqlCommand("Select * from Options  where Question_id=2", con);


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
                            table.Append("<tr>");
                            table.Append("<td>" + rd[1] + "</td>");
                            table.Append("</br>");
                            table.Append("</br>");
                            table.Append("</tr>");
                            table.Append("<td></td>");
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
                            table.AppendLine(@"<input type=""radio"" ID=""RadioButton1"" name= ""option"" runat=""server"" >");
                            table.Append("</td>");
                            table.Append(@"<label for=""RadioButton1"">" + rd1[1] + "</label><br>");
                            table.AppendLine(@"<input type=""radio"" ID=""RadioButton2"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""RadioButton2"">" + rd1[2] + "</label><br>");
                            table.AppendLine(@"<input type=""radio"" ID=""RadioButton3"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""RadioButton3"">" + rd1[3] + "</label><br>");
                            table.AppendLine(@"<input type=""radio"" ID=""RadioButton4"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""RadioButton4"">" + rd1[4] + "</label><br>");
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