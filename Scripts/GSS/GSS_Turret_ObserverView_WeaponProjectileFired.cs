using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 83, true)]
    public class TurretObserverViewProjectileFired : BaseScript
    {
        public uint Time;
        public float[] Aim;
        public byte Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            Time = Stream.Read.UInt();
            Aim = Stream.Read.FloatArray(3);
            Unk = Stream.Read.Byte();
        }
    }
}