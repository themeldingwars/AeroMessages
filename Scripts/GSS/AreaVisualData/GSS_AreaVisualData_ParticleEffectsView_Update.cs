using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct ParticleEffectsData
    {
        // No idea if this is right
        public byte[] Unk1;
        public byte[] Unk2;
        public float[] Position;

        public ParticleEffectsData(Bitter.BinaryReader R)
        {
            Unk1 = R.ByteArray(4);
            Unk2 = R.ByteArray(11);
            Position = R.FloatArray(3);
        }

        public override string ToString() => $"Position: [{(Position != null ? String.Join(", ", Position) : "null")}";
    }

    [Script(MessageType.GSS, 21, 1, true)]
    public class AreaVisualDataParticleEffectsViewUpdate : BaseScript
    {

        enum ShadowFieldIndex : byte
        {
            ParticleEffects_0 = 0x00,
            ParticleEffects_1 = 0x01,
            ParticleEffects_2 = 0x02,
            ParticleEffects_3 = 0x03,
            ParticleEffects_4 = 0x04,
            ParticleEffects_5 = 0x05,
            ParticleEffects_6 = 0x06,
            ParticleEffects_7 = 0x07,
            ParticleEffects_8 = 0x08,
            ParticleEffects_9 = 0x09,
            ParticleEffects_10 = 0x0a,
            ParticleEffects_11 = 0x0b,
            ParticleEffects_12 = 0x0c,
            ParticleEffects_13 = 0x0d,
            ParticleEffects_14 = 0x0e,
            ParticleEffects_15 = 0x0f,
            ParticleEffects_16 = 0x10,
            ParticleEffects_17 = 0x11,
            ParticleEffects_18 = 0x12,
            ParticleEffects_19 = 0x13,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public ParticleEffectsData? ParticleEffects_0;
        public ParticleEffectsData? ParticleEffects_1;
        public ParticleEffectsData? ParticleEffects_2;
        public ParticleEffectsData? ParticleEffects_3;
        public ParticleEffectsData? ParticleEffects_4;
        public ParticleEffectsData? ParticleEffects_5;
        public ParticleEffectsData? ParticleEffects_6;
        public ParticleEffectsData? ParticleEffects_7;
        public ParticleEffectsData? ParticleEffects_8;
        public ParticleEffectsData? ParticleEffects_9;
        public ParticleEffectsData? ParticleEffects_10;
        public ParticleEffectsData? ParticleEffects_11;
        public ParticleEffectsData? ParticleEffects_12;
        public ParticleEffectsData? ParticleEffects_13;
        public ParticleEffectsData? ParticleEffects_14;
        public ParticleEffectsData? ParticleEffects_15;
        public ParticleEffectsData? ParticleEffects_16;
        public ParticleEffectsData? ParticleEffects_17;
        public ParticleEffectsData? ParticleEffects_18;
        public ParticleEffectsData? ParticleEffects_19;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.ParticleEffects_0:
                        ParticleEffects_0 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_1:
                        ParticleEffects_1 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_2:
                        ParticleEffects_2 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_3:
                        ParticleEffects_3 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_4:
                        ParticleEffects_4 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_5:
                        ParticleEffects_5 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_6:
                        ParticleEffects_6 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_7:
                        ParticleEffects_7 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_8:
                        ParticleEffects_8 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_9:
                        ParticleEffects_9 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_10:
                        ParticleEffects_10 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_11:
                        ParticleEffects_11 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_12:
                        ParticleEffects_12 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_13:
                        ParticleEffects_13 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_14:
                        ParticleEffects_14 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_15:
                        ParticleEffects_15 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_16:
                        ParticleEffects_16 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_17:
                        ParticleEffects_17 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_18:
                        ParticleEffects_18 = Stream.Read.ParticleEffectsData();
                        break;
                    case ShadowFieldIndex.ParticleEffects_19:
                        ParticleEffects_19 = Stream.Read.ParticleEffectsData();
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

    }


    public static class MyExtensions
    {
        public static ParticleEffectsData ParticleEffectsData(this Bitter.BinaryReader R)
        {
            return new ParticleEffectsData(R);
        }

        public static ParticleEffectsData[] ParticleEffectsDataArray(this Bitter.BinaryReader R, int num)
        {
            List<ParticleEffectsData> list = new List<ParticleEffectsData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ParticleEffectsData());
            }
            return list.ToArray();
        }
    }
    
}