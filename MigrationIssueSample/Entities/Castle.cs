using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Castle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PledgeId { get; set; }
        public int NextWarTime { get; set; }
        public short TaxRate { get; set; }
        public byte Type { get; set; }
        public byte Status { get; set; }
        public int CropIncome { get; set; }
        public int ShopIncome { get; set; }
        public int SiegeElapsedTime { get; set; }
        public int TaxChildRate { get; set; }
        public int ShopIncomeTemp { get; set; }
        public short TaxRateToChange { get; set; }
        public short TaxChildRateToChange { get; set; }
    }
}
