using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 164, true)]
    public class CharacterBaseControllerExitingAttachment : BaseScript
    {
        // Guessing
        public ushort[] PackedAim;
        public float[] Aim;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            PackedAim = Stream.Read.UShortArray(3);
            Aim = UnpackFloatArray(PackedAim);
      
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