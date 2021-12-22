/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 133
    MsgName: DisplayRewards
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 133)]
    public partial class Character_Event_DisplayRewards
    {
        public uint IndexId; // Used by client when claiming

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint TitleLocalizationId;

        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(typeof(byte))]
        public StatInfo[] Stats;

        [AeroArray(typeof(byte))]
        public RewardInfo[] Rewards;

        [AeroArray(typeof(byte))]
        public Unk2Info[] Unk2;

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

        [AeroArray(6)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct RewardInfo
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;
        public ushort Quantity; // Total quantity awarded
        public ushort Quality; // Looks to be remnant of the 1-1000 quality system.
        public ushort Boosted; // Amount of quantity that is boosted
        public uint Module1; // Parsed as an array by UI
        public uint Module2; // Only if Module1 is set

        public byte Unk;
    }

    [AeroBlock]
    public struct ReputationInfo
    {
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId;

        public uint Amount;
    }

    [AeroBlock]
    public struct Unk2Info
    {
        [AeroArray(19)]
        public byte[] Data; // ?
    }

    
}