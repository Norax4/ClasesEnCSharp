using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectClass
{
    internal class Caballo
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public Caballo() { }

        public Caballo(string nombre)
        {
            Nombre = nombre;
        }

        public Caballo(string nombre, int edad) : this(nombre)
        {
            Edad = edad;
        }

        public override string ToString()
        {
            return $"Caballo: Nombre = {Nombre}, Edad = {Edad}";
        }

        internal static string Hablar()
        {
            return "El caballo relincha";
        }
    }
}
