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
                    StatusEffect_0_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[1] == 0x00)
                {
                    StatusEffect_1_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[2] == 0x00)
                {
                    StatusEffect_2_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[3] == 0x00)
                {
                    StatusEffect_3_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[4] == 0x00)
                {
                    StatusEffect_4_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[5] == 0x00)
                {
                    StatusEffect_5_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[6] == 0x00)
                {
                    StatusEffect_6_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[7] == 0x00)
                {
                    StatusEffect_7_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[8] == 0x00)
                {
                    StatusEffect_8_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[9] == 0x00)
                {
                    StatusEffect_9_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[10] == 0x00)
                {
                    StatusEffect_a_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[11] == 0x00)
                {
                    StatusEffect_b_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[12] == 0x00)
                {
                    StatusEffect_c_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[13] == 0x00)
                {
                    StatusEffect_d_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[14] == 0x00)
                {
                    StatusEffect_e_ShortTime = Stream.Read.UShort();
                }
                if (Bitfield_StatusEffectData[15] == 0x00)
                {
                    StatusEffect_f_ShortTime = Stream.Read.UShort();
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

                // Status data
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

                Faction = Stream.Read.ByteArray(2);

                Unk_LastBytes = Stream.Read.ByteArray(53);
            }
        }
    }
}