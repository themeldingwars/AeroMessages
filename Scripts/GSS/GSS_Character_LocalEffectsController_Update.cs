using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 6, 1, true)]
    public class CharacterLocalEffectsControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Unk_0x00 = 0x00,
            Unk_0x01 = 0x01,
            Unk_0x80 = 0x80,
            Unk_0x81 = 0x81,
        }

        public byte[] Unk_0x00_Entity;
        public uint? Unk_0x00_Value;
        public uint? Unk_0x00_Time;

        public byte[] Unk_0x01_Entity;
        public uint? Unk_0x01_Value;
        public uint? Unk_0x01_Time;

        public bool? Unk_0x80; // Cancel for 0x00?
        public bool? Unk_0x81; // Cancel for 0x00?


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
                        Unk_0x00_Entity = Stream.Read.ByteArray(8);
                        Unk_0x00_Value = Stream.Read.UInt();
                        Unk_0x00_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x01:
                        Unk_0x01_Entity = Stream.Read.ByteArray(8);
                        Unk_0x01_Value = Stream.Read.UInt();
                        Unk_0x01_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x80:
                        Unk_0x80 = true;
                        break;

                    case ShadowFieldIndex.Unk_0x81:
                        Unk_0x81 = true;
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