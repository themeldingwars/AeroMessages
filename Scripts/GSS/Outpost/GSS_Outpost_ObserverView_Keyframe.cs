using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 45, 3, true)]
    public class OutpostObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            NearbyResourceItems_0,
            NearbyResourceItems_1,
            NearbyResourceItems_2,
            NearbyResourceItems_3,
            NearbyResourceItems_4,
            NearbyResourceItems_5,
            NearbyResourceItems_6,
            NearbyResourceItems_7,
            NearbyResourceItems_8,
            NearbyResourceItems_9,
            NearbyResourceItems_10,
            NearbyResourceItems_11,
            NearbyResourceItems_12,
            NearbyResourceItems_13,
            NearbyResourceItems_14,
            NearbyResourceItems_15,
        }

        public byte[] Bitfield;
        public uint OutpostName;
        public float[] Position;
        public uint LevelBandId;
        public byte SinUnlockIndex;
        public int TeleportCost;
        public float Progress; // Dynamic_00
        public byte FactionId; // Dynamic_01
        public byte Team; // Dynamic_02
        public byte UnderAttack; // Dynamic_03
        public byte OutpostType; // Dynamic_04
        public uint PossibleBuffsId; // Dynamic_05
        public byte PowerLevel; // Dynamic_06
        public ushort MWCurrent; // Dynamic_07
        public ushort MWMax; // Dynamic_08
        public uint MapMarkerTypeId; // Dynamic_09
        public float Radius; // Dynamic_10
        public byte[] Dynamic_11;
        public uint NearbyResourceItems_0;
        public uint NearbyResourceItems_1;
        public uint NearbyResourceItems_2;
        public uint NearbyResourceItems_3;
        public uint NearbyResourceItems_4;
        public uint NearbyResourceItems_5;
        public uint NearbyResourceItems_6;
        public uint NearbyResourceItems_7;
        public uint NearbyResourceItems_8;
        public uint NearbyResourceItems_9;
        public uint NearbyResourceItems_10;
        public uint NearbyResourceItems_11;
        public uint NearbyResourceItems_12;
        public uint NearbyResourceItems_13;
        public uint NearbyResourceItems_14;
        public uint NearbyResourceItems_15;
        public string EncounterId;
        public byte[] ScopeBubbleInfo;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield = Stream.Read.BitArray(16); 
                OutpostName = Stream.Read.UInt();
                Position = Stream.Read.FloatArray(3);
                LevelBandId = Stream.Read.UInt();
                SinUnlockIndex = Stream.Read.Byte();
                TeleportCost = Stream.Read.Int();

                Progress = Stream.Read.Float();
                FactionId = Stream.Read.Byte();
                Team = Stream.Read.Byte();
                UnderAttack = Stream.Read.Byte();
                OutpostType = Stream.Read.Byte();
                PossibleBuffsId = Stream.Read.UInt();
                PowerLevel = Stream.Read.Byte();
                MWCurrent = Stream.Read.UShort();
                MWMax = Stream.Read.UShort();
                MapMarkerTypeId = Stream.Read.UInt();
                Radius = Stream.Read.Float(); 
                Dynamic_11 = Stream.Read.ByteArray(4);

                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_0] == 0)
                {
                    NearbyResourceItems_0 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_1] == 0)
                {
                    NearbyResourceItems_1 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_2] == 0)
                {
                    NearbyResourceItems_2 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_3] == 0)
                {
                    NearbyResourceItems_3 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_4] == 0)
                {
                    NearbyResourceItems_4 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_5] == 0)
                {
                    NearbyResourceItems_5 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_6] == 0)
                {
                    NearbyResourceItems_6 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_7] == 0)
                {
                    NearbyResourceItems_7 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_8] == 0)
                {
                    NearbyResourceItems_8 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_9] == 0)
                {
                    NearbyResourceItems_9 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_10] == 0)
                {
                    NearbyResourceItems_10 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_11] == 0)
                {
                    NearbyResourceItems_11 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_12] == 0)
                {
                    NearbyResourceItems_12 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_13] == 0)
                {
                    NearbyResourceItems_13 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_14] == 0)
                {
                    NearbyResourceItems_14 = Stream.Read.UInt();
                }
                if (Bitfield[(int)BitfieldIndex.NearbyResourceItems_15] == 0)
                {
                    NearbyResourceItems_15 = Stream.Read.UInt();
                }

                EncounterId = Stream.Read.Entity();
                ScopeBubbleInfo = Stream.Read.ByteArray(8);
            }
            
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