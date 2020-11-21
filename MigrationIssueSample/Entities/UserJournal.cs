using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserJournal
    {
        public int CharId { get; set; }
        public short Type { get; set; }
        public int? IntData1 { get; set; }
        public int? IntData2 { get; set; }
        public DateTime LogData { get; set; }
        public int PlayTime { get; set; }
    }
}
