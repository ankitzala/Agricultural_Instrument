using Agricultural_Instrument.Models;
using Agricultural_Instrument.Models.Enums;

namespace Agricultural_Instrument.Models
{
    public class InstrumentCrop
    {
        public int InstrumentId { get; set; }

        public AgriculturalInstrument Instrument { get; set; }
            = null!;


        public int CropId { get; set; }

        public Crop Crop { get; set; }
            = null!;
    }
}