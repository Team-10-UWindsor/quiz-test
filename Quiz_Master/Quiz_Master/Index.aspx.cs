using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Master
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Employer_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employer_Login.aspx");
        }

        protected void Participant_Click(object sender, EventArgs e)
        {
            Response.Redirect("Participant.aspx");
        }
    }
}