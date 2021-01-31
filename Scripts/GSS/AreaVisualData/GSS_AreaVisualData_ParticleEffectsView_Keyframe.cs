using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 21, 3, true)]
    public class AreaVisualDataParticleEffectsViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            ParticleEffects_0,
            ParticleEffects_1,
            ParticleEffects_2,
            ParticleEffects_3,
            ParticleEffects_4,
            ParticleEffects_5,
            ParticleEffects_6,
            ParticleEffects_7,
            ParticleEffects_8,
            ParticleEffects_9,
            ParticleEffects_10,
            ParticleEffects_11,
            ParticleEffects_12,
            ParticleEffects_13,
            ParticleEffects_14,
            ParticleEffects_15,
            ParticleEffects_16,
            ParticleEffects_17,
            ParticleEffects_18,
            ParticleEffects_19,
        }

        // Just quickly scoping this out
        public byte[] Bitfield;

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
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Bitfield = Stream.Read.BitArray(24); // Since only 20 bitfields should be only 3 bytes here 
                
            if (Bitfield[(int)BitfieldIndex.ParticleEffects_0] == 0)
                ParticleEffects_0 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_1] == 0)
                ParticleEffects_1 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_2] == 0)
                ParticleEffects_2 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_3] == 0)
                ParticleEffects_3 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_4] == 0)
                ParticleEffects_4 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_5] == 0)
                ParticleEffects_5 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_6] == 0)
                ParticleEffects_6 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_7] == 0)
                ParticleEffects_7 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_8] == 0)
                ParticleEffects_8 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_9] == 0)
                ParticleEffects_9 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_10] == 0)
                ParticleEffects_10 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_11] == 0)
                ParticleEffects_11 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_12] == 0)
                ParticleEffects_12 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_13] == 0)
                ParticleEffects_13 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_14] == 0)
                ParticleEffects_14 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_15] == 0)
                ParticleEffects_15 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_16] == 0)
                ParticleEffects_16 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_17] == 0)
                ParticleEffects_17 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_18] == 0)
                ParticleEffects_18 = Stream.Read.ParticleEffect();

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_19] == 0)
                ParticleEffects_19 = Stream.Read.ParticleEffect();

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