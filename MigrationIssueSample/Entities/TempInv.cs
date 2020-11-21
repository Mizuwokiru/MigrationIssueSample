using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TempInv
    {
        public int ItemId { get; set; }
        public int ItemType { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
    }
}
