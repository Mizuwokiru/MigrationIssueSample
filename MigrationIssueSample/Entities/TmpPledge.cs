using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpPledge
    {
        public int PledgeId { get; set; }
        public int RulerId { get; set; }
        public string Name { get; set; }
        public int AllianceId { get; set; }
        public int RootNameValue { get; set; }
        public int NameValue { get; set; }
        public int OustTime { get; set; }
        public short SkillLevel { get; set; }
        public int CastleId { get; set; }
        public int AgitId { get; set; }
        public int Rank { get; set; }
        public int Status { get; set; }
        public int IsGuilty { get; set; }
        public int DismissReservedTime { get; set; }
    }
}
