// Clase que gestiona los contactos usando un vector
public class Agenda
{
    private Contacto[] contactos;
    private int contador;

    public Agenda(int capacidad)
    {
        contactos = new Contacto[capacidad];
        contador = 0;
    }

    // Agrega un contacto al vector
    public void AgregarContacto(Contacto c)
    {
        if (contador < contactos.Length)
        {
            contactos[contador] = c;
            contador++;
        }
        else
        {
            Console.WriteLine("La agenda está llena.");
        }
    }

    // Ordena los contactos por nombre alfabéticamente
    public void OrdenarPorNombre()
    {
        Array.Sort(contactos, 0, contador, Comparer<Contacto>.Create(
        (a, b) => string.Compare(a.Nombre, b.Nombre, StringComparison.OrdinalIgnoreCase)
    ));
    }

    // Muestra todos los contactos
    public void MostrarContactos()
    {
        Console.WriteLine("\nAGENDA:");
        Console.WriteLine($"{"Nombre",-30} | {"Telefono",-15} | {"Detalle"}");
        Console.WriteLine("_______________________________|_________________|________________________________");
        for (int i = 0; i < contador; i++)
        {
            contactos[i].Mostrar();
        }
    }

    // Buscar contacto por nombre
    public void BuscarContacto(string nombre)
    {
        if (nombre == "")
        {
            Console.WriteLine("No ingreso ningun nombre a buscar.");
            return;
        }

        bool encontrado = false;
        Console.WriteLine($"\nAGENDA: (FILTRO)");
        Console.WriteLine($"{"Nombre",-30} | {"Telefono",-15} | {"Detalle"}");
        Console.WriteLine("_______________________________|_________________|________________________________");
        for (int i = 0; i < contador; i++)
        {
            if (contactos[i].Nombre.ToLower().Contains(nombre.ToLower()))
            {
                contactos[i].Mostrar();
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}
