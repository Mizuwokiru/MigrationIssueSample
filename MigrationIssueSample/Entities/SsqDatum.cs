using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SsqDatum
    {
        public int RoundNumber { get; set; }
        public byte Status { get; set; }
        public byte Winner { get; set; }
        public int EventStartTime { get; set; }
        public int SealEffectTime { get; set; }
        public int EventEndTime { get; set; }
        public int SealEffectEndTime { get; set; }
        public byte Seal1 { get; set; }
        public byte Seal2 { get; set; }
        public byte Seal3 { get; set; }
        public byte Seal4 { get; set; }
        public byte Seal5 { get; set; }
        public byte Seal6 { get; set; }
        public byte Seal7 { get; set; }
        public DateTime LastChangedTime { get; set; }
        public int? CastleSnapshotTime { get; set; }
        public int? CanDropGuard { get; set; }
    }
}
