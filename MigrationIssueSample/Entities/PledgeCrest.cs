using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class PledgeCrest
    {
        public int CrestId { get; set; }
        public short BitmapSize { get; set; }
        public byte[] Bitmap { get; set; }
    }
}
