using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_Fahrenheit
{
    public class Program
    {
        static void Main(string[] args)
        {
            // iniciar las variables
            double celcius, fahrenheit;

            // solicitar los datos
            Console.Write("\nIngresa la temperatura en Celsius: ");
            celcius = Convert.ToDouble(Console.ReadLine());

            // llamar la funcion
            fahrenheit = CelsiusFahrenheit(celcius);

            // mostrar el resultado
            Console.WriteLine($"\nLa temperatura Celcius a Fahrenheit es {fahrenheit} °F");
            Console.WriteLine("\n");
        }

        #region Conversor
        public static double CelsiusFahrenheit(double celcius)
        {
            return Math.Round((celcius * 9 / 5) + 32, 2);
        }
        #endregion

    }
}