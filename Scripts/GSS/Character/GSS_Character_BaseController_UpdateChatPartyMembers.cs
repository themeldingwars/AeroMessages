using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 185, false)]
    public class CharacterBaseControllerUpdateChatPartyMembers : BaseScript
    {
        public byte[] Unk1;
        public string InvitedCharacterName;
        public byte Unk2; // I'm seeing 0b, it could be chat channel for squad
        public byte[] InvitingEntity;
        

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(9);

            InvitedCharacterName = Stream.Read.String(GetNullTerminatedStrSize(Stream));

            Unk2 = Stream.Read.Byte();

            InvitingEntity = Stream.Read.ByteArray(8);

        }

        // Reads until we find 0x00, then resets the head and returns the number of bytes read.
        private int GetNullTerminatedStrSize(Bitter.BinaryStream Stream)
        {
            long StartOffset = Stream.baseStream.ByteOffset;
            do
            {
                byte b = Stream.Read.Byte();
                if (b == 0x00)
                {
                    break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            long EndOffset = Stream.baseStream.ByteOffset;
            Stream.baseStream.ByteOffset = StartOffset;
            return (int)(EndOffset - StartOffset);
        }
    }
}