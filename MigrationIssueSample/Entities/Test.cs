using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Test
    {
        public int _ { get; set; }
        public int? CharId { get; set; }
        public string CharName { get; set; }
        public string AccountName { get; set; }
        public byte? Lev { get; set; }
        public int? Class { get; set; }
    }
}
