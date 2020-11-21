using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Auction
    {
        public int AuctionId { get; set; }
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public int Enchant { get; set; }
        public int Augmentation { get; set; }
        public int Price { get; set; }
        public int ExpireTime { get; set; }
    }
}
