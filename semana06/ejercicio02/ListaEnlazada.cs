class ListaEnlazada
{
    public Nodo Cabeza;         // Primer nodo de la lista

    public ListaEnlazada()
    {
        Cabeza = null;
    }

    // Metodo para agregar nodos al final de la lista
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Metodo que calcula la longitud de la lista
    public int CalcularLongitud()
    {
        int contador = 0;
        Nodo actual = Cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    // Metodo que invierte la lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;         // Nodo previo al actual
        Nodo actual = Cabeza;         // Nodo que estamos procesando
        Nodo siguiente = null;        // Guarda temporalmente el siguiente nodo

        // Recorremos la lista
        while (actual != null)
        {
            siguiente = actual.Siguiente;  // Guardamos el siguiente nodo
            actual.Siguiente = anterior;   // Invertimos el puntero del nodo actual
            anterior = actual;             // Movemos anterior al nodo actual
            actual = siguiente;            // Avanzamos al siguiente nodo
        }

        // Finalmente, actualizamos la cabeza de la lista
        Cabeza = anterior;
    }

    // Metodo para mostrar los valores de la lista
    public void Mostrar()
    {
        Nodo actual = Cabeza;

        Console.Write("head --> ");
        while (actual != null)
        {
            Console.Write($"[ {actual.Valor} | * ] --> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null\n");
    }
}