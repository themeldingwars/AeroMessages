using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 58)]
    public partial class GamePaused
    {
        public ulong Unk1;
        public ulong Unk2;
        public ulong Unk3; // different?
        public ulong Unk4;
        public ulong Unk5;
        public byte Paused;
    }
}