using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AnimationUpdated, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class AnimationUpdated
    {
        public ushort ShortTime;
        public byte AnimRequestId; // low 7 bits, the client strips bit 7
    }
}