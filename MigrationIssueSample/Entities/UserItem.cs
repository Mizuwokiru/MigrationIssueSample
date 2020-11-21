using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserItem
    {
        public int ItemId { get; set; }
        public int CharId { get; set; }
        public int ItemType { get; set; }
        public int Amount { get; set; }
        public int Enchant { get; set; }
        public int Eroded { get; set; }
        public byte Bless { get; set; }
        public int Ident { get; set; }
        public byte Wished { get; set; }
        public int Warehouse { get; set; }
        public int Augmentation { get; set; }
        public int ManaLeft { get; set; }
        public int LifeTime { get; set; }
        public int ProtectionTimeout { get; set; }
    }
}
