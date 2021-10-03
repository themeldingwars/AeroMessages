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

        [AeroArray(9)]
        public byte[] Unk2;

        public byte HaveExperience;
        public uint Experience;

        [AeroArray(3)]
        public byte[] Unk3;
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
        public ushort Quantity;
        public ushort Unk1;

        [AeroArray(11)]
        public byte[] Unk2;
    }
}