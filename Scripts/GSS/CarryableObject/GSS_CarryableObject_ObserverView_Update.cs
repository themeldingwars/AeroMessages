using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 1, true)]
    public class CarryableObjectObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            CarryableObjectTypeId = 0x00,
            Name = 0x01,
            Position = 0x02,
            Orientation = 0x03,
            Hostility = 0x04, // Faction
            PersonalFactionStance = 0x05,
            CarryingCharacterId = 0x06,
            ForcedMovement = 0x07,
            StatusEffect_00_ChangeTime = 0x08,
            StatusEffect_01_ChangeTime = 0x09,
            StatusEffect_02_ChangeTime = 0x0a,
            StatusEffect_03_ChangeTime = 0x0b,
            StatusEffect_04_ChangeTime = 0x0c,
            StatusEffect_05_ChangeTime = 0x0d,
            StatusEffect_06_ChangeTime = 0x0e,
            StatusEffect_07_ChangeTime = 0x0f,
            StatusEffect_08_ChangeTime = 0x10,
            StatusEffect_09_ChangeTime = 0x11,
            StatusEffect_0a_ChangeTime = 0x12,
            StatusEffect_0b_ChangeTime = 0x13,
            StatusEffect_0c_ChangeTime = 0x14,
            StatusEffect_0d_ChangeTime = 0x15,
            StatusEffect_0e_ChangeTime = 0x16,
            StatusEffect_0f_ChangeTime = 0x17,
            StatusEffect_10_ChangeTime = 0x18,
            StatusEffect_11_ChangeTime = 0x19,
            StatusEffect_12_ChangeTime = 0x1a,
            StatusEffect_13_ChangeTime = 0x1b,
            StatusEffect_14_ChangeTime = 0x1c,
            StatusEffect_15_ChangeTime = 0x1d,
            StatusEffect_16_ChangeTime = 0x1e,
            StatusEffect_17_ChangeTime = 0x1f,
            StatusEffect_18_ChangeTime = 0x20,
            StatusEffect_19_ChangeTime = 0x21,
            StatusEffect_1a_ChangeTime = 0x22,
            StatusEffect_1b_ChangeTime = 0x23,
            StatusEffect_1c_ChangeTime = 0x24,
            StatusEffect_1d_ChangeTime = 0x25,
            StatusEffect_1e_ChangeTime = 0x26,
            StatusEffect_1f_ChangeTime = 0x27,
            StatusEffect_00_Data = 0x28,
            StatusEffect_01_Data = 0x29,
            StatusEffect_02_Data = 0x2a,
            StatusEffect_03_Data = 0x2b,
            StatusEffect_04_Data = 0x2c,
            StatusEffect_05_Data = 0x2d,
            StatusEffect_06_Data = 0x2e,
            StatusEffect_07_Data = 0x2f,
            StatusEffect_08_Data = 0x30,
            StatusEffect_09_Data = 0x31,
            StatusEffect_0a_Data = 0x32,
            StatusEffect_0b_Data = 0x33,
            StatusEffect_0c_Data = 0x34,
            StatusEffect_0d_Data = 0x35,
            StatusEffect_0e_Data = 0x36,
            StatusEffect_0f_Data = 0x37,
            StatusEffect_10_Data = 0x38,
            StatusEffect_11_Data = 0x39,
            StatusEffect_12_Data = 0x3a,
            StatusEffect_13_Data = 0x3b,
            StatusEffect_14_Data = 0x3c,
            StatusEffect_15_Data = 0x3d,
            StatusEffect_16_Data = 0x3e,
            StatusEffect_17_Data = 0x3f,
            StatusEffect_18_Data = 0x40,
            StatusEffect_19_Data = 0x41,
            StatusEffect_1a_Data = 0x42,
            StatusEffect_1b_Data = 0x43,
            StatusEffect_1c_Data = 0x44,
            StatusEffect_1d_Data = 0x45,
            StatusEffect_1e_Data = 0x46,
            StatusEffect_1f_Data = 0x47,

            StatusEffect_00_Cancel = 0xa8,
            StatusEffect_01_Cancel = 0xa9,
            StatusEffect_02_Cancel = 0xaa,
            StatusEffect_03_Cancel = 0xab,
            StatusEffect_04_Cancel = 0xac,
            StatusEffect_05_Cancel = 0xad,
            StatusEffect_06_Cancel = 0xae,
            StatusEffect_07_Cancel = 0xaf,
            StatusEffect_08_Cancel = 0xb0,
            StatusEffect_09_Cancel = 0xb1,
            StatusEffect_0a_Cancel = 0xb2,
            StatusEffect_0b_Cancel = 0xb3,
            StatusEffect_0c_Cancel = 0xb4,
            StatusEffect_0d_Cancel = 0xb5,
            StatusEffect_0e_Cancel = 0xb6,
            StatusEffect_0f_Cancel = 0xb7,
            StatusEffect_10_Cancel = 0xb8,
            StatusEffect_11_Cancel = 0xb9,
            StatusEffect_12_Cancel = 0xba,
            StatusEffect_13_Cancel = 0xbb,
            StatusEffect_14_Cancel = 0xbc,
            StatusEffect_15_Cancel = 0xbd,
            StatusEffect_16_Cancel = 0xbe,
            StatusEffect_17_Cancel = 0xbf,
            StatusEffect_18_Cancel = 0xc0,
            StatusEffect_19_Cancel = 0xc1,
            StatusEffect_1a_Cancel = 0xc2,
            StatusEffect_1b_Cancel = 0xc3,
            StatusEffect_1c_Cancel = 0xc4,
            StatusEffect_1d_Cancel = 0xc5,
            StatusEffect_1e_Cancel = 0xc6,
            StatusEffect_1f_Cancel = 0xc7,
            
            AllowFriendlyPickup = 0x48,
            AllowHostilePickup = 0x49,
            SinCardType = 0x4a,
            SinCardFields_0 = 0x4b,
            SinCardFields_1 = 0x4c,
            SinCardFields_2 = 0x4d,
            SinCardFields_3 = 0x4e,
            SinCardFields_4 = 0x4f,
            SinCardFields_5 = 0x50,
            SinCardFields_6 = 0x51,
            SinCardFields_7 = 0x52,
            SinCardFields_8 = 0x53,
            SinCardFields_9 = 0x54,
            SinCardFields_10 = 0x55,
            SinCardFields_11 = 0x56,
            SinCardFields_12 = 0x57,
            SinCardFields_13 = 0x58,
            SinCardFields_14 = 0x59,
            SinCardFields_15 = 0x5a,
            SinCardFields_16 = 0x5b,
            SinCardFields_17 = 0x5c,
            SinCardFields_18 = 0x5d,
            SinCardFields_19 = 0x5e,
            SinCardFields_20 = 0x5f,
            SinCardFields_21 = 0x60,
            SinCardFields_22 = 0x61,
            VisualInfoGroupIndex = 0x62,
            ThrownField = 0x63,
            SeekField = 0x64,
            BounceField = 0x65,
            ScopeBubbleInfo = 0x66,

            Unk_0x86 = 0x86, // not sure if call with no data or if just a byte that belonged elsewhere
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield


        public float[] Position;
        public byte[] CarryingCharacterId;

        public float[] BounceField_Position;
        public float[] BounceField_MaybeVelocity;
        public uint? BounceField_Time;



        public ushort? StatusEffect_00_ChangeTime;
        public uint? StatusEffect_00_Id;
        public byte[] StatusEffect_00_Unk1;
        public byte[] StatusEffect_00_Entity;
        public uint? StatusEffect_00_Time1;
        public byte? StatusEffect_00_MoreDataFlag;
        public byte? StatusEffect_00_Data1_Count;
        public byte[] StatusEffect_00_Data1_Entity;
        public byte[] StatusEffect_00_UnkData;
        public float? StatusEffect_00_Data_Float1;
        public float? StatusEffect_00_Data_Float2;
        public bool? StatusEffect_00_Cancel;

        public ushort? StatusEffect_01_ChangeTime;
        public uint? StatusEffect_01_Id;
        public byte[] StatusEffect_01_Unk1;
        public byte[] StatusEffect_01_Entity;
        public uint? StatusEffect_01_Time1;
        public byte? StatusEffect_01_MoreDataFlag;
        public byte? StatusEffect_01_Data1_Count;
        public byte[] StatusEffect_01_Data1_Entity;
        public byte[] StatusEffect_01_UnkData;
        public float? StatusEffect_01_Data_Float1;
        public float? StatusEffect_01_Data_Float2;
        public bool? StatusEffect_01_Cancel;

        public ushort? StatusEffect_02_ChangeTime;
        public uint? StatusEffect_02_Id;
        public byte[] StatusEffect_02_Unk1;
        public byte[] StatusEffect_02_Entity;
        public uint? StatusEffect_02_Time1;
        public byte? StatusEffect_02_MoreDataFlag;
        public byte? StatusEffect_02_Data1_Count;
        public byte[] StatusEffect_02_Data1_Entity;
        public byte[] StatusEffect_02_UnkData;
        public float? StatusEffect_02_Data_Float1;
        public float? StatusEffect_02_Data_Float2;
        public bool? StatusEffect_02_Cancel;

        public ushort? StatusEffect_03_ChangeTime;
        public uint? StatusEffect_03_Id;
        public byte[] StatusEffect_03_Unk1;
        public byte[] StatusEffect_03_Entity;
        public uint? StatusEffect_03_Time1;
        public byte? StatusEffect_03_MoreDataFlag;
        public byte? StatusEffect_03_Data1_Count;
        public byte[] StatusEffect_03_Data1_Entity;
        public byte[] StatusEffect_03_UnkData;
        public float? StatusEffect_03_Data_Float1;
        public float? StatusEffect_03_Data_Float2;
        public bool? StatusEffect_03_Cancel;

        public ushort? StatusEffect_04_ChangeTime;
        public uint? StatusEffect_04_Id;
        public byte[] StatusEffect_04_Unk1;
        public byte[] StatusEffect_04_Entity;
        public uint? StatusEffect_04_Time1;
        public byte? StatusEffect_04_MoreDataFlag;
        public byte? StatusEffect_04_Data1_Count;
        public byte[] StatusEffect_04_Data1_Entity;
        public byte[] StatusEffect_04_UnkData;
        public float? StatusEffect_04_Data_Float1;
        public float? StatusEffect_04_Data_Float2;
        public bool? StatusEffect_04_Cancel;

        public ushort? StatusEffect_05_ChangeTime;
        public uint? StatusEffect_05_Id;
        public byte[] StatusEffect_05_Unk1;
        public byte[] StatusEffect_05_Entity;
        public uint? StatusEffect_05_Time1;
        public byte? StatusEffect_05_MoreDataFlag;
        public byte? StatusEffect_05_Data1_Count;
        public byte[] StatusEffect_05_Data1_Entity;
        public byte[] StatusEffect_05_UnkData;
        public float? StatusEffect_05_Data_Float1;
        public float? StatusEffect_05_Data_Float2;
        public bool? StatusEffect_05_Cancel;

        public ushort? StatusEffect_06_ChangeTime;
        public uint? StatusEffect_06_Id;
        public byte[] StatusEffect_06_Unk1;
        public byte[] StatusEffect_06_Entity;
        public uint? StatusEffect_06_Time1;
        public byte? StatusEffect_06_MoreDataFlag;
        public byte? StatusEffect_06_Data1_Count;
        public byte[] StatusEffect_06_Data1_Entity;
        public byte[] StatusEffect_06_UnkData;
        public float? StatusEffect_06_Data_Float1;
        public float? StatusEffect_06_Data_Float2;
        public bool? StatusEffect_06_Cancel;

        public ushort? StatusEffect_07_ChangeTime;
        public uint? StatusEffect_07_Id;
        public byte[] StatusEffect_07_Unk1;
        public byte[] StatusEffect_07_Entity;
        public uint? StatusEffect_07_Time1;
        public byte? StatusEffect_07_MoreDataFlag;
        public byte? StatusEffect_07_Data1_Count;
        public byte[] StatusEffect_07_Data1_Entity;
        public byte[] StatusEffect_07_UnkData;
        public float? StatusEffect_07_Data_Float1;
        public float? StatusEffect_07_Data_Float2;
        public bool? StatusEffect_07_Cancel;

        public ushort? StatusEffect_08_ChangeTime;
        public uint? StatusEffect_08_Id; 
        public byte[] StatusEffect_08_Unk1;
        public byte[] StatusEffect_08_Entity;
        public uint? StatusEffect_08_Time1;
        public byte? StatusEffect_08_MoreDataFlag;
        public byte? StatusEffect_08_Data1_Count;
        public byte[] StatusEffect_08_Data1_Entity;
        public byte[] StatusEffect_08_UnkData;
        public float? StatusEffect_08_Data_Float1;
        public float? StatusEffect_08_Data_Float2;
        public bool? StatusEffect_08_Cancel;

        public ushort? StatusEffect_09_ChangeTime;
        public uint? StatusEffect_09_Id;
        public byte[] StatusEffect_09_Unk1;
        public byte[] StatusEffect_09_Entity;
        public uint? StatusEffect_09_Time1;
        public byte? StatusEffect_09_MoreDataFlag;
        public byte? StatusEffect_09_Data1_Count;
        public byte[] StatusEffect_09_Data1_Entity;
        public byte[] StatusEffect_09_UnkData;
        public float? StatusEffect_09_Data_Float1;
        public float? StatusEffect_09_Data_Float2;
        public bool? StatusEffect_09_Cancel;

        public ushort? StatusEffect_0a_ChangeTime;
        public uint? StatusEffect_0a_Id;
        public byte[] StatusEffect_0a_Unk1;
        public byte[] StatusEffect_0a_Entity;
        public uint? StatusEffect_0a_Time1;
        public byte? StatusEffect_0a_MoreDataFlag;
        public byte? StatusEffect_0a_Data1_Count;
        public byte[] StatusEffect_0a_Data1_Entity;
        public byte[] StatusEffect_0a_UnkData;
        public float? StatusEffect_0a_Data_Float1;
        public float? StatusEffect_0a_Data_Float2;
        public bool? StatusEffect_0a_Cancel;

        public ushort? StatusEffect_0b_ChangeTime;
        public uint? StatusEffect_0b_Id;
        public byte[] StatusEffect_0b_Unk1;
        public byte[] StatusEffect_0b_Entity;
        public uint? StatusEffect_0b_Time1;
        public byte? StatusEffect_0b_MoreDataFlag;
        public byte? StatusEffect_0b_Data1_Count;
        public byte[] StatusEffect_0b_Data1_Entity;
        public byte[] StatusEffect_0b_UnkData;
        public float? StatusEffect_0b_Data_Float1;
        public float? StatusEffect_0b_Data_Float2;
        public bool? StatusEffect_0b_Cancel;

        public ushort? StatusEffect_0c_ChangeTime;
        public uint? StatusEffect_0c_Id;
        public byte[] StatusEffect_0c_Unk1;
        public byte[] StatusEffect_0c_Entity;
        public uint? StatusEffect_0c_Time1;
        public byte? StatusEffect_0c_MoreDataFlag;
        public byte? StatusEffect_0c_Data1_Count;
        public byte[] StatusEffect_0c_Data1_Entity;
        public byte[] StatusEffect_0c_UnkData;
        public float? StatusEffect_0c_Data_Float1;
        public float? StatusEffect_0c_Data_Float2;
        public bool? StatusEffect_0c_Cancel;

        public ushort? StatusEffect_0d_ChangeTime;
        public uint? StatusEffect_0d_Id;
        public byte[] StatusEffect_0d_Unk1;
        public byte[] StatusEffect_0d_Entity;
        public uint? StatusEffect_0d_Time1;
        public byte? StatusEffect_0d_MoreDataFlag;
        public byte? StatusEffect_0d_Data1_Count;
        public byte[] StatusEffect_0d_Data1_Entity;
        public byte[] StatusEffect_0d_UnkData;
        public float? StatusEffect_0d_Data_Float1;
        public float? StatusEffect_0d_Data_Float2;
        public bool? StatusEffect_0d_Cancel;

        public ushort? StatusEffect_0e_ChangeTime;
        public uint? StatusEffect_0e_Id;
        public byte[] StatusEffect_0e_Unk1;
        public byte[] StatusEffect_0e_Entity;
        public uint? StatusEffect_0e_Time1;
        public byte? StatusEffect_0e_MoreDataFlag;
        public byte? StatusEffect_0e_Data1_Count;
        public byte[] StatusEffect_0e_Data1_Entity;
        public byte[] StatusEffect_0e_UnkData;
        public float? StatusEffect_0e_Data_Float1;
        public float? StatusEffect_0e_Data_Float2;
        public bool? StatusEffect_0e_Cancel;

        public ushort? StatusEffect_0f_ChangeTime;
        public uint? StatusEffect_0f_Id;
        public byte[] StatusEffect_0f_Unk1;
        public byte[] StatusEffect_0f_Entity;
        public uint? StatusEffect_0f_Time1;
        public byte? StatusEffect_0f_MoreDataFlag;
        public byte? StatusEffect_0f_Data1_Count;
        public byte[] StatusEffect_0f_Data1_Entity;
        public byte[] StatusEffect_0f_UnkData;
        public float? StatusEffect_0f_Data_Float1;
        public float? StatusEffect_0f_Data_Float2;
        public bool? StatusEffect_0f_Cancel;

        public ushort? StatusEffect_10_ChangeTime;
        public uint? StatusEffect_10_Id;
        public byte[] StatusEffect_10_Unk1;
        public byte[] StatusEffect_10_Entity;
        public uint? StatusEffect_10_Time1;
        public byte? StatusEffect_10_MoreDataFlag;
        public byte? StatusEffect_10_Data1_Count;
        public byte[] StatusEffect_10_Data1_Entity;
        public byte[] StatusEffect_10_UnkData;
        public float? StatusEffect_10_Data_Float1;
        public float? StatusEffect_10_Data_Float2;
        public bool? StatusEffect_10_Cancel;

        public ushort? StatusEffect_11_ChangeTime;
        public uint? StatusEffect_11_Id;
        public byte[] StatusEffect_11_Unk1;
        public byte[] StatusEffect_11_Entity;
        public uint? StatusEffect_11_Time1;
        public byte? StatusEffect_11_MoreDataFlag;
        public byte? StatusEffect_11_Data1_Count;
        public byte[] StatusEffect_11_Data1_Entity;
        public byte[] StatusEffect_11_UnkData;
        public float? StatusEffect_11_Data_Float1;
        public float? StatusEffect_11_Data_Float2;
        public bool? StatusEffect_11_Cancel;

        public ushort? StatusEffect_12_ChangeTime;
        public uint? StatusEffect_12_Id;
        public byte[] StatusEffect_12_Unk1;
        public byte[] StatusEffect_12_Entity;
        public uint? StatusEffect_12_Time1;
        public byte? StatusEffect_12_MoreDataFlag;
        public byte? StatusEffect_12_Data1_Count;
        public byte[] StatusEffect_12_Data1_Entity;
        public byte[] StatusEffect_12_UnkData;
        public float? StatusEffect_12_Data_Float1;
        public float? StatusEffect_12_Data_Float2;
        public bool? StatusEffect_12_Cancel;

        public ushort? StatusEffect_13_ChangeTime;
        public uint? StatusEffect_13_Id;
        public byte[] StatusEffect_13_Unk1;
        public byte[] StatusEffect_13_Entity;
        public uint? StatusEffect_13_Time1;
        public byte? StatusEffect_13_MoreDataFlag;
        public byte? StatusEffect_13_Data1_Count;
        public byte[] StatusEffect_13_Data1_Entity;
        public byte[] StatusEffect_13_UnkData;
        public float? StatusEffect_13_Data_Float1;
        public float? StatusEffect_13_Data_Float2;
        public bool? StatusEffect_13_Cancel;

        public ushort? StatusEffect_14_ChangeTime;
        public uint? StatusEffect_14_Id;
        public byte[] StatusEffect_14_Unk1;
        public byte[] StatusEffect_14_Entity;
        public uint? StatusEffect_14_Time1;
        public byte? StatusEffect_14_MoreDataFlag;
        public byte? StatusEffect_14_Data1_Count;
        public byte[] StatusEffect_14_Data1_Entity;
        public byte[] StatusEffect_14_UnkData;
        public float? StatusEffect_14_Data_Float1;
        public float? StatusEffect_14_Data_Float2;
        public bool? StatusEffect_14_Cancel;

        public ushort? StatusEffect_15_ChangeTime;
        public uint? StatusEffect_15_Id;
        public byte[] StatusEffect_15_Unk1;
        public byte[] StatusEffect_15_Entity;
        public uint? StatusEffect_15_Time1;
        public byte? StatusEffect_15_MoreDataFlag;
        public byte? StatusEffect_15_Data1_Count;
        public byte[] StatusEffect_15_Data1_Entity;
        public byte[] StatusEffect_15_UnkData;
        public float? StatusEffect_15_Data_Float1;
        public float? StatusEffect_15_Data_Float2;
        public bool? StatusEffect_15_Cancel;

        public ushort? StatusEffect_16_ChangeTime;
        public uint? StatusEffect_16_Id;
        public byte[] StatusEffect_16_Unk1;
        public byte[] StatusEffect_16_Entity;
        public uint? StatusEffect_16_Time1;
        public byte? StatusEffect_16_MoreDataFlag;
        public byte? StatusEffect_16_Data1_Count;
        public byte[] StatusEffect_16_Data1_Entity;
        public byte[] StatusEffect_16_UnkData;
        public float? StatusEffect_16_Data_Float1;
        public float? StatusEffect_16_Data_Float2;
        public bool? StatusEffect_16_Cancel;

        public ushort? StatusEffect_17_ChangeTime;
        public uint? StatusEffect_17_Id;
        public byte[] StatusEffect_17_Unk1;
        public byte[] StatusEffect_17_Entity;
        public uint? StatusEffect_17_Time1;
        public byte? StatusEffect_17_MoreDataFlag;
        public byte? StatusEffect_17_Data1_Count;
        public byte[] StatusEffect_17_Data1_Entity;
        public byte[] StatusEffect_17_UnkData;
        public float? StatusEffect_17_Data_Float1;
        public float? StatusEffect_17_Data_Float2;
        public bool? StatusEffect_17_Cancel;

        public ushort? StatusEffect_18_ChangeTime;
        public uint? StatusEffect_18_Id; 
        public byte[] StatusEffect_18_Unk1;
        public byte[] StatusEffect_18_Entity;
        public uint? StatusEffect_18_Time1;
        public byte? StatusEffect_18_MoreDataFlag;
        public byte? StatusEffect_18_Data1_Count;
        public byte[] StatusEffect_18_Data1_Entity;
        public byte[] StatusEffect_18_UnkData;
        public float? StatusEffect_18_Data_Float1;
        public float? StatusEffect_18_Data_Float2;
        public bool? StatusEffect_18_Cancel;

        public ushort? StatusEffect_19_ChangeTime;
        public uint? StatusEffect_19_Id;
        public byte[] StatusEffect_19_Unk1;
        public byte[] StatusEffect_19_Entity;
        public uint? StatusEffect_19_Time1;
        public byte? StatusEffect_19_MoreDataFlag;
        public byte? StatusEffect_19_Data1_Count;
        public byte[] StatusEffect_19_Data1_Entity;
        public byte[] StatusEffect_19_UnkData;
        public float? StatusEffect_19_Data_Float1;
        public float? StatusEffect_19_Data_Float2;
        public bool? StatusEffect_19_Cancel;

        public ushort? StatusEffect_1a_ChangeTime;
        public uint? StatusEffect_1a_Id;
        public byte[] StatusEffect_1a_Unk1;
        public byte[] StatusEffect_1a_Entity;
        public uint? StatusEffect_1a_Time1;
        public byte? StatusEffect_1a_MoreDataFlag;
        public byte? StatusEffect_1a_Data1_Count;
        public byte[] StatusEffect_1a_Data1_Entity;
        public byte[] StatusEffect_1a_UnkData;
        public float? StatusEffect_1a_Data_Float1;
        public float? StatusEffect_1a_Data_Float2;
        public bool? StatusEffect_1a_Cancel;

        public ushort? StatusEffect_1b_ChangeTime;
        public uint? StatusEffect_1b_Id;
        public byte[] StatusEffect_1b_Unk1;
        public byte[] StatusEffect_1b_Entity;
        public uint? StatusEffect_1b_Time1;
        public byte? StatusEffect_1b_MoreDataFlag;
        public byte? StatusEffect_1b_Data1_Count;
        public byte[] StatusEffect_1b_Data1_Entity;
        public byte[] StatusEffect_1b_UnkData;
        public float? StatusEffect_1b_Data_Float1;
        public float? StatusEffect_1b_Data_Float2;
        public bool? StatusEffect_1b_Cancel;

        public ushort? StatusEffect_1c_ChangeTime;
        public uint? StatusEffect_1c_Id;
        public byte[] StatusEffect_1c_Unk1;
        public byte[] StatusEffect_1c_Entity;
        public uint? StatusEffect_1c_Time1;
        public byte? StatusEffect_1c_MoreDataFlag;
        public byte? StatusEffect_1c_Data1_Count;
        public byte[] StatusEffect_1c_Data1_Entity;
        public byte[] StatusEffect_1c_UnkData;
        public float? StatusEffect_1c_Data_Float1;
        public float? StatusEffect_1c_Data_Float2;
        public bool? StatusEffect_1c_Cancel;

        public ushort? StatusEffect_1d_ChangeTime;
        public uint? StatusEffect_1d_Id;
        public byte[] StatusEffect_1d_Unk1;
        public byte[] StatusEffect_1d_Entity;
        public uint? StatusEffect_1d_Time1;
        public byte? StatusEffect_1d_MoreDataFlag;
        public byte? StatusEffect_1d_Data1_Count;
        public byte[] StatusEffect_1d_Data1_Entity;
        public byte[] StatusEffect_1d_UnkData;
        public float? StatusEffect_1d_Data_Float1;
        public float? StatusEffect_1d_Data_Float2;
        public bool? StatusEffect_1d_Cancel;

        public ushort? StatusEffect_1e_ChangeTime;
        public uint? StatusEffect_1e_Id;
        public byte[] StatusEffect_1e_Unk1;
        public byte[] StatusEffect_1e_Entity;
        public uint? StatusEffect_1e_Time1;
        public byte? StatusEffect_1e_MoreDataFlag;
        public byte? StatusEffect_1e_Data1_Count;
        public byte[] StatusEffect_1e_Data1_Entity;
        public byte[] StatusEffect_1e_UnkData;
        public float? StatusEffect_1e_Data_Float1;
        public float? StatusEffect_1e_Data_Float2;
        public bool? StatusEffect_1e_Cancel;

        public ushort? StatusEffect_1f_ChangeTime;
        public uint? StatusEffect_1f_Id;
        public byte[] StatusEffect_1f_Unk1;
        public byte[] StatusEffect_1f_Entity;
        public uint? StatusEffect_1f_Time1;
        public byte? StatusEffect_1f_MoreDataFlag;
        public byte? StatusEffect_1f_Data1_Count;
        public byte[] StatusEffect_1f_Data1_Entity;
        public byte[] StatusEffect_1f_UnkData;
        public float? StatusEffect_1f_Data_Float1;
        public float? StatusEffect_1f_Data_Float2;
        public bool? StatusEffect_1f_Cancel;



        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;

                    case ShadowFieldIndex.CarryingCharacterId:
                        CarryingCharacterId = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.BounceField:
                        BounceField_Position = Stream.Read.FloatArray(3);
                        BounceField_MaybeVelocity = Stream.Read.FloatArray(3);
                        BounceField_Time = Stream.Read.UInt();
                        break;


                    case ShadowFieldIndex.StatusEffect_00_ChangeTime:
                        StatusEffect_00_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_01_ChangeTime:
                        StatusEffect_01_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_02_ChangeTime:
                        StatusEffect_02_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_03_ChangeTime:
                        StatusEffect_03_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_04_ChangeTime:
                        StatusEffect_04_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_05_ChangeTime:
                        StatusEffect_05_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_06_ChangeTime:
                        StatusEffect_06_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_07_ChangeTime:
                        StatusEffect_07_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_08_ChangeTime:
                        StatusEffect_08_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_09_ChangeTime:
                        StatusEffect_09_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0a_ChangeTime:
                        StatusEffect_0a_ChangeTime = Stream.Read.UShort();
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

                    case ShadowFieldIndex.StatusEffect_15_ChangeTime:
                        StatusEffect_15_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_16_ChangeTime:
                        StatusEffect_16_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_17_ChangeTime:
                        StatusEffect_17_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_18_ChangeTime:
                        StatusEffect_18_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_19_ChangeTime:
                        StatusEffect_19_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1a_ChangeTime:
                        StatusEffect_1a_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1b_ChangeTime:
                        StatusEffect_1b_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1c_ChangeTime:
                        StatusEffect_1c_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1d_ChangeTime:
                        StatusEffect_1d_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1e_ChangeTime:
                        StatusEffect_1e_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1f_ChangeTime:
                        StatusEffect_1f_ChangeTime = Stream.Read.UShort();
                        break;


                    case ShadowFieldIndex.StatusEffect_00_Data:
                        StatusEffect_00_Id     = Stream.Read.UInt();
                        StatusEffect_00_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_00_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_00_Time1  = Stream.Read.UInt();
                        StatusEffect_00_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_00_MoreDataFlag == 0x01)
                        {
                            StatusEffect_00_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_00_Data1_Count > 0) {
                                StatusEffect_00_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_00_Data1_Count);
                            }
                            StatusEffect_00_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_00_Data_Float1 = Stream.Read.Float();
                            StatusEffect_00_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_01_Data:
                        StatusEffect_01_Id     = Stream.Read.UInt();
                        StatusEffect_01_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_01_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_01_Time1  = Stream.Read.UInt();
                        StatusEffect_01_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_01_MoreDataFlag == 0x01)
                        {
                            StatusEffect_01_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_01_Data1_Count > 0) {
                                StatusEffect_01_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_01_Data1_Count);
                            }
                            StatusEffect_01_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_01_Data_Float1 = Stream.Read.Float();
                            StatusEffect_01_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_02_Data:
                        StatusEffect_02_Id     = Stream.Read.UInt();
                        StatusEffect_02_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_02_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_02_Time1  = Stream.Read.UInt();
                        StatusEffect_02_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_02_MoreDataFlag == 0x01)
                        {
                            StatusEffect_02_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_02_Data1_Count > 0) {
                                StatusEffect_02_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_02_Data1_Count);
                            }
                            StatusEffect_02_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_02_Data_Float1 = Stream.Read.Float();
                            StatusEffect_02_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_03_Data:
                        StatusEffect_03_Id     = Stream.Read.UInt();
                        StatusEffect_03_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_03_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_03_Time1  = Stream.Read.UInt();
                        StatusEffect_03_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_03_MoreDataFlag == 0x01)
                        {
                            StatusEffect_03_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_03_Data1_Count > 0) {
                                StatusEffect_03_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_03_Data1_Count);
                            }
                            StatusEffect_03_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_03_Data_Float1 = Stream.Read.Float();
                            StatusEffect_03_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_04_Data:
                        StatusEffect_04_Id     = Stream.Read.UInt();
                        StatusEffect_04_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_04_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_04_Time1  = Stream.Read.UInt();
                        StatusEffect_04_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_04_MoreDataFlag == 0x01)
                        {
                            StatusEffect_04_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_04_Data1_Count > 0) {
                                StatusEffect_04_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_04_Data1_Count);
                            }
                            StatusEffect_04_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_04_Data_Float1 = Stream.Read.Float();
                            StatusEffect_04_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_05_Data:
                        StatusEffect_05_Id     = Stream.Read.UInt();
                        StatusEffect_05_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_05_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_05_Time1  = Stream.Read.UInt();
                        StatusEffect_05_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_05_MoreDataFlag == 0x01)
                        {
                            StatusEffect_05_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_05_Data1_Count > 0) {
                                StatusEffect_05_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_05_Data1_Count);
                            }
                            StatusEffect_05_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_05_Data_Float1 = Stream.Read.Float();
                            StatusEffect_05_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_06_Data:
                        StatusEffect_06_Id     = Stream.Read.UInt();
                        StatusEffect_06_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_06_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_06_Time1  = Stream.Read.UInt();
                        StatusEffect_06_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_06_MoreDataFlag == 0x01)
                        {
                            StatusEffect_06_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_06_Data1_Count > 0) {
                                StatusEffect_06_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_06_Data1_Count);
                            }
                            StatusEffect_06_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_06_Data_Float1 = Stream.Read.Float();
                            StatusEffect_06_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_07_Data:
                        StatusEffect_07_Id     = Stream.Read.UInt();
                        StatusEffect_07_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_07_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_07_Time1  = Stream.Read.UInt();
                        StatusEffect_07_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_07_MoreDataFlag == 0x01)
                        {
                            StatusEffect_07_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_07_Data1_Count > 0) {
                                StatusEffect_07_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_07_Data1_Count);
                            }
                            StatusEffect_07_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_07_Data_Float1 = Stream.Read.Float();
                            StatusEffect_07_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_08_Data:
                        StatusEffect_08_Id     = Stream.Read.UInt();
                        StatusEffect_08_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_08_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_08_Time1  = Stream.Read.UInt();
                        StatusEffect_08_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_08_MoreDataFlag == 0x01)
                        {
                            StatusEffect_08_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_08_Data1_Count > 0) {
                                StatusEffect_08_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_08_Data1_Count);
                            }
                            StatusEffect_08_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_08_Data_Float1 = Stream.Read.Float();
                            StatusEffect_08_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_09_Data:
                        StatusEffect_09_Id     = Stream.Read.UInt();
                        StatusEffect_09_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_09_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_09_Time1  = Stream.Read.UInt();
                        StatusEffect_09_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_09_MoreDataFlag == 0x01)
                        {
                            StatusEffect_09_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_09_Data1_Count > 0) {
                                StatusEffect_09_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_09_Data1_Count);
                            }
                            StatusEffect_09_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_09_Data_Float1 = Stream.Read.Float();
                            StatusEffect_09_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0a_Data:
                        StatusEffect_0a_Id     = Stream.Read.UInt();
                        StatusEffect_0a_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0a_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0a_Time1  = Stream.Read.UInt();
                        StatusEffect_0a_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0a_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0a_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0a_Data1_Count > 0) {
                                StatusEffect_0a_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0a_Data1_Count);
                            }
                            StatusEffect_0a_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0a_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0a_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0b_Data:
                        StatusEffect_0b_Id     = Stream.Read.UInt();
                        StatusEffect_0b_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0b_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0b_Time1  = Stream.Read.UInt();
                        StatusEffect_0b_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0b_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0b_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0b_Data1_Count > 0) {
                                StatusEffect_0b_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0b_Data1_Count);
                            }
                            StatusEffect_0b_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0b_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0b_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0c_Data:
                        StatusEffect_0c_Id     = Stream.Read.UInt();
                        StatusEffect_0c_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0c_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0c_Time1  = Stream.Read.UInt();
                        StatusEffect_0c_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0c_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0c_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0c_Data1_Count > 0) {
                                StatusEffect_0c_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0c_Data1_Count);
                            }
                            StatusEffect_0c_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0c_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0c_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0d_Data:
                        StatusEffect_0d_Id     = Stream.Read.UInt();
                        StatusEffect_0d_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0d_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0d_Time1  = Stream.Read.UInt();
                        StatusEffect_0d_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0d_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0d_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0d_Data1_Count > 0) {
                                StatusEffect_0d_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0d_Data1_Count);
                            }
                            StatusEffect_0d_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0d_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0d_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0e_Data:
                        StatusEffect_0e_Id     = Stream.Read.UInt();
                        StatusEffect_0e_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0e_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0e_Time1  = Stream.Read.UInt();
                        StatusEffect_0e_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0e_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0e_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0e_Data1_Count > 0) {
                                StatusEffect_0e_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0e_Data1_Count);
                            }
                            StatusEffect_0e_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0e_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0e_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0f_Data:
                        StatusEffect_0f_Id     = Stream.Read.UInt();
                        StatusEffect_0f_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0f_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0f_Time1  = Stream.Read.UInt();
                        StatusEffect_0f_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_0f_MoreDataFlag == 0x01)
                        {
                            StatusEffect_0f_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_0f_Data1_Count > 0) {
                                StatusEffect_0f_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_0f_Data1_Count);
                            }
                            StatusEffect_0f_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_0f_Data_Float1 = Stream.Read.Float();
                            StatusEffect_0f_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_10_Data:
                        StatusEffect_10_Id     = Stream.Read.UInt();
                        StatusEffect_10_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_10_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_10_Time1  = Stream.Read.UInt();
                        StatusEffect_10_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_10_MoreDataFlag == 0x01)
                        {
                            StatusEffect_10_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_10_Data1_Count > 0) {
                                StatusEffect_10_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_10_Data1_Count);
                            }
                            StatusEffect_10_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_10_Data_Float1 = Stream.Read.Float();
                            StatusEffect_10_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_11_Data:
                        StatusEffect_11_Id     = Stream.Read.UInt();
                        StatusEffect_11_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_11_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_11_Time1  = Stream.Read.UInt();
                        StatusEffect_11_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_11_MoreDataFlag == 0x01)
                        {
                            StatusEffect_11_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_11_Data1_Count > 0) {
                                StatusEffect_11_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_11_Data1_Count);
                            }
                            StatusEffect_11_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_11_Data_Float1 = Stream.Read.Float();
                            StatusEffect_11_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_12_Data:
                        StatusEffect_12_Id     = Stream.Read.UInt();
                        StatusEffect_12_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_12_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_12_Time1  = Stream.Read.UInt();
                        StatusEffect_12_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_12_MoreDataFlag == 0x01)
                        {
                            StatusEffect_12_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_12_Data1_Count > 0) {
                                StatusEffect_12_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_12_Data1_Count);
                            }
                            StatusEffect_12_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_12_Data_Float1 = Stream.Read.Float();
                            StatusEffect_12_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_13_Data:
                        StatusEffect_13_Id     = Stream.Read.UInt();
                        StatusEffect_13_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_13_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_13_Time1  = Stream.Read.UInt();
                        StatusEffect_13_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_13_MoreDataFlag == 0x01)
                        {
                            StatusEffect_13_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_13_Data1_Count > 0) {
                                StatusEffect_13_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_13_Data1_Count);
                            }
                            StatusEffect_13_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_13_Data_Float1 = Stream.Read.Float();
                            StatusEffect_13_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_14_Data:
                        StatusEffect_14_Id     = Stream.Read.UInt();
                        StatusEffect_14_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_14_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_14_Time1  = Stream.Read.UInt();
                        StatusEffect_14_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_14_MoreDataFlag == 0x01)
                        {
                            StatusEffect_14_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_14_Data1_Count > 0) {
                                StatusEffect_14_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_14_Data1_Count);
                            }
                            StatusEffect_14_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_14_Data_Float1 = Stream.Read.Float();
                            StatusEffect_14_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_15_Data:
                        StatusEffect_15_Id     = Stream.Read.UInt();
                        StatusEffect_15_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_15_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_15_Time1  = Stream.Read.UInt();
                        StatusEffect_15_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_15_MoreDataFlag == 0x01)
                        {
                            StatusEffect_15_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_15_Data1_Count > 0) {
                                StatusEffect_15_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_15_Data1_Count);
                            }
                            StatusEffect_15_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_15_Data_Float1 = Stream.Read.Float();
                            StatusEffect_15_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_16_Data:
                        StatusEffect_16_Id     = Stream.Read.UInt();
                        StatusEffect_16_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_16_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_16_Time1  = Stream.Read.UInt();
                        StatusEffect_16_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_16_MoreDataFlag == 0x01)
                        {
                            StatusEffect_16_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_16_Data1_Count > 0) {
                                StatusEffect_16_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_16_Data1_Count);
                            }
                            StatusEffect_16_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_16_Data_Float1 = Stream.Read.Float();
                            StatusEffect_16_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_17_Data:
                        StatusEffect_17_Id     = Stream.Read.UInt();
                        StatusEffect_17_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_17_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_17_Time1  = Stream.Read.UInt();
                        StatusEffect_17_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_17_MoreDataFlag == 0x01)
                        {
                            StatusEffect_17_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_17_Data1_Count > 0) {
                                StatusEffect_17_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_17_Data1_Count);
                            }
                            StatusEffect_17_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_17_Data_Float1 = Stream.Read.Float();
                            StatusEffect_17_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_18_Data:
                        StatusEffect_18_Id     = Stream.Read.UInt();
                        StatusEffect_18_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_18_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_18_Time1  = Stream.Read.UInt();
                        StatusEffect_18_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_18_MoreDataFlag == 0x01)
                        {
                            StatusEffect_18_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_18_Data1_Count > 0) {
                                StatusEffect_18_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_18_Data1_Count);
                            }
                            StatusEffect_18_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_18_Data_Float1 = Stream.Read.Float();
                            StatusEffect_18_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_19_Data:
                        StatusEffect_19_Id     = Stream.Read.UInt();
                        StatusEffect_19_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_19_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_19_Time1  = Stream.Read.UInt();
                        StatusEffect_19_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_19_MoreDataFlag == 0x01)
                        {
                            StatusEffect_19_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_19_Data1_Count > 0) {
                                StatusEffect_19_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_19_Data1_Count);
                            }
                            StatusEffect_19_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_19_Data_Float1 = Stream.Read.Float();
                            StatusEffect_19_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1a_Data:
                        StatusEffect_1a_Id     = Stream.Read.UInt();
                        StatusEffect_1a_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1a_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1a_Time1  = Stream.Read.UInt();
                        StatusEffect_1a_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1a_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1a_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1a_Data1_Count > 0) {
                                StatusEffect_1a_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1a_Data1_Count);
                            }
                            StatusEffect_1a_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1a_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1a_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1b_Data:
                        StatusEffect_1b_Id     = Stream.Read.UInt();
                        StatusEffect_1b_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1b_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1b_Time1  = Stream.Read.UInt();
                        StatusEffect_1b_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1b_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1b_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1b_Data1_Count > 0) {
                                StatusEffect_1b_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1b_Data1_Count);
                            }
                            StatusEffect_1b_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1b_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1b_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1c_Data:
                        StatusEffect_1c_Id     = Stream.Read.UInt();
                        StatusEffect_1c_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1c_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1c_Time1  = Stream.Read.UInt();
                        StatusEffect_1c_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1c_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1c_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1c_Data1_Count > 0) {
                                StatusEffect_1c_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1c_Data1_Count);
                            }
                            StatusEffect_1c_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1c_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1c_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1d_Data:
                        StatusEffect_1d_Id     = Stream.Read.UInt();
                        StatusEffect_1d_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1d_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1d_Time1  = Stream.Read.UInt();
                        StatusEffect_1d_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1d_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1d_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1d_Data1_Count > 0) {
                                StatusEffect_1d_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1d_Data1_Count);
                            }
                            StatusEffect_1d_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1d_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1d_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1e_Data:
                        StatusEffect_1e_Id     = Stream.Read.UInt();
                        StatusEffect_1e_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1e_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1e_Time1  = Stream.Read.UInt();
                        StatusEffect_1e_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1e_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1e_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1e_Data1_Count > 0) {
                                StatusEffect_1e_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1e_Data1_Count);
                            }
                            StatusEffect_1e_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1e_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1e_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1f_Data:
                        StatusEffect_1f_Id     = Stream.Read.UInt();
                        StatusEffect_1f_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1f_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1f_Time1  = Stream.Read.UInt();
                        StatusEffect_1f_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_1f_MoreDataFlag == 0x01)
                        {
                            StatusEffect_1f_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_1f_Data1_Count > 0) {
                                StatusEffect_1f_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_1f_Data1_Count);
                            }
                            StatusEffect_1f_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_1f_Data_Float1 = Stream.Read.Float();
                            StatusEffect_1f_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    // These keys do not come with any data
                    case ShadowFieldIndex.StatusEffect_00_Cancel:
                        StatusEffect_00_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_01_Cancel:
                        StatusEffect_01_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_02_Cancel:
                        StatusEffect_02_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_03_Cancel:
                        StatusEffect_03_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_04_Cancel:
                        StatusEffect_04_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_05_Cancel:
                        StatusEffect_05_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_06_Cancel:
                        StatusEffect_06_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_07_Cancel:
                        StatusEffect_07_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_08_Cancel:
                        StatusEffect_08_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_09_Cancel:
                        StatusEffect_09_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0a_Cancel:
                        StatusEffect_0a_Cancel = true;
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
                    case ShadowFieldIndex.StatusEffect_15_Cancel:
                        StatusEffect_15_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_16_Cancel:
                        StatusEffect_16_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_17_Cancel:
                        StatusEffect_17_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_18_Cancel:
                        StatusEffect_18_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_19_Cancel:
                        StatusEffect_19_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1a_Cancel:
                        StatusEffect_1a_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1b_Cancel:
                        StatusEffect_1b_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1c_Cancel:
                        StatusEffect_1c_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1d_Cancel:
                        StatusEffect_1d_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1e_Cancel:
                        StatusEffect_1e_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1f_Cancel:
                        StatusEffect_1f_Cancel = true;
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