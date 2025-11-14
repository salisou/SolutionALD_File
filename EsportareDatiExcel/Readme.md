
# Struttura del progetto (cartelle pulite)

    📂 EsportaDatiExcel
    │
    ├── 📁 Models      → Contiene solo i dati (classi semplici)
    │     ├── Studente.cs
    │     ├── Corso.cs
    │     ├── Iscrizione.cs
    │     └── Voto.cs
    │
    ├── 📁 Services    → Contiene la logica (azioni e metodi)
    │     ├── DatiMock.cs   → Crea dati di prova
    │     └── ReportExcel.cs → Genera il file Excel
    │
    └── Program.cs     → Avvia il programma e usa i services


# Spiegazione dettagliata

    | Parte                                  | Descrizione                                                     |
    | -------------------------------------- | --------------------------------------------------------------- |
    | `using ClosedXML.Excel;`               | Importa la libreria per gestire i file Excel.                   |
    | `var workbook = new XLWorkbook();`     | Crea un nuovo file Excel in memoria.                            |
    | `workbook.Worksheets.Add("Studenti");` | Aggiunge un nuovo foglio con nome "Studenti".                   |
    | `ws.Cell(riga, colonna).Value = ...`   | Scrive il valore nella cella specificata.                       |
    | `workbook.SaveAs(percorsoFile);`       | Salva fisicamente il file `.xlsx`.                              |
    | `Trova()`                              | Cerca un record in una lista in base a una chiave e un valore.  |
    | `CalcolaMedia()`                       | Scorre iscrizioni e voti per calcolare la media dello studente. |
        

## Risultato finale
Il file ReportUniversita.xlsx conterrà 5 fogli:

    | Foglio         | Contenuto                        |
    | -------------- | -------------------------------- |
    | **Studenti**   | ID, Nome, Cognome, Email         |
    | **Corsi**      | ID, NomeCorso, Crediti           |
    | **Iscrizioni** | Studente ↔ Corso con data        |
    | **Voti**       | Studente, Corso, Voto, DataEsame |
    | **Medie**      | Media calcolata per studente     |


## COSA SONO I SERVICES

   In poche parole:
    👉 Un Service è una classe (o un insieme di classi) che contiene la logica operativa del programma.
    Non rappresenta un “oggetto” come uno Studente o un Corso, ma un comportamento.

    | Ruolo           | Esempio nel codice          | Cosa fa                                         |
    | --------------- | --------------------------- | ----------------------------------------------- |
    | 👩‍🏫 *Model*      | `Studente`, `Corso`, `Voto` | Sono le *entità* del sistema (i “dati”).        |
    | 🧑‍🔧 *Service*    | `ReportExcel`, `DatiMock`   | Sono i *lavoratori* che agiscono sui dati.      |
    | 🧑‍💻 *Program*    | `Program.cs`                | È il *coordinatore*: decide chi deve fare cosa. |

## ⚙️ Cos’è la logica di un programma?

### La logica è tutto ciò che fa qualcosa con i dati, ad esempio:

-- Salvare su file
-- Leggere da database
-- Calcolare medie, totali, statistiche
-- Generare un PDF o un Excel
-- Inviare email o notifiche
## 👉 Tutte queste operazioni vanno nei Services, non nei Models.


## Perché servono i Services?

    | Motivo                   | Vantaggio                                                |
    | ------------------------ | -------------------------------------------------------- |
    | 🔹 Separazione dei ruoli | Il codice è più ordinato e facile da leggere             |
    | 🔹 Riutilizzabilità      | Puoi usare `ReportExcel` anche in un altro progetto      |
    | 🔹 Facilità di test      | Puoi testare un singolo `Service` senza far girare tutto |
    | 🔹 Manutenzione          | Se devi cambiare un pezzo, lo trovi subito               |
    | 🔹 Scalabilità           | Aggiungere nuove funzionalità è più facile               |

## In breve

    | Tipo        | Contiene                               | Esempio                      |
    | ----------- | -------------------------------------- | ---------------------------- |
    | **Model**   | Dati (proprietà)                       | `Studente`, `Corso`          |
    | **Service** | Logica (metodi, calcoli, esportazioni) | `ReportExcel`, `DatiMock`    |
    | **Program** | Controllo del flusso                   | Chiama i metodi dei Services |
