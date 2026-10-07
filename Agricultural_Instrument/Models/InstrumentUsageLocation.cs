using Agricultural_Instrument.Models.Enums;

namespace Agricultural_Instrument.Models
{
    public class InstrumentUsageLocation
    {
        public int InstrumentId { get; set; }

        public AgriculturalInstrument Instrument { get; set; }
            = null!;

        public int UsageLocationId { get; set; }

        public UsageLocation UsageLocation { get; set; }
            = null!;
    }
}