using Bitter;
namespace PacketPeepScript
{
    // Assuming it has the same number of status effect fields as Character.
    // Only seen status effects here so far.
    [Script(MessageType.GSS, 30, 1, true)]
    public class VehicleCombatControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            StatusEffect_0_ShortTime = 0x00,
            StatusEffect_1_ShortTime = 0x01,
            StatusEffect_2_ShortTime = 0x02,
            StatusEffect_3_ShortTime = 0x03,
            StatusEffect_4_ShortTime = 0x04,
            StatusEffect_5_ShortTime = 0x05,
            StatusEffect_6_ShortTime = 0x06,
            StatusEffect_7_ShortTime = 0x07,
            StatusEffect_8_ShortTime = 0x08,
            StatusEffect_9_ShortTime = 0x09,
            StatusEffect_a_ShortTime = 0x0a,
            StatusEffect_b_ShortTime = 0x0b,
            StatusEffect_c_ShortTime = 0x0c,
            StatusEffect_d_ShortTime = 0x0d,
            StatusEffect_e_ShortTime = 0x0e,
            StatusEffect_f_ShortTime = 0x0f,

            StatusEffect_0_Data = 0x20,
            StatusEffect_1_Data = 0x21,
            StatusEffect_2_Data = 0x22,
            StatusEffect_3_Data = 0x23,
            StatusEffect_4_Data = 0x24,
            StatusEffect_5_Data = 0x25,
            StatusEffect_6_Data = 0x26,
            StatusEffect_7_Data = 0x27,
            StatusEffect_8_Data = 0x28,
            StatusEffect_9_Data = 0x29,
            StatusEffect_a_Data = 0x2a,
            StatusEffect_b_Data = 0x2b,
            StatusEffect_c_Data = 0x2c,
            StatusEffect_d_Data = 0x2d,
            StatusEffect_e_Data = 0x2e,
            StatusEffect_f_Data = 0x2f,
            
