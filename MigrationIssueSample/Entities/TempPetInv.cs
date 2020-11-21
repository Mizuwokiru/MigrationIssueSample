using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TempPetInv
    {
        public int PetItemId { get; set; }
        public int PetItemType { get; set; }
        public int Amount { get; set; }
        public int PetCollarId { get; set; }
        public int UserId { get; set; }
    }
}
