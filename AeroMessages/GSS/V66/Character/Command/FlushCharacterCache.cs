using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 231)]
    public partial class FlushCharacterCache
    {
        public sbyte Unk1;
        public sbyte Unk2;
        public sbyte Unk3;
        public sbyte Unk4;
        public sbyte Unk5;
    }
}