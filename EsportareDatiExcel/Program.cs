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
using EsportareDatiExcel.Models;  // 📦 Libreria per creare file Excel facilmente

class Program
{
    static void Main()
    {
        Studente studente = new Studente();


        // 1️⃣ CREAZIONE DELLE "TABELLE"
        List<Dictionary<string, object>> studenti = CreaStudenti();
        List<Dictionary<string, object>> corsi = CreaCorsi();
        List<Dictionary<string, object>> iscrizioni = CreaIscrizioni();
        List<Dictionary<string, object>> voti = CreaVoti();

        // 🔹 Percorso assoluto della radice del progetto
        string rootPath = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.FullName;

        // 🔹 Costruiamo il percorso completo del file Excel nella radice
        string percorsoFile = Path.Combine(rootPath, "ReportUniversita.xlsx");

        // (Facoltativo) Stampa a video per controllo
        Console.WriteLine("📁 Il file verrà salvato in: " + percorsoFile);

        // Crea un nuovo file Excel in memoria
        using (XLWorkbook workbook = new())
        {
            // ========================
            // Foglio 1 – Studenti
            // ========================
            IXLWorksheet wsStudenti = workbook.Worksheets.Add("Studenti");
            wsStudenti.Cell(1, 1).Value = "StudenteId";
            wsStudenti.Cell(1, 2).Value = "Nome";
            wsStudenti.Cell(1, 3).Value = "Cognome";
            wsStudenti.Cell(1, 4).Value = "Email";

            int riga = 2;
            foreach (Dictionary<string, object> s in studenti)
            {
                wsStudenti.Cell(riga, 1).Value = s["StudenteId"].ToString();
                wsStudenti.Cell(riga, 2).Value = s["Nome"].ToString();
                wsStudenti.Cell(riga, 3).Value = s["Cognome"].ToString();
                wsStudenti.Cell(riga, 4).Value = s["Email"].ToString();
                riga++;
            }

            // ========================
            // Foglio 2 – Corsi
            // ========================
            IXLWorksheet wsCorsi = workbook.Worksheets.Add("Corsi");
            wsCorsi.Cell(1, 1).Value = "CorsoId";
            wsCorsi.Cell(1, 2).Value = "NomeCorso";
            wsCorsi.Cell(1, 3).Value = "Crediti";

            riga = 2;
            foreach (Dictionary<string, object> c in corsi)
            {
                wsCorsi.Cell(riga, 1).Value = c["CorsoId"].ToString();
                wsCorsi.Cell(riga, 2).Value = c["NomeCorso"].ToString();
                wsCorsi.Cell(riga, 3).Value = c["Crediti"].ToString();
                riga++;
            }

            // ========================
            // Foglio 3 – Iscrizioni
            // ========================
            IXLWorksheet wsIscrizioni = workbook.Worksheets.Add("Iscrizioni");
            wsIscrizioni.Cell(1, 1).Value = "IscrizioneId";
            wsIscrizioni.Cell(1, 2).Value = "Studente";
            wsIscrizioni.Cell(1, 3).Value = "Corso";
            wsIscrizioni.Cell(1, 4).Value = "DataIscrizione";

            riga = 2;
            foreach (var i in iscrizioni)
            {
                Dictionary<string, object> stud = Trova(studenti, "StudenteId", (int)i["StudenteId"]);
                Dictionary<string, object> corso = Trova(corsi, "CorsoId", (int)i["CorsoId"]);

                wsIscrizioni.Cell(riga, 1).Value = i["IscrizioneId"].ToString();
                wsIscrizioni.Cell(riga, 2).Value = $"{stud["Nome"]} {stud["Cognome"]}";
                wsIscrizioni.Cell(riga, 3).Value = corso["NomeCorso"].ToString();
                wsIscrizioni.Cell(riga, 4).Value = ((DateTime)i["DataIscrizione"]).ToShortDateString();
                riga++;
            }

            // ========================
            // Foglio 4 – Voti
            // ========================
            IXLWorksheet wsVoti = workbook.Worksheets.Add("Voti");
            wsVoti.Cell(1, 1).Value = "VotoId";
            wsVoti.Cell(1, 2).Value = "Studente";
            wsVoti.Cell(1, 3).Value = "Corso";
            wsVoti.Cell(1, 4).Value = "Voto";
            wsVoti.Cell(1, 5).Value = "DataEsame";

            riga = 2;
            foreach (Dictionary<string, object> v in voti)
            {
                Dictionary<string, object> iscr = Trova(iscrizioni, "IscrizioneId", (int)v["IscrizioneId"]);
                var stud = Trova(studenti, "StudenteId", (int)iscr["StudenteId"]);
                var corso = Trova(corsi, "CorsoId", (int)iscr["CorsoId"]);

                wsVoti.Cell(riga, 1).Value = v["VotoId"].ToString();
                wsVoti.Cell(riga, 2).Value = $"{stud["Nome"]} {stud["Cognome"]}";
                wsVoti.Cell(riga, 3).Value = corso["NomeCorso"].ToString();
                wsVoti.Cell(riga, 4).Value = v["Voto"].ToString();
                wsVoti.Cell(riga, 5).Value = ((DateTime)v["DataEsame"]).ToShortDateString();
                riga++;
            }

            // ========================
            // Foglio 5 – Medie
            // ========================
            IXLWorksheet wsMedie = workbook.Worksheets.Add("Medie");
            wsMedie.Cell(1, 1).Value = "Studente";
            wsMedie.Cell(1, 2).Value = "Media Voti";

            riga = 2;
            foreach (var s in studenti)
            {
                double media = CalcolaMedia(s, voti, iscrizioni);
                wsMedie.Cell(riga, 1).Value = $"{s["Nome"]} {s["Cognome"]}";
                wsMedie.Cell(riga, 2).Value = media > 0 ? media.ToString("F2") : "N/A";
                riga++;
            }

            // 3️⃣ SALVIAMO IL FILE
            workbook.SaveAs(percorsoFile);
        }

        Console.WriteLine($"File Excel generato correttamente: {System.IO.Path.GetFullPath(percorsoFile)}");
    }

