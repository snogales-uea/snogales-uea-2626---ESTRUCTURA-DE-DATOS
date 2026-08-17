Console.WriteLine("ESTRUCTURA DE DATOS - UEA");
Console.WriteLine();

// Crear un rectángulo con base 5 y altura 10.5
Rectangulo rectangulo = new Rectangulo(5, 20);

// Encabezado de tabla
Console.WriteLine("Rectangulo       | Valor");
Console.WriteLine("-----------------|-----------");

// Valores del rectángulo
Console.WriteLine("Base             | " + rectangulo.Base);
Console.WriteLine("Altura           | " + rectangulo.Altura);
Console.WriteLine("Área             | " + rectangulo.CalcularArea());
Console.WriteLine("Perímetro        | " + rectangulo.CalcularPerimetro());

Console.WriteLine();
