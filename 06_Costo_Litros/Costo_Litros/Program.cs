using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Costo_Litros
{
    public class Program
    {
        static void Main(string[] args)
        {
            double litroConsum, distancia, consumo;

            do
            {
                // Solicitar los datos
                Console.Write("\nIngresa la distancia en km: ");
                distancia = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el consumo de gasolina en litros: ");
                consumo = Convert.ToDouble(Console.ReadLine());

                // se llama la funcion
                litroConsum = CalLitro(distancia, consumo);

                // se muestra el resultado
                Console.WriteLine($"\nEl gasto de gasolina fue de {litroConsum} litros.");
                Console.WriteLine("\n");
            }
            while (litroConsum < 0 || distancia < 0 || consumo < 0);
        }

        #region Calcular Litros
        // crear la funcion para calcular el costo de la gasolina
        public static double CalLitro(double distancia, double consumo)
        {
            return (distancia / 100) * consumo;

        }
        #endregion
    }
}