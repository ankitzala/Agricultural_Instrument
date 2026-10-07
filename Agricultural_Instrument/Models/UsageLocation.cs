using System.ComponentModel.DataAnnotations;

namespace Agricultural_Instrument.Models
{
    public class UsageLocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }


        public ICollection<InstrumentUsageLocation> InstrumentUsageLocations { get; set; }
            = new List<InstrumentUsageLocation>();
    }
}