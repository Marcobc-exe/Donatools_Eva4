using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donatools_Eva3.Modelo;
//using Donatools_Eva3.Clases;

namespace Donatools_Eva3.Controllers
{
    public class DonacionController
    {
        private static donatoolsDBEntities1 dbc = new donatoolsDBEntities1();

        public static string addDonacion(string idUsuario, string nombre, string descripcion, string tipo, string fecha_publicacion, string fecha_limite, bool publico)
        {
            try
            {   
                Usuario usuario = dbc.Usuario.Find(int.Parse(idUsuario));
                Tipo tipoDonacion = dbc.Tipo.Find(tipo);

                Donacion donacion = new Donacion()
                {
                    usuario = usuario.id_usuario,
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
            catch (Exception e)
            {

                return "Error: " + e.Message;
            }
        }

        // Filtrar donaciones por tipo - DONE
        public static List<Donacion> filterType(string tipo)
        {
            List<Donacion> listaDonacion = getAll();
            List<Donacion> filterList = new List<Donacion>();

            if (listaDonacion.Count > 0)
            {
                foreach (Donacion donacion in listaDonacion)
                {
                    if (donacion.tipo == int.Parse(tipo) && donacion.publico == 1)
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