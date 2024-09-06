using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectClass
{
    internal class Perro
    {
        public string? Nombre { get; set; }
        public int Edad {  get; set; }
        public string? Raza { get; set; }

        public Perro() { }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public Perro(string nombre, int edad) : this (nombre) 
        { 
            Edad = edad;
        }

        public Perro(string nombre, int edad, string raza) : this (nombre, edad)
        {
            Raza = raza;
        }

        public string Hablar()
        {
            return "El perro ladra";
        }

    }
}
