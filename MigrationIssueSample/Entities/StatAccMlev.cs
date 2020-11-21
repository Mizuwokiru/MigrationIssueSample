using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class StatAccMlev
    {
        public string AccountName { get; set; }
        public string CharName { get; set; }
        public byte Lev { get; set; }
        public byte Race { get; set; }
        public byte Class { get; set; }
    }
}
