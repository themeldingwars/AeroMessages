using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CurrentPoseUpdate, GssCharacterView.MovementView, GssVersion.V9, GssVersion.V67)]
    public partial class CurrentPoseUpdate
    {
        public CurrentPoseUpdateData Data;
    }
}