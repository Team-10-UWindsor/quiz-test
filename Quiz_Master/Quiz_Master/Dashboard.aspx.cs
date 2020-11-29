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
           
                // quiz.ClearSelection();
               emp_name.Text = Session["activeUser"].ToString();
               emp_id.Text = Session["activeUserId"].ToString();            
        }

        protected void next_Click(object sender, EventArgs e)
        {

        }
    }
}