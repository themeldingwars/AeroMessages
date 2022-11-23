using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 111)]
    public partial class ConfirmedPoseUpdate
    {
        public MovementPoseData PoseData;
        public ushort NextShortTime;
    }
}