using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 3, true)]
    public class CharacterCombatViewKeyframe : BaseScript
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
            AppendageHealthPools_0,
            AppendageHealthPools_1,
            AppendageHealthPools_2,
            AppendageHealthPools_3,
            AppendageHealthPools_4,
            AppendageHealthPools_5,
            AppendageHealthPools_6,
            AppendageHealthPools_7,
            AppendageHealthPools_8,
            AppendageHealthPools_9,
            NPCTargetObjId,
            BattleChatterTag,
        }

        public string PeepWarning;
        public byte[] Bitfield;

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

        public byte? FireMode_0;
        public uint? FireMode_0_Time;
        public byte? FireMode_1;
        public uint? FireMode_1_Time;
        public ushort? Ammo_0;
        public ushort? Ammo_1;
        public ushort? AltAmmo_0;
        public ushort? AltAmmo_1;
        public byte? WeaponIndex_Index;
        public byte[] WeaponIndex_Unk;
        public uint? WeaponIndex_Time;
        public uint? ClipEmptyBegin;
        public uint? ClipEmptyEnd;
        public uint? WeaponBurstFired;
        public uint? WeaponBurstEnded;
        public uint? WeaponBurstCancelled;
        public uint? WeaponReloaded;
        public uint? WeaponReloadCancelled;
        public float? WeaponAgilityMod;
        public uint? AbilityCooldownEndMs_0;
        public uint? AbilityCooldownEndMs_1;
        public uint? AbilityCooldownEndMs_2;
        public uint? AbilityCooldownEndMs_3;
        public uint? EquipmentLoadTime;
        public uint? CombatFlags;
        public uint? CombatFlags_Time;

        public byte[] AppendageHealthPools_0;
        public byte[] AppendageHealthPools_1;
        public byte[] AppendageHealthPools_2;
        public byte[] AppendageHealthPools_3;
        public byte[] AppendageHealthPools_4;
        public byte[] AppendageHealthPools_5;
        public byte[] AppendageHealthPools_6;
        public byte[] AppendageHealthPools_7;
        public byte[] AppendageHealthPools_8;
        public byte[] AppendageHealthPools_9;

        public byte AppendageHealthPct_0; // Not sure
        public byte AppendageHealthPct_1; // Not sure
        public byte AppendageHealthPct_2; // Not sure
        public byte AppendageHealthPct_3; // Not sure
        public byte AppendageHealthPct_4; // Not sure
        public byte AppendageHealthPct_5; // Not sure
        public byte AppendageHealthPct_6; // Not sure
        public byte AppendageHealthPct_7; // Not sure
        public byte AppendageHealthPct_8; // Not sure
        public byte AppendageHealthPct_9; // Not sure

        public byte[] NPCTargetObjId;
        public byte[] BattleChatterTag;

        public byte[] MimicParent; // Not sure
        public byte[] MimicOffset; // Not sure
 
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true)
            {
                Bitfield = Stream.Read.BitArray(48);

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
                if (Bitfield[(int)BitfieldIndex.StatusEffects_0] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_1] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_2] == 0x00)
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
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_3] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_4] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_5] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_6] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_7] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_8] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_9] == 0x00)
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
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_10] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_11] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_12] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_13] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_14] == 0x00)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_15] == 0x00)
                { 
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_16] == 0x00)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_17] == 0x00)
                {
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_18] == 0x00)
                {
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
                }
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_19] == 0x00)
                {  
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
                }

                if (Bitfield[(int)BitfieldIndex.StatusEffects_20] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_21] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_22] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_23] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_24] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_25] == 0x00)
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
                
                if (Bitfield[(int)BitfieldIndex.StatusEffects_26] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_27] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_28] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_29] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_30] == 0x00)
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

                if (Bitfield[(int)BitfieldIndex.StatusEffects_31] == 0x00)
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

                FireMode_0 = Stream.Read.Byte();
                FireMode_0_Time = Stream.Read.UInt();
                FireMode_1 = Stream.Read.Byte();
                FireMode_1_Time = Stream.Read.UInt();
                Ammo_0 = Stream.Read.UShort();
                Ammo_1 = Stream.Read.UShort();
                AltAmmo_0 = Stream.Read.UShort();
                AltAmmo_1 = Stream.Read.UShort();
                WeaponIndex_Index = Stream.Read.Byte();
                WeaponIndex_Unk = Stream.Read.ByteArray(2);
                WeaponIndex_Time = Stream.Read.UInt();
                ClipEmptyBegin = Stream.Read.UInt();
                ClipEmptyEnd = Stream.Read.UInt();
                WeaponBurstFired = Stream.Read.UInt();
                WeaponBurstEnded = Stream.Read.UInt();
                WeaponBurstCancelled = Stream.Read.UInt();
                WeaponReloaded = Stream.Read.UInt();
                WeaponReloadCancelled = Stream.Read.UInt();
                WeaponAgilityMod = Stream.Read.Float();
                AbilityCooldownEndMs_0 = Stream.Read.UInt();
                AbilityCooldownEndMs_1 = Stream.Read.UInt();
                AbilityCooldownEndMs_2 = Stream.Read.UInt();
                AbilityCooldownEndMs_3 = Stream.Read.UInt();
                EquipmentLoadTime = Stream.Read.UInt();
                CombatFlags = Stream.Read.UInt();
                CombatFlags_Time = Stream.Read.UInt();

                // TODO: AppendageHealthPools
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_0] == 0)
                {
                    PeepWarning += "AppendageHealthPools_0;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_1] == 0)
                {
                    PeepWarning += "AppendageHealthPools_1;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_2] == 0)
                {
                    PeepWarning += "AppendageHealthPools_2;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_3] == 0)
                {
                    PeepWarning += "AppendageHealthPools_3;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_4] == 0)
                {
                    PeepWarning += "AppendageHealthPools_4;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_5] == 0)
                {
                    PeepWarning += "AppendageHealthPools_5;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_6] == 0)
                {
                    PeepWarning += "AppendageHealthPools_6;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_7] == 0)
                {
                    PeepWarning += "AppendageHealthPools_7;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_8] == 0)
                {
                    PeepWarning += "AppendageHealthPools_8;";
                }
                if(Bitfield[(int)BitfieldIndex.AppendageHealthPools_9] == 0)
                {
                    PeepWarning += "AppendageHealthPools_9;";
                }

                // AppendageHealthPct (guess, but it's rock solid for the entities that have npctargetobjid)
                AppendageHealthPct_0 = Stream.Read.Byte();
                AppendageHealthPct_1 = Stream.Read.Byte();
                AppendageHealthPct_2 = Stream.Read.Byte();
                AppendageHealthPct_3 = Stream.Read.Byte();
                AppendageHealthPct_4 = Stream.Read.Byte();
                AppendageHealthPct_5 = Stream.Read.Byte();
                AppendageHealthPct_6 = Stream.Read.Byte();
                AppendageHealthPct_7 = Stream.Read.Byte();
                AppendageHealthPct_8 = Stream.Read.Byte();
                AppendageHealthPct_9 = Stream.Read.Byte();

                if(Bitfield[(int)BitfieldIndex.NPCTargetObjId] == 0)
                {
                    NPCTargetObjId = Stream.Read.ByteArray(8);
                }
                if(Bitfield[(int)BitfieldIndex.BattleChatterTag] == 0)
                {
                    PeepWarning += "BattleChatterTag;";
                    BattleChatterTag = Stream.Read.ByteArray(2);
                }

                MimicParent = Stream.Read.ByteArray(8); // Have yet to find a proper example, but ends up being 0s consistently so thats good
                MimicOffset = Stream.Read.ByteArray(12); // Many cases of values but not sure what they are, hardly fitting for floats, maybe something packed

            }
            
        }
    }
}