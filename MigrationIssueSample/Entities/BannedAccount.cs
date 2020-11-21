using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class BannedAccount
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public int Timestamp { get; set; }
        public string Reason { get; set; }
    }
}
