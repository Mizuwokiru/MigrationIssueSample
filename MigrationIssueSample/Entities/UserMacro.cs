using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserMacro
    {
        public int MacroId { get; set; }
        public int? CharId { get; set; }
        public string MacroName { get; set; }
        public string MacroTooltip { get; set; }
        public string MacroIconname { get; set; }
        public int? MacroIcontype { get; set; }
    }
}
