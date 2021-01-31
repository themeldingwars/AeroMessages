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
            MyExtensions.Stream = Stream;

            Bitfield = Stream.Read.BitArray(24); // Since only 20 bitfields should be only 3 bytes here 
                
            if (Bitfield[(int)BitfieldIndex.ParticleEffects_0] == 0)
            {
                ParticleEffects_0 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_1] == 0)
            {
                ParticleEffects_1 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_2] == 0)
            {
                ParticleEffects_2 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_3] == 0)
            {
                ParticleEffects_3 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_4] == 0)
            {
                ParticleEffects_4 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_5] == 0)
            {
                ParticleEffects_5 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_6] == 0)
            {
                ParticleEffects_6 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_7] == 0)
            {
                ParticleEffects_7 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_8] == 0)
            {
                ParticleEffects_8 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_9] == 0)
            {
                ParticleEffects_9 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_10] == 0)
            {
                ParticleEffects_10 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_11] == 0)
            {
                ParticleEffects_11 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_12] == 0)
            {
                ParticleEffects_12 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_13] == 0)
            {
                ParticleEffects_13 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_14] == 0)
            {
                ParticleEffects_14 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_15] == 0)
            {
                ParticleEffects_15 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_16] == 0)
            {
                ParticleEffects_16 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_17] == 0)
            {
                ParticleEffects_17 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_18] == 0)
            {
                ParticleEffects_18 = Stream.Read.ParticleEffect();
            }

            if (Bitfield[(int)BitfieldIndex.ParticleEffects_19] == 0)
            {
                ParticleEffects_19 = Stream.Read.ParticleEffect();
            }

        }
    }

    public struct ParticleEffect
    {
        public string SomeEntityId;
        public uint Unk2;
        public float[] Position;
        public byte[] Unk3;

        public ParticleEffect(Bitter.BinaryReader R)
        {
            SomeEntityId = R.Entity();
            Unk2 = R.UInt();
            Position = R.FloatArray(3);
            Unk3 = R.ByteArray(17);
        }

        string SafeRepr<T>(T[] arr)
        {
            return $"[{(arr != null ? String.Join(", ", arr) : "null")}]";
        }

        public override string ToString() => $"{SomeEntityId}, Unk2: {Unk2}, Position: {SafeRepr(Position)}, Unk3: {SafeRepr(Unk3)}";
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