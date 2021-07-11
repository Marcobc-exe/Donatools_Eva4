using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Donatools_Eva3.Clases
{
    public class Persona
    {
        private string rut;
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;

        public Persona(string rut, string nombre, string apellido, int edad, string genero)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }

        public Persona()
        {

        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}