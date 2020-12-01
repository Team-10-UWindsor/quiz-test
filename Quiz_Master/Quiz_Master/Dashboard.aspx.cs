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
            quiz_name.Enabled = false;
            quiz_name.Visible = false;
            duration.Enabled = false;
            duration.Visible = false;
            emp_name.Text = Session["activeUser"].ToString();
            emp_id.Text = Session["activeUserId"].ToString();
        }

        protected void next_Click(object sender, EventArgs e)
        {

            if (quiz.Checked)
            {
                Session["Quiz_Name"] = quiz_name.Text.ToString();
                Session["Duration"] = Int32.Parse(duration.Text);
                Response.Redirect("Generate_Quiz.aspx");
            }
            else if (report.Checked)
            {
                Response.Redirect("ViewQuiz.aspx");
            }
            else
            {
                Response.Write("<script>alert('Select one of the Options');</script>");
            }

        }
        void uncheck()
        {
            report.Checked = false;
            quiz.Checked = false;
        }

        protected void quiz_CheckedChanged(object sender, EventArgs e)
        {
            if (quiz.Checked)
            {
                quiz_name.Enabled = true;
                quiz_name.Visible = true;
                duration.Enabled = true;
                duration.Visible = true;
            }
            else
            {
                quiz_name.Enabled = false;
                quiz_name.Visible = false;
                duration.Enabled = false;
                duration.Visible = false;
            }
        }

        protected void report_CheckedChanged(object sender, EventArgs e)
        {
            if (report.Checked)
            {
                quiz_name.Enabled = false;
                quiz_name.Visible = false;
                duration.Enabled = false;
                duration.Visible = false;
            }
            else
            {
                quiz_name.Enabled = true;
                quiz_name.Visible = true;
                duration.Enabled = true;
                duration.Visible = true;
            }
        }
    }
}