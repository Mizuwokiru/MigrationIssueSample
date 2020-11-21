using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class OlympiadResult
    {
        public int Season { get; set; }
        public int Class { get; set; }
        public int CharId { get; set; }
        public int Point { get; set; }
        public int MatchCount { get; set; }
    }
}
