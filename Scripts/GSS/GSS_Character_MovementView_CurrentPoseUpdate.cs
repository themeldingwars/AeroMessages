using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 12, 110, true)]
    public class CharacterMovementViewCurrentPoseUpdate : BaseScript
    {
        public byte Flags;
        public ushort ShortTime;
        public byte? Unk1;
        public ushort? MovementState;
        public float[] Position;
        public ushort[] PackedRotation;
        public float[] Rotation;
        public ushort[] PackedAim;
        public float[] Aim;

        public byte[] Flag_2_Value;
        public byte[] Flag_3_Value;
        public byte[] Flag_4_Value;
        public byte[] Flag_5_Value;
        public byte[] Flag_6_Value;
        public byte[] Flag_7_Value;

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
                PackedAim = Stream.Read.UShortArray(3);
                Aim = UnpackFloatArray(PackedAim);
            }
            else {
                if ((Flags & 1) == 0) {
                    Unk1 = Stream.Read.Byte();
                }
                if ((Flags & 2) == 0) {
                    MovementState = Stream.Read.UShort();
                }

                if (Flags == 0x62 || Flags == 0x30) {
                    Position = Stream.Read.FloatArray(3); // Looks right to me
                }

                // This was working well until I found an ent where (Flags & 4).
                // That ent had many other messages that broke the pattern.
                // So I guess either the other flags or the value of Unk1 has an impact as well.
                /*
                if ((Flags & 8) == 0) {
                    Flag_3_Value = Stream.Read.ByteArray(3);
                }
                if ((Flags & 16) == 0) {
                    Flag_4_Value = Stream.Read.ByteArray(3);
                }
                if ((Flags & 32) == 0) {
                    Flag_5_Value = Stream.Read.ByteArray(1);
                }
                if ((Flags & 64) == 0) {
                    Flag_6_Value = Stream.Read.ByteArray(3);
                }
                if ((Flags & 128) == 0) {
                    Flag_7_Value = Stream.Read.ByteArray(3);
                }
                 */
                
                
            }
        }

        // Util funcs to handle floats packed as ushort
        private float UnpackFloat(ushort val)
        {
            float result = (1.0f / 32767f) * val;
            if (result >= 0) {
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