using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserHistory
    {
        public string CharName { get; set; }
        public int CharId { get; set; }
        public DateTime LogDate { get; set; }
        public byte LogAction { get; set; }
        public string AccountName { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
