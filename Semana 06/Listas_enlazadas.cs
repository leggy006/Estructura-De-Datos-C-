using System;

namespace ListasEnlazadas
{
    // Clase Nodo: representa cada elemento de la lista enlazada
    class Nodo
    {
        public int Dato;       // Valor almacenado en el nodo
        public Nodo Siguiente; // Referencia al siguiente nodo

        // Constructor del nodo
        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada: maneja todas las operaciones de la lista
    class ListaEnlazada
    {
        private Nodo cabeza; // Primer nodo de la lista

        // Constructor de la lista
        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para insertar un elemento al final de la lista
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            // Si la lista está vacía, el nuevo nodo será la cabeza
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                // Si no está vacía, recorremos hasta el último nodo
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // ---------------- EJERCICIO 1 ----------------
        // Método que calcula el número de elementos de la lista enlazada
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            // Recorremos la lista hasta llegar al final
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // ---------------- EJERCICIO 3 ----------------
        // Método que busca un valor y retorna cuántas veces aparece
        public int Buscar(int valor)
        {
            int contador = 0;
            Nodo actual = cabeza;

            // Recorremos toda la lista
            while (actual != null)
            {
                // Si el dato coincide, incrementamos el contador
                if (actual.Dato == valor)
                {
                    contador++;
                }
                actual = actual.Siguiente;
            }

            return contador;
        }

        // Método para mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;

            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una nueva lista enlazada
            ListaEnlazada lista = new ListaEnlazada();

            // Insertamos algunos valores en la lista
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);
            lista.Insertar(20);
            lista.Insertar(40);
            lista.Insertar(20);

            // Mostramos la lista completa
            lista.Mostrar();

            // ----------- Resultado del Ejercicio 1 -----------
            int totalElementos = lista.ContarElementos();
            Console.WriteLine("Número de elementos en la lista: " + totalElementos);

            // ----------- Resultado del Ejercicio 3 -----------
            Console.Write("Ingrese el valor a buscar: ");
            int valorBuscado = int.Parse(Console.ReadLine());

            int vecesEncontrado = lista.Buscar(valorBuscado);

            if (vecesEncontrado > 0)
            {
                Console.WriteLine("El valor " + valorBuscado + " se encontró " + vecesEncontrado + " veces en la lista.");
            }
            else
            {
                Console.WriteLine("El valor ingresado no fue encontrado en la lista.");
            }
        }
    }
}
