using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 91)]
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