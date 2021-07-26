using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Donatools_Eva3.Modelo;
//using Donatools_Eva3.Clases;

namespace Donatools_Eva3.Controllers
{
    public class DonacionController
    {
        private static donatoolsDBEntities dbc = new donatoolsDBEntities();

        public static string addDonacion(string idUsuario, string nombre, string descripcion, string tipoID, string fecha_publicacion, string fecha_limite, bool publico)
        {
            try
            {   
                Usuario usuario = dbc.Usuario.Find(int.Parse(idUsuario));
                Tipo tipoDonacion = dbc.Tipo.Find(int.Parse(tipoID));

                Donacion donacion = new Donacion()
                {
                    usuario_fk = usuario.id_usuario,
                    tipo = tipoDonacion.id_tipo,
                    nomb_donacion = nombre,
                    descripcion = descripcion,
                    fecha_publicacion = Convert.ToDateTime(fecha_publicacion),
                    fecha_limite = Convert.ToDateTime(fecha_limite),
                    publico = Convert.ToInt32(publico)
                };

                dbc.Donacion.Add(donacion);
                dbc.SaveChanges();
                return "Donacion agregada correctamente.";
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

        // Filtrar donaciones por tipo - DONE
        public static List<Donacion> filterType(int tipo)
        {
            List<Donacion> listaDonacion = getAll();
            List<Donacion> filterList = new List<Donacion>();

            if (listaDonacion.Count > 0)
            {
                foreach (Donacion donacion in listaDonacion)
                {
                    if (donacion.tipo == tipo && donacion.publico == 1)
                    {
                        filterList.Add(donacion);
                    }
                }
                return filterList;
            }

            return null;

        }
        // Buscar Donacion - DONE
        public static Donacion findDonacion(string id)
        {
            return dbc.Donacion.Find(int.Parse(id));
        }
        // Editar donacion - DONE
        public static string editDonacion(string id, string nombre, string descripcion, string fechaLimite)
        {
            try
            {
                Donacion donacion = findDonacion(id);

                if (donacion != null)
                {
                    donacion.nomb_donacion = nombre;
                    donacion.descripcion = descripcion;
                    donacion.fecha_limite = Convert.ToDateTime(fechaLimite);
                    return "Donacion " + donacion.id_donacion + " actualizada exitosamente";
                    dbc.SaveChanges();
                }
                return "Donacion no encontrada";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        // Eliminar Donacion - DONE
        public static string deleteDonacion(string id)
        {
            Donacion donacion = findDonacion(id);
            if (donacion != null)
            {
                dbc.Donacion.Remove(donacion);
                dbc.SaveChanges();

                return "Donacion eliminada correctamente";
            }
            else
            {
                return "Donacion no encontrada";
            }
        }

        // Listar todas las donaciones - DONE
        public static List<Donacion> getAll()
        {
            var donaciones = from d in dbc.Donacion select d;

            return donaciones.ToList();
        }

    }
}