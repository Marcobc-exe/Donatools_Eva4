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
    public partial class donacionRopa : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(DonacionController.filterType(1) != null)
            {
                string html = "";
                foreach (Donacion donacion in DonacionController.filterType(1))
                {
                    Usuario user = usuarioController.findUsuario(donacion.usuario_fk.ToString());
                    string nombreUsuario = user.username;
                    html += "<article class=\"don-container mb-4 \"><div class=\"row\"><div class=\"col d-flex px-0 mb-3\"><img src = \"https://via.placeholder.com/150x100\"><div class=\"title d-flex flex-column\"><h2>" + donacion.nomb_donacion + "</h2><p>" + nombreUsuario +"</p></div></div>";
                    html += "<div class=\"date-con col text-end\"><p><span> Termina en </span><br>" + donacion.fecha_limite.ToShortDateString() + "</p></div> ";
                    html += "<div class=\"descripcion mb-4\"><p>" + donacion.descripcion + "</p></div>";
                    html += "<div class=\"solicitar-btn\"><span> solicitar donación </span></div></div><div class=\"load-btn\"><span class=\"col\">v</span></div></article>";
                }

                donacionContainer.InnerHtml = html;
            }
        }
    }
}