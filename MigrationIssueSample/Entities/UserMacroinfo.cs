using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserMacroinfo
    {
        public int MacroId { get; set; }
        public int? MacroOrder { get; set; }
        public int? MacroInt1 { get; set; }
        public int? MacroInt2 { get; set; }
        public int? MacroInt3 { get; set; }
        public string MacroStr { get; set; }
    }
}
