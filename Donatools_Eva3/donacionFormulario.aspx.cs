﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Donatools_Eva3.Controllers;

namespace Donatools_Eva3
{
    public partial class donacionFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnCrearDonacion_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = DonacionController.addDonacion("101", txtTitulo.Text, txtDescripcion.Text,
                rblTipo.SelectedValue, "ahora", txtFecha.Text, true);
        }
    }
}