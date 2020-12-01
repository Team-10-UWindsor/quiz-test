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
        QuizDS qds = new QuizDS();
        static List<Dictionary<String, String>> quiz = new List<Dictionary<String, String>>();
        static List<String> q_ans = new List<String>();

        static int count = 1;
        static int hh, mm, ss;
        static double seconds;
        protected void Page_Load(object sender, EventArgs e)
        {

            p_name.Text = Session["P_Name"].ToString();
            p_id.Text = Session["P_EMAIL"].ToString();

            if (!Page.IsPostBack)
            {

                p_name.Text = Session["P_Name"].ToString();
                p_id.Text = Session["P_EMAIL"].ToString();

                quiz = qds.fetchQuiz((int) Session["QID"]);

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand f = new SqlCommand("Select Participant_Id from Participant where Participant_Email = @email", con);
                f.Parameters.AddWithValue("@email", Session["P_EMAIL"].ToString());
                SqlDataReader rd = f.ExecuteReader();
                int pid = -1;
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        pid = (int) rd[0];
                        Session["PID"] = pid;
                    }
                }
                rd.Close();

                SqlCommand cmd = new SqlCommand("Insert into Quiz_Participant (Quiz_Id, Participant_Id) values (@qid, @pid)", con);

                cmd.Parameters.AddWithValue("@qid", (int)Session["QID"]);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.ExecuteNonQuery();

                SqlCommand time = new SqlCommand("Select Quiz_Duration from Quiz where Quiz_Id = @quiz_id", con);
                time.Parameters.AddWithValue("@quiz_id", Session["QID"].ToString());
                SqlDataReader rd1 = time.ExecuteReader();

                seconds = 60;
                if (rd1.HasRows)
                {
                    while (rd1.Read())
                    {
                        //int min = (int)rd1[0];
                        //seconds = min * 60;
                    }
                }
                rd1.Close();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                prev.Visible = false;
                prev.Enabled = false;

                for (int i = 0; i < quiz.Count; i++)
                    q_ans.Add(null);


                //Populating the Quiz
                question_no.Text = "Question 1 of " + quiz.Count();

                Ques_desc.Text = quiz[0]["que_des"];
                optionA.Text = quiz[0]["optionA"];
                optionB.Text = quiz[0]["optionB"];
                optionC.Text = quiz[0]["optionC"];
                optionD.Text = quiz[0]["optionD"];
                
                //Entering questions in Question List
                for(int i = 0; i < quiz.Count; i++)
                {
                    que_list.Items.Insert(i, quiz[i]["que_des"]);
                }
                que_list.SelectedIndex = 0;
            }
        }

        protected void showSelected()
        {
            String s = q_ans[count - 1];
            if (s != null)
            {
                if ((optionA.Text.ToString()).Equals(s))
                {
                    optionA.Checked = true;
                }
                else if ((optionB.Text.ToString()).Equals(s))
                {
                    optionB.Checked = true;
                }
                else if ((optionC.Text.ToString()).Equals(s))
                {
                    optionC.Checked = true;
                }
                else if ((optionD.Text.ToString()).Equals(s))
                {
                    optionD.Checked = true;
                }

            }
        }

        protected void setUncheck()
        {
            optionA.Checked = false;
            optionB.Checked = false;
            optionC.Checked = false;
            optionD.Checked = false;
        }

        protected String selectedAnswer()
        {
            String ans = null;

            RadioButton radio = null;
            if (optionA.Checked)
            {
                radio = optionA;
            }
            else if (optionB.Checked)
            {
                radio = optionB;
            }
            else if (optionC.Checked)
            {
                radio = optionC;
            }
            else if (optionD.Checked)
            {
                radio = optionD;
            }

            if (radio != null)
            {
                ans = radio.Text.ToString();
            }


            return ans;
        }

        protected void done_Click(object sender, EventArgs e)
        {
            

            q_ans[count - 1] = selectedAnswer();


            Evaluate eval = new Evaluate();
            eval.doEvaluate(q_ans, (int) Session["PID"], (int) Session["QID"]);
            //Response.Write("<script>alert('" + percent + "');</script>");
            Session.Clear();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thank you for participating in the Quiz!!');window.location ='Participant_Login.aspx';", true);
            
        }

        protected void next_Click(object sender, EventArgs e)
        {
            q_ans[count - 1] = selectedAnswer();

            count++;
            que_list.SelectedIndex = (count - 1);

            setUncheck();

            prev.Visible = true;
            prev.Enabled = true;

            if (count == quiz.Count())
            {
                next.Visible = false;
                next.Enabled = false;
            }
            question_no.Text = "Question " + count + " of " + quiz.Count();

            Ques_desc.Text = quiz[count - 1]["que_des"];
            optionA.Text = quiz[count - 1]["optionA"];
            optionB.Text = quiz[count - 1]["optionB"];
            optionC.Text = quiz[count - 1]["optionC"];
            optionD.Text = quiz[count - 1]["optionD"];
            if (q_ans[count - 1] != null)
            {
                showSelected();
            }
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            q_ans[count - 1] = selectedAnswer();

            count--;
            que_list.SelectedIndex = (count - 1);
            setUncheck();
            next.Visible = true;
            next.Enabled = true;

            if (count == 1)
            {
                prev.Visible = false;
                prev.Enabled = false;
            }

            question_no.Text = "Question " + count + " of " + quiz.Count();

            Ques_desc.Text = quiz[count - 1]["que_des"];
            optionA.Text = quiz[count - 1]["optionA"];
            optionB.Text = quiz[count - 1]["optionB"];
            optionC.Text = quiz[count - 1]["optionC"];
            optionD.Text = quiz[count - 1]["optionD"];

            if (q_ans[count - 1] != null)
            {
                showSelected();
            }

        }

        protected void que_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            q_ans[count - 1] = selectedAnswer();
            count = que_list.SelectedIndex + 1;
            setUncheck();

            if(count == quiz.Count)
            {
                next.Visible = false;
                next.Enabled = false;
            }
            else
            {
                next.Visible = true;
                next.Enabled = true;
            }
            
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

            question_no.Text = "Question " + count + " of " + quiz.Count();

            Ques_desc.Text = quiz[count - 1]["que_des"];
            optionA.Text = quiz[count - 1]["optionA"];
            optionB.Text = quiz[count - 1]["optionB"];
            optionC.Text = quiz[count - 1]["optionC"];
            optionD.Text = quiz[count - 1]["optionD"];

            if (q_ans[count - 1] != null)
            {
                showSelected();
            }
        }

       protected void duration_timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds = seconds - 1;
            }

            TimeSpan time_Span = TimeSpan.FromSeconds(seconds);
            hh = time_Span.Hours;
            mm = time_Span.Minutes;
            ss = time_Span.Seconds;

            cdtimer.Text = " " + hh + ": " + mm + ": " + ss;
        }
    }
}