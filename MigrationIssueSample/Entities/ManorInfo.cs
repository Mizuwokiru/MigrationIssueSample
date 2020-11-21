using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class ManorInfo
    {
        public int ManorId { get; set; }
        public int ResidenceId { get; set; }
        public int AdenaVault { get; set; }
        public int CropBuyVault { get; set; }
        public byte ChangeState { get; set; }
        public int LastChangedT { get; set; }
    }
}
