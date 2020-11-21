using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserNameReserved
    {
        public string CharName { get; set; }
        public int AccountId { get; set; }
        public byte Used { get; set; }
    }
}
