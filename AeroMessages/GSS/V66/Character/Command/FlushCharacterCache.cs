using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 231)]
    public partial class FlushCharacterCache
    {
        public byte Unk1;
        public byte Unk2;
        public byte Unk3;
        public byte Unk4;
        public byte Unk5;
    }
}