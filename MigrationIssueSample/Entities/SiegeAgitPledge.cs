using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SiegeAgitPledge
    {
        public int AgitId { get; set; }
        public int PledgeId { get; set; }
        public int ProposeTime { get; set; }
        public int? Status { get; set; }
    }
}
