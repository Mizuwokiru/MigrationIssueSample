using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserSkill
    {
        public int CharId { get; set; }
        public int SkillId { get; set; }
        public byte SkillLev { get; set; }
        public int ToEndTime { get; set; }
        public int SubjobId { get; set; }
    }
}
