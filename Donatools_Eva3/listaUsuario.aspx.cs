using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Donatools_Eva3.Controllers;

namespace Donatools_Eva3
{
    public partial class listaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();

            //Validación de sesión
            if (Session["user"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("login.aspx");
            }
        }

        public void cargarGrid()
        {
            grdUsuario.DataSource = from m in usuarioController.getAll()
                                    select new
                                    {
                                        Código = m.CodigoUsuario,
                                        Rut = m.Rut,
                                        Nombre = m.Nombre + " " + m.Apellido,
                                        Edad = m.Edad + " años",
                                        Correo = m.Mail,
                                        Telefono = m.Telefono
                                    };
            grdUsuario.DataBind();
        }

        protected void lnkNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("registroUsuario.aspx");
        }
    }
}