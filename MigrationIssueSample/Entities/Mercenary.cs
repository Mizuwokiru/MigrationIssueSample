using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Mercenary
    {
        public int Id { get; set; }
        public int ResidenceId { get; set; }
        public int NpcId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Angle { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
    }
}
