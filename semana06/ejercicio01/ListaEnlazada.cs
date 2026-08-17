// Clase ListaEnlazada: gestiona la lista enlazada manualmente
class ListaEnlazada
{
    public Nodo Cabeza;                 // Nodo inicial de la lista (el primero nodo) 

    // Constructor: inicializa la lista vacia
    public ListaEnlazada()
    {
        Cabeza = null;
    }

    // Metodo para agregar un nuevo nodo al final de la lista
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);   // Crear un nuevo nodo con el valor dado

        if (Cabeza == null)
        {
            // Si la lista esta vacia, el nuevo nodo se convierte en la cabeza
            Cabeza = nuevo;
        }
        else
        {
            // Si la lista ya tiene elementos, recorrer hasta el ultimo nodo
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente; // Avanzar al siguiente nodo
            }
            // Enlazar el ultimo nodo con el nuevo nodo
            actual.Siguiente = nuevo;
        }
    }

    // Metodo que calcula la longitud de la lista recorriendola nodo por nodo
    public int CalcularLongitud()
    {
        int contador = 0;               // Contador de nodos
        Nodo actual = Cabeza;           // Empezamos desde la cabeza de la lista

        while (actual != null)
        {
            contador++;                 // Contamos el nodo actual
            actual = actual.Siguiente;  // Avanzamos al siguiente nodo
        }

        return contador;                // Retornamos la cantidad total de nodos
    }

    // Metodo para imprimir en consola la lista
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