using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Donatools_Eva3.Modelo;
using Donatools_Eva3.Controllers;
using System.Drawing;

namespace Donatools_Eva3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["error"] != null)
            {
                lblMensaje2.Text = Session["error"].ToString();
                lblMensaje2.ForeColor = Color.Red;
                Session["error"] = null;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            Usuario usuario = loginController.login(txtUsername.Text, txtPassword.Text);
            if (usuario != null)
            {
                Session["user"] = usuario;
                Response.Redirect("listaUsuario.aspx");

            }
            else
            {
                lblMensaje2.Text = "Datos ingresados no coinciden";
            }
        }
    }
}