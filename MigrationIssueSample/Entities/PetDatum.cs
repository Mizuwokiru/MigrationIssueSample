using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PetDatum
    {
        public int PetId { get; set; }
        public int NpcClassId { get; set; }
        public int Expoint { get; set; }
        public string NickName { get; set; }
        public double Hp { get; set; }
        public double Mp { get; set; }
        public int Sp { get; set; }
        public int Meal { get; set; }
        public int Slot1 { get; set; }
        public int Slot2 { get; set; }
    }
}
