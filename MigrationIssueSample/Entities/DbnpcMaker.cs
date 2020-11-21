using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class DbnpcMaker
    {
        public int Id { get; set; }
        public int NpcId { get; set; }
        public int SpawnX { get; set; }
        public int SpawnY { get; set; }
        public int SpawnZ { get; set; }
        public int Heading { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Comment { get; set; }
    }
}
