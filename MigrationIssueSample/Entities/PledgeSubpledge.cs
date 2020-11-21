using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PledgeSubpledge
    {
        public int PledgeId { get; set; }
        public int PledgeType { get; set; }
        public string SubName { get; set; }
        public string LeaderName { get; set; }
        public int LeaderDbid { get; set; }
    }
}
