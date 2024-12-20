using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WerkProfiAPI.Models
{
    public class Chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Inhalt { get; set; }

        [Required]
        public DateTime SendeDatum { get; set; }

        [Required]
        public int KundeId { get; set; }

        [Required]
        public int DienstleisterId { get; set; }

        [ForeignKey("DienstleisterId")]
        public virtual Dienstleister Dienstleister { get; set; }

        [ForeignKey("KundeId")]
        public virtual Kunde Kunde { get; set; }
    }
}