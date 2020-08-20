using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 115, false)]
    public class CharacterBaseControllerMovementInput : BaseScript
    {
        public ushort ShortTime;
        public byte Unk2;
        public byte Unk3;
        public short Unk4;
        public short Unk5;
        public byte Unk6;

        // Movement state
        public ushort MovementUnk1;
        public byte MovementType;
        public byte MovementUnk3;

        public float[] MovementType1_Position;
        public float[] MovementType1_Rotation;
        public short MovementType1_State;

        public float[] Velocity;

        public float[] MovementType2_AimDirection;

        public ushort MovementUnk5; // Jetpack Energy related
        public short GroundTimePositiveAirTimeNegative;
        public short TimeSinceLastJump;

        public ushort EndShort;
        //public byte EndByte;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            ShortTime = Stream.Read.UShort();
            Unk2 = Stream.Read.Byte();
            Unk3 = Stream.Read.Byte();

            Unk4 = Stream.Read.Short();
            Unk5 = Stream.Read.Short();
            Unk6 = Stream.Read.Byte();

            MovementUnk1 = Stream.Read.UShort();
            MovementType = Stream.Read.Byte();
            MovementUnk3 = Stream.Read.Byte();

            if ((MovementType & 1) == 1)
            {
                MovementType1_Position = Stream.Read.FloatArray(3);
                MovementType1_Rotation = Stream.Read.FloatArray(4);
                MovementType1_State = Stream.Read.Short();
            }

            Velocity = Stream.Read.FloatArray(3);

            if ((MovementType & 2) >> 1 == 1)
            {
                MovementType2_AimDirection = Stream.Read.FloatArray(3);
            }

            MovementUnk5 = Stream.Read.UShort();
            GroundTimePositiveAirTimeNegative = Stream.Read.Short(); // Millis
            TimeSinceLastJump = Stream.Read.Short(); // Millis

            EndShort = Stream.Read.UShort();
            //EndByte = Stream.Read.Byte();
        }
    }
}