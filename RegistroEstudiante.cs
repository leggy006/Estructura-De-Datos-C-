using System;

namespace RegistroEstudiante
{
    // Clase Estudiante para guardar los datos básicos
    class Estudiante
    {
        public int ID;
        public string nombres;
        public string apellidos;
        public string direccion;

        // Array para almacenar los 3 números de teléfono
        public string[] telefonos = new string[3];

        // Método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("\n----- DATOS REGISTRADOS -----");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);

            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine("- Teléfono " + (i + 1) + ": " + telefonos[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Estudiante
            Estudiante est = new Estudiante();

            Console.WriteLine("REGISTRO DE ESTUDIANTE");
            Console.WriteLine("------------------------");

            // Pedimos los datos básicos
            Console.Write("Ingrese el ID: ");
            est.ID = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los nombres: ");
            est.nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos: ");
            est.apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            est.direccion = Console.ReadLine();

            // Pedimos los 3 números de teléfono usando un array
            Console.WriteLine("Ingrese los 3 números de teléfono:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Teléfono " + (i + 1) + ": ");
                est.telefonos[i] = Console.ReadLine();
            }

            // Mostramos todos los datos que se ingresaron
            est.MostrarDatos();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadLine();

        }
    }
}
