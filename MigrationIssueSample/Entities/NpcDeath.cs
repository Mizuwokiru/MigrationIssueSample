using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class NpcDeath
    {
        public int NpcClassId { get; set; }
        public int DeathTime { get; set; }
    }
}
