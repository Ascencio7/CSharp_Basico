using System;

namespace gestorProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestor gestor = new Gestor();
            int opcion = 0;

            do
            {
                Console.WriteLine("\n=== GESTOR DE PRODUCTOS ===\n");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Editar producto");
                Console.WriteLine("3. Listar productos");
                Console.WriteLine("4. Buscar producto");
                Console.WriteLine("5. Eliminar producto");
                Console.WriteLine("6. Salir");

                Console.Write("\nSelecciona una opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Write("\nEntrada inválida. Ingresa un número del 1 al 5: ");
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1: 
                        gestor.AgregarProducto(); 
                        break;

                    case 2:
                        gestor.EditarProducto();
                        break;

                    case 3: 
                        gestor.ListarProductos(); 
                        break;

                    case 4: 
                        gestor.BuscarProducto(); 
                        break;

                    case 5: gestor.EliminarProducto(); 
                        break;

                    case 6: 
                        Console.WriteLine("Saliendo..."); 
                        break;

                    default: 
                        Console.WriteLine("Opción inválida.\n"); 
                        break;
                }

            } while (opcion != 6);
        }
    }
}