using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 95, true)]
    public class CharacterCombatControllerWeaponProjectileFired : BaseScript
    {
        public ushort ShortTime;
        public ushort[] PackedAim;
        public float[] Aim;
        public byte Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            ShortTime = Stream.Read.UShort();
            PackedAim = Stream.Read.UShortArray(3);
            Aim = UnpackFloatArray(PackedAim);
            Unk = Stream.Read.Byte();
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