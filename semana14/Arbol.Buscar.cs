partial class Arbol
{
    public bool buscar(int valor)
    {
        return buscarRec(raiz, valor);
    }

    private bool buscarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
        {
            return false;
        }

        if (valor == nodo.valor)
        {
            return true;
        }

        if (valor < nodo.valor)
        {
            return buscarRec(nodo.izq, valor);
        }

        return buscarRec(nodo.der, valor);
    }
}
