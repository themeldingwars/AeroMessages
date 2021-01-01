using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 114, true)]
    public class CharacterCombatControllerForcedMovementCancelled : BaseScript
    {
        public uint CommandId;
        public ushort ShortTime;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            CommandId = Stream.Read.UInt();
            ShortTime = Stream.Read.UShort();
        }
    }
}