using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.DebugMovementUpdate, GssVehicleView.MovementView, GssVersion.V16, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.DebugMovementUpdate, GssVehicleView.BaseController, GssVersion.V74, GssVersion.V74)]
    public partial class DebugMovementUpdate
    {
        public byte Unk1; // debug channel: 0 and 1 are drawn, other values are ignored
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort Unk2; // stored in the debug record, not interpreted
        public uint Time;
    }
}