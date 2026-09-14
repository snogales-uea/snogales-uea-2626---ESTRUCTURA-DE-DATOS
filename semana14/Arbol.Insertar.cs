partial class Arbol
{
    public void insertar(int valor)
    {
        if (raiz == null)
        {
            raiz = new Nodo(valor);
        }
        else
        {
            insertarRec(raiz, valor);
        }
    }

    private void insertarRec(Nodo nodo, int valor)
    {
        if (valor < nodo.valor)
        {
            if (nodo.izq == null)
            {
                nodo.izq = new Nodo(valor);
            }
            else
            {
                insertarRec(nodo.izq, valor);
            }
        }
        else
        {
            if (nodo.der == null)
            {
                nodo.der = new Nodo(valor);
            }
            else
            {
                insertarRec(nodo.der, valor);
            }
        }
    }
}