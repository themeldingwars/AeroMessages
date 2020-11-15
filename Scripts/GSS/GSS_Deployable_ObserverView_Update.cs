using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 35, 1, true)]
    public class DeployableObserverViewUpdate : BaseScript
    {
        // Take anything that is Unk with a huge grain of salt.
        enum ShadowFieldIndex : byte
        {
            CurrentHealthPercent    = 0x08, // % integer
        

            StatusEffect_0b_ShortTime = 0x0b,
            StatusEffect_0c_ShortTime = 0x0c,
            StatusEffect_0d_ShortTime = 0x0d,
            StatusEffect_0e_ShortTime = 0x0e,
            StatusEffect_0f_ShortTime = 0x0f,

            StatusEffect_10_ShortTime = 0x10,
            StatusEffect_11_ShortTime = 0x11,
            StatusEffect_12_ShortTime = 0x12,
            StatusEffect_13_ShortTime = 0x13,
            StatusEffect_14_ShortTime = 0x14,

            StatusEffect_0b_Data = 0x2b,
            StatusEffect_0c_Data = 0x2c,
            StatusEffect_0d_Data = 0x2d,
            StatusEffect_0e_Data = 0x2e,
            StatusEffect_0f_Data = 0x2f,

            StatusEffect_10_Data = 0x30,
            StatusEffect_11_Data = 0x31,
            StatusEffect_12_Data = 0x32,
            StatusEffect_13_Data = 0x33,
            StatusEffect_14_Data = 0x34,
            

            StatusEffect_0b_Cancel = 0xab,
            StatusEffect_0c_Cancel = 0xac,
            StatusEffect_0d_Cancel = 0xad,
            StatusEffect_0e_Cancel = 0xae,
            StatusEffect_0f_Cancel = 0xaf,

            StatusEffect_10_Cancel = 0xb0,
            StatusEffect_11_Cancel = 0xb1,
            StatusEffect_12_Cancel = 0xb2,
            StatusEffect_13_Cancel = 0xb3,
            StatusEffect_14_Cancel = 0xb4,


            Faction = 0x4b,
            Unk_0x50 = 0x50,
            Unk_0x51 = 0x51,
        }


        public byte? CurrentHealthPercent;

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

        public byte[] Faction;
        public byte[] Unk_0x50;
        public byte[] Unk_0x51;

        public byte[] UnableToParse;



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    
                    case ShadowFieldIndex.CurrentHealthPercent:
                        CurrentHealthPercent = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.StatusEffect_0b_ShortTime:
                        StatusEffect_0b_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0c_ShortTime:
                        StatusEffect_0c_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0d_ShortTime:
                        StatusEffect_0d_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0e_ShortTime:
                        StatusEffect_0e_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0f_ShortTime:
                        StatusEffect_0f_ShortTime = Stream.Read.UShort();
                        break;
                    
                    case ShadowFieldIndex.StatusEffect_10_ShortTime:
                        StatusEffect_10_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_11_ShortTime:
                        StatusEffect_11_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_12_ShortTime:
                        StatusEffect_12_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_13_ShortTime:
                        StatusEffect_13_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_14_ShortTime:
                        StatusEffect_14_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_0b_Data:
                        StatusEffect_0b_Id     = Stream.Read.UInt();
                        StatusEffect_0b_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0b_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0b_Time1  = Stream.Read.UInt();
                        StatusEffect_0b_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0b_Unk2Flag == 0x01)
                        {
                            StatusEffect_0b_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0c_Data:
                        StatusEffect_0c_Id     = Stream.Read.UInt();
                        StatusEffect_0c_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0c_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0c_Time1  = Stream.Read.UInt();
                        StatusEffect_0c_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0c_Unk2Flag == 0x01)
                        {
                            StatusEffect_0c_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0d_Data:
                        StatusEffect_0d_Id     = Stream.Read.UInt();
                        StatusEffect_0d_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0d_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0d_Time1  = Stream.Read.UInt();
                        StatusEffect_0d_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0d_Unk2Flag == 0x01)
                        {
                            StatusEffect_0d_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0e_Data:
                        StatusEffect_0e_Id     = Stream.Read.UInt();
                        StatusEffect_0e_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0e_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0e_Time1  = Stream.Read.UInt();
                        StatusEffect_0e_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0e_Unk2Flag == 0x01)
                        {
                            StatusEffect_0e_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_0f_Data:
                        StatusEffect_0f_Id     = Stream.Read.UInt();
                        StatusEffect_0f_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_0f_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_0f_Time1  = Stream.Read.UInt();
                        StatusEffect_0f_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_0f_Unk2Flag == 0x01)
                        {
                            StatusEffect_0f_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_10_Data:
                        StatusEffect_10_Id     = Stream.Read.UInt();
                        StatusEffect_10_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_10_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_10_Time1  = Stream.Read.UInt();
                        StatusEffect_10_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_10_Unk2Flag == 0x01)
                        {
                            StatusEffect_10_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_11_Data:
                        StatusEffect_11_Id     = Stream.Read.UInt();
                        StatusEffect_11_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_11_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_11_Time1  = Stream.Read.UInt();
                        StatusEffect_11_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_11_Unk2Flag == 0x01)
                        {
                            StatusEffect_11_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_12_Data:
                        StatusEffect_12_Id     = Stream.Read.UInt();
                        StatusEffect_12_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_12_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_12_Time1  = Stream.Read.UInt();
                        StatusEffect_12_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_12_Unk2Flag == 0x01)
                        {
                            StatusEffect_12_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_13_Data:
                        StatusEffect_13_Id     = Stream.Read.UInt();
                        StatusEffect_13_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_13_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_13_Time1  = Stream.Read.UInt();
                        StatusEffect_13_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_13_Unk2Flag == 0x01)
                        {
                            StatusEffect_13_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_14_Data:
                        StatusEffect_14_Id     = Stream.Read.UInt();
                        StatusEffect_14_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_14_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_14_Time1  = Stream.Read.UInt();
                        StatusEffect_14_Unk2Flag = Stream.Read.Byte();
                        if (StatusEffect_14_Unk2Flag == 0x01)
                        {
                            StatusEffect_14_Unk2   = Stream.Read.ByteArray(38);
                        }
                        break;


                    case ShadowFieldIndex.StatusEffect_0b_Cancel:
                        StatusEffect_0b_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0c_Cancel:
                        StatusEffect_0c_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0d_Cancel:
                        StatusEffect_0d_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0e_Cancel:
                        StatusEffect_0e_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_0f_Cancel:
                        StatusEffect_0f_Cancel = true;
                        break;

                    case ShadowFieldIndex.StatusEffect_10_Cancel:
                        StatusEffect_10_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_11_Cancel:
                        StatusEffect_11_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_12_Cancel:
                        StatusEffect_12_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_13_Cancel:
                        StatusEffect_13_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffect_14_Cancel:
                        StatusEffect_14_Cancel = true;
                        break;

                    case ShadowFieldIndex.Faction:
                        Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x50:
                        Unk_0x50 = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_0x51:
                        Unk_0x51 = Stream.Read.ByteArray(2);
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