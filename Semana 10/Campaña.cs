using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Conjunto general de ciudadanos (500 en total)
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // conjunto de vacunados con Pfizer (75)
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // conjunto de vacunados con AstraZeneca (75)
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // ---------------- OPERACIONES DE CONJUNTOS ----------------

        // 1-Ciudadanos que recibieron ambas dosis (intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // 2-Ciudadanos que solo recibieron Pfizer (diferencia)
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // 3-Ciudadanos que solo recibieron AstraZeneca (diferencia)
        HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // 4-Ciudadanos sin vacunarse
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // ---------------- MOSTRAR RESULTADOS ----------------

        Console.WriteLine("Ciudadanos que no se han vacunado:");
        foreach (var c in noVacunados)
            Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos que han recibido ambas dosis:");
        foreach (var c in ambasDosis)
            Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos que solo han recibido Pfizer:");
        foreach (var c in soloPfizer)
            Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos que solo han recibido AstraZeneca:");
        foreach (var c in soloAstraZeneca)
            Console.WriteLine(c);

        Console.WriteLine("\nProceso finalizado.");
    }
}
