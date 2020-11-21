using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class BannedHardwareId
    {
        public string HardwareId { get; set; }
        public string Account { get; set; }
        public string Gm { get; set; }
        public int Timeout { get; set; }
    }
}
