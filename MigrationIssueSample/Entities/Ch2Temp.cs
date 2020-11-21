using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Ch2Temp
    {
        public int Uid { get; set; }
        public string Account { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? LastWorld { get; set; }
    }
}
