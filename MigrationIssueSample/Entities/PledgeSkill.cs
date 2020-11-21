using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PledgeSkill
    {
        public int PledgeId { get; set; }
        public int SkillId { get; set; }
        public int SkillLevel { get; set; }
    }
}
