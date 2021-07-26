using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Donatools_Eva3.Controllers;
using Donatools_Eva3.Modelo;

namespace Donatools_Eva3
{
    public partial class donacionFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("login.aspx");
            }
            txtFecha.Enabled = false;
            if (!IsPostBack)
            {
                calFecha.Visible = false;
            }
        }

        protected void btnCrearDonacion_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario) Session["user"];
            lblMensaje.Text = DonacionController.addDonacion(usuario.id_usuario.ToString(), txtTitulo.Text, txtDescripcion.Text, rblTipo.SelectedValue, DateTime.Now.ToShortDateString(), txtFecha.Text, true);
        }
        protected void btnCalendar_Click(object sender, EventArgs e)
        {
            if (calFecha.Visible)
            {
                calFecha.Visible = false;
            }
            else
            {
                calFecha.Visible = true;
            }
        }

        protected void calFecha_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = calFecha.SelectedDate.ToShortDateString();
            calFecha.Visible = false;
        }

        protected void calFecha_DayRender(Object sender, DayRenderEventArgs e)
        {
            DateTime minDay = DateTime.Today;
            DateTime maxDay = minDay.AddDays(7);

            if (DateTime.Compare(e.Day.Date, minDay) < 0 || DateTime.Compare(e.Day.Date, maxDay) > 0)
            {
                e.Day.IsSelectable = false;
                e.Cell.CssClass = "bg-secondary";
            }
            else
            {
                e.Cell.CssClass = "bg-success";
            }

        }
    }
}