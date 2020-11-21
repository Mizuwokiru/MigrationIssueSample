using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpUserNobless
    {
        public int CharId { get; set; }
        public byte? NoblessType { get; set; }
        public byte? HeroType { get; set; }
        public int? WinCount { get; set; }
        public int? PreviousPoint { get; set; }
        public int? OlympiadPoint { get; set; }
        public int? MatchCount { get; set; }
        public string Words { get; set; }
    }
}
