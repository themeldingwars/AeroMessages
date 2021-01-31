using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 24, 3, true)]
    public class AreaVisualDataLootObjectViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            LootObjects_0,
            LootObjects_1,
            LootObjects_2,
            LootObjects_3,
            LootObjects_4,
            LootObjects_5,
            LootObjects_6,
            LootObjects_7,
            LootObjects_8,
            LootObjects_9,
            LootObjects_10,
            LootObjects_11,
            LootObjects_12,
            LootObjects_13,
            LootObjects_14,
            LootObjects_15,
            LootObjects_16,
            LootObjects_17,
            LootObjects_18,
            LootObjects_19,
            LootObjects_20,
            LootObjects_21,
            LootObjects_22,
            LootObjects_23,
        }

        public byte[] Bitfield;

        public LootObject? LootObjects_0;
        public LootObject? LootObjects_1;
        public LootObject? LootObjects_2;
        public LootObject? LootObjects_3;
        public LootObject? LootObjects_4;
        public LootObject? LootObjects_5;
        public LootObject? LootObjects_6;
        public LootObject? LootObjects_7;
        public LootObject? LootObjects_8;
        public LootObject? LootObjects_9;
        public LootObject? LootObjects_10;
        public LootObject? LootObjects_11;
        public LootObject? LootObjects_12;
        public LootObject? LootObjects_13;
        public LootObject? LootObjects_14;
        public LootObject? LootObjects_15;
        public LootObject? LootObjects_16;
        public LootObject? LootObjects_17;
        public LootObject? LootObjects_18;
        public LootObject? LootObjects_19;
        public LootObject? LootObjects_20;
        public LootObject? LootObjects_21;
        public LootObject? LootObjects_22;
        public LootObject? LootObjects_23;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
            
            if (true) {
                Bitfield = Stream.Read.BitArray(24);

                if (Bitfield[(int)BitfieldIndex.LootObjects_0] == 0)
                {
                    LootObjects_0 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_1] == 0)
                {
                    LootObjects_1 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_2] == 0)
                {
                    LootObjects_2 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_3] == 0)
                {
                    LootObjects_3 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_4] == 0)
                {
                    LootObjects_4 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_5] == 0)
                {
                    LootObjects_5 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_6] == 0)
                {
                    LootObjects_6 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_7] == 0)
                {
                    LootObjects_7 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_8] == 0)
                {
                    LootObjects_8 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_9] == 0)
                {
                    LootObjects_9 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_10] == 0)
                {
                    LootObjects_10 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_11] == 0)
                {
                    LootObjects_11 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_12] == 0)
                {
                    LootObjects_12 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_13] == 0)
                {
                    LootObjects_13 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_14] == 0)
                {
                    LootObjects_14 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_15] == 0)
                {
                    LootObjects_15 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_16] == 0)
                {
                    LootObjects_16 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_17] == 0)
                {
                    LootObjects_17 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_18] == 0)
                {
                    LootObjects_18 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_19] == 0)
                {
                    LootObjects_19 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_20] == 0)
                {
                    LootObjects_20 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_21] == 0)
                {
                    LootObjects_21 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_22] == 0)
                {
                    LootObjects_22 = Stream.Read.LootObject();
                }

                if (Bitfield[(int)BitfieldIndex.LootObjects_23] == 0)
                {
                    LootObjects_23 = Stream.Read.LootObject();
                }
            }
        }
    }

    public struct LootObject
    {
        public uint Time;
        public byte HaveEntity;
        public string Entity;
        public byte HaveHostility;
        public byte[] Hostility;
        public byte[] Unk4;
        public float[] Position;
        public uint LootSdbId;
        public uint Quantity;
        public byte[] Unk5;

        public LootObject(Bitter.BinaryReader R)
        {
            Time = R.UInt();

            HaveEntity = R.Byte();
            if (HaveEntity == 1)
            {
                Entity = R.Entity();
            }
            else {
                Entity = "None";
            }

            HaveHostility = R.Byte(); // Feel like this should be Hostility, but I didn't expect 2 bytes from it.
            if (HaveHostility == 1) {
                Hostility = R.ByteArray(2);
            }
            else {
                Hostility = null;
            }

            Unk4 = R.ByteArray(6); // A direction in halfs?

            Position = R.FloatArray(3);

            LootSdbId = R.UInt();
            Quantity = R.UInt();

            Unk5 = R.ByteArray(8); // A rotation in halfs, a scopebubble, or a guid?
        }

        public override string ToString() => $"Loot: {LootSdbId}, Quantity: {Quantity}, Entity: {Entity},{(Hostility != null ? $" Hostility: [{String.Join(", ", Hostility)}]," : "")} Unk4: [{(Unk4 != null ? String.Join(", ", Unk4) : "null")}], Position: [{(Position != null ? String.Join(", ", Position) : "null")}], Unk5: [{(Unk5 != null ? String.Join(", ", Unk5) : "null")}], Time: {Time}";
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

        public static LootObject LootObject(this Bitter.BinaryReader R)
        {
            return new LootObject(R);
        }

        public static LootObject[] LootObjectArray(this Bitter.BinaryReader R, int num)
        {
            List<LootObject> list = new List<LootObject>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.LootObject());
            }
            return list.ToArray();
        }
    }
}