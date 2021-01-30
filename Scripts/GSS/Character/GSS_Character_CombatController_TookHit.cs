using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 105, true)]
    public class CharacterCombatControllerTookHit : BaseScript
    {
        
        // There are some variations of this message that don't include dealer entity.
        // DealtHit has similiar variations.
        // Maybe for fall dmg or similiar in this case.
        // If Unk_1_byte is not 1 then there won't be a dealer entity.`
        public byte Unk_1_byte;

        public string DealerEntity;

        public byte Unk_2_byte;

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

        public byte[] Unk_Type0;

        public ushort Unk_ShortTime;
        public byte[] Unk_4;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
            
            Unk_1_byte = Stream.Read.Byte();

            if (Unk_1_byte == 1)
            {
                DealerEntity = Stream.Read.Entity();

                Unk_2_byte = Stream.Read.Byte();

                DamageValue = Stream.Read.UInt();
                DamageType = Stream.Read.Byte(); // Just assuming its like DealtHit
                Unk_3_byte = Stream.Read.Byte(); // Just assuming its like DealtHit
                DamageFlags = Stream.Read.Byte(); // Just assuming its like DealtHit
            }
            else
            {
                Unk_Type0 = Stream.Read.ByteArray(2);
            }

            Unk_ShortTime = Stream.Read.UShort();
            Unk_4 = Stream.Read.ByteArray(1);
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