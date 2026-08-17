class ListaCircular
{
    private Nodo cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
            cabeza.Siguiente = cabeza;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != cabeza)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
            nuevo.Siguiente = cabeza;
        }
    }

    public void Mostrar(int repeticiones = 1)
    {
        if (cabeza == null) return;

        Nodo actual = cabeza;
        int contador = 0;

        do
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
            contador++;
        } while (actual != cabeza && contador < 100); // protección contra bucles infinitos

        Console.WriteLine("(vuelve al inicio)");
    }
}