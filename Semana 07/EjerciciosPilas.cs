using System;
using System.Collections.Generic;

namespace Pilas_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== USO DE PILAS EN C# ===\n");

            // -------------------------------------------------
            // 1. VERIFICACIÓN DE PARÉNTESIS BALANCEADOS
            // -------------------------------------------------
            Console.WriteLine("1. Verificación de paréntesis balanceados\n");

            Console.WriteLine("Ingrese una expresión matemática (o presione Enter para usar el ejemplo):");
            string entrada = Console.ReadLine();

            // Si el usuario no ingresa nada, se utiliza el ejemplo del enunciado
            string expresion;
            if (string.IsNullOrWhiteSpace(entrada))
            {
                expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
            }
            else
            {
                expresion = entrada;
            }

            Console.WriteLine("\nExpresión: " + expresion);

            if (ParentesisBalanceados(expresion))
            {
                Console.WriteLine("Resultado: Fórmula balanceada.\n");
            }
            else
            {
                Console.WriteLine("Resultado: Fórmula NO balanceada.\n");
            }

            // -------------------------------------------------
            // 2. TORRES DE HANOI USANDO PILAS
            // -------------------------------------------------
            Console.WriteLine("2. Resolución de las Torres de Hanoi usando pilas\n");

            int numeroDiscos = 3;

            Stack<int> torreOrigen = new Stack<int>();
            Stack<int> torreAuxiliar = new Stack<int>();
            Stack<int> torreDestino = new Stack<int>();

            // Se insertan los discos en la torre de origen
            for (int i = numeroDiscos; i >= 1; i--)
            {
                torreOrigen.Push(i);
            }

            ResolverHanoi(numeroDiscos, torreOrigen, torreDestino, torreAuxiliar,
                          "Origen", "Destino", "Auxiliar");

            Console.WriteLine("\nProceso finalizado.");
            Console.ReadLine();
        }

        // -------------------------------------------------
        // MÉTODO PARA VERIFICAR PARÉNTESIS BALANCEADOS
        // -------------------------------------------------
        static bool ParentesisBalanceados(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char caracter in expresion)
            {
                // Si es un símbolo de apertura, se inserta en la pila
                if (caracter == '(' || caracter == '{' || caracter == '[')
                {
                    pila.Push(caracter);
                }

                // Si es un símbolo de cierre, se verifica la correspondencia
                if (caracter == ')' || caracter == '}' || caracter == ']')
                {
                    // Si la pila está vacía, no hay coincidencia
                    if (pila.Count == 0)
                    {
                        return false;
                    }

                    char ultimo = pila.Pop();

                    // Verifica que el símbolo de apertura coincida con el de cierre
                    if (!Coinciden(ultimo, caracter))
                    {
                        return false;
                    }
                }
            }

            // Si la pila queda vacía, la expresión está correctamente balanceada
            return pila.Count == 0;
        }

        // Método auxiliar para validar la coincidencia de símbolos
        static bool Coinciden(char apertura, char cierre)
        {
            if (apertura == '(' && cierre == ')') return true;
            if (apertura == '{' && cierre == '}') return true;
            if (apertura == '[' && cierre == ']') return true;
            return false;
        }

        // -------------------------------------------------
        // MÉTODO RECURSIVO PARA TORRES DE HANOI USANDO PILAS
        // -------------------------------------------------
        static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino,
                                  Stack<int> auxiliar,
                                  string nombreOrigen, string nombreDestino,
                                  string nombreAuxiliar)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
                return;
            }

            ResolverHanoi(n - 1, origen, auxiliar, destino,
                          nombreOrigen, nombreAuxiliar, nombreDestino);

            int discoActual = origen.Pop();
            destino.Push(discoActual);
            Console.WriteLine($"Mover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

            ResolverHanoi(n - 1, auxiliar, destino, origen,
                          nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }
}
