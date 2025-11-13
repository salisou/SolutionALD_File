namespace EsportaDatiExcel.Models
{
    public class Iscrizione
    {
        public int IscrizioneId { get; set; }
        public int StudenteId { get; set; }
        public int CorsoId { get; set; }
        public DateTime DataIscrizione { get; set; }
    }
}
