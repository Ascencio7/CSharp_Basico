using System;

namespace mate_operaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inicializo la variable
            int opcion = 0;

            // Bucle principal
            while (opcion != 5) // 5 es la opcion de salir
            {
                // Llamo al metodo del menu
                Menu();
                Console.Write("\nIngresa una opción: ");
                
                // Validar opción
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Write("Entrada inválida. Ingresa una opción: ");
                }

                // Segun la opcion, llamo al metodo correspondiente
                switch (opcion)
                {
                    case 1:
                        // Uso var para declarar variables locales sin especificar el tipo
                        var (s1, s2) = PedirNumeros(); // Llamo al metodo para pedir los numeros
                        // Imprimo los resultados concatenando los resultados
                        Console.WriteLine($"\nEl resultado de la suma es: {Sumar(s1, s2)}\n");
                        break;
                    case 2:
                        var (r1, r2) = PedirNumeros();
                        Console.WriteLine($"\nEl resultado de la resta es: {Restar(r1, r2)}\n");
                        break;
                    case 3:
                        var (m1, m2) = PedirNumeros();
                        Console.WriteLine($"\nEl resultado de la multiplicación es: {Multiplicar(m1, m2)}\n");
                        break;
                    case 4:
                        var (d1, d2) = PedirNumeros();
                        // Validacion para evitar division por 0
                        if (d2 == 0){
                            Console.WriteLine("\nError: no se puede dividir por cero.\n");
                        }
                        else{
                            Console.WriteLine($"\nEl resultado de la división es: {Dividir(d1, d2)}\n");
                        }
                        break;
                    case 5: // Salir y detener el programa
                        Console.WriteLine("\nGracias por usar la calculadora.\n");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida.\n");
                        break;
                }

            } // fin del while
        }

        #region Metodos

        // Metodo para mostrar el menu
        public static void Menu()
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
        }

        // Metodo para pedir los numeros
        public static (double, double) PedirNumeros()
        {
            // Pide el primer numero
            Console.Write("\nIngresa el primer número: ");
            double num1;
            // Valida que si no es un numero lo vuelve a pedir
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Entrada inválida. Ingresa el primer número: ");
            }

            // Pide el segundo numero
            Console.Write("Ingresa el segundo número: ");
            double num2;
            // Valida que si no es un numero lo vuelve a pedir
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Entrada inválida. Ingresa el segundo número: ");
            }

            // Devuelve los numeros ingresados
            return (num1, num2);
        }
        #endregion

        #region Metodos de Operaciones
        
        // Metodos de operaciones que llaman a la operacion correspondiente
        public static double Sumar(double n1, double n2) => n1 + n2;
        public static double Restar(double n1, double n2) => n1 - n2;
        public static double Multiplicar(double n1, double n2) => n1 * n2;
        public static double Dividir(double n1, double n2) => n1 / n2;
        
        #endregion
    }
}