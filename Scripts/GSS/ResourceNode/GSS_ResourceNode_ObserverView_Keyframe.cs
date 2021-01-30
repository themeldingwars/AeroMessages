using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    // Need a capture or replay of these, this is mostly guesswork based on shadowfields and what the client seems to like.
    [Script(MessageType.GSS, 48, 3, true)]
    public class ResourceNodeObserverViewUpdate : BaseScript
    {
        enum BitfieldIndex : byte
        {
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
            PersonalFactionStance,
        }

        public byte[] Bitfield;
        public uint NodeType;
        public byte[] OwnerId1; // total assumption, similar to vehicle
        public byte[] OwnerId2; // total assumption, similar to vehicle
        public string Owner;
        public uint UnkMaybeTime;
        public float[] Position;
        public uint BeaconId;
        public byte CurrentHealthPct;
        public uint MaxHealth;
        public float Progress;
        public byte StateInfo_State;
        public uint StateInfo_Time;
        public uint StateInfo_CountdownTime;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public byte[] ScopeBubbleInfo;

        public ushort? StatusEffects_0_ChangeTime;
        public uint? StatusEffects_0_Id;
        public byte[] StatusEffects_0_Unk1;
        public string StatusEffects_0_Entity;
        public uint? StatusEffects_0_Time1;
        public byte? StatusEffects_0_MoreDataFlag;
        public byte? StatusEffects_0_Data1_Count;
        public string[] StatusEffects_0_Data1_Entity;
        public byte[] StatusEffects_0_UnkData;
        public float? StatusEffects_0_Data_Float1;
        public float? StatusEffects_0_Data_Float2;
        public bool? Clear_StatusEffects_0;

        public ushort? StatusEffects_1_ChangeTime;
        public uint? StatusEffects_1_Id;
        public byte[] StatusEffects_1_Unk1;
        public string StatusEffects_1_Entity;
        public uint? StatusEffects_1_Time1;
        public byte? StatusEffects_1_MoreDataFlag;
        public byte? StatusEffects_1_Data1_Count;
        public string[] StatusEffects_1_Data1_Entity;
        public byte[] StatusEffects_1_UnkData;
        public float? StatusEffects_1_Data_Float1;
        public float? StatusEffects_1_Data_Float2;
        public bool? Clear_StatusEffects_1;

        public ushort? StatusEffects_2_ChangeTime;
        public uint? StatusEffects_2_Id;
        public byte[] StatusEffects_2_Unk1;
        public string StatusEffects_2_Entity;
        public uint? StatusEffects_2_Time1;
        public byte? StatusEffects_2_MoreDataFlag;
        public byte? StatusEffects_2_Data1_Count;
        public string[] StatusEffects_2_Data1_Entity;
        public byte[] StatusEffects_2_UnkData;
        public float? StatusEffects_2_Data_Float1;
        public float? StatusEffects_2_Data_Float2;
        public bool? Clear_StatusEffects_2;

        public ushort? StatusEffects_3_ChangeTime;
        public uint? StatusEffects_3_Id;
        public byte[] StatusEffects_3_Unk1;
        public string StatusEffects_3_Entity;
        public uint? StatusEffects_3_Time1;
        public byte? StatusEffects_3_MoreDataFlag;
        public byte? StatusEffects_3_Data1_Count;
        public string[] StatusEffects_3_Data1_Entity;
        public byte[] StatusEffects_3_UnkData;
        public float? StatusEffects_3_Data_Float1;
        public float? StatusEffects_3_Data_Float2;
        public bool? Clear_StatusEffects_3;

        public ushort? StatusEffects_4_ChangeTime;
        public uint? StatusEffects_4_Id;
        public byte[] StatusEffects_4_Unk1;
        public string StatusEffects_4_Entity;
        public uint? StatusEffects_4_Time1;
        public byte? StatusEffects_4_MoreDataFlag;
        public byte? StatusEffects_4_Data1_Count;
        public string[] StatusEffects_4_Data1_Entity;
        public byte[] StatusEffects_4_UnkData;
        public float? StatusEffects_4_Data_Float1;
        public float? StatusEffects_4_Data_Float2;
        public bool? Clear_StatusEffects_4;

        public ushort? StatusEffects_5_ChangeTime;
        public uint? StatusEffects_5_Id;
        public byte[] StatusEffects_5_Unk1;
        public string StatusEffects_5_Entity;
        public uint? StatusEffects_5_Time1;
        public byte? StatusEffects_5_MoreDataFlag;
        public byte? StatusEffects_5_Data1_Count;
        public string[] StatusEffects_5_Data1_Entity;
        public byte[] StatusEffects_5_UnkData;
        public float? StatusEffects_5_Data_Float1;
        public float? StatusEffects_5_Data_Float2;
        public bool? Clear_StatusEffects_5;

        public ushort? StatusEffects_6_ChangeTime;
        public uint? StatusEffects_6_Id;
        public byte[] StatusEffects_6_Unk1;
        public string StatusEffects_6_Entity;
        public uint? StatusEffects_6_Time1;
        public byte? StatusEffects_6_MoreDataFlag;
        public byte? StatusEffects_6_Data1_Count;
        public string[] StatusEffects_6_Data1_Entity;
        public byte[] StatusEffects_6_UnkData;
        public float? StatusEffects_6_Data_Float1;
        public float? StatusEffects_6_Data_Float2;
        public bool? Clear_StatusEffects_6;

        public ushort? StatusEffects_7_ChangeTime;
        public uint? StatusEffects_7_Id;
        public byte[] StatusEffects_7_Unk1;
        public string StatusEffects_7_Entity;
        public uint? StatusEffects_7_Time1;
        public byte? StatusEffects_7_MoreDataFlag;
        public byte? StatusEffects_7_Data1_Count;
        public string[] StatusEffects_7_Data1_Entity;
        public byte[] StatusEffects_7_UnkData;
        public float? StatusEffects_7_Data_Float1;
        public float? StatusEffects_7_Data_Float2;
        public bool? Clear_StatusEffects_7;

        public ushort? StatusEffects_8_ChangeTime;
        public uint? StatusEffects_8_Id; 
        public byte[] StatusEffects_8_Unk1;
        public string StatusEffects_8_Entity;
        public uint? StatusEffects_8_Time1;
        public byte? StatusEffects_8_MoreDataFlag;
        public byte? StatusEffects_8_Data1_Count;
        public string[] StatusEffects_8_Data1_Entity;
        public byte[] StatusEffects_8_UnkData;
        public float? StatusEffects_8_Data_Float1;
        public float? StatusEffects_8_Data_Float2;
        public bool? Clear_StatusEffects_8;

        public ushort? StatusEffects_9_ChangeTime;
        public uint? StatusEffects_9_Id;
        public byte[] StatusEffects_9_Unk1;
        public string StatusEffects_9_Entity;
        public uint? StatusEffects_9_Time1;
        public byte? StatusEffects_9_MoreDataFlag;
        public byte? StatusEffects_9_Data1_Count;
        public string[] StatusEffects_9_Data1_Entity;
        public byte[] StatusEffects_9_UnkData;
        public float? StatusEffects_9_Data_Float1;
        public float? StatusEffects_9_Data_Float2;
        public bool? Clear_StatusEffects_9;

        public ushort? StatusEffects_10_ChangeTime;
        public uint? StatusEffects_10_Id;
        public byte[] StatusEffects_10_Unk1;
        public string StatusEffects_10_Entity;
        public uint? StatusEffects_10_Time1;
        public byte? StatusEffects_10_MoreDataFlag;
        public byte? StatusEffects_10_Data1_Count;
        public string[] StatusEffects_10_Data1_Entity;
        public byte[] StatusEffects_10_UnkData;
        public float? StatusEffects_10_Data_Float1;
        public float? StatusEffects_10_Data_Float2;
        public bool? Clear_StatusEffects_10;

        public ushort? StatusEffects_11_ChangeTime;
        public uint? StatusEffects_11_Id;
        public byte[] StatusEffects_11_Unk1;
        public string StatusEffects_11_Entity;
        public uint? StatusEffects_11_Time1;
        public byte? StatusEffects_11_MoreDataFlag;
        public byte? StatusEffects_11_Data1_Count;
        public string[] StatusEffects_11_Data1_Entity;
        public byte[] StatusEffects_11_UnkData;
        public float? StatusEffects_11_Data_Float1;
        public float? StatusEffects_11_Data_Float2;
        public bool? Clear_StatusEffects_11;

        public ushort? StatusEffects_12_ChangeTime;
        public uint? StatusEffects_12_Id;
        public byte[] StatusEffects_12_Unk1;
        public string StatusEffects_12_Entity;
        public uint? StatusEffects_12_Time1;
        public byte? StatusEffects_12_MoreDataFlag;
        public byte? StatusEffects_12_Data1_Count;
        public string[] StatusEffects_12_Data1_Entity;
        public byte[] StatusEffects_12_UnkData;
        public float? StatusEffects_12_Data_Float1;
        public float? StatusEffects_12_Data_Float2;
        public bool? Clear_StatusEffects_12;

        public ushort? StatusEffects_13_ChangeTime;
        public uint? StatusEffects_13_Id;
        public byte[] StatusEffects_13_Unk1;
        public string StatusEffects_13_Entity;
        public uint? StatusEffects_13_Time1;
        public byte? StatusEffects_13_MoreDataFlag;
        public byte? StatusEffects_13_Data1_Count;
        public string[] StatusEffects_13_Data1_Entity;
        public byte[] StatusEffects_13_UnkData;
        public float? StatusEffects_13_Data_Float1;
        public float? StatusEffects_13_Data_Float2;
        public bool? Clear_StatusEffects_13;

        public ushort? StatusEffects_14_ChangeTime;
        public uint? StatusEffects_14_Id;
        public byte[] StatusEffects_14_Unk1;
        public string StatusEffects_14_Entity;
        public uint? StatusEffects_14_Time1;
        public byte? StatusEffects_14_MoreDataFlag;
        public byte? StatusEffects_14_Data1_Count;
        public string[] StatusEffects_14_Data1_Entity;
        public byte[] StatusEffects_14_UnkData;
        public float? StatusEffects_14_Data_Float1;
        public float? StatusEffects_14_Data_Float2;
        public bool? Clear_StatusEffects_14;

        public ushort? StatusEffects_15_ChangeTime;
        public uint? StatusEffects_15_Id;
        public byte[] StatusEffects_15_Unk1;
        public string StatusEffects_15_Entity;
        public uint? StatusEffects_15_Time1;
        public byte? StatusEffects_15_MoreDataFlag;
        public byte? StatusEffects_15_Data1_Count;
        public string[] StatusEffects_15_Data1_Entity;
        public byte[] StatusEffects_15_UnkData;
        public float? StatusEffects_15_Data_Float1;
        public float? StatusEffects_15_Data_Float2;
        public bool? Clear_StatusEffects_15;

        public ushort? StatusEffects_16_ChangeTime;
        public uint? StatusEffects_16_Id;
        public byte[] StatusEffects_16_Unk1;
        public string StatusEffects_16_Entity;
        public uint? StatusEffects_16_Time1;
        public byte? StatusEffects_16_MoreDataFlag;
        public byte? StatusEffects_16_Data1_Count;
        public string[] StatusEffects_16_Data1_Entity;
        public byte[] StatusEffects_16_UnkData;
        public float? StatusEffects_16_Data_Float1;
        public float? StatusEffects_16_Data_Float2;
        public bool? Clear_StatusEffects_16;

        public ushort? StatusEffects_17_ChangeTime;
        public uint? StatusEffects_17_Id;
        public byte[] StatusEffects_17_Unk1;
        public string StatusEffects_17_Entity;
        public uint? StatusEffects_17_Time1;
        public byte? StatusEffects_17_MoreDataFlag;
        public byte? StatusEffects_17_Data1_Count;
        public string[] StatusEffects_17_Data1_Entity;
        public byte[] StatusEffects_17_UnkData;
        public float? StatusEffects_17_Data_Float1;
        public float? StatusEffects_17_Data_Float2;
        public bool? Clear_StatusEffects_17;

        public ushort? StatusEffects_18_ChangeTime;
        public uint? StatusEffects_18_Id;
        public byte[] StatusEffects_18_Unk1;
        public string StatusEffects_18_Entity;
        public uint? StatusEffects_18_Time1;
        public byte? StatusEffects_18_MoreDataFlag;
        public byte? StatusEffects_18_Data1_Count;
        public string[] StatusEffects_18_Data1_Entity;
        public byte[] StatusEffects_18_UnkData;
        public float? StatusEffects_18_Data_Float1;
        public float? StatusEffects_18_Data_Float2;
        public bool? Clear_StatusEffects_18;

        public ushort? StatusEffects_19_ChangeTime;
        public uint? StatusEffects_19_Id;
        public byte[] StatusEffects_19_Unk1;
        public string StatusEffects_19_Entity;
        public uint? StatusEffects_19_Time1;
        public byte? StatusEffects_19_MoreDataFlag;
        public byte? StatusEffects_19_Data1_Count;
        public string[] StatusEffects_19_Data1_Entity;
        public byte[] StatusEffects_19_UnkData;
        public float? StatusEffects_19_Data_Float1;
        public float? StatusEffects_19_Data_Float2;
        public bool? Clear_StatusEffects_19;

        public ushort? StatusEffects_20_ChangeTime;
        public uint? StatusEffects_20_Id;
        public byte[] StatusEffects_20_Unk1;
        public string StatusEffects_20_Entity;
        public uint? StatusEffects_20_Time1;
        public byte? StatusEffects_20_MoreDataFlag;
        public byte? StatusEffects_20_Data1_Count;
        public string[] StatusEffects_20_Data1_Entity;
        public byte[] StatusEffects_20_UnkData;
        public float? StatusEffects_20_Data_Float1;
        public float? StatusEffects_20_Data_Float2;
        public bool? Clear_StatusEffects_20;

        public ushort? StatusEffects_21_ChangeTime;
        public uint? StatusEffects_21_Id;
        public byte[] StatusEffects_21_Unk1;
        public string StatusEffects_21_Entity;
        public uint? StatusEffects_21_Time1;
        public byte? StatusEffects_21_MoreDataFlag;
        public byte? StatusEffects_21_Data1_Count;
        public string[] StatusEffects_21_Data1_Entity;
        public byte[] StatusEffects_21_UnkData;
        public float? StatusEffects_21_Data_Float1;
        public float? StatusEffects_21_Data_Float2;
        public bool? Clear_StatusEffects_21;

        public ushort? StatusEffects_22_ChangeTime;
        public uint? StatusEffects_22_Id;
        public byte[] StatusEffects_22_Unk1;
        public string StatusEffects_22_Entity;
        public uint? StatusEffects_22_Time1;
        public byte? StatusEffects_22_MoreDataFlag;
        public byte? StatusEffects_22_Data1_Count;
        public string[] StatusEffects_22_Data1_Entity;
        public byte[] StatusEffects_22_UnkData;
        public float? StatusEffects_22_Data_Float1;
        public float? StatusEffects_22_Data_Float2;
        public bool? Clear_StatusEffects_22;

        public ushort? StatusEffects_23_ChangeTime;
        public uint? StatusEffects_23_Id;
        public byte[] StatusEffects_23_Unk1;
        public string StatusEffects_23_Entity;
        public uint? StatusEffects_23_Time1;
        public byte? StatusEffects_23_MoreDataFlag;
        public byte? StatusEffects_23_Data1_Count;
        public string[] StatusEffects_23_Data1_Entity;
        public byte[] StatusEffects_23_UnkData;
        public float? StatusEffects_23_Data_Float1;
        public float? StatusEffects_23_Data_Float2;
        public bool? Clear_StatusEffects_23;

        public ushort? StatusEffects_24_ChangeTime;
        public uint? StatusEffects_24_Id; 
        public byte[] StatusEffects_24_Unk1;
        public string StatusEffects_24_Entity;
        public uint? StatusEffects_24_Time1;
        public byte? StatusEffects_24_MoreDataFlag;
        public byte? StatusEffects_24_Data1_Count;
        public string[] StatusEffects_24_Data1_Entity;
        public byte[] StatusEffects_24_UnkData;
        public float? StatusEffects_24_Data_Float1;
        public float? StatusEffects_24_Data_Float2;
        public bool? Clear_StatusEffects_24;

        public ushort? StatusEffects_25_ChangeTime;
        public uint? StatusEffects_25_Id;
        public byte[] StatusEffects_25_Unk1;
        public string StatusEffects_25_Entity;
        public uint? StatusEffects_25_Time1;
        public byte? StatusEffects_25_MoreDataFlag;
        public byte? StatusEffects_25_Data1_Count;
        public string[] StatusEffects_25_Data1_Entity;
        public byte[] StatusEffects_25_UnkData;
        public float? StatusEffects_25_Data_Float1;
        public float? StatusEffects_25_Data_Float2;
        public bool? Clear_StatusEffects_25;

        public ushort? StatusEffects_26_ChangeTime;
        public uint? StatusEffects_26_Id;
        public byte[] StatusEffects_26_Unk1;
        public string StatusEffects_26_Entity;
        public uint? StatusEffects_26_Time1;
        public byte? StatusEffects_26_MoreDataFlag;
        public byte? StatusEffects_26_Data1_Count;
        public string[] StatusEffects_26_Data1_Entity;
        public byte[] StatusEffects_26_UnkData;
        public float? StatusEffects_26_Data_Float1;
        public float? StatusEffects_26_Data_Float2;
        public bool? Clear_StatusEffects_26;

        public ushort? StatusEffects_27_ChangeTime;
        public uint? StatusEffects_27_Id;
        public byte[] StatusEffects_27_Unk1;
        public string StatusEffects_27_Entity;
        public uint? StatusEffects_27_Time1;
        public byte? StatusEffects_27_MoreDataFlag;
        public byte? StatusEffects_27_Data1_Count;
        public string[] StatusEffects_27_Data1_Entity;
        public byte[] StatusEffects_27_UnkData;
        public float? StatusEffects_27_Data_Float1;
        public float? StatusEffects_27_Data_Float2;
        public bool? Clear_StatusEffects_27;

        public ushort? StatusEffects_28_ChangeTime;
        public uint? StatusEffects_28_Id;
        public byte[] StatusEffects_28_Unk1;
        public string StatusEffects_28_Entity;
        public uint? StatusEffects_28_Time1;
        public byte? StatusEffects_28_MoreDataFlag;
        public byte? StatusEffects_28_Data1_Count;
        public string[] StatusEffects_28_Data1_Entity;
        public byte[] StatusEffects_28_UnkData;
        public float? StatusEffects_28_Data_Float1;
        public float? StatusEffects_28_Data_Float2;
        public bool? Clear_StatusEffects_28;

        public ushort? StatusEffects_29_ChangeTime;
        public uint? StatusEffects_29_Id;
        public byte[] StatusEffects_29_Unk1;
        public string StatusEffects_29_Entity;
        public uint? StatusEffects_29_Time1;
        public byte? StatusEffects_29_MoreDataFlag;
        public byte? StatusEffects_29_Data1_Count;
        public string[] StatusEffects_29_Data1_Entity;
        public byte[] StatusEffects_29_UnkData;
        public float? StatusEffects_29_Data_Float1;
        public float? StatusEffects_29_Data_Float2;
        public bool? Clear_StatusEffects_29;

        public ushort? StatusEffects_30_ChangeTime;
        public uint? StatusEffects_30_Id;
        public byte[] StatusEffects_30_Unk1;
        public string StatusEffects_30_Entity;
        public uint? StatusEffects_30_Time1;
        public byte? StatusEffects_30_MoreDataFlag;
        public byte? StatusEffects_30_Data1_Count;
        public string[] StatusEffects_30_Data1_Entity;
        public byte[] StatusEffects_30_UnkData;
        public float? StatusEffects_30_Data_Float1;
        public float? StatusEffects_30_Data_Float2;
        public bool? Clear_StatusEffects_30;

        public ushort? StatusEffects_31_ChangeTime;
        public uint? StatusEffects_31_Id;
        public byte[] StatusEffects_31_Unk1;
        public string StatusEffects_31_Entity;
        public uint? StatusEffects_31_Time1;
        public byte? StatusEffects_31_MoreDataFlag;
        public byte? StatusEffects_31_Data1_Count;
        public string[] StatusEffects_31_Data1_Entity;
        public byte[] StatusEffects_31_UnkData;
        public float? StatusEffects_31_Data_Float1;
        public float? StatusEffects_31_Data_Float2;
        public bool? Clear_StatusEffects_31;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield = Stream.Read.BitArray(40);

                NodeType = Stream.Read.UInt();

                OwnerId1 = Stream.Read.ByteArray(8);
                OwnerId2 = Stream.Read.ByteArray(8);
                Owner = Stream.Read.StringZ();


                UnkMaybeTime = Stream.Read.UInt();
                Position = Stream.Read.FloatArray(3);
                BeaconId = Stream.Read.UInt();
                CurrentHealthPct = Stream.Read.Byte();
                MaxHealth = Stream.Read.UInt();
                Progress = Stream.Read.Float();
                StateInfo_State = Stream.Read.Byte();
                StateInfo_Time = Stream.Read.UInt();
                StateInfo_CountdownTime = Stream.Read.UInt();

                // Status Times
                if (Bitfield[(int)BitfieldIndex.StatusEffects_0] == 0) {
                    StatusEffects_0_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_1] == 0) {
                    StatusEffects_1_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_2] == 0) {
                    StatusEffects_2_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_3] == 0) {
                    StatusEffects_3_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_4] == 0) {
                    StatusEffects_4_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_5] == 0) {
                    StatusEffects_5_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_6] == 0) {
                    StatusEffects_6_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_7] == 0) {
                    StatusEffects_7_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_8] == 0) {
                    StatusEffects_8_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_9] == 0) {
                    StatusEffects_9_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_10] == 0) {
                    StatusEffects_10_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_11] == 0) {
                    StatusEffects_11_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_12] == 0) {
                    StatusEffects_12_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_13] == 0) {
                    StatusEffects_13_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_14] == 0) {
                    StatusEffects_14_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_15] == 0) {
                    StatusEffects_15_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_16] == 0) {
                    StatusEffects_16_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_17] == 0) {
                    StatusEffects_17_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_18] == 0) {
                    StatusEffects_18_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_19] == 0) {
                    StatusEffects_19_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_20] == 0) {
                    StatusEffects_20_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_21] == 0) {
                    StatusEffects_21_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_22] == 0) {
                    StatusEffects_22_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_23] == 0) {
                    StatusEffects_23_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_24] == 0) {
                    StatusEffects_24_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_25] == 0) {
                    StatusEffects_25_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_26] == 0) {
                    StatusEffects_26_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_27] == 0) {
                    StatusEffects_27_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_28] == 0) {
                    StatusEffects_28_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_29] == 0) {
                    StatusEffects_29_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_30] == 0) {
                    StatusEffects_30_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield[(int)BitfieldIndex.StatusEffects_31] == 0) {
                    StatusEffects_31_ChangeTime = Stream.Read.UShort();
                }

                // Status Effect Data
                if (Bitfield[(int)BitfieldIndex.StatusEffects_0] == 0)
                {
                    StatusEffects_0_Id     = Stream.Read.UInt();
                    StatusEffects_0_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_0_Entity = Stream.Read.Entity();
                    StatusEffects_0_Time1  = Stream.Read.UInt();
                    StatusEffects_0_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_0_MoreDataFlag == 0x01)
                    {
                        StatusEffects_0_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_0_Data1_Count > 0) {
                            StatusEffects_0_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_0_Data1_Count);
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
                    StatusEffects_1_Entity = Stream.Read.Entity();
                    StatusEffects_1_Time1  = Stream.Read.UInt();
                    StatusEffects_1_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_1_MoreDataFlag == 0x01)
                    {
                        StatusEffects_1_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_1_Data1_Count > 0) {
                            StatusEffects_1_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_1_Data1_Count);
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
                    StatusEffects_2_Entity = Stream.Read.Entity();
                    StatusEffects_2_Time1  = Stream.Read.UInt();
                    StatusEffects_2_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_2_MoreDataFlag == 0x01)
                    {
                        StatusEffects_2_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_2_Data1_Count > 0) {
                            StatusEffects_2_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_2_Data1_Count);
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
                    StatusEffects_3_Entity = Stream.Read.Entity();
                    StatusEffects_3_Time1  = Stream.Read.UInt();
                    StatusEffects_3_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_3_MoreDataFlag == 0x01)
                    {
                        StatusEffects_3_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_3_Data1_Count > 0) {
                            StatusEffects_3_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_3_Data1_Count);
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
                    StatusEffects_4_Entity = Stream.Read.Entity();
                    StatusEffects_4_Time1  = Stream.Read.UInt();
                    StatusEffects_4_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_4_MoreDataFlag == 0x01)
                    {
                        StatusEffects_4_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_4_Data1_Count > 0) {
                            StatusEffects_4_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_4_Data1_Count);
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
                    StatusEffects_5_Entity = Stream.Read.Entity();
                    StatusEffects_5_Time1  = Stream.Read.UInt();
                    StatusEffects_5_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_5_MoreDataFlag == 0x01)
                    {
                        StatusEffects_5_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_5_Data1_Count > 0) {
                            StatusEffects_5_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_5_Data1_Count);
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
                    StatusEffects_6_Entity = Stream.Read.Entity();
                    StatusEffects_6_Time1  = Stream.Read.UInt();
                    StatusEffects_6_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_6_MoreDataFlag == 0x01)
                    {
                        StatusEffects_6_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_6_Data1_Count > 0) {
                            StatusEffects_6_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_6_Data1_Count);
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
                    StatusEffects_7_Entity = Stream.Read.Entity();
                    StatusEffects_7_Time1  = Stream.Read.UInt();
                    StatusEffects_7_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_7_MoreDataFlag == 0x01)
                    {
                        StatusEffects_7_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_7_Data1_Count > 0) {
                            StatusEffects_7_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_7_Data1_Count);
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
                    StatusEffects_8_Entity = Stream.Read.Entity();
                    StatusEffects_8_Time1  = Stream.Read.UInt();
                    StatusEffects_8_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_8_MoreDataFlag == 0x01)
                    {
                        StatusEffects_8_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_8_Data1_Count > 0) {
                            StatusEffects_8_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_8_Data1_Count);
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
                    StatusEffects_9_Entity = Stream.Read.Entity();
                    StatusEffects_9_Time1  = Stream.Read.UInt();
                    StatusEffects_9_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_9_MoreDataFlag == 0x01)
                    {
                        StatusEffects_9_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_9_Data1_Count > 0) {
                            StatusEffects_9_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_9_Data1_Count);
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
                    StatusEffects_10_Entity = Stream.Read.Entity();
                    StatusEffects_10_Time1  = Stream.Read.UInt();
                    StatusEffects_10_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_10_MoreDataFlag == 0x01)
                    {
                        StatusEffects_10_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_10_Data1_Count > 0) {
                            StatusEffects_10_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_10_Data1_Count);
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
                    StatusEffects_11_Entity = Stream.Read.Entity();
                    StatusEffects_11_Time1  = Stream.Read.UInt();
                    StatusEffects_11_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_11_MoreDataFlag == 0x01)
                    {
                        StatusEffects_11_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_11_Data1_Count > 0) {
                            StatusEffects_11_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_11_Data1_Count);
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
                    StatusEffects_12_Entity = Stream.Read.Entity();
                    StatusEffects_12_Time1  = Stream.Read.UInt();
                    StatusEffects_12_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_12_MoreDataFlag == 0x01)
                    {
                        StatusEffects_12_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_12_Data1_Count > 0) {
                            StatusEffects_12_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_12_Data1_Count);
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
                    StatusEffects_13_Entity = Stream.Read.Entity();
                    StatusEffects_13_Time1  = Stream.Read.UInt();
                    StatusEffects_13_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_13_MoreDataFlag == 0x01)
                    {
                        StatusEffects_13_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_13_Data1_Count > 0) {
                            StatusEffects_13_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_13_Data1_Count);
                        }
                        StatusEffects_13_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_13_Data_Float1 = Stream.Read.Float();
                        StatusEffects_13_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_14] == 0)
                { 
                    StatusEffects_14_Id     = Stream.Read.UInt();
                    StatusEffects_14_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_14_Entity = Stream.Read.Entity();
                    StatusEffects_14_Time1  = Stream.Read.UInt();
                    StatusEffects_14_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_14_MoreDataFlag == 0x01)
                    {
                        StatusEffects_14_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_14_Data1_Count > 0) {
                            StatusEffects_14_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_14_Data1_Count);
                        }
                        StatusEffects_14_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_14_Data_Float1 = Stream.Read.Float();
                        StatusEffects_14_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_15] == 0)
                { 
                    StatusEffects_15_Id     = Stream.Read.UInt();
                    StatusEffects_15_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_15_Entity = Stream.Read.Entity();
                    StatusEffects_15_Time1  = Stream.Read.UInt();
                    StatusEffects_15_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_15_MoreDataFlag == 0x01)
                    {
                        StatusEffects_15_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_15_Data1_Count > 0) {
                            StatusEffects_15_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_15_Data1_Count);
                        }
                        StatusEffects_15_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_15_Data_Float1 = Stream.Read.Float();
                        StatusEffects_15_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_16] == 0)
                {
                    StatusEffects_16_Id     = Stream.Read.UInt();
                    StatusEffects_16_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_16_Entity = Stream.Read.Entity();
                    StatusEffects_16_Time1  = Stream.Read.UInt();
                    StatusEffects_16_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_16_MoreDataFlag == 0x01)
                    {
                        StatusEffects_16_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_16_Data1_Count > 0) {
                            StatusEffects_16_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_16_Data1_Count);
                        }
                        StatusEffects_16_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_16_Data_Float1 = Stream.Read.Float();
                        StatusEffects_16_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_17] == 0)
                {
                    StatusEffects_17_Id     = Stream.Read.UInt();
                    StatusEffects_17_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_17_Entity = Stream.Read.Entity();
                    StatusEffects_17_Time1  = Stream.Read.UInt();
                    StatusEffects_17_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_17_MoreDataFlag == 0x01)
                    {
                        StatusEffects_17_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_17_Data1_Count > 0) {
                            StatusEffects_17_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_17_Data1_Count);
                        }
                        StatusEffects_17_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_17_Data_Float1 = Stream.Read.Float();
                        StatusEffects_17_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_18] == 0)
                {
                    StatusEffects_18_Id     = Stream.Read.UInt();
                    StatusEffects_18_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_18_Entity = Stream.Read.Entity();
                    StatusEffects_18_Time1  = Stream.Read.UInt();
                    StatusEffects_18_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_18_MoreDataFlag == 0x01)
                    {
                        StatusEffects_18_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_18_Data1_Count > 0) {
                            StatusEffects_18_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_18_Data1_Count);
                        }
                        StatusEffects_18_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_18_Data_Float1 = Stream.Read.Float();
                        StatusEffects_18_Data_Float2 = Stream.Read.Float();
                    }
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_19] == 0)
                {  
                    StatusEffects_19_Id     = Stream.Read.UInt();
                    StatusEffects_19_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_19_Entity = Stream.Read.Entity();
                    StatusEffects_19_Time1  = Stream.Read.UInt();
                    StatusEffects_19_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_19_MoreDataFlag == 0x01)
                    {
                        StatusEffects_19_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_19_Data1_Count > 0) {
                            StatusEffects_19_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_19_Data1_Count);
                        }
                        StatusEffects_19_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_19_Data_Float1 = Stream.Read.Float();
                        StatusEffects_19_Data_Float2 = Stream.Read.Float();
                    }
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_20] == 0)
                { 
                    StatusEffects_20_Id     = Stream.Read.UInt();
                    StatusEffects_20_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffects_20_Entity = Stream.Read.Entity();
                    StatusEffects_20_Time1  = Stream.Read.UInt();
                    StatusEffects_20_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_20_MoreDataFlag == 0x01)
                    {
                        StatusEffects_20_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_20_Data1_Count > 0) {
                            StatusEffects_20_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_20_Data1_Count);
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
                    StatusEffects_21_Entity = Stream.Read.Entity();
                    StatusEffects_21_Time1  = Stream.Read.UInt();
                    StatusEffects_21_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_21_MoreDataFlag == 0x01)
                    {
                        StatusEffects_21_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_21_Data1_Count > 0) {
                            StatusEffects_21_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_21_Data1_Count);
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
                    StatusEffects_22_Entity = Stream.Read.Entity();
                    StatusEffects_22_Time1  = Stream.Read.UInt();
                    StatusEffects_22_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_22_MoreDataFlag == 0x01)
                    {
                        StatusEffects_22_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_22_Data1_Count > 0) {
                            StatusEffects_22_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_22_Data1_Count);
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
                    StatusEffects_23_Entity = Stream.Read.Entity();
                    StatusEffects_23_Time1  = Stream.Read.UInt();
                    StatusEffects_23_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_23_MoreDataFlag == 0x01)
                    {
                        StatusEffects_23_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_23_Data1_Count > 0) {
                            StatusEffects_23_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_23_Data1_Count);
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
                    StatusEffects_24_Entity = Stream.Read.Entity();
                    StatusEffects_24_Time1  = Stream.Read.UInt();
                    StatusEffects_24_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_24_MoreDataFlag == 0x01)
                    {
                        StatusEffects_24_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_24_Data1_Count > 0) {
                            StatusEffects_24_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_24_Data1_Count);
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
                    StatusEffects_25_Entity = Stream.Read.Entity();
                    StatusEffects_25_Time1  = Stream.Read.UInt();
                    StatusEffects_25_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_25_MoreDataFlag == 0x01)
                    {
                        StatusEffects_25_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_25_Data1_Count > 0) {
                            StatusEffects_25_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_25_Data1_Count);
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
                    StatusEffects_26_Entity = Stream.Read.Entity();
                    StatusEffects_26_Time1  = Stream.Read.UInt();
                    StatusEffects_26_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_26_MoreDataFlag == 0x01)
                    {
                        StatusEffects_26_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_26_Data1_Count > 0) {
                            StatusEffects_26_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_26_Data1_Count);
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
                    StatusEffects_27_Entity = Stream.Read.Entity();
                    StatusEffects_27_Time1  = Stream.Read.UInt();
                    StatusEffects_27_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_27_MoreDataFlag == 0x01)
                    {
                        StatusEffects_27_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_27_Data1_Count > 0) {
                            StatusEffects_27_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_27_Data1_Count);
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
                    StatusEffects_28_Entity = Stream.Read.Entity();
                    StatusEffects_28_Time1  = Stream.Read.UInt();
                    StatusEffects_28_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_28_MoreDataFlag == 0x01)
                    {
                        StatusEffects_28_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_28_Data1_Count > 0) {
                            StatusEffects_28_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_28_Data1_Count);
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
                    StatusEffects_29_Entity = Stream.Read.Entity();
                    StatusEffects_29_Time1  = Stream.Read.UInt();
                    StatusEffects_29_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_29_MoreDataFlag == 0x01)
                    {
                        StatusEffects_29_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_29_Data1_Count > 0) {
                            StatusEffects_29_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_29_Data1_Count);
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
                    StatusEffects_30_Entity = Stream.Read.Entity();
                    StatusEffects_30_Time1  = Stream.Read.UInt();
                    StatusEffects_30_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_30_MoreDataFlag == 0x01)
                    {
                        StatusEffects_30_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_30_Data1_Count > 0) {
                            StatusEffects_30_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_30_Data1_Count);
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
                    StatusEffects_31_Entity = Stream.Read.Entity();
                    StatusEffects_31_Time1  = Stream.Read.UInt();
                    StatusEffects_31_MoreDataFlag = Stream.Read.Byte();
                    if (StatusEffects_31_MoreDataFlag == 0x01)
                    {
                        StatusEffects_31_Data1_Count = Stream.Read.Byte();
                        if (StatusEffects_31_Data1_Count > 0) {
                            StatusEffects_31_Data1_Entity = Stream.Read.EntityArray((int)StatusEffects_31_Data1_Count);
                        }
                        StatusEffects_31_UnkData   = Stream.Read.ByteArray(29);
                        StatusEffects_31_Data_Float1 = Stream.Read.Float();
                        StatusEffects_31_Data_Float2 = Stream.Read.Float();
                    }
                }


                HostilityInfo = Stream.Read.ByteArray(2);
                if (Bitfield[(int)BitfieldIndex.PersonalFactionStance] == 0)
                {
                    PersonalFactionStance = Stream.Read.ByteArray(5*4);
                }
                ScopeBubbleInfo = Stream.Read.ByteArray(8);
            }
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
            
        public enum Controller : byte
        {
            Generic = 0x00,
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            TinyObjectType = 0x29,
            CharacterAbilityPhysics = 0x2a,
            ProjectileObjectType = 0x2b,
            Outpost = 0x2c,
            ResourceArea = 0x2e,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
            LootStoreExtension = 0x34,
            TeamManager = 0x36,
        }

        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            if (controller == 0 && id == 0) return "None";
            return $"{controller}:{id}";
        }

        public static string[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

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