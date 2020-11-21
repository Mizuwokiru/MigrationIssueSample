using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class MonraceMon
    {
        public int? RunnerId { get; set; }
        public short? InitialWin { get; set; }
        public int? RunCount { get; set; }
        public int? WinCount { get; set; }
    }
}
