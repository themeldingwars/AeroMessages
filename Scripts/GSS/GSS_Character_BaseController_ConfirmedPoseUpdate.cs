using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 111, true)]
    public class CharacterBaseControllerConfirmedPoseUpdate : BaseScript
    {
        public ushort ShortTime1;
        public byte Flags;
        public byte Unk3;

        public float[] Type1_Position;
        public float[] Type1_Rotation;
        public short Type1_MovementState;

        public float[] Velocity;

        public float[] Type2_Aim;

        public ushort Unk5; // Related to jumpjet energy. Rightmost byte appears equiv. to current jumpjet energy percent.
        public short GroundTimePositiveAirTimeNegative; // Counts upwards from 0 when on ground. Counts downwards (into the negative) from 0 when in the air.
        public short TimeSinceLastJump; // Sets to 0 when you jump from the ground.

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            ShortTime1  = Stream.Read.UShort();
            Flags = Stream.Read.Byte();
            Unk3  = Stream.Read.Byte();

            if ((Flags & 1) == 1)
            {
                Type1_Position = Stream.Read.FloatArray(3);
                Type1_Rotation = Stream.Read.FloatArray(4);
                Type1_MovementState = Stream.Read.Short();
            }

            Velocity = Stream.Read.FloatArray(3);

            if ((Flags & 2) >> 1 == 1)
            {
                Type2_Aim = Stream.Read.FloatArray(3);
            }

            Unk5 = Stream.Read.UShort();
            GroundTimePositiveAirTimeNegative = Stream.Read.Short();
            TimeSinceLastJump = Stream.Read.Short();
        }
    }
}