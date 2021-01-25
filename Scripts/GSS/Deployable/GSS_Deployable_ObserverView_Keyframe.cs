using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 35, 3, true)]
    public class DeployableObserverViewKeyframe : BaseScript
    {
        public byte[] Bitfield_StatusEffectData; // Assuming it will support at least 16 status effects
        public byte[] Unk_ContentBytes; // Focusing on making the parsing work when all these are 0xFF

        public uint DeployableTypeId; // Sdb table 187, id column.

        public byte[] OwnerEntity;
        public ulong OwnerEntity_Value;

        public uint SourceAbilityId; // example in msgidx 123396

        public float[] Position;
        public float[] Rotation;

        public float[] Position2; // But why?
        public float[] MaybeDirection; // A guess 

        public byte UnkByte;
        public uint UnkTime;
        public int MaxHealth;
        public byte Level;

        public string UnkMemoryLeak; // Inbetween effect times and data.

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

        public byte[] Faction;

        public byte[] Unk_LastBytes;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield_StatusEffectData = Stream.Read.BitArray(16);
                Unk_ContentBytes = Stream.Read.ByteArray(6);

                DeployableTypeId = Stream.Read.UInt();

                OwnerEntity = Stream.Read.ByteArray(8);
                Stream.baseStream.ByteOffset -= 8;
                OwnerEntity_Value = Stream.Read.ULong() & 0xFFFFFFFFFFFFFF00;
                
                SourceAbilityId = Stream.Read.UInt();

                Position = Stream.Read.FloatArray(3);
                Rotation = Stream.Read.FloatArray(4);
                
                Position2 = Stream.Read.FloatArray(3);
                MaybeDirection = Stream.Read.FloatArray(3);

                UnkByte = Stream.Read.Byte();
                UnkTime = Stream.Read.UInt();

                MaxHealth = Stream.Read.Int(); 
                Level = Stream.Read.Byte();

                // Status Times
                if (Bitfield_StatusEffectData[0] == 0x00)
                {
                    StatusEffects_0_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[1] == 0x00)
                {
                    StatusEffects_1_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[2] == 0x00)
                {
                    StatusEffects_2_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[3] == 0x00)
                {
                    StatusEffects_3_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[4] == 0x00)
                {
                    StatusEffects_4_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[5] == 0x00)
                {
                    StatusEffects_5_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[6] == 0x00)
                {
                    StatusEffects_6_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[7] == 0x00)
                {
                    StatusEffects_7_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[8] == 0x00)
                {
                    StatusEffects_8_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[9] == 0x00)
                {
                    StatusEffects_9_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[10] == 0x00)
                {
                    StatusEffects_10_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[11] == 0x00)
                {
                    StatusEffects_11_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[12] == 0x00)
                {
                    StatusEffects_12_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[13] == 0x00)
                {
                    StatusEffects_13_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[14] == 0x00)
                {
                    StatusEffects_14_ChangeTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[15] == 0x00)
                {
                    StatusEffects_15_ChangeTime = Stream.Read.UShort();
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

                Faction = Stream.Read.ByteArray(2);

                Unk_LastBytes = Stream.Read.ByteArray(53);
            }
        }
    }
}