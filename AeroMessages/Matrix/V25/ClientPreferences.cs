using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 26)]
    public partial class ClientPreferences
    {
        public uint Unk1;
        public uint Unk2;
        public ushort Unk3;
        public byte Unk4; // When debuglag.matrixDev is set to 1, Unk4 == 2. Otherwise == 0.
    }
}