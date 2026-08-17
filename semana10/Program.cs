class Program
{
    static void Main()
    {
        Console.WriteLine("ESTRUCTURA DE DATOS - UEA / SEMANA 10");

        // =========================================================================
        // 1. Crear conjunto de 500 ciudadanos
        // =========================================================================
        HashSet<string> conjuntoU = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            conjuntoU.Add("Ciudadano " + i);
        }

        // =========================================================================
        // 2. Crear conjunto ficticio de 75 vacunados con Pfizer
        // =========================================================================
        HashSet<string> conjuntoA = GenerarVacunados();

        // =========================================================================
        // 3. Crear conjunto ficticio de 75 vacunados con AstraZeneca
        // =========================================================================
        HashSet<string> conjuntoB = GenerarVacunados();

        // =========================================================================
        // 4. Operaciones de conjuntos
        // =========================================================================

        /*
        U = [1,2,..500] //TODOS
        A = [1,25,6]    //PZIFER
        B = [2,6,4]     //AZTRAZENCA

        vacunados = A u B = [1,2,4,6,25]
        novacunados = U - vacunados [3,5,7...,24...500]

        */

        // vacunados = (A ∪ B)
        var vacunados = new HashSet<string>(conjuntoA);     // copia de A
        vacunados.UnionWith(conjuntoB);                     // ahora A ∪ B

        // no vacunados = U - vacunados
        var noVacunados = new HashSet<string>(conjuntoU);   // copia de U
        noVacunados.ExceptWith(vacunados);                  // U - vacunados

        // ambas dosis = A ∩ B
        var ambasDosis = new HashSet<string>(conjuntoA);    // copia de A 
        ambasDosis.IntersectWith(conjuntoB);

        // solo Pfizer = A - B
        var soloPfizer = new HashSet<string>(conjuntoA);    // copia de A 
        soloPfizer.ExceptWith(conjuntoB);

        // solo AstraZeneca = B - A
        var soloAstra = new HashSet<string>(conjuntoB);    // copia de B
        soloAstra.ExceptWith(conjuntoA);

        // =========================================================================
        // 5. Resultados
        // =========================================================================
        Console.WriteLine("\n=== Campaña de Vacunación COVID-19 ===");
        Console.WriteLine("Total ciudadanos: " + conjuntoU.Count);
        Console.WriteLine("Vacunados con Pfizer: " + conjuntoA.Count);
        Console.WriteLine("Vacunados con AstraZeneca: " + conjuntoB.Count);
        Console.WriteLine("Vacunados: " + vacunados.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);

        // (Opcional) Mostrar listados:
        
        Console.WriteLine("\n-- No vacunados --");
        foreach (var c in noVacunados) Console.WriteLine(c);

        Console.WriteLine("\n-- Ambas dosis --");
        foreach (var c in ambasDosis) Console.WriteLine(c);

        Console.WriteLine("\n-- Solo Pfizer --");
        foreach (var c in soloPfizer) Console.WriteLine(c);

        Console.WriteLine("\n-- Solo AstraZeneca --");
        foreach (var c in soloAstra) Console.WriteLine(c);

    }

    // Método para generar ciudadanos vacunados de manera aleatoria
    static HashSet<string> GenerarVacunados()
    {
        HashSet<string> conjunto = new HashSet<string>();
        Random random = new Random();
        while (conjunto.Count < 75)
        //for (int i = 1; i <= 75; i++)
        {
            int num = random.Next(1, 500);
            conjunto.Add("Ciudadano " + num);
        }
        return conjunto;
    }
}
