using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ReqChar
    {
        public int? ServerId { get; set; }
        public string CharName { get; set; }
    }
}
