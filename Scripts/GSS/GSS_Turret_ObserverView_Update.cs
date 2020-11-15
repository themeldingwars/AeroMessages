using Bitter;
using System;
namespace PacketPeepScript
{
    // This pretty rough, not tested
    [Script(MessageType.GSS, 40, 1, true)]
    public class TurretObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Unk_0x03 = 0x03,
            Rotation = 0x04,
            Unk_0x05 = 0x05,
            FireBurst = 0x06, // Maybe FireBurst
            FireEnd = 0x07, // Maybe FireEnd

            Unk_0x0a = 0x0a, // Maybe Faction

            Unk_0x8b = 0x8b, // Some action/eventcall, no data
        }

        public byte[] Unk_0x03_Entity; // Think this is the "gunner npc" but not finding them
        public ulong? Unk_0x03_Entity_Value;

        public ushort? Rotation_ShortTime;
        public ushort[] Rotation_Data;
        public float[] Rotation_Unpacked;
        public uint? Unk_0x05;
        public uint? FireBurst_Time;
        public uint? FireEnd_Time;

        public byte[] Unk_0x0a_Faction;

        public bool? Unk_0x8b;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x03:
                        Unk_0x03_Entity = Stream.Read.ByteArray(8);
                        Stream.baseStream.ByteOffset -= 8;
                        Unk_0x03_Entity_Value = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;
                        break;
                    case ShadowFieldIndex.Rotation:
                        Rotation_ShortTime = Stream.Read.UShort();
                        Rotation_Data = Stream.Read.UShortArray(4);
                        Rotation_Unpacked = UnpackFloatArray(Rotation_Data);
                        break;
                    case ShadowFieldIndex.Unk_0x05:
                        Unk_0x05 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.FireBurst:
                        FireBurst_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.FireEnd:
                        FireEnd_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x0a:
                        Unk_0x0a_Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x8b:
                        Unk_0x8b = true;
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

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