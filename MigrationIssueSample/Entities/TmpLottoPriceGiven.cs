using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpLottoPriceGiven
    {
        public int? CharId { get; set; }
        public string CharName { get; set; }
        public int? Rank { get; set; }
        public int? Price { get; set; }
        public int? NewPrice { get; set; }
    }
}
