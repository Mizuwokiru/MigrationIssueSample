using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class OlympiadMatch
    {
        public int? Season { get; set; }
        public int? Class { get; set; }
        public int? MatchTime { get; set; }
        public int? CharId { get; set; }
        public int? RivalId { get; set; }
        public int? Point { get; set; }
        public byte? IsWinner { get; set; }
    }
}
