using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct TinyObjectData
    {
        public ushort TypeId; // SDB Table 152
        public float[] Position;
        public byte[] Faction;

        public TinyObjectData(Bitter.BinaryReader R)
        {
            TypeId = R.UShort();
            Position = R.FloatArray(3);
            Faction = R.ByteArray(2);
        }

        public override string ToString() => $"TypeId: {TypeId}, Position: [{(Position != null ? String.Join(", ", Position) : "null")}, Faction: [{(Faction != null ? String.Join(", ", Faction) : "null")}]";
    }

    [Script(MessageType.GSS, 13, 1, true)]
    public class CharacterTinyObjectViewUpdate : BaseScript
    {

        enum ShadowFieldIndex : byte
        {
            TinyObject_00_Create = 0x00,
            TinyObject_01_Create = 0x01,
            TinyObject_02_Create = 0x02,
            TinyObject_03_Create = 0x03,
            TinyObject_04_Create = 0x04,
            TinyObject_05_Create = 0x05,
            TinyObject_06_Create = 0x06,
            TinyObject_07_Create = 0x07,
            TinyObject_08_Create = 0x08,
            TinyObject_09_Create = 0x09,
            TinyObject_0a_Create = 0x0a,
            TinyObject_0b_Create = 0x0b,
            TinyObject_0c_Create = 0x0c,
            TinyObject_0d_Create = 0x0d,
            TinyObject_0e_Create = 0x0e,
            TinyObject_0f_Create = 0x0f,
            TinyObject_10_Create = 0x10,
            TinyObject_11_Create = 0x11,
            TinyObject_12_Create = 0x12,
            TinyObject_13_Create = 0x13,
            TinyObject_14_Create = 0x14,
            TinyObject_15_Create = 0x15,
            TinyObject_16_Create = 0x16,
            TinyObject_17_Create = 0x17,
            TinyObject_18_Create = 0x18,
            TinyObject_19_Create = 0x19,
            TinyObject_1a_Create = 0x1a,
            TinyObject_1b_Create = 0x1b,
            TinyObject_1c_Create = 0x1c,
            TinyObject_1d_Create = 0x1d,
            TinyObject_1e_Create = 0x1e,
            TinyObject_1f_Create = 0x1f,

            TinyObject_00_Remove = 0x80,
            TinyObject_01_Remove = 0x81,
            TinyObject_02_Remove = 0x82,
            TinyObject_03_Remove = 0x83,
            TinyObject_04_Remove = 0x84,
            TinyObject_05_Remove = 0x85,
            TinyObject_06_Remove = 0x86,
            TinyObject_07_Remove = 0x87,
            TinyObject_08_Remove = 0x88,
            TinyObject_09_Remove = 0x89,
            TinyObject_0a_Remove = 0x8a,
            TinyObject_0b_Remove = 0x8b,
            TinyObject_0c_Remove = 0x8c,
            TinyObject_0d_Remove = 0x8d,
            TinyObject_0e_Remove = 0x8e,
            TinyObject_0f_Remove = 0x8f,
            TinyObject_10_Remove = 0x90,
            TinyObject_11_Remove = 0x91,
            TinyObject_12_Remove = 0x92,
            TinyObject_13_Remove = 0x93,
            TinyObject_14_Remove = 0x94,
            TinyObject_15_Remove = 0x95,
            TinyObject_16_Remove = 0x96,
            TinyObject_17_Remove = 0x97,
            TinyObject_18_Remove = 0x98,
            TinyObject_19_Remove = 0x99,
            TinyObject_1a_Remove = 0x9a,
            TinyObject_1b_Remove = 0x9b,
            TinyObject_1c_Remove = 0x9c,
            TinyObject_1d_Remove = 0x9d,
            TinyObject_1e_Remove = 0x9e,
            TinyObject_1f_Remove = 0x9f,
        }

        public TinyObjectData? TinyObject_00_Create;
        public TinyObjectData? TinyObject_01_Create;
        public TinyObjectData? TinyObject_02_Create;
        public TinyObjectData? TinyObject_03_Create;
        public TinyObjectData? TinyObject_04_Create;
        public TinyObjectData? TinyObject_05_Create;
        public TinyObjectData? TinyObject_06_Create;
        public TinyObjectData? TinyObject_07_Create;
        public TinyObjectData? TinyObject_08_Create;
        public TinyObjectData? TinyObject_09_Create;
        public TinyObjectData? TinyObject_0a_Create;
        public TinyObjectData? TinyObject_0b_Create;
        public TinyObjectData? TinyObject_0c_Create;
        public TinyObjectData? TinyObject_0d_Create;
        public TinyObjectData? TinyObject_0e_Create;
        public TinyObjectData? TinyObject_0f_Create;
        public TinyObjectData? TinyObject_10_Create;
        public TinyObjectData? TinyObject_11_Create;
        public TinyObjectData? TinyObject_12_Create;
        public TinyObjectData? TinyObject_13_Create;
        public TinyObjectData? TinyObject_14_Create;
        public TinyObjectData? TinyObject_15_Create;
        public TinyObjectData? TinyObject_16_Create;
        public TinyObjectData? TinyObject_17_Create;
        public TinyObjectData? TinyObject_18_Create;
        public TinyObjectData? TinyObject_19_Create;
        public TinyObjectData? TinyObject_1a_Create;
        public TinyObjectData? TinyObject_1b_Create;
        public TinyObjectData? TinyObject_1c_Create;
        public TinyObjectData? TinyObject_1d_Create;
        public TinyObjectData? TinyObject_1e_Create;
        public TinyObjectData? TinyObject_1f_Create;

        public bool? TinyObject_00_Remove;
        public bool? TinyObject_01_Remove;
        public bool? TinyObject_02_Remove;
        public bool? TinyObject_03_Remove;
        public bool? TinyObject_04_Remove;
        public bool? TinyObject_05_Remove;
        public bool? TinyObject_06_Remove;
        public bool? TinyObject_07_Remove;
        public bool? TinyObject_08_Remove;
        public bool? TinyObject_09_Remove;
        public bool? TinyObject_0a_Remove;
        public bool? TinyObject_0b_Remove;
        public bool? TinyObject_0c_Remove;
        public bool? TinyObject_0d_Remove;
        public bool? TinyObject_0e_Remove;
        public bool? TinyObject_0f_Remove;
        public bool? TinyObject_10_Remove;
        public bool? TinyObject_11_Remove;
        public bool? TinyObject_12_Remove;
        public bool? TinyObject_13_Remove;
        public bool? TinyObject_14_Remove;
        public bool? TinyObject_15_Remove;
        public bool? TinyObject_16_Remove;
        public bool? TinyObject_17_Remove;
        public bool? TinyObject_18_Remove;
        public bool? TinyObject_19_Remove;
        public bool? TinyObject_1a_Remove;
        public bool? TinyObject_1b_Remove;
        public bool? TinyObject_1c_Remove;
        public bool? TinyObject_1d_Remove;
        public bool? TinyObject_1e_Remove;
        public bool? TinyObject_1f_Remove;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.TinyObject_00_Create:
                        TinyObject_00_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_01_Create:
                        TinyObject_01_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_02_Create:
                        TinyObject_02_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_03_Create:
                        TinyObject_03_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_04_Create:
                        TinyObject_04_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_05_Create:
                        TinyObject_05_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_06_Create:
                        TinyObject_06_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_07_Create:
                        TinyObject_07_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_08_Create:
                        TinyObject_08_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_09_Create:
                        TinyObject_09_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0a_Create:
                        TinyObject_0a_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0b_Create:
                        TinyObject_0b_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0c_Create:
                        TinyObject_0c_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0d_Create:
                        TinyObject_0d_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0e_Create:
                        TinyObject_0e_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_0f_Create:
                        TinyObject_0f_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_10_Create:
                        TinyObject_10_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_11_Create:
                        TinyObject_11_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_12_Create:
                        TinyObject_12_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_13_Create:
                        TinyObject_13_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_14_Create:
                        TinyObject_14_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_15_Create:
                        TinyObject_15_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_16_Create:
                        TinyObject_16_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_17_Create:
                        TinyObject_17_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_18_Create:
                        TinyObject_18_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_19_Create:
                        TinyObject_19_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1a_Create:
                        TinyObject_1a_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1b_Create:
                        TinyObject_1b_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1c_Create:
                        TinyObject_1c_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1d_Create:
                        TinyObject_1d_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1e_Create:
                        TinyObject_1e_Create = Stream.Read.TinyObjectData();
                        break;
                    case ShadowFieldIndex.TinyObject_1f_Create:
                        TinyObject_1f_Create = Stream.Read.TinyObjectData();
                        break;

                    case ShadowFieldIndex.TinyObject_00_Remove:
                        TinyObject_00_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_01_Remove:
                        TinyObject_01_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_02_Remove:
                        TinyObject_02_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_03_Remove:
                        TinyObject_03_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_04_Remove:
                        TinyObject_04_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_05_Remove:
                        TinyObject_05_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_06_Remove:
                        TinyObject_06_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_07_Remove:
                        TinyObject_07_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_08_Remove:
                        TinyObject_08_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_09_Remove:
                        TinyObject_09_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0a_Remove:
                        TinyObject_0a_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0b_Remove:
                        TinyObject_0b_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0c_Remove:
                        TinyObject_0c_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0d_Remove:
                        TinyObject_0d_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0e_Remove:
                        TinyObject_0e_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_0f_Remove:
                        TinyObject_0f_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_10_Remove:
                        TinyObject_10_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_11_Remove:
                        TinyObject_11_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_12_Remove:
                        TinyObject_12_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_13_Remove:
                        TinyObject_13_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_14_Remove:
                        TinyObject_14_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_15_Remove:
                        TinyObject_15_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_16_Remove:
                        TinyObject_16_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_17_Remove:
                        TinyObject_17_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_18_Remove:
                        TinyObject_18_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_19_Remove:
                        TinyObject_19_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1a_Remove:
                        TinyObject_1a_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1b_Remove:
                        TinyObject_1b_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1c_Remove:
                        TinyObject_1c_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1d_Remove:
                        TinyObject_1d_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1e_Remove:
                        TinyObject_1e_Remove = true;
                        break;
                    case ShadowFieldIndex.TinyObject_1f_Remove:
                        TinyObject_1f_Remove = true;
                        break;

                    default:
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
        public static TinyObjectData TinyObjectData(this Bitter.BinaryReader R)
        {
            return new TinyObjectData(R);
        }

        public static TinyObjectData[] TinyObjectDataArray(this Bitter.BinaryReader R, int num)
        {
            List<TinyObjectData> list = new List<TinyObjectData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.TinyObjectData());
            }
            return list.ToArray();
        }
    }
    
}