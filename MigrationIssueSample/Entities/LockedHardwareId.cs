using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class LockedHardwareId
    {
        public int CharId { get; set; }
        public int AccountId { get; set; }
        public string HardwareId { get; set; }
        public string LockedBy { get; set; }
    }
}
