using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 28, 4, true)]
    public class VehicleCombatControllerKeyframe : BaseScript
    {
        public ulong PlayerID;
        public byte[] Bitfield_StatusEffectData;

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
        public bool? StatusEffects_0_Cancel;

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
        public bool? StatusEffects_1_Cancel;

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
        public bool? StatusEffects_2_Cancel;

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
        public bool? StatusEffects_3_Cancel;

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
        public bool? StatusEffects_4_Cancel;

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
        public bool? StatusEffects_5_Cancel;

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
        public bool? StatusEffects_6_Cancel;

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
        public bool? StatusEffects_7_Cancel;

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
        public bool? StatusEffects_8_Cancel;

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
        public bool? StatusEffects_9_Cancel;

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
        public bool? StatusEffects_10_Cancel;

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
        public bool? StatusEffects_11_Cancel;

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
        public bool? StatusEffects_12_Cancel;

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
        public bool? StatusEffects_13_Cancel;

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
        public bool? StatusEffects_14_Cancel;

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
        public bool? StatusEffects_15_Cancel;

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
        public bool? StatusEffects_16_Cancel;

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
        public bool? StatusEffects_17_Cancel;

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
        public bool? StatusEffects_18_Cancel;

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
        public bool? StatusEffects_19_Cancel;

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
        public bool? StatusEffects_20_Cancel;

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
        public bool? StatusEffects_21_Cancel;

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
        public bool? StatusEffects_22_Cancel;

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
        public bool? StatusEffects_23_Cancel;

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
        public bool? StatusEffects_24_Cancel;

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
        public bool? StatusEffects_25_Cancel;

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
        public bool? StatusEffects_26_Cancel;

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
        public bool? StatusEffects_27_Cancel;

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
        public bool? StatusEffects_28_Cancel;

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
        public bool? StatusEffects_29_Cancel;

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
        public bool? StatusEffects_30_Cancel;

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
        public bool? StatusEffects_31_Cancel;

        public string UnkMemoryLeak;

        // Type might be wrong for some
        public uint Unk_0x40;
        public uint Unk_0x41;
        public uint Unk_0x42;
        public uint Unk_0x43;
        public uint Unk_0x44;
        public uint Unk_0x45;
        public uint Unk_0x46;
        public uint Unk_0x47;
        public uint Unk_0x48;
        // --

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            if (true)
            {
                PlayerID = Stream.Read.ULong();
                Bitfield_StatusEffectData = Stream.Read.BitArray(32); 

                // Status Effect Times
                if (Bitfield_StatusEffectData[0x00] == 0x00) {
                    StatusEffects_0_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x01] == 0x00) {
                    StatusEffects_1_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x02] == 0x00) {
                    StatusEffects_2_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x03] == 0x00) {
                    StatusEffects_3_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x04] == 0x00) {
                    StatusEffects_4_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x05] == 0x00) {
                    StatusEffects_5_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x06] == 0x00) {
                    StatusEffects_6_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x07] == 0x00) {
                    StatusEffects_7_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x08] == 0x00) {
                    StatusEffects_8_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x09] == 0x00) {
                    StatusEffects_9_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0a] == 0x00) {
                    StatusEffects_10_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0b] == 0x00) {
                    StatusEffects_11_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0c] == 0x00) {
                    StatusEffects_12_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0d] == 0x00) {
                    StatusEffects_13_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0e] == 0x00) {
                    StatusEffects_14_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x0f] == 0x00) {
                    StatusEffects_15_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x10] == 0x00) {
                    StatusEffects_16_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x11] == 0x00) {
                    StatusEffects_17_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x12] == 0x00) {
                    StatusEffects_18_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x13] == 0x00) {
                    StatusEffects_19_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x14] == 0x00) {
                    StatusEffects_20_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x15] == 0x00) {
                    StatusEffects_21_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x16] == 0x00) {
                    StatusEffects_22_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x17] == 0x00) {
                    StatusEffects_23_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x18] == 0x00) {
                    StatusEffects_24_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x19] == 0x00) {
                    StatusEffects_25_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1a] == 0x00) {
                    StatusEffects_26_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1b] == 0x00) {
                    StatusEffects_27_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1c] == 0x00) {
                    StatusEffects_28_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1d] == 0x00) {
                    StatusEffects_29_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1e] == 0x00) {
                    StatusEffects_30_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[0x1f] == 0x00) {
                    StatusEffects_31_ChangeTime = Stream.Read.UShort();
                }

                // This text is fucking weird, I'm half assuming this was due to some kind of bug.
                // It is neither null-terminated nor size-indicated but it appears to be predictable relative to number of status effects...
                // This solution appears to work for 0, 1, and 3 status effects.
                int NumberOfStatusEffects = 0;
                foreach (byte b in Bitfield_StatusEffectData)
                {
                    if (b == 0x00)
                        NumberOfStatusEffects++;
                }
                int WeirdTextLength = 64 - (2*NumberOfStatusEffects);
                UnkMemoryLeak = Stream.Read.String(WeirdTextLength);
      

                // Status Effect Data
                if (Bitfield_StatusEffectData[0] == 0x00)
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

                if (Bitfield_StatusEffectData[1] == 0x00)
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

                if (Bitfield_StatusEffectData[2] == 0x00)
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
                
                if (Bitfield_StatusEffectData[3] == 0x00)
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

                if (Bitfield_StatusEffectData[4] == 0x00)
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

                if (Bitfield_StatusEffectData[5] == 0x00)
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

                if (Bitfield_StatusEffectData[6] == 0x00)
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

                if (Bitfield_StatusEffectData[7] == 0x00)
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

                if (Bitfield_StatusEffectData[8] == 0x00)
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

                if (Bitfield_StatusEffectData[9] == 0x00)
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
                
                if (Bitfield_StatusEffectData[10] == 0x00)
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

                if (Bitfield_StatusEffectData[11] == 0x00)
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

                if (Bitfield_StatusEffectData[12] == 0x00)
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

                if (Bitfield_StatusEffectData[13] == 0x00)
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

                if (Bitfield_StatusEffectData[14] == 0x00)
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

                if (Bitfield_StatusEffectData[15] == 0x00)
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

                if (Bitfield_StatusEffectData[16] == 0x00)
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

                if (Bitfield_StatusEffectData[17] == 0x00)
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

                if (Bitfield_StatusEffectData[18] == 0x00)
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
                
                if (Bitfield_StatusEffectData[19] == 0x00)
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

                if (Bitfield_StatusEffectData[20] == 0x00)
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

                if (Bitfield_StatusEffectData[21] == 0x00)
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

                if (Bitfield_StatusEffectData[22] == 0x00)
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

                if (Bitfield_StatusEffectData[23] == 0x00)
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

                if (Bitfield_StatusEffectData[24] == 0x00)
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

                if (Bitfield_StatusEffectData[25] == 0x00)
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
                
                if (Bitfield_StatusEffectData[26] == 0x00)
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

                if (Bitfield_StatusEffectData[27] == 0x00)
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

                if (Bitfield_StatusEffectData[28] == 0x00)
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

                if (Bitfield_StatusEffectData[29] == 0x00)
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

                if (Bitfield_StatusEffectData[30] == 0x00)
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

                if (Bitfield_StatusEffectData[31] == 0x00)
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


                Unk_0x40 = Stream.Read.UInt();
                Unk_0x41 = Stream.Read.UInt();
                Unk_0x42 = Stream.Read.UInt();
                Unk_0x43 = Stream.Read.UInt();
                Unk_0x44 = Stream.Read.UInt();
                Unk_0x45 = Stream.Read.UInt();
                Unk_0x46 = Stream.Read.UInt();
                Unk_0x47 = Stream.Read.UInt();
                Unk_0x48 = Stream.Read.UInt();
            }
        }
    }
}