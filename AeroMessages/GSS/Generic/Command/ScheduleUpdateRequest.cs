using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.ScheduleUpdateRequest, GssVersion.V1, GssVersion.V74)]
    public partial class ScheduleUpdateRequest
    {
        public uint Time;
    }
}