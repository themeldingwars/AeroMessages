using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 35)]
    public partial class WelcomeToTheMatrix
    {
        public ulong PlayerID;
        public ushort Unk1;
        public ushort Unk2;
    }
}