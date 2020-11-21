using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class MultiSellLog
    {
        public int CharId { get; set; }
        public int AccountId { get; set; }
        public string CharName { get; set; }
        public string AccountName { get; set; }
        public int Price1Id { get; set; }
        public int Price1Count { get; set; }
        public int Price2Id { get; set; }
        public int Price2Count { get; set; }
        public int Price3Id { get; set; }
        public int Price3Count { get; set; }
        public int Price4Id { get; set; }
        public int Price4Count { get; set; }
        public int Price5Id { get; set; }
        public int Price5Count { get; set; }
        public int Reward1Id { get; set; }
        public int Reward1Count { get; set; }
        public int Reward2Id { get; set; }
        public int Reward2Count { get; set; }
        public int Reward3Id { get; set; }
        public int Reward3Count { get; set; }
        public int Reward4Id { get; set; }
        public int Reward4Count { get; set; }
        public int Reward5Id { get; set; }
        public int Reward5Count { get; set; }
        public int Timestamp { get; set; }
    }
}
