using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class WarDeclare
    {
        public int Challenger { get; set; }
        public int Challengee { get; set; }
        public int DeclareTime { get; set; }
    }
}
