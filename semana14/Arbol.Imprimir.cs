partial class Arbol
{
    public void imprimir()
    {
        if (raiz == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }

        int altura = obtenerAltura(raiz);
        int ancho = (int)Math.Pow(2, altura) * 4;

        imprimirNivel(
            new List<Nodo> { raiz },
            1,
            altura,
            ancho
        );
    }

    private void imprimirNivel(
        List<Nodo> nodos,
        int nivel,
        int altura,
        int ancho)
    {
        if (nivel > altura)
            return;

        int separacion = ancho / (int)Math.Pow(2, nivel);
        int inicio = separacion / 2;

        Console.Write(new string(' ', inicio));

        List<Nodo> siguiente = new List<Nodo>();

        foreach (Nodo nodo in nodos)
        {
            if (nodo != null)
            {
                Console.Write(nodo.valor);

                siguiente.Add(nodo.izq);
                siguiente.Add(nodo.der);
            }
            else
            {
                Console.Write("  ");

                siguiente.Add(null);
                siguiente.Add(null);
            }

            Console.Write(
                new string(' ', Math.Max(1, separacion - 2))
            );
        }

        Console.WriteLine();

        if (nivel < altura)
        {
            Console.Write(
                new string(' ', Math.Max(0, inicio - 1))
            );

            foreach (Nodo nodo in nodos)
            {
                if (nodo != null)
                {
                    if (nodo.izq != null)
                        Console.Write("/");
                    else
                        Console.Write(" ");

                    Console.Write(" ");

                    if (nodo.der != null)
                        Console.Write("\\");
                    else
                        Console.Write(" ");
                }
                else
                {
                    Console.Write("   ");
                }

                Console.Write(
                    new string(' ', Math.Max(1, separacion - 3))
                );
            }

            Console.WriteLine();
        }

        imprimirNivel(
            siguiente,
            nivel + 1,
            altura,
            ancho
        );
    }

    private int obtenerAltura(Nodo nodo)
    {
        if (nodo == null)
            return 0;

        int izquierda = obtenerAltura(nodo.izq);
        int derecha = obtenerAltura(nodo.der);

        return Math.Max(izquierda, derecha) + 1;
    }
}