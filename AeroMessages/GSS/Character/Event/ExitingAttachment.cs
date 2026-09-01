using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ExitingAttachment, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ExitingAttachment
    {
        // Guessing
        public QuantisedVector3 Direction;
    }
}