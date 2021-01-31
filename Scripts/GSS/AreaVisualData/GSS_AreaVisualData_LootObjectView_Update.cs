using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 24, 1, true)]
    public class AreaVisualDataLootObjectViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            LootObjects_0 = 0x00,
            LootObjects_1 = 0x01,
            LootObjects_2 = 0x02,
            LootObjects_3 = 0x03,
            LootObjects_4 = 0x04,
            LootObjects_5 = 0x05,
            LootObjects_6 = 0x06,
            LootObjects_7 = 0x07,
            LootObjects_8 = 0x08,
            LootObjects_9 = 0x09,
            LootObjects_10 = 0x0a,
            LootObjects_11 = 0x0b,
            LootObjects_12 = 0x0c,
            LootObjects_13 = 0x0d,
            LootObjects_14 = 0x0e,
            LootObjects_15 = 0x0f,
            LootObjects_16 = 0x10,
            LootObjects_17 = 0x11,
            LootObjects_18 = 0x12,
            LootObjects_19 = 0x13,
            LootObjects_20 = 0x14,
            LootObjects_21 = 0x15,
            LootObjects_22 = 0x16,
            LootObjects_23 = 0x17,
            
            Clear_LootObjects_0  = 0x80,
            Clear_LootObjects_1  = 0x81,
            Clear_LootObjects_2  = 0x82,
            Clear_LootObjects_3  = 0x83,
            Clear_LootObjects_4  = 0x84,
            Clear_LootObjects_5  = 0x85,
            Clear_LootObjects_6  = 0x86,
            Clear_LootObjects_7  = 0x87,
            Clear_LootObjects_8  = 0x88,
            Clear_LootObjects_9  = 0x89,
            Clear_LootObjects_10 = 0x8a,
            Clear_LootObjects_11 = 0x8b,
            Clear_LootObjects_12 = 0x8c,
            Clear_LootObjects_13 = 0x8d,
            Clear_LootObjects_14 = 0x8e,
            Clear_LootObjects_15 = 0x8f,
            Clear_LootObjects_16 = 0x90,
            Clear_LootObjects_17 = 0x91,
            Clear_LootObjects_18 = 0x92,
            Clear_LootObjects_19 = 0x93,
            Clear_LootObjects_20 = 0x94,
            Clear_LootObjects_21 = 0x95,
            Clear_LootObjects_22 = 0x96,
            Clear_LootObjects_23 = 0x97,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

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

        public bool? Clear_LootObjects_0;
        public bool? Clear_LootObjects_1;
        public bool? Clear_LootObjects_2;
        public bool? Clear_LootObjects_3;
        public bool? Clear_LootObjects_4;
        public bool? Clear_LootObjects_5;
        public bool? Clear_LootObjects_6;
        public bool? Clear_LootObjects_7;
        public bool? Clear_LootObjects_8;
        public bool? Clear_LootObjects_9;
        public bool? Clear_LootObjects_10;
        public bool? Clear_LootObjects_11;
        public bool? Clear_LootObjects_12;
        public bool? Clear_LootObjects_13;
        public bool? Clear_LootObjects_14;
        public bool? Clear_LootObjects_15;
        public bool? Clear_LootObjects_16;
        public bool? Clear_LootObjects_17;
        public bool? Clear_LootObjects_18;
        public bool? Clear_LootObjects_19;
        public bool? Clear_LootObjects_20;
        public bool? Clear_LootObjects_21;
        public bool? Clear_LootObjects_22;
        public bool? Clear_LootObjects_23;

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

                    case ShadowFieldIndex.LootObjects_0:
                        LootObjects_0 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_1:
                        LootObjects_1 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_2:
                        LootObjects_2 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_3:
                        LootObjects_3 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_4:
                        LootObjects_4 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_5:
                        LootObjects_5 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_6:
                        LootObjects_6 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_7:
                        LootObjects_7 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_8:
                        LootObjects_8 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_9:
                        LootObjects_9 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_10:
                        LootObjects_10 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_11:
                        LootObjects_11 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_12:
                        LootObjects_12 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_13:
                        LootObjects_13 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_14:
                        LootObjects_14 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_15:
                        LootObjects_15 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_16:
                        LootObjects_16 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_17:
                        LootObjects_17 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_18:
                        LootObjects_18 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_19:
                        LootObjects_19 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_20:
                        LootObjects_20 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_21:
                        LootObjects_21 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_22:
                        LootObjects_22 = Stream.Read.LootObject();
                        break;
                    case ShadowFieldIndex.LootObjects_23:
                        LootObjects_23 = Stream.Read.LootObject();
                        break;

                    case ShadowFieldIndex.Clear_LootObjects_0:
                        Clear_LootObjects_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_1:
                        Clear_LootObjects_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_2:
                        Clear_LootObjects_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_3:
                        Clear_LootObjects_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_4:
                        Clear_LootObjects_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_5:
                        Clear_LootObjects_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_6:
                        Clear_LootObjects_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_7:
                        Clear_LootObjects_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_8:
                        Clear_LootObjects_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_9:
                        Clear_LootObjects_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_10:
                        Clear_LootObjects_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_11:
                        Clear_LootObjects_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_12:
                        Clear_LootObjects_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_13:
                        Clear_LootObjects_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_14:
                        Clear_LootObjects_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_15:
                        Clear_LootObjects_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_16:
                        Clear_LootObjects_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_17:
                        Clear_LootObjects_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_18:
                        Clear_LootObjects_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_19:
                        Clear_LootObjects_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_20:
                        Clear_LootObjects_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_21:
                        Clear_LootObjects_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_22:
                        Clear_LootObjects_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_LootObjects_23:
                        Clear_LootObjects_23 = true;
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

    public struct LootObject
    {
        public uint Time1;
        public byte Unk2;
        public string Entity;
        public byte Unk3;
        public byte[] Unk4;
        public float[] Position;
        public uint LootSdbId;
        public uint Quantity;

        public LootObject(Bitter.BinaryReader R)
        {
            Time1 = R.UInt();

            Unk2 = R.Byte();
            if (Unk2 == 1)
            {
                Entity = R.Entity();
            }
            else {
                Entity = "None";
            }

            Unk3 = R.Byte();
            if (Unk3 == 1) {
                Unk4 = R.ByteArray(8);
            }
            else {
                Unk4 = R.ByteArray(6);
            }

            Position = R.FloatArray(3);

            LootSdbId = R.UInt();
            Quantity = R.UInt();
        }

        public override string ToString() => $"";
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