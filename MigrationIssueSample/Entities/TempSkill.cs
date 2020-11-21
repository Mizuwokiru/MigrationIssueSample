using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TempSkill
    {
        public int? CharId { get; set; }
        public int? Skill { get; set; }
        public int? Lev { get; set; }
        public int? Temptime { get; set; }
    }
}
