// Clase que administra los turnos de los pacientes
public class AgendaTurnos
{
    // Vector para almacenar pacientes
    private Paciente[] pacientes;

    // Contador de cuántos pacientes se han registrado
    private int contador;

    // Constructor: define la capacidad máxima de la agenda
    public AgendaTurnos(int capacidad)
    {
        pacientes = new Paciente[capacidad];
        contador = 0;
    }

    // Método para agregar un turno (paciente) a la agenda
    public void AgregarTurno(Paciente p)
    {
        if (contador < pacientes.Length)
        {
            pacientes[contador++] = p;
        }
        else
        {
            Console.WriteLine("Agenda llena.");
        }
    }

    // Método para mostrar todos los turnos
    public void MostrarTurnos()
    {
        Console.WriteLine("\nAGENDA DE TURNOS:");
        Console.WriteLine("Tipo            | Nombre               | CEDULA     | Turno            | Extra");
        Console.WriteLine("________________|______________________|____________|__________________|_________________");

        for (int i = 0; i < contador; i++)
        {
            pacientes[i].Mostrar();
        }
    }

    // Método para ordenar los turnos alfabéticamente por nombre
    public void OrdenarPorNombre()
    {
        Array.Sort(pacientes, 0, contador, Comparer<Paciente>.Create(
            (a, b) => string.Compare(a.nombre, b.nombre, StringComparison.OrdinalIgnoreCase)
        ));

        Console.WriteLine("\nTurnos ordenados por nombre.");
    }
}
