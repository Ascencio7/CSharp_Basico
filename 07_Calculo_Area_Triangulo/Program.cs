using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Area_Triangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Iniciar las variables
            double baseValor, altura, area;

            // Solicitar los datos
            Console.Write("\nIngresa la base del triangulo: ");
            baseValor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la altura del triangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());


            // Llamar la funcion
            area = CalAreaTriangulo(baseValor, altura);

            // Mostrar el resultado
            Console.WriteLine($"\nEl Area del triangulo es {area}");
        }

        #region Metodo Area Triangulo
        public static double CalAreaTriangulo(double baseValor, double altura)
        {
            if (baseValor <= 0 || altura <= 0)
            {
                Console.WriteLine("\nLos valores de la base y altura del triangulo deben ser mayores a 0.");
                return 0;
            }

            return Math.Round((baseValor * altura) / 2, 2);
        }
        #endregion

    }
}