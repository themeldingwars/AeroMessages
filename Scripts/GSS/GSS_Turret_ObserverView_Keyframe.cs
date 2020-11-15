using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 3, true)]
    public class TurretObserverViewKeyframe : BaseScript
    {
        public byte Unk_MoreData; // When 0 we get another 20 bytes at the end of the message
        public uint TurretTypeId; // SDB Table 197
        public byte[] ParentEntity; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        public ulong ParentEntity_Value; // Just for searching purposes
        public byte Unk2; // Only observed 0x00
        public byte[] Entity2;
        public ulong Entity2_Value; // Just for searching purposes
        public ushort Rotation_ShortTime;
        public ushort[] Rotation_Data; // Assumption
        public float[] Rotation_Unpacked; // Assumption
        public uint Unk_0x05; // Shadow field index 0x05, 4 bytes
        public uint FireBurst_Time;
        public uint FireEnd_Time;
        public byte Unk6_Count;
        public ushort[] Unk6_Data; // Looks like 2 bytes each so assuming short
        public float Unk7_Float;
        public byte[] Faction;
        public byte[] Unk_MoreData_1;
        public byte[] Unk_MoreData_2;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            if (true) {
                Unk_MoreData = Stream.Read.Byte();
                TurretTypeId = Stream.Read.UInt();

                ParentEntity = Stream.Read.ByteArray(8);
                Stream.baseStream.ByteOffset -= 8;
                ParentEntity_Value = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;

                Unk2 = Stream.Read.Byte();
                Entity2 = Stream.Read.ByteArray(8);
                Stream.baseStream.ByteOffset -= 8;
                Entity2_Value = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;

                Rotation_ShortTime = Stream.Read.UShort();
                Rotation_Data = Stream.Read.UShortArray(4);
                Rotation_Unpacked = UnpackFloatArray(Rotation_Data);
                Unk_0x05 = Stream.Read.UInt();
                FireBurst_Time = Stream.Read.UInt();
                FireEnd_Time = Stream.Read.UInt();
                Unk6_Count = Stream.Read.Byte();
                if (Unk6_Count > 0x00) {
                    Unk6_Data = Stream.Read.UShortArray((int)Unk6_Count);
                }
                Unk7_Float = Stream.Read.Float();
                Faction = Stream.Read.ByteArray(2);
                if (Unk_MoreData == 0x00) {
                    Unk_MoreData_1 = Stream.Read.ByteArray(10);
                    Unk_MoreData_2 = Stream.Read.ByteArray(10);
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