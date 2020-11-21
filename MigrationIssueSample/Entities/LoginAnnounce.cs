using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class LoginAnnounce
    {
        public int AnnounceId { get; set; }
        public string AnnounceMsg { get; set; }
        public int Interval10 { get; set; }
    }
}
