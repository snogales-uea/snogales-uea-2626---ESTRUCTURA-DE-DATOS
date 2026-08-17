// Contacto profesional hereda de Contacto
public class ContactoProfesional : Contacto
{
    private string empresa;

    public string Empresa
    {
        get { return empresa; }
        set { empresa = value; }
    }

    public ContactoProfesional(string nombre, string telefono, string empresa)
        : base(nombre, telefono)
    {
        this.empresa = empresa;
    }

    public override void Mostrar()
    {
        Console.WriteLine($"{Nombre,-30} | {Telefono,-15} | {"[Profesional]",-15} {Empresa,-15}");
    }
}
