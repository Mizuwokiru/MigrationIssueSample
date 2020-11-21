using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class SkillDatum
    {
        public int Id { get; set; }
        public short Lev { get; set; }
        public string Name { get; set; }
        public DateTime Logdate { get; set; }
        public string SkillDesc { get; set; }
        public byte? BIsMagic { get; set; }
        public string ActivateType { get; set; }
    }
}
