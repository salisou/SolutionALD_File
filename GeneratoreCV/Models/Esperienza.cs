namespace GeneratoreCV.Models;

public class Esperienza
{
    public string Azienda { get; set; }
    public string Ruolo { get; set; }
    public string Descrizione { get; set; }
    public DateTime Dal { get; set; }
    public DateTime Al { get; set; }

    // ✅ Costruttore
    public Esperienza(string azienda, string ruolo, string descrizione, DateTime dal, DateTime al)
    {
        Azienda = azienda;
        Ruolo = ruolo;
        Descrizione = descrizione;
        Dal = dal;
        Al = al;
    }

    // ✅ Metodo per formattare la durata del lavoro
    public string Periodo()
    {
        return $"{Dal:MMMM yyyy} - {Al:MMMM yyyy}";
    }
}
