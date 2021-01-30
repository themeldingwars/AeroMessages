using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 107, true)]
    public class CharacterCombatControllerDealtHit : BaseScript
    {
        // There are some variations of this message that don't include target and/or dealer entity and I don't know how to parse those yet.
        // TookHit has similiar variation.
        // If Unk_1_byte is not 1 then there won't be a target entity and similiar to Unk_2_byte if Unk_1_byte is 1.

        public byte Unk_1_byte;

        public string TargetEntity;

        public byte Unk_2_byte;

        public string DealerEntity;

        public uint DamageValue;
        public byte DamageType; // Sdb table 330, id column
        public byte Unk_3_byte;

        // Damage Response Flags
        // 1 - Critical
        // 2 - ???
        // 4 - Effective
        // 8 - Resisted
        // (Effective+Resisted => Immune)
        public byte DamageFlags;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            Unk_1_byte = Stream.Read.Byte();

            if (Unk_1_byte == 1)
            {
                TargetEntity = Stream.Read.Entity();

                Unk_2_byte = Stream.Read.Byte();
                if (Unk_2_byte == 1)
                {
                    DealerEntity = Stream.Read.Entity();

                    DamageValue = Stream.Read.UInt();
                    DamageType = Stream.Read.Byte();
                    Unk_3_byte = Stream.Read.Byte();
                    DamageFlags = Stream.Read.Byte();
                }
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