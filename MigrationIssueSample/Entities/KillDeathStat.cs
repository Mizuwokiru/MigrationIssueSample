using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class KillDeathStat
    {
        public int VictimId { get; set; }
        public int VictimClassId { get; set; }
        public int VictimLevel { get; set; }
        public int KillerId { get; set; }
        public int KillerClassId { get; set; }
        public int KillerLevel { get; set; }
        public int KillerHp { get; set; }
        public int KillerMaxHp { get; set; }
        public int KillerCp { get; set; }
        public int KillerMaxCp { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Pvp { get; set; }
        public int SkillId { get; set; }
        public int SkillLevel { get; set; }
        public int DeathTime { get; set; }
    }
}
