using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 106, true)]
    public class GenericPlaySoundId : BaseScript
    {
        // Sdb table 14, record_id column?
        // Looks like there are variations of the message
        // Record id works for some messages but not all.
        public uint Id_UInt; 
        public ushort Id_UShort_1;
        public ushort Id_UShort_2;
        public byte[] Unk1;
        public byte[] Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            //SoundRecordId = Stream.Read.UInt();
            //
            
            Id_UInt = Stream.Read.UInt();
            Stream.baseStream.ByteOffset -= 4;
            Id_UShort_1 = Stream.Read.UShort();
            Id_UShort_2 = Stream.Read.UShort();

            Unk1 = Stream.Read.ByteArray(4);
            Unk2 = Stream.Read.ByteArray(8);
        }
    }
}