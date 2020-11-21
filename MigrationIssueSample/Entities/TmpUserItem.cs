using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpUserItem
    {
        public int ItemId { get; set; }
        public int CharId { get; set; }
        public int ItemType { get; set; }
        public int Amount { get; set; }
        public int Enchant { get; set; }
        public int Warehouse { get; set; }
    }
}
