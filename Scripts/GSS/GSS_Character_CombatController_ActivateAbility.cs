using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 134, false)]
    public class CharacterCombatControllerActivateAbility : BaseScript
    {
        public uint Time;
        public byte AbilitySlotIndex;

        public byte HaveTarget;
        public byte[] TargetEntity;
        public byte[] InitiatorEntity;
        public byte[] Unk_1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            AbilitySlotIndex = Stream.Read.Byte();

            HaveTarget = Stream.Read.Byte();

            if (HaveTarget != 0x00) {
                TargetEntity = Stream.Read.ByteArray(8);
                InitiatorEntity = Stream.Read.ByteArray(8);
                Unk_1 = Stream.Read.ByteArray(5);
            }


        }
    }
}