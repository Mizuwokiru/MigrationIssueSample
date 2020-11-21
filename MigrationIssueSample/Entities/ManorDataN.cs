using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ManorDataN
    {
        public int ManorId { get; set; }
        public int DataIndex { get; set; }
        public int SeedIdN { get; set; }
        public int SeedPriceN { get; set; }
        public int SeedSellCountN { get; set; }
        public int CropIdN { get; set; }
        public int CropBuyCountN { get; set; }
        public int CropPriceN { get; set; }
        public int CropTypeN { get; set; }
    }
}
