using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 125, false)]
    public class CharacterCombatControllerSelectWeapon : BaseScript
    {
        public uint Time;
        public byte SelectedWeaponIndex;
        public byte Unk3; // This is related to the selected weapon but idk what it is, maybe slot that we are selecting weapon for or something (not that we have multiple slots that are swappable?)

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            SelectedWeaponIndex = Stream.Read.Byte();
            Unk3 = Stream.Read.Byte();
        }
    }
}