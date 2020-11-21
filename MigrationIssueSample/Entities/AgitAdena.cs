using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class AgitAdena
    {
        public int? AgitId { get; set; }
        public int? PledgeId { get; set; }
        public int? AuctionId { get; set; }
        public int? Reason { get; set; }
        public int? Adena { get; set; }
        public int LogId { get; set; }
    }
}
