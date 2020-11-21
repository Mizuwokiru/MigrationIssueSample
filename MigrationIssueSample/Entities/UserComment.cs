using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserComment
    {
        public string CharName { get; set; }
        public int? CharId { get; set; }
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }
        public string Writer { get; set; }
        public byte? Deleted { get; set; }
    }
}
