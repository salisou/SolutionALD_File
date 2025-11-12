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

