using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Primo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIngresa un numero para verificar si es primo: "); // Solicitar el numero
            string entrada = Console.ReadLine(); // leer el dato como string

            if (int.TryParse(entrada, out int numero) && numero > 0) // convertir el dato en numero entero y ver si es positivo
            {
                bool numPrimo = NumPrimo(numero); // se llama a la funcion con una variable booleana

                if (numPrimo) // si es primo se muestra el mensaje de exito
                {
                    Console.WriteLine($"\nEl numero {numero} es primo.");
                }
                else
                {
                    Console.WriteLine($"\nEl numero {numero} no es numero primo."); // sino, se muestra el mensaje de que no lo es
                }
            }
            else
            {
                Console.WriteLine($"\nEntrada invalida, debe ser un numero entero positivo."); // un mensaje de error si la entrada es invalida
            }
        }


        #region Numero Primo
        public static bool NumPrimo(int numero)
        {
            if (numero <= 1) return false; // si el numero no es primo retorna falso

            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0) // si es igual a 0 retorna falso
                
                    return false;
                
            }
            return true; // si es un numero primo lo devuelve como true
        }
        #endregion


    }
}