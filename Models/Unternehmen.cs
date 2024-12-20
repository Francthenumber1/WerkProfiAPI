using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WerkProfiAPI.Models
{
    public class Unternehmen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Beschreibung { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string EmailAdresse { get; set; }

        [Required]
        public long TelefonNummer { get; set; }

        [Required]
        [ForeignKey("Dienstleistung")]
        public int DienstleistungId { get; set; }

        public virtual Dienstleistung Dienstleistung { get; set; }
    }
}