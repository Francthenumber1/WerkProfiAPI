using System;

namespace WerkProfiAPI.Models
{
    public class Buchung
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Buchung_Datum { get; set; }
        public int Kunde_id { get; set; }
        public int Dienstleistung_id { get; set; }
        public string Anschrift { get; set; }
    }}
        