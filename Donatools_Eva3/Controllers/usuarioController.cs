using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Donatools_Eva3.Modelo;
//using Donatools_Eva3.Clases;


namespace Donatools_Eva3.Controllers
{
    public class usuarioController
    {
        private static donatoolsDBEntities dbc = new donatoolsDBEntities();

        //Métodos de clase y reglas de negocio
        //Método de registro de Usuario. - DONE
        public static string addUsuario(string rut, string nombre, string apellido, string edad, string generoID, string mail, string telefono, string username, string password)
        {
            try
            {
                // Genero generoClase = new Genero();
                Genero genero = dbc.Genero.Find(int.Parse(generoID));

                // Comprobar que no exista el usuario
                bool rutExiste = dbc.Usuario.Any(u => u.rut == rut);
                bool mailExiste = dbc.Usuario.Any(u => u.mail == mail);
                bool telefonoExiste = dbc.Usuario.Any(u => u.telefono == telefono);
                bool usernameExiste = dbc.Usuario.Any(u => u.username == username);

                if (rutExiste)
                {
                    return "Un usuario con este rut existe";
                }
                if (mailExiste )
                {
                    return "Un usuario con este mail existe";
                }
                if (telefonoExiste)
                {
                    return "Un usuario con este telefono existe";
                }
                if (usernameExiste)
                {
                    return "Un usuario con este nombre de usuario ya existe";
                }

                Usuario usuario = new Usuario()
                {
                    username = username,
                    mail = mail,
                    telefono = telefono,
                    rut = rut,
                    nombre = nombre,
                    apellido = apellido,
                    edad = int.Parse(edad),
                    genero_fk = genero.id_genero,
                    password = password
                };


                
                dbc.Usuario.Add(usuario);
                dbc.SaveChanges();
                return "Usuario agregado correctamente.";

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
                return "Error con algun elemento";
            }
            
        }

        //Método de búsqueda de Usuario y persona. - DONE
        public static Usuario findUsuario(string codigoUsuario)
        {
            Usuario usuario = dbc.Usuario.Find(int.Parse(codigoUsuario));
            return usuario;

        }

        //Método de modificación de Usuario. - DONE
        public static string editUsuario(string codigoUsuario, string nombre, string apellido, string edad, string genero, string mail, string telefono, string rut){
            try
            {
                Usuario usuario = findUsuario(codigoUsuario);
                Genero generoID = dbc.Genero.Find(int.Parse(genero));

                bool rutExiste = dbc.Usuario.Any(u => u.rut == rut);
                bool mailExiste = dbc.Usuario.Any(u => u.mail == mail);
                bool telefonoExiste = dbc.Usuario.Any(u => u.telefono == telefono);

                if (rutExiste)
                {
                    return "Un usuario con este rut existe";
                }
                if (mailExiste)
                {
                    return "Un usuario con este mail existe";
                }
                if (telefonoExiste)
                {
                    return "Un usuario con este telefono existe";
                }

                if (usuario != null)
                {
                    usuario.nombre = nombre;
                    usuario.apellido = apellido;
                    usuario.edad = int.Parse(edad);
                    usuario.genero_fk = generoID.id_genero;
                    usuario.mail = mail;
                    usuario.telefono = telefono;
                    usuario.rut = rut;
                    return "Usuario " + usuario.nombre + " " + usuario.apellido + " Modificado.";
                }
                else
                {
                    return "Usuario no encontrado.";
                }
            }
            catch(DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
                return "Error con algun elemento";
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

        public static string GetMD5(string contrasena)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificar = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificar.GetBytes(contrasena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}