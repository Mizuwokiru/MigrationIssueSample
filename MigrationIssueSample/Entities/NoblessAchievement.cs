using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class NoblessAchievement
    {
        public int? CharId { get; set; }
        public int? WinType { get; set; }
        public int? Target { get; set; }
        public int? WinTime { get; set; }
    }
}
