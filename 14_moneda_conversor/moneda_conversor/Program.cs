using System;

namespace moneda_conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIngresa la cantidad en dólares: $");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n1. Euros");
            Console.WriteLine("2. Colones Salvadoreños");
            Console.WriteLine("3. Pesos Mexicanos");
            Console.WriteLine("4. Bitcoin");
            Console.WriteLine("5. Salir");
            Console.Write("\nSelecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            double resultado = 0;
            string moneda = "";

            switch (opcion)
            {
                case 1:
                    resultado = cantidad * 0.93;
                    moneda = "EUR";
                    break;
                case 2:
                    resultado = cantidad * 8.75;
                    moneda = "SVC";
                    break;
                case 3:
                    resultado = cantidad * 20.50;
                    moneda = "MXN";
                    break;
                case 4:
                    resultado = cantidad * 0.000015;
                    moneda = "BTC";
                    break;
                case 5:
                    Console.WriteLine("\nGracias por usar el conversor.");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida.");
                    break;
            }

            if (opcion >= 1 && opcion <= 4)
            {
                Console.WriteLine($"\n{cantidad} dólares son {Math.Round(resultado, 4)} {moneda}");
            }

            Console.WriteLine("\nFin del programa.\n");
        }
    }
}