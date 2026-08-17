Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 05");

while (true)
{
    Console.WriteLine("\nSeleccione un ejercicio (1 - 10), o 0 para salir:");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Ejercicio01.Ejecutar();
            break;
        case "2":
            Ejercicio02.Ejecutar();
            break;
        case "3":
            Ejercicio03.Ejecutar();
            break;
        case "4":
            Ejercicio04.Ejecutar();
            break;
        case "5":
            Ejercicio05.Ejecutar();
            break;
        case "6":
            Ejercicio06.Ejecutar();
            break;
        case "7":
            Ejercicio07.Ejecutar();
            break;
        case "8":
            Ejercicio08.Ejecutar();
            break;
        case "9":
            Ejercicio09.Ejecutar();
            break;
        case "10":
            Ejercicio10.Ejecutar();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}