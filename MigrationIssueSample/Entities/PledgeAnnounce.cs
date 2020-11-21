using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PledgeAnnounce
    {
        public int PledgeId { get; set; }
        public short ShowFlag { get; set; }
        public string Content { get; set; }
    }
}
