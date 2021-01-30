using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 89, false)]
    public class CharacterBaseControllerFetchQueueInfo : BaseScript
    {
        
        public byte NumberOfKeys;
        public string Key1;
        public string Key2;
        public string Key3;
        public string Key4;
        public string Key5;

        public byte[] Unk; // Last few bytes might be a level range

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            NumberOfKeys = Stream.Read.Byte();

            if (NumberOfKeys > 0) {
                Key1 = Stream.Read.StringZ();
            }
            if (NumberOfKeys > 1) {
                Key2 = Stream.Read.StringZ();
            }
            if (NumberOfKeys > 2) {
                Key3 = Stream.Read.StringZ();
            }
            if (NumberOfKeys > 3) {
                Key4 = Stream.Read.StringZ();
            }
            if (NumberOfKeys > 4) {
                Key5 = Stream.Read.StringZ();
            }

            Unk = Stream.Read.ByteArray(12);

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