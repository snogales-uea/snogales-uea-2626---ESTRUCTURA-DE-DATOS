using System.Text.RegularExpressions;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>();

    static void Main()
    {
        CargarBase();

        while (true)
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Traducir frase");
            Console.WriteLine("2. Agregar palabra");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();
            if (opcion == "1")
                TraducirFrase();
            else if (opcion == "2")
                AgregarPalabra();
            else if (opcion == "0")
                break;
            else
                Console.WriteLine("Opción inválida");
        }
    }

    static void CargarBase()
    {
        diccionario.Add("tiempo", "time"); // Tiempo tiEMPO TieMPo -> tiempo
        diccionario.Add("persona", "person");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("día", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("hombre", "man");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("ojo", "eye");
        diccionario.Add("dia", "day");
        diccionario.Add("gobierno", "government");
        diccionario["hermoso"] = "beautiful";
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese frase en español: ");
        string frase = Console.ReadLine();

        var expresion = Regex.Split(frase, @"(\W+)"); // separa palabras y signos
        for (int i = 0; i < expresion.Length; i++)
        {
            string palabra = expresion[i].ToLower(); // <-- conversión a minúscula al comparar
            if (diccionario.ContainsKey(palabra))
                expresion[i] = diccionario[palabra];
        }

        Console.WriteLine("Traducción: " + string.Join("", expresion));
    }

    static void AgregarPalabra()
    {
        Console.Write("Palabra en español: ");
        string es = (Console.ReadLine() ?? "").Trim().ToLower(); // <-- guardada en minúscula

        Console.Write("Traducción en inglés: ");
        string en = (Console.ReadLine() ?? "").Trim();

        if (!string.IsNullOrWhiteSpace(es) && !string.IsNullOrWhiteSpace(en))
        {
            diccionario[es] = en;
            Console.WriteLine("Agregada con éxito.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}
