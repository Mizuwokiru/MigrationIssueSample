using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserNewbie
    {
        public int AccountId { get; set; }
        public int CharId { get; set; }
        public short NewbieStat { get; set; }
    }
}
