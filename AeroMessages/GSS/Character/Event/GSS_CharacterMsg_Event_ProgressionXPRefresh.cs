using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 89)]
    public partial class Character_Event_ProgressionXPRefresh
    {
        [AeroArray(typeof(byte))]
        public ProgressionFrameInfo[] Frames;
    }

    [AeroBlock]
    public struct ProgressionFrameInfo
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ChassisID;

        public uint XpValue1;
        public uint XpValue2;
        public byte CurrentLevel;

        [AeroArray(7)]
        public byte[] Unk;
    }
}