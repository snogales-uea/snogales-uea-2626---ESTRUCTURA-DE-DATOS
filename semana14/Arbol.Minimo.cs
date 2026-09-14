partial class Arbol
{
    public int minimo()
    {
        if (raiz == null)
        {
            throw new InvalidOperationException("El árbol está vacío.");
        }

        Nodo nodo = raiz;

        while (nodo.izq != null)
        {
            nodo = nodo.izq;
        }

        return nodo.valor;
    }
}
