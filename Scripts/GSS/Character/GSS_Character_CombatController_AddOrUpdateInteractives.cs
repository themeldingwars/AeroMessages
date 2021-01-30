using System.Collections.Generic;
using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 123, true)]
    public class CharacterCombatControllerAddOrUpdateInteractives : BaseScript
    {
        public byte NumberOfEntities;
        public MyExtensions.EntityRef[] Entities;

        public byte NumberOfInteractionTypes;
        public byte[] InteractionTypes;

        public byte NumberOfInteractionDurationMs;
        public uint[] InteractionDurationsMs;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
            
            if (true) {
                NumberOfEntities = Stream.Read.Byte();
                Entities = Stream.Read.EntityArray(NumberOfEntities);

                NumberOfInteractionTypes = Stream.Read.Byte();
                InteractionTypes = Stream.Read.ByteArray(NumberOfInteractionTypes);

                NumberOfInteractionDurationMs = Stream.Read.Byte();
                InteractionDurationsMs = Stream.Read.UIntArray(NumberOfInteractionDurationMs);
            }
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
        

        public enum Controller : byte
        {
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            Outpost = 0x2c,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
        }

        public struct EntityRef
        {
            public Controller Controller;
            public ulong Id;

            public EntityRef(Bitter.BinaryReader R)
            {
                Controller = (Controller) R.Byte();
                Stream.baseStream.ByteOffset--;
                Id = R.ULong() & 0xFFFFFFFFFFFFFF00;
            }

            public override string ToString() => $"{Controller}:{Id}";
        }

        public static EntityRef Entity(this Bitter.BinaryReader R)
        {
            return new EntityRef(R);
        }

        public static EntityRef[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<EntityRef> list = new List<EntityRef>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

        /*
        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            return $"{controller}:{id}";
        }
        */
        
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
        
        public static void SkipZeros(this Bitter.BinaryReader rdr)
        {
            byte b;
            do {
                b = rdr.Byte();
            } while( b == 0 );
            
            Stream.baseStream.ByteOffset--;
        }
    }
}