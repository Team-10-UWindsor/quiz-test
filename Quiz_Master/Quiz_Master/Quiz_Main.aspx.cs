using System;
using System.Collections.Generic;
using System.Collections;
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
                if (!Page.IsPostBack)
                {

                    List< Dictionary < String, String >> quiz = new List<Dictionary<String, String>>();
                    QuizDS qds = new QuizDS();

                    quiz = qds.fetchQuiz(1);


                    /*SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Question where Question_id = 1 ", con);
                    SqlCommand cmd1 = new SqlCommand("Select * from Options where Question_id = 1 ", con);
                    //SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    //SqlDataAdapter sdr1 = new SqlDataAdapter(cmd1);

                    SqlDataReader rd = cmd.ExecuteReader();

                    table.Append("<table border='0' width = 2000px>");

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            table.Append("<tr>");
                            table.Append("<td>");
                            table.Append(@"<label>" + quiz[0
                                ]["que_des"] + "</label><br>");
                            table.Append("</td>");
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
                            table.AppendLine(@"<input type=""radio"" ID=""optionA"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""optionA"">" + rd1[1] + "</label><br>");
                            table.Append("</td>");

                            table.Append("</tr>");

                            table.Append("<tr>");
                            table.Append("<td>");
                            table.AppendLine(@"<input type=""radio"" ID=""optionB"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""optionB"">" + rd1[2] + "</label><br>");
                            table.Append("</td>");

                            table.Append("<tr>");
                            table.Append("<td>");
                            table.AppendLine(@"<input type=""radio"" ID=""optionC"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""optionC"">" + rd1[3] + "</label><br>");
                            table.Append("</td>");

                            table.Append("<tr>");
                            table.Append("<td>");
                            table.AppendLine(@"<input type=""radio"" ID=""optionD"" name= ""option"" runat=""server"" >");
                            table.Append(@"<label for=""optionD"">" + rd1[4] + "</label><br>");
                            table.Append("</td>");
                            table.Append("</tr>");
                            //  Response.Write("<script>alert('" + rd.GetValue(1).ToString() + "');</script>");
                        }

                    }
                    rd1.Close();

                    cmd.Dispose();
                    cmd1.Dispose();

                    table.Append("</table>");

                    PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

                    con.Close();
                    */

                }
            }

        }
    }
}