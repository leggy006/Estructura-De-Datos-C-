using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TAREA 5 - ESTRUCTURA DE DATOS ===\n");

        Ejercicio1();
        Ejercicio2();
        Ejercicio8();
        Ejercicio9();
        Ejercicio10();

        Console.WriteLine("\nFin de la ejecución de los ejercicios.");
    }

    // ---------------- EJERCICIO 1 ----------------
    // Almacenar asignaturas en una lista y mostrarlas
    static void Ejercicio1()
    {
        Console.WriteLine("\nEjercicio 1: Lista de asignaturas");

        List<string> asignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        foreach (string materia in asignaturas)
        {
            Console.WriteLine(materia);
        }
    }

    // ---------------- EJERCICIO 2 ----------------
    // Mostrar mensaje "Yo estudio <asignatura>"
    static void Ejercicio2()
    {
        Console.WriteLine("\nEjercicio 2: Yo estudio...");

        List<string> asignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        foreach (string materia in asignaturas)
        {
            Console.WriteLine("Yo estudio " + materia);
        }
    }

    // ---------------- EJERCICIO 8 ----------------
    // Verificar si una palabra es palíndromo
    static void Ejercicio8()
    {
        Console.WriteLine("\nEjercicio 8: Palíndromo");

        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        char[] letras = palabra.ToCharArray();
        Array.Reverse(letras);
        string invertida = new string(letras);

        if (palabra == invertida)
        {
            Console.WriteLine("La palabra ES un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra NO es un palíndromo.");
        }
    }

    // ---------------- EJERCICIO 9 ----------------
    // Contar cuántas veces aparece cada vocal
    static void Ejercicio9()
    {
        Console.WriteLine("\nEjercicio 9: Conteo de vocales");

        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int a = 0, e = 0, i = 0, o = 0, u = 0;

        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a': a++; break;
                case 'e': e++; break;
                case 'i': i++; break;
                case 'o': o++; break;
                case 'u': u++; break;
            }
        }

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"e: {e}");
        Console.WriteLine($"i: {i}");
        Console.WriteLine($"o: {o}");
        Console.WriteLine($"u: {u}");
    }

    // ---------------- EJERCICIO 10 ----------------
    // Mostrar el menor y mayor precio
    static void Ejercicio10()
    {
        Console.WriteLine("\nEjercicio 10: Menor y mayor precio");

        List<int> precios = new List<int>() { 50, 75, 46, 22, 80, 65, 8 };

        int menor = precios[0];
        int mayor = precios[0];

        foreach (int precio in precios)
        {
            if (precio < menor)
                menor = precio;

            if (precio > mayor)
                mayor = precio;
        }

        Console.WriteLine("Precio menor: " + menor);
        Console.WriteLine("Precio mayor: " + mayor);
    }
}
