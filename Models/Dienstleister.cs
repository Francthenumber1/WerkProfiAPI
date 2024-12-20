using System.ComponentModel.DataAnnotations;

namespace WerkProfiAPI.Models
{
    public class Dienstleister
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Email_Adreße { get; set; }
        [Required] public string Passwort { get; set; }
        [Required] public long Telefon_Nummer { get; set; }
        [Required] public string Anschrift { get; set; }
        public DateTime Registrierung_Datum { get; set; }
        public string Biographie { get; set; }
        public string Fachgebiete { get; set; }
        public string Verfügbarkeit { get; set; }
    }
}
