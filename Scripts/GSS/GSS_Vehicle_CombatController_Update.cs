using Bitter;
namespace PacketPeepScript
{
    // Have some doubts about this as when looking at CombatView it looks irregular
    // leaving it because the pattern is still there
    [Script(MessageType.GSS, 28, 1, true)]
    public class VehicleCombatControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            Unk_0x00 = 0x00,
            Unk_0x22 = 0x22,
            Unk_0x40 = 0x40,
            Unk_0x41 = 0x41,
            Unk_0x42 = 0x42,
            Unk_0x43 = 0x43,
            Unk_0x44 = 0x44,
            Unk_0x45 = 0x45,
            Unk_0x46 = 0x46,
            Unk_0x47 = 0x47,
            Unk_0x48 = 0x48,
        }

        public ushort? Unk_0x00_ShortTime;
        public byte? Unk_0x00_Byte;

        public byte[] Unk_0x22_1;
        public byte[] Unk_0x22_2_Entity;
        public uint? Unk_0x22_3_Time;
        public byte? Unk_0x22_4;

        public byte[] Unk_0x40;
        public byte[] Unk_0x41;
        public byte[] Unk_0x42;
        public byte[] Unk_0x43;
        public byte[] Unk_0x44;
        public byte[] Unk_0x45;
        public byte[] Unk_0x46;
        public byte[] Unk_0x47;
        public byte[] Unk_0x48;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x00:
                        Unk_0x00_ShortTime = Stream.Read.UShort();
                        Unk_0x00_Byte = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x22:
                        Unk_0x22_1 = Stream.Read.ByteArray(4);
                        Unk_0x22_2_Entity = Stream.Read.ByteArray(8);
                        Unk_0x22_3_Time = Stream.Read.UInt();
                        Unk_0x22_4 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x40:
                        Unk_0x40 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x41:
                        Unk_0x41 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x42:
                        Unk_0x42 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x43:
                        Unk_0x43 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x44:
                        Unk_0x44 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x45:
                        Unk_0x45 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x46:
                        Unk_0x46 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x47:
                        Unk_0x47 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x48:
                        Unk_0x48 = Stream.Read.ByteArray(4);
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}