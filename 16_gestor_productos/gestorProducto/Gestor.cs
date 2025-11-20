using System;
using System.Collections.Generic;

namespace gestorProducto
{
    public class Gestor
    {
        // Creo una lista para guardar los productos
        private List<Productos> productos = new List<Productos>();
        // una variable que sera autoincrementable para el ID del producto
        private static int lastId = 0;


        #region Agregar Producto
        public void AgregarProducto()
        {
            // Pedir los datos del producto y se verifica que sean datos validos
            Console.Write("\nIngresa el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa el precio del producto: $");
            double precio;
            while (!double.TryParse(Console.ReadLine(), out precio))
            {
                Console.Write("\nEntrada inválida. Ingresa un precio válido: $");
            }

            Console.Write("Ingresa la cantidad del producto: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.Write("\nEntrada inválida. Ingresa una cantidad válida: ");
            }

            // Se genera el id automaticamente
            int geId = ++lastId;

            // Se crea una instancia para agregar las variables que capturan los datos del producto
            Productos nuevo = new Productos(geId, nombre, precio, cantidad);
            // Se agregan los datos del producto a la lista
            productos.Add(nuevo);

            // Se muestra el resultado
            Console.WriteLine($"\nEl producto '{nombre}' ha sido agregado correctamente.\n");
        }
        #endregion


        #region Listar Productos
        public void ListarProductos()
        {
            Console.WriteLine("\n=== Lista de Productos ===\n");

            // Verifica que si los productos estan vacios se muestra el siguiente mensaje y retorna al menu
            if (productos.Count == 0)
            {
                Console.WriteLine("\nNo hay productos agregados.\n");
                return;
            }

            // Si hay productos recorre la lista y los muestra
            foreach (var p in productos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }
        #endregion


        #region Buscar Producto
        public void BuscarProducto()
        {
            // Solicita el ID existente del producto a buscar
            Console.Write("\nIngresa el ID a buscar: ");
            int id;
            // Verifica que sea un dato valido, sino lo vuelve a pedir
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("\nEntrada inválida. Ingresa un ID válido: ");
            }

            // Verifica en la lista que el ID de la Clase sea identico al id guardado
            Productos prod = productos.Find(p => p.idProducto == id);

            // Si el producto es encontrado se muestran los datos
            if (prod != null)
            {
                Console.WriteLine("\nProducto encontrado:\n");
                Console.WriteLine(prod + "\n");
            }
            else
            {
                // Si no se muestra el siguiente mensaje
                Console.WriteLine("\nEl producto no fue encontrado.\n");
            }
        }
        #endregion


        #region Eliminar Producto
        public void EliminarProducto()
        {
            // Solicita el ID a eliminar
            Console.Write("\nIngresa el ID a eliminar: ");
            int id;
            string entrada = Console.ReadLine();

            // Verifica que sea un dato valido, sino lo vuelve a pedir
            while (!int.TryParse(entrada, out id))
            {
                Console.Write("Entrada inválida. Ingresa un ID válido: ");
                entrada = Console.ReadLine();
            }

            // Buscar producto en la lista de los productos si ambos IDs coinciden
            Productos prod = productos.Find(p => p.idProducto == id);

            // Si el producto existe...
            if (prod != null)
            {
                // se elimina el producto de la lista de productos
                productos.Remove(prod);
                // y muestra el mensaje de exito y el nombre del producto eliminado
                Console.WriteLine($"\nProducto '{prod.nombreProducto}' ha sido eliminado correctamente.\n");
            }
            else
            {
                // Si no se muestra el siguiente mensaje
                Console.WriteLine("\nNo existe un producto con ese ID.\n");
            }
        }
        #endregion


        #region Editar Producto
        public void EditarProducto()
        {
            // Se solicita el id del producto a editar
            Console.Write("\nIngresa el ID del producto a editar: ");
            int id;
            string entrada = Console.ReadLine();

            // Validar ID numérico
            while (!int.TryParse(entrada, out id))
            {
                Console.Write("\nEntrada inválida. Ingresa un ID válido: ");
                entrada = Console.ReadLine();
            }

            // Buscar producto en la lista de los productos si ambos IDs coinciden
            Productos prod = productos.Find(p => p.idProducto == id);

            // Si no existe el producto entonces se muestra el siguiente mensaje
            if (prod == null)
            {
                Console.WriteLine("\nNo existe un producto con ese ID.\n");
                return;
            }

            // Mostrar los detalles del producto encontrado
            Console.WriteLine("\nProducto encontrado:\n");
            Console.WriteLine(prod);

            // Menú de edición de los detalles del producto
            Console.WriteLine("\n¿Qué deseas editar?\n");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Precio");
            Console.WriteLine("3. Cantidad");
            Console.WriteLine("4. Cancelar");
            Console.Write("\nSelecciona una opción: ");

            int opcion;
            // Verifica que las opciones sean dentro del rango, sino se muestra el siguiente mensaje
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("\nOpción inválida. Selecciona 1-4: ");
            }

            // Se usa un switch para manejar las opciones del submenu
            switch (opcion)
            {
                case 1:
                    Console.Write("\nNuevo nombre: ");
                    // Se actualiza el nombre del producto
                    prod.nombreProducto = Console.ReadLine();
                    Console.WriteLine("\nNombre actualizado correctamente.\n");
                    break;

                case 2:
                    Console.Write("\nNuevo precio: $");
                    double nuevoPrecio;

                    // Verifica que el precio sea valido, sino muestra el mensaje y solicita de nuevo el precio
                    while (!double.TryParse(Console.ReadLine(), out nuevoPrecio) || nuevoPrecio < 0)
                    {
                        Console.Write("\nPrecio inválido. Intenta de nuevo: $");
                    }
                    // Se actualiza el precio del producto
                    prod.precioProducto = nuevoPrecio;
                    Console.WriteLine("\nPrecio actualizado correctamente.\n");
                    break;

                case 3:
                    Console.Write("\nNueva cantidad: ");
                    int nuevaCant;

                    // Verifica que la cantidad sea valida, sino muestra el mensaje y se solicita de nuevo la cantidad
                    while (!int.TryParse(Console.ReadLine(), out nuevaCant) || nuevaCant < 0)
                    {
                        Console.Write("\nCantidad inválida. Intenta de nuevo: ");
                    }
                    // Se actualiza la cantidad del producto
                    prod.cantidadProducto = nuevaCant;
                    Console.WriteLine("\nCantidad actualizada correctamente.\n");
                    break;

                case 4:
                    Console.WriteLine("\nEdición cancelada.\n");
                    return;
            }

            // Mostrar producto actualizado
            Console.WriteLine("Producto actualizado:");
            Console.WriteLine(prod + "\n");
        }
        #endregion


    }
}