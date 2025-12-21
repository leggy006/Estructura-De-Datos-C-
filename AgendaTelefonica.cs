using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    // Clase que representa un contacto de la agenda
    class Contacto
    {
        // Propiedades del contacto
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        // Constructor para inicializar el contacto
        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }

    class Program
    {
        // Lista que almacena los contactos de la agenda
        static List<Contacto> agenda = new List<Contacto>();

        static void Main(string[] args)
        {
            int opcion;

            // Menú principal del sistema
            do
            {
                Console.Clear();
                Console.WriteLine("AGENDA TELEFONICA");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;

                    case 2:
                        MostrarContactos();
                        break;

                    case 3:
                        BuscarContacto();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }

        // Metodo para agregar un nuevo contacto a la agenda
        static void AgregarContacto()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del contacto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el telefono del contacto: ");
            string telefono = Console.ReadLine();

            Contacto nuevoContacto = new Contacto(nombre, telefono);
            agenda.Add(nuevoContacto);

            Console.WriteLine("Contacto agregado correctamente.");
        }

        // Metodo para mostrar todos los contactos registrados
        static void MostrarContactos()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE CONTACTOS");
            Console.WriteLine("------------------");

            if (agenda.Count == 0)
            {
                Console.WriteLine("No existen contactos registrados.");
            }
            else
            {
                foreach (Contacto c in agenda)
                {
                    Console.WriteLine("Nombre: " + c.Nombre + " - Telefono: " + c.Telefono);
                }
            }
        }

        // Metodo para buscar un contacto por nombre
        static void BuscarContacto()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();

            bool encontrado = false;

            foreach (Contacto c in agenda)
            {
                if (c.Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contacto encontrado:");
                    Console.WriteLine("Nombre: " + c.Nombre);
                    Console.WriteLine("Telefono: " + c.Telefono);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El contacto no existe en la agenda.");
            }
        }
    }
}
