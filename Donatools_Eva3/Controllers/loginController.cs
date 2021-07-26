using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donatools_Eva3.Modelo;

namespace Donatools_Eva3.Controllers
{
    public class loginController
    {
        public static Usuario login(string username, string password)
        {
            foreach (Usuario usuario in usuarioController.getAll())
            {
                if (usuario.username.Equals(username))
                {
                    if (usuario.password.Equals(password))
                    {
                        return usuario;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
    }
}