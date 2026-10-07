using Agricultural_Instrument.Models;
using Agricultural_Instrument.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Agricultural_Instrument.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; } = true;


        // One Category → Many Instruments

        public ICollection<AgriculturalInstrument> Instruments { get; set; }
            = new List<AgriculturalInstrument>();
    }
}