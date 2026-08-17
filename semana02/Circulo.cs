// clase
public class Circulo : Figura
{
    // atributos
    public double radio { get; set; }

    // constructor
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // metodos
    public override double CalcularArea()
    {
        return Math.Round((Math.PI * radio * radio), 2);
    }

    public override double CalcularPerimetro()
    {
        return Math.Round((2 * Math.PI * radio), 2);
    }
}
