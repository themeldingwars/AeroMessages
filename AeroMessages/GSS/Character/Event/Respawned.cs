using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Respawned, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Respawned, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class Respawned
    {
        public ushort ShortTime;
        public sbyte Unk1; // 1 only together with Unk2 = 6
        public byte Unk2; // CharacterStatus values: 1 after Ghost, 2 after Dead, 6 when respawned while alive
    }
}