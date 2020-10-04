using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 123, true)]
    public class CharacterCombatControllerAddOrUpdateInteractives : BaseScript
    {
        public byte NumberOfEntities;
        public byte[] Entity1;
        public byte[] Entity2;
        public byte[] Entity3;
        public byte[] Entity4;
        public byte[] Entity5;

        public byte NumberOfInteractionTypes;
        public byte? InteractionType1;
        public byte? InteractionType2;
        public byte? InteractionType3;
        public byte? InteractionType4;
        public byte? InteractionType5;

        public byte NumberOfInteractionDurationMs;
        public uint? InteractionDurationMs1;
        public uint? InteractionDurationMs2;
        public uint? InteractionDurationMs3;
        public uint? InteractionDurationMs4;
        public uint? InteractionDurationMs5;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            if (true) {
                NumberOfEntities = Stream.Read.Byte();
                if (NumberOfEntities > 0) {
                    Entity1 = Stream.Read.ByteArray(8);
                }
                if (NumberOfEntities > 1) {
                    Entity2 = Stream.Read.ByteArray(8);
                }
                if (NumberOfEntities > 2) {
                    Entity3 = Stream.Read.ByteArray(8);
                }
                if (NumberOfEntities > 3) {
                    Entity4 = Stream.Read.ByteArray(8);
                }
                if (NumberOfEntities > 4) {
                    Entity5 = Stream.Read.ByteArray(8);
                }

                NumberOfInteractionTypes = Stream.Read.Byte();
                if (NumberOfInteractionTypes > 0) {
                    InteractionType1 = Stream.Read.Byte();
                }
                if (NumberOfInteractionTypes > 1) {
                    InteractionType2 = Stream.Read.Byte();
                }
                if (NumberOfInteractionTypes > 2) {
                    InteractionType3 = Stream.Read.Byte();
                }
                if (NumberOfInteractionTypes > 3) {
                    InteractionType4 = Stream.Read.Byte();
                }
                if (NumberOfInteractionTypes > 4) {
                    InteractionType5 = Stream.Read.Byte();
                }

                NumberOfInteractionDurationMs = Stream.Read.Byte();
                if (NumberOfInteractionDurationMs > 0) {
                    InteractionDurationMs1 = Stream.Read.UInt();
                }
                if (NumberOfInteractionDurationMs > 1) {
                    InteractionDurationMs2 = Stream.Read.UInt();
                }
                if (NumberOfInteractionDurationMs > 2) {
                    InteractionDurationMs3 = Stream.Read.UInt();
                }
                if (NumberOfInteractionDurationMs > 3) {
                    InteractionDurationMs4 = Stream.Read.UInt();
                }
                if (NumberOfInteractionDurationMs > 4) {
                    InteractionDurationMs5 = Stream.Read.UInt();
                }
            }
        }
    }
}