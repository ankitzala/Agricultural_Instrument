using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agricultural_Instrument.Models.Enums
{
    public class AgriculturalInstrument
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Subtitle { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;


        // =========================
        // CATEGORY
        // =========================

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }


        // =========================
        // BASIC INFORMATION
        // =========================

        [Required]
        public string Purpose { get; set; } = string.Empty;

        public string? WorkingPrinciple { get; set; }


        // =========================
        // POWER INFORMATION
        // =========================

        [Required]
        public PowerSource PowerSource { get; set; }

        [StringLength(100)]
        public string? PowerRequirement { get; set; }


        // =========================
        // CAPACITY & DIMENSIONS
        // =========================

        [StringLength(100)]
        public string? Capacity { get; set; }

        [StringLength(100)]
        public string? Size { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Weight { get; set; }


        // =========================
        // PRICE
        // =========================

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }


        // =========================
        // MANUFACTURER
        // =========================

        public int? ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer? Manufacturer { get; set; }

        [StringLength(100)]
        public string? ModelNumber { get; set; }


        // =========================
        // MEDIA
        // =========================

        [Url]
        public string? ImageUrl { get; set; }

        [Url]
        public string? VideoUrl { get; set; }


        // =========================
        // INSTRUCTIONS
        // =========================

        public string? UsageInstructions { get; set; }

        public string? SafetyInstructions { get; set; }

        public string? Maintenance { get; set; }


        // =========================
        // ADVANTAGES / DISADVANTAGES
        // =========================

        public string? Advantages { get; set; }

        public string? Disadvantages { get; set; }


        // =========================
        // STATUS
        // =========================

        public bool IsActive { get; set; } = true;


        // =========================
        // AUDIT
        // =========================

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }


        // =========================
        // MANY-TO-MANY RELATIONSHIPS
        // =========================

        public ICollection<InstrumentCrop> InstrumentCrops { get; set; }
            = new List<InstrumentCrop>();

        public ICollection<InstrumentUsageLocation> UsageLocations { get; set; }
            = new List<InstrumentUsageLocation>();

        public ICollection<InstrumentImage> Images { get; set; }
            = new List<InstrumentImage>();

        public ICollection<InstrumentVideo> Videos { get; set; }
            = new List<InstrumentVideo>();
    }
}