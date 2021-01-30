using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 20)]
    public class KeyframeRequest : BaseScript
    {
        public byte HaveRequestByEntityID;
        public byte NumRequestsByEntityID;
        public RequestByEntity[] EntityRequests;
        public byte HaveRequestByRefID;
        public byte NumRequestByRefID;
        public ushort[] RefRequests;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
           MyExtensions.Stream = Stream;
            
            HaveRequestByEntityID = Stream.Read.Byte();
            if (HaveRequestByEntityID == 1)
            {
                NumRequestsByEntityID = Stream.Read.Byte();
                EntityRequests = Stream.Read.EntityRequestArray(NumRequestsByEntityID);
            }

            HaveRequestByRefID = Stream.Read.Byte();
            if (HaveRequestByRefID == 1)
            {
                NumRequestByRefID = Stream.Read.Byte();
                RefRequests = Stream.Read.UShortArray(NumRequestByRefID);
            }
        }
    }

    public struct RequestByEntity
    {
        public string Entity;
        public ushort RefID;
        public byte Unk2;
        public uint Checksum;

        public RequestByEntity(Bitter.BinaryReader R)
        {
            Entity       = R.Entity();
            RefID        = R.UShort();
            Unk2         = R.Byte();
            Checksum     = R.UInt();
        }

        public override string ToString() => $"Entity: {Entity}, Ref: {RefID}, Unk: {Unk2}, Checksum: {Checksum}";
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

        public static RequestByEntity[] EntityRequestArray(this Bitter.BinaryReader R, int num)
        {
            List<RequestByEntity> list = new List<RequestByEntity>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(new RequestByEntity(R));
            }
            return list.ToArray();
        }
    }
}