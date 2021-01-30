using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 39, 1, true)]
    public class TurretBaseControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Type = 0x00,
            ParentObjId = 0x01,
            ParentChildIndex = 0x02,
            GunnerId = 0x03,
            SpawnPose = 0x04,
            ProcessDelay = 0x05,
            WeaponFireBaseTime = 0x06,
            Ammo = 0x07,
            FireRateModifier = 0x08,
            HostilityInfo = 0x9, // Faction
            PersonalFactionStance = 0x0a,
            ScalingLevel = 0x0b,

            Unk_0x8b = 0x8b, // Some action/eventcall, no data
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public string GunnerId_Entity;

        public ushort? SpawnPose_ShortTime; // May be off
        public ushort[] SpawnPose_Data; // May be off
        public float[] SpawnPose_Unpacked; // May be off
        public uint? ProcessDelay;
        public uint? WeaponFireBaseTime_Time;

        public byte[] HostilityInfo_Faction;

        public bool? Unk_0x8b;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.GunnerId:
                        GunnerId_Entity = Stream.Read.Entity();
                        break;
                    case ShadowFieldIndex.SpawnPose: // May be off
                        SpawnPose_ShortTime = Stream.Read.UShort();
                        SpawnPose_Data = Stream.Read.UShortArray(4);
                        SpawnPose_Unpacked = UnpackFloatArray(SpawnPose_Data);
                        break;
                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WeaponFireBaseTime:
                        WeaponFireBaseTime_Time = Stream.Read.UInt();
                        break;
    
                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo_Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x8b:
                        Unk_0x8b = true;
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
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