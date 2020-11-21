using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpAlliance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MasterPledgeId { get; set; }
        public int OustTime { get; set; }
    }
}
