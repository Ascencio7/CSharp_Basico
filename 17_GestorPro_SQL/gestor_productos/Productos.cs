using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_productos
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public override string ToString()
        {
            return $"ID: {IdProducto} | Nombre: {Nombre} | Precio: ${Precio} | Cantidad: {Cantidad} | Total: ${Total}";
        }

    }
}