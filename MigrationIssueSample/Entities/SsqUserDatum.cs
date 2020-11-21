using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SsqUserDatum
    {
        public int CharId { get; set; }
        public int RoundNumber { get; set; }
        public byte SsqPart { get; set; }
        public byte SsqPosition { get; set; }
        public byte SealSelectionNo { get; set; }
        public int SsqJoinTime { get; set; }
        public int SsqPoint { get; set; }
        public int TwilightAItemNum { get; set; }
        public int TwilightBItemNum { get; set; }
        public int TwilightCItemNum { get; set; }
        public int DawnAItemNum { get; set; }
        public int DawnBItemNum { get; set; }
        public int DawnCItemNum { get; set; }
        public byte TicketBuyCount { get; set; }
    }
}
