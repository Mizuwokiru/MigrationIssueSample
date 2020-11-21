using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TeamBattleAgitPledge
    {
        public int AgitId { get; set; }
        public int PledgeId { get; set; }
        public int ProposeTime { get; set; }
        public int Color { get; set; }
        public int NpcType { get; set; }
    }
}
