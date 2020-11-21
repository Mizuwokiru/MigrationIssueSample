using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Ch3LottoChar
    {
        public int CharId { get; set; }
        public int? ItemCount { get; set; }
        public int? RoundNumber { get; set; }
        public int? ItemId { get; set; }
        public int? NumberFlag { get; set; }
    }
}
