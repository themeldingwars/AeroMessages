using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 3, true)]
    public class CarryableObjectObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            PersonalFactionStance, // assumption
            CarryingCharacterId, // guess
            ForcedMovement, // guess,

            StatusEffect_00,
            StatusEffect_01,
            StatusEffect_02,
            StatusEffect_03,
            StatusEffect_04,
            StatusEffect_05,
            StatusEffect_06,
            StatusEffect_07,
            StatusEffect_08,
            StatusEffect_09,
            StatusEffect_0a,
            StatusEffect_0b,
            StatusEffect_0c,
            StatusEffect_0d,
            StatusEffect_0e,
            StatusEffect_0f,
            StatusEffect_10,
            StatusEffect_11,
            StatusEffect_12,
            StatusEffect_13,
            StatusEffect_14,
            StatusEffect_15,
            StatusEffect_16,
            StatusEffect_17,
            StatusEffect_18,
            StatusEffect_19,
            StatusEffect_1a,
            StatusEffect_1b,
            StatusEffect_1c,
            StatusEffect_1d,
            StatusEffect_1e,
            StatusEffect_1f,

            SinCardFields_0,
            SinCardFields_1,
            SinCardFields_2,
            SinCardFields_3,
            SinCardFields_4,
            SinCardFields_5,
            SinCardFields_6,
            SinCardFields_7,
            SinCardFields_8,
            SinCardFields_9,
            SinCardFields_10,
            SinCardFields_11,
            SinCardFields_12,
            SinCardFields_13,
            SinCardFields_14,
            SinCardFields_15,
            SinCardFields_16,
            SinCardFields_17,
            SinCardFields_18,
            SinCardFields_19,
            SinCardFields_20,
            SinCardFields_21,
            SinCardFields_22,

            ThrownField, // guess
            SeekField, // guess
            BounceField, // guess

            // 3 last bits are 0 by default, probably unused
        }


        public string Warning;

        public byte[] Bitfield;
        public uint CarryableObjectTypeId; // Sdb table 480, id column.
        public string Name;
        public float[] Position;
        public float[] Orientation;
        public byte Hostility_Mode;
        public byte? Hostility_Id;

        public byte[] PersonalFactionStance;
        public byte[] CarryingCharacterId;
        public byte[] ForcedMovement; // Needs indepth parsing, first byte is type/flags.

        public byte AllowFriendlyPickup; // guess
        public byte AllowHostilePickup; // guess
        public uint SinCardType;

        public byte[] SinCardFields_0;
        public byte[] SinCardFields_1;
        public byte[] SinCardFields_2;
        public byte[] SinCardFields_3;
        public byte[] SinCardFields_4;
        public byte[] SinCardFields_5;
        public byte[] SinCardFields_6;
        public byte[] SinCardFields_7;
        public byte[] SinCardFields_8;
        public byte[] SinCardFields_9;
        public byte[] SinCardFields_10;
        public byte[] SinCardFields_11;
        public byte[] SinCardFields_12;
        public byte[] SinCardFields_13;
        public byte[] SinCardFields_14;
        public byte[] SinCardFields_15;
        public byte[] SinCardFields_16;
        public byte[] SinCardFields_17;
        public byte[] SinCardFields_18;
        public byte[] SinCardFields_19;
        public byte[] SinCardFields_20;
        public byte[] SinCardFields_21;
        public byte[] SinCardFields_22;

        public byte VisualInfoGroupIndex;

        public float[] ThrownField_Unk1_Floats;
        public byte[] ThrownField_Unk2_Bytes;
        
        public float[] BounceField_Position;
        public float[] BounceField_MaybeVelocity;
        public uint? BounceField_Time;


        public byte[] ScopeBubbleInfo;
        


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



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield = Stream.Read.BitArray(64);
                CarryableObjectTypeId = Stream.Read.UInt();
                Name = Stream.Read.StringZ(Stream);
                Position = Stream.Read.FloatArray(3);
                Orientation = Stream.Read.FloatArray(4);
                Hostility_Mode = Stream.Read.Byte();
                if (Hostility_Mode > 0) {
                    Hostility_Id = Stream.Read.Byte();
                }

                if (Bitfield[(int)BitfieldIndex.PersonalFactionStance] == 0)
                {
                    PersonalFactionStance = Stream.Read.ByteArray(5*4);
                }

                if (Bitfield[(int)BitfieldIndex.CarryingCharacterId] == 0)
                {
                    CarryingCharacterId = Stream.Read.ByteArray(8);
                }

                if (Bitfield[(int)BitfieldIndex.ForcedMovement] == 0)
                {
                    Warning += "ForcedMovement;";
                    // Needs indepth parsing, first byte is type/flags.
                    ForcedMovement = Stream.Read.ByteArray(30);
                }

                StatusEffect_00_ChangeTime = Stream.Read.UShort();
                StatusEffect_01_ChangeTime = Stream.Read.UShort();
                StatusEffect_02_ChangeTime = Stream.Read.UShort();
                StatusEffect_03_ChangeTime = Stream.Read.UShort();
                StatusEffect_04_ChangeTime = Stream.Read.UShort();
                StatusEffect_05_ChangeTime = Stream.Read.UShort();
                StatusEffect_06_ChangeTime = Stream.Read.UShort();
                StatusEffect_07_ChangeTime = Stream.Read.UShort();
                StatusEffect_08_ChangeTime = Stream.Read.UShort();
                StatusEffect_09_ChangeTime = Stream.Read.UShort();
                StatusEffect_0a_ChangeTime = Stream.Read.UShort();
                StatusEffect_0b_ChangeTime = Stream.Read.UShort();
                StatusEffect_0c_ChangeTime = Stream.Read.UShort();
                StatusEffect_0d_ChangeTime = Stream.Read.UShort();
                StatusEffect_0e_ChangeTime = Stream.Read.UShort();
                StatusEffect_0f_ChangeTime = Stream.Read.UShort();
                StatusEffect_10_ChangeTime = Stream.Read.UShort();
                StatusEffect_11_ChangeTime = Stream.Read.UShort();
                StatusEffect_12_ChangeTime = Stream.Read.UShort();
                StatusEffect_13_ChangeTime = Stream.Read.UShort();
                StatusEffect_14_ChangeTime = Stream.Read.UShort();
                StatusEffect_15_ChangeTime = Stream.Read.UShort();
                StatusEffect_16_ChangeTime = Stream.Read.UShort();
                StatusEffect_17_ChangeTime = Stream.Read.UShort();
                StatusEffect_18_ChangeTime = Stream.Read.UShort();
                StatusEffect_19_ChangeTime = Stream.Read.UShort();
                StatusEffect_1a_ChangeTime = Stream.Read.UShort();
                StatusEffect_1b_ChangeTime = Stream.Read.UShort();
                StatusEffect_1c_ChangeTime = Stream.Read.UShort();
                StatusEffect_1d_ChangeTime = Stream.Read.UShort();
                StatusEffect_1e_ChangeTime = Stream.Read.UShort();
                StatusEffect_1f_ChangeTime = Stream.Read.UShort();

                // Status Effect Data
                if (Bitfield[(int)BitfieldIndex.StatusEffect_00] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_01] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_02] == 0)
                {
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffect_03] == 0)
                {  
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_04] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_05] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_06] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_07] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_08] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_09] == 0)
                { 
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffect_0a] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_0b] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_0c] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_0d] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_0e] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_0f] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_10] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_11] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_12] == 0)
                {
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffect_13] == 0)
                {  
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_14] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_15] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_16] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_17] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_18] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_19] == 0)
                { 
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffect_1a] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_1b] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_1c] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_1d] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_1e] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffect_1f] == 0)
                { 
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
                }

                AllowFriendlyPickup = Stream.Read.Byte(); // guess
                AllowHostilePickup = Stream.Read.Byte(); // guess
                SinCardType = Stream.Read.UInt();

                if (Bitfield[(int)BitfieldIndex.SinCardFields_0] == 0)
                {
                    Warning += "SinCardFields_0;";
                    SinCardFields_0 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_1] == 0)
                {
                    Warning += "SinCardFields_1;";
                    SinCardFields_1 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_2] == 0)
                {
                    Warning += "SinCardFields_2;";
                    SinCardFields_2 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_3] == 0)
                {
                    Warning += "SinCardFields_3;";
                    SinCardFields_3 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_4] == 0)
                {
                    Warning += "SinCardFields_4;";
                    SinCardFields_4 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_5] == 0)
                {
                    Warning += "SinCardFields_5;";
                    SinCardFields_5 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_6] == 0)
                {
                    Warning += "SinCardFields_6;";
                    SinCardFields_6 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_7] == 0)
                {
                    Warning += "SinCardFields_7;";
                    SinCardFields_7 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_8] == 0)
                {
                    Warning += "SinCardFields_8;";
                    SinCardFields_8 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_9] == 0)
                {
                    Warning += "SinCardFields_9;";
                    SinCardFields_9 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_10] == 0)
                {
                    Warning += "SinCardFields_10;";
                    SinCardFields_10 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_11] == 0)
                {
                    Warning += "SinCardFields_11;";
                    SinCardFields_11 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_12] == 0)
                {
                    Warning += "SinCardFields_12;";
                    SinCardFields_12 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_13] == 0)
                {
                    Warning += "SinCardFields_13;";
                    SinCardFields_13 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_14] == 0)
                {
                    Warning += "SinCardFields_14;";
                    SinCardFields_14 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_15] == 0)
                {
                    Warning += "SinCardFields_15;";
                    SinCardFields_15 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_16] == 0)
                {
                    Warning += "SinCardFields_16;";
                    SinCardFields_16 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_17] == 0)
                {
                    Warning += "SinCardFields_17;";
                    SinCardFields_17 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_18] == 0)
                {
                    Warning += "SinCardFields_18;";
                    SinCardFields_18 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_19] == 0)
                {
                    Warning += "SinCardFields_19;";
                    SinCardFields_19 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_20] == 0)
                {
                    Warning += "SinCardFields_20;";
                    SinCardFields_20 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_21] == 0)
                {
                    Warning += "SinCardFields_21;";
                    SinCardFields_21 = Stream.Read.ByteArray(5);
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_22] == 0)
                {
                    Warning += "SinCardFields_22;";
                    SinCardFields_22 = Stream.Read.ByteArray(5);
                }

                VisualInfoGroupIndex = Stream.Read.Byte();

                if (Bitfield[(int)BitfieldIndex.ThrownField] == 0)
                {
                    ThrownField_Unk1_Floats = Stream.Read.FloatArray(4);
                    ThrownField_Unk2_Bytes = Stream.Read.ByteArray(1);
                }
                if (Bitfield[(int)BitfieldIndex.SeekField] == 0)
                {
                    Warning += "SeekField;";
                }
                if (Bitfield[(int)BitfieldIndex.BounceField] == 0)
                {
                    BounceField_Position = Stream.Read.FloatArray(3);
                    BounceField_MaybeVelocity = Stream.Read.FloatArray(3);
                    BounceField_Time = Stream.Read.UInt();
                }

                ScopeBubbleInfo = Stream.Read.ByteArray(8);

            }
            
        }
    }

    public static class MyExtensions
    {
        public static string StringZ(this Bitter.BinaryReader rdr, Bitter.BinaryStream stream) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (stream.baseStream.ByteOffset < stream.baseStream.Length);
            return ret;
        }
    }
}