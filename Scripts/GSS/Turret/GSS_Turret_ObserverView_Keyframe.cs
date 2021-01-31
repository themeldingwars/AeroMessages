using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 3, true)]
    public class TurretObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            PersonalFactionStance,
        }

        public byte[] Bitfield;
        public uint Type; // SDB Table 197
        public string ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        public byte ParentChildIndex; // Only observed 0x00
        public string GunnerId;
        public ushort CurrentPose_ShortTime;
        public ushort[] CurrentPose_Rotation_Data; // Assumption
        public float[] CurrentPose_Rotation_Unpacked; // Assumption
        public uint ProcessDelay; // Shadow field index 0x05, 4 bytes
        public uint WeaponBurstFired;
        public uint WeaponBurstEnded;
        public byte Ammo_Count; // Limited examples, could be wrong
        public ushort[] Ammo_Data; // Limited examples, could be wrong
        public float FireRateModifier;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
            
            if (true) {
                Bitfield = Stream.Read.BitArray(8); // Only one bit is used :'D
                Type = Stream.Read.UInt();
                ParentObjId = Stream.Read.Entity();
                ParentChildIndex = Stream.Read.Byte();
                GunnerId = Stream.Read.Entity();

                CurrentPose_ShortTime = Stream.Read.UShort();
                CurrentPose_Rotation_Data = Stream.Read.UShortArray(4);
                CurrentPose_Rotation_Unpacked = UnpackFloatArray(CurrentPose_Rotation_Data);

                ProcessDelay = Stream.Read.UInt();
                WeaponBurstFired = Stream.Read.UInt();
                WeaponBurstEnded = Stream.Read.UInt();

                Ammo_Count = Stream.Read.Byte();
                if (Ammo_Count > 0x00) {
                    Ammo_Data = Stream.Read.UShortArray((int)Ammo_Count);
                }

                FireRateModifier = Stream.Read.Float();
                HostilityInfo = Stream.Read.ByteArray(2);
                
                if (Bitfield[(int)BitfieldIndex.PersonalFactionStance] == 0) {
                    PersonalFactionStance = Stream.Read.ByteArray(20);
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