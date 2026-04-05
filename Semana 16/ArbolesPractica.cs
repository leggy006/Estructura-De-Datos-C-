using System;
using System.Collections.Generic;

class Nodo
{
    // Valor que guarda el nodo (nombre)
    public string Valor;
    // Lista de hijos del nodo
    public List<Nodo> Hijos;

    public Nodo(string valor)
    {
        Valor = valor;
        Hijos = new List<Nodo>();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO 1: ÁRBOL ACADÉMICO ===");

        // Simulo datos de un bloc de notas
        Nodo raizAcademica = new Nodo("Universidad");
        Nodo carrera = new Nodo("Tecnología de la Información");
        Nodo materia1 = new Nodo("Estructura de Datos");
        Nodo materia2 = new Nodo("Programación");

        raizAcademica.Hijos.Add(carrera);
        carrera.Hijos.Add(materia1);
        carrera.Hijos.Add(materia2);

        MostrarArbol(raizAcademica, 0);

        Console.WriteLine("\n=== EJEMPLO 2: ÁRBOL DE CARPETAS ===");

        Nodo raizCarpetas = new Nodo("Disco Local");
        Nodo documentos = new Nodo("Documentos");
        Nodo fotos = new Nodo("Fotos");
        Nodo tareas = new Nodo("Tareas");

        raizCarpetas.Hijos.Add(documentos);
        raizCarpetas.Hijos.Add(fotos);
        documentos.Hijos.Add(tareas);

        MostrarArbol(raizCarpetas, 0);
    }

    // Método recursivo para mostrar el árbol
    static void MostrarArbol(Nodo nodo, int nivel)
    {
        // Sangría según el nivel del árbol
        Console.WriteLine(new string('-', nivel * 2) + nodo.Valor);

        foreach (Nodo hijo in nodo.Hijos)
        {
            MostrarArbol(hijo, nivel + 1);
        }
    }
}