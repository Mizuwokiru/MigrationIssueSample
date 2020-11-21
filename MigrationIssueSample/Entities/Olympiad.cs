using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Olympiad
    {
        public int Season { get; set; }
        public int? Step { get; set; }
        public int? SeasonStartTime { get; set; }
        public int? StartSec { get; set; }
        public int? Bonus1Sec { get; set; }
        public int? Bonus2Sec { get; set; }
        public int? Bonus3Sec { get; set; }
        public int? Bonus4Sec { get; set; }
        public int? NominateSec { get; set; }
    }
}
