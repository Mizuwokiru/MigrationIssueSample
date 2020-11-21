using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Door
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int? MaxHp { get; set; }
    }
}
