using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class Bookmark
    {
        public int CharId { get; set; }
        public string Name { get; set; }
        public int? World { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Z { get; set; }
        public int Bookmarkid { get; set; }
    }
}
