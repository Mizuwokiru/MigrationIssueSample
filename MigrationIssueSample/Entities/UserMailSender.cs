using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserMailSender
    {
        public int MailId { get; set; }
        public int RelatedId { get; set; }
        public byte MailType { get; set; }
        public byte MailboxType { get; set; }
        public int SenderId { get; set; }
        public string SenderName { get; set; }
        public DateTime SendDate { get; set; }
        public string ReceiverNameList { get; set; }
        public byte Deleted { get; set; }
    }
}
