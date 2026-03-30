using System;

namespace FechaNacimiento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // fecha de nacimiento
            DateOnly fechaNacimiento = new DateOnly(2003, 9, 24);

            // fecha actual
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);

            // calcular edad
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // ajustar si aún no ha cumplido años este año
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            // mostrar la edad
            Console.WriteLine("La edad es: " + edad);
        }
    }
}
