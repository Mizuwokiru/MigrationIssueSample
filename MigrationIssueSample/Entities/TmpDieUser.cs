using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpDieUser
    {
        public string CharName { get; set; }
        public string AccountName { get; set; }
        public int? BeforeDieExp { get; set; }
        public int? DieMinusExp { get; set; }
        public int? AfterResurrectExp { get; set; }
        public int? ResurrectAddExp { get; set; }
        public int? HasSubjob { get; set; }
    }
}
