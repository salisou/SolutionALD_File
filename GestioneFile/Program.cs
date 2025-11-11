using ClosedXML.Excel;

namespace GestioneFile;

class Program
{

    /// <summary>
    /// AppContext.BaseDirectory: Ottiene il percorso deve viene eseguito il programma (bin/Debug/ReportUniversita.xlsx)
    /// Parent!.FullName: Risale di due cartelle (bin -> Debug -> net8.0) per tornare alla radice del progetetto
    /// ath.Combine(...)	Combina il percorso del progetto con il nome del file Excel.
    /// Console.WriteLine(...)	Serve solo per verificare il percorso(puoi toglierlo in produzione).
    /// </summary>
    static void Main()
    {
        // Trava la cartella principale del progetto 
        string rootPath = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.FullName;
        //Console.WriteLine(rootPath);

        // Precorso del file Excel da creare
        string percorsoFile = Path.Combine(rootPath, "ReportUniversita.xlsx");

        // Creiamo il file Excel di esempio
        using (XLWorkbook workbook = new())
        {
            IXLWorksheet ws = workbook.Worksheets.Add("Test");
            ws.Cell(1, 1).Value = "Funziona!";
            workbook.SaveAs(percorsoFile);
        }

        Console.WriteLine($"File Excel creato in {percorsoFile} 🎉🎉🎉🎉🎉");
    }
}