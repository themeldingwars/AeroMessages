using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 1, true)]
    public class TurretObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Type = 0x00,
            ParentObjId = 0x01,
            ParentChildIndex = 0x02,
            GunnerId = 0x03,
            CurrentPose = 0x04,
            ProcessDelay = 0x05,
            WeaponBurstFired = 0x06,
            WeaponBurstEnded = 0x07,
            Ammo = 0x08,
            FireRateModifier = 0x09,
            HostilityInfo = 0x0a, // Faction
            PersonalFactionStance = 0x0b,

            Clear_PersonalFactionStance = 0x8b,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public uint? Type; // SDB Table 197
        public string ParentObjId; 
        public byte? ParentChildIndex; // Only observed 0x00
        public string GunnerId;
        public ushort? CurrentPose_ShortTime;
        public ushort[] CurrentPose_Rotation_Data;
        public float[] CurrentPose_Rotation_Unpacked;
        public uint? ProcessDelay;
        public uint? WeaponBurstFired;
        public uint? WeaponBurstEnded;
        public byte? Ammo_Count; // Limited examples, could be wrong
        public ushort[] Ammo_Data; // Limited examples, could be wrong
        public float? FireRateModifier;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;

        public bool? Clear_PersonalFactionStance;

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
                    case ShadowFieldIndex.Type:
                        Type = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.ParentObjId:
                        ParentObjId = Stream.Read.Entity();
                        break;
                    case ShadowFieldIndex.ParentChildIndex:
                        ParentChildIndex = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.GunnerId:
                        GunnerId = Stream.Read.Entity();
                        break;
                    case ShadowFieldIndex.CurrentPose:
                        CurrentPose_ShortTime = Stream.Read.UShort();
                        CurrentPose_Rotation_Data = Stream.Read.UShortArray(4);
                        CurrentPose_Rotation_Unpacked = UnpackFloatArray(CurrentPose_Rotation_Data);
                        break;
                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WeaponBurstFired:
                        WeaponBurstFired = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WeaponBurstEnded:
                        WeaponBurstEnded = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Ammo:
                        Ammo_Count = Stream.Read.Byte();
                        if (Ammo_Count > 0x00) {
                            Ammo_Data = Stream.Read.UShortArray((int)Ammo_Count);
                        }
                        break;
                    case ShadowFieldIndex.FireRateModifier:
                        FireRateModifier = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo = Stream.Read.ByteArray(2);
                        break;
                    case ShadowFieldIndex.PersonalFactionStance:
                        PersonalFactionStance = Stream.Read.ByteArray(20);
                        break;

                    case ShadowFieldIndex.Clear_PersonalFactionStance:
                        Clear_PersonalFactionStance = true;
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