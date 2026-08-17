// clase
public class Cuadrado
{
    // atributos
    public double lado { get; set; }

    // constructor
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // metodos
    public double CalcularArea()
    {
        return lado * lado;
    }

    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
