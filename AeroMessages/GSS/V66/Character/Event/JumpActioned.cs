using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.JumpActioned, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class JumpActioned
    {
        public ushort ShortTime;
    }
}