partial class Arbol
{
    public void inorden()
    {
        inordenRec(raiz);
        Console.WriteLine();
    }

    private void inordenRec(Nodo nodo)
    {
        if (nodo == null)
        {
            return;
        }

        inordenRec(nodo.izq);
        Console.Write(nodo.valor + " ");
        inordenRec(nodo.der);
    }
}
