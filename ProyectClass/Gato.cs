using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectClass
{
    internal class Gato
    {

        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public Gato() { }

        public Gato(string nombre)
        {
            Nombre = nombre;
        }

        public Gato(string nombre, int edad) : this(nombre)
        {
            Edad = edad;
        }

        public override string ToString()
        {
            return $"Gato: Nombre = {Nombre}, Edad = {Edad}";
        }

        public string Hablar()
        {
            return "El gato maúlla";
        }
    }
}
