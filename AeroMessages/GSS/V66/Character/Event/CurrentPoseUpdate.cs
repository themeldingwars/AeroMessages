using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 110)]
    public partial class CurrentPoseUpdate
    {
        public CurrentPoseUpdateData Data;
    }
}