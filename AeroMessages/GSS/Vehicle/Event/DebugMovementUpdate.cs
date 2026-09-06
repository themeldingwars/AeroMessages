using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.DebugMovementUpdate, GssVehicleView.MovementView, GssVersion.V16, GssVersion.V67)]
    public partial class DebugMovementUpdate
    {
        public byte Unk1;
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort Unk2; // State?
        public uint Unk3; // Time?
    }
}