using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class StatItemMent
    {
        public int ItemType { get; set; }
        public int ItemId { get; set; }
        public string CharName { get; set; }
        public int MaxEnt { get; set; }
        public byte Builder { get; set; }
    }
}
