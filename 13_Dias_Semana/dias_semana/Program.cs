using System;
using System.Collections.Generic;

namespace dias_semana
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Definir la lista de los dias de la semana de tipo string
            List<string> dias = new List<string>
            {
                "Lunes","Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
            };

            Console.Write("Ingresa un número del 1 al 7: ");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    // Resta 1 para ajustar el indice de la lista 0 a 6
                    Console.WriteLine("El día es: " + dias[numero - 1]);
                    break;

                default:
                    Console.WriteLine("\nEntrada inválida. Ingresa del 1 al 7.");
                    break;
            }

            Console.WriteLine("\nFin del programa.\n");
        }
    }
}