    // ======================
    // METODI DI SUPPORTO
    // ======================

    static List<Dictionary<string, object>> CreaStudenti() =>
    [
        new() { ["StudenteId"]=1, ["Nome"]="Marco", ["Cognome"]="Rossi", ["Email"]="marco.rossi@email.com" },
        new() { ["StudenteId"]=2, ["Nome"]="Luca", ["Cognome"]="Bianchi", ["Email"]="luca.bianchi@email.com" },
        new() { ["StudenteId"]=3, ["Nome"]="Giulia", ["Cognome"]="Verdi", ["Email"]="giulia.verdi@email.com" }
    ];

    static List<Dictionary<string, object>> CreaCorsi() =>
    [
        new() { ["CorsoId"]=1, ["NomeCorso"]="Programmazione C#/.Net", ["Crediti"]=6 },
        new() { ["CorsoId"]=2, ["NomeCorso"]="Matematica", ["Crediti"]=8 },
        new() { ["CorsoId"]=3, ["NomeCorso"]="Storia", ["Crediti"]=5 }
    ];

    static List<Dictionary<string, object>> CreaIscrizioni() =>
    [
        new() { ["IscrizioneId"]=1, ["StudenteId"]=1, ["CorsoId"]=1, ["DataIscrizione"]=new DateTime(2024,9,1) },
        new() { ["IscrizioneId"]=2, ["StudenteId"]=2, ["CorsoId"]=2, ["DataIscrizione"]=new DateTime(2024,9,1) },
        new() { ["IscrizioneId"]=3, ["StudenteId"]=3, ["CorsoId"]=3, ["DataIscrizione"]=new DateTime(2024,9,1) }
    ];

    static List<Dictionary<string, object>> CreaVoti() =>
    [
        new() { ["VotoId"]=1, ["IscrizioneId"]=1, ["Voto"]=28, ["DataEsame"]=new DateTime(2024,12,15) },
        new() { ["VotoId"]=2, ["IscrizioneId"]=2, ["Voto"]=30, ["DataEsame"]=new DateTime(2025,1,10) },
        new() { ["VotoId"]=3, ["IscrizioneId"]=3, ["Voto"]=25, ["DataEsame"]=new DateTime(2025,1,20) }
    ];

    // Metodo per trovare un record in base a una chiave
    static Dictionary<string, object> Trova(List<Dictionary<string, object>> tabella, string chiave, int valore)
    {
        return tabella.Find(riga => (int)riga[chiave] == valore)!;
    }

    // Metodo per calcolare la media voti di uno studente
    static double CalcolaMedia(Dictionary<string, object> studente,
                               List<Dictionary<string, object>> voti,
                               List<Dictionary<string, object>> iscrizioni)
    {
        int studId = (int)studente["StudenteId"];
        int somma = 0;
        int conteggio = 0;

        foreach (var i in iscrizioni)
        {
            if ((int)i["StudenteId"] == studId)
            {
                var voto = voti.Find(v => (int)v["IscrizioneId"] == (int)i["IscrizioneId"]);
                if (voto != null)
                {
                    somma += (int)voto["Voto"];
                    conteggio++;
                }
            }
        }

        return conteggio > 0 ? (double)somma / conteggio : 0;
    }
}
