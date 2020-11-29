using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class QuizCreate : System.Web.UI.Page
    {
        Dictionary<String, String> que=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

            }
        }

        protected void done_Click(object sender, EventArgs e)
        {
               
            

        }

        protected void next_Click(object sender, EventArgs e)
        {
            List<Dictionary<String, String>> quiz = new List<Dictionary<String, String>>();


            var question = "";
            var Option1 = "";
            var Option2 = "";
            var Option3 = "";
            var Option4 = "";
            var Solution = "";

            question = Request.QueryString["question"];
            Option1 = Request.QueryString["enteroption1"];
            Option2 = Request.QueryString["enteroption2"];
            Option3 = Request.QueryString["enteroption3"];
            Option4 = Request.QueryString["enteroption4"];
            Solution = Request.QueryString["entersolution"];

            var items = from pair in que
                       select pair;

            que.Add("question", question);
            que.Add("Option1", Option1);
            que.Add("Option2", Option2);
            que.Add("Option3", Option3);
            que.Add("Option4", Option4);
            que.Add("Solution", Solution);

            Response.Write("<script>alert('" + question + "')</script>");

            quiz.Add(que);






            foreach (KeyValuePair<string, string> pair in que)
            {
                //Console.log(pair.Key);
                Response.Write("<script>alert('" + pair.Value + "')</script>");
            }

            Response.Write("<script>alert('" + question + "')</script>");

        }
    }
}