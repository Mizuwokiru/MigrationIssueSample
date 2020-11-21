using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserPin
    {
        public int CharId { get; set; }
        public int Pin { get; set; }
        public int Timestamp { get; set; }
    }
}
