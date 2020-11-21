using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Agit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PledgeId { get; set; }
        public int? AuctionPrice { get; set; }
        public int? AuctionDate { get; set; }
        public byte? HpStove { get; set; }
        public byte? MpFlame { get; set; }
        public byte? Hatcher { get; set; }
        public int? HpStoveExpire { get; set; }
        public int? MpFlameExpire { get; set; }
        public byte? Status { get; set; }
        public int? NextWarTime { get; set; }
        public int? AuctionId { get; set; }
        public int? LastPrice { get; set; }
        public int? LastCancel { get; set; }
        public int? TeleportLevel { get; set; }
        public int? TeleportExpire { get; set; }
        public int? NextCost { get; set; }
        public int? CostFail { get; set; }
        public int TaxRate { get; set; }
        public int ShopIncome { get; set; }
        public short TaxRateToChange { get; set; }
        public short TaxChildRate { get; set; }
        public short TaxChildRateToChange { get; set; }
        public int ShopIncomeTemp { get; set; }
        public int? TeamBattleStatus { get; set; }
    }
}
