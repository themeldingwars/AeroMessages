using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.JumpRolled, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class JumpRolled
    {
        public ushort ShortTime;
    }
}