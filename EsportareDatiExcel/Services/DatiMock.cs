using EsportaDatiExcel.Models;
using EsportareDatiExcel.Models;

namespace EsportaDatiExcel.Services
{
    public class DatiMock
    {

        // ======================
        // METODI DI SUPPORTO
        // ======================
        public static List<Studente> CreaStudenti() =>
        [
            new() { StudenteId = 1, Nome = "Marco", Cognome = "Rossi", Email = "marco.rossi@email.com" },
            new() { StudenteId = 2, Nome = "Luca", Cognome = "Bianchi", Email = "luca.bianchi@email.com" },
            new() { StudenteId = 3, Nome = "Giulia", Cognome = "Verdi", Email = "giulia.verdi@email.com" }
        ];

        public static List<Corso> CreaCorsi() =>
        [
            new() { CorsoId = 1, NomeCorso = "Informatica", Crediti = 6 },
            new() { CorsoId = 2, NomeCorso = "Matematica", Crediti = 8 },
            new() { CorsoId = 3, NomeCorso = "Storia", Crediti = 5 }
        ];

        public static List<Iscrizione> CreaIscrizioni() =>
        [
            new() { IscrizioneId = 1, StudenteId = 1, CorsoId = 1, DataIscrizione = new DateTime(2024, 9, 1) },
            new() { IscrizioneId = 2, StudenteId = 2, CorsoId = 2, DataIscrizione = new DateTime(2024, 9, 1) },
            new() { IscrizioneId = 3, StudenteId = 3, CorsoId = 3, DataIscrizione = new DateTime(2024, 9, 1) }
        ];


        public static List<Voto> CreaVoti() =>
        [
            new() { VotoId = 1, IscrizioneId = 1, Valore = 28, DataEsame = new DateTime(2024, 12, 15) },
            new() { VotoId = 2, IscrizioneId = 2, Valore = 30, DataEsame = new DateTime(2025, 1, 10) },
            new() { VotoId = 3, IscrizioneId = 3, Valore = 25, DataEsame = new DateTime(2025, 1, 20) }
        ];
    }
}
