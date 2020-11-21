using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class StatItemEnt
    {
        public int ItemType { get; set; }
        public int Enchant { get; set; }
        public int Count { get; set; }
        public int Sum { get; set; }
    }
}
