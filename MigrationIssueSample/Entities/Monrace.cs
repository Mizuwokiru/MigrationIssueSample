using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Monrace
    {
        public int RaceId { get; set; }
        public DateTime? MakeDate { get; set; }
        public short? Lane1 { get; set; }
        public short? Lane2 { get; set; }
        public short? Lane3 { get; set; }
        public short? Lane4 { get; set; }
        public short? Lane5 { get; set; }
        public short? Lane6 { get; set; }
        public short? Lane7 { get; set; }
        public short? Lane8 { get; set; }
        public double? Run1 { get; set; }
        public double? Run2 { get; set; }
        public double? Run3 { get; set; }
        public double? Run4 { get; set; }
        public double? Run5 { get; set; }
        public double? Run6 { get; set; }
        public double? Run7 { get; set; }
        public double? Run8 { get; set; }
        public short? Win1 { get; set; }
        public short? Win2 { get; set; }
        public double? Winrate1 { get; set; }
        public double? Winrate2 { get; set; }
        public short? RaceEnd { get; set; }
        public int? TaxRate { get; set; }
    }
}
