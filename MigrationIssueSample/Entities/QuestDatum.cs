using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class QuestDatum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public DateTime Logdate { get; set; }
    }
}
