using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 3, true)]
    public class CharacterCombatViewKeyframe : BaseScript
    {
        // Bit half finished this

        // The lenght variable, seems like it's the data in the status effects doing it.
        // It's not only that there's a flag in them, but sometimes the data on them is completely omitted. First byte might be a clue.
        // Keyframes ranging between 200-500+ bytes.

        public byte[] Bitfield_StatusEffectData;
        public byte[] Unk_ContentBytes; // Probably



        public ushort? StatusEffect_0_ShortTime;
        public uint? StatusEffect_0_Id;
        public byte[] StatusEffect_0_Unk1;
        public byte[] StatusEffect_0_Entity;
        public uint? StatusEffect_0_Time1;
        public byte? StatusEffect_0_Unk2Flag;
        public byte[] StatusEffect_0_Unk2;
        public bool? StatusEffect_0_Cancel;

        public ushort? StatusEffect_1_ShortTime;
        public uint? StatusEffect_1_Id;
        public byte[] StatusEffect_1_Unk1;
        public byte[] StatusEffect_1_Entity;
        public uint? StatusEffect_1_Time1;
        public byte? StatusEffect_1_Unk2Flag;
        public byte[] StatusEffect_1_Unk2;
        public bool? StatusEffect_1_Cancel;

        public ushort? StatusEffect_2_ShortTime;
        public uint? StatusEffect_2_Id;
        public byte[] StatusEffect_2_Unk1;
        public byte[] StatusEffect_2_Entity;
        public uint? StatusEffect_2_Time1;
        public byte? StatusEffect_2_Unk2Flag;
        public byte[] StatusEffect_2_Unk2;
        public bool? StatusEffect_2_Cancel;

        public ushort? StatusEffect_3_ShortTime;
        public uint? StatusEffect_3_Id;
        public byte[] StatusEffect_3_Unk1;
        public byte[] StatusEffect_3_Entity;
        public uint? StatusEffect_3_Time1;
        public byte? StatusEffect_3_Unk2Flag;
        public byte[] StatusEffect_3_Unk2;
        public bool? StatusEffect_3_Cancel;

        public ushort? StatusEffect_4_ShortTime;
        public uint? StatusEffect_4_Id;
        public byte[] StatusEffect_4_Unk1;
        public byte[] StatusEffect_4_Entity;
        public uint? StatusEffect_4_Time1;
        public byte? StatusEffect_4_Unk2Flag;
        public byte[] StatusEffect_4_Unk2;
        public bool? StatusEffect_4_Cancel;

        public ushort? StatusEffect_5_ShortTime;
        public uint? StatusEffect_5_Id;
        public byte[] StatusEffect_5_Unk1;
        public byte[] StatusEffect_5_Entity;
        public uint? StatusEffect_5_Time1;
        public byte? StatusEffect_5_Unk2Flag;
        public byte[] StatusEffect_5_Unk2;
        public bool? StatusEffect_5_Cancel;

        public ushort? StatusEffect_6_ShortTime;
        public uint? StatusEffect_6_Id;
        public byte[] StatusEffect_6_Unk1;
        public byte[] StatusEffect_6_Entity;
        public uint? StatusEffect_6_Time1;
        public byte? StatusEffect_6_Unk2Flag;
        public byte[] StatusEffect_6_Unk2;
        public bool? StatusEffect_6_Cancel;

        public ushort? StatusEffect_7_ShortTime;
        public uint? StatusEffect_7_Id;
        public byte[] StatusEffect_7_Unk1;
        public byte[] StatusEffect_7_Entity;
        public uint? StatusEffect_7_Time1;
        public byte? StatusEffect_7_Unk2Flag;
        public byte[] StatusEffect_7_Unk2;
        public bool? StatusEffect_7_Cancel;

        public ushort? StatusEffect_8_ShortTime;
        public uint? StatusEffect_8_Id; 
        public byte[] StatusEffect_8_Unk1;
        public byte[] StatusEffect_8_Entity;
        public uint? StatusEffect_8_Time1;
        public byte? StatusEffect_8_Unk2Flag;
        public byte[] StatusEffect_8_Unk2;
        public bool? StatusEffect_8_Cancel;

        public ushort? StatusEffect_9_ShortTime;
        public uint? StatusEffect_9_Id;
        public byte[] StatusEffect_9_Unk1;
        public byte[] StatusEffect_9_Entity;
        public uint? StatusEffect_9_Time1;
        public byte? StatusEffect_9_Unk2Flag;
        public byte[] StatusEffect_9_Unk2;
        public bool? StatusEffect_9_Cancel;

        public ushort? StatusEffect_a_ShortTime;
        public uint? StatusEffect_a_Id;
        public byte[] StatusEffect_a_Unk1;
        public byte[] StatusEffect_a_Entity;
        public uint? StatusEffect_a_Time1;
        public byte? StatusEffect_a_Unk2Flag;
        public byte[] StatusEffect_a_Unk2;
        public bool? StatusEffect_a_Cancel;

        public ushort? StatusEffect_b_ShortTime;
        public uint? StatusEffect_b_Id;
        public byte[] StatusEffect_b_Unk1;
        public byte[] StatusEffect_b_Entity;
        public uint? StatusEffect_b_Time1;
        public byte? StatusEffect_b_Unk2Flag;
        public byte[] StatusEffect_b_Unk2;
        public bool? StatusEffect_b_Cancel;

        public ushort? StatusEffect_c_ShortTime;
        public uint? StatusEffect_c_Id;
        public byte[] StatusEffect_c_Unk1;
        public byte[] StatusEffect_c_Entity;
        public uint? StatusEffect_c_Time1;
        public byte? StatusEffect_c_Unk2Flag;
        public byte[] StatusEffect_c_Unk2;
        public bool? StatusEffect_c_Cancel;

        public ushort? StatusEffect_d_ShortTime;
        public uint? StatusEffect_d_Id;
        public byte[] StatusEffect_d_Unk1;
        public byte[] StatusEffect_d_Entity;
        public uint? StatusEffect_d_Time1;
        public byte? StatusEffect_d_Unk2Flag;
        public byte[] StatusEffect_d_Unk2;
        public bool? StatusEffect_d_Cancel;

        public ushort? StatusEffect_e_ShortTime;
        public uint? StatusEffect_e_Id;
        public byte[] StatusEffect_e_Unk1;
        public byte[] StatusEffect_e_Entity;
        public uint? StatusEffect_e_Time1;
        public byte? StatusEffect_e_Unk2Flag;
        public byte[] StatusEffect_e_Unk2;
        public bool? StatusEffect_e_Cancel;

        public ushort? StatusEffect_f_ShortTime;
        public uint? StatusEffect_f_Id;
        public byte[] StatusEffect_f_Unk1;
        public byte[] StatusEffect_f_Entity;
        public uint? StatusEffect_f_Time1;
        public byte? StatusEffect_f_Unk2Flag;
        public byte[] StatusEffect_f_Unk2;
        public bool? StatusEffect_f_Cancel;


        public byte[] Unk_NotSure;


        public byte? SelectFireMode_FireMode;
        public uint? SelectFireMode_Time;
        public byte? UseScope_InScope;
        public uint? UseScope_Time;
        public byte[] Unk_0x42;
        public byte[] Unk_0x43;
        public byte[] Unk_0x44;
        public byte[] Unk_0x45;
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
                Bitfield_StatusEffectData = Stream.Read.BitArray(16); 
                Unk_ContentBytes = Stream.Read.ByteArray(4);

                // Note: In the Deployable Observer we only have as many times as we have data.
                StatusEffect_0_ShortTime = Stream.Read.UShort();
                StatusEffect_1_ShortTime = Stream.Read.UShort();
                StatusEffect_2_ShortTime = Stream.Read.UShort();
                StatusEffect_3_ShortTime = Stream.Read.UShort();
                StatusEffect_4_ShortTime = Stream.Read.UShort();
                StatusEffect_5_ShortTime = Stream.Read.UShort();
                StatusEffect_6_ShortTime = Stream.Read.UShort();
                StatusEffect_7_ShortTime = Stream.Read.UShort();
                StatusEffect_8_ShortTime = Stream.Read.UShort();
                StatusEffect_9_ShortTime = Stream.Read.UShort();
                StatusEffect_a_ShortTime = Stream.Read.UShort();
                StatusEffect_b_ShortTime = Stream.Read.UShort();
                StatusEffect_c_ShortTime = Stream.Read.UShort();
                StatusEffect_d_ShortTime = Stream.Read.UShort();
                StatusEffect_e_ShortTime = Stream.Read.UShort();
                StatusEffect_f_ShortTime = Stream.Read.UShort();

                Unk_NotSure = Stream.Read.ByteArray(32);


                // Status Effect Data
                if (Bitfield_StatusEffectData[0] == 0x00)
                {
                    StatusEffect_0_Id     = Stream.Read.UInt();
                    StatusEffect_0_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_0_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_0_Time1  = Stream.Read.UInt();
                    StatusEffect_0_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_0_Unk2Flag == 0x01)
                    {
                        StatusEffect_0_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[1] == 0x00)
                {
                    StatusEffect_1_Id     = Stream.Read.UInt();
                    StatusEffect_1_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_1_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_1_Time1  = Stream.Read.UInt();
                    StatusEffect_1_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_1_Unk2Flag == 0x01)
                    {
                        StatusEffect_1_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[2] == 0x00)
                {
                    StatusEffect_2_Id     = Stream.Read.UInt();
                    StatusEffect_2_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_2_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_2_Time1  = Stream.Read.UInt();
                    StatusEffect_2_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_2_Unk2Flag == 0x01)
                    {
                        StatusEffect_2_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[3] == 0x00)
                {  
                    StatusEffect_3_Id     = Stream.Read.UInt();
                    StatusEffect_3_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_3_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_3_Time1  = Stream.Read.UInt();
                    StatusEffect_3_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_3_Unk2Flag == 0x01)
                    {
                        StatusEffect_3_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[4] == 0x00)
                { 
                    StatusEffect_4_Id     = Stream.Read.UInt();
                    StatusEffect_4_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_4_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_4_Time1  = Stream.Read.UInt();
                    StatusEffect_4_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_4_Unk2Flag == 0x01)
                    {
                        StatusEffect_4_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[5] == 0x00)
                { 
                    StatusEffect_5_Id     = Stream.Read.UInt();
                    StatusEffect_5_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_5_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_5_Time1  = Stream.Read.UInt();
                    StatusEffect_5_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_5_Unk2Flag == 0x01)
                    {
                        StatusEffect_5_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[6] == 0x00)
                {
                    StatusEffect_6_Id     = Stream.Read.UInt();
                    StatusEffect_6_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_6_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_6_Time1  = Stream.Read.UInt();
                    StatusEffect_6_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_6_Unk2Flag == 0x01)
                    {
                        StatusEffect_6_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[7] == 0x00)
                { 
                    StatusEffect_7_Id     = Stream.Read.UInt();
                    StatusEffect_7_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_7_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_7_Time1  = Stream.Read.UInt();
                    StatusEffect_7_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_7_Unk2Flag == 0x01)
                    {
                        StatusEffect_7_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[8] == 0x00)
                { 
                    StatusEffect_8_Id     = Stream.Read.UInt();
                    StatusEffect_8_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_8_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_8_Time1  = Stream.Read.UInt();
                    StatusEffect_8_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_8_Unk2Flag == 0x01)
                    {
                        StatusEffect_8_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[9] == 0x00)
                { 
                    StatusEffect_9_Id     = Stream.Read.UInt();
                    StatusEffect_9_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_9_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_9_Time1  = Stream.Read.UInt();
                    StatusEffect_9_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_9_Unk2Flag == 0x01)
                    {
                        StatusEffect_9_Unk2   = Stream.Read.ByteArray(38);
                    }
                }
                
                if (Bitfield_StatusEffectData[10] == 0x00)
                { 
                    StatusEffect_a_Id     = Stream.Read.UInt();
                    StatusEffect_a_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_a_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_a_Time1  = Stream.Read.UInt();
                    StatusEffect_a_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_a_Unk2Flag == 0x01)
                    {
                        StatusEffect_a_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[11] == 0x00)
                { 
                    StatusEffect_b_Id     = Stream.Read.UInt();
                    StatusEffect_b_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_b_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_b_Time1  = Stream.Read.UInt();
                    StatusEffect_b_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_b_Unk2Flag == 0x01)
                    {
                        StatusEffect_b_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[12] == 0x00)
                { 
                    StatusEffect_c_Id     = Stream.Read.UInt();
                    StatusEffect_c_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_c_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_c_Time1  = Stream.Read.UInt();
                    StatusEffect_c_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_c_Unk2Flag == 0x01)
                    {
                        StatusEffect_c_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[13] == 0x00)
                { 
                    StatusEffect_d_Id     = Stream.Read.UInt();
                    StatusEffect_d_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_d_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_d_Time1  = Stream.Read.UInt();
                    StatusEffect_d_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_d_Unk2Flag == 0x01)
                    {
                        StatusEffect_d_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[14] == 0x00)
                { 
                    StatusEffect_e_Id     = Stream.Read.UInt();
                    StatusEffect_e_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_e_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_e_Time1  = Stream.Read.UInt();
                    StatusEffect_e_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_e_Unk2Flag == 0x01)
                    {
                        StatusEffect_e_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                if (Bitfield_StatusEffectData[15] == 0x00)
                { 
                    StatusEffect_f_Id     = Stream.Read.UInt();
                    StatusEffect_f_Unk1   = Stream.Read.ByteArray(1);
                    StatusEffect_f_Entity = Stream.Read.ByteArray(8);
                    StatusEffect_f_Time1  = Stream.Read.UInt();
                    StatusEffect_f_Unk2Flag = Stream.Read.Byte();
                    if (StatusEffect_f_Unk2Flag == 0x01)
                    {
                        StatusEffect_f_Unk2   = Stream.Read.ByteArray(38);
                    }
                }

                
                // The unks inbetween these are reasonable asumptions based on what is known
                SelectFireMode_FireMode = Stream.Read.Byte();
                SelectFireMode_Time = Stream.Read.UInt();
                UseScope_InScope = Stream.Read.Byte();
                UseScope_Time = Stream.Read.UInt();
                Unk_0x42 = Stream.Read.ByteArray(2);
                Unk_0x43 = Stream.Read.ByteArray(2);
                Unk_0x44 = Stream.Read.ByteArray(2);
                Unk_0x45 = Stream.Read.ByteArray(2);
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


                // Float
                // Time
                // Time
                // Time
                // Time
                // Time
                // 4 bytes
                // Time
            }
            
        }
    }
}