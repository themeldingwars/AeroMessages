using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 24, 3, true)]
    public class AreaVisualDataLootObjectViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public uint Time1;
        public byte Unk2;
        public string Entity;
        public byte Unk3;
        public float[] Position;
        public uint LootSdbId;
        public uint Quantity;

        public byte[] Unk;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            if (true) {
                Unk1 = Stream.Read.ByteArray(3);
                Time1 = Stream.Read.UInt();

                Unk2 = Stream.Read.Byte();
                if (Unk2 == 1)
                {
                    Entity = Stream.Read.Entity();
                }

                Unk3 = Stream.Read.Byte();
                if (Unk3 == 1) {
                    Stream.baseStream.ByteOffset += 8;
                }
                else {
                    Stream.baseStream.ByteOffset += 6;
                }

                Position = Stream.Read.FloatArray(3);

                LootSdbId = Stream.Read.UInt();
                Quantity = Stream.Read.UInt();

                int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                Unk = Stream.Read.ByteArray(remaining);
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