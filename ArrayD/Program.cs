namespace Array3D;

class Program
{
    static void Main(string[] args)
    {
        //3D: Creare, Leggere, Modificare, iterare foreach e for
        string[,,] array3D = new string[3, 2, 2]
        {
            {
                { "100", "101"}, // Riga 0 colonna 0
                { "102", "103"}, // Riga 1 colonna 1
            },
            {
                { "201", "202"},
                { "203", "204" }
            },
            {
                { "405", "262"},
                { "503", "904" }
            }
        };

        // Prima dimensione 
        for (int dim1 = 0; dim1 < array3D.GetLength(0); dim1++)
        {
            // Seconda dimensione 
            for (int dim2 = 0; dim2 < array3D.GetLength(1); dim2++)
            {
                for (int dim3 = 0; dim3 < array3D.GetLength(2); dim3++)
                {
                    Console.WriteLine($"Sono in dim1 {dim1}, dim2 {dim2}, dim3 {dim3}");
                    Console.WriteLine($"Il valore è: {array3D[dim1, dim2, dim3]}");
                }
            }
        }



        // Leggiamo
        Console.WriteLine("Prima della modifica " + array3D[0, 1, 1]);

        // Modifica di un valore 
        array3D[0, 1, 1] = "999";
        Console.WriteLine("\nDopo la modifica");
        Console.WriteLine("codici[0,1,1] = " + array3D[0, 1, 1]);



        // LETTURA CON FOREACH
        foreach (string codice in array3D)
            Console.WriteLine(codice);
    }
}