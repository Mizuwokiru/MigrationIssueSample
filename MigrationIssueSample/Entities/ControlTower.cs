using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ControlTower
    {
        public string Name { get; set; }
        public int ResidenceId { get; set; }
        public int? ControlLevel { get; set; }
        public int Hp { get; set; }
        public int Status { get; set; }
    }
}
