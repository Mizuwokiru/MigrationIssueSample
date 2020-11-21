using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SsqJoinDatum
    {
        public int RoundNumber { get; set; }
        public byte Type { get; set; }
        public int Point { get; set; }
        public int? MainEventPoint { get; set; }
        public int? CollectedPoint { get; set; }
        public int MemberCount { get; set; }
        public int Seal1SelectionCount { get; set; }
        public int Seal2SelectionCount { get; set; }
        public int Seal3SelectionCount { get; set; }
        public int Seal4SelectionCount { get; set; }
        public int Seal5SelectionCount { get; set; }
        public int Seal6SelectionCount { get; set; }
        public int Seal7SelectionCount { get; set; }
        public DateTime LastChangedTime { get; set; }
    }
}
