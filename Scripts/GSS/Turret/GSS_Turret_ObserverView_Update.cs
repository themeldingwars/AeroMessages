using Bitter;
using System;
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

            Unk_0x8b = 0x8b, // Some action/eventcall, no data
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte[] GunnerId_Entity;
        public ulong? GunnerId_Entity_Value;

        public ushort? CurrentPose_ShortTime;
        public ushort[] CurrentPose_Data;
        public float[] CurrentPose_Unpacked;
        public uint? ProcessDelay;
        public uint? WeaponBurstFired_Time;
        public uint? WeaponBurstEnded_Time;

        public byte[] HostilityInfo_Faction;

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
                    case ShadowFieldIndex.GunnerId:
                        GunnerId_Entity = Stream.Read.ByteArray(8);
                        Stream.baseStream.ByteOffset -= 8;
                        GunnerId_Entity_Value = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;
                        break;
                    case ShadowFieldIndex.CurrentPose:
                        CurrentPose_ShortTime = Stream.Read.UShort();
                        CurrentPose_Data = Stream.Read.UShortArray(4);
                        CurrentPose_Unpacked = UnpackFloatArray(CurrentPose_Data);
                        break;
                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WeaponBurstFired:
                        WeaponBurstFired_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WeaponBurstEnded:
                        WeaponBurstEnded_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo_Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x8b:
                        Unk_0x8b = true;
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
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