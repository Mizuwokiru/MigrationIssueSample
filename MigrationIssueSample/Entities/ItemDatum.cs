using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ItemDatum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Logdate { get; set; }
        public string Consumetype { get; set; }
        public byte IsQuest { get; set; }
    }
}
