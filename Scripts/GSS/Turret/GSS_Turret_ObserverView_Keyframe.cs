using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 3, true)]
    public class TurretObserverViewKeyframe : BaseScript
    {
        public byte Unk_MoreData; // When 0 we get another 20 bytes at the end of the message
        public uint TurretTypeId; // SDB Table 197
        public string ParentEntity; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        public byte Unk2; // Only observed 0x00
        public string Entity2;
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

                ParentEntity = Stream.Read.Entity();

                Unk2 = Stream.Read.Byte();
                Entity2 = Stream.Read.Entity();

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

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
            
        public enum Controller : byte
        {
            Generic = 0x00,
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            TinyObjectType = 0x29,
            CharacterAbilityPhysics = 0x2a,
            ProjectileObjectType = 0x2b,
            Outpost = 0x2c,
            ResourceArea = 0x2e,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
            LootStoreExtension = 0x34,
            TeamManager = 0x36,
        }
        
        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            if (controller == 0 && id == 0) return "None";
            return $"{controller}:{id}";
        }

        public static string[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }
    }
}