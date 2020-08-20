using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 90, false)]
    public class VehicleBaseControllerSetEffectsFlag : BaseScript
    {
        public byte UnkByte1; // Not sure if this indicates the flag being toggled or if it's something that can be toggled in general.
        public byte UnkByte2_HeadlightEnabled; // At least when UnkByte1 is 0x01, this value is 0x00 if the headlights are turned off and 0x01 when turned on

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            UnkByte1 = Stream.Read.Byte();
            UnkByte2_HeadlightEnabled = Stream.Read.Byte();
        }
    }
}