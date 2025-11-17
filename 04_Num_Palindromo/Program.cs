using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_Palindromo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el numero
            Console.Write("\nIngresa el numero: ");
            string cadena = Console.ReadLine();

            if(int.TryParse(cadena, out int numero) && numero > 0)
            {
                bool esPalin = EsPalindromo(numero);

                if (esPalin)
                {
                    Console.WriteLine($"\nEl numero {numero} es un palindromo.\n");
                }
                else
                {
                    Console.WriteLine($"\nEl numero {numero} no es un palindromo.\n");
                }
            }
            else
            {
                Console.WriteLine("\nEntrada invalida, debes ingresar un numero entero positivo.");
            }
        }

        #region Numero Palindromo
        public static bool EsPalindromo(int numero)
        {
            int numOri = numero;
            int numInv = 0;

            while(numero > 0)
            {
                int ultimoDigito = numero % 10;
                numInv = numInv * 10 + ultimoDigito;
                numero /= 10;
            }

            return numOri == numInv;
        }

        #endregion

    }
}