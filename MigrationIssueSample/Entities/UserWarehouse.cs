using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserWarehouse
    {
        public int ItemId { get; set; }
        public int CharId { get; set; }
        public int ItemType { get; set; }
        public int Amount { get; set; }
        public int Enchant { get; set; }
        public int Eroded { get; set; }
        public byte Bless { get; set; }
        public byte Ident { get; set; }
        public byte? Wished { get; set; }
        public int Warehouse { get; set; }
    }
}
