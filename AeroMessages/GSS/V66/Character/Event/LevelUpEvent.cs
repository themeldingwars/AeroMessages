using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 171)]
    public partial class LevelUpEvent
    {
        public uint FrameId;
        public byte NewLevel;
        public byte NumberOfLevelsAdvanced;
        [AeroArray(typeof(byte))]
        public byte[] UnkByteArray;
    }
}