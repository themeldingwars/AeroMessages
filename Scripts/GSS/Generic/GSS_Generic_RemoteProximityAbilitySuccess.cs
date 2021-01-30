using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 21, false)]
    public class ServerGenericRemoteProximityAbilitySuccess : BaseScript
    {
        public string SourceEntity;
        public byte Unk;
        public uint ClientProximityCommandId;
        public byte NumberOfAffected;
        public string Entity1;
        public string Entity2;
        public string Entity3;
        public string Entity4;
        public string Entity5;
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
        
            SourceEntity = Stream.Read.Entity();
            Unk = Stream.Read.Byte();
            ClientProximityCommandId = Stream.Read.UInt();
            NumberOfAffected = Stream.Read.Byte();
            
            if (NumberOfAffected > 0) {
                Entity1 = Stream.Read.Entity();
            }
            if (NumberOfAffected > 1) {
                Entity2 = Stream.Read.Entity();
            }
            if (NumberOfAffected > 2) {
                Entity3 = Stream.Read.Entity();
            }
            if (NumberOfAffected > 3) {
                Entity4 = Stream.Read.Entity();
            }
            if (NumberOfAffected > 3) {
                Entity5 = Stream.Read.Entity();
            }
            
            Time = Stream.Read.UInt();
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