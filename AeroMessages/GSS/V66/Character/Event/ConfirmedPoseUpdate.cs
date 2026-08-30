using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ConfirmedPoseUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ConfirmedPoseUpdate
    {
        public MovementPoseData PoseData;
        public ushort NextShortTime;
    }
}