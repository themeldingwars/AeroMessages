using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 150, true)]
    public class CharacterBaseControllerSalvageResponse : BaseScript
    {
        // Added script so that peep doesn't display the wrong stuff  

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

      
        }
    }
}