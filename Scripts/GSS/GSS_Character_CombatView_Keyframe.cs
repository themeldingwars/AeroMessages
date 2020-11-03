using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 3, true)]
    public class CharacterCombatViewKeyframe : BaseScript
    {
        public byte[] Bitfield_StatusEffectData;
        public byte[] Unk_ContentBytes; // Probably

        public ushort? StatusEffect_00_ShortTime;
        public uint? StatusEffect_00_Id;
        public byte[] StatusEffect_00_Unk1;
        public byte[] StatusEffect_00_Entity;
        public uint? StatusEffect_00_Time1;
        public byte? StatusEffect_00_Unk2Flag;
        public byte[] StatusEffect_00_Unk2;
        public bool? StatusEffect_00_Cancel;

        public ushort? StatusEffect_01_ShortTime;
        public uint? StatusEffect_01_Id;
        public byte[] StatusEffect_01_Unk1;
        public byte[] StatusEffect_01_Entity;
        public uint? StatusEffect_01_Time1;
        public byte? StatusEffect_01_Unk2Flag;
        public byte[] StatusEffect_01_Unk2;
        public bool? StatusEffect_01_Cancel;

        public ushort? StatusEffect_02_ShortTime;
        public uint? StatusEffect_02_Id;
        public byte[] StatusEffect_02_Unk1;
        public byte[] StatusEffect_02_Entity;
        public uint? StatusEffect_02_Time1;
        public byte? StatusEffect_02_Unk2Flag;
        public byte[] StatusEffect_02_Unk2;
        public bool? StatusEffect_02_Cancel;

        public ushort? StatusEffect_03_ShortTime;
        public uint? StatusEffect_03_Id;
        public byte[] StatusEffect_03_Unk1;
        public byte[] StatusEffect_03_Entity;
        public uint? StatusEffect_03_Time1;
        public byte? StatusEffect_03_Unk2Flag;
        public byte[] StatusEffect_03_Unk2;
        public bool? StatusEffect_03_Cancel;

        public ushort? StatusEffect_04_ShortTime;
        public uint? StatusEffect_04_Id;
        public byte[] StatusEffect_04_Unk1;
        public byte[] StatusEffect_04_Entity;
        public uint? StatusEffect_04_Time1;
        public byte? StatusEffect_04_Unk2Flag;
        public byte[] StatusEffect_04_Unk2;
        public bool? StatusEffect_04_Cancel;

        public ushort? StatusEffect_05_ShortTime;
        public uint? StatusEffect_05_Id;
        public byte[] StatusEffect_05_Unk1;
        public byte[] StatusEffect_05_Entity;
        public uint? StatusEffect_05_Time1;
        public byte? StatusEffect_05_Unk2Flag;
        public byte[] StatusEffect_05_Unk2;
        public bool? StatusEffect_05_Cancel;

        public ushort? StatusEffect_06_ShortTime;
        public uint? StatusEffect_06_Id;
        public byte[] StatusEffect_06_Unk1;
        public byte[] StatusEffect_06_Entity;
        public uint? StatusEffect_06_Time1;
        public byte? StatusEffect_06_Unk2Flag;
        public byte[] StatusEffect_06_Unk2;
        public bool? StatusEffect_06_Cancel;

        public ushort? StatusEffect_07_ShortTime;
        public uint? StatusEffect_07_Id;
        public byte[] StatusEffect_07_Unk1;
        public byte[] StatusEffect_07_Entity;
        public uint? StatusEffect_07_Time1;
        public byte? StatusEffect_07_Unk2Flag;
        public byte[] StatusEffect_07_Unk2;
        public bool? StatusEffect_07_Cancel;

        public ushort? StatusEffect_08_ShortTime;
        public uint? StatusEffect_08_Id; 
        public byte[] StatusEffect_08_Unk1;
        public byte[] StatusEffect_08_Entity;
        public uint? StatusEffect_08_Time1;
        public byte? StatusEffect_08_Unk2Flag;
        public byte[] StatusEffect_08_Unk2;
        public bool? StatusEffect_08_Cancel;

        public ushort? StatusEffect_09_ShortTime;
        public uint? StatusEffect_09_Id;
        public byte[] StatusEffect_09_Unk1;
        public byte[] StatusEffect_09_Entity;
        public uint? StatusEffect_09_Time1;
        public byte? StatusEffect_09_Unk2Flag;
        public byte[] StatusEffect_09_Unk2;
        public bool? StatusEffect_09_Cancel;

        public ushort? StatusEffect_0a_ShortTime;
        public uint? StatusEffect_0a_Id;
        public byte[] StatusEffect_0a_Unk1;
        public byte[] StatusEffect_0a_Entity;
        public uint? StatusEffect_0a_Time1;
        public byte? StatusEffect_0a_Unk2Flag;
        public byte[] StatusEffect_0a_Unk2;
        public bool? StatusEffect_0a_Cancel;

        public ushort? StatusEffect_0b_ShortTime;
        public uint? StatusEffect_0b_Id;
        public byte[] StatusEffect_0b_Unk1;
        public byte[] StatusEffect_0b_Entity;
        public uint? StatusEffect_0b_Time1;
        public byte? StatusEffect_0b_Unk2Flag;
        public byte[] StatusEffect_0b_Unk2;
        public bool? StatusEffect_0b_Cancel;

        public ushort? StatusEffect_0c_ShortTime;
        public uint? StatusEffect_0c_Id;
        public byte[] StatusEffect_0c_Unk1;
        public byte[] StatusEffect_0c_Entity;
        public uint? StatusEffect_0c_Time1;
        public byte? StatusEffect_0c_Unk2Flag;
        public byte[] StatusEffect_0c_Unk2;
        public bool? StatusEffect_0c_Cancel;

        public ushort? StatusEffect_0d_ShortTime;
        public uint? StatusEffect_0d_Id;
        public byte[] StatusEffect_0d_Unk1;
        public byte[] StatusEffect_0d_Entity;
        public uint? StatusEffect_0d_Time1;
        public byte? StatusEffect_0d_Unk2Flag;
        public byte[] StatusEffect_0d_Unk2;
        public bool? StatusEffect_0d_Cancel;

        public ushort? StatusEffect_0e_ShortTime;
        public uint? StatusEffect_0e_Id;
        public byte[] StatusEffect_0e_Unk1;
        public byte[] StatusEffect_0e_Entity;
        public uint? StatusEffect_0e_Time1;
        public byte? StatusEffect_0e_Unk2Flag;
        public byte[] StatusEffect_0e_Unk2;
        public bool? StatusEffect_0e_Cancel;

        public ushort? StatusEffect_0f_ShortTime;
        public uint? StatusEffect_0f_Id;
        public byte[] StatusEffect_0f_Unk1;
        public byte[] StatusEffect_0f_Entity;
        public uint? StatusEffect_0f_Time1;
        public byte? StatusEffect_0f_Unk2Flag;
        public byte[] StatusEffect_0f_Unk2;
        public bool? StatusEffect_0f_Cancel;

        public ushort? StatusEffect_10_ShortTime;
        public uint? StatusEffect_10_Id;
        public byte[] StatusEffect_10_Unk1;
        public byte[] StatusEffect_10_Entity;
        public uint? StatusEffect_10_Time1;
        public byte? StatusEffect_10_Unk2Flag;
        public byte[] StatusEffect_10_Unk2;
        public bool? StatusEffect_10_Cancel;

        public ushort? StatusEffect_11_ShortTime;
        public uint? StatusEffect_11_Id;
        public byte[] StatusEffect_11_Unk1;
        public byte[] StatusEffect_11_Entity;
        public uint? StatusEffect_11_Time1;
        public byte? StatusEffect_11_Unk2Flag;
        public byte[] StatusEffect_11_Unk2;
        public bool? StatusEffect_11_Cancel;

        public ushort? StatusEffect_12_ShortTime;
        public uint? StatusEffect_12_Id;
        public byte[] StatusEffect_12_Unk1;
        public byte[] StatusEffect_12_Entity;
        public uint? StatusEffect_12_Time1;
        public byte? StatusEffect_12_Unk2Flag;
        public byte[] StatusEffect_12_Unk2;
        public bool? StatusEffect_12_Cancel;

        public ushort? StatusEffect_13_ShortTime;
        public uint? StatusEffect_13_Id;
        public byte[] StatusEffect_13_Unk1;
        public byte[] StatusEffect_13_Entity;
        public uint? StatusEffect_13_Time1;
        public byte? StatusEffect_13_Unk2Flag;
        public byte[] StatusEffect_13_Unk2;
        public bool? StatusEffect_13_Cancel;

        public ushort? StatusEffect_14_ShortTime;
        public uint? StatusEffect_14_Id;
        public byte[] StatusEffect_14_Unk1;
        public byte[] StatusEffect_14_Entity;
        public uint? StatusEffect_14_Time1;
        public byte? StatusEffect_14_Unk2Flag;
        public byte[] StatusEffect_14_Unk2;
        public bool? StatusEffect_14_Cancel;

        public ushort? StatusEffect_15_ShortTime;
        public uint? StatusEffect_15_Id;
        public byte[] StatusEffect_15_Unk1;
        public byte[] StatusEffect_15_Entity;
        public uint? StatusEffect_15_Time1;
        public byte? StatusEffect_15_Unk2Flag;
        public byte[] StatusEffect_15_Unk2;
        public bool? StatusEffect_15_Cancel;

        public ushort? StatusEffect_16_ShortTime;
        public uint? StatusEffect_16_Id;
        public byte[] StatusEffect_16_Unk1;
        public byte[] StatusEffect_16_Entity;
        public uint? StatusEffect_16_Time1;
        public byte? StatusEffect_16_Unk2Flag;
        public byte[] StatusEffect_16_Unk2;
        public bool? StatusEffect_16_Cancel;

        public ushort? StatusEffect_17_ShortTime;
        public uint? StatusEffect_17_Id;
        public byte[] StatusEffect_17_Unk1;
        public byte[] StatusEffect_17_Entity;
        public uint? StatusEffect_17_Time1;
        public byte? StatusEffect_17_Unk2Flag;
        public byte[] StatusEffect_17_Unk2;
        public bool? StatusEffect_17_Cancel;

        public ushort? StatusEffect_18_ShortTime;
        public uint? StatusEffect_18_Id; 
        public byte[] StatusEffect_18_Unk1;
        public byte[] StatusEffect_18_Entity;
        public uint? StatusEffect_18_Time1;
        public byte? StatusEffect_18_Unk2Flag;
        public byte[] StatusEffect_18_Unk2;
        public bool? StatusEffect_18_Cancel;

        public ushort? StatusEffect_19_ShortTime;
        public uint? StatusEffect_19_Id;
        public byte[] StatusEffect_19_Unk1;
        public byte[] StatusEffect_19_Entity;
        public uint? StatusEffect_19_Time1;
        public byte? StatusEffect_19_Unk2Flag;
        public byte[] StatusEffect_19_Unk2;
        public bool? StatusEffect_19_Cancel;

        public ushort? StatusEffect_1a_ShortTime;
        public uint? StatusEffect_1a_Id;
        public byte[] StatusEffect_1a_Unk1;
        public byte[] StatusEffect_1a_Entity;
        public uint? StatusEffect_1a_Time1;
        public byte? StatusEffect_1a_Unk2Flag;
        public byte[] StatusEffect_1a_Unk2;
        public bool? StatusEffect_1a_Cancel;

        public ushort? StatusEffect_1b_ShortTime;
        public uint? StatusEffect_1b_Id;
        public byte[] StatusEffect_1b_Unk1;
        public byte[] StatusEffect_1b_Entity;
        public uint? StatusEffect_1b_Time1;
        public byte? StatusEffect_1b_Unk2Flag;
        public byte[] StatusEffect_1b_Unk2;
        public bool? StatusEffect_1b_Cancel;

        public ushort? StatusEffect_1c_ShortTime;
        public uint? StatusEffect_1c_Id;
        public byte[] StatusEffect_1c_Unk1;
        public byte[] StatusEffect_1c_Entity;
        public uint? StatusEffect_1c_Time1;
        public byte? StatusEffect_1c_Unk2Flag;
        public byte[] StatusEffect_1c_Unk2;
        public bool? StatusEffect_1c_Cancel;

        public ushort? StatusEffect_1d_ShortTime;
        public uint? StatusEffect_1d_Id;
        public byte[] StatusEffect_1d_Unk1;
        public byte[] StatusEffect_1d_Entity;
        public uint? StatusEffect_1d_Time1;
        public byte? StatusEffect_1d_Unk2Flag;
        public byte[] StatusEffect_1d_Unk2;
        public bool? StatusEffect_1d_Cancel;

        public ushort? StatusEffect_1e_ShortTime;
        public uint? StatusEffect_1e_Id;
        public byte[] StatusEffect_1e_Unk1;
        public byte[] StatusEffect_1e_Entity;
        public uint? StatusEffect_1e_Time1;
        public byte? StatusEffect_1e_Unk2Flag;
        public byte[] StatusEffect_1e_Unk2;
        public bool? StatusEffect_1e_Cancel;

        public ushort? StatusEffect_1f_ShortTime;
        public uint? StatusEffect_1f_Id;
        public byte[] StatusEffect_1f_Unk1;
        public byte[] StatusEffect_1f_Entity;
        public uint? StatusEffect_1f_Time1;
        public byte? StatusEffect_1f_Unk2Flag;
        public byte[] StatusEffect_1f_Unk2;
        public bool? StatusEffect_1f_Cancel;


        public byte? SelectFireMode_FireMode;
        public uint? SelectFireMode_Time;
        public byte? UseScope_InScope;
        public uint? UseScope_Time;
        public ushort? Ammo_Primary_Clip_1;
        public ushort? Ammo_Secondary_Clip_1;
        public ushort? Ammo_Primary_Clip_2;
        public ushort? Ammo_Secondary_Clip_2;
        public byte? SelectWeapon_Index;
        public byte[] SelectWeapon_Unk;
        public uint? SelectWeapon_Time;
        public uint? Unk_0x47_Time;
        public uint? Unk_0x48_Time;
        public uint? FireBurst_Time;
        public uint? FireEnd_Time;
        public uint? FireCancel_Time;
        public uint? ReloadWeapon_Time;
        public uint? Unk_0x4e_Time;




        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true)
            {
                Bitfield_StatusEffectData = Stream.Read.BitArray(32); 
                Unk_ContentBytes = Stream.Read.ByteArray(2);

                StatusEffect_00_ShortTime = Stream.Read.UShort();
                StatusEffect_01_ShortTime = Stream.Read.UShort();
                StatusEffect_02_ShortTime = Stream.Read.UShort();
                StatusEffect_03_ShortTime = Stream.Read.UShort();
                StatusEffect_04_ShortTime = Stream.Read.UShort();
                StatusEffect_05_ShortTime = Stream.Read.UShort();
                StatusEffect_06_ShortTime = Stream.Read.UShort();
                StatusEffect_07_ShortTime = Stream.Read.UShort();
                StatusEffect_08_ShortTime = Stream.Read.UShort();
                StatusEffect_09_ShortTime = Stream.Read.UShort();
                StatusEffect_0a_ShortTime = Stream.Read.UShort();
                StatusEffect_0b_ShortTime = Stream.Read.UShort();
                StatusEffect_0c_ShortTime = Stream.Read.UShort();
                StatusEffect_0d_ShortTime = Stream.Read.UShort();
                StatusEffect_0e_ShortTime = Stream.Read.UShort();
                StatusEffect_0f_ShortTime = Stream.Read.UShort();
                StatusEffect_10_ShortTime = Stream.Read.UShort();
                StatusEffect_11_ShortTime = Stream.Read.UShort();
                StatusEffect_12_ShortTime = Stream.Read.UShort();
                StatusEffect_13_ShortTime = Stream.Read.UShort();
                StatusEffect_14_ShortTime = Stream.Read.UShort();
                StatusEffect_15_ShortTime = Stream.Read.UShort();
                StatusEffect_16_ShortTime = Stream.Read.UShort();
                StatusEffect_17_ShortTime = Stream.Read.UShort();
                StatusEffect_18_ShortTime = Stream.Read.UShort();
                StatusEffect_19_ShortTime = Stream.Read.UShort();
                StatusEffect_1a_ShortTime = Stream.Read.UShort();
                StatusEffect_1b_ShortTime = Stream.Read.UShort();
                StatusEffect_1c_ShortTime = Stream.Read.UShort();
                StatusEffect_1d_ShortTime = Stream.Read.UShort();
                StatusEffect_1e_ShortTime = Stream.Read.UShort();
                StatusEffect_1f_ShortTime = Stream.Read.UShort();


                // Status Effect Data
                if (Bitfield_StatusEffectData[0] == 0x00)
                {
                    StatusEffect_00_Id     = Stream.Read.UInt();
                    StatusEffect_00_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_00_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_00_Time1  = Stream.Read.UInt();
                    StatusEffect_00_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_00_Unk2Flag == 0x01)
                    {
                        StatusEffect_00_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[1] == 0x00)
                {
                    StatusEffect_01_Id     = Stream.Read.UInt();
                    StatusEffect_01_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_01_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_01_Time1  = Stream.Read.UInt();
                    StatusEffect_01_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_01_Unk2Flag == 0x01)
                    {
                        StatusEffect_01_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[2] == 0x00)
                {
                    StatusEffect_02_Id     = Stream.Read.UInt();
                    StatusEffect_02_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_02_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_02_Time1  = Stream.Read.UInt();
                    StatusEffect_02_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_02_Unk2Flag == 0x01)
                    {
                        StatusEffect_02_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[3] == 0x00)
                {  
                    StatusEffect_03_Id     = Stream.Read.UInt();
                    StatusEffect_03_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_03_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_03_Time1  = Stream.Read.UInt();
                    StatusEffect_03_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_03_Unk2Flag == 0x01)
                    {
                        StatusEffect_03_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[4] == 0x00)
                { 
                    StatusEffect_04_Id     = Stream.Read.UInt();
                    StatusEffect_04_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_04_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_04_Time1  = Stream.Read.UInt();
                    StatusEffect_04_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_04_Unk2Flag == 0x01)
                    {
                        StatusEffect_04_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[5] == 0x00)
                { 
                    StatusEffect_05_Id     = Stream.Read.UInt();
                    StatusEffect_05_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_05_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_05_Time1  = Stream.Read.UInt();
                    StatusEffect_05_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_05_Unk2Flag == 0x01)
                    {
                        StatusEffect_05_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[6] == 0x00)
                {
                    StatusEffect_06_Id     = Stream.Read.UInt();
                    StatusEffect_06_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_06_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_06_Time1  = Stream.Read.UInt();
                    StatusEffect_06_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_06_Unk2Flag == 0x01)
                    {
                        StatusEffect_06_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[7] == 0x00)
                { 
                    StatusEffect_07_Id     = Stream.Read.UInt();
                    StatusEffect_07_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_07_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_07_Time1  = Stream.Read.UInt();
                    StatusEffect_07_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_07_Unk2Flag == 0x01)
                    {
                        StatusEffect_07_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[8] == 0x00)
                { 
                    StatusEffect_08_Id     = Stream.Read.UInt();
                    StatusEffect_08_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_08_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_08_Time1  = Stream.Read.UInt();
                    StatusEffect_08_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_08_Unk2Flag == 0x01)
                    {
                        StatusEffect_08_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[9] == 0x00)
                { 
                    StatusEffect_09_Id     = Stream.Read.UInt();
                    StatusEffect_09_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_09_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_09_Time1  = Stream.Read.UInt();
                    StatusEffect_09_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_09_Unk2Flag == 0x01)
                    {
                        StatusEffect_09_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[10] == 0x00)
                { 
                    StatusEffect_0a_Id     = Stream.Read.UInt();
                    StatusEffect_0a_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0a_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0a_Time1  = Stream.Read.UInt();
                    StatusEffect_0a_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0a_Unk2Flag == 0x01)
                    {
                        StatusEffect_0a_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[11] == 0x00)
                { 
                    StatusEffect_0b_Id     = Stream.Read.UInt();
                    StatusEffect_0b_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0b_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0b_Time1  = Stream.Read.UInt();
                    StatusEffect_0b_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0b_Unk2Flag == 0x01)
                    {
                        StatusEffect_0b_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[12] == 0x00)
                { 
                    StatusEffect_0c_Id     = Stream.Read.UInt();
                    StatusEffect_0c_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0c_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0c_Time1  = Stream.Read.UInt();
                    StatusEffect_0c_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0c_Unk2Flag == 0x01)
                    {
                        StatusEffect_0c_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[13] == 0x00)
                { 
                    StatusEffect_0d_Id     = Stream.Read.UInt();
                    StatusEffect_0d_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0d_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0d_Time1  = Stream.Read.UInt();
                    StatusEffect_0d_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0d_Unk2Flag == 0x01)
                    {
                        StatusEffect_0d_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[14] == 0x00)
                { 
                    StatusEffect_0e_Id     = Stream.Read.UInt();
                    StatusEffect_0e_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0e_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0e_Time1  = Stream.Read.UInt();
                    StatusEffect_0e_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0e_Unk2Flag == 0x01)
                    {
                        StatusEffect_0e_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[15] == 0x00)
                { 
                    StatusEffect_0f_Id     = Stream.Read.UInt();
                    StatusEffect_0f_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0f_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0f_Time1  = Stream.Read.UInt();
                    StatusEffect_0f_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0f_Unk2Flag == 0x01)
                    {
                        StatusEffect_0f_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[16] == 0x00)
                {
                    StatusEffect_10_Id     = Stream.Read.UInt();
                    StatusEffect_10_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_10_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_10_Time1  = Stream.Read.UInt();
                    StatusEffect_10_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_10_Unk2Flag == 0x01)
                    {
                        StatusEffect_10_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[17] == 0x00)
                {
                    StatusEffect_11_Id     = Stream.Read.UInt();
                    StatusEffect_11_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_11_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_11_Time1  = Stream.Read.UInt();
                    StatusEffect_11_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_11_Unk2Flag == 0x01)
                    {
                        StatusEffect_11_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[18] == 0x00)
                {
                    StatusEffect_12_Id     = Stream.Read.UInt();
                    StatusEffect_12_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_12_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_12_Time1  = Stream.Read.UInt();
                    StatusEffect_12_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_12_Unk2Flag == 0x01)
                    {
                        StatusEffect_12_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[19] == 0x00)
                {  
                    StatusEffect_13_Id     = Stream.Read.UInt();
                    StatusEffect_13_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_13_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_13_Time1  = Stream.Read.UInt();
                    StatusEffect_13_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_13_Unk2Flag == 0x01)
                    {
                        StatusEffect_13_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[20] == 0x00)
                { 
                    StatusEffect_14_Id     = Stream.Read.UInt();
                    StatusEffect_14_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_14_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_14_Time1  = Stream.Read.UInt();
                    StatusEffect_14_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_14_Unk2Flag == 0x01)
                    {
                        StatusEffect_14_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[21] == 0x00)
                { 
                    StatusEffect_15_Id     = Stream.Read.UInt();
                    StatusEffect_15_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_15_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_15_Time1  = Stream.Read.UInt();
                    StatusEffect_15_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_15_Unk2Flag == 0x01)
                    {
                        StatusEffect_15_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[22] == 0x00)
                {
                    StatusEffect_16_Id     = Stream.Read.UInt();
                    StatusEffect_16_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_16_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_16_Time1  = Stream.Read.UInt();
                    StatusEffect_16_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_16_Unk2Flag == 0x01)
                    {
                        StatusEffect_16_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[23] == 0x00)
                { 
                    StatusEffect_17_Id     = Stream.Read.UInt();
                    StatusEffect_17_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_17_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_17_Time1  = Stream.Read.UInt();
                    StatusEffect_17_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_17_Unk2Flag == 0x01)
                    {
                        StatusEffect_17_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[24] == 0x00)
                { 
                    StatusEffect_18_Id     = Stream.Read.UInt();
                    StatusEffect_18_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_18_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_18_Time1  = Stream.Read.UInt();
                    StatusEffect_18_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_18_Unk2Flag == 0x01)
                    {
                        StatusEffect_18_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[25] == 0x00)
                { 
                    StatusEffect_19_Id     = Stream.Read.UInt();
                    StatusEffect_19_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_19_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_19_Time1  = Stream.Read.UInt();
                    StatusEffect_19_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_19_Unk2Flag == 0x01)
                    {
                        StatusEffect_19_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[26] == 0x00)
                { 
                    StatusEffect_1a_Id     = Stream.Read.UInt();
                    StatusEffect_1a_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1a_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1a_Time1  = Stream.Read.UInt();
                    StatusEffect_1a_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1a_Unk2Flag == 0x01)
                    {
                        StatusEffect_1a_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[27] == 0x00)
                { 
                    StatusEffect_1b_Id     = Stream.Read.UInt();
                    StatusEffect_1b_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1b_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1b_Time1  = Stream.Read.UInt();
                    StatusEffect_1b_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1b_Unk2Flag == 0x01)
                    {
                        StatusEffect_1b_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[28] == 0x00)
                { 
                    StatusEffect_1c_Id     = Stream.Read.UInt();
                    StatusEffect_1c_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1c_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1c_Time1  = Stream.Read.UInt();
                    StatusEffect_1c_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1c_Unk2Flag == 0x01)
                    {
                        StatusEffect_1c_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[29] == 0x00)
                { 
                    StatusEffect_1d_Id     = Stream.Read.UInt();
                    StatusEffect_1d_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1d_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1d_Time1  = Stream.Read.UInt();
                    StatusEffect_1d_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1d_Unk2Flag == 0x01)
                    {
                        StatusEffect_1d_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[30] == 0x00)
                { 
                    StatusEffect_1e_Id     = Stream.Read.UInt();
                    StatusEffect_1e_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1e_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1e_Time1  = Stream.Read.UInt();
                    StatusEffect_1e_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1e_Unk2Flag == 0x01)
                    {
                        StatusEffect_1e_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[31] == 0x00)
                { 
                    StatusEffect_1f_Id     = Stream.Read.UInt();
                    StatusEffect_1f_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1f_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1f_Time1  = Stream.Read.UInt();
                    StatusEffect_1f_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1f_Unk2Flag == 0x01)
                    {
                        StatusEffect_1f_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                
                // The unks inbetween these are reasonable asumptions based on what is known
                SelectFireMode_FireMode = Stream.Read.Byte();
                SelectFireMode_Time = Stream.Read.UInt();
                UseScope_InScope = Stream.Read.Byte();
                UseScope_Time = Stream.Read.UInt();
                Ammo_Primary_Clip_1 = Stream.Read.UShort();
                Ammo_Secondary_Clip_1 = Stream.Read.UShort();
                Ammo_Primary_Clip_2 = Stream.Read.UShort();
                Ammo_Secondary_Clip_2 = Stream.Read.UShort();
                SelectWeapon_Index = Stream.Read.Byte();
                SelectWeapon_Unk = Stream.Read.ByteArray(2);
                SelectWeapon_Time = Stream.Read.UInt();
                Unk_0x47_Time = Stream.Read.UInt();
                Unk_0x48_Time = Stream.Read.UInt();
                FireBurst_Time = Stream.Read.UInt();
                FireEnd_Time = Stream.Read.UInt();
                FireCancel_Time = Stream.Read.UInt();
                ReloadWeapon_Time = Stream.Read.UInt();
                // The 0x4d is missing?
                Unk_0x4e_Time = Stream.Read.UInt();
            }
            
        }
    }
}