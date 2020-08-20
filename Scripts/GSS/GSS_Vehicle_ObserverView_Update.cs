using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 29, 1, true)]
    public class VehicleObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Unk_0x02 = 0x02,
            Unk_0x03 = 0x03, // Maybe Vehicle Enabled
            Unk_0x04 = 0x04,
            DriverSeat0_Entity = 0x08,
            PassengerSeat1_Entity = 0x09,
            PassengerSeat2_Entity = 0x0a,
            PassengerSeat3_Entity = 0x0b,
            PassengerSeat4_Entity = 0x0c,
            PassengerSeat5_Entity = 0x0d,
            Unk_0x18 = 0x18, // Not effect flags
            Unk_0x19 = 0x19, // 3rd byte sometimes counting down
            Faction = 0x1A, // 0x01, 0x01, could maybe be effect flags or faction
            Unk_0x1B = 0x1B, // 20 bytes of idk
            CurrentHealth = 0x1C,
            Unk_0x1D = 0x1D,
            Unk_0x23 = 0x23, // Sees values of 0x00-0x06 and seems generally incremental. Maybe gear... if that needs to be network relayed. Some cases jumping 5 to 0 tho. The studied entry was a P1-Cobra so seat doesn't make sense.
            Unk_0x24 = 0x24, // Not effect flags
            Unk_0x3E = 0x3E, // Might be part of 0x1D
        }

        public byte[] Unk_0x02;
        public byte? Unk_0x03;
        public byte? Unk_0x04;
        public byte[] DriverSeat0_Entity; // 0x08
        public byte[] PassengerSeat1_Entity; // 0x09
        public byte[] PassengerSeat2_Entity; // 0x0a
        public byte[] PassengerSeat3_Entity; // 0x0b
        public byte[] PassengerSeat4_Entity; // 0x0c
        public byte[] PassengerSeat5_Entity; // 0x0d
        public byte? Unk_0x18; 
        public byte[] Unk_0x19;
        public byte[] Faction;
        public byte[] Unk_0x1B;
        public uint? CurrentHealth;
        public byte[] Unk_0x1D;
        public byte? Unk_0x23;
        public byte? Unk_0x24; 
        public byte[] Unk_0x3E;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x02:
                        Unk_0x02 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x03:
                        Unk_0x03 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x04:
                        Unk_0x04 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.DriverSeat0_Entity:
                        DriverSeat0_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.PassengerSeat1_Entity:
                        PassengerSeat1_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.PassengerSeat2_Entity:
                        PassengerSeat2_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.PassengerSeat3_Entity:
                        PassengerSeat3_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.PassengerSeat4_Entity:
                        PassengerSeat4_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.PassengerSeat5_Entity:
                        PassengerSeat5_Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Unk_0x18:
                        Unk_0x18 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x19:
                        Unk_0x19 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Faction:
                        Faction = Stream.Read.ByteArray(2);
                        break;
                    case ShadowFieldIndex.Unk_0x1B:
                        Unk_0x1B = Stream.Read.ByteArray(20);
                        break;
                    case ShadowFieldIndex.CurrentHealth:
                        CurrentHealth = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x1D:
                        Unk_0x1D = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Unk_0x23:
                        Unk_0x23 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x24:
                        Unk_0x24 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x3E:
                        Unk_0x3E = Stream.Read.ByteArray(4);
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