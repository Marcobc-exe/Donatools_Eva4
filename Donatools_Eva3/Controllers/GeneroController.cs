using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donatools_Eva3.Modelo;

namespace Donatools_Eva3.Controllers
{
    public class GeneroController
    {
        private static donatoolsDBEntities dbc = new donatoolsDBEntities();

        public static List<Genero> getAll()
        {
            var genero = from g in dbc.Genero select g;

            return genero.ToList();
        }
    }
}