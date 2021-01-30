using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 169, true)]
    public class CharacterBaseControllerChatPartyUpdate : BaseScript
    {
        public string Begin_Entity;
        public string Begin_Name;

        public byte[] Unk1;

        public byte NumberOfMembers;

        public string Member_01_Entity;
        public string Member_01_Name;
        public byte? Member_01_Unk;
        public string Member_02_Entity;
        public string Member_02_Name;
        public byte? Member_02_Unk;
        public string Member_03_Entity;
        public string Member_03_Name;
        public byte? Member_03_Unk;
        public string Member_04_Entity;
        public string Member_04_Name;
        public byte? Member_04_Unk;
        public string Member_05_Entity;
        public string Member_05_Name;
        public byte? Member_05_Unk;

        public string End_Entity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            Begin_Entity = Stream.Read.Entity();
            Begin_Name = Stream.Read.StringZ();

            Unk1 = Stream.Read.ByteArray(10);

            NumberOfMembers = Stream.Read.Byte();

            if (NumberOfMembers > 0)
            {
                Member_01_Entity = Stream.Read.Entity();
                Member_01_Name = Stream.Read.StringZ();
                Member_01_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 1)
            {
                Member_02_Entity = Stream.Read.Entity();
                Member_02_Name = Stream.Read.StringZ();
                Member_02_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 2)
            {
                Member_03_Entity = Stream.Read.Entity();
                Member_03_Name = Stream.Read.StringZ();
                Member_03_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 3)
            {
                Member_04_Entity = Stream.Read.Entity();
                Member_04_Name = Stream.Read.StringZ();
                Member_04_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 5)
            {
                Member_05_Entity = Stream.Read.Entity();
                Member_05_Name = Stream.Read.StringZ();
                Member_05_Unk = Stream.Read.Byte();
            }




            End_Entity = Stream.Read.Entity();
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