using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class LottoItem
    {
        public int RoundNumber { get; set; }
        public int ItemId { get; set; }
        public int NumberFlag { get; set; }
    }
}
