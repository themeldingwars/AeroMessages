using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ExitingAttachment, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ExitingAttachment
    {
        public HalfVector3 Direction; // selects the vehicle's exit/interact point, more a position than a direction
    }
}