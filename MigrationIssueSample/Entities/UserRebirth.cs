using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserRebirth
    {
        public int CharId { get; set; }
        public int SubjobId { get; set; }
        public int RebirthCount { get; set; }
        public int AvailablePoints { get; set; }
        public int BonusInt { get; set; }
        public int BonusStr { get; set; }
        public int BonusCon { get; set; }
        public int BonusMen { get; set; }
        public int BonusDex { get; set; }
        public int BonusWit { get; set; }
    }
}
