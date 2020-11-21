using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class LottoGameBackup20050302
    {
        public int RoundNumber { get; set; }
        public int State { get; set; }
        public int LeftTime { get; set; }
        public int ChosenNumberFlag { get; set; }
        public int RuleNumber { get; set; }
        public int Winner1Count { get; set; }
        public int Winner2Count { get; set; }
        public int Winner3Count { get; set; }
        public int Winner4Count { get; set; }
        public int TotalCount { get; set; }
        public int CarriedAdena { get; set; }
    }
}
