// Nodo del árbol
class Nodo
{
    public int valor;
    public Nodo izq;
    public Nodo der;

    public Nodo(int value)
    {
        valor = value;
        izq = null;
        der = null;
    }
}