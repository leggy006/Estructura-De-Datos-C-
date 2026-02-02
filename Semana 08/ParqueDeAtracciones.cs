using System;
using System.Collections.Generic;

namespace AtraccionParque
{
    // Clase que representa a una persona que llega a la atracción
    class Persona
    {
        // Propiedad que almacena el nombre de la persona
        public string Nombre { get; set; }

        // Constructor de la clase Persona
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase que representa la atracción del parque de diversiones
    class Atraccion
    {
        // Cola que almacena a las personas en orden de llegada
        private Queue<Persona> cola;

        // Capacidad máxima de asientos de la atracción
        private int capacidadMaxima;

        // Constructor que inicializa la cola y define la capacidad
        public Atraccion(int capacidad)
        {
            cola = new Queue<Persona>();
            capacidadMaxima = capacidad;
        }

        // Método que agrega una persona a la cola si existen asientos disponibles
        public void AgregarPersona(Persona persona)
        {
            if (cola.Count < capacidadMaxima)
            {
                // Se agrega la persona al final de la cola respetando el orden de llegada
                cola.Enqueue(persona);
                Console.WriteLine(persona.Nombre + " ha sido agregado a la cola.");
            }
            else
            {
                // Mensaje que indica que ya no existen asientos disponibles
                Console.WriteLine("Todos los asientos han sido vendidos.");
            }
        }

        // Método de reportería que permite visualizar las personas que están en la cola
        public void MostrarCola()
        {
            Console.WriteLine("\nPersonas en la cola:");

            if (cola.Count == 0)
            {
                Console.WriteLine("La cola está vacía.");
            }
            else
            {
                // Se recorre la cola para mostrar el orden de llegada
                foreach (Persona persona in cola)
                {
                    Console.WriteLine("- " + persona.Nombre);
                }
            }
        }

        // Método que simula la subida de las personas a la atracción
        public void IniciarAtraccion()
        {
            Console.WriteLine("\nIniciando la atracción...");

            // Mientras existan personas en la cola, se las va retirando en orden
            while (cola.Count > 0)
            {
                Persona persona = cola.Dequeue();
                Console.WriteLine(persona.Nombre + " sube a la atracción.");
            }

            Console.WriteLine("Todos los asientos han sido ocupados.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia de la atracción con capacidad para 30 personas
            Atraccion atraccion = new Atraccion(30);

            // Simulación de la llegada de 30 personas a la atracción
            for (int i = 1; i <= 30; i++)
            {
                atraccion.AgregarPersona(new Persona("Persona " + i));
            }

            // Se muestra el estado de la cola antes de iniciar la atracción
            atraccion.MostrarCola();

            // Se inicia la atracción respetando el orden de llegada
            atraccion.IniciarAtraccion();

            // Se detiene la consola para visualizar los resultados
            Console.ReadKey();
        }
    }
}
