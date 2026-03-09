using System;
using System.Collections.Generic;

class Program
{
    // Diccionario para guardar jugadores: ID -> Nombre
    // Lo uso porque permite buscar rápido por ID (mapa)
    static Dictionary<int, string> jugadores = new Dictionary<int, string>();

    // Diccionario para guardar equipos: NombreEquipo -> HashSet de jugadores
    // Uso HashSet para evitar duplicados cuando agrego jugadores a un equipo
    static Dictionary<string, HashSet<int>> equipos = new Dictionary<string, HashSet<int>>();

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== MENÚ TORNEO ===");
            Console.WriteLine("1) Registrar jugador");
            Console.WriteLine("2) Registrar equipo");
            Console.WriteLine("3) Asignar jugador a equipo");
            Console.WriteLine("4) Listar jugadores");
            Console.WriteLine("5) Listar equipos");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarJugador(); break;
                case "2": RegistrarEquipo(); break;
                case "3": AsignarJugador(); break;
                case "4": ListarJugadores(); break;
                case "5": ListarEquipos(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
    }

    // -------------------------- FUNCIONES --------------------------

    // Registrar un jugador por su ID
    static void RegistrarJugador()
    {
        Console.Write("ID del jugador: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nombre del jugador: ");
        string nombre = Console.ReadLine();

        // Evito duplicar IDs
        if (jugadores.ContainsKey(id))
        {
            Console.WriteLine("Ese ID ya existe.");
            return;
        }

        jugadores[id] = nombre;
        Console.WriteLine("Jugador registrado correctamente.");
    }

    // Registrar equipo
    static void RegistrarEquipo()
    {
        Console.Write("Nombre del equipo: ");
        string nombre = Console.ReadLine();

        if (equipos.ContainsKey(nombre))
        {
            Console.WriteLine("Ese equipo ya existe.");
            return;
        }

        // Cada equipo tiene un HashSet para evitar repetir jugadores
        equipos[nombre] = new HashSet<int>();
        Console.WriteLine("Equipo registrado.");
    }

    // Asignar jugador a un equipo
    static void AsignarJugador()
    {
        Console.Write("ID del jugador: ");
        int id = int.Parse(Console.ReadLine());

        if (!jugadores.ContainsKey(id))
        {
            Console.WriteLine("Ese jugador no existe.");
            return;
        }

        Console.Write("Nombre del equipo: ");
        string equipo = Console.ReadLine();

        if (!equipos.ContainsKey(equipo))
        {
            Console.WriteLine("Ese equipo no existe.");
            return;
        }

        // HashSet evita duplicados automáticamente
        equipos[equipo].Add(id);
        Console.WriteLine("Jugador asignado al equipo.");
    }

    // Mostrar jugadores
    static void ListarJugadores()
    {
        Console.WriteLine("\n--- JUGADORES ---");
        foreach (var j in jugadores)
        {
            Console.WriteLine($"ID {j.Key}: {j.Value}");
        }
    }

    // Mostrar equipos
    static void ListarEquipos()
    {
        Console.WriteLine("\n--- EQUIPOS ---");
        foreach (var e in equipos)
        {
            Console.WriteLine($"\nEquipo: {e.Key}");
            Console.WriteLine("Jugadores:");

            foreach (var id in e.Value)
            {
                Console.WriteLine($"  - {id} ({jugadores[id]})");
            }
        }
    }
}