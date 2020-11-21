using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationIssueSample.Entities
{
    public partial class UserDataMoved
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
        public int Xloc { get; set; }
        public int Yloc { get; set; }
        public int Zloc { get; set; }
        public short IsInVehicle { get; set; }
        public double Hp { get; set; }
        public double Mp { get; set; }
        public int Sp { get; set; }
        public int Exp { get; set; }
        public byte Lev { get; set; }
        public int Align { get; set; }
        public int Pk { get; set; }
        public int Pkpardon { get; set; }
        public int Duel { get; set; }
        public int StUnderware { get; set; }
        public int StRightEar { get; set; }
        public int StLeftEar { get; set; }
        public int StNeck { get; set; }
        public int StRightFinger { get; set; }
        public int StLeftFinger { get; set; }
        public int StHead { get; set; }
        public int StRightHand { get; set; }
        public int StLeftHand { get; set; }
        public int StGloves { get; set; }
        public int StChest { get; set; }
        public int StLegs { get; set; }
        public int StFeet { get; set; }
        public int StBack { get; set; }
        public int StBothHand { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public byte[] QuestFlag { get; set; }
        public string Nickname { get; set; }
        public byte[] PowerFlag { get; set; }
        public int PledgeDismissTime { get; set; }
        public int PledgeLeaveTime { get; set; }
        public byte PledgeLeaveStatus { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public string QuestMemo { get; set; }
        public int FaceIndex { get; set; }
        public int HairShapeIndex { get; set; }
        public int HairColorIndex { get; set; }
        public int UseTime { get; set; }
        public DateTime? TempDeleteDate { get; set; }
        public int PledgeOustedTime { get; set; }
        public int PledgeWithdrawTime { get; set; }
        public int SurrenderWarId { get; set; }
        public int DropExp { get; set; }
    }
}
