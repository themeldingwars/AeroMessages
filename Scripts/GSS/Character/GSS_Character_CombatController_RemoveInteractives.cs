using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 124, true)]
    public class CharacterCombatControllerRemoveInteractives : BaseScript
    {
        public byte Unk1; // Presumably count
        public byte[] Entity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            Unk1 = Stream.Read.Byte();
            Entity = Stream.Read.ByteArray(8);
        }
    }
}