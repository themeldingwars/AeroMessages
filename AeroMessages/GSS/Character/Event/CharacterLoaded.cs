using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CharacterLoaded, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class CharacterLoaded
    {
        public sbyte Unk1;
        public sbyte Unk2;
    }
}