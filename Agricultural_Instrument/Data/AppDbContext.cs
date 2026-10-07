using Agricultural_Instrument.Models;
using Agricultural_Instrument.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Agricultural_Instrument.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options)
        : DbContext(options)
    {
        // =========================
        // PRIMARY ENTITY TABLES
        // =========================

        public DbSet<AgriculturalInstrument> AgriculturalInstruments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Crop> Crops { get; set; }

        public DbSet<UsageLocation> UsageLocations { get; set; }


        // =========================
        // JUNCTION TABLES
        // =========================

        public DbSet<InstrumentCrop> InstrumentCrops { get; set; }

        public DbSet<InstrumentUsageLocation> InstrumentUsageLocations { get; set; }


        // =========================
        // MEDIA TABLES
        // =========================

        public DbSet<InstrumentImage> InstrumentImages { get; set; }

        public DbSet<InstrumentVideo> InstrumentVideos { get; set; }


        // =========================
        // MODEL CONFIGURATION
        // =========================

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // =========================
            // InstrumentCrop
            // Composite Primary Key
            // =========================

            modelBuilder.Entity<InstrumentCrop>()
                .HasKey(ic => new
                {
                    ic.InstrumentId,
                    ic.CropId
                });


            // =========================
            // InstrumentUsageLocation
            // Composite Primary Key
            // =========================

            modelBuilder.Entity<InstrumentUsageLocation>()
                .HasKey(iul => new
                {
                    iul.InstrumentId,
                    iul.UsageLocationId
                });
        }
    }
}