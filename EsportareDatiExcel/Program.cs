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

namespace EsportareDatiExcel;

class Program
{
    static void Main(string[] args)
    {

    }

    //=============================
    // METODI DI SUPORTO
    //=============================
    static List<Dictionary<string, object>> CreaStudenti =
    [
        new() {["SudenteId"] = 1, ["Nome"]=  "Marco", ["Cognome"] = "Rossi", ["Email"] = "marco.rossi@gmail.com" },
        new() {["SudenteId"] = 2, ["Nome"]=  "Luca", ["Cognome"] = "Bianchi", ["Email"] = "luca.bianchi@infoitalia.it" },
        new() {["SudenteId"] = 3, ["Nome"]=  "Giulia", ["Cognome"] = "Verdi", ["Email"] = "g.verdi1@ferrari.it" }
    ];

    static List<Dictionary<string, object>> CreaCorsi =
    [
        new(){["CorsoId"] = 1, ["NomeCorso"] = "Informatica", ["Crediti"] = "6"},
        new(){["CorsoId"] = 2, ["NomeCorso"] = "Matematica", ["Crediti"] = "8"},
        new(){["CorsoId"] = 3, ["NomeCorso"] = "Storia", ["Crediti"] = "5"}
    ];

    static List<Dictionary<string, object>> CreaIscrizioni =
    [
        new(){["IscrizioneId"] = 1, ["StudenteId"] = 1, ["CorsoId"] = 1, ["DataIscrizione"] = new DateTime(2023,9,1)},
        new(){["IscrizioneId"] = 2, ["StudenteId"] = 2, ["CorsoId"] = 2, ["DataIscrizione"] = new DateTime(2024,10,10)},
        new(){["IscrizioneId"] = 3, ["StudenteId"] = 3, ["CorsoId"] = 3, ["DataIscrizione"] = new DateTime(2025,1,7)}
    ];

    static List<Dictionary<string, object>> CreaVoti =
    [
        new() {["CotoId"] = 1, ["IscrizioneId"] = 1, ["Voto"] = 18, ["DataEsame"] = new DateTime(2024,12,15)},
        new() {["CotoId"] = 2, ["IscrizioneId"] = 2, ["Voto"] = 25, ["DataEsame"] = new DateTime(2024,1,18)},
        new() {["CotoId"] = 3, ["IscrizioneId"] = 3, ["Voto"] = 30, ["DataEsame"] = new DateTime(2024,1,21)}
    ];

    // Creiamo un metodo per trovare un record in base alla chiave 
    static Dictionary<string, object> Trova(List<Dictionary<string, object>> tabella, string chiave, int valore)
    {
        return tabella.Find(riga => (int)riga[chiave] == valore)!;
    }

    // Creiamo un metodo calcolare la media voti di uno studente 
    static double CalcolaMedia(Dictionary<string, object> studente,
                               Dictionary<string, object> voto,
                               Dictionary<string, object> iscrizione)
    {

    }
}