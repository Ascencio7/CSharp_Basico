using System;

namespace condicionales
{
    public class Programa
    {
        static void Main(string[] args)
        {
            // Verificar si el numero es positivo, negativo o 0
            string entrada;
            int num;

            // Solicitar el numero
            Console.Write("\nIngresa el numero: ");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            // Verificar si el numero es positivo, negativo o 0
            if (num > 0)
            {
                Console.WriteLine($"\nEl numero es positivo y mayor a 0: {num}");
            }
            else if (num < 0)
            {
                Console.WriteLine($"\nEl numero es negativo: {num}");
            }
            else if (num == 0)
            {
                Console.WriteLine("\nValor es 0.");
            }
            else
            {
                Console.WriteLine("\nValor nulo.");
            }
            Console.WriteLine("Fin del programa.\n");

        }
    }
}