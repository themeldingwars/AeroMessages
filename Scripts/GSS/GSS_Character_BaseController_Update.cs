using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 1, true)]
    public class CharacterBaseControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            Unk_0x00                = 0x00,
            UsedInventorySlots      = 0x01,
            MaxInventorySlots       = 0x02,
            AuthTerminal            = 0x03,
            ConfirmedPoseUpdateTime = 0x04,
            ObserverData            = 0x05, // Look to Character_ObserverView_Keyframe for decoding
            Unk_0x06_Time           = 0x06,
            Unk_0x07                = 0x07,
            EquipmentData           = 0x08, // Look to Character_EquipmentView_Keyframe for decoding
            LoadoutId               = 0x09,
            Unk_0x0A                = 0x0A,
            Unk_0x0B                = 0x0B,
            MovementData            = 0x0C, // Look to Character_MovementView_Keyframe for decoding
            Unk_0x0D                = 0x0D, // Equivalent of 0x04 in Observer View
            CharacterState          = 0x10,
            Faction                 = 0x11,
            Unk_0x12                = 0x12, // I think this might be like offsets for the player point of view or something along those lines, values like these reoccur in the Vehicle stuff as well
            CurrentHealth           = 0x13,
            Unk_0x14                = 0x14,
            Unk_0x15                = 0x15,
            MaxHealth               = 0x16,
            Unk_0x17                = 0x17,
            JetpackValues           = 0x18,
            Stats                   = 0x19,
            ArmyGUID                = 0x21,
            Unk_0x22                = 0x22,
            Unk_0x26                = 0x26,
            Unk_0x27                = 0x27,
            Unk_0x29                = 0x29,
            Unk_0x2F                = 0x2F,
            Unk_0x30                = 0x30,
            Unk_0x31                = 0x31,
            Unk_0x32                = 0x32,
            Unk_0x33                = 0x33,
            Unk_0x34                = 0x34,
            Unk_0x35                = 0x35,
            Unk_0x36                = 0x36,
            Unk_0x37                = 0x37,
            Unk_0x38                = 0x38,
            Unk_0x39                = 0x39,
            Unk_0x3a                = 0x3a,
            Unk_0x3b                = 0x3b,
            Unk_0x3c                = 0x3c,
            Unk_0x3d                = 0x3d,
            Unk_0x3e                = 0x3e,
            Unk_0x3f                = 0x3f,
            Unk_0x40                = 0x40,
            Unk_0x41                = 0x41,
            Unk_0x42                = 0x42,
            Unk_0x43                = 0x43,
            Unk_0x44                = 0x44,
            Unk_0x45                = 0x45,
            Level                   = 0x47,
            Effective_Level         = 0x48,
            Unk_0x4b                = 0x4b,
            Unk_0x6a                = 0x6a,
            Unk_0x6b                = 0x6b,
            Unk_0x6c                = 0x6c,
            Unk_0x6d                = 0x6d,
            Unk_0x6e                = 0x6e,
            Unk_0x6f                = 0x6f,
            Unk_0x70                = 0x70,
            Unk_0x71                = 0x71,
        }

        public byte[] Unk_0x00;
        public uint? UsedInventorySlots;
        public uint? MaxInventorySlots;
        public byte? AuthTerminalType;
        public uint? AuthTerminalId;
        public byte[] AuthTerminalEntity;
        public uint? ConfirmedPoseUpdateTime;
        public byte[] ObserverData;
        public uint? Unk_0x06_Time;
        public byte? Unk_0x07;
        public byte[] EquipmentData;
        public uint? LoadoutId;
        public byte[] Unk_0x0A;
        public byte[] Unk_0x0B_1;
        public uint? Unk_0x0B_Time;
        public byte[] MovementData;
        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte[] Unk_0x0D;
        public byte[] Faction;
        public byte[] Unk_0x12;
        public uint? CurrentHealth;
        public byte[] Unk_0x14;
        public byte[] Unk_0x15;
        public uint? Unk_0x15_Time;
        public uint? MaxHealth;
        public uint? MaxHealth_Time;
        public byte? Unk_0x17;
        public float? JetpackValues_EnergyMax;
        public uint? JetpackValues_Unk;
        public float? JetpackValues_RechargeRelated;
        public uint? JetpackValues_Time;
        public byte[] Stats;
        public ulong? ArmyGUID;
        
        public byte? Unk_0x22;

        public byte[] Unk_0x26;
        public byte[] Unk_0x27;
        public byte[] Unk_0x29;
        public byte[] Unk_0x2F;

        public byte[] Unk_0x30;

        public byte[] Unk_0x31;
        public byte[] Unk_0x32;
        public byte[] Unk_0x33;
        public byte[] Unk_0x34;
        public byte[] Unk_0x35;
        public byte[] Unk_0x36;
        public byte[] Unk_0x37;
        public byte[] Unk_0x38;
        public byte[] Unk_0x39;
        public byte[] Unk_0x3a;
        public byte[] Unk_0x3b;
        public byte[] Unk_0x3c;
        public byte[] Unk_0x3d;
        public byte[] Unk_0x3e;
        public byte[] Unk_0x3f;
        public byte[] Unk_0x40;
        public byte[] Unk_0x41;
        public byte[] Unk_0x42;
        public byte[] Unk_0x43;
        public byte[] Unk_0x44;
        public byte[] Unk_0x45;

        public byte? Level;
        public byte? Effective_Level;

        public byte[] Unk_0x4b;
        public byte[] Unk_0x6a;
        public byte[] Unk_0x6b;
        public byte[] Unk_0x6c;
        public byte[] Unk_0x6d;
        public byte[] Unk_0x6e;
        public byte[] Unk_0x6f;
        public byte[] Unk_0x70;
        public byte[] Unk_0x71;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x00:
                        Unk_0x00 = Stream.Read.ByteArray(4);
                        break;
                        
                    case ShadowFieldIndex.UsedInventorySlots:
                        UsedInventorySlots = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.MaxInventorySlots:
                        MaxInventorySlots = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.AuthTerminal:
                        AuthTerminalType = Stream.Read.Byte();
                        AuthTerminalId = Stream.Read.UInt();
                        AuthTerminalEntity = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ConfirmedPoseUpdateTime:
                        ConfirmedPoseUpdateTime = Stream.Read.UInt();
                        break;

                    //case ShadowFieldIndex.ObserverData:
                    //    ObserverData = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.Unk_0x06_Time:
                        Unk_0x06_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x07:
                        Unk_0x07 = Stream.Read.Byte();
                        break;

                    //case ShadowFieldIndex.EquipmentData:
                    //    EquipmentData = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.LoadoutId:
                        LoadoutId = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x0A:
                        Unk_0x0A = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x0B:
                        Unk_0x0B_1 = Stream.Read.ByteArray(4);
                        Unk_0x0B_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x0D:
                        Unk_0x0D = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.MovementData:
                        MovementData = Stream.Read.ByteArray(67); // Might as well add indepth parsing
                        break;

                    case ShadowFieldIndex.CharacterState:
                        CharacterState = Stream.Read.Byte();
                        CharacterState_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Faction:
                        Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x12:
                        Unk_0x12 = Stream.Read.ByteArray(20);
                        break;

                    case ShadowFieldIndex.CurrentHealth:
                        CurrentHealth = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x14:
                        Unk_0x14 = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x15:
                        Unk_0x15 = Stream.Read.ByteArray(4);
                        Unk_0x15_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        MaxHealth_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Unk_0x17:
                        Unk_0x17 = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.JetpackValues:
                        JetpackValues_EnergyMax = Stream.Read.Float();
                        JetpackValues_Unk = Stream.Read.UInt(); // Not sure
                        JetpackValues_RechargeRelated = Stream.Read.Float();
                        JetpackValues_Time = Stream.Read.UInt();
                        break;

                    //case ShadowFieldIndex.Stats:
                    //    Stats = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.ArmyGUID:
                        ArmyGUID = Stream.Read.ULong();
                        break;

                    case ShadowFieldIndex.Unk_0x22:
                        Unk_0x22 = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.Unk_0x26:
                        Unk_0x26 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x27:
                        Unk_0x27 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x29:
                        Unk_0x29 = Stream.Read.ByteArray(9);
                        break;

                    case ShadowFieldIndex.Unk_0x2F:
                        Unk_0x2F = Stream.Read.ByteArray(4);
                        break;

                    //case ShadowFieldIndex.Unk_0x30:
                    //    Unk_0x30 = ;
                    //    break;

                    case ShadowFieldIndex.Unk_0x31:
                        Unk_0x31 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x32:
                        Unk_0x32 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x33:
                        Unk_0x33 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x34:
                        Unk_0x34 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x35:
                        Unk_0x35 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x36:
                        Unk_0x36 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x37:
                        Unk_0x37 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x38:
                        Unk_0x38 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x39:
                        Unk_0x39 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3a:
                        Unk_0x3a = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3b:
                        Unk_0x3b = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3c:
                        Unk_0x3c = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3d:
                        Unk_0x3d = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3e:
                        Unk_0x3e = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x3f:
                        Unk_0x3f = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x40:
                        Unk_0x40 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x41:
                        Unk_0x41 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x42:
                        Unk_0x42 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x43:
                        Unk_0x43 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x44:
                        Unk_0x44 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x45:
                        Unk_0x45 = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Level:
                        Level = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.Effective_Level:
                        Effective_Level = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.Unk_0x4b:
                        Unk_0x4b = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x6a:
                        Unk_0x6a = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x6b:
                        Unk_0x6b = Stream.Read.ByteArray(5);
                        break;

                    case ShadowFieldIndex.Unk_0x6d:
                        Unk_0x6d = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x6e:
                        Unk_0x6e = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x6f:
                        Unk_0x6f = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x70:
                        Unk_0x70 = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.Unk_0x71:
                        Unk_0x71 = Stream.Read.ByteArray(4);
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