using System;

// Clase Nodo
class Nodo
{
    public int valor;        // valor almacenado
    public Nodo izquierda;   // hijo izquierdo
    public Nodo derecha;     // hijo derecho

    public Nodo(int valor)
    {
        this.valor = valor;
        izquierda = null;
        derecha = null;
    }
}

// Clase Árbol Binario de Búsqueda
class ArbolBST
{
    public Nodo raiz;

    // Insertar un valor en el árbol
    public void Insertar(int valor)
    {
        raiz = InsertarRec(raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.valor)
            nodo.izquierda = InsertarRec(nodo.izquierda, valor);
        else if (valor > nodo.valor)
            nodo.derecha = InsertarRec(nodo.derecha, valor);

        return nodo;
    }

    // Buscar un valor en el árbol
    public bool Buscar(int valor)
    {
        return BuscarRec(raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (valor == nodo.valor)
            return true;

        if (valor < nodo.valor)
            return BuscarRec(nodo.izquierda, valor);
        else
            return BuscarRec(nodo.derecha, valor);
    }

    // Recorrido InOrden
    public void InOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.izquierda);
            Console.Write(nodo.valor + " ");
            InOrden(nodo.derecha);
        }
    }

    // Recorrido PreOrden
    public void PreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.valor + " ");
            PreOrden(nodo.izquierda);
            PreOrden(nodo.derecha);
        }
    }

    // Recorrido PostOrden
    public void PostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            PostOrden(nodo.izquierda);
            PostOrden(nodo.derecha);
            Console.Write(nodo.valor + " ");
        }
    }

    // Obtener valor mínimo
    public int Minimo()
    {
        Nodo actual = raiz;
        while (actual.izquierda != null)
            actual = actual.izquierda;

        return actual.valor;
    }

    // Obtener valor máximo
    public int Maximo()
    {
        Nodo actual = raiz;
        while (actual.derecha != null)
            actual = actual.derecha;

        return actual.valor;
    }

    // Calcular altura del árbol
    public int Altura(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        int izquierda = Altura(nodo.izquierda);
        int derecha = Altura(nodo.derecha);

        return Math.Max(izquierda, derecha) + 1;
    }

    // Eliminar un valor del árbol
    public Nodo Eliminar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return nodo;

        if (valor < nodo.valor)
            nodo.izquierda = Eliminar(nodo.izquierda, valor);
        else if (valor > nodo.valor)
            nodo.derecha = Eliminar(nodo.derecha, valor);
        else
        {
            // Caso 1: sin hijos
            if (nodo.izquierda == null && nodo.derecha == null)
                return null;

            // Caso 2: un hijo
            if (nodo.izquierda == null)
                return nodo.derecha;

            if (nodo.derecha == null)
                return nodo.izquierda;

            // Caso 3: dos hijos
            Nodo sucesor = nodo.derecha;
            while (sucesor.izquierda != null)
                sucesor = sucesor.izquierda;

            nodo.valor = sucesor.valor;
            nodo.derecha = Eliminar(nodo.derecha, sucesor.valor);
        }

        return nodo;
    }

    // Limpiar el árbol
    public void Limpiar()
    {
        raiz = null;
    }
}

// Programa principal con menú
class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\nMENU BST");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Mostrar recorridos");
            Console.WriteLine("5. Mostrar minimo, maximo y altura");
            Console.WriteLine("6. Limpiar arbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;

                case 2:
                    Console.Write("Ingrese valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Valor encontrado" : "Valor no encontrado");
                    break;

                case 3:
                    Console.Write("Ingrese valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.raiz = arbol.Eliminar(arbol.raiz, valor);
                    break;

                case 4:
                    Console.WriteLine("InOrden:");
                    arbol.InOrden(arbol.raiz);
                    Console.WriteLine("\nPreOrden:");
                    arbol.PreOrden(arbol.raiz);
                    Console.WriteLine("\nPostOrden:");
                    arbol.PostOrden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    if (arbol.raiz != null)
                    {
                        Console.WriteLine("Minimo: " + arbol.Minimo());
                        Console.WriteLine("Maximo: " + arbol.Maximo());
                        Console.WriteLine("Altura: " + arbol.Altura(arbol.raiz));
                    }
                    else
                    {
                        Console.WriteLine("El arbol esta vacio");
                    }
                    break;

                case 6:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol limpiado");
                    break;

            }

        } while (opcion != 0);
    }
}