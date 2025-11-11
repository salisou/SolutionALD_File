namespace ArrayCollection;

class program
{
    static void Main(string[] args)
    {
        //2D: Creare, Leggere, Modificare, iterare foreach e for.3D
        string[,] codici = new string[3, 2]
        {
            { "010", "011" },
            { "020", "021"},
            { "030", "031"}
        };

        // Leggere
        Console.WriteLine(codici[2, 1]);

        // Modificare
        codici[2, 1] = "032";

        Console.WriteLine(codici[2, 1]);

        foreach (string codice in codici)
        {
            Console.WriteLine(codice);
        }

        for (int righe = 0; righe < codici.GetLength(0); righe++)
        {
            Console.WriteLine($"Sono in riga: {righe}");
            for (int colonne = 0; colonne < codici.GetLength(1); colonne++)
            {
                Console.WriteLine($"Sono in colonna: {righe}");
                Console.WriteLine($"Valore {codici[righe, colonne]}");
            }
        }
    }
}