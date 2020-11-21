using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TimeDatum
    {
        public int AccountId { get; set; }
        public DateTime LastLogout { get; set; }
        public int UsedSec { get; set; }
    }
}
