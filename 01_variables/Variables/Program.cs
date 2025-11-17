// Las variables en C#
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de tipo entero
            int numEntero = 10;

            // Variable de tipo flotante
            double numFloa = 10.48D;

            float numFlotante = 5.75F;

            // Variable de tipo string
            string mensaje = "Soy Vladimir Ascencio";

            // Variables de tipo booleano
            bool isTrue = false;
            bool isFalso = true;

            // Mostrar los resultados

            System.Console.WriteLine($"\nValor entero: {numEntero}");
            System.Console.WriteLine($"Valor double: {numFloa}");
            System.Console.WriteLine($"Valor flotante: {numFlotante}");
            System.Console.WriteLine($"Valor String: {mensaje}");
            System.Console.WriteLine($"Valor booleano 1: {isTrue}");
            System.Console.WriteLine($"Valor booleano 2: {isFalso}\n");

        }
    }
}