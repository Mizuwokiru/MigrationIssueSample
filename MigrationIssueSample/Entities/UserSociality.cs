using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserSociality
    {
        public int CharId { get; set; }
        public int Sociality { get; set; }
        public int UsedSulffrage { get; set; }
        public DateTime LastChanged { get; set; }
    }
}
