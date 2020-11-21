using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ShortcutDatum
    {
        public int CharId { get; set; }
        public int Slotnum { get; set; }
        public int ShortcutType { get; set; }
        public int ShortcutId { get; set; }
        public string ShortcutMacro { get; set; }
        public int SubjobId { get; set; }
    }
}
