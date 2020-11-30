using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class Generate_Quiz : System.Web.UI.Page
    {
        QuizDS qds = new QuizDS();
        static List<Dictionary<String, String>> quiz = new List<Dictionary<String, String>>();

        static int count = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                que_no.Text = count.ToString() + ".";
                prev.Enabled = false;
                prev.Visible = false;
            }
        }

        protected void done_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> que = new Dictionary<String, String>();

            que.Add("que_des", question.Text.ToString());
            que.Add("optionA", optionA.Text.ToString());
            que.Add("optionB", optionB.Text.ToString());
            que.Add("optionC", optionC.Text.ToString());
            que.Add("optionD", optionD.Text.ToString());

            String soln = selectedAnswer();
            if (soln != null)
            {
                que.Add("que_soln", soln.Trim());
                if (count <= quiz.Count)
                {
                    quiz[count - 1] = que;
                }
                else
                {
                    quiz.Add(que);
                }
                int quiz_id = qds.uploadQuiz(quiz, (int)Session["activeUserId"], Session["Quiz_Name"].ToString(), (int)Session["Duration"]);
                Session["Quiz_Id"] = quiz_id;
                Response.Redirect("View_Ques.aspx");

            }
            else
            {
                Response.Write("<script>alert('Select a solution...');</script>");
            }
        }

        protected void autoPopulate()
        {
            Dictionary<String, String> que = quiz[count - 1];

            question.Text = que["que_des"].ToString();
            optionA.Text = que["optionA"].ToString();
            optionB.Text = que["optionB"].ToString();
            optionC.Text = que["optionC"].ToString();
            optionD.Text = que["optionD"].ToString();
            if(que["que_soln"] != null)
            {
                if ((optionA.Text.ToString().Trim()).Equals(que["que_soln"].ToString().Trim()))
                {
                    rdA.Checked = true;
                }
                else if ((optionB.Text.ToString().Trim()).Equals(que["que_soln"].ToString().Trim()))
                {
                    rdB.Checked = true;
                }
                else if ((optionC.Text.ToString().Trim()).Equals(que["que_soln"].ToString().Trim()))
                {
                    rdC.Checked = true;
                }
                else if ((optionD.Text.ToString().Trim()).Equals(que["que_soln"].ToString().Trim()))
                {
                    rdD.Checked = true;
                }
            }


        }

        protected void setUncheck()
        {
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
            question.Text = null;
            optionA.Text = null;
            optionB.Text = null;
            optionC.Text = null;
            optionD.Text = null;
        }

        protected String selectedAnswer()
        {
            String ans = null;

            if (rdA.Checked)
            {
                ans = optionA.Text.ToString();
            }
            else if (rdB.Checked)
            {
                ans = optionB.Text.ToString();
            }
            else if (rdC.Checked)
            {
                ans = optionC.Text.ToString();
            }
            else if (rdD.Checked)
            {
                ans = optionD.Text.ToString();
            }
            return ans;
        }

        protected void next_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> que = new Dictionary<String, String>();
            
            que.Add("que_des", question.Text.ToString());
            que.Add("optionA", optionA.Text.ToString());
            que.Add("optionB", optionB.Text.ToString());
            que.Add("optionC", optionC.Text.ToString());
            que.Add("optionD", optionD.Text.ToString());

            
            String soln = selectedAnswer();
            if (soln != null)
             {
                que.Add("que_soln", soln.Trim());
                if (count <= quiz.Count)
                {
                    quiz[count - 1] = que;
                }
                else
                {
                    quiz.Add(que);
                }

                count++;
                que_no.Text = count.ToString() + ".";
                if (count == 1)
                {
                    prev.Visible = false;
                    prev.Enabled = false;
                }
                else
                {
                    prev.Visible = true;
                    prev.Enabled = true;
                }
                if (count <= quiz.Count)
                {
                    setUncheck();
                    autoPopulate();
                }
                else
                {
                    setUncheck();
                }
            }
            else
             {
                Response.Write("<script>alert('Select a solution...');</script>");
             }
            
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            //count--;
            Dictionary<String, String> que = new Dictionary<String, String>();

            que.Add("que_des", question.Text.ToString());
            que.Add("optionA", optionA.Text.ToString());
            que.Add("optionB", optionB.Text.ToString());
            que.Add("optionC", optionC.Text.ToString());
            que.Add("optionD", optionD.Text.ToString());

            String soln = selectedAnswer();
            if (soln != null)
            {
                que.Add("que_soln", soln.Trim());
                if (count <= quiz.Count)
                {
                    quiz[count - 1] = que;
                }
                else
                {
                    quiz.Add(que);
                }

                count--;
                setUncheck();
                que_no.Text = count.ToString() + ".";
                autoPopulate();
                if (count == 1)
                {
                    prev.Visible = false;
                    prev.Enabled = false;
                }

            }
            else
            {
                Response.Write("<script>alert('Select a solution...');</script>");
            }            
        }

    }
}