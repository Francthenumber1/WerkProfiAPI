using System;

namespace WerkProfiAPI.Models
{
    public class Kunde
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAdresse { get; set; }
        public string Passwort { get; set; }
        public long TelefonNummer { get; set; }
        public string Anschrift { get; set; }
        public DateTime RegistrierungDatum { get; set; }
        public int DienstleistungId { get; set; }
    }
}