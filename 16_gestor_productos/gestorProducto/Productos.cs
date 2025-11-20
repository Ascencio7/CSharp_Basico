using System;
using System.Collections.Generic;
using System.Text;

namespace gestorProducto
{
    public class Productos
    {
        // Se crean las propiedades a manejar del producto
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public double precioProducto { get; set; }
        public int cantidadProducto { get; set; }

        // Total calculado automáticamente
        public double totalProducto
        {
            get { return Math.Round(precioProducto * cantidadProducto, 2); }
        }

        // Se crea el constructor de la clase Productos con sus parametros
        public Productos(int id, string nombre, double precio, int cantidad)
        {
            // Se asignan los parametros a las propiedades de la clase
            idProducto = id;
            nombreProducto = nombre;
            precioProducto = precio;
            cantidadProducto = cantidad;
        }

        // Se sobreescribe el metodo para mostrar la informacion del producto
        public override string ToString()
        {
            return $"ID: {idProducto} | Nombre: {nombreProducto} | Precio: ${precioProducto} | Cantidad: {cantidadProducto} | Total: ${totalProducto}";
        }
    }
}