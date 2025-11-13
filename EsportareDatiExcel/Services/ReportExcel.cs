using ClosedXML.Excel;
using EsportaDatiExcel.Models;
using EsportareDatiExcel.Models;

namespace EsportaDatiExcel.Services
{
    public class ReportExcel
    {
        public static void Genera(string percorsoFile,
        List<Studente> studenti,
        List<Corso> corsi,
        List<Iscrizione> iscrizioni,

        List<Voto> voti)
        {
            using var wb = new XLWorkbook();

            // 🧾 Studenti
            var ws1 = wb.Worksheets.Add("Studenti");
            ws1.Cell(1, 1).Value = "StudenteId";
            ws1.Cell(1, 2).Value = "Nome";
            ws1.Cell(1, 3).Value = "Cognome";
            ws1.Cell(1, 4).Value = "Email";

            int riga = 2;
            foreach (var s in studenti)
            {
                ws1.Cell(riga, 1).Value = s.StudenteId;
                ws1.Cell(riga, 2).Value = s.Nome;
                ws1.Cell(riga, 3).Value = s.Cognome;
                ws1.Cell(riga, 4).Value = s.Email;
                riga++;
            }

            // 📚 Corsi
            var ws2 = wb.Worksheets.Add("Corsi");
            ws2.Cell(1, 1).Value = "CorsoId";
            ws2.Cell(1, 2).Value = "NomeCorso";
            ws2.Cell(1, 3).Value = "Crediti";

            riga = 2;
            foreach (var c in corsi)
            {
                ws2.Cell(riga, 1).Value = c.CorsoId;
                ws2.Cell(riga, 2).Value = c.NomeCorso;
                ws2.Cell(riga, 3).Value = c.Crediti;
                riga++;
            }

            // 🧾 Iscrizioni
            var ws3 = wb.Worksheets.Add("Iscrizioni");
            ws3.Cell(1, 1).Value = "Studente";
            ws3.Cell(1, 2).Value = "Corso";
            ws3.Cell(1, 3).Value = "Data Iscrizione";

            riga = 2;
            foreach (var i in iscrizioni)
            {
                var s = studenti.Find(x => x.StudenteId == i.StudenteId)!;
                var c = corsi.Find(x => x.CorsoId == i.CorsoId)!;
                ws3.Cell(riga, 1).Value = $"{s.Nome} {s.Cognome}";
                ws3.Cell(riga, 2).Value = c.NomeCorso;
                ws3.Cell(riga, 3).Value = i.DataIscrizione.ToShortDateString();
                riga++;
            }

            // 🎓 Voti
            var ws4 = wb.Worksheets.Add("Voti");
            ws4.Cell(1, 1).Value = "Studente";
            ws4.Cell(1, 2).Value = "Corso";
            ws4.Cell(1, 3).Value = "Voto";
            ws4.Cell(1, 4).Value = "Data Esame";

            riga = 2;
            foreach (var v in voti)
            {
                var i = iscrizioni.Find(x => x.IscrizioneId == v.IscrizioneId)!;
                var s = studenti.Find(x => x.StudenteId == i.StudenteId)!;
                var c = corsi.Find(x => x.CorsoId == i.CorsoId)!;

                ws4.Cell(riga, 1).Value = $"{s.Nome} {s.Cognome}";
                ws4.Cell(riga, 2).Value = c.NomeCorso;
                ws4.Cell(riga, 3).Value = v.Valore;
                ws4.Cell(riga, 4).Value = v.DataEsame.ToShortDateString();
                riga++;
            }

            // 📊 Medie
            var ws5 = wb.Worksheets.Add("Medie");
            ws5.Cell(1, 1).Value = "Studente";
            ws5.Cell(1, 2).Value = "Media Voti";

            riga = 2;
            foreach (var s in studenti)
            {
                double media = CalcolaMedia(s.StudenteId, iscrizioni, voti);
                ws5.Cell(riga, 1).Value = $"{s.Nome} {s.Cognome}";
                ws5.Cell(riga, 2).Value = media > 0 ? media.ToString("F2") : "N/A";
                riga++;
            }

            wb.SaveAs(percorsoFile);
        }

        private static double CalcolaMedia(int studenteId, List<Iscrizione> iscrizioni, List<Voto> voti)
        {
            int somma = 0, count = 0;
            foreach (var i in iscrizioni)
            {
                if (i.StudenteId == studenteId)
                {
                    var voto = voti.Find(v => v.IscrizioneId == i.IscrizioneId);
                    if (voto != null)
                    {
                        somma += voto.Valore;
                        count++;
                    }
                }
            }
            return count > 0 ? (double)somma / count : 0;
        }
    }
}
