using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Donatools_Eva3
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!Page.IsPostBack)
            {

                if (Session["user"] != null)
                {
                        Session.Abandon();
                        Response.Redirect("login.aspx");
                }
            }
        }
    }
}