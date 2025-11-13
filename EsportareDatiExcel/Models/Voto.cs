namespace EsportaDatiExcel.Models
{
    public class Voto
    {
        public int VotoId { get; set; }
        public int IscrizioneId { get; set; }
        public int Valore { get; set; }
        public DateTime DataEsame { get; set; }
    }
}
