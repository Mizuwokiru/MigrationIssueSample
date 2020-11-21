using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class EventItem
    {
        public int? CharId { get; set; }
        public int? ClassId { get; set; }
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
