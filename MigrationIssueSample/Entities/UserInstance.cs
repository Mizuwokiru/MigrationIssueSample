using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserInstance
    {
        public int CharId { get; set; }
        public int InstanceId { get; set; }
        public int TimeSpent { get; set; }
        public int ReuseTimeout { get; set; }
    }
}
