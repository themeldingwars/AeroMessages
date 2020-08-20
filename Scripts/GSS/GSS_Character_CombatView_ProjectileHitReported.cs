using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 97, true)]
    public class CharacterCombatViewProjectileHitReported : BaseScript
    {
        public byte[] Unk1;
        public ushort ShortTime;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(2);
            ShortTime = Stream.Read.UShort();
        }
    }
}