using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Donatools_Eva3
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["user"] == null)
                {
                    Menu1.Visible = false;
                    Menu2.Visible = true;
                }
                else
                {
                    Menu1.Visible = true;
                    Menu2.Visible = false;
                }
            }
        }
    }
}