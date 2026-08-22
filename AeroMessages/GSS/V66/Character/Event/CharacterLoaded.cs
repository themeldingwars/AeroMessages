using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 148)]
    public partial class CharacterLoaded
    {
        public sbyte Unk1;
        public sbyte Unk2;
    }
}