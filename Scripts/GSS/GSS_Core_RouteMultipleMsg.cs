using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 8, true)]
    public class CoreRouteMultipleMsg : BaseScript
    {
        //public byte[][] Packets = new byte[][256];
        public byte[] Msg1;
        public byte[] Msg2;
        public byte[] Msg3;
        public byte[] Msg4;
        public byte[] Msg5;
        public byte[] Msg6;
        public byte[] Msg7;
        public byte[] Msg8;
        public byte[] Msg9;
        public byte[] Msg10;
        public byte[] Msg11;
        public byte[] Msg12;
        public byte[] Msg13;
        public byte[] Msg14;
        public byte[] Msg15;
        public byte[] Msg16;
        public byte[] Msg17;
        public byte[] Msg18;
        public byte[] Msg19;
        public byte[] Msg20;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            int idx = 0;
           do 
           {
               int  len   = 0;
               byte byte1 = Stream.Read.Byte();

               if (((byte1 & 0x80) >> 7) == 1)
               {
                   byte byte2 = Stream.Read.Byte();
                        len   = byte2 | (byte1 ^ 0x80) << 8;
               }
               else
               {
                   len = byte1;
               }

                switch (idx++)
                {
                    case 0: Msg1   = Stream.Read.ByteArray(len); break;
                    case 1: Msg2   = Stream.Read.ByteArray(len); break;
                    case 2: Msg3   = Stream.Read.ByteArray(len); break;
                    case 3: Msg4   = Stream.Read.ByteArray(len); break;
                    case 4: Msg5   = Stream.Read.ByteArray(len); break;
                    case 5: Msg6   = Stream.Read.ByteArray(len); break;
                    case 6: Msg7   = Stream.Read.ByteArray(len); break;
                    case 7: Msg8   = Stream.Read.ByteArray(len); break;
                    case 8: Msg9   = Stream.Read.ByteArray(len); break;
                    case 9: Msg10  = Stream.Read.ByteArray(len); break;
                    case 10: Msg11 = Stream.Read.ByteArray(len); break;
                    case 11: Msg12 = Stream.Read.ByteArray(len); break;
                    case 12: Msg13 = Stream.Read.ByteArray(len); break;
                    case 13: Msg14 = Stream.Read.ByteArray(len); break;
                    case 14: Msg15 = Stream.Read.ByteArray(len); break;
                    case 15: Msg16 = Stream.Read.ByteArray(len); break;
                    case 16: Msg17 = Stream.Read.ByteArray(len); break;
                    case 17: Msg18 = Stream.Read.ByteArray(len); break;
                    case 18: Msg19 = Stream.Read.ByteArray(len); break;
                    case 19: Msg20 = Stream.Read.ByteArray(len); break;
                }
           } while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }
    }
}