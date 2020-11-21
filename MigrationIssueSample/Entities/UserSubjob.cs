using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserSubjob
    {
        public int? CharId { get; set; }
        public double? Hp { get; set; }
        public double? Mp { get; set; }
        public int? Sp { get; set; }
        public int? Exp { get; set; }
        public byte? Level { get; set; }
        public int? Henna1 { get; set; }
        public int? Henna2 { get; set; }
        public int? Henna3 { get; set; }
        public int? SubjobId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
