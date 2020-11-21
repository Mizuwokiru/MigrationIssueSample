using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserHenna
    {
        public int CharId { get; set; }
        public int Henna1 { get; set; }
        public int Henna2 { get; set; }
        public int Henna3 { get; set; }
        public int? SubjobId { get; set; }
    }
}
