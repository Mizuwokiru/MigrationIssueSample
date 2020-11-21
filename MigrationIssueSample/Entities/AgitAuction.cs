using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class AgitAuction
    {
        public int? AgitId { get; set; }
        public int AuctionId { get; set; }
        public string AuctionDesc { get; set; }
        public int? MinPrice { get; set; }
        public int? AcceptedBid { get; set; }
        public int? AuctionTime { get; set; }
        public int? AuctionTax { get; set; }
    }
}
