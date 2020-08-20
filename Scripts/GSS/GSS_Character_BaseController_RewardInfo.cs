using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 88, true)]
    public class CharacterBaseControllerRewardInfo : BaseScript
    {
        
        public byte RewardType;
        public byte Bonus_RewardType; // Uncertain about this
        public byte[] RelatedEntity;
        public uint Unk_RewardValue; // Not the value that is displayed?
        public byte[] Unk3;
        public uint Bonus_RewardValue; // Matches expectations

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            RewardType = Stream.Read.Byte();
            Bonus_RewardType = Stream.Read.Byte();
            RelatedEntity = Stream.Read.ByteArray(8);
            Unk_RewardValue = Stream.Read.UInt();
            Unk3 = Stream.Read.ByteArray(4);
            Bonus_RewardValue = Stream.Read.UInt();
        }

    }
}