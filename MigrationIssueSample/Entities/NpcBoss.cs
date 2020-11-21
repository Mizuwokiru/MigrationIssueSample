using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class NpcBoss
    {
        public string NpcDbName { get; set; }
        public int Alive { get; set; }
        public int? Hp { get; set; }
        public int? Mp { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }
        public int? PosZ { get; set; }
        public int? TimeLow { get; set; }
        public int? TimeHigh { get; set; }
        public int I0 { get; set; }
    }
}
