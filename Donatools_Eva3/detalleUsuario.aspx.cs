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
    public partial class detalleUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("login.aspx");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario usuario = usuarioController.findUsuario(txtBuscar.Text);

            if (usuario != null)
            {
                lblMensaje.Text = "Usuario encontrado";
                lblMensaje.ForeColor = Color.Green;
                Panel1.Visible = true;

                //LLamado de los atributos del Usuario
                hdnCodigo.Value = usuario.id_usuario.ToString();// valor oculto
                txtRut.Text = usuario.rut.Normalize();
                txtNombre.Text = usuario.nombre;
                txtApellido.Text = usuario.apellido;
                txtEdad.Text = usuario.edad + " años";
                rblGenero.SelectedValue = usuario.genero_fk.ToString();
                txtMail.Text = usuario.mail;
                txtTelefono.Text = usuario.telefono.ToString();
                txtCodigo.Text = usuario.id_usuario.ToString();
                Session["user"] = usuario; //Se crea una sesión y se almacena.
            }
            else
            {
                lblMensaje.Text = "Usuario no encontrado";
                lblMensaje.ForeColor = Color.Red;
                Panel1.Visible = false;
            }
        }

        protected void lnkEditar_Click(object sender, EventArgs e)
        {
            if (lnkEditar.Text.Equals("Modificar"))
            {
                txtRut.Enabled = true;
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtEdad.Enabled = true;
                rblGenero.Enabled = true;
                txtMail.Enabled = true;
                txtTelefono.Enabled = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                lnkEditar.Text = "Cancelar";
            }
            else
            {
                txtRut.Enabled = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtEdad.Enabled = false;
                rblGenero.Enabled = false;
                txtMail.Enabled = false;
                txtTelefono.Enabled = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                lnkEditar.Text = "Modificar";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            lbMensaje2.Text = usuarioController.editUsuario(
                txtCodigo.Text, 
                txtNombre.Text, 
                txtApellido.Text, 
                txtEdad.Text, 
                rblGenero.SelectedValue, 
                txtMail.Text, 
                txtTelefono.Text, 
                txtRut.Text);
            Usuario usuario = (Usuario)Session["user"];
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lbMensaje2.Text = usuarioController.deleteUsuario(hdnCodigo.Value);
            Session["user"] = null;
        }

    }
}