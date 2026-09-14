partial class Arbol
{
    public int maximo()
    {
        if (raiz == null)
        {
            throw new InvalidOperationException("El árbol está vacío.");
        }

        Nodo nodo = raiz;

        while (nodo.der != null)
        {
            nodo = nodo.der;
        }

        return nodo.valor;
    }
}
