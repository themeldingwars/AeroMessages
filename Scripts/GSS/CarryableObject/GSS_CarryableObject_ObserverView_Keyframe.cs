using Bitter;
using System;
using System.Collections.Generic;
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

            StatusEffects_0,
            StatusEffects_1,
            StatusEffects_2,
            StatusEffects_3,
            StatusEffects_4,
            StatusEffects_5,
            StatusEffects_6,
            StatusEffects_7,
            StatusEffects_8,
            StatusEffects_9,
            StatusEffects_10,
            StatusEffects_11,
            StatusEffects_12,
            StatusEffects_13,
            StatusEffects_14,
            StatusEffects_15,
            StatusEffects_16,
            StatusEffects_17,
            StatusEffects_18,
            StatusEffects_19,
            StatusEffects_20,
            StatusEffects_21,
            StatusEffects_22,
            StatusEffects_23,
            StatusEffects_24,
            StatusEffects_25,
            StatusEffects_26,
            StatusEffects_27,
            StatusEffects_28,
            StatusEffects_29,
            StatusEffects_30,
            StatusEffects_31,

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

        public string PeepWarning;

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

        public SinCardField SinCardFields_0;
        public SinCardField SinCardFields_1;
        public SinCardField SinCardFields_2;
        public SinCardField SinCardFields_3;
        public SinCardField SinCardFields_4;
        public SinCardField SinCardFields_5;
        public SinCardField SinCardFields_6;
        public SinCardField SinCardFields_7;
        public SinCardField SinCardFields_8;
        public SinCardField SinCardFields_9;
        public SinCardField SinCardFields_10;
        public SinCardField SinCardFields_11;
        public SinCardField SinCardFields_12;
        public SinCardField SinCardFields_13;
        public SinCardField SinCardFields_14;
        public SinCardField SinCardFields_15;
        public SinCardField SinCardFields_16;
        public SinCardField SinCardFields_17;
        public SinCardField SinCardFields_18;
        public SinCardField SinCardFields_19;
        public SinCardField SinCardFields_20;
        public SinCardField SinCardFields_21;
        public SinCardField SinCardFields_22;

        public byte VisualInfoGroupIndex;

        public float[] ThrownField_Unk1_Floats;
        public byte[] ThrownField_Unk2_Bytes;
        
        public float[] BounceField_Position;
        public float[] BounceField_MaybeVelocity;
        public uint? BounceField_Time;


        public byte[] ScopeBubbleInfo;
        


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



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield = Stream.Read.BitArray(64);
                CarryableObjectTypeId = Stream.Read.UInt();
                Name = Stream.Read.StringZ();
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
                    PeepWarning += "ForcedMovement;";
                    // Needs indepth parsing, first byte is type/flags.
                    ForcedMovement = Stream.Read.ByteArray(30);
                }

                StatusEffects_0_ChangeTime = Stream.Read.UShort();
                StatusEffects_1_ChangeTime = Stream.Read.UShort();
                StatusEffects_2_ChangeTime = Stream.Read.UShort();
                StatusEffects_3_ChangeTime = Stream.Read.UShort();
                StatusEffects_4_ChangeTime = Stream.Read.UShort();
                StatusEffects_5_ChangeTime = Stream.Read.UShort();
                StatusEffects_6_ChangeTime = Stream.Read.UShort();
                StatusEffects_7_ChangeTime = Stream.Read.UShort();
                StatusEffects_8_ChangeTime = Stream.Read.UShort();
                StatusEffects_9_ChangeTime = Stream.Read.UShort();
                StatusEffects_10_ChangeTime = Stream.Read.UShort();
                StatusEffects_11_ChangeTime = Stream.Read.UShort();
                StatusEffects_12_ChangeTime = Stream.Read.UShort();
                StatusEffects_13_ChangeTime = Stream.Read.UShort();
                StatusEffects_14_ChangeTime = Stream.Read.UShort();
                StatusEffects_15_ChangeTime = Stream.Read.UShort();
                StatusEffects_16_ChangeTime = Stream.Read.UShort();
                StatusEffects_17_ChangeTime = Stream.Read.UShort();
                StatusEffects_18_ChangeTime = Stream.Read.UShort();
                StatusEffects_19_ChangeTime = Stream.Read.UShort();
                StatusEffects_20_ChangeTime = Stream.Read.UShort();
                StatusEffects_21_ChangeTime = Stream.Read.UShort();
                StatusEffects_22_ChangeTime = Stream.Read.UShort();
                StatusEffects_23_ChangeTime = Stream.Read.UShort();
                StatusEffects_24_ChangeTime = Stream.Read.UShort();
                StatusEffects_25_ChangeTime = Stream.Read.UShort();
                StatusEffects_26_ChangeTime = Stream.Read.UShort();
                StatusEffects_27_ChangeTime = Stream.Read.UShort();
                StatusEffects_28_ChangeTime = Stream.Read.UShort();
                StatusEffects_29_ChangeTime = Stream.Read.UShort();
                StatusEffects_30_ChangeTime = Stream.Read.UShort();
                StatusEffects_31_ChangeTime = Stream.Read.UShort();

                // Status Effect Data
                if (Bitfield[(int)BitfieldIndex.StatusEffects_0] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_1] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_2] == 0)
                {
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_3] == 0)
                {  
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_4] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_5] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_6] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_7] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_8] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_9] == 0)
                { 
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_10] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_11] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_12] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_13] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_14] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_15] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_16] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_17] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_18] == 0)
                {
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_19] == 0)
                {  
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_20] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_21] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_22] == 0)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_23] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_24] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_25] == 0)
                { 
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_26] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_27] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_28] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_29] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_30] == 0)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_31] == 0)
                { 
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
                }

                AllowFriendlyPickup = Stream.Read.Byte(); // guess
                AllowHostilePickup = Stream.Read.Byte(); // guess
                SinCardType = Stream.Read.UInt();

                if (Bitfield[(int)BitfieldIndex.SinCardFields_0] == 0)
                {
                    SinCardFields_0 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_1] == 0)
                {
                    SinCardFields_1 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_2] == 0)
                {
                    SinCardFields_2 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_3] == 0)
                {
                    SinCardFields_3 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_4] == 0)
                {
                    SinCardFields_4 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_5] == 0)
                {
                    SinCardFields_5 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_6] == 0)
                {
                    SinCardFields_6 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_7] == 0)
                {
                  SinCardFields_7 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_8] == 0)
                {
                    SinCardFields_8 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_9] == 0)
                {
                    SinCardFields_9 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_10] == 0)
                {
                    SinCardFields_10 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_11] == 0)
                {
                    SinCardFields_11 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_12] == 0)
                {
                    SinCardFields_12 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_13] == 0)
                {
                    SinCardFields_13 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_14] == 0)
                {
                    SinCardFields_14 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_15] == 0)
                {
                    SinCardFields_15 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_16] == 0)
                {
                    SinCardFields_16 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_17] == 0)
                {
                    SinCardFields_17 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_18] == 0)
                {
                    SinCardFields_18 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_19] == 0)
                {
                    SinCardFields_19 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_20] == 0)
                {
                    SinCardFields_20 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_21] == 0)
                {
                    SinCardFields_21 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_22] == 0)
                {
                    SinCardFields_22 = Stream.Read.SinCardField();
                }


                VisualInfoGroupIndex = Stream.Read.Byte();

                if (Bitfield[(int)BitfieldIndex.ThrownField] == 0)
                {
                    ThrownField_Unk1_Floats = Stream.Read.FloatArray(4);
                    ThrownField_Unk2_Bytes = Stream.Read.ByteArray(1);
                }
                if (Bitfield[(int)BitfieldIndex.SeekField] == 0)
                {
                    PeepWarning += "SeekField;";
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

    public struct SinCardField
    {
        public enum SinCardFieldDataType : byte
        {
            LocalizationId = 0, // 4 bytes
            Integer = 1, // 4 bytes
            EntityId = 2, // 8 bytes
            UnkType_3 = 3, // 8 bytes
            Enum = 4, // stringz
            UnkType_5 = 5, // ?
            Short = 6, // 2 bytes
            Timer = 7, // 9 bytes
            Boolean = 8, // 0 bytes???
        }

        public SinCardFieldDataType DataType;

        public uint LocalizationId;
        public uint Integer;
        public byte[] EntityId;
        public string Enum;
        public ushort Short;

        public byte[] UnkData;


        public SinCardField(Bitter.BinaryReader R)
        {
            // Sigh
            LocalizationId = 0;
            Integer = 0;
            EntityId = null;
            Enum = "";
            Short = 0;
            UnkData = null;

            // Parse
            DataType = (SinCardFieldDataType) R.Byte();

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    LocalizationId = R.UInt();
                    break;
                case SinCardFieldDataType.Integer:
                    Integer = R.UInt();
                    break;
                case SinCardFieldDataType.EntityId:
                    EntityId = R.ByteArray(8);
                    break;
                case SinCardFieldDataType.Enum:
                    Enum = R.StringZ();
                    break;
                case SinCardFieldDataType.Short:
                    Short = R.UShort();
                    break;
                case SinCardFieldDataType.Timer:
                    UnkData = R.ByteArray(9);
                    break;
            }
        }

        public override string ToString()
        {
            string result = $"{DataType}: ";

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    result += $"{LocalizationId}";
                    break;
                case SinCardFieldDataType.Integer:
                    result += $"{Integer}";
                    break;
                case SinCardFieldDataType.EntityId:
                    result += $"[{(EntityId != null ? String.Join(", ", EntityId) : "null")}]";
                    break;
                case SinCardFieldDataType.Enum:
                    result += $"{Enum}";
                    break;
                case SinCardFieldDataType.Short:
                    result += $"{Short}";
                    break;
                case SinCardFieldDataType.Timer:
                    result += $"[{(UnkData != null ? String.Join(", ", UnkData) : "null")}]";
                    break;
            }

            return result;
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

        public static SinCardField SinCardField(this Bitter.BinaryReader R)
        {
            return new SinCardField(R);
        }

        public static SinCardField[] SinCardFieldArray(this Bitter.BinaryReader R, int num)
        {
            List<SinCardField> list = new List<SinCardField>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.SinCardField());
            }
            return list.ToArray();
        }
    }
}