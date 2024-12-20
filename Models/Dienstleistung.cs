using WerkProfiAPI.Models;

public class Dienstleistung
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Typ { get; set; }
    public string Beschreibung { get; set; }
    public string Standort { get; set; }
    public decimal Preise { get; set; }

    // Foreign Key
    public int DienstleisterId { get; set; }
    public Dienstleister Dienstleister { get; set; }
}
