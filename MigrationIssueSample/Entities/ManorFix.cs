using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ManorFix
    {
        public int CharId { get; set; }
        public int ItemType { get; set; }
        public int Amount { get; set; }
        public int Warehouse { get; set; }
        public int? ErrorAmount { get; set; }
        public int? ToDec { get; set; }
    }
}
