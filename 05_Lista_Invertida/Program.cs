using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Invertida
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Solicitar los datos
            Console.Write("\nIngresa un numero entero positivo: ");

            // verifica que la entrada sea un numero no negativo
            if(int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {
                int inver = InvertirNum(numero); // se llama a la funcion
                Console.WriteLine($"\nEl numero invertido es {inver}"); // se muestra el resultado
            }
            else
            {
                Console.WriteLine("\nDato invalido, ingresa un dato numero entero positivo."); // si no es un numero muestra un mensaje de error
            }
        }


        #region Invertir Num Entero
        public static int InvertirNum(int numero)
        {
            int numInver = 0; // declarar una variable para guardar el numero invertido

            while(numero > 0)
            {
                int digito = numero % 10; // este obtiene el ultimo digito
                numInver = numInver * 10 + digito; // lo pone al frente del nuevo numero
                numero /= 10; // y quita ese ultimo digito
            }

            return numInver; // devuelve el valor final
        }

        #endregion


    }
}