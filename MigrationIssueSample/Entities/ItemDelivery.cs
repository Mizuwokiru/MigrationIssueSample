using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ItemDelivery
    {
        public int JobId { get; set; }
        public int CharId { get; set; }
        public int ItemId { get; set; }
        public int ItemAmount { get; set; }
        public int Enchant { get; set; }
    }
}
