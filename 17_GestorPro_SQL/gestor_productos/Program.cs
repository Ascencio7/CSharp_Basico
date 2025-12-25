using System;
using System.Collections.Generic;

namespace gestor_productos
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            GestorSQL gestor = new GestorSQL();
            int opcion = 0;

            do
            {
                // Se muestra el menu de opciones
                Console.WriteLine("\nGESTOR DE PRODUCTOS CON SQL SERVER\n");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Listar productos");
                Console.WriteLine("3. Editar productos");
                Console.WriteLine("4. Eliminar productos");
                Console.WriteLine("5. Salir del programa");

                Console.Write("\nElige una opcion: ");
                // Se lee la entrada del usuario y se convierte a un entero
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    // Una manera mejor, visualmente, de los casos que solo necesitan los metodos
                    case 1: gestor.AgregarProductos(); break;
                    case 2: gestor.ListarProductos(); break;
                    case 3: gestor.EditarProductos(); break;
                    case 4: gestor.EliminarProductos(); break;
                    case 5:
                        Console.WriteLine("\nGracias por usar este sistema. Fin del programa.\n");
                        break;
                }


            } while (opcion != 5);
        }
    }
}