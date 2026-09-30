using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ExitingAttachment, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ExitingAttachment, GssCharacterView.ObserverView, GssVersion.V74, GssVersion.V74)]
    public partial class ExitingAttachment
    {
        public HalfVector3 ExitPosition; // attachment local, the client picks the seat's interact point closest to it
    }
}