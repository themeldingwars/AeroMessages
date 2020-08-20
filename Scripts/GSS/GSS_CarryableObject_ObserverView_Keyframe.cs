using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 3, true)]
    public class CarryableObjectObserverViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public uint CarryableTypeId; // Sdb table 480, id column.
        public byte Unk2;
        public float[] Position;
        public float[] MaybeRotation;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(8);
            CarryableTypeId = Stream.Read.UInt();
            Unk2 = Stream.Read.Byte();

            Position = Stream.Read.FloatArray(3);
            MaybeRotation = Stream.Read.FloatArray(4);
        }
    }
}