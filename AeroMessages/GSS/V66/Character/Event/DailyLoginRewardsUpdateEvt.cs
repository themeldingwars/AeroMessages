using Aero.Gen.Attributes;
using System.Numerics;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using static Aero.Gen.Attributes.AeroIfAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 175)]
    public partial class DailyLoginRewardsUpdateEvt
    {   
        [AeroArray(typeof(byte))] public DailyRewardsLoginData[] LoginData;
        [AeroArray(typeof(byte))] public DailyRewardStreakData[] StreakData;
        public uint StreakLength;
        public uint StreakBuybackPrice;
        [AeroSdb("dbcharacter::Calendar", "id")]
        public uint CalendarId;
    }

    [AeroBlock]
    public struct DailyRewardsLoginData
    {
        public uint Epoch;
        [AeroString] public string Date; // YYYY-MM-DD
        public byte Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct DailyRewardStreakData
    {
        public uint DayId; // Should be unique or it overrides
        public uint Day; // Becomes the key (so must also be unique) and the display value
        public uint Display; // Seems like it can be the index to display in streak items if there are multiple
        public uint LastClaimTime;

        [AeroArray(typeof(byte))] public DailyRewardStreakItemData[] StreakItems; // If no entries are provided the client crashes?
    }

    [AeroBlock]
    public struct DailyRewardStreakItemData
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint StreakItem;
        public uint StreakItemCount;
    }
}