using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
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

        public List<Dictionary<String, String>> createQuiz(int quiz_id)
        {

            var que = "";

             
        }

    }
}