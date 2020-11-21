using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserBan
    {
        public int CharId { get; set; }
        public int? Status { get; set; }
        public DateTime? BanDate { get; set; }
        public short? BanHour { get; set; }
        public int? BanEnd { get; set; }
    }
}
