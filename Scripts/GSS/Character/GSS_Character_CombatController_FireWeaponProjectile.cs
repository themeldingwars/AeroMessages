using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 121, false)]
    public class CharacterCombatControllerFireWeaponProjectile : BaseScript
    {
        public uint Time;
        public ushort ShortTime; // Not part of the message, just for viewing purposes.
        public float[] AimDirection;
        public byte Unk_Always0;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            ShortTime = Stream.Read.UShort();
            Stream.baseStream.ByteOffset -= 2;
            Time = Stream.Read.UInt();
            AimDirection = Stream.Read.FloatArray(3);
            Unk_Always0 = Stream.Read.Byte();
        }
    }
}