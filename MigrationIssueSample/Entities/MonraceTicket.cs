using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class MonraceTicket
    {
        public int TicketId { get; set; }
        public int? Monraceid { get; set; }
        public short? BetType { get; set; }
        public short? Bet1 { get; set; }
        public short? Bet2 { get; set; }
        public short? Bet3 { get; set; }
        public int? BetMoney { get; set; }
        public int? ItemId { get; set; }
        public int? TaxMoney { get; set; }
        public int? Deleted { get; set; }
        public int? Remotefee { get; set; }
    }
}
