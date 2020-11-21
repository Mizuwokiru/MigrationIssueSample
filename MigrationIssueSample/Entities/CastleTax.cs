using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class CastleTax
    {
        public int IncomeUpdateT { get; set; }
        public int TaxChangeT { get; set; }
        public int ManorResetT { get; set; }
    }
}
