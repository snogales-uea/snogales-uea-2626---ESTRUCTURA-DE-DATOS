partial class Arbol
{
    public int altura()
    {
        return alturaRec(raiz);
    }

    private int alturaRec(Nodo nodo)
    {
        if (nodo == null)
        {
            return 0;
        }

        int izquierda = alturaRec(nodo.izq);
        int derecha = alturaRec(nodo.der);

        return Math.Max(izquierda, derecha) + 1;
    }
}
