using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TempAccount
    {
        public string RealAccount { get; set; }
        public string UserId { get; set; }
    }
}
