using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 118, false)]
    public class CharacterCombatControllerFireBurst : BaseScript
    {
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
        }
    }
}