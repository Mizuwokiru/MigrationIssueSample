using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class CastleCrop
    {
        public int CastleId { get; set; }
        public int ItemType { get; set; }
        public int DropRate { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
    }
}
