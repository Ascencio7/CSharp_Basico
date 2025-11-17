using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Calificaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Main Principal
            // Declarar la lista
            List<double> calificaciones = new List<double>(); // de tipo double para manejar datos con decimales

            Console.WriteLine("\n\t\t\t\t===== Ingreso de Datos ====="); // mensaje de bienvenida

            Console.Write("\nIngrese cuantas calificaciones ingresara: "); // se solicita la cantidad de calificaciones, debe ser tipo entero
            int cantidad = Convert.ToInt32(Console.ReadLine()); // lee la entrada y lo convierte en entero

            if(cantidad <= 0) // si la cantidad es 0 se muestra un mensaje
            {
                Console.WriteLine("\nLa cantidad de calificaciones a ingresar debe ser mayor a 0.");
                return;
            }

            for(int i = 0; i < cantidad; i++) // un bucle for para iterar segun la cantidad ingresada
            {
                double calificacion; // iniciar la variable para guardar las calificaciones

                while (true) // un bucle while para manejar el ingreso de las calificaciones segun la cantidad ingresada
                {
                    Console.Write($"\nIngresa la {i + 1}° calificacion: "); // se ingresa una calificacion y se suma desde el primero hasta el n
                    calificacion = Convert.ToDouble(Console.ReadLine()); // lee la entrada y lo convierte en double

                    if (calificacion >= 0 && calificacion <=10) // verifica que las calificaciones sean entre 0 y 10
                    break;
                    Console.WriteLine("\nLa calificacion debe ser entre 0 y 10."); // se muestra mensaje de error
                }

                calificaciones.Add(calificacion); // se agregan las calificiones en la lista
            }

            // se llama a la funcion
            double promedio = CalcularPromedio(calificaciones);
            double notaAlta = NotaAlta(calificaciones);
            double notaBaja = NotaBaja(calificaciones);

            // se muestra el resultado
            Console.WriteLine("\n\t\t==== RESULTADOS ====");
            Console.WriteLine($"\n\tEl promedio de las {cantidad} calificaciones es de {promedio}");
            Console.WriteLine($"\n\tLa nota mas alta de las {cantidad} calificaciones es {notaAlta}");
            Console.WriteLine($"\n\tLa nota mas baja de las {cantidad} calificaciones es {notaBaja}");
        }
        #endregion


        #region Calculo Promedio
        public static double CalcularPromedio(List<double> lista) // una funcion con argumento de lista
        {
            if (lista.Count == 0) return 0; // verifica si la lista esta vacia e igual a 0 retorna 0
            return Math.Round(lista.Average(), 2); // si la lista esta llena, se saca el promedio y se redondea a 2 decimales
        }
        #endregion


        #region Nota Alta
        public static double NotaAlta(List<double> lista)
        {
            if (lista.Count == 0) return 0;
            return lista.Max(); // Max verifica la nota mas alta de las calificaciones en el arreglo
        }
        #endregion


        #region Nota Baja
        public static double NotaBaja(List<double> lista)
        {
            if (lista.Count == 0) return 0;
            return lista.Min(); // Min verifica la nota mas baja de las calificaciones en el arreglo
        }
        #endregion

    }
}