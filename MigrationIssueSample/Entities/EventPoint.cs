using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class EventPoint
    {
        public int PointId { get; set; }
        public int? GroupId { get; set; }
        public double? GroupPoint { get; set; }
    }
}
