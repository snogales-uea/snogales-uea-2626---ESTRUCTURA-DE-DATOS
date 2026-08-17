using System;

class ListaDoble
{
    private Nodo cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
            nuevo.Anterior = actual;
        }
    }

    public void MostrarAdelante()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}