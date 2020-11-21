using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class AgitBid
    {
        public int? AuctionId { get; set; }
        public int AttendId { get; set; }
        public int? AttendPrice { get; set; }
        public int? AttendPledgeId { get; set; }
        public DateTime? AttendDate { get; set; }
        public int? AttendTime { get; set; }
    }
}
