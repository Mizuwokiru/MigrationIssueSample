using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class L2networkVote
    {
        public string Identity { get; set; }
        public int LastVoteTime { get; set; }
        public int LastRewardTime { get; set; }
    }
}
