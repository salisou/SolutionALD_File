namespace GeneratoreCV.Models;

public class Persona
{
    // Proprietà della persona
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Professione { get; set; }

    // Costruttore (inizializza l'oggetto Persona)
    public Persona(string nome, string cognome, string email, string telefono, string professione)
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Telefono = telefono;
        Professione = professione;
    }

    // Metodo per ottenere il nome completo
    public string NomeCompleto() => $"{Nome} {Cognome}";
}
