// Subclase que representa un paciente particular
public class PacienteParticular : Paciente
{
    public string motivo { set; get; }

    // Constructor: llama al constructor base e inicializa el motivo
    public PacienteParticular(string nombre, string cedula, string turno, string motivo)
        : base(nombre, cedula, turno)
    {
        this.motivo = motivo;
    }

    // Implementación del método Mostrar
    public override void Mostrar()
    {
        Console.WriteLine($"{ "[Particular]",-15} | {this.nombre,-20} | {this.cedula,-10} | {this.turno:dd/MM/yyyy HH:mm} | {this.motivo,-15}");
    }
}
