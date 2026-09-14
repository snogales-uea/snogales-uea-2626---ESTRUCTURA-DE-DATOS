
Arbol arbol = new Arbol();
bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("===== MENU ARBOL BINARIO DE BUSQUEDA =====");
    Console.WriteLine("1.  Insertar");
    Console.WriteLine("2.  Buscar");
    Console.WriteLine("3.  Eliminar");
    Console.WriteLine("4.  Recorrido Preorden");
    Console.WriteLine("5.  Recorrido Inorden");
    Console.WriteLine("6.  Recorrido Postorden");
    Console.WriteLine("7.  Minimo");
    Console.WriteLine("8.  Maximo");
    Console.WriteLine("9.  Altura");
    Console.WriteLine("10. Imprimir");
    Console.WriteLine("11. Limpiar");
    Console.WriteLine("0.  Salir");
    Console.Write("Seleccione una opcion: ");

    string opcion = Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("Valor a insertar: ");
            arbol.insertar(int.Parse(Console.ReadLine()));
            break;

        case "2":
            Console.Write("Valor a buscar: ");
            int valorBuscar = int.Parse(Console.ReadLine());
            Console.WriteLine(
                arbol.buscar(valorBuscar)
                    ? "El valor existe en el arbol."
                    : "El valor no existe en el arbol."
            );
            break;

        case "3":
            Console.Write("Valor a eliminar: ");
            arbol.eliminar(int.Parse(Console.ReadLine()));
            break;

        case "4":
            Console.Write("Preorden:  ");
            arbol.preorden();
            break;

        case "5":
            Console.Write("Inorden:   ");
            arbol.inorden();
            break;

        case "6":
            Console.Write("Postorden: ");
            arbol.postorden();
            break;

        case "7":
            try
            {
                Console.WriteLine("Minimo: " + arbol.minimo());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            break;

        case "8":
            try
            {
                Console.WriteLine("Maximo: " + arbol.maximo());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            break;

        case "9":
            Console.WriteLine("Altura: " + arbol.altura());
            break;

        case "10":
            arbol.imprimir();
            break;

        case "11":
            arbol.limpiar();
            Console.WriteLine("Arbol vaciado.");
            break;

        case "0":
            salir = true;
            break;

        default:
            Console.WriteLine("Opcion invalida.");
            break;
    }
}
