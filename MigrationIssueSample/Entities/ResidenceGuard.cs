using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ResidenceGuard
    {
        public int ResidenceId { get; set; }
        public int ItemId { get; set; }
        public int NpcId { get; set; }
        public int GuardType { get; set; }
        public int CanMove { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Angle { get; set; }
    }
}
