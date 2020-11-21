using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class CastleWar
    {
        public int CastleId { get; set; }
        public int PledgeId { get; set; }
        public byte Type { get; set; }
        public int? ProposeTime { get; set; }
    }
}
