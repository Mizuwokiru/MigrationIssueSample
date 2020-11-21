using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ReqCharmoveOld
    {
        public string OldCharName { get; set; }
        public int? OldCharId { get; set; }
        public string AccountName { get; set; }
        public int? AccountId { get; set; }
        public int? OldWorldId { get; set; }
        public DateTime? ReqDate { get; set; }
        public int ReqId { get; set; }
        public int? NewWorldId { get; set; }
        public string NewCharName { get; set; }
        public int? NewCharId { get; set; }
    }
}
