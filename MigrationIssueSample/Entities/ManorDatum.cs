using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ManorDatum
    {
        public int ManorId { get; set; }
        public int DataIndex { get; set; }
        public int SeedId { get; set; }
        public int SeedPrice { get; set; }
        public int SeedSellCount { get; set; }
        public int SeedRemainCount { get; set; }
        public int CropId { get; set; }
        public int CropBuyCount { get; set; }
        public int CropPrice { get; set; }
        public int CropType { get; set; }
        public int CropRemainCount { get; set; }
        public int CropDeposit { get; set; }
    }
}
