## Nome del progetto (GeneratoreCV)
📂 GeneratoreCV
│
├── 📁 Models
│     ├── Esperienza.cs         
│     │       • Proprietà: 
│     │            - string Azienda
│     │            - string Ruolo
│     │            - string Descrizione
│     │            - DateTime Dal
│     │            - DateTime Al
│     │       
│     │       • Costruttore:
│     │            Il costruttore deve assegnare alle proprietà i valori ricevuti come parametri.
|     |                  .....Periodo() => $"{Dal:MMMM yyyy} - {AL:MMMM yyyy}"; 
│     │       
│     │       • Metodo:
│     │            Periodo() → restituisce la durata del lavoro formattata
│     │            (Esempio: "Gennaio 2022 - Dicembre 2023")
│     │
│     ├── Formazione.cs
│     │       • Proprietà:
│     │            - string Titolo
│     │            - string Istituto
│     │            - int Anno
│     │
│     │       • Costruttore:
│     │            Deve inizializzare le proprietà con i valori ricevuti.
│     │
│     ├── Persona.cs
│     │       • Proprietà:
│     │            - string Nome
│     │            - string Cognome
│     │            - string Email
│     │            - string Telefono
│     │            - string Professione
│     │
│     │       • Costruttore:
│     │            Inizializza tutte le proprietà con i valori passati come parametri.
│     │
│     │       • Metodo:
│     │            NomeCompleto()
│     │            → restituisce "Nome Cognome"
│     │
│
├── 📁 Services
│     ├── CVService.cs
│     │
│     │       • Metodo principale: GeneraPDF(...)
│     │
│     │       Dentro il metodo:
│     │             1️⃣ Imposta la licenza gratuita:
│     │                 QuestPDF.Settings.License = LicenseType.Community;
│     │
│     │             2️⃣ Crea il documento PDF:
│     │                 Document.Create(container => {...})
│     │
│     │             3️⃣ Aggiunge una pagina:
│     │                 container.Page(page => {...})
│     │
│     │             4️⃣ Impostazioni della pagina:
│     │                 - Dimensione A4
│     │                 - Margini
│     │                 - Colore di sfondo
│     │                 - Stile del testo
│     │
│     │             5️⃣ Header:
│     │                 Mostra Nome Completo + Professione
│     │
│     │             6️⃣ Corpo del CV:
│     │                 - Sezione dati personali
│     │                 - Sezione Esperienze lavorative (foreach)
│     │                 - Sezione Formazione (foreach)
│     │
│     │             7️⃣ Footer:
│     │                 Testo legale GDPR
│     │
│     │             8️⃣ Salvataggio del file PDF:
│     │                 document.GeneratePdf(percorso);
│
│
└── Program.cs
        • Avvia il programma
        • Crea l'oggetto Persona
        • Crea la lista delle Esperienze
        • Crea la lista della Formazione
        • Calcola il percorso del file
        • Chiama CVService.GeneraPDF(...)
        • Stampa conferma



# 📄 Genereatore del Curriculum Vitae (VC) in PDF Con Console App

## 📃 Descrizione del Progetto

<p style="text-center">Questo progetto è una <strong>APPLICAZIONE CONSOLE IN C#</strong> che genera automaticamente un **Curriculum Vitae in formato PDF** utilizzando la libreria **QuestPDF**.  
L’utente definisce una persona, le sue esperienze lavorative e la formazione; il sistema genera un documento PDF ben formattato con tutte queste informazioni.
</p>


È un progetto ideale per studenti che stanno imparando:
- Programmazione ad oggetti (OOP)
- Costruttori e metodi
- Overloading
- Organizzazione del codice (Models, Services, Program)
- Gestione file e generazione di documenti PDF