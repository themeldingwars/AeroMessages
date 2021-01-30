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
            StatusEffects_0_ChangeTime = 0x08,
            StatusEffects_1_ChangeTime = 0x09,
            StatusEffects_2_ChangeTime = 0x0a,
            StatusEffects_3_ChangeTime = 0x0b,
            StatusEffects_4_ChangeTime = 0x0c,
            StatusEffects_5_ChangeTime = 0x0d,
            StatusEffects_6_ChangeTime = 0x0e,
            StatusEffects_7_ChangeTime = 0x0f,
            StatusEffects_8_ChangeTime = 0x10,
            StatusEffects_9_ChangeTime = 0x11,
            StatusEffects_10_ChangeTime = 0x12,
            StatusEffects_11_ChangeTime = 0x13,
            StatusEffects_12_ChangeTime = 0x14,
            StatusEffects_13_ChangeTime = 0x15,
            StatusEffects_14_ChangeTime = 0x16,
            StatusEffects_15_ChangeTime = 0x17,
            StatusEffects_16_ChangeTime = 0x18,
            StatusEffects_17_ChangeTime = 0x19,
            StatusEffects_18_ChangeTime = 0x1a,
            StatusEffects_19_ChangeTime = 0x1b,
            StatusEffects_20_ChangeTime = 0x1c,
            StatusEffects_21_ChangeTime = 0x1d,
            StatusEffects_22_ChangeTime = 0x1e,
            StatusEffects_23_ChangeTime = 0x1f,
            StatusEffects_24_ChangeTime = 0x20,
            StatusEffects_25_ChangeTime = 0x21,
            StatusEffects_26_ChangeTime = 0x22,
            StatusEffects_27_ChangeTime = 0x23,
            StatusEffects_28_ChangeTime = 0x24,
            StatusEffects_29_ChangeTime = 0x25,
            StatusEffects_30_ChangeTime = 0x26,
            StatusEffects_31_ChangeTime = 0x27,
            StatusEffects_0_Data = 0x28,
            StatusEffects_1_Data = 0x29,
            StatusEffects_2_Data = 0x2a,
            StatusEffects_3_Data = 0x2b,
            StatusEffects_4_Data = 0x2c,
            StatusEffects_5_Data = 0x2d,
            StatusEffects_6_Data = 0x2e,
            StatusEffects_7_Data = 0x2f,
            StatusEffects_8_Data = 0x30,
            StatusEffects_9_Data = 0x31,
            StatusEffects_10_Data = 0x32,
            StatusEffects_11_Data = 0x33,
            StatusEffects_12_Data = 0x34,
            StatusEffects_13_Data = 0x35,
            StatusEffects_14_Data = 0x36,
            StatusEffects_15_Data = 0x37,
            StatusEffects_16_Data = 0x38,
            StatusEffects_17_Data = 0x39,
            StatusEffects_18_Data = 0x3a,
            StatusEffects_19_Data = 0x3b,
            StatusEffects_20_Data = 0x3c,
            StatusEffects_21_Data = 0x3d,
            StatusEffects_22_Data = 0x3e,
            StatusEffects_23_Data = 0x3f,
            StatusEffects_24_Data = 0x40,
            StatusEffects_25_Data = 0x41,
            StatusEffects_26_Data = 0x42,
            StatusEffects_27_Data = 0x43,
            StatusEffects_28_Data = 0x44,
            StatusEffects_29_Data = 0x45,
            StatusEffects_30_Data = 0x46,
            StatusEffects_31_Data = 0x47,
            
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





            Clear_PersonalFactionStance = 133, // assumption
            Clear_CarryingCharacterId = 134, // guess
            Clear_ForcedMovement = 135, // guess

            Clear_StatusEffects_0 = 0xa8,
            Clear_StatusEffects_1 = 0xa9,
            Clear_StatusEffects_2 = 0xaa,
            Clear_StatusEffects_3 = 0xab,
            Clear_StatusEffects_4 = 0xac,
            Clear_StatusEffects_5 = 0xad,
            Clear_StatusEffects_6 = 0xae,
            Clear_StatusEffects_7 = 0xaf,
            Clear_StatusEffects_8 = 0xb0,
            Clear_StatusEffects_9 = 0xb1,
            Clear_StatusEffects_10 = 0xb2,
            Clear_StatusEffects_11 = 0xb3,
            Clear_StatusEffects_12 = 0xb4,
            Clear_StatusEffects_13 = 0xb5,
            Clear_StatusEffects_14 = 0xb6,
            Clear_StatusEffects_15 = 0xb7,
            Clear_StatusEffects_16 = 0xb8,
            Clear_StatusEffects_17 = 0xb9,
            Clear_StatusEffects_18 = 0xba,
            Clear_StatusEffects_19 = 0xbb,
            Clear_StatusEffects_20 = 0xbc,
            Clear_StatusEffects_21 = 0xbd,
            Clear_StatusEffects_22 = 0xbe,
            Clear_StatusEffects_23 = 0xbf,
            Clear_StatusEffects_24 = 0xc0,
            Clear_StatusEffects_25 = 0xc1,
            Clear_StatusEffects_26 = 0xc2,
            Clear_StatusEffects_27 = 0xc3,
            Clear_StatusEffects_28 = 0xc4,
            Clear_StatusEffects_29 = 0xc5,
            Clear_StatusEffects_30 = 0xc6,
            Clear_StatusEffects_31 = 0xc7,

            Clear_SinCardFields_0  = 203, // 0xcb
            Clear_SinCardFields_1  = 204,
            Clear_SinCardFields_2  = 205,
            Clear_SinCardFields_3  = 206,
            Clear_SinCardFields_4  = 207,
            Clear_SinCardFields_5  = 208,
            Clear_SinCardFields_6  = 209,
            Clear_SinCardFields_7  = 210,
            Clear_SinCardFields_8  = 211,
            Clear_SinCardFields_9  = 212,
            Clear_SinCardFields_10 = 213,
            Clear_SinCardFields_11 = 214,
            Clear_SinCardFields_12 = 215,
            Clear_SinCardFields_13 = 216,
            Clear_SinCardFields_14 = 217,
            Clear_SinCardFields_15 = 218,
            Clear_SinCardFields_16 = 219,
            Clear_SinCardFields_17 = 220,
            Clear_SinCardFields_18 = 221,
            Clear_SinCardFields_19 = 222,
            Clear_SinCardFields_20 = 223,
            Clear_SinCardFields_21 = 224,
            Clear_SinCardFields_22 = 225, // 0xe1

            Clear_ThrownField = 227, // guess
            Clear_SeekField = 228, // guess
            Clear_BounceField = 229, // guess
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield


        public uint? CarryableObjectTypeId; // Sdb table 480, id column.
        public string Name;
        public float[] Position;
        public float[] Orientation;
        public byte? Hostility_Mode;
        public byte? Hostility_Id;


        public byte[] PersonalFactionStance;
        public byte[] CarryingCharacterId;
        public byte[] ForcedMovement;

        public byte? AllowFriendlyPickup; // guess
        public byte? AllowHostilePickup; // guess
        public uint? SinCardType;

        

        public float[] ThrownField_Unk1_Floats;
        public byte[] ThrownField_Unk2_Bytes;

        public float[] BounceField_Position;
        public float[] BounceField_MaybeVelocity;
        public uint? BounceField_Time;


        public byte? VisualInfoGroupIndex;
        public byte[] ScopeBubbleInfo;


        public bool? Clear_PersonalFactionStance;
        public bool? Clear_CarryingCharacterId;
        public bool? Clear_ForcedMovement;
        public bool? Clear_SinCardFields_0;
        public bool? Clear_SinCardFields_1;
        public bool? Clear_SinCardFields_2;
        public bool? Clear_SinCardFields_3;
        public bool? Clear_SinCardFields_4;
        public bool? Clear_SinCardFields_5;
        public bool? Clear_SinCardFields_6;
        public bool? Clear_SinCardFields_7;
        public bool? Clear_SinCardFields_8;
        public bool? Clear_SinCardFields_9;
        public bool? Clear_SinCardFields_10;
        public bool? Clear_SinCardFields_11;
        public bool? Clear_SinCardFields_12;
        public bool? Clear_SinCardFields_13;
        public bool? Clear_SinCardFields_14;
        public bool? Clear_SinCardFields_15;
        public bool? Clear_SinCardFields_16;
        public bool? Clear_SinCardFields_17;
        public bool? Clear_SinCardFields_18;
        public bool? Clear_SinCardFields_19;
        public bool? Clear_SinCardFields_20;
        public bool? Clear_SinCardFields_21;
        public bool? Clear_SinCardFields_22;
        public bool? Clear_ThrownField;
        public bool? Clear_SeekField;
        public bool? Clear_BounceField;


        public ushort? StatusEffects_0_ChangeTime;
        public uint? StatusEffects_0_Id;
        public byte[] StatusEffects_0_Unk1;
        public byte[] StatusEffects_0_Entity;
        public uint? StatusEffects_0_Time1;
        public byte? StatusEffects_0_MoreDataFlag;
        public byte? StatusEffects_0_Data1_Count;
        public byte[] StatusEffects_0_Data1_Entity;
        public byte[] StatusEffects_0_UnkData;
        public float? StatusEffects_0_Data_Float1;
        public float? StatusEffects_0_Data_Float2;
        public bool? Clear_StatusEffects_0;

        public ushort? StatusEffects_1_ChangeTime;
        public uint? StatusEffects_1_Id;
        public byte[] StatusEffects_1_Unk1;
        public byte[] StatusEffects_1_Entity;
        public uint? StatusEffects_1_Time1;
        public byte? StatusEffects_1_MoreDataFlag;
        public byte? StatusEffects_1_Data1_Count;
        public byte[] StatusEffects_1_Data1_Entity;
        public byte[] StatusEffects_1_UnkData;
        public float? StatusEffects_1_Data_Float1;
        public float? StatusEffects_1_Data_Float2;
        public bool? Clear_StatusEffects_1;

        public ushort? StatusEffects_2_ChangeTime;
        public uint? StatusEffects_2_Id;
        public byte[] StatusEffects_2_Unk1;
        public byte[] StatusEffects_2_Entity;
        public uint? StatusEffects_2_Time1;
        public byte? StatusEffects_2_MoreDataFlag;
        public byte? StatusEffects_2_Data1_Count;
        public byte[] StatusEffects_2_Data1_Entity;
        public byte[] StatusEffects_2_UnkData;
        public float? StatusEffects_2_Data_Float1;
        public float? StatusEffects_2_Data_Float2;
        public bool? Clear_StatusEffects_2;

        public ushort? StatusEffects_3_ChangeTime;
        public uint? StatusEffects_3_Id;
        public byte[] StatusEffects_3_Unk1;
        public byte[] StatusEffects_3_Entity;
        public uint? StatusEffects_3_Time1;
        public byte? StatusEffects_3_MoreDataFlag;
        public byte? StatusEffects_3_Data1_Count;
        public byte[] StatusEffects_3_Data1_Entity;
        public byte[] StatusEffects_3_UnkData;
        public float? StatusEffects_3_Data_Float1;
        public float? StatusEffects_3_Data_Float2;
        public bool? Clear_StatusEffects_3;

        public ushort? StatusEffects_4_ChangeTime;
        public uint? StatusEffects_4_Id;
        public byte[] StatusEffects_4_Unk1;
        public byte[] StatusEffects_4_Entity;
        public uint? StatusEffects_4_Time1;
        public byte? StatusEffects_4_MoreDataFlag;
        public byte? StatusEffects_4_Data1_Count;
        public byte[] StatusEffects_4_Data1_Entity;
        public byte[] StatusEffects_4_UnkData;
        public float? StatusEffects_4_Data_Float1;
        public float? StatusEffects_4_Data_Float2;
        public bool? Clear_StatusEffects_4;

        public ushort? StatusEffects_5_ChangeTime;
        public uint? StatusEffects_5_Id;
        public byte[] StatusEffects_5_Unk1;
        public byte[] StatusEffects_5_Entity;
        public uint? StatusEffects_5_Time1;
        public byte? StatusEffects_5_MoreDataFlag;
        public byte? StatusEffects_5_Data1_Count;
        public byte[] StatusEffects_5_Data1_Entity;
        public byte[] StatusEffects_5_UnkData;
        public float? StatusEffects_5_Data_Float1;
        public float? StatusEffects_5_Data_Float2;
        public bool? Clear_StatusEffects_5;

        public ushort? StatusEffects_6_ChangeTime;
        public uint? StatusEffects_6_Id;
        public byte[] StatusEffects_6_Unk1;
        public byte[] StatusEffects_6_Entity;
        public uint? StatusEffects_6_Time1;
        public byte? StatusEffects_6_MoreDataFlag;
        public byte? StatusEffects_6_Data1_Count;
        public byte[] StatusEffects_6_Data1_Entity;
        public byte[] StatusEffects_6_UnkData;
        public float? StatusEffects_6_Data_Float1;
        public float? StatusEffects_6_Data_Float2;
        public bool? Clear_StatusEffects_6;

        public ushort? StatusEffects_7_ChangeTime;
        public uint? StatusEffects_7_Id;
        public byte[] StatusEffects_7_Unk1;
        public byte[] StatusEffects_7_Entity;
        public uint? StatusEffects_7_Time1;
        public byte? StatusEffects_7_MoreDataFlag;
        public byte? StatusEffects_7_Data1_Count;
        public byte[] StatusEffects_7_Data1_Entity;
        public byte[] StatusEffects_7_UnkData;
        public float? StatusEffects_7_Data_Float1;
        public float? StatusEffects_7_Data_Float2;
        public bool? Clear_StatusEffects_7;

        public ushort? StatusEffects_8_ChangeTime;
        public uint? StatusEffects_8_Id; 
        public byte[] StatusEffects_8_Unk1;
        public byte[] StatusEffects_8_Entity;
        public uint? StatusEffects_8_Time1;
        public byte? StatusEffects_8_MoreDataFlag;
        public byte? StatusEffects_8_Data1_Count;
        public byte[] StatusEffects_8_Data1_Entity;
        public byte[] StatusEffects_8_UnkData;
        public float? StatusEffects_8_Data_Float1;
        public float? StatusEffects_8_Data_Float2;
        public bool? Clear_StatusEffects_8;

        public ushort? StatusEffects_9_ChangeTime;
        public uint? StatusEffects_9_Id;
        public byte[] StatusEffects_9_Unk1;
        public byte[] StatusEffects_9_Entity;
        public uint? StatusEffects_9_Time1;
        public byte? StatusEffects_9_MoreDataFlag;
        public byte? StatusEffects_9_Data1_Count;
        public byte[] StatusEffects_9_Data1_Entity;
        public byte[] StatusEffects_9_UnkData;
        public float? StatusEffects_9_Data_Float1;
        public float? StatusEffects_9_Data_Float2;
        public bool? Clear_StatusEffects_9;

        public ushort? StatusEffects_10_ChangeTime;
        public uint? StatusEffects_10_Id;
        public byte[] StatusEffects_10_Unk1;
        public byte[] StatusEffects_10_Entity;
        public uint? StatusEffects_10_Time1;
        public byte? StatusEffects_10_MoreDataFlag;
        public byte? StatusEffects_10_Data1_Count;
        public byte[] StatusEffects_10_Data1_Entity;
        public byte[] StatusEffects_10_UnkData;
        public float? StatusEffects_10_Data_Float1;
        public float? StatusEffects_10_Data_Float2;
        public bool? Clear_StatusEffects_10;

        public ushort? StatusEffects_11_ChangeTime;
        public uint? StatusEffects_11_Id;
        public byte[] StatusEffects_11_Unk1;
        public byte[] StatusEffects_11_Entity;
        public uint? StatusEffects_11_Time1;
        public byte? StatusEffects_11_MoreDataFlag;
        public byte? StatusEffects_11_Data1_Count;
        public byte[] StatusEffects_11_Data1_Entity;
        public byte[] StatusEffects_11_UnkData;
        public float? StatusEffects_11_Data_Float1;
        public float? StatusEffects_11_Data_Float2;
        public bool? Clear_StatusEffects_11;

        public ushort? StatusEffects_12_ChangeTime;
        public uint? StatusEffects_12_Id;
        public byte[] StatusEffects_12_Unk1;
        public byte[] StatusEffects_12_Entity;
        public uint? StatusEffects_12_Time1;
        public byte? StatusEffects_12_MoreDataFlag;
        public byte? StatusEffects_12_Data1_Count;
        public byte[] StatusEffects_12_Data1_Entity;
        public byte[] StatusEffects_12_UnkData;
        public float? StatusEffects_12_Data_Float1;
        public float? StatusEffects_12_Data_Float2;
        public bool? Clear_StatusEffects_12;

        public ushort? StatusEffects_13_ChangeTime;
        public uint? StatusEffects_13_Id;
        public byte[] StatusEffects_13_Unk1;
        public byte[] StatusEffects_13_Entity;
        public uint? StatusEffects_13_Time1;
        public byte? StatusEffects_13_MoreDataFlag;
        public byte? StatusEffects_13_Data1_Count;
        public byte[] StatusEffects_13_Data1_Entity;
        public byte[] StatusEffects_13_UnkData;
        public float? StatusEffects_13_Data_Float1;
        public float? StatusEffects_13_Data_Float2;
        public bool? Clear_StatusEffects_13;

        public ushort? StatusEffects_14_ChangeTime;
        public uint? StatusEffects_14_Id;
        public byte[] StatusEffects_14_Unk1;
        public byte[] StatusEffects_14_Entity;
        public uint? StatusEffects_14_Time1;
        public byte? StatusEffects_14_MoreDataFlag;
        public byte? StatusEffects_14_Data1_Count;
        public byte[] StatusEffects_14_Data1_Entity;
        public byte[] StatusEffects_14_UnkData;
        public float? StatusEffects_14_Data_Float1;
        public float? StatusEffects_14_Data_Float2;
        public bool? Clear_StatusEffects_14;

        public ushort? StatusEffects_15_ChangeTime;
        public uint? StatusEffects_15_Id;
        public byte[] StatusEffects_15_Unk1;
        public byte[] StatusEffects_15_Entity;
        public uint? StatusEffects_15_Time1;
        public byte? StatusEffects_15_MoreDataFlag;
        public byte? StatusEffects_15_Data1_Count;
        public byte[] StatusEffects_15_Data1_Entity;
        public byte[] StatusEffects_15_UnkData;
        public float? StatusEffects_15_Data_Float1;
        public float? StatusEffects_15_Data_Float2;
        public bool? Clear_StatusEffects_15;

        public ushort? StatusEffects_16_ChangeTime;
        public uint? StatusEffects_16_Id;
        public byte[] StatusEffects_16_Unk1;
        public byte[] StatusEffects_16_Entity;
        public uint? StatusEffects_16_Time1;
        public byte? StatusEffects_16_MoreDataFlag;
        public byte? StatusEffects_16_Data1_Count;
        public byte[] StatusEffects_16_Data1_Entity;
        public byte[] StatusEffects_16_UnkData;
        public float? StatusEffects_16_Data_Float1;
        public float? StatusEffects_16_Data_Float2;
        public bool? Clear_StatusEffects_16;

        public ushort? StatusEffects_17_ChangeTime;
        public uint? StatusEffects_17_Id;
        public byte[] StatusEffects_17_Unk1;
        public byte[] StatusEffects_17_Entity;
        public uint? StatusEffects_17_Time1;
        public byte? StatusEffects_17_MoreDataFlag;
        public byte? StatusEffects_17_Data1_Count;
        public byte[] StatusEffects_17_Data1_Entity;
        public byte[] StatusEffects_17_UnkData;
        public float? StatusEffects_17_Data_Float1;
        public float? StatusEffects_17_Data_Float2;
        public bool? Clear_StatusEffects_17;

        public ushort? StatusEffects_18_ChangeTime;
        public uint? StatusEffects_18_Id;
        public byte[] StatusEffects_18_Unk1;
        public byte[] StatusEffects_18_Entity;
        public uint? StatusEffects_18_Time1;
        public byte? StatusEffects_18_MoreDataFlag;
        public byte? StatusEffects_18_Data1_Count;
        public byte[] StatusEffects_18_Data1_Entity;
        public byte[] StatusEffects_18_UnkData;
        public float? StatusEffects_18_Data_Float1;
        public float? StatusEffects_18_Data_Float2;
        public bool? Clear_StatusEffects_18;

        public ushort? StatusEffects_19_ChangeTime;
        public uint? StatusEffects_19_Id;
        public byte[] StatusEffects_19_Unk1;
        public byte[] StatusEffects_19_Entity;
        public uint? StatusEffects_19_Time1;
        public byte? StatusEffects_19_MoreDataFlag;
        public byte? StatusEffects_19_Data1_Count;
        public byte[] StatusEffects_19_Data1_Entity;
        public byte[] StatusEffects_19_UnkData;
        public float? StatusEffects_19_Data_Float1;
        public float? StatusEffects_19_Data_Float2;
        public bool? Clear_StatusEffects_19;

        public ushort? StatusEffects_20_ChangeTime;
        public uint? StatusEffects_20_Id;
        public byte[] StatusEffects_20_Unk1;
        public byte[] StatusEffects_20_Entity;
        public uint? StatusEffects_20_Time1;
        public byte? StatusEffects_20_MoreDataFlag;
        public byte? StatusEffects_20_Data1_Count;
        public byte[] StatusEffects_20_Data1_Entity;
        public byte[] StatusEffects_20_UnkData;
        public float? StatusEffects_20_Data_Float1;
        public float? StatusEffects_20_Data_Float2;
        public bool? Clear_StatusEffects_20;

        public ushort? StatusEffects_21_ChangeTime;
        public uint? StatusEffects_21_Id;
        public byte[] StatusEffects_21_Unk1;
        public byte[] StatusEffects_21_Entity;
        public uint? StatusEffects_21_Time1;
        public byte? StatusEffects_21_MoreDataFlag;
        public byte? StatusEffects_21_Data1_Count;
        public byte[] StatusEffects_21_Data1_Entity;
        public byte[] StatusEffects_21_UnkData;
        public float? StatusEffects_21_Data_Float1;
        public float? StatusEffects_21_Data_Float2;
        public bool? Clear_StatusEffects_21;

        public ushort? StatusEffects_22_ChangeTime;
        public uint? StatusEffects_22_Id;
        public byte[] StatusEffects_22_Unk1;
        public byte[] StatusEffects_22_Entity;
        public uint? StatusEffects_22_Time1;
        public byte? StatusEffects_22_MoreDataFlag;
        public byte? StatusEffects_22_Data1_Count;
        public byte[] StatusEffects_22_Data1_Entity;
        public byte[] StatusEffects_22_UnkData;
        public float? StatusEffects_22_Data_Float1;
        public float? StatusEffects_22_Data_Float2;
        public bool? Clear_StatusEffects_22;

        public ushort? StatusEffects_23_ChangeTime;
        public uint? StatusEffects_23_Id;
        public byte[] StatusEffects_23_Unk1;
        public byte[] StatusEffects_23_Entity;
        public uint? StatusEffects_23_Time1;
        public byte? StatusEffects_23_MoreDataFlag;
        public byte? StatusEffects_23_Data1_Count;
        public byte[] StatusEffects_23_Data1_Entity;
        public byte[] StatusEffects_23_UnkData;
        public float? StatusEffects_23_Data_Float1;
        public float? StatusEffects_23_Data_Float2;
        public bool? Clear_StatusEffects_23;

        public ushort? StatusEffects_24_ChangeTime;
        public uint? StatusEffects_24_Id; 
        public byte[] StatusEffects_24_Unk1;
        public byte[] StatusEffects_24_Entity;
        public uint? StatusEffects_24_Time1;
        public byte? StatusEffects_24_MoreDataFlag;
        public byte? StatusEffects_24_Data1_Count;
        public byte[] StatusEffects_24_Data1_Entity;
        public byte[] StatusEffects_24_UnkData;
        public float? StatusEffects_24_Data_Float1;
        public float? StatusEffects_24_Data_Float2;
        public bool? Clear_StatusEffects_24;

        public ushort? StatusEffects_25_ChangeTime;
        public uint? StatusEffects_25_Id;
        public byte[] StatusEffects_25_Unk1;
        public byte[] StatusEffects_25_Entity;
        public uint? StatusEffects_25_Time1;
        public byte? StatusEffects_25_MoreDataFlag;
        public byte? StatusEffects_25_Data1_Count;
        public byte[] StatusEffects_25_Data1_Entity;
        public byte[] StatusEffects_25_UnkData;
        public float? StatusEffects_25_Data_Float1;
        public float? StatusEffects_25_Data_Float2;
        public bool? Clear_StatusEffects_25;

        public ushort? StatusEffects_26_ChangeTime;
        public uint? StatusEffects_26_Id;
        public byte[] StatusEffects_26_Unk1;
        public byte[] StatusEffects_26_Entity;
        public uint? StatusEffects_26_Time1;
        public byte? StatusEffects_26_MoreDataFlag;
        public byte? StatusEffects_26_Data1_Count;
        public byte[] StatusEffects_26_Data1_Entity;
        public byte[] StatusEffects_26_UnkData;
        public float? StatusEffects_26_Data_Float1;
        public float? StatusEffects_26_Data_Float2;
        public bool? Clear_StatusEffects_26;

        public ushort? StatusEffects_27_ChangeTime;
        public uint? StatusEffects_27_Id;
        public byte[] StatusEffects_27_Unk1;
        public byte[] StatusEffects_27_Entity;
        public uint? StatusEffects_27_Time1;
        public byte? StatusEffects_27_MoreDataFlag;
        public byte? StatusEffects_27_Data1_Count;
        public byte[] StatusEffects_27_Data1_Entity;
        public byte[] StatusEffects_27_UnkData;
        public float? StatusEffects_27_Data_Float1;
        public float? StatusEffects_27_Data_Float2;
        public bool? Clear_StatusEffects_27;

        public ushort? StatusEffects_28_ChangeTime;
        public uint? StatusEffects_28_Id;
        public byte[] StatusEffects_28_Unk1;
        public byte[] StatusEffects_28_Entity;
        public uint? StatusEffects_28_Time1;
        public byte? StatusEffects_28_MoreDataFlag;
        public byte? StatusEffects_28_Data1_Count;
        public byte[] StatusEffects_28_Data1_Entity;
        public byte[] StatusEffects_28_UnkData;
        public float? StatusEffects_28_Data_Float1;
        public float? StatusEffects_28_Data_Float2;
        public bool? Clear_StatusEffects_28;

        public ushort? StatusEffects_29_ChangeTime;
        public uint? StatusEffects_29_Id;
        public byte[] StatusEffects_29_Unk1;
        public byte[] StatusEffects_29_Entity;
        public uint? StatusEffects_29_Time1;
        public byte? StatusEffects_29_MoreDataFlag;
        public byte? StatusEffects_29_Data1_Count;
        public byte[] StatusEffects_29_Data1_Entity;
        public byte[] StatusEffects_29_UnkData;
        public float? StatusEffects_29_Data_Float1;
        public float? StatusEffects_29_Data_Float2;
        public bool? Clear_StatusEffects_29;

        public ushort? StatusEffects_30_ChangeTime;
        public uint? StatusEffects_30_Id;
        public byte[] StatusEffects_30_Unk1;
        public byte[] StatusEffects_30_Entity;
        public uint? StatusEffects_30_Time1;
        public byte? StatusEffects_30_MoreDataFlag;
        public byte? StatusEffects_30_Data1_Count;
        public byte[] StatusEffects_30_Data1_Entity;
        public byte[] StatusEffects_30_UnkData;
        public float? StatusEffects_30_Data_Float1;
        public float? StatusEffects_30_Data_Float2;
        public bool? Clear_StatusEffects_30;

        public ushort? StatusEffects_31_ChangeTime;
        public uint? StatusEffects_31_Id;
        public byte[] StatusEffects_31_Unk1;
        public byte[] StatusEffects_31_Entity;
        public uint? StatusEffects_31_Time1;
        public byte? StatusEffects_31_MoreDataFlag;
        public byte? StatusEffects_31_Data1_Count;
        public byte[] StatusEffects_31_Data1_Entity;
        public byte[] StatusEffects_31_UnkData;
        public float? StatusEffects_31_Data_Float1;
        public float? StatusEffects_31_Data_Float2;
        public bool? Clear_StatusEffects_31;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;
            
            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.CarryableObjectTypeId:
                        CarryableObjectTypeId = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Name:
                        Name = Stream.Read.StringZ();
                        break;

                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;

                    case ShadowFieldIndex.Orientation:
                        Orientation = Stream.Read.FloatArray(4);
                        break;

                    case ShadowFieldIndex.Hostility:
                        Hostility_Mode = Stream.Read.Byte();
                        if (Hostility_Mode > 0) {
                            Hostility_Id = Stream.Read.Byte();
                        }
                        break;

                    case ShadowFieldIndex.PersonalFactionStance:
                        PersonalFactionStance = Stream.Read.ByteArray(5*4);
                        break;

                    case ShadowFieldIndex.CarryingCharacterId:
                        CarryingCharacterId = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.AllowFriendlyPickup:
                        AllowFriendlyPickup = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.AllowHostilePickup:
                        AllowHostilePickup = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinCardType:
                        SinCardType = Stream.Read.UInt();
                        break;



                    

                    case ShadowFieldIndex.ThrownField:
                        ThrownField_Unk1_Floats = Stream.Read.FloatArray(4);
                        ThrownField_Unk2_Bytes = Stream.Read.ByteArray(1);
                        break;

                    case ShadowFieldIndex.BounceField:
                        BounceField_Position = Stream.Read.FloatArray(3);
                        BounceField_MaybeVelocity = Stream.Read.FloatArray(3);
                        BounceField_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.StatusEffects_0_ChangeTime:
                        StatusEffects_0_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_1_ChangeTime:
                        StatusEffects_1_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_2_ChangeTime:
                        StatusEffects_2_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_3_ChangeTime:
                        StatusEffects_3_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_4_ChangeTime:
                        StatusEffects_4_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_5_ChangeTime:
                        StatusEffects_5_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_6_ChangeTime:
                        StatusEffects_6_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_7_ChangeTime:
                        StatusEffects_7_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_8_ChangeTime:
                        StatusEffects_8_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_9_ChangeTime:
                        StatusEffects_9_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_10_ChangeTime:
                        StatusEffects_10_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_11_ChangeTime:
                        StatusEffects_11_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_12_ChangeTime:
                        StatusEffects_12_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_13_ChangeTime:
                        StatusEffects_13_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_14_ChangeTime:
                        StatusEffects_14_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_15_ChangeTime:
                        StatusEffects_15_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_16_ChangeTime:
                        StatusEffects_16_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_17_ChangeTime:
                        StatusEffects_17_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_18_ChangeTime:
                        StatusEffects_18_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_19_ChangeTime:
                        StatusEffects_19_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_20_ChangeTime:
                        StatusEffects_20_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_21_ChangeTime:
                        StatusEffects_21_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_22_ChangeTime:
                        StatusEffects_22_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_23_ChangeTime:
                        StatusEffects_23_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_24_ChangeTime:
                        StatusEffects_24_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_25_ChangeTime:
                        StatusEffects_25_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_26_ChangeTime:
                        StatusEffects_26_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_27_ChangeTime:
                        StatusEffects_27_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_28_ChangeTime:
                        StatusEffects_28_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_29_ChangeTime:
                        StatusEffects_29_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_30_ChangeTime:
                        StatusEffects_30_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_31_ChangeTime:
                        StatusEffects_31_ChangeTime = Stream.Read.UShort();
                        break;


                    case ShadowFieldIndex.StatusEffects_0_Data:
                        StatusEffects_0_Id     = Stream.Read.UInt();
                        StatusEffects_0_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_0_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_0_Time1  = Stream.Read.UInt();
                        StatusEffects_0_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_0_MoreDataFlag == 0x01)
                        {
                            StatusEffects_0_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_0_Data1_Count > 0) {
                                StatusEffects_0_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_0_Data1_Count);
                            }
                            StatusEffects_0_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_0_Data_Float1 = Stream.Read.Float();
                            StatusEffects_0_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_1_Data:
                        StatusEffects_1_Id     = Stream.Read.UInt();
                        StatusEffects_1_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_1_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_1_Time1  = Stream.Read.UInt();
                        StatusEffects_1_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_1_MoreDataFlag == 0x01)
                        {
                            StatusEffects_1_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_1_Data1_Count > 0) {
                                StatusEffects_1_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_1_Data1_Count);
                            }
                            StatusEffects_1_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_1_Data_Float1 = Stream.Read.Float();
                            StatusEffects_1_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_2_Data:
                        StatusEffects_2_Id     = Stream.Read.UInt();
                        StatusEffects_2_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_2_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_2_Time1  = Stream.Read.UInt();
                        StatusEffects_2_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_2_MoreDataFlag == 0x01)
                        {
                            StatusEffects_2_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_2_Data1_Count > 0) {
                                StatusEffects_2_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_2_Data1_Count);
                            }
                            StatusEffects_2_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_2_Data_Float1 = Stream.Read.Float();
                            StatusEffects_2_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_3_Data:
                        StatusEffects_3_Id     = Stream.Read.UInt();
                        StatusEffects_3_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_3_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_3_Time1  = Stream.Read.UInt();
                        StatusEffects_3_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_3_MoreDataFlag == 0x01)
                        {
                            StatusEffects_3_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_3_Data1_Count > 0) {
                                StatusEffects_3_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_3_Data1_Count);
                            }
                            StatusEffects_3_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_3_Data_Float1 = Stream.Read.Float();
                            StatusEffects_3_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_4_Data:
                        StatusEffects_4_Id     = Stream.Read.UInt();
                        StatusEffects_4_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_4_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_4_Time1  = Stream.Read.UInt();
                        StatusEffects_4_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_4_MoreDataFlag == 0x01)
                        {
                            StatusEffects_4_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_4_Data1_Count > 0) {
                                StatusEffects_4_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_4_Data1_Count);
                            }
                            StatusEffects_4_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_4_Data_Float1 = Stream.Read.Float();
                            StatusEffects_4_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_5_Data:
                        StatusEffects_5_Id     = Stream.Read.UInt();
                        StatusEffects_5_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_5_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_5_Time1  = Stream.Read.UInt();
                        StatusEffects_5_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_5_MoreDataFlag == 0x01)
                        {
                            StatusEffects_5_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_5_Data1_Count > 0) {
                                StatusEffects_5_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_5_Data1_Count);
                            }
                            StatusEffects_5_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_5_Data_Float1 = Stream.Read.Float();
                            StatusEffects_5_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_6_Data:
                        StatusEffects_6_Id     = Stream.Read.UInt();
                        StatusEffects_6_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_6_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_6_Time1  = Stream.Read.UInt();
                        StatusEffects_6_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_6_MoreDataFlag == 0x01)
                        {
                            StatusEffects_6_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_6_Data1_Count > 0) {
                                StatusEffects_6_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_6_Data1_Count);
                            }
                            StatusEffects_6_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_6_Data_Float1 = Stream.Read.Float();
                            StatusEffects_6_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_7_Data:
                        StatusEffects_7_Id     = Stream.Read.UInt();
                        StatusEffects_7_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_7_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_7_Time1  = Stream.Read.UInt();
                        StatusEffects_7_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_7_MoreDataFlag == 0x01)
                        {
                            StatusEffects_7_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_7_Data1_Count > 0) {
                                StatusEffects_7_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_7_Data1_Count);
                            }
                            StatusEffects_7_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_7_Data_Float1 = Stream.Read.Float();
                            StatusEffects_7_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_8_Data:
                        StatusEffects_8_Id     = Stream.Read.UInt();
                        StatusEffects_8_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_8_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_8_Time1  = Stream.Read.UInt();
                        StatusEffects_8_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_8_MoreDataFlag == 0x01)
                        {
                            StatusEffects_8_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_8_Data1_Count > 0) {
                                StatusEffects_8_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_8_Data1_Count);
                            }
                            StatusEffects_8_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_8_Data_Float1 = Stream.Read.Float();
                            StatusEffects_8_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_9_Data:
                        StatusEffects_9_Id     = Stream.Read.UInt();
                        StatusEffects_9_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_9_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_9_Time1  = Stream.Read.UInt();
                        StatusEffects_9_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_9_MoreDataFlag == 0x01)
                        {
                            StatusEffects_9_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_9_Data1_Count > 0) {
                                StatusEffects_9_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_9_Data1_Count);
                            }
                            StatusEffects_9_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_9_Data_Float1 = Stream.Read.Float();
                            StatusEffects_9_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_10_Data:
                        StatusEffects_10_Id     = Stream.Read.UInt();
                        StatusEffects_10_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_10_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_10_Time1  = Stream.Read.UInt();
                        StatusEffects_10_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_10_MoreDataFlag == 0x01)
                        {
                            StatusEffects_10_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_10_Data1_Count > 0) {
                                StatusEffects_10_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_10_Data1_Count);
                            }
                            StatusEffects_10_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_10_Data_Float1 = Stream.Read.Float();
                            StatusEffects_10_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_11_Data:
                        StatusEffects_11_Id     = Stream.Read.UInt();
                        StatusEffects_11_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_11_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_11_Time1  = Stream.Read.UInt();
                        StatusEffects_11_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_11_MoreDataFlag == 0x01)
                        {
                            StatusEffects_11_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_11_Data1_Count > 0) {
                                StatusEffects_11_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_11_Data1_Count);
                            }
                            StatusEffects_11_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_11_Data_Float1 = Stream.Read.Float();
                            StatusEffects_11_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_12_Data:
                        StatusEffects_12_Id     = Stream.Read.UInt();
                        StatusEffects_12_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_12_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_12_Time1  = Stream.Read.UInt();
                        StatusEffects_12_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_12_MoreDataFlag == 0x01)
                        {
                            StatusEffects_12_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_12_Data1_Count > 0) {
                                StatusEffects_12_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_12_Data1_Count);
                            }
                            StatusEffects_12_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_12_Data_Float1 = Stream.Read.Float();
                            StatusEffects_12_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_13_Data:
                        StatusEffects_13_Id     = Stream.Read.UInt();
                        StatusEffects_13_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_13_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_13_Time1  = Stream.Read.UInt();
                        StatusEffects_13_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_13_MoreDataFlag == 0x01)
                        {
                            StatusEffects_13_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_13_Data1_Count > 0) {
                                StatusEffects_13_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_13_Data1_Count);
                            }
                            StatusEffects_13_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_13_Data_Float1 = Stream.Read.Float();
                            StatusEffects_13_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_14_Data:
                        StatusEffects_14_Id     = Stream.Read.UInt();
                        StatusEffects_14_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_14_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_14_Time1  = Stream.Read.UInt();
                        StatusEffects_14_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_14_MoreDataFlag == 0x01)
                        {
                            StatusEffects_14_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_14_Data1_Count > 0) {
                                StatusEffects_14_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_14_Data1_Count);
                            }
                            StatusEffects_14_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_14_Data_Float1 = Stream.Read.Float();
                            StatusEffects_14_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_15_Data:
                        StatusEffects_15_Id     = Stream.Read.UInt();
                        StatusEffects_15_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_15_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_15_Time1  = Stream.Read.UInt();
                        StatusEffects_15_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_15_MoreDataFlag == 0x01)
                        {
                            StatusEffects_15_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_15_Data1_Count > 0) {
                                StatusEffects_15_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_15_Data1_Count);
                            }
                            StatusEffects_15_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_15_Data_Float1 = Stream.Read.Float();
                            StatusEffects_15_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_16_Data:
                        StatusEffects_16_Id     = Stream.Read.UInt();
                        StatusEffects_16_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_16_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_16_Time1  = Stream.Read.UInt();
                        StatusEffects_16_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_16_MoreDataFlag == 0x01)
                        {
                            StatusEffects_16_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_16_Data1_Count > 0) {
                                StatusEffects_16_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_16_Data1_Count);
                            }
                            StatusEffects_16_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_16_Data_Float1 = Stream.Read.Float();
                            StatusEffects_16_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_17_Data:
                        StatusEffects_17_Id     = Stream.Read.UInt();
                        StatusEffects_17_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_17_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_17_Time1  = Stream.Read.UInt();
                        StatusEffects_17_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_17_MoreDataFlag == 0x01)
                        {
                            StatusEffects_17_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_17_Data1_Count > 0) {
                                StatusEffects_17_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_17_Data1_Count);
                            }
                            StatusEffects_17_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_17_Data_Float1 = Stream.Read.Float();
                            StatusEffects_17_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_18_Data:
                        StatusEffects_18_Id     = Stream.Read.UInt();
                        StatusEffects_18_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_18_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_18_Time1  = Stream.Read.UInt();
                        StatusEffects_18_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_18_MoreDataFlag == 0x01)
                        {
                            StatusEffects_18_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_18_Data1_Count > 0) {
                                StatusEffects_18_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_18_Data1_Count);
                            }
                            StatusEffects_18_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_18_Data_Float1 = Stream.Read.Float();
                            StatusEffects_18_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_19_Data:
                        StatusEffects_19_Id     = Stream.Read.UInt();
                        StatusEffects_19_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_19_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_19_Time1  = Stream.Read.UInt();
                        StatusEffects_19_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_19_MoreDataFlag == 0x01)
                        {
                            StatusEffects_19_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_19_Data1_Count > 0) {
                                StatusEffects_19_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_19_Data1_Count);
                            }
                            StatusEffects_19_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_19_Data_Float1 = Stream.Read.Float();
                            StatusEffects_19_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_20_Data:
                        StatusEffects_20_Id     = Stream.Read.UInt();
                        StatusEffects_20_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_20_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_20_Time1  = Stream.Read.UInt();
                        StatusEffects_20_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_20_MoreDataFlag == 0x01)
                        {
                            StatusEffects_20_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_20_Data1_Count > 0) {
                                StatusEffects_20_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_20_Data1_Count);
                            }
                            StatusEffects_20_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_20_Data_Float1 = Stream.Read.Float();
                            StatusEffects_20_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_21_Data:
                        StatusEffects_21_Id     = Stream.Read.UInt();
                        StatusEffects_21_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_21_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_21_Time1  = Stream.Read.UInt();
                        StatusEffects_21_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_21_MoreDataFlag == 0x01)
                        {
                            StatusEffects_21_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_21_Data1_Count > 0) {
                                StatusEffects_21_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_21_Data1_Count);
                            }
                            StatusEffects_21_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_21_Data_Float1 = Stream.Read.Float();
                            StatusEffects_21_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_22_Data:
                        StatusEffects_22_Id     = Stream.Read.UInt();
                        StatusEffects_22_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_22_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_22_Time1  = Stream.Read.UInt();
                        StatusEffects_22_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_22_MoreDataFlag == 0x01)
                        {
                            StatusEffects_22_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_22_Data1_Count > 0) {
                                StatusEffects_22_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_22_Data1_Count);
                            }
                            StatusEffects_22_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_22_Data_Float1 = Stream.Read.Float();
                            StatusEffects_22_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_23_Data:
                        StatusEffects_23_Id     = Stream.Read.UInt();
                        StatusEffects_23_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_23_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_23_Time1  = Stream.Read.UInt();
                        StatusEffects_23_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_23_MoreDataFlag == 0x01)
                        {
                            StatusEffects_23_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_23_Data1_Count > 0) {
                                StatusEffects_23_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_23_Data1_Count);
                            }
                            StatusEffects_23_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_23_Data_Float1 = Stream.Read.Float();
                            StatusEffects_23_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_24_Data:
                        StatusEffects_24_Id     = Stream.Read.UInt();
                        StatusEffects_24_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_24_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_24_Time1  = Stream.Read.UInt();
                        StatusEffects_24_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_24_MoreDataFlag == 0x01)
                        {
                            StatusEffects_24_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_24_Data1_Count > 0) {
                                StatusEffects_24_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_24_Data1_Count);
                            }
                            StatusEffects_24_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_24_Data_Float1 = Stream.Read.Float();
                            StatusEffects_24_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_25_Data:
                        StatusEffects_25_Id     = Stream.Read.UInt();
                        StatusEffects_25_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_25_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_25_Time1  = Stream.Read.UInt();
                        StatusEffects_25_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_25_MoreDataFlag == 0x01)
                        {
                            StatusEffects_25_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_25_Data1_Count > 0) {
                                StatusEffects_25_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_25_Data1_Count);
                            }
                            StatusEffects_25_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_25_Data_Float1 = Stream.Read.Float();
                            StatusEffects_25_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_26_Data:
                        StatusEffects_26_Id     = Stream.Read.UInt();
                        StatusEffects_26_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_26_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_26_Time1  = Stream.Read.UInt();
                        StatusEffects_26_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_26_MoreDataFlag == 0x01)
                        {
                            StatusEffects_26_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_26_Data1_Count > 0) {
                                StatusEffects_26_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_26_Data1_Count);
                            }
                            StatusEffects_26_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_26_Data_Float1 = Stream.Read.Float();
                            StatusEffects_26_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_27_Data:
                        StatusEffects_27_Id     = Stream.Read.UInt();
                        StatusEffects_27_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_27_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_27_Time1  = Stream.Read.UInt();
                        StatusEffects_27_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_27_MoreDataFlag == 0x01)
                        {
                            StatusEffects_27_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_27_Data1_Count > 0) {
                                StatusEffects_27_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_27_Data1_Count);
                            }
                            StatusEffects_27_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_27_Data_Float1 = Stream.Read.Float();
                            StatusEffects_27_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_28_Data:
                        StatusEffects_28_Id     = Stream.Read.UInt();
                        StatusEffects_28_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_28_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_28_Time1  = Stream.Read.UInt();
                        StatusEffects_28_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_28_MoreDataFlag == 0x01)
                        {
                            StatusEffects_28_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_28_Data1_Count > 0) {
                                StatusEffects_28_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_28_Data1_Count);
                            }
                            StatusEffects_28_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_28_Data_Float1 = Stream.Read.Float();
                            StatusEffects_28_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_29_Data:
                        StatusEffects_29_Id     = Stream.Read.UInt();
                        StatusEffects_29_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_29_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_29_Time1  = Stream.Read.UInt();
                        StatusEffects_29_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_29_MoreDataFlag == 0x01)
                        {
                            StatusEffects_29_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_29_Data1_Count > 0) {
                                StatusEffects_29_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_29_Data1_Count);
                            }
                            StatusEffects_29_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_29_Data_Float1 = Stream.Read.Float();
                            StatusEffects_29_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_30_Data:
                        StatusEffects_30_Id     = Stream.Read.UInt();
                        StatusEffects_30_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_30_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_30_Time1  = Stream.Read.UInt();
                        StatusEffects_30_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_30_MoreDataFlag == 0x01)
                        {
                            StatusEffects_30_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_30_Data1_Count > 0) {
                                StatusEffects_30_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_30_Data1_Count);
                            }
                            StatusEffects_30_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_30_Data_Float1 = Stream.Read.Float();
                            StatusEffects_30_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_31_Data:
                        StatusEffects_31_Id     = Stream.Read.UInt();
                        StatusEffects_31_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_31_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_31_Time1  = Stream.Read.UInt();
                        StatusEffects_31_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_31_MoreDataFlag == 0x01)
                        {
                            StatusEffects_31_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_31_Data1_Count > 0) {
                                StatusEffects_31_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_31_Data1_Count);
                            }
                            StatusEffects_31_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_31_Data_Float1 = Stream.Read.Float();
                            StatusEffects_31_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    // These keys do not come with any data
                    case ShadowFieldIndex.Clear_StatusEffects_0:
                        Clear_StatusEffects_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_1:
                        Clear_StatusEffects_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_2:
                        Clear_StatusEffects_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_3:
                        Clear_StatusEffects_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_4:
                        Clear_StatusEffects_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_5:
                        Clear_StatusEffects_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_6:
                        Clear_StatusEffects_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_7:
                        Clear_StatusEffects_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_8:
                        Clear_StatusEffects_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_9:
                        Clear_StatusEffects_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_10:
                        Clear_StatusEffects_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_11:
                        Clear_StatusEffects_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_12:
                        Clear_StatusEffects_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_13:
                        Clear_StatusEffects_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_14:
                        Clear_StatusEffects_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_15:
                        Clear_StatusEffects_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_16:
                        Clear_StatusEffects_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_17:
                        Clear_StatusEffects_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_18:
                        Clear_StatusEffects_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_19:
                        Clear_StatusEffects_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_20:
                        Clear_StatusEffects_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_21:
                        Clear_StatusEffects_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_22:
                        Clear_StatusEffects_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_23:
                        Clear_StatusEffects_23 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_24:
                        Clear_StatusEffects_24 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_25:
                        Clear_StatusEffects_25 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_26:
                        Clear_StatusEffects_26 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_27:
                        Clear_StatusEffects_27 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_28:
                        Clear_StatusEffects_28 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_29:
                        Clear_StatusEffects_29 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_30:
                        Clear_StatusEffects_30 = true;
                        break;
                    case ShadowFieldIndex.Clear_StatusEffects_31:
                        Clear_StatusEffects_31 = true;
                        break;


                    case ShadowFieldIndex.Clear_PersonalFactionStance:
                        Clear_PersonalFactionStance = true;
                        break;
                    case ShadowFieldIndex.Clear_CarryingCharacterId:
                        Clear_CarryingCharacterId = true;
                        break;
                    case ShadowFieldIndex.Clear_ForcedMovement:
                        Clear_ForcedMovement = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_0:
                        Clear_SinCardFields_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_1:
                        Clear_SinCardFields_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_2:
                        Clear_SinCardFields_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_3:
                        Clear_SinCardFields_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_4:
                        Clear_SinCardFields_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_5:
                        Clear_SinCardFields_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_6:
                        Clear_SinCardFields_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_7:
                        Clear_SinCardFields_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_8:
                        Clear_SinCardFields_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_9:
                        Clear_SinCardFields_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_10:
                        Clear_SinCardFields_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_11:
                        Clear_SinCardFields_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_12:
                        Clear_SinCardFields_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_13:
                        Clear_SinCardFields_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_14:
                        Clear_SinCardFields_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_15:
                        Clear_SinCardFields_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_16:
                        Clear_SinCardFields_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_17:
                        Clear_SinCardFields_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_18:
                        Clear_SinCardFields_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_19:
                        Clear_SinCardFields_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_20:
                        Clear_SinCardFields_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_21:
                        Clear_SinCardFields_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_22:
                        Clear_SinCardFields_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_ThrownField:
                        Clear_ThrownField = true;
                        break;
                    case ShadowFieldIndex.Clear_SeekField:
                        Clear_SeekField = true;
                        break;
                    case ShadowFieldIndex.Clear_BounceField:
                        Clear_BounceField = true;
                        break;


                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
        
        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }
    }
}