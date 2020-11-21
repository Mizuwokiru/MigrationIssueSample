using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SiegeStat
    {
        public int CharId { get; set; }
        public int PledgeId { get; set; }
        public int CastleId { get; set; }
        public int? KillCount { get; set; }
        public int? DeathCount { get; set; }
        public int? DamageTaken { get; set; }
        public int? DamageDealt { get; set; }
    }
}
