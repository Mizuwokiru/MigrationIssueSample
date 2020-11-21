using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TimeAttackRecord
    {
        public int SsqRound { get; set; }
        public byte RoomNo { get; set; }
        public byte RecordType { get; set; }
        public byte SsqPart { get; set; }
        public int Point { get; set; }
        public int RecordTime { get; set; }
        public int ElapsedTime { get; set; }
        public int MemberCount { get; set; }
        public string MemberNames { get; set; }
        public string MemberDbidList { get; set; }
        public int? MemberRewardFlags { get; set; }
        public int? Fee { get; set; }
    }
}
