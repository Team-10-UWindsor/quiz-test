using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Quiz_Master
{
    public class Evaluate
    {

        float percent = 0;
        List<Dictionary<String, String>> quiz = new List<Dictionary<String, String>>();
        QuizDS qds = new QuizDS();
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public void doEvaluate(List<String> q_ans, int pid, int qid)
        {
            quiz = qds.fetchQuiz(qid);
            //Total number of questions
            int N = quiz.Count;

            for(int i = 0; i < N; i++)
            {
                String solution = quiz[i]["que_soln"];
                String ans = q_ans[i];
                if(ans != null)
                {
                    if ((solution.ToLower()).Equals(ans.ToLower()))
                    {
                        percent++;
                    }
                }
                

            }
            percent = (percent / N) * 100;

            uploadReport(percent, pid, qid);

        }

        private void uploadReport(float percent, int pid, int qid)
        {
            SqlConnection con = new SqlConnection(strcon);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into Evaluation (Percentage, Participant_Id, Quiz_Id) values (@percent, @pid, @qid)", con);

            cmd.Parameters.AddWithValue("@percent", percent);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@qid", qid);
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}