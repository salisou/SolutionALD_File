namespace GeneratoreCV.Models;

public class Formazione
{
    public string Titolo { get; set; }
    public string Istituto { get; set; }
    public int Anno { get; set; }

    // ✅ Costruttore
    public Formazione(string titolo, string istituto, int anno)
    {
        Titolo = titolo;
        Istituto = istituto;
        Anno = anno;
    }
}
