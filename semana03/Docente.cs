public class Docente
{
    // Atributos
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string[] Ltelefono { get; set; }

    public Docente(int id, string nombre, string apellido, string direccion, string[] ltelefono)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
        this.Ltelefono = ltelefono;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Docente");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre Completo: {this.Nombre} {this.Apellido}");
        Console.WriteLine($"Direccion: {this.Direccion}");
        Console.WriteLine("Telefonos:");
        int contador = 1;
        foreach (var telefono in this.Ltelefono)
        {
            Console.WriteLine($" {contador++}: {telefono}");
        }
    }
}