partial class Arbol
{
    public void postorden()
    {
        postordenRec(raiz);
        Console.WriteLine();
    }

    private void postordenRec(Nodo nodo)
    {
        if (nodo == null)
        {
            return;
        }

        postordenRec(nodo.izq);
        postordenRec(nodo.der);
        Console.Write(nodo.valor + " ");
    }
}
