using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserFriend
    {
        public int CharId { get; set; }
        public int FriendCharId { get; set; }
        public string FriendCharName { get; set; }
    }
}
