using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CharacterLoaded, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class CharacterLoaded
    {
        public sbyte Unk1;
        public sbyte Unk2;
    }
}