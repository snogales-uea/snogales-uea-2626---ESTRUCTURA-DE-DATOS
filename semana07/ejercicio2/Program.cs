/*
Resolución del problema de las Torres de Hanoi
Desarrolle un algoritmo que resuelva el problema de las Torres de Hanoi utilizando pilas. 
El programa debe mostrar paso a paso cómo se mueven los discos entre las torres.
*/

Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 07");

Console.Write("Ingrese la cantidad de discos: ");
int numDiscos = int.Parse(Console.ReadLine());

// Cargar los discos en la torre de origen (del mayor al menor)
for (int i = numDiscos; i >= 1; i--)
{
    Ejercicio2.origen.Push(i);
}

Console.WriteLine("\nEstado inicial:");
Ejercicio2.MostrarTorres();

// Resolver el problema
Ejercicio2.Resolver(numDiscos, Ejercicio2.origen, Ejercicio2.destino, Ejercicio2.auxiliar, "Origen", "Destino", "Auxiliar");

Console.WriteLine("¡Todos los discos se han movido exitosamente!");