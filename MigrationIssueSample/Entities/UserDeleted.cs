using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserDeleted
    {
        public int CharId { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
