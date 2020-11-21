using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class StatItemCnt
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }
    }
}
