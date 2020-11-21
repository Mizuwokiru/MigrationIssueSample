using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class TmpUserDatum
    {
        public string CharName { get; set; }
        public int CharId { get; set; }
        public string AccountName { get; set; }
        public int AccountId { get; set; }
        public int PledgeId { get; set; }
        public byte Builder { get; set; }
        public byte Gender { get; set; }
        public byte Race { get; set; }
        public byte Class { get; set; }
        public short World { get; set; }
        public int Sp { get; set; }
        public int Exp { get; set; }
        public byte Lev { get; set; }
        public int Align { get; set; }
        public int Pk { get; set; }
        public int Pkpardon { get; set; }
        public int Duel { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public string Nickname { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int UseTime { get; set; }
        public int DropExp { get; set; }
        public double Cp { get; set; }
        public double MaxCp { get; set; }
        public int? SubjobId { get; set; }
        public int Subjob0Class { get; set; }
        public int Subjob1Class { get; set; }
        public int Subjob2Class { get; set; }
        public int Subjob3Class { get; set; }
    }
}
