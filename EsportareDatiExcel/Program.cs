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

namespace EsportareDatiExcel;


class Program
{
    static void Main(string[] args)
    {
        // CREAZIONE DELLE "TABELLE"
        List<Dictionary<string, object>> studenti = CreaStudenti();
        List<Dictionary<string, object>> corsi = CreaCorsi();
        List<Dictionary<string, object>> iscrizioni = CreaIscrizioni();
        List<Dictionary<string, object>> voti = CreaVoti();

        // CREA UN NUOVO FILE EXCEL IN MEMORIA 
        using XLWorkbook workbook = new();
        //=======================
        // FOGLIO 1 -> Studente |
        //=======================
    }

    #region Metodi
    //=============================
    // METODI DI SUPORTO
    //=============================
    static List<Dictionary<string, object>> CreaStudenti() =>
    [
        new() { ["StudenteId"] = 1, ["Nome"]="Marco", ["Cognome"]="Rossi", ["Email"]="marco.rossi@email.com" },
        new() { ["StudenteId"] = 2, ["Nome"]="Luca", ["Cognome"]="Bianchi", ["Email"]="luca.bianchi@email.com" },
        new() { ["StudenteId"] = 3, ["Nome"]="Giulia", ["Cognome"]="Verdi", ["Email"]="giulia.verdi@email.com" }
    ];

    static List<Dictionary<string, object>> CreaCorsi() =>
    [
        new() { ["CorsoId"]=1, ["NomeCorso"]="Informatica", ["Crediti"]=6 },
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

    // Creiamo un metodo per trovare un record in base alla chiave 
    static Dictionary<string, object> Trova(List<Dictionary<string, object>> tabella, string chiave, int valore)
    {
        return tabella.Find(riga => (int)riga[chiave] == valore)!;
    }

    // Creiamo un metodo calcolare la media voti di uno studente 
    static double CalcolaMedia(Dictionary<string, object> studente,
                             List<Dictionary<string, object>> voti,
                             List<Dictionary<string, object>> iscrizioni)
    {
        int studId = (int)studente["Id"];
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
    #endregion
}