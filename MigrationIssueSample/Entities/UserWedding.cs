using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserWedding
    {
        public int CharId { get; set; }
        public int State { get; set; }
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int PenaltyTimeout { get; set; }
        public int TeleportTimeout { get; set; }
        public int WeddingTime { get; set; }
    }
}
