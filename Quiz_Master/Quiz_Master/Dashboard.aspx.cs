using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //report.Checked = false;
                // quiz.ClearSelection();
               emp_name.Text = Session["activeUser"].ToString();
               emp_id.Text = Session["activeUserId"].ToString();
            
        }

        protected void next_Click(object sender, EventArgs e)
        {

            if (report.Checked && quiz.Checked)
            {
                uncheck();
            }
            else if (quiz.Checked)
            {
                Response.Redirect("ViewQuiz.aspx");
            }
            else if (report.Checked)
            {
                Response.Redirect("Reports.aspx");
            }

        }
        void uncheck()
        {
            report.Checked = false;
            quiz.Checked = false;
        }
    }
}