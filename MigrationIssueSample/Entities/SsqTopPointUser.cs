using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SsqTopPointUser
    {
        public int SsqRound { get; set; }
        public int RecordId { get; set; }
        public int RankTime { get; set; }
        public int SsqPoint { get; set; }
        public int CharId { get; set; }
        public string CharName { get; set; }
        public byte SsqPart { get; set; }
        public byte SsqPosition { get; set; }
        public byte SealSelectionNo { get; set; }
        public DateTime? LastChangedTime { get; set; }
    }
}
