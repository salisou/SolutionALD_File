using GeneratoreCV.Models;
using GeneratoreCV.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("🧾 Generatore di Curriculum Vitae\n");

        // 1. Creiamo la persona
        Persona persona = new(
            nome: "Marco",
            cognome: "Cogoni",
            email: "marco.cogoni@example.com",
            telefono: "3204567890",
            professione: "Full Stack Developer"
        );

        // 2. Esperienze lavorative
        List<Esperienza> esperienze =
        [
            new("GESCAD", "Full Stack Developer",
                "Sviluppo applicazioni .NET, gestione database SQL Server e porting di applicazioni Windows su Android.",
                new DateTime(2022,4,1), new DateTime(2022,10,1)),

            new("DotEnv SRL", "Backend Developer",
                "Lavoro con PHP, Laravel, API Platform, Docker e sviluppo API REST ad alte prestazioni.",
                new DateTime(2021,9,1), new DateTime(2022,2,1)),

            new("ACME Tech", "Software Engineer",
                "Progettazione di sistemi enterprise, microservizi e integrazioni cloud Azure.",
                new DateTime(2020,1,1), new DateTime(2021,8,1)),

            new("FutureLab", "Junior Developer",
                "Sviluppo web con C#, HTML, CSS, JavaScript e basi di React.",
                new DateTime(2019,2,1), new DateTime(2019,12,1))
        ];

        // 3. Formazione
        List<Formazione> formazioni =
        [
            new("Laurea Triennale in Informatica", "Università di Cagliari", 2018),
            new("Master in Web Development", "Talentform Academy", 2020),
            new("Certificazione Docker & Kubernetes", "Udemy", 2022),
            new("Corso Avanzato C# e .NET", "Microsoft Learn", 2023),
            new("Corso Inglese Intermedio B2", "MyES Cagliari", 2024)
        ];

        // 4. Percorso del file
        string percorso = Path.Combine(
            Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.FullName,
            "Curriculum_MarcoCogoni.pdf");

        // 5. Generazione PDF
        CVService.GeneraPDF(persona, esperienze, formazioni, percorso);

        Console.WriteLine($"\n📁 Curriculum generato: {percorso}");
    }
}
