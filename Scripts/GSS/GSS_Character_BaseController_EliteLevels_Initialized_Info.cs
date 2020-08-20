using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 193, true)]
    public class CharacterBaseControllerEliteLevelsInitializedInfo : BaseScript
    {
        // need to verify
        public uint Var1; // award_frame_min_level
        public uint Var2; // levels_per_rare
        public uint Var3; // revert_cost
        public uint Var4; // reroll_cost

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Var1 = Stream.Read.UInt();
            Var2 = Stream.Read.UInt();
            Var3 = Stream.Read.UInt();
            Var4 = Stream.Read.UInt();
        }
    }
}