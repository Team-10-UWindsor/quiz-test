using System;
using System.Collections.Generic;
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
    public partial class Reports : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con = new SqlConnection("strcon");
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                RepeterData();
            }

        }

        public void RepeterData()
        {
            con.Open();
            cmd = new SqlCommand("Select * from Comment Order By Post_Date desc", con);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            RepterDetails.DataSource = ds;
            RepterDetails.DataBind();
        }

    }
}