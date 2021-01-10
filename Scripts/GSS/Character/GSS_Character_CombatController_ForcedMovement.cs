using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 113, true)]
    public class CharacterCombatControllerForcedMovement : BaseScript
    {
        public byte Unk1_Flag;
        public byte[] Unk2;

        // Type 1
        public float[] Type1_Position;
        public float[] Type1_Direction; // These are a bit of an assumption
        public float[] Type1_Velocity; // These are a bit of an assumption
        public uint Type1_Time1;
        public ushort Type1_ShortTime1;

        // Type 5
        public float[] Type5_Velocity; // These are a bit of an assumption
        public uint Type5_Time1;
        public uint Type5_Time2;
        public byte Type5_Unk2;
        public ushort Type5_ShortTime1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1_Flag = Stream.Read.Byte();
            Unk2 = Stream.Read.ByteArray(5);

            if (Unk1_Flag == 0x01)
            {
                Type1_Position = Stream.Read.FloatArray(3);
                Type1_Direction = Stream.Read.FloatArray(3);
                Type1_Velocity = Stream.Read.FloatArray(3);
                Type1_Time1 = Stream.Read.UInt();
                Type1_ShortTime1 = Stream.Read.UShort();
            }
            else if (Unk1_Flag == 0x05)
            {
                Type5_Velocity = Stream.Read.FloatArray(3);
                Type5_Time1 = Stream.Read.UInt();
                Type5_Time2 = Stream.Read.UInt();
                Type5_Unk2 = Stream.Read.Byte();
                Type5_ShortTime1 = Stream.Read.UShort();
            }  
        }
    }
}