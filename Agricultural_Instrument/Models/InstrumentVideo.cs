using Agricultural_Instrument.Models;
using Agricultural_Instrument.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Agricultural_Instrument.Models
{
    public class InstrumentVideo
    {
        [Key]
        public int Id { get; set; }

        public int InstrumentId { get; set; }

        public AgriculturalInstrument Instrument { get; set; }
            = null!;


        [Required]
        [Url]
        public string VideoUrl { get; set; } = string.Empty;

        [StringLength(150)]
        public string? Title { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public int DisplayOrder { get; set; }
    }
}