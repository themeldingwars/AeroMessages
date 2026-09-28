using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.DisplayRewards, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class DisplayRewards
    {
        public uint IndexId; // Used by client when claiming

        [AeroSdb("dblocalization::UITextMap", "id")]
        public uint TitleTextId;

        public uint EventId; // world object/event id, gives the event name and icon

        [AeroArray(typeof(byte))]
        public StatInfo[] Stats;

        [AeroArray(typeof(byte))]
        public RewardInfoData[] Rewards1;

        [AeroArray(typeof(byte))]
        public RewardInfoData[] Rewards2;

        public EntityId ResourceTargetId;
        public byte ResourceTargetType; // "0": DEFAULT, "1": PERMANENT, "2": TEMPORARY, "3": "OUTPOST" ...
        public uint Experience;

        [AeroSdb("dbcharacter::RewardScreenType", "id")]
        public byte ScreenType;

        public byte DisplayQuality; // 0 = salvage, 5 = legendary

        [AeroArray(typeof(byte))]
        public ReputationInfo[] Reputations;
    }


    [AeroBlock]
    public struct StatInfo
    {
        public enum StatType : byte
        {
            NumericValue = 0,
            Percent = 1,
            Time = 2,
            LocalizedString = 3, // Value is a localized text id
            String = 4, // StringValue is shown instead of Value
        }

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint NameId;

        public StatType Type;
        public float Value;
        [AeroString] public string StringValue;
    }

    [AeroBlock]
    public struct ReputationInfo
    {
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId;

        public uint Amount;
    }
}