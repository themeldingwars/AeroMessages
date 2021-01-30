using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 71, true)]
    public class GenericBountyActivationAck : BaseScript
    {

        public uint BountyId; // Unsure how this id works
        public byte[] Unk1;
        public uint MissionId; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk2;
        public string Name;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
    
            BountyId = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(7);
            MissionId = Stream.Read.UInt();
            Unk2 = Stream.Read.ByteArray(9);
            Name = Stream.Read.StringZ();
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;

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