            StatusEffect_0_Cancel = 0xa0,
            StatusEffect_1_Cancel = 0xa1,
            StatusEffect_2_Cancel = 0xa2,
            StatusEffect_3_Cancel = 0xa3,
            StatusEffect_4_Cancel = 0xa4,
            StatusEffect_5_Cancel = 0xa5,
            StatusEffect_6_Cancel = 0xa6,
            StatusEffect_7_Cancel = 0xa7,
            StatusEffect_8_Cancel = 0xa8,
            StatusEffect_9_Cancel = 0xa9,
            StatusEffect_a_Cancel = 0xaa,
            StatusEffect_b_Cancel = 0xab,
            StatusEffect_c_Cancel = 0xac,
            StatusEffect_d_Cancel = 0xad,
            StatusEffect_e_Cancel = 0xae,
            StatusEffect_f_Cancel = 0xaf,
        }

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

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.StatusEffect_0_ShortTime:
                        StatusEffect_0_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_1_ShortTime:
                        StatusEffect_1_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_2_ShortTime:
                        StatusEffect_2_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_3_ShortTime:
                        StatusEffect_3_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_4_ShortTime:
                        StatusEffect_4_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_5_ShortTime:
                        StatusEffect_5_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_6_ShortTime:
                        StatusEffect_6_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_7_ShortTime:
                        StatusEffect_7_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_8_ShortTime:
                        StatusEffect_8_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_9_ShortTime:
                        StatusEffect_9_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_a_ShortTime:
                        StatusEffect_a_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_b_ShortTime:
                        StatusEffect_b_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_c_ShortTime:
                        StatusEffect_c_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_d_ShortTime:
                        StatusEffect_d_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_e_ShortTime:
                        StatusEffect_e_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_f_ShortTime:
                        StatusEffect_f_ShortTime = Stream.Read.UShort();
                        break;


                    case ShadowFieldIndex.StatusEffect_0_Data:
                        StatusEffect_0_Id     = Stream.Read.UInt();
                        StatusEffect_0_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0_Time1  = Stream.Read.UInt();
                        StatusEffect_0_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0_Unk2Flag == 0x01)
                        {
                            StatusEffect_0_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_1_Data:
                        StatusEffect_1_Id     = Stream.Read.UInt();
                        StatusEffect_1_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_1_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_1_Time1  = Stream.Read.UInt();
                        StatusEffect_1_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_1_Unk2Flag == 0x01)
                        {
                            StatusEffect_1_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_2_Data:
                        StatusEffect_2_Id     = Stream.Read.UInt();
                        StatusEffect_2_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_2_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_2_Time1  = Stream.Read.UInt();
                        StatusEffect_2_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_2_Unk2Flag == 0x01)
                        {
                            StatusEffect_2_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_3_Data:
                        StatusEffect_3_Id     = Stream.Read.UInt();
                        StatusEffect_3_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_3_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_3_Time1  = Stream.Read.UInt();
                        StatusEffect_3_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_3_Unk2Flag == 0x01)
                        {
                            StatusEffect_3_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_4_Data:
                        StatusEffect_4_Id     = Stream.Read.UInt();
                        StatusEffect_4_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_4_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_4_Time1  = Stream.Read.UInt();
                        StatusEffect_4_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_4_Unk2Flag == 0x01)
                        {
                            StatusEffect_4_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_5_Data:
                        StatusEffect_5_Id     = Stream.Read.UInt();
                        StatusEffect_5_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_5_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_5_Time1  = Stream.Read.UInt();
                        StatusEffect_5_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_5_Unk2Flag == 0x01)
                        {
                            StatusEffect_5_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_6_Data:
                        StatusEffect_6_Id     = Stream.Read.UInt();
                        StatusEffect_6_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_6_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_6_Time1  = Stream.Read.UInt();
                        StatusEffect_6_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_6_Unk2Flag == 0x01)
                        {
                            StatusEffect_6_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_7_Data:
                        StatusEffect_7_Id     = Stream.Read.UInt();
                        StatusEffect_7_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_7_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_7_Time1  = Stream.Read.UInt();
                        StatusEffect_7_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_7_Unk2Flag == 0x01)
                        {
                            StatusEffect_7_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_8_Data:
                        StatusEffect_8_Id     = Stream.Read.UInt();
                        StatusEffect_8_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_8_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_8_Time1  = Stream.Read.UInt();
                        StatusEffect_8_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_8_Unk2Flag == 0x01)
                        {
                            StatusEffect_8_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_9_Data:
                        StatusEffect_9_Id     = Stream.Read.UInt();
                        StatusEffect_9_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_9_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_9_Time1  = Stream.Read.UInt();
                        StatusEffect_9_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_9_Unk2Flag == 0x01)
                        {
                            StatusEffect_9_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_a_Data:
                        StatusEffect_a_Id     = Stream.Read.UInt();
                        StatusEffect_a_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_a_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_a_Time1  = Stream.Read.UInt();
                        StatusEffect_a_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_a_Unk2Flag == 0x01)
                        {
                            StatusEffect_a_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_b_Data:
                        StatusEffect_b_Id     = Stream.Read.UInt();
                        StatusEffect_b_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_b_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_b_Time1  = Stream.Read.UInt();
                        StatusEffect_b_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_b_Unk2Flag == 0x01)
                        {
                            StatusEffect_b_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_c_Data:
                        StatusEffect_c_Id     = Stream.Read.UInt();
                        StatusEffect_c_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_c_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_c_Time1  = Stream.Read.UInt();
                        StatusEffect_c_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_c_Unk2Flag == 0x01)
                        {
                            StatusEffect_c_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_d_Data:
                        StatusEffect_d_Id     = Stream.Read.UInt();
                        StatusEffect_d_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_d_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_d_Time1  = Stream.Read.UInt();
                        StatusEffect_d_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_d_Unk2Flag == 0x01)
                        {
                            StatusEffect_d_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_e_Data:
                        StatusEffect_e_Id     = Stream.Read.UInt();
                        StatusEffect_e_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_e_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_e_Time1  = Stream.Read.UInt();
                        StatusEffect_e_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_e_Unk2Flag == 0x01)
                        {
                            StatusEffect_e_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_f_Data:
                        StatusEffect_f_Id     = Stream.Read.UInt();
                        StatusEffect_f_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_f_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_f_Time1  = Stream.Read.UInt();
                        StatusEffect_f_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_f_Unk2Flag == 0x01)
                        {
                            StatusEffect_f_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    // These keys do not come with any data
                    case ShadowFieldIndex.StatusEffect_0_Cancel:
                        StatusEffect_0_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_1_Cancel:
                        StatusEffect_1_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_2_Cancel:
                        StatusEffect_2_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_3_Cancel:
                        StatusEffect_3_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_4_Cancel:
                        StatusEffect_4_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_5_Cancel:
                        StatusEffect_5_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_6_Cancel:
                        StatusEffect_6_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_7_Cancel:
                        StatusEffect_7_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_8_Cancel:
                        StatusEffect_8_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_9_Cancel:
                        StatusEffect_9_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_a_Cancel:
                        StatusEffect_a_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_b_Cancel:
                        StatusEffect_b_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_c_Cancel:
                        StatusEffect_c_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_d_Cancel:
                        StatusEffect_d_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_e_Cancel:
                        StatusEffect_e_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_f_Cancel:
                        StatusEffect_f_Cancel = true;
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}