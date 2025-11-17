using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km_Milla_Conversor
{
    public class Program
    {
        static void Main(string[] args)
        {
            // iniciar la variable
            double kilometro, millas;

            // solicitar los datos
            Console.Write("\nIngresa los Kilometros: ");
            kilometro = Convert.ToDouble(Console.ReadLine());

            // se llama la funcion
            millas = ConvertirKMaMillas(kilometro);

            // mostrar el total
            Console.WriteLine($"\nLos {kilometro} kms a millas son: {millas} millas.");
            Console.WriteLine("\n");
        }

        #region Conversor
        public static double ConvertirKMaMillas(double kilometro)
        {
            return Math.Round(kilometro * 0.621371, 5);
        }
        #endregion

    }
}