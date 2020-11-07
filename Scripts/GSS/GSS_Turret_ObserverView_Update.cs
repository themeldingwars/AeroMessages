using Bitter;
namespace PacketPeepScript
{
    // This pretty rough, not tested
    [Script(MessageType.GSS, 40, 1, true)]
    public class TurretObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Unk_0x03 = 0x03,
            Unk_0x04 = 0x04,
            Unk_0x05 = 0x05,
            Unk_0x06 = 0x06, // Maybe FireBurst
            Unk_0x07 = 0x07, // Maybe FireEnd

            Unk_0x0a = 0x0a, // Maybe Faction

            Unk_0x8b = 0x8b, // Some action/eventcall, no data
        }

        public byte[] Unk_0x03_Entity;
        public byte[] Unk_0x04;
        public uint? Unk_0x05;
        public uint? Unk_0x06_Time;
        public uint? Unk_0x07_Time;

        public byte[] Unk_0x0a_Faction;

        public bool? Unk_0x8b;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x03:
                        Unk_0x03_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Unk_0x04:
                        Unk_0x04 = Stream.Read.ByteArray(10);
                        break;
                    case ShadowFieldIndex.Unk_0x05:
                        Unk_0x05 = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x06:
                        Unk_0x06_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x07:
                        Unk_0x07_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x0a:
                        Unk_0x0a_Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x8b:
                        Unk_0x8b = true;
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}