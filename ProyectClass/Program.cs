using ProyectClass;
using static System.Runtime.InteropServices.JavaScript.JSType;

Perro perro = new Perro("Firulais", 5);
Gato gato = new Gato("Michu", 3);
Caballo caballo = new Caballo("Spirit", 7);

// Mostrar información del Perro
Console.WriteLine($"Perro: Nombre: {perro.Nombre}, Edad: {perro.Edad}");

Console.WriteLine(perro.Hablar());
Console.WriteLine("");

// Mostrar información del Gato
Console.WriteLine(gato.ToString());
Console.WriteLine(gato.Hablar());
Console.WriteLine("");

// Mostrar información del Caballo
Console.WriteLine(caballo.ToString());
Console.WriteLine(Caballo.Hablar());
Console.WriteLine("");

// Comparar edades entre el perro y el gato
#region Comparar

//Aca deben comparar las edades y mostrar en consola cual de los dos es el de más edad
if (perro.Edad > gato.Edad)
{
    Console.WriteLine($"{perro.Nombre} (Perro) es mayor a {gato.Nombre} (Gato)");
} else if (perro.Edad < gato.Edad)
{
    Console.WriteLine($"{perro.Nombre} (Perro) es menor a {gato.Nombre} (Gato)");
} else
{
    Console.WriteLine($"{perro.Nombre} (Perro) tiene la misma edad que {gato.Nombre} (Gato)");
}
#endregion

Console.WriteLine("");
Perro perro2 = new Perro("Chicho", 8, "BUlldog");

// Mostrar información del perro2
Console.WriteLine($"Perro 2: Nombre: {perro2.Nombre}, Edad: {perro2.Edad}, Raza:{perro2.Raza}");