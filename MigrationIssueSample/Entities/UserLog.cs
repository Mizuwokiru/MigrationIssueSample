using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserLog
    {
        public int? CharId { get; set; }
        public byte? LogId { get; set; }
        public DateTime? LogDate { get; set; }
        public int? LogFrom { get; set; }
        public int? LogTo { get; set; }
        public int? UseTime { get; set; }
        public int? SubjobId { get; set; }
    }
}
