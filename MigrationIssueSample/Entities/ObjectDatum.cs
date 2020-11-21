using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ObjectDatum
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int ResidenceId { get; set; }
        public int MaxHp { get; set; }
        public int Hp { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int ZPos { get; set; }
        public int Type { get; set; }
    }
}
