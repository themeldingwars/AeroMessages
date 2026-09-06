using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProgressionXpRefresh, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ProgressionXPRefresh
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
        public uint CurrentLevel;
        public uint Unk;
    }
}