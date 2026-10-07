using System.ComponentModel.DataAnnotations;

namespace Agricultural_Instrument.Models
{
    public class Crop
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


        // Many Crops → Many Instruments

        public ICollection<InstrumentCrop> InstrumentCrops { get; set; }
            = new List<InstrumentCrop>();
    }
}