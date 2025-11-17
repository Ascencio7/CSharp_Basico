using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Estudiante
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public double Promedio { get; set; }


        public Estudiante(int id, string nombre, string apellido, int edad, string correo, string telefono, double promedio)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Correo = correo;
            Telefono = telefono;
            Promedio = promedio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Promedio: {Promedio}");
        }

    }
}
