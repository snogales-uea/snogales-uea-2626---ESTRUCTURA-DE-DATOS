// Clase abstracta que representa a un paciente genérico
public abstract class Paciente
{
    // Encapsulamiento: campos privados
    public string nombre { set; get; }
    public string cedula { set; get; }
    public string turno { set; get; }

    // Constructor común para todos los pacientes
    public Paciente(string nombre, string cedula, string turno)
    {
        this.nombre = nombre;
        this.cedula = cedula;
        this.turno = turno;
    }

    // Método abstracto que será implementado por las subclases
    public abstract void Mostrar();
}
