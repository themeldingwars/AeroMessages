using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 17)]
    public class Login : BaseScript
    {
        public byte Unk1;
        public int Unk2;
        public byte[] GUID;
        public ulong Unk3;
        public int Unk4;
        public int Unk5;
        public short Unk6;
        public byte Unk7;
        public byte Unk8;
        public byte Unk9;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

           Unk1 = Stream.Read.Byte();
           Unk2 = Stream.Read.Int();

           GUID = Stream.Read.ByteArray(10);

           Unk3 = Stream.Read.ULong();
           Unk4 = Stream.Read.Int();
           Unk5 = Stream.Read.Int();
           Unk6 = Stream.Read.Short();

           Unk7 = Stream.Read.Byte();
           Unk8 = Stream.Read.Byte();
           Unk9 = Stream.Read.Byte();
        }
    }
}