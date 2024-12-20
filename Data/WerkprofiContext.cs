using Microsoft.EntityFrameworkCore;
using WerkProfiAPI.Models;

namespace WerkProfiAPI
{
    public class WerkProfiContext : DbContext
    {
        public WerkProfiContext(DbContextOptions<WerkProfiContext> options) : base(options) { }

        public DbSet<Dienstleister> Dienstleister { get; set; }
        public DbSet<Dienstleistung> Dienstleistung { get; set; }
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Buchung> Buchung { get; set; }
        public DbSet<Bewertung> Bewertung { get; set; }
        public DbSet<Chat> Chat { get; set; }
    }
}
