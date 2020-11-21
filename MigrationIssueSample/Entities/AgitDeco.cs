using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class AgitDeco
    {
        public int AgitId { get; set; }
        public int Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public int? Expire { get; set; }
    }
}
