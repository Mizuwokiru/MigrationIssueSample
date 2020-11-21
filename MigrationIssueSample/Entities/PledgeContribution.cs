using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PledgeContribution
    {
        public int ResidenceId { get; set; }
        public int PledgeId { get; set; }
        public int Contribution { get; set; }
    }
}
