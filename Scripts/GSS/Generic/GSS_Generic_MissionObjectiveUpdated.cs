using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 64, true)]
    public class GenericMissionObjectiveUpdated : BaseScript
    {
        public uint MissionID; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk1;
        public string TextObjectiveTitle;
        public string TextObjectiveProgress;
        public byte[] Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            MissionID = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(8);
            TextObjectiveTitle = Stream.Read.StringZ();
            TextObjectiveProgress = Stream.Read.StringZ();
            Unk2 = Stream.Read.ByteArray(5);
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