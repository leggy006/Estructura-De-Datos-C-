using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Diccionario donde guardo las palabras en inglés como clave y su traducción al español como valor
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Time", "tiempo" },
            { "Person", "persona" },
            { "Year", "año" },
            { "Day", "día" },
            { "Thing", "cosa" },
            { "Man", "hombre" },
            { "World", "mundo" },
            { "Life", "vida" },
            { "Hand", "mano" },
            { "Part", "parte" },
            { "Eye", "ojo" },
            { "Woman", "mujer" }
        };

        int opcion;

        do
        {
            // Muestro el menú
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    // Opción para traducir una frase
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();

                    // Separo la frase en palabras usando espacio
                    string[] palabras = frase.Split(' ');

                    Console.WriteLine("\nTraducción:");

                    foreach (string palabra in palabras)
                    {
                        // Verifico si la palabra existe en el diccionario
                        if (diccionario.ContainsKey(palabra))
                        {
                            Console.Write(diccionario[palabra] + " ");
                        }
                        else
                        {
                            // Si no existe, dejo la palabra igual
                            Console.Write(palabra + " ");
                        }
                    }

                    Console.WriteLine("\n");
                    break;

                case 2:
                    // Opción para agregar nuevas palabras
                    Console.Write("Ingrese la palabra en inglés: ");
                    string ingles = Console.ReadLine();

                    Console.Write("Ingrese la traducción en español: ");
                    string espanol = Console.ReadLine();

                    // Agrego la nueva palabra al diccionario
                    diccionario[ingles] = espanol;

                    Console.WriteLine("Palabra agregada correctamente.\n");
                    break;

                case 0:
                    // Salir del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }

        } while (opcion != 0);
    }
}