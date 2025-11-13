namespace EsportareDatiExcel.Models
{
    /// <summary>
    /// Questa classe rapresentano i dati gli studenti salvati nel Database
    /// </summary>
    public class Studente()
    {
        //  Proprietà - Parametri / Oggetti
        public int StudenteId { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }
    }
}
