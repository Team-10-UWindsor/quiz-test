using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public class QuizDS
    {
        
        String que_des;
        String que_soln;
        String optionA;
        String optionB;
        String optionC;
        String optionD;

        int quiz_id;
        int emp_id;
        static DateTime pd;
        
        Dictionary<String, String> que;
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public QuizDS()
        {
            this.que = null;
        }

        public List <Dictionary<String, String>> fetchQuiz(int quiz_id)
        {
            List <Dictionary<String, String>> quiz = new List<Dictionary<String, String>>();

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand que_id = new SqlCommand("Select Question_Id from Quiz_Question where Quiz_Id = @Quiz_id", con);
            que_id.Parameters.AddWithValue("@Quiz_id", quiz_id);

            que_id.ExecuteNonQuery();

            SqlDataReader rd = que_id.ExecuteReader();

            ArrayList id = new ArrayList();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    id.Add(rd[0].ToString());
                }
            }
            rd.Close();

           if (id.Count > 0)
            {
                foreach(String i in id)
                {
                    que = new Dictionary<String, String>();

                    SqlCommand cmd3 = new SqlCommand("Select * from Question where Question_id = @Que_id ", con);
                    
                    cmd3.Parameters.AddWithValue("@Que_id", i);
                    

                    cmd3.ExecuteNonQuery();

                    SqlDataReader rd1 = cmd3.ExecuteReader();
                    if (rd1.HasRows)
                    {
                        while (rd1.Read())
                        {
                            que_des = rd1[1].ToString();
                            que_soln = rd1[2].ToString();
                        }
                    }
                    rd1.Close();

                    SqlCommand cmd2 = new SqlCommand("Select * from Options where Question_id = @Que_id ", con);
                    cmd2.Parameters.AddWithValue("@Que_id", i);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (rd2.HasRows)
                    {
                        while (rd2.Read())
                        {
                            optionA = rd2[1].ToString();
                            optionB = rd2[2].ToString();
                            optionC = rd2[3].ToString();
                            optionD = rd2[4].ToString();
                        }
                    }
                    rd2.Close();

                    que.Add("que_des", que_des);
                    que.Add("que_soln", que_soln);
                    que.Add("optionA", optionA);
                    que.Add("optionB", optionB);
                    que.Add("optionC", optionC);
                    que.Add("optionD", optionD);

                    quiz.Add(que);

                }
            }
            rd.Close();
            
            return quiz;
        }

        public void uploadQuiz(List<Dictionary<String, String>> quiz, int emp_id)
        {
            pd = System.DateTime.Now;
            this.emp_id = emp_id;

            SqlConnection con = new SqlConnection(strcon);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into Quiz (Quiz_Name, Quiz_Publishdate, Quiz_Duration, Employer_Id) values (@qname, @qpd, @dur, @eid)", con);
            cmd.Parameters.AddWithValue("@qname", "Quiz");
            cmd.Parameters.AddWithValue("@qpd", pd);
            cmd.Parameters.AddWithValue("@dur", 30);
            cmd.Parameters.AddWithValue("@eid", emp_id);
            cmd.ExecuteNonQuery();

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            uploadQuestion(quiz);
            uploadOptions(quiz);
        }

        public void uploadQuestion(List<Dictionary<String, String>> quiz)
        {
            SqlConnection con = new SqlConnection(strcon);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into Question (Question_Description, Question_Solution) values (@desc, @soln)", con);
            for(int i = 0; i< quiz.Count; i++)
            {
                cmd.Parameters.AddWithValue("@desc", quiz[i]["que_des"]);
                cmd.Parameters.AddWithValue("@soln", quiz[i]["que_soln"]);
                cmd.ExecuteNonQuery();
            }
            
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

        public void uploadOptions(List<Dictionary<String, String>> quiz)
        {
            SqlConnection con = new SqlConnection(strcon);
            List<int> q_id = new List<int>();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand quizcmd = new SqlCommand("Select Quiz_Id from Quiz where Employer_Id = @eid and Quiz_Publishdate = @pd", con);
            quizcmd.Parameters.AddWithValue("@eid", emp_id);
            quizcmd.Parameters.AddWithValue("@pd", pd);
            SqlDataReader quizdr = quizcmd.ExecuteReader();
            if (quizdr.HasRows)
            {
                while (quizdr.Read())
                {
                    quiz_id = (int)quizdr[0];
                }
            }
            quizdr.Close();

            SqlCommand cmd1 = new SqlCommand("Select Question_Id from Question where Question_Description = @qd and Question_Solution = @qs", con);
            for(int i = 0; i < quiz.Count; i++)
            {
                cmd1.Parameters.AddWithValue("@qd", quiz[i]["que_des"].ToString());
                cmd1.Parameters.AddWithValue("@qs", quiz[i]["que_soln"].ToString());

                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        q_id.Add((int)dr[0]);
                    }
                }
                dr.Close();
            }

            SqlCommand cmd = new SqlCommand("Insert into Options (Question_Id, OptionA, OptionB, OptionC, OptionD) values (@que_id, @optA, @optB, @optC, @optD)", con);
            SqlCommand cmd2 = new SqlCommand("Insert into Quiz_Question (Question_Id, Quiz_Id) values (@que_id, @q_id)", con);

            for (int i = 0; i < quiz.Count && i < q_id.Count; i++)
            {
                cmd2.Parameters.AddWithValue("@que_id", q_id[i]);
                cmd2.Parameters.AddWithValue("@q_id", quiz_id);
                cmd2.ExecuteNonQuery();
            }

                for (int i = 0; i < quiz.Count && i < q_id.Count; i++)
            {
                cmd.Parameters.AddWithValue("@que_id", q_id[i]);
                cmd.Parameters.AddWithValue("@optA", quiz[i]["optionA"]);
                cmd.Parameters.AddWithValue("@optB", quiz[i]["optionB"]);
                cmd.Parameters.AddWithValue("@optC", quiz[i]["optionC"]);
                cmd.Parameters.AddWithValue("@optD", quiz[i]["optionD"]);
                cmd.ExecuteNonQuery();
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}