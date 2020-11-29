﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Quiz_Master
{
    public partial class View_Ques : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Question_Description FROM   Question WHERE  Question_Id IN (SELECT Question_Id FROM[dbo].[Quiz_Question] Where Quiz_Id = 1)", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // Repeater Rpt1 = (Repeater)Master.FindControl("Repeater_1");
                Repeater_3.DataSource = dt;
                Repeater_3.DataBind();


            }
        }
    }
}