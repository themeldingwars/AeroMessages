using Bitter;
namespace PacketPeepScript
{
    // Need a capture or replay of these, this is mostly guesswork based on shadowfields and what the client seems to like.
    [Script(MessageType.GSS, 48, 3, true)]
    public class ResourceNodeObserverViewUpdate : BaseScript
    {
        public byte[] Bitfield_StatusEffectData; // Assumption
        public byte[] Unk_InitialBytes;
        public uint NodeType;
        public string Owner;
        public uint UnkMaybeTime;
        public float[] Position;
        public uint BeaconId;
        public byte CurrentHealthPct;
        public uint MaxHealth;
        public float Progress;
        public byte StateInfo;

        public ushort? StatusEffect_00_ShortTime;
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

        public ushort? StatusEffect_01_ShortTime;
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

        public ushort? StatusEffect_02_ShortTime;
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

        public ushort? StatusEffect_03_ShortTime;
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

        public ushort? StatusEffect_04_ShortTime;
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

        public ushort? StatusEffect_05_ShortTime;
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

        public ushort? StatusEffect_06_ShortTime;
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

        public ushort? StatusEffect_07_ShortTime;
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

        public ushort? StatusEffect_08_ShortTime;
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

        public ushort? StatusEffect_09_ShortTime;
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

        public ushort? StatusEffect_0a_ShortTime;
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

        public ushort? StatusEffect_0b_ShortTime;
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

        public ushort? StatusEffect_0c_ShortTime;
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

        public ushort? StatusEffect_0d_ShortTime;
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

        public ushort? StatusEffect_0e_ShortTime;
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

        public ushort? StatusEffect_0f_ShortTime;
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

        public byte[] Unk_RemainingBytes;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.BStream = Stream;

            if (true) {
                Bitfield_StatusEffectData = Stream.Read.BitArray(32);

                Unk_InitialBytes = Stream.Read.ByteArray(17);
                //NodeType = Stream.Read.UInt(); // Somewhere in the 17 bytes...

                string Owner = Stream.Read.StringZ();
                uint UnkMaybeTime = Stream.Read.UInt();
                float[] Position = Stream.Read.FloatArray(3);

                uint BeaconId = Stream.Read.UInt();
                byte CurrentHealthPct = Stream.Read.Byte();
                uint MaxHealth = Stream.Read.UInt();
                float Progress = Stream.Read.Float();
                byte StateInfo = Stream.Read.Byte();

                // Status Times
                if (Bitfield_StatusEffectData[0] == 0x00)
                {
                    StatusEffect_00_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[1] == 0x00)
                {
                    StatusEffect_01_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[2] == 0x00)
                {
                    StatusEffect_02_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[3] == 0x00)
                {
                    StatusEffect_03_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[4] == 0x00)
                {
                    StatusEffect_04_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[5] == 0x00)
                {
                    StatusEffect_05_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[6] == 0x00)
                {
                    StatusEffect_06_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[7] == 0x00)
                {
                    StatusEffect_07_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[8] == 0x00)
                {
                    StatusEffect_08_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[9] == 0x00)
                {
                    StatusEffect_09_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[10] == 0x00)
                {
                    StatusEffect_0a_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[11] == 0x00)
                {
                    StatusEffect_0b_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[12] == 0x00)
                {
                    StatusEffect_0c_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[13] == 0x00)
                {
                    StatusEffect_0d_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[14] == 0x00)
                {
                    StatusEffect_0e_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[15] == 0x00)
                {
                    StatusEffect_0f_ShortTime = Stream.Read.UShort();
                }

                // Status Effect Data
                if (Bitfield_StatusEffectData[0] == 0x00)
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

                if (Bitfield_StatusEffectData[1] == 0x00)
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

                if (Bitfield_StatusEffectData[2] == 0x00)
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
                
                if (Bitfield_StatusEffectData[3] == 0x00)
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

                if (Bitfield_StatusEffectData[4] == 0x00)
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

                if (Bitfield_StatusEffectData[5] == 0x00)
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

                if (Bitfield_StatusEffectData[6] == 0x00)
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

                if (Bitfield_StatusEffectData[7] == 0x00)
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

                if (Bitfield_StatusEffectData[8] == 0x00)
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

                if (Bitfield_StatusEffectData[9] == 0x00)
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
                
                if (Bitfield_StatusEffectData[10] == 0x00)
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

                if (Bitfield_StatusEffectData[11] == 0x00)
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

                if (Bitfield_StatusEffectData[12] == 0x00)
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

                if (Bitfield_StatusEffectData[13] == 0x00)
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

                if (Bitfield_StatusEffectData[14] == 0x00)
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

                if (Bitfield_StatusEffectData[15] == 0x00)
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

                int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                Unk_RemainingBytes = Stream.Read.ByteArray(remaining);
            }
        }
    }

    public static class MyExtensions {
        public static Bitter.BinaryStream BStream;

        public static string StringZ(this Bitter.BinaryReader rdr) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            return ret;
        }
    }
}