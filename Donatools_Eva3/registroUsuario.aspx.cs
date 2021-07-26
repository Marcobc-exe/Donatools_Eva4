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
            cargarDrop();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = usuarioController.addUsuario(
                txtRut.Text, 
                txtNombre.Text, 
                txtApellido.Text, 
                txtEdad.Text,
                dropGenero.SelectedValue, 
                txtMail.Text, 
                txtTelefono.Text, 
                txtUsername.Text, 
                txtPassword.Text
                );
        }
        public void cargarDrop()
        {

            dropGenero.DataSource = from g in GeneroController.getAll()
                                     select new
                                     {
                                         genero = g.genero1 ,
                                         codigo = g.id_genero
                                     };
            dropGenero.DataValueField = "codigo";
            dropGenero.DataTextField = "genero";
            dropGenero.DataBind();

        }
    }
}