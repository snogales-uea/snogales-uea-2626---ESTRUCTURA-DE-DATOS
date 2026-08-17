// Clase Nodo: representa un elemento de la lista
class Nodo
{
    public int Valor;           // Valor que contiene el nodo
    public Nodo Siguiente;      // Referencia al siguiente nodo

    // Constructor que inicializa el nodo con un valor
    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;      // Por defecto, el siguiente nodo es null
    }
}