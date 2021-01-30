using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 96, true)]
    public class CharacterCombatViewAbilityProjectileFired : BaseScript
    {
        public ushort ShortTime;
        public ushort[] PackedUnk; // Could be a ruse, if not, what vector would this be???
        public float[] UnpackedUnk;
        public ushort[] PackedAim; // Confirmed that this second one is the aim
        public float[] Aim;
        public ushort AmmoType; // Definition in Sdb table 120, references from table 238
        public float Range; // Value is found in fireprojcdef table 238

        public byte[] Unk1;
        public ushort Hardpoint;

        public byte[] Unk5;

        public byte UnkFlag;
        public byte[] UnkFlaggedEntity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true)
            {
                ShortTime = Stream.Read.UShort();
                PackedUnk = Stream.Read.UShortArray(3);
                UnpackedUnk = UnpackFloatArray(PackedUnk);
                PackedAim = Stream.Read.UShortArray(3);
                Aim = UnpackFloatArray(PackedAim);
                AmmoType = Stream.Read.UShort();
                Range = Stream.Read.Float();

                Unk1 = Stream.Read.ByteArray(14);

                Hardpoint = Stream.Read.UShort();

                Unk5 = Stream.Read.ByteArray(2);

                UnkFlag = Stream.Read.Byte();
                if (UnkFlag > 0)
                {
                    UnkFlaggedEntity = Stream.Read.ByteArray(8);
                }
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