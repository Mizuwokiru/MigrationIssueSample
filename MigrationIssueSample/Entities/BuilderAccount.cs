using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class BuilderAccount
    {
        public string AccountName { get; set; }
        public int DefaultBuilder { get; set; }
        public int AccountId { get; set; }
    }
}
