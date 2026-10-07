using Agricultural_Instrument.Models;
using Agricultural_Instrument.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Agricultural_Instrument.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Url]
        public string? Website { get; set; }

        [Url]
        public string? LogoUrl { get; set; }

        public bool IsActive { get; set; } = true;


        // One Manufacturer → Many Instruments

        public ICollection<AgriculturalInstrument> Instruments { get; set; }
            = new List<AgriculturalInstrument>();
    }
}