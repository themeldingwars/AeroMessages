using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 86)]
    public partial class CurrentPoseUpdate
    {
        public CurrentPoseUpdateData Data;
    }
}