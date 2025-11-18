using System;

namespace votar
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Verificar si una persona puede votar o no

            // Declarar las variables
            int edad;
            string entrada;

            // Pedir la edad
            Console.Write("\nIngresa tu edad: ");
            entrada = Console.ReadLine();
            edad = Convert.ToInt32(entrada);

            // Evaluar las condiciones
            if (edad < 0)
            {
                Console.WriteLine("\nLa edad ingresada es invalida.");
            }
            else if (edad < 18)
            {
                Console.WriteLine("\nEres menor de edad, no puedes votar.");
            }
            else if (edad >= 18 && edad <= 69)
            {
                Console.WriteLine("\nEres mayor de edad, puedes votar.");
            }
            else
            {
                Console.WriteLine("\nEres adulto mayor, el voto es opcional.");
            }

            Console.WriteLine("Fin del programa.\n");

        }
    }
}