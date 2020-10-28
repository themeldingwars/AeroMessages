using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 4, true)]
    public class VehicleBaseControllerKeyframe : BaseScript
    {
        // Fields are underscored based on VehicleBaseController shadowfield indexes
        // The unks with no underscored index are gap areas where I don't know the potential byte distribution.
        // Field lengths can expand (e.g. arrays) and throw the distribution off when we don't know how to handle them, so compare multiple fields and messages if something looks wrong.
        public ulong PlayerID;
        public byte[] Unk1;
        public ushort VehicleID; // 0x00, Sdb table 47, id column.
        public byte[] Unk2_0x01;
        public byte[] Unk3_0x02;
        public byte VehicleEnabled; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        public byte Unk4_0x04;
        public byte[] OwnerEntity; // 0x05
        public byte Unk5;
        public byte[] Unk6_0x07;
        public byte[] DriverSeat0_Entity; // 0x08
        public byte[] PassengerSeat1_Entity; // 0x09
        public byte[] PassengerSeat2_Entity; // 0x0a
        public byte[] PassengerSeat3_Entity; // 0x0b
        public byte[] PassengerSeat4_Entity; // 0x0c
        public byte[] PassengerSeat5_Entity; // 0x0d
        public byte[] Unk8_0x0E;
        public byte[] Unk9_0x0F;
        public byte[] Unk10_0x10;
        public byte[] Unk11_0x11;
        public byte[] Unk12_0x12;
        public byte[] Unk13_0x13;
        public byte[] Unk14_0x14;
        public byte[] Unk15_0x15;
        public byte[] Unk16_0x16;
        public byte[] Unk17_0x17;
        public byte Unk18;

        // 0x19 - Maybe initial movement?
        public float[] UnkMov_Position;
        public float[] UnkMov_Rotation;
        public float[] UnkMov_Direction;
        public uint UnkMov_Time;

        public byte[] Unk_0x1A;

        // 0x1B - Movement Input
        public float[] MovInput_Position;
        public float[] MovInput_Rotation;
        public float[] MovInput_Direction;
        public ushort MovInput_State;
        public uint MovInput_Time;

        public byte[] Unk19_0x1C;
        public byte[] Faction;
        public byte[] Unk20_0x1E;
        public uint CurrentHealth;
        public uint MaxHealth;
        public byte[] Unk21;
        public byte[] Unk22_0x23;
        public byte[] Unk23;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            PlayerID = Stream.Read.ULong();
            Unk1 = Stream.Read.ByteArray(4);
            VehicleID = Stream.Read.UShort();
            Unk2_0x01 = Stream.Read.ByteArray(32);
            Unk3_0x02 = Stream.Read.ByteArray(4);
            VehicleEnabled = Stream.Read.Byte();
            Unk4_0x04 = Stream.Read.Byte();
            OwnerEntity = Stream.Read.ByteArray(8);
            Unk5 = Stream.Read.Byte();
            Unk6_0x07 = Stream.Read.ByteArray(4);
            DriverSeat0_Entity = Stream.Read.ByteArray(8);
            PassengerSeat1_Entity = Stream.Read.ByteArray(8);
            PassengerSeat2_Entity = Stream.Read.ByteArray(8);
            PassengerSeat3_Entity = Stream.Read.ByteArray(8);
            PassengerSeat4_Entity = Stream.Read.ByteArray(8);
            PassengerSeat5_Entity = Stream.Read.ByteArray(8);
            Unk8_0x0E = Stream.Read.ByteArray(13);
            Unk9_0x0F = Stream.Read.ByteArray(13);
            Unk10_0x10 = Stream.Read.ByteArray(13);
            Unk11_0x11 = Stream.Read.ByteArray(13);
            Unk12_0x12 = Stream.Read.ByteArray(13);
            Unk13_0x13 = Stream.Read.ByteArray(13);
            Unk14_0x14 = Stream.Read.ByteArray(13);
            Unk15_0x15 = Stream.Read.ByteArray(13);
            Unk16_0x16 = Stream.Read.ByteArray(13);
            Unk17_0x17 = Stream.Read.ByteArray(13);
            Unk18 = Stream.Read.Byte();

            UnkMov_Position = Stream.Read.FloatArray(3);
            UnkMov_Rotation = Stream.Read.FloatArray(4);
            UnkMov_Direction = Stream.Read.FloatArray(3);
            UnkMov_Time = Stream.Read.UInt();

            Unk_0x1A = Stream.Read.ByteArray(12);

            MovInput_Position = Stream.Read.FloatArray(3);
            MovInput_Rotation = Stream.Read.FloatArray(4);
            MovInput_Direction = Stream.Read.FloatArray(3);
            MovInput_State = Stream.Read.UShort();
            MovInput_Time = Stream.Read.UInt();

            Unk19_0x1C = Stream.Read.ByteArray(4);
            Faction = Stream.Read.ByteArray(2);
            Unk20_0x1E = Stream.Read.ByteArray(20);
            CurrentHealth = Stream.Read.UInt();
            MaxHealth = Stream.Read.UInt();
            Unk21 = Stream.Read.ByteArray(8);
            Unk22_0x23 = Stream.Read.ByteArray(4);
            
            Unk23 = Stream.Read.ByteArray(23);
        }
    }
}