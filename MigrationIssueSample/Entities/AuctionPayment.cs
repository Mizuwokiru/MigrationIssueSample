using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class AuctionPayment
    {
        public int JobId { get; set; }
        public int CharId { get; set; }
        public int PriceId { get; set; }
        public int PriceAmount { get; set; }
        public int ItemId { get; set; }
        public int ItemAmount { get; set; }
        public string Buyer { get; set; }
    }
}
