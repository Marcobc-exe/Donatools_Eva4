using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donatools_Eva3.Modelo;
//using Donatools_Eva3.Clases;


namespace Donatools_Eva3.Controllers
{
    public class usuarioController
    {
        private static donatoolsDBEntities1 dbc = new donatoolsDBEntities1();

        //Métodos de clase y reglas de negocio
        //Método de registro de Usuario. - DONE
        public static string addUsuario(string rut, string nombre, string apellido, string edad, string genero, string mail, string telefono, string username, string password)
        {
            try
            {
                Genero generoID = dbc.Genero.Find(genero);
                Persona persona = new Persona()
                {
                    rut = rut,
                    nombre = nombre,
                    apellido = apellido,
                    edad = int.Parse(edad),
                    genero = generoID.id_genero
                };
                dbc.Persona.Add(persona);


                Usuario usuario = new Usuario()
                {
                    
                    username = username,
                    usuario_ref = persona.id_persona,
                    mail = mail,
                    telefono = int.Parse(telefono),
                    password = password

                };
                dbc.Usuario.Add(usuario);
                return "Usuario agregado correctamente.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        //Método de búsqueda de Usuario y persona. - DONE
        public static Usuario findUsuario(string codigoUsuario)
        {
            Usuario usuario = dbc.Usuario.Find(int.Parse(codigoUsuario));
            return usuario;

        }

        //Método de modificación de Usuario. - DONE
        public static string editUsuario(
            string codigoUsuario,
            string nombre, 
            string apellido, 
            string edad, 
            string genero, 
            string mail, 
            string telefono, 
            string rut)
        {
            try
            {
                Usuario usuario = findUsuario(codigoUsuario);
                Genero generoID = dbc.Genero.Find(genero);
                if (usuario != null)
                {
                    usuario.Persona.nombre = nombre;
                    usuario.Persona.apellido = apellido;
                    usuario.Persona.edad = int.Parse(edad);
                    usuario.Persona.genero = generoID.id_genero;
                    usuario.Persona.rut = rut;
                    usuario.mail = mail;
                    usuario.telefono = int.Parse(telefono);
                    return "Usuario" + usuario.Persona.nombre + " " + usuario.Persona.apellido + "Modificado.";
                }
                else
                {
                    return "Usuario no encontrado.";
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }


        }

        //Método de eliminación de Usuario. - DONE
        public static string deleteUsuario(string codigo)
        {
            Usuario usuario = findUsuario(codigo);
            if (usuario != null)
            {
                dbc.Usuario.Remove(usuario);
                dbc.SaveChanges();
                return "Usuario eliminado correctamente.";
            }
            else
            {
                return "Usuario no encontrado.";
            }
        }

        //Método de listar todos los Usuarios. - DONE
        public static List<Usuario> getAll()
        {
            var usuarios = from u in dbc.Usuario select u;

            return usuarios.ToList();
        }

    }
}