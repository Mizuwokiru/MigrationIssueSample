using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TempRecipe
    {
        public int? CharId { get; set; }
        public int? ItemType { get; set; }
        public int? Warehouse { get; set; }
        public int? Recipecount { get; set; }
    }
}
