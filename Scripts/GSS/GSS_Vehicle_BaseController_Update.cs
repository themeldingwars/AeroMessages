using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 1, true)]
    public class VehicleBaseControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            VehicleId             = 0x00,
            Unk_0x01              = 0x01,
            Unk_0x02              = 0x02,
            VehicleEnabled        = 0x03,
            Unk_0x04              = 0x04,
            OwnerEntity           = 0x05,
            Unk_0x07              = 0x07,
            Seat0Entity           = 0x08,
            Seat1Entity           = 0x09,
            Seat2Entity           = 0x0A,
            Seat3Entity           = 0x0B,
            Seat4Entity           = 0x0C,
            Seat5Entity           = 0x0D,
            Unk_0x0E              = 0x0E,
            Unk_0x0F              = 0x0F,
            Unk_0x10              = 0x10,
            Unk_0x11              = 0x11,
            Unk_0x12              = 0x12,
            Unk_0x13              = 0x13,
            Unk_0x14              = 0x14,
            Unk_0x15              = 0x15,
            Unk_0x16              = 0x16,
            Unk_0x17              = 0x17,
            Unk_0x18              = 0x18,
            Maybe_InitialMovement = 0x19,
            Unk_0x1A              = 0x1A,
            MovementInput         = 0x1B,
            Unk_0x1C              = 0x1C,
            Maybe_Faction         = 0x1D,
            Unk_0x1E              = 0x1E,
            CurrentHealth         = 0x1F,
            MaxHealth             = 0x20,
            Unk_0x23              = 0x23,
            Unk_0x24              = 0x24,
        }

        public ushort? VehicleId;
        public byte[] Unk_0x01;
        public byte[] Unk_0x02;
        public byte? VehicleEnabled;
        public byte? Unk_0x04;
        public byte[] OwnerEntity;
        public byte[] Unk_0x07;
        public byte[] Seat0Entity;
        public byte[] Seat1Entity;
        public byte[] Seat2Entity;
        public byte[] Seat3Entity;
        public byte[] Seat4Entity;
        public byte[] Seat5Entity;
        public byte[] Unk_0x0E;
        public byte[] Unk_0x0F;
        public byte[] Unk_0x10;
        public byte[] Unk_0x11;
        public byte[] Unk_0x12;
        public byte[] Unk_0x13;
        public byte[] Unk_0x14;
        public byte[] Unk_0x15;
        public byte[] Unk_0x16;
        public byte[] Unk_0x17;
        public byte? Unk_0x18;
        public float[] UnkMov_Position; // 0x19
        public float[] UnkMov_Rotation; // 0x19
        public float[] UnkMov_Direction; // 0x19
        public uint? UnkMov_Time; // 0x19

        public byte[] Unk_0x1A;
        public float[] MovInput_Position; // 0x1B
        public float[] MovInput_Rotation; // 0x1B
        public float[] MovInput_Direction; // 0x1B
        public ushort? MovInput_State; // 0x1B
        public uint? MovInput_Time; // 0x1B
        public byte[] Unk_0x1C;
        public byte[] Maybe_Faction;
        public byte[] Unk_0x1E;
        public uint? CurrentHealth;
        public uint? MaxHealth;
        public byte[] Unk_0x23;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.VehicleId:
                        VehicleId = Stream.Read.UShort();
                        break;
                    case ShadowFieldIndex.Unk_0x01:
                        Unk_0x01 = Stream.Read.ByteArray(32);
                        break;
                    case ShadowFieldIndex.Unk_0x02:
                        Unk_0x02 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.VehicleEnabled:
                        VehicleEnabled = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x04:
                        Unk_0x04 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.OwnerEntity:
                        OwnerEntity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Unk_0x07:
                        Unk_0x07 = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Seat0Entity:
                        Seat0Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Seat1Entity:
                        Seat1Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Seat2Entity:
                        Seat2Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Seat3Entity:
                        Seat3Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Seat4Entity:
                        Seat4Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Seat5Entity:
                        Seat5Entity = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.Unk_0x0E:
                        Unk_0x0E = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x0F:
                        Unk_0x0F = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x10:
                        Unk_0x10 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x11:
                        Unk_0x11 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x12:
                        Unk_0x12 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x13:
                        Unk_0x13 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x14:
                        Unk_0x14 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x15:
                        Unk_0x15 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x16:
                        Unk_0x16 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x17:
                        Unk_0x17 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.Unk_0x18:
                        Unk_0x18 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Maybe_InitialMovement:
                        UnkMov_Position = Stream.Read.FloatArray(3);
                        UnkMov_Rotation = Stream.Read.FloatArray(4);
                        UnkMov_Direction = Stream.Read.FloatArray(3);
                        UnkMov_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x1A:
                        Unk_0x1A = Stream.Read.ByteArray(12);
                        break;
                    case ShadowFieldIndex.MovementInput:
                        MovInput_Position = Stream.Read.FloatArray(3);
                        MovInput_Rotation = Stream.Read.FloatArray(4);
                        MovInput_Direction = Stream.Read.FloatArray(3);
                        MovInput_State = Stream.Read.UShort();
                        MovInput_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x1C:
                        Unk_0x1C = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.Maybe_Faction:
                        Maybe_Faction = Stream.Read.ByteArray(2);
                        break;
                    case ShadowFieldIndex.Unk_0x1E:
                        Unk_0x1E = Stream.Read.ByteArray(20);
                        break;
                    case ShadowFieldIndex.CurrentHealth:
                        CurrentHealth = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.Unk_0x23:
                        Unk_0x23 = Stream.Read.ByteArray(4);
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