using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 31, 86, true)]
    public class VehicleMovementViewCurrentPoseUpdate : BaseScript
    {
        public byte Flags;
        public ushort ShortTime;
        public byte Unk1;
        public ushort MovementState;
        public float[] Position;
        public ushort[] PackedRotation;
        public float[] Rotation;
        public ushort[] PackedDirection;
        public float[] Direction;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Flags = Stream.Read.Byte();
            ShortTime = Stream.Read.UShort();

            if (Flags == 0x00)
            {
                Unk1 = Stream.Read.Byte();
                MovementState = Stream.Read.UShort();
                Position = Stream.Read.FloatArray(3);
                PackedRotation = Stream.Read.UShortArray(4);
                Rotation = UnpackFloatArray(PackedRotation);
                PackedDirection = Stream.Read.UShortArray(3);
                Direction = UnpackFloatArray(PackedDirection);
            }
        }

        // Util funcs to handle floats packed as ushort
        private float UnpackFloat(ushort val)
        {
            float result = (1.0f / 32767f) * val;
            if (result >= 0)
            {
                result = (result -1f) * -1f; 
            }
            return result;
        }
        private float[] UnpackFloatArray(ushort[] arr)
        {
            return Array.ConvertAll(arr, val => UnpackFloat(val));
        }
    }

}