using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Respawned, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Respawned, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class Respawned
    {
        public ushort ShortTime;
        public sbyte Unk1;
        public byte Unk2;
    }
}