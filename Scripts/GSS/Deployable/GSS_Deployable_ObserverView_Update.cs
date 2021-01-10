using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 35, 1, true)]
    public class DeployableObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Type = 0x00,
            OwningEntity = 0x01,
            AbilitySrcId = 0x02,
            Position = 0x03,
            Orientation = 0x04,
            AimPosition = 0x05,
            AimDirection = 0x06,
            ConstructedTime = 0x07,
            CurrentHealthPct    = 0x08, // % integer
            MaxHealth = 0x09,
            Level = 0x0a,
            StatusEffect_00_ChangeTime = 0x0b,
            StatusEffect_01_ChangeTime = 0x0c,
            StatusEffect_02_ChangeTime = 0x0d,
            StatusEffect_03_ChangeTime = 0x0e,
            StatusEffect_04_ChangeTime = 0x0f,
            StatusEffect_05_ChangeTime = 0x10,
            StatusEffect_06_ChangeTime = 0x11,
            StatusEffect_07_ChangeTime = 0x12,
            StatusEffect_08_ChangeTime = 0x13,
            StatusEffect_09_ChangeTime = 0x14,
            StatusEffect_0a_ChangeTime = 0x15,
            StatusEffect_0b_ChangeTime = 0x16,
            StatusEffect_0c_ChangeTime = 0x17,
            StatusEffect_0d_ChangeTime = 0x18,
            StatusEffect_0e_ChangeTime = 0x19,
            StatusEffect_0f_ChangeTime = 0x1a,
            StatusEffect_10_ChangeTime = 0x1b,
            StatusEffect_11_ChangeTime = 0x1c,
            StatusEffect_12_ChangeTime = 0x1d,
            StatusEffect_13_ChangeTime = 0x1e,
            StatusEffect_14_ChangeTime = 0x1f,
            StatusEffect_15_ChangeTime = 0x20,
            StatusEffect_16_ChangeTime = 0x21,
            StatusEffect_17_ChangeTime = 0x22,
            StatusEffect_18_ChangeTime = 0x23,
            StatusEffect_19_ChangeTime = 0x24,
            StatusEffect_1a_ChangeTime = 0x25,
            StatusEffect_1b_ChangeTime = 0x26,
            StatusEffect_1c_ChangeTime = 0x27,
            StatusEffect_1d_ChangeTime = 0x28,
            StatusEffect_1e_ChangeTime = 0x29,
            StatusEffect_1f_ChangeTime = 0x2a,
            StatusEffect_00_Data = 0x2b,
            StatusEffect_01_Data = 0x2c,
            StatusEffect_02_Data = 0x2d,
            StatusEffect_03_Data = 0x2e,
            StatusEffect_04_Data = 0x2f,
            StatusEffect_05_Data = 0x30,
            StatusEffect_06_Data = 0x31,
            StatusEffect_07_Data = 0x32,
            StatusEffect_08_Data = 0x33,
            StatusEffect_09_Data = 0x34,
            StatusEffect_0a_Data = 0x35,
            StatusEffect_0b_Data = 0x36,
            StatusEffect_0c_Data = 0x37,
            StatusEffect_0d_Data = 0x38,
            StatusEffect_0e_Data = 0x39,
            StatusEffect_0f_Data = 0x3a,
            StatusEffect_10_Data = 0x3b,
            StatusEffect_11_Data = 0x3c,
            StatusEffect_12_Data = 0x3d,
            StatusEffect_13_Data = 0x3e,
            StatusEffect_14_Data = 0x3f,
            StatusEffect_15_Data = 0x40,
            StatusEffect_16_Data = 0x41,
            StatusEffect_17_Data = 0x42,
            StatusEffect_18_Data = 0x43,
            StatusEffect_19_Data = 0x44,
            StatusEffect_1a_Data = 0x45,
            StatusEffect_1b_Data = 0x46,
            StatusEffect_1c_Data = 0x47,
            StatusEffect_1d_Data = 0x48,
            StatusEffect_1e_Data = 0x49,
            StatusEffect_1f_Data = 0x4a,

            StatusEffect_00_Cancel = 0xab,
            StatusEffect_01_Cancel = 0xac,
            StatusEffect_02_Cancel = 0xad,
            StatusEffect_03_Cancel = 0xae,
            StatusEffect_04_Cancel = 0xaf,
            StatusEffect_05_Cancel = 0xb0,
            StatusEffect_06_Cancel = 0xb1,
            StatusEffect_07_Cancel = 0xb2,
            StatusEffect_08_Cancel = 0xb3,
            StatusEffect_09_Cancel = 0xb4,
            StatusEffect_0a_Cancel = 0xb5,
            StatusEffect_0b_Cancel = 0xb6,
            StatusEffect_0c_Cancel = 0xb7,
            StatusEffect_0d_Cancel = 0xb8,
            StatusEffect_0e_Cancel = 0xb9,
            StatusEffect_0f_Cancel = 0xba,
            StatusEffect_10_Cancel = 0xbb,
            StatusEffect_11_Cancel = 0xbc,
            StatusEffect_12_Cancel = 0xbd,
            StatusEffect_13_Cancel = 0xbe,
            StatusEffect_14_Cancel = 0xbf,
            StatusEffect_15_Cancel = 0xc0,
            StatusEffect_16_Cancel = 0xc1,
            StatusEffect_17_Cancel = 0xc2,
            StatusEffect_18_Cancel = 0xc3,
            StatusEffect_19_Cancel = 0xc4,
            StatusEffect_1a_Cancel = 0xc5,
            StatusEffect_1b_Cancel = 0xc6,
            StatusEffect_1c_Cancel = 0xc7,
            StatusEffect_1d_Cancel = 0xc8,
            StatusEffect_1e_Cancel = 0xc9,
            StatusEffect_1f_Cancel = 0xca,

            HostilityInfo = 0x4b,
            PersonalFactionStance = 0x4c,
            GibVisualsID = 0x04d,
            ForcedMovement = 0x4e,
            SinFlags = 0x4f,
            SinFactionsAcquiredBy = 0x50,
            SinTeamsAcquiredBy = 0x51,
            AttachedTo = 0x52,
            WarpaintColors = 0x53,
            VisualInfoGroupIndex = 0x54,
            CharacterStats = 0x55,
            SinCardType = 0x56,
            SinCardFields_0 =  0x57,
            SinCardFields_1 =  0x58,
            SinCardFields_2 =  0x59,
            SinCardFields_3 =  0x5a,
            SinCardFields_4 =  0x5b,
            SinCardFields_5 =  0x5c,
            SinCardFields_6 =  0x5d,
            SinCardFields_7 =  0x5e,
            SinCardFields_8 =  0x5f,
            SinCardFields_9 =  0x60,
            SinCardFields_10 =  0x61,
            SinCardFields_11 =  0x62,
            SinCardFields_12 =  0x63,
            SinCardFields_13 =  0x64,
            SinCardFields_14 =  0x65,
            SinCardFields_15 =  0x66,
            SinCardFields_16 =  0x67,
            SinCardFields_17 =  0x68,
            SinCardFields_18 =  0x69,
            SinCardFields_19 =  0x6a,
            ScalingLevel = 0x6b,
            AppendageHealthPools_0 = 0x6c,
            AppendageHealthPools_1 = 0x6d,
            AppendageHealthPools_2 = 0x6e,
            AppendageHealthPools_3 = 0x6f,
            AppendageHealthPools_4 = 0x70,
            AppendageHealthPools_5 = 0x71,
            AppendageHealthPools_6 = 0x72,
            AppendageHealthPools_7 = 0x73,
            AppendageHealthPct_0 = 0x74,
            AppendageHealthPct_1 = 0x75,
            AppendageHealthPct_2 = 0x76,
            AppendageHealthPct_3 = 0x77,
            AppendageHealthPct_4 = 0x78,
            AppendageHealthPct_5 = 0x79,
            AppendageHealthPct_6 = 0x7a,
            AppendageHealthPct_7 = 0x7b,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield


        public byte? CurrentHealthPct;

        public ushort? StatusEffect_0b_ChangeTime;
        public uint? StatusEffect_0b_Id;
        public byte[] StatusEffect_0b_Unk1;
        public byte[] StatusEffect_0b_Entity;
        public uint? StatusEffect_0b_Time1;
        public byte? StatusEffect_0b_Unk2Flag;
        public byte[] StatusEffect_0b_Unk2;
        public bool? StatusEffect_0b_Cancel;

        public ushort? StatusEffect_0c_ChangeTime;
        public uint? StatusEffect_0c_Id;
        public byte[] StatusEffect_0c_Unk1;
        public byte[] StatusEffect_0c_Entity;
        public uint? StatusEffect_0c_Time1;
        public byte? StatusEffect_0c_Unk2Flag;
        public byte[] StatusEffect_0c_Unk2;
        public bool? StatusEffect_0c_Cancel;

        public ushort? StatusEffect_0d_ChangeTime;
        public uint? StatusEffect_0d_Id;
        public byte[] StatusEffect_0d_Unk1;
        public byte[] StatusEffect_0d_Entity;
        public uint? StatusEffect_0d_Time1;
        public byte? StatusEffect_0d_Unk2Flag;
        public byte[] StatusEffect_0d_Unk2;
        public bool? StatusEffect_0d_Cancel;

        public ushort? StatusEffect_0e_ChangeTime;
        public uint? StatusEffect_0e_Id;
        public byte[] StatusEffect_0e_Unk1;
        public byte[] StatusEffect_0e_Entity;
        public uint? StatusEffect_0e_Time1;
        public byte? StatusEffect_0e_Unk2Flag;
        public byte[] StatusEffect_0e_Unk2;
        public bool? StatusEffect_0e_Cancel;

        public ushort? StatusEffect_0f_ChangeTime;
        public uint? StatusEffect_0f_Id;
        public byte[] StatusEffect_0f_Unk1;
        public byte[] StatusEffect_0f_Entity;
        public uint? StatusEffect_0f_Time1;
        public byte? StatusEffect_0f_Unk2Flag;
        public byte[] StatusEffect_0f_Unk2;
        public bool? StatusEffect_0f_Cancel;


        public ushort? StatusEffect_10_ChangeTime;
        public uint? StatusEffect_10_Id;
        public byte[] StatusEffect_10_Unk1;
        public byte[] StatusEffect_10_Entity;
        public uint? StatusEffect_10_Time1;
        public byte? StatusEffect_10_Unk2Flag;
        public byte[] StatusEffect_10_Unk2;
        public bool? StatusEffect_10_Cancel;

        public ushort? StatusEffect_11_ChangeTime;
        public uint? StatusEffect_11_Id;
        public byte[] StatusEffect_11_Unk1;
        public byte[] StatusEffect_11_Entity;
        public uint? StatusEffect_11_Time1;
        public byte? StatusEffect_11_Unk2Flag;
        public byte[] StatusEffect_11_Unk2;
        public bool? StatusEffect_11_Cancel;

        public ushort? StatusEffect_12_ChangeTime;
        public uint? StatusEffect_12_Id;
        public byte[] StatusEffect_12_Unk1;
        public byte[] StatusEffect_12_Entity;
        public uint? StatusEffect_12_Time1;
        public byte? StatusEffect_12_Unk2Flag;
        public byte[] StatusEffect_12_Unk2;
        public bool? StatusEffect_12_Cancel;

        public ushort? StatusEffect_13_ChangeTime;
        public uint? StatusEffect_13_Id;
        public byte[] StatusEffect_13_Unk1;
        public byte[] StatusEffect_13_Entity;
        public uint? StatusEffect_13_Time1;
        public byte? StatusEffect_13_Unk2Flag;
        public byte[] StatusEffect_13_Unk2;
        public bool? StatusEffect_13_Cancel;

        public ushort? StatusEffect_14_ChangeTime;
        public uint? StatusEffect_14_Id;
        public byte[] StatusEffect_14_Unk1;
        public byte[] StatusEffect_14_Entity;
        public uint? StatusEffect_14_Time1;
        public byte? StatusEffect_14_Unk2Flag;
        public byte[] StatusEffect_14_Unk2;
        public bool? StatusEffect_14_Cancel;

        public byte[] HostilityInfo;
        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;

        public byte[] UnableToParse;



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    
                    case ShadowFieldIndex.CurrentHealthPct:
                        CurrentHealthPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.StatusEffect_0b_ChangeTime:
                        StatusEffect_0b_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0c_ChangeTime:
                        StatusEffect_0c_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0d_ChangeTime:
                        StatusEffect_0d_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0e_ChangeTime:
                        StatusEffect_0e_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0f_ChangeTime:
                        StatusEffect_0f_ChangeTime = Stream.Read.UShort();
                        break;
                    
                    case ShadowFieldIndex.StatusEffect_10_ChangeTime:
                        StatusEffect_10_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_11_ChangeTime:
                        StatusEffect_11_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_12_ChangeTime:
                        StatusEffect_12_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_13_ChangeTime:
                        StatusEffect_13_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_14_ChangeTime:
                        StatusEffect_14_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0b_Data:
                        StatusEffect_0b_Id     = Stream.Read.UInt();
                        StatusEffect_0b_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0b_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0b_Time1  = Stream.Read.UInt();
                        StatusEffect_0b_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0b_Unk2Flag == 0x01)
                        {
                            StatusEffect_0b_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0c_Data:
                        StatusEffect_0c_Id     = Stream.Read.UInt();
                        StatusEffect_0c_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0c_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0c_Time1  = Stream.Read.UInt();
                        StatusEffect_0c_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0c_Unk2Flag == 0x01)
                        {
                            StatusEffect_0c_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0d_Data:
                        StatusEffect_0d_Id     = Stream.Read.UInt();
                        StatusEffect_0d_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0d_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0d_Time1  = Stream.Read.UInt();
                        StatusEffect_0d_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0d_Unk2Flag == 0x01)
                        {
                            StatusEffect_0d_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0e_Data:
                        StatusEffect_0e_Id     = Stream.Read.UInt();
                        StatusEffect_0e_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0e_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0e_Time1  = Stream.Read.UInt();
                        StatusEffect_0e_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0e_Unk2Flag == 0x01)
                        {
                            StatusEffect_0e_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0f_Data:
                        StatusEffect_0f_Id     = Stream.Read.UInt();
                        StatusEffect_0f_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0f_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0f_Time1  = Stream.Read.UInt();
                        StatusEffect_0f_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0f_Unk2Flag == 0x01)
                        {
                            StatusEffect_0f_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_10_Data:
                        StatusEffect_10_Id     = Stream.Read.UInt();
                        StatusEffect_10_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_10_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_10_Time1  = Stream.Read.UInt();
                        StatusEffect_10_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_10_Unk2Flag == 0x01)
                        {
                            StatusEffect_10_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_11_Data:
                        StatusEffect_11_Id     = Stream.Read.UInt();
                        StatusEffect_11_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_11_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_11_Time1  = Stream.Read.UInt();
                        StatusEffect_11_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_11_Unk2Flag == 0x01)
                        {
                            StatusEffect_11_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_12_Data:
                        StatusEffect_12_Id     = Stream.Read.UInt();
                        StatusEffect_12_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_12_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_12_Time1  = Stream.Read.UInt();
                        StatusEffect_12_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_12_Unk2Flag == 0x01)
                        {
                            StatusEffect_12_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_13_Data:
                        StatusEffect_13_Id     = Stream.Read.UInt();
                        StatusEffect_13_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_13_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_13_Time1  = Stream.Read.UInt();
                        StatusEffect_13_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_13_Unk2Flag == 0x01)
                        {
                            StatusEffect_13_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_14_Data:
                        StatusEffect_14_Id     = Stream.Read.UInt();
                        StatusEffect_14_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_14_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_14_Time1  = Stream.Read.UInt();
                        StatusEffect_14_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_14_Unk2Flag == 0x01)
                        {
                            StatusEffect_14_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;


                    case ShadowFieldIndex.StatusEffect_0b_Cancel:
                        StatusEffect_0b_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0c_Cancel:
                        StatusEffect_0c_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0d_Cancel:
                        StatusEffect_0d_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0e_Cancel:
                        StatusEffect_0e_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0f_Cancel:
                        StatusEffect_0f_Cancel = true;
                        break;

                    case ShadowFieldIndex.StatusEffect_10_Cancel:
                        StatusEffect_10_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_11_Cancel:
                        StatusEffect_11_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_12_Cancel:
                        StatusEffect_12_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_13_Cancel:
                        StatusEffect_13_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_14_Cancel:
                        StatusEffect_14_Cancel = true;
                        break;

                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinFactionsAcquiredBy:
                        SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinTeamsAcquiredBy:
                        SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }
    }
}