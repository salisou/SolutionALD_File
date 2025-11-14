using GeneratoreCV.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GeneratoreCV.Services;

public static class CVService
{
    // 🔹 Metodo principale per generare il CV
    public static void GeneraPDF(Persona persona, List<Esperienza> esperienze, List<Formazione> formazioni, string percorso)
    {
        // ✅ Imposta la licenza gratuita
        QuestPDF.Settings.License = LicenseType.Community;

        // ✅ Crea il documento PDF
        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                // 🔹 Impostazioni della pagina
                page.Size(PageSizes.A4);
                page.Margin(40);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(11));

                // 🔹 Header (nome e titolo)
                page.Header().Text($"{persona.NomeCompleto()} - {persona.Professione}")
                    .Bold().FontSize(24).AlignCenter();

                // 🔹 Corpo del CV
                page.Content().Column(column =>
                {
                    // Sezione dati personali
                    column.Item().PaddingVertical(10).Text($"📧 {persona.Email} | 📞 {persona.Telefono}");
                    column.Item().PaddingVertical(10).Element(Separatore);

                    // Sezione Esperienze
                    column.Item().Text("💼 ESPERIENZE LAVORATIVE").Bold().FontSize(13);
                    foreach (var exp in esperienze)
                    {
                        column.Item().PaddingTop(6).Text($"{exp.Ruolo} - {exp.Azienda} ({exp.Periodo()})").Bold();
                        column.Item().Text(exp.Descrizione);
                    }

                    column.Item().PaddingVertical(10).Element(Separatore);

                    // Sezione Formazione
                    column.Item().Text("🎓 ISTRUZIONE E FORMAZIONE").Bold().FontSize(13);
                    foreach (var f in formazioni)
                    {
                        column.Item().PaddingTop(6).Text($"{f.Titolo} - {f.Istituto} ({f.Anno})");
                    }
                });

                // 🔹 Footer
                page.Footer().AlignCenter().Text("Autorizzo il trattamento dei dati personali ai sensi del Reg. UE 2016/679 (GDPR).").FontSize(9);
            });
        });

        // ✅ Salvataggio del file PDF
        document.GeneratePdf(percorso);
        Console.WriteLine($"✅ CV generato correttamente in: {Path.GetFullPath(percorso)}");
    }

    // 🔸 Metodo di supporto per disegnare una linea orizzontale
    private static void Separatore(IContainer container)
    {
        container.PaddingVertical(5).Height(1).Background(Colors.Grey.Lighten2);
    }
}
