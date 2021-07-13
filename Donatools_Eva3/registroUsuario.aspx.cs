using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Donatools_Eva3.Clases;
using Donatools_Eva3.Controllers;

namespace Donatools_Eva3
{
    public partial class registroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioController.fillUsuarios();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = usuarioController.addUsuario(
                txtRut.Text, 
                txtCodigo.Text, 
                txtNombre.Text, 
                txtApellido.Text, 
                txtEdad.Text,
                rblGenero.SelectedValue, 
                txtMail.Text, 
                txtTelefono.Text, 
                txtUsername.Text, 
                txtPassword.Text);
        }
    }
}