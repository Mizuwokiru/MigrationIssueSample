using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class CharacterLock
    {
        public int CharId { get; set; }
        public string CodeHash { get; set; }
        public string HardwareId { get; set; }
    }
}
