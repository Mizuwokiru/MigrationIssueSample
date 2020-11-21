using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ItemMarketPrice
    {
        public int ItemType { get; set; }
        public int Enchant { get; set; }
        public double AvgPrice { get; set; }
        public int Frequency { get; set; }
    }
}
