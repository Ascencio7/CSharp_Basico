using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Estudiante
{
    public class Program
    {
        #region Variables Globales
        static List<Estudiante> estudiantes = new List<Estudiante>();
        static int nextId = 1;
        #endregion

        static void Main(string[] args)
        {
            #region Variable Menu
            // declarar la variable para el menu
            int option = 0;
            #endregion

            #region Bucle Menu
            // Bucle para mostrar el menu
            do
            {
                Console.WriteLine("\n=== Gestor de Estudiantes ===");
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Mostrar Estudiantes");
                Console.WriteLine("3. Buscar Estudiante por nombre");
                Console.WriteLine("4. Eliminar Estudiante por Id");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción del menu: ");

                // verificar las opciones del menu
                if(int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option) // Evalua la opcion seleccionada
                    {
                        case 1: // Para la primera opcion...
                            AgregarEstudiante(); // se llama al metod de agregar
                            break; // finaliza el bucle
                        case 2:
                            MostrarEstudiantes();
                            break;
                        case 3:
                            BuscarEstudiantePorNombre();
                            break;
                        case 4:
                            EliminarEstudiantePorId();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa..."); // Mensaje de salida
                            break; // finaliza el bucle
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo."); // mensaje de error si la opcion no es valida
                            break; // finaliza el bucle
                    }
                }
                else // si la opcion no es un numero, se muestra un mensaje de error
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

            } while (option != 5); // el bucle se repite hasta que la opcion sea 5
            #endregion
        }

        #region Agregar Estudiante
        public static void AgregarEstudiante()
        {
            // se solicita los datos del estudiante
            Console.WriteLine("\nIngrese los datos del estudiante:");
            Console.Write("\nNombre: "); // se solicita el nombre
            string nombre = Console.ReadLine(); // se guarda el nombre en una variable y se lee desde la consola (asi para los demas campos)
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Correo: ");
            string correo = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Promedio: ");
            double promedio = double.Parse(Console.ReadLine());

            // se crea un nuevo objeto Estudiante con los datos ingresados
            Estudiante nuevoEstudiante = new Estudiante(nextId++, nombre, apellido, edad, correo, telefono, promedio);

            // se agrega el nuevo estudiante a la lista de estudiantes
            estudiantes.Add(nuevoEstudiante);
            // se muestra un mensaje de exito de que el estudiante fue agregado correctamente
            Console.WriteLine("\nEstudiante agregado exitosamente.");
        }
        #endregion


        #region Mostrar Estudiantes
        public static void MostrarEstudiantes() // metodo para mostrar la informacion de los estudiantes
        {
            if (estudiantes.Count == 0) // si la lista de estudiantes esta vacia, se muestra el mensaje
            {
                Console.WriteLine("\nNo hay estudiantes registrados."); 
                return; // finaliza el metodo si no hay estudiantes
            }
            // si hay estudiantes se muestran los datos de cada uno
            Console.WriteLine("\nLista de Estudiantes registrados:");

            // se recorre la lista de estudiantes y se muestra la informacion de cada uno
            foreach (var estudiante in estudiantes) // se usa foreach para recorrer la lista de los estudiantes
            {
                estudiante.MostrarInformacion(); // se llama al metodo para mostra los datos del estudiante
                Console.WriteLine("\n-------------------------"); // se imprime una linea para separar los estudiantes
            }
        }
        #endregion


        #region Buscar Estudiante por Nombre
        public static void BuscarEstudiantePorNombre() // metodo para buscar un estudiante por su nombre
        {
            Console.Write("\nIngrese el nombre del estudiante a buscar: "); // se solicita el nombre del estudiante a buscar
            string nombreBuscado = Console.ReadLine(); // se guarda el nombre ingresado en una variable para leerlo desde la consola

            // se busca en la lista de estudiantes que coincida con el nombre ingresado
            var estudiantesEncontrados = estudiantes.Where(e => e.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase)).ToList(); // se usa LINQ para filtrar los estudiantes por nombre y se 
            // convierte el resultado a una lista y se guarda en la variable estudiantesEncontrados

            // si no se encuentran estudiantes con ese nombre, se muestra un mensaje
            if (estudiantesEncontrados.Count == 0)
            {
                Console.WriteLine("\nNo se encontraron estudiantes con ese nombre.");
                return; // finaliza el metodo si no se encuentran los estudiantes
            }

            // si se encuentran estudiantes se muestran los datos
            Console.WriteLine("\nEstudiantes encontrados:");

            // se recorre la lista de estudiantes encontrados y se muestra los datos de cada uno
            foreach (var estudiante in estudiantesEncontrados)
            {
                estudiante.MostrarInformacion(); // se llama al metodo para mostrar el dato del estudiante
                Console.WriteLine("\n-------------------------"); // se imprime una linea para separar los estudiantes
            }
        }
        #endregion


        #region Eliminar Estudiante por Id
        public static void EliminarEstudiantePorId() // metodo para eliminar un estudiante por su id
        {
            Console.Write("Ingrese el ID del estudiante a eliminar: "); // se solicita el ID del estudiante a eliminar
            if (int.TryParse(Console.ReadLine(), out int id)) // se intenta convertir la entrada del usuario a un entero
            {
                // se busca en la lista de estudiantes el estudiante con el ID ingresado
                var estudianteAEliminar = estudiantes.FirstOrDefault(e => e.Id == id); // se usa LINQ para buscar el estudiante por su ID y se guarda en la variable estudianteAEliminar
                if (estudianteAEliminar != null) // si se encuentra el estudiante con el ID ingresado
                {
                    estudiantes.Remove(estudianteAEliminar); // se elimina el estudiante de la lista
                    Console.WriteLine("\nEstudiante eliminado exitosamente."); // se muestra un mensaje de exito
                }
                else
                {
                    Console.WriteLine("\nNo se encontró un estudiante con ese ID."); // si no se encuentra el estudiante con el ID ingresado, se muestra un mensaje
                }
            }
            else
            {
                Console.WriteLine("\nEl ID no es válido. Por favor, ingrese un número.");
            }
        }
        #endregion

    }
}