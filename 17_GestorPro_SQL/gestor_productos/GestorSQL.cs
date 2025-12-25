using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace gestor_productos
{
    public class GestorSQL
    {

        private string connectionString = @"Server=VLADIMIR\ASCENCIO;Database=GESTOR_PRODUCTO;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        #region Agregar Productos
        public void AgregarProductos()
        {
            // Se solicitan los datos del producto y se crean las variables donde se almacenaran
            Console.Write("\nNombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: $");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Se crea una variable para guardar y ejecutar la sentencia SQL de insercion en la tabla de la BD
            string query = "INSERT INTO Productos (Nombre, Precio, Cantidad) VALUES (@nombre, @precio, @cantidad)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            // Se muestra un mensaje de confirmacion si la consulta fue correcta
            Console.WriteLine($"\nEl producto {nombre} ha sido agregado.\n");

        }
        #endregion


        #region Listar Productos
        public void ListarProductos()
        {
            // Una variable que guarde la consulta SQL
            string query = "SELECT * FROM Productos";

            // Creo una lista para mostrar los productos
            List<Productos> lista = new List<Productos>();

            // 
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Un bucle infinito para leer los datos
                while (reader.Read())
                {
                    // Uso la variable anterior y agrego los atributos de la clase
                    lista.Add(new Productos
                    {
                        // Por cada atributo es igual al atributo en SQL Server
                        IdProducto = (int)reader["IdProducto"],
                        Nombre = reader["Nombre"].ToString(),
                        Precio = Convert.ToDouble(reader["Precio"]),
                        Cantidad = (int)reader["Cantidad"],
                        // Se debe agregar, si no, entonces el Total lo mostrara con $0.00
                        Total = Convert.ToDouble(reader["Total"])
                    });
                }
            }

            Console.WriteLine("\nLista de los productos agregados:\n");
            
            // 
            if(lista.Count == 0)
            {
                Console.WriteLine("\nNo hay productos registrados.\n");
                return;
            }

            foreach (var p in lista)
            {
                Console.WriteLine(p);
            }
        }
        #endregion


        #region Buscar Productos
        public Productos BuscarProducto(int id)
        {
            // Se crea una variable donde se guarda y se ejecuta la sentencia SQL
            string query = "SELECT * FROM Productos WHERE IdProducto = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Buscamos el parametro segun el ID
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Productos
                    {
                        IdProducto = (int)reader["IdProducto"],
                        Nombre = reader["Nombre"].ToString(),
                        Precio = Convert.ToDouble(reader["Precio"]),
                        Cantidad = (int)reader["Cantidad"],
                        Total = Convert.ToDouble(reader["Total"])
                    };
                }
            }

            return null;
        }
        #endregion


        #region Editar Productos
        public void EditarProductos()
        {
            // Se solicita el ID del producto a editar
            Console.Write("\nIngresa el Id del producto a editar: ");
            int id = int.Parse(Console.ReadLine());

            // Se llama al metodo de buscar productos y se pasa el ID para ser buscado
            Productos prod = BuscarProducto(id);

            // Si el ID no existe o no esta se muestra el siguiente mensaje
            if (prod == null)
            {
                Console.WriteLine("\nEl producto no ha sido encontrado.\n");
                return;
            }

            // Caso contrario, se muestra el siguiente mensaje y los datos del producto.
            Console.WriteLine("\nProducto encontrado:\n");
            Console.WriteLine(prod);

            // Se solicitan los nuevos datos del producto
            Console.Write("\nNuevo nombre: ");
            prod.Nombre = Console.ReadLine();

            Console.Write("Nuevo precio: $");
            prod.Precio = double.Parse(Console.ReadLine());

            Console.Write("Nueva cantidad: ");
            prod.Cantidad = int.Parse(Console.ReadLine());

            // Se crea una variable para guardar y ejecutar la sentencia SQL
            string query = "UPDATE Productos SET Nombre=@nombre, Precio=@precio, Cantidad=@cantidad WHERE IdProducto=@id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.Parameters.AddWithValue("@cantidad", prod.Cantidad);
                cmd.Parameters.AddWithValue("@id", prod.IdProducto);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            // Se muestra el mensaje de exito de actualizacion del producto
            Console.WriteLine("\nProducto actaulizado correctamente.\n");
        }
        #endregion


        #region Eliminar Productos
        public void EliminarProductos()
        {
            // Se solicita el ID del producto
            Console.Write("\nIngresa el Id del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            // Se llama al metodo de buscar productos y se pasa el ID
            Productos prod = BuscarProducto(id);

            // Si el producto no se encuentra o no existe se muestra el siguiente mensaje
            if (prod == null)
            {
                Console.WriteLine("\nNo se ha encontrado dicho producto con el ID ingresado.\n");
                return;
            }

            // Se crea una variable para guardar y ejecutar la sentencia SQL
            string query = "DELETE FROM Productos WHERE IdProducto = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            // Se muestra el mensaje de exito de eliminacion del producto
            Console.WriteLine($"\nProducto: {prod.Nombre} eliminado correctamente.\n");
        }
        #endregion

    }
}