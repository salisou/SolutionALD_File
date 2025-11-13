// (ClosedXML, DocumentFormat.OpenXml) Librerie da istallare per creare file Excel facilmente

/*
   Titolo: Esportare i dati in un file Excel con i metodi

   Obiettivo:
        Creare un file ReportUniversita.xlsx con più fogli:
        Studenti
        Corsi
        Iscrizioni
        Voti
        Media per studente



 */

using ClosedXML.Excel;
using EsportaDatiExcel.Models;
using EsportaDatiExcel.Services;
using EsportareDatiExcel.Models;  // 📦 Libreria per creare file Excel facilmente

class Program
{
    static void Main()
    {
        // 1️⃣ CREAZIONE DELLE "TABELLE"
        var studenti   = DatiMock.CreaStudenti();
        var corsi      = DatiMock.CreaCorsi();
        var iscrizioni = DatiMock.CreaIscrizioni();
        var voti       = DatiMock.CreaVoti();

        // Generazione del file Excel
        string percorso = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.FullName, "ReportUniversita.xlsx");
        ReportExcel.Genera(percorso, studenti, corsi, iscrizioni, voti);

        Console.WriteLine($"✅ File generato con successo: {percorso}");
    }
}