using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 48, true)]
    public class GenericTempConsoleMessage : BaseScript
    {
        public string ConsoleCommand;
        public string ChatNotification;
        public string ConsoleNoticeMessage;
        public string DebugReportArgType;
        public ushort DebugReportArgDataLength;
        public string DebugReportArgData;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            ConsoleCommand = Stream.Read.StringZ();
            ChatNotification = Stream.Read.StringZ();
            ConsoleNoticeMessage = Stream.Read.StringZ();

            DebugReportArgType = Stream.Read.StringZ();

            DebugReportArgDataLength = Stream.Read.UShort();
            DebugReportArgData = Stream.Read.String(DebugReportArgDataLength);
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