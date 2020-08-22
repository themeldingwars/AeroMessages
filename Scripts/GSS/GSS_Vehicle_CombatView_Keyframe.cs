using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 30, 3, true)]
    public class VehicleCombatViewKeyframe : BaseScript
    {
        public byte[] Unk1;

        // There is a variance in these based on the first 4 bytes
        // Bitfield for the status effect data probably.

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            Unk1 = Stream.Read.ByteArray(4);
        }
    }
}