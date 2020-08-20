using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 121, false)]
    public class CharacterCombatControllerFireWeaponProjectile : BaseScript
    {
        public uint Time;
        public float[] Aim; // Or at least usually very similar

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            Time = Stream.Read.UInt();
            Aim = Stream.Read.FloatArray(3);
        }
    }
}