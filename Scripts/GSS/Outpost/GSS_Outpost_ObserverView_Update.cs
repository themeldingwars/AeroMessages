using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 45, 1, true)]
    public class OutpostObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            OutpostName            = 0x00,
            Position               = 0x01,
            LevelBandId            = 0x02,
            SinUnlockIndex         = 0x03,
            TeleportCost           = 0x04,
            Dynamic_00             = 0x05,
            Dynamic_01             = 0x06,
            Dynamic_02             = 0x07,
            Dynamic_03             = 0x08,
            Dynamic_04             = 0x09,
            Dynamic_05             = 0x0a,
            Dynamic_06             = 0x0b,
            Dynamic_07             = 0x0c,
            Dynamic_08             = 0x0d,
            Dynamic_09             = 0x0e,
            Dynamic_10             = 0x0f,
            Dynamic_11             = 0x10,
            NearbyResourceItems_0  = 0x11,
            NearbyResourceItems_1  = 0x12,
            NearbyResourceItems_2  = 0x13,
            NearbyResourceItems_3  = 0x14,
            NearbyResourceItems_4  = 0x15,
            NearbyResourceItems_5  = 0x16,
            NearbyResourceItems_6  = 0x17,
            NearbyResourceItems_7  = 0x18,
            NearbyResourceItems_8  = 0x19,
            NearbyResourceItems_9  = 0x1a,
            NearbyResourceItems_10 = 0x1b,
            NearbyResourceItems_11 = 0x1c,
            NearbyResourceItems_12 = 0x1d,
            NearbyResourceItems_13 = 0x1e,
            NearbyResourceItems_14 = 0x1f,
            NearbyResourceItems_15 = 0x20,
            EncounterId            = 0x21,
            ScopeBubbleInfo        = 0x22,

            Clear_NearbyResourceItems_0  = 0x91,
            Clear_NearbyResourceItems_1  = 0x92,
            Clear_NearbyResourceItems_2  = 0x93,
            Clear_NearbyResourceItems_3  = 0x94,
            Clear_NearbyResourceItems_4  = 0x95,
            Clear_NearbyResourceItems_5  = 0x96,
            Clear_NearbyResourceItems_6  = 0x97,
            Clear_NearbyResourceItems_7  = 0x98,
            Clear_NearbyResourceItems_8  = 0x99,
            Clear_NearbyResourceItems_9  = 0x9a,
            Clear_NearbyResourceItems_10 = 0x9b,
            Clear_NearbyResourceItems_11 = 0x9c,
            Clear_NearbyResourceItems_12 = 0x9d,
            Clear_NearbyResourceItems_13 = 0x9e,
            Clear_NearbyResourceItems_14 = 0x9f,
            Clear_NearbyResourceItems_15 = 0xa0,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public uint? OutpostName;
        public float[] Position;
        public uint? LevelBandId;
        public byte? SinUnlockIndex;
        public int? TeleportCost;
        public float? Progress; // Dynamic_00
        public byte? FactionId; // Dynamic_01
        public byte? Team; // Dynamic_02
        public byte? UnderAttack; // Dynamic_03
        public byte? OutpostType; // Dynamic_04
        public uint? PossibleBuffsId; // Dynamic_05
        public byte? PowerLevel; // Dynamic_06
        public ushort? MWCurrent; // Dynamic_07
        public ushort? MWMax; // Dynamic_08
        public uint? MapMarkerTypeId; // Dynamic_09
        public float? Radius; // Dynamic_10
        public byte[] Dynamic_11;
        public uint? NearbyResourceItems_0;
        public uint? NearbyResourceItems_1;
        public uint? NearbyResourceItems_2;
        public uint? NearbyResourceItems_3;
        public uint? NearbyResourceItems_4;
        public uint? NearbyResourceItems_5;
        public uint? NearbyResourceItems_6;
        public uint? NearbyResourceItems_7;
        public uint? NearbyResourceItems_8;
        public uint? NearbyResourceItems_9;
        public uint? NearbyResourceItems_10;
        public uint? NearbyResourceItems_11;
        public uint? NearbyResourceItems_12;
        public uint? NearbyResourceItems_13;
        public uint? NearbyResourceItems_14;
        public uint? NearbyResourceItems_15;
        public string EncounterId;
        public byte[] ScopeBubbleInfo;

        public bool? Clear_NearbyResourceItems_0;
        public bool? Clear_NearbyResourceItems_1;
        public bool? Clear_NearbyResourceItems_2;
        public bool? Clear_NearbyResourceItems_3;
        public bool? Clear_NearbyResourceItems_4;
        public bool? Clear_NearbyResourceItems_5;
        public bool? Clear_NearbyResourceItems_6;
        public bool? Clear_NearbyResourceItems_7;
        public bool? Clear_NearbyResourceItems_8;
        public bool? Clear_NearbyResourceItems_9;
        public bool? Clear_NearbyResourceItems_10;
        public bool? Clear_NearbyResourceItems_11;
        public bool? Clear_NearbyResourceItems_12;
        public bool? Clear_NearbyResourceItems_13;
        public bool? Clear_NearbyResourceItems_14;
        public bool? Clear_NearbyResourceItems_15;

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
                    
                    case ShadowFieldIndex.OutpostName:
                        OutpostName = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;
                    case ShadowFieldIndex.LevelBandId:
                        LevelBandId = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.SinUnlockIndex:
                        SinUnlockIndex = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.TeleportCost:
                        TeleportCost = Stream.Read.Int();
                        break;
                    case ShadowFieldIndex.Dynamic_00:
                        Progress = Stream.Read.Float();
                        break;
                    case ShadowFieldIndex.Dynamic_01:
                        FactionId = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_02:
                        Team = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_03:
                        UnderAttack = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_04:
                        OutpostType = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_05:
                        PossibleBuffsId = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Dynamic_06:
                        PowerLevel = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_07:
                        MWCurrent = Stream.Read.UShort();
                        break;
                    case ShadowFieldIndex.Dynamic_08:
                        MWMax = Stream.Read.UShort();
                        break;
                    case ShadowFieldIndex.Dynamic_09:
                        MapMarkerTypeId = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Dynamic_10:
                        Radius = Stream.Read.Float(); 
                        break;
                    case ShadowFieldIndex.Dynamic_11:
                        Dynamic_11 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_0:
                        NearbyResourceItems_0 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_1:
                        NearbyResourceItems_1 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_2:
                        NearbyResourceItems_2 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_3:
                        NearbyResourceItems_3 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_4:
                        NearbyResourceItems_4 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_5:
                        NearbyResourceItems_5 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_6:
                        NearbyResourceItems_6 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_7:
                        NearbyResourceItems_7 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_8:
                        NearbyResourceItems_8 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_9:
                        NearbyResourceItems_9 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_10:
                        NearbyResourceItems_10 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_11:
                        NearbyResourceItems_11 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_12:
                        NearbyResourceItems_12 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_13:
                        NearbyResourceItems_13 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_14:
                        NearbyResourceItems_14 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.NearbyResourceItems_15:
                        NearbyResourceItems_15 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.EncounterId:
                        EncounterId = Stream.Read.Entity();
                        break;
                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;


                    case ShadowFieldIndex.Clear_NearbyResourceItems_0:
                        Clear_NearbyResourceItems_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_1:
                        Clear_NearbyResourceItems_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_2:
                        Clear_NearbyResourceItems_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_3:
                        Clear_NearbyResourceItems_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_4:
                        Clear_NearbyResourceItems_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_5:
                        Clear_NearbyResourceItems_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_6:
                        Clear_NearbyResourceItems_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_7:
                        Clear_NearbyResourceItems_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_8:
                        Clear_NearbyResourceItems_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_9:
                        Clear_NearbyResourceItems_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_10:
                        Clear_NearbyResourceItems_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_11:
                        Clear_NearbyResourceItems_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_12:
                        Clear_NearbyResourceItems_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_13:
                        Clear_NearbyResourceItems_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_14:
                        Clear_NearbyResourceItems_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_NearbyResourceItems_15:
                        Clear_NearbyResourceItems_15 = true;
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