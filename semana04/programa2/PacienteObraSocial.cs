// Subclase que representa un paciente con obra social
public class PacienteObraSocial : Paciente
{
    private string obraSocial { set; get; } // atributos prropios de la clase

    // Constructor: llama al constructor base e inicializa la obra social
    public PacienteObraSocial(string nombre, string cedula, string turno, string obraSocial)
        : base(nombre, cedula, turno)
    {
        this.obraSocial = obraSocial;
    }

    // Implementación del método Mostrar
    public override void Mostrar()
    {
        // Formato con columnas fijas
        Console.WriteLine($"{"[Obra Social]",-15} | {this.nombre,-20} | {this.cedula,-10} | {this.turno:dd/MM/yyyy HH:mm} | {this.obraSocial,-15}");
    }
}
