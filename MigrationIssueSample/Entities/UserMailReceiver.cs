using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserMailReceiver
    {
        public int MailId { get; set; }
        public byte MailboxType { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverName { get; set; }
        public DateTime? ReadDate { get; set; }
        public byte ReadStatus { get; set; }
        public byte Deleted { get; set; }
    }
}
