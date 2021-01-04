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
        public ulong TargetEntityId;
        public byte[] InitiatorEntity;
        
        public byte[] Unk_1;

        public float[] Unk_2;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            AbilitySlotIndex = Stream.Read.Byte();

            HaveTarget = Stream.Read.Byte();

            if (HaveTarget != 0x00) {
                TargetEntity = Stream.Read.ByteArray(8);

                Stream.baseStream.ByteOffset -= 8;
                TargetEntityId = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;

                InitiatorEntity = Stream.Read.ByteArray(8);
                Unk_1 = Stream.Read.ByteArray(5);
            }
            else {
                Unk_2 = Stream.Read.FloatArray(3);
            }


        }
    }
}