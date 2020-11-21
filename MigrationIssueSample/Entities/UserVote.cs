using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserVote
    {
        public int AccountId { get; set; }
        public int VotePoints { get; set; }
        public int VoteTimestamp { get; set; }
    }
}
