using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserBlocklist
    {
        public int CharId { get; set; }
        public int BlockCharId { get; set; }
        public string BlockCharName { get; set; }
    }
}
