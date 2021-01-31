using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
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

            Clear_ParticleEffects_0 = 0x80,
            Clear_ParticleEffects_1 = 0x81,
            Clear_ParticleEffects_2 = 0x82,
            Clear_ParticleEffects_3 = 0x83,
            Clear_ParticleEffects_4 = 0x84,
            Clear_ParticleEffects_5 = 0x85,
            Clear_ParticleEffects_6 = 0x86,
            Clear_ParticleEffects_7 = 0x87,
            Clear_ParticleEffects_8 = 0x88,
            Clear_ParticleEffects_9 = 0x89,
            Clear_ParticleEffects_10 = 0x8a,
            Clear_ParticleEffects_11 = 0x8b,
            Clear_ParticleEffects_12 = 0x8c,
            Clear_ParticleEffects_13 = 0x8d,
            Clear_ParticleEffects_14 = 0x8e,
            Clear_ParticleEffects_15 = 0x8f,
            Clear_ParticleEffects_16 = 0x90,
            Clear_ParticleEffects_17 = 0x91,
            Clear_ParticleEffects_18 = 0x92,
            Clear_ParticleEffects_19 = 0x93,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public ParticleEffect? ParticleEffects_0;
        public ParticleEffect? ParticleEffects_1;
        public ParticleEffect? ParticleEffects_2;
        public ParticleEffect? ParticleEffects_3;
        public ParticleEffect? ParticleEffects_4;
        public ParticleEffect? ParticleEffects_5;
        public ParticleEffect? ParticleEffects_6;
        public ParticleEffect? ParticleEffects_7;
        public ParticleEffect? ParticleEffects_8;
        public ParticleEffect? ParticleEffects_9;
        public ParticleEffect? ParticleEffects_10;
        public ParticleEffect? ParticleEffects_11;
        public ParticleEffect? ParticleEffects_12;
        public ParticleEffect? ParticleEffects_13;
        public ParticleEffect? ParticleEffects_14;
        public ParticleEffect? ParticleEffects_15;
        public ParticleEffect? ParticleEffects_16;
        public ParticleEffect? ParticleEffects_17;
        public ParticleEffect? ParticleEffects_18;
        public ParticleEffect? ParticleEffects_19;

        public bool? Clear_ParticleEffects_0;
        public bool? Clear_ParticleEffects_1;
        public bool? Clear_ParticleEffects_2;
        public bool? Clear_ParticleEffects_3;
        public bool? Clear_ParticleEffects_4;
        public bool? Clear_ParticleEffects_5;
        public bool? Clear_ParticleEffects_6;
        public bool? Clear_ParticleEffects_7;
        public bool? Clear_ParticleEffects_8;
        public bool? Clear_ParticleEffects_9;
        public bool? Clear_ParticleEffects_10;
        public bool? Clear_ParticleEffects_11;
        public bool? Clear_ParticleEffects_12;
        public bool? Clear_ParticleEffects_13;
        public bool? Clear_ParticleEffects_14;
        public bool? Clear_ParticleEffects_15;
        public bool? Clear_ParticleEffects_16;
        public bool? Clear_ParticleEffects_17;
        public bool? Clear_ParticleEffects_18;
        public bool? Clear_ParticleEffects_19;

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
                        ParticleEffects_0 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_1:
                        ParticleEffects_1 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_2:
                        ParticleEffects_2 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_3:
                        ParticleEffects_3 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_4:
                        ParticleEffects_4 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_5:
                        ParticleEffects_5 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_6:
                        ParticleEffects_6 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_7:
                        ParticleEffects_7 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_8:
                        ParticleEffects_8 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_9:
                        ParticleEffects_9 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_10:
                        ParticleEffects_10 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_11:
                        ParticleEffects_11 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_12:
                        ParticleEffects_12 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_13:
                        ParticleEffects_13 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_14:
                        ParticleEffects_14 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_15:
                        ParticleEffects_15 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_16:
                        ParticleEffects_16 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_17:
                        ParticleEffects_17 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_18:
                        ParticleEffects_18 = Stream.Read.ParticleEffect();
                        break;
                    case ShadowFieldIndex.ParticleEffects_19:
                        ParticleEffects_19 = Stream.Read.ParticleEffect();
                        break;

                    case ShadowFieldIndex.Clear_ParticleEffects_0:
                        Clear_ParticleEffects_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_1:
                        Clear_ParticleEffects_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_2:
                        Clear_ParticleEffects_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_3:
                        Clear_ParticleEffects_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_4:
                        Clear_ParticleEffects_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_5:
                        Clear_ParticleEffects_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_6:
                        Clear_ParticleEffects_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_7:
                        Clear_ParticleEffects_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_8:
                        Clear_ParticleEffects_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_9:
                        Clear_ParticleEffects_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_10:
                        Clear_ParticleEffects_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_11:
                        Clear_ParticleEffects_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_12:
                        Clear_ParticleEffects_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_13:
                        Clear_ParticleEffects_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_14:
                        Clear_ParticleEffects_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_15:
                        Clear_ParticleEffects_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_16:
                        Clear_ParticleEffects_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_17:
                        Clear_ParticleEffects_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_18:
                        Clear_ParticleEffects_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_ParticleEffects_19:
                        Clear_ParticleEffects_19 = true;
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

    public struct ParticleEffect
    {
        public byte[] Unk2;
        public float[] Position;

        public ParticleEffect(Bitter.BinaryReader R)
        {
            Unk2 = R.ByteArray(12);
            Position = R.FloatArray(3);
        }

        public override string ToString() => $"Position: [{(Position != null ? String.Join(", ", Position) : "null")}";
    }


    public static class MyExtensions
    {
        public static ParticleEffect ParticleEffect(this Bitter.BinaryReader R)
        {
            return new ParticleEffect(R);
        }

        public static ParticleEffect[] ParticleEffectArray(this Bitter.BinaryReader R, int num)
        {
            List<ParticleEffect> list = new List<ParticleEffect>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ParticleEffect());
            }
            return list.ToArray();
        }
    }
    
}