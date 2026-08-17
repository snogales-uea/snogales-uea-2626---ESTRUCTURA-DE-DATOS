// Clase abstracta que representa un contacto genérico
public abstract class Contacto
{
    // Encapsulamiento: campos privados con propiedades públicas
    private string nombre;
    private string telefono;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    // Constructor
    public Contacto(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
    }

    // Abstracción: método que será implementado en clases hijas
    public abstract void Mostrar();
}
