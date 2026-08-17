// Contacto personal hereda de Contacto
public class ContactoPersonal : Contacto
{
    private string relacion;

    public string Relacion
    {
        get { return relacion; }
        set { relacion = value; }
    }

    public ContactoPersonal(string nombre, string telefono, string relacion)
        : base(nombre, telefono)
    {
        this.relacion = relacion;
    }

    // Implementación del método abstracto
    public override void Mostrar()
    {
        Console.WriteLine($"{Nombre,-30} | {Telefono,-15} | {"[Personal]",-15} {Relacion,-15}");
    }
}
