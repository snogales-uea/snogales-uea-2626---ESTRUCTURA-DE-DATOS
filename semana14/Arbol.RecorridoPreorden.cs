partial class Arbol
{
    public void preorden()
    {
        preordenRec(raiz);
        Console.WriteLine();
    }

    private void preordenRec(Nodo nodo)
    {
        if (nodo == null)
        {
            return;
        }

        Console.Write(nodo.valor + " ");
        preordenRec(nodo.izq);
        preordenRec(nodo.der);
    }
}
