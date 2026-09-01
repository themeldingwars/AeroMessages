using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CalledForHelp, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class CalledForHelp
    {
        public ushort ShortTime;
    }
}