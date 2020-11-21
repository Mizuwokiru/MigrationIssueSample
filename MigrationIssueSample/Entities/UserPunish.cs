using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserPunish
    {
        public int CharId { get; set; }
        public int PunishId { get; set; }
        public byte PunishOn { get; set; }
        public int? RemainGame { get; set; }
        public int? RemainReal { get; set; }
        public int? PunishSeconds { get; set; }
        public DateTime? PunishDate { get; set; }
    }
}
