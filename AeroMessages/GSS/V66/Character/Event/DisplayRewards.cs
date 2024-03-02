using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 133)]
    public partial class DisplayRewards
    {
        public uint IndexId; // Used by client when claiming

        [AeroSdb("dblocalization::UITextMap", "id")]
        public uint TitleTextId;

        public uint Unk1;

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
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint LocalizationId;

        public byte Unk1;
        public uint Unk2;
        [AeroString] public string Unk3;
    }

    [AeroBlock]
    public struct ReputationInfo
    {
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId;

        public uint Amount;
    }  
}