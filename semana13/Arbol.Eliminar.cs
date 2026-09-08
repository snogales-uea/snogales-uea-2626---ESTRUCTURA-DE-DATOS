partial class Arbol
{
    public void eliminar(int valor)
    {
        raiz = eliminarRec(raiz, valor);
    }

    private Nodo eliminarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
        {
            return null;
        }

        if (valor < nodo.valor)
        {
            nodo.izq = eliminarRec(nodo.izq, valor);
        }
        else if (valor > nodo.valor)
        {
            nodo.der = eliminarRec(nodo.der, valor);
        }
        else
        {
            // Caso 1: No tiene hijos
            if (nodo.izq == null && nodo.der == null)
            {
                return null;
            }

            // Caso 2: Solo tiene hijo derecho
            if (nodo.izq == null)
            {
                return nodo.der;
            }

            // Caso 2: Solo tiene hijo izquierdo
            if (nodo.der == null)
            {
                return nodo.izq;
            }

            // Caso 3: Tiene dos hijos
            Nodo menor = BuscarMenor(nodo.der);
            nodo.valor = menor.valor;
            nodo.der = eliminarRec(nodo.der, menor.valor);
        }

        return nodo;
    }

    private Nodo BuscarMenor(Nodo nodo)
    {
        while (nodo.izq != null)
        {
            nodo = nodo.izq;
        }

        return nodo;
    }
}