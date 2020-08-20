using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 89, true)]
    public class CharacterBaseControllerProgressionXPRefresh : BaseScript
    {
        public byte NumberOfEntries;

        public uint?   Frame0_ChassisID;
        public uint?   Frame0_XP_Value_1;
        public uint?   Frame0_XP_Value_2;
        public byte?   Frame0_CurrentLevel;
        public byte[] Frame0_Unk;


        public uint?   Frame1_ChassisID;
        public uint?   Frame1_XP_Value_1;
        public uint?   Frame1_XP_Value_2;
        public byte?   Frame1_CurrentLevel;
        public byte[] Frame1_Unk;

        public uint?   Frame2_ChassisID;
        public uint?   Frame2_XP_Value_1;
        public uint?   Frame2_XP_Value_2;
        public byte?   Frame2_CurrentLevel;
        public byte[] Frame2_Unk;

        public uint?   Frame3_ChassisID;
        public uint?   Frame3_XP_Value_1;
        public uint?   Frame3_XP_Value_2;
        public byte?   Frame3_CurrentLevel;
        public byte[] Frame3_Unk;

        public uint?   Frame4_ChassisID;
        public uint?   Frame4_XP_Value_1;
        public uint?   Frame4_XP_Value_2;
        public byte?   Frame4_CurrentLevel;
        public byte[] Frame4_Unk;

        public uint?   Frame5_ChassisID;
        public uint?   Frame5_XP_Value_1;
        public uint?   Frame5_XP_Value_2;
        public byte?   Frame5_CurrentLevel;
        public byte[] Frame5_Unk;

        public uint?   Frame6_ChassisID;
        public uint?   Frame6_XP_Value_1;
        public uint?   Frame6_XP_Value_2;
        public byte?   Frame6_CurrentLevel;
        public byte[] Frame6_Unk;

        public uint?   Frame7_ChassisID;
        public uint?   Frame7_XP_Value_1;
        public uint?   Frame7_XP_Value_2;
        public byte?   Frame7_CurrentLevel;
        public byte[] Frame7_Unk;

        public uint?   Frame8_ChassisID;
        public uint?   Frame8_XP_Value_1;
        public uint?   Frame8_XP_Value_2;
        public byte?   Frame8_CurrentLevel;
        public byte[] Frame8_Unk;

        public uint?   Frame9_ChassisID;
        public uint?   Frame9_XP_Value_1;
        public uint?   Frame9_XP_Value_2;
        public byte?   Frame9_CurrentLevel;
        public byte[] Frame9_Unk;

        public uint?   Frame10_ChassisID;
        public uint?   Frame10_XP_Value_1;
        public uint?   Frame10_XP_Value_2;
        public byte?   Frame10_CurrentLevel;
        public byte[] Frame10_Unk;

        public uint?   Frame11_ChassisID;
        public uint?   Frame11_XP_Value_1;
        public uint?   Frame11_XP_Value_2;
        public byte?   Frame11_CurrentLevel;
        public byte[] Frame11_Unk;

        public uint?   Frame12_ChassisID;
        public uint?   Frame12_XP_Value_1;
        public uint?   Frame12_XP_Value_2;
        public byte?   Frame12_CurrentLevel;
        public byte[] Frame12_Unk;

        public uint?   Frame13_ChassisID;
        public uint?   Frame13_XP_Value_1;
        public uint?   Frame13_XP_Value_2;
        public byte?   Frame13_CurrentLevel;
        public byte[] Frame13_Unk;

        public uint?   Frame14_ChassisID;
        public uint?   Frame14_XP_Value_1;
        public uint?   Frame14_XP_Value_2;
        public byte?   Frame14_CurrentLevel;
        public byte[] Frame14_Unk;

        public uint?   Frame15_ChassisID;
        public uint?   Frame15_XP_Value_1;
        public uint?   Frame15_XP_Value_2;
        public byte?   Frame15_CurrentLevel;
        public byte[] Frame15_Unk;

        public uint?   Frame16_ChassisID;
        public uint?   Frame16_XP_Value_1;
        public uint?   Frame16_XP_Value_2;
        public byte?   Frame16_CurrentLevel;
        public byte[] Frame16_Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            NumberOfEntries = Stream.Read.Byte();
            for (int i = 0; i < NumberOfEntries; i++)
            {
                switch (i)
                {
                    case 0:
                        Frame0_ChassisID = Stream.Read.UInt();
                        Frame0_XP_Value_1 = Stream.Read.UInt();
                        Frame0_XP_Value_2 = Stream.Read.UInt();
                        Frame0_CurrentLevel = Stream.Read.Byte();
                        Frame0_Unk = Stream.Read.ByteArray(7);
                        break;

                    case 1:
                        Frame1_ChassisID = Stream.Read.UInt();
                        Frame1_XP_Value_1 = Stream.Read.UInt();
                        Frame1_XP_Value_2 = Stream.Read.UInt();
                        Frame1_CurrentLevel = Stream.Read.Byte();
                        Frame1_Unk = Stream.Read.ByteArray(7);
                        break;

                    case 2:
                        Frame2_ChassisID = Stream.Read.UInt();
                        Frame2_XP_Value_1 = Stream.Read.UInt();
                        Frame2_XP_Value_2 = Stream.Read.UInt();
                        Frame2_CurrentLevel = Stream.Read.Byte();
                        Frame2_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 3:
                        Frame3_ChassisID = Stream.Read.UInt();
                        Frame3_XP_Value_1 = Stream.Read.UInt();
                        Frame3_XP_Value_2 = Stream.Read.UInt();
                        Frame3_CurrentLevel = Stream.Read.Byte();
                        Frame3_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 4:
                        Frame4_ChassisID = Stream.Read.UInt();
                        Frame4_XP_Value_1 = Stream.Read.UInt();
                        Frame4_XP_Value_2 = Stream.Read.UInt();
                        Frame4_CurrentLevel = Stream.Read.Byte();
                        Frame4_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 5:
                        Frame5_ChassisID = Stream.Read.UInt();
                        Frame5_XP_Value_1 = Stream.Read.UInt();
                        Frame5_XP_Value_2 = Stream.Read.UInt();
                        Frame5_CurrentLevel = Stream.Read.Byte();
                        Frame5_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 6:
                        Frame6_ChassisID = Stream.Read.UInt();
                        Frame6_XP_Value_1 = Stream.Read.UInt();
                        Frame6_XP_Value_2 = Stream.Read.UInt();
                        Frame6_CurrentLevel = Stream.Read.Byte();
                        Frame6_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 7:
                        Frame7_ChassisID = Stream.Read.UInt();
                        Frame7_XP_Value_1 = Stream.Read.UInt();
                        Frame7_XP_Value_2 = Stream.Read.UInt();
                        Frame7_CurrentLevel = Stream.Read.Byte();
                        Frame7_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 8:
                        Frame8_ChassisID = Stream.Read.UInt();
                        Frame8_XP_Value_1 = Stream.Read.UInt();
                        Frame8_XP_Value_2 = Stream.Read.UInt();
                        Frame8_CurrentLevel = Stream.Read.Byte();
                        Frame8_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 9:
                        Frame9_ChassisID = Stream.Read.UInt();
                        Frame9_XP_Value_1 = Stream.Read.UInt();
                        Frame9_XP_Value_2 = Stream.Read.UInt();
                        Frame9_CurrentLevel = Stream.Read.Byte();
                        Frame9_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 10:
                        Frame10_ChassisID = Stream.Read.UInt();
                        Frame10_XP_Value_1 = Stream.Read.UInt();
                        Frame10_XP_Value_2 = Stream.Read.UInt();
                        Frame10_CurrentLevel = Stream.Read.Byte();
                        Frame10_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 11:
                        Frame11_ChassisID = Stream.Read.UInt();
                        Frame11_XP_Value_1 = Stream.Read.UInt();
                        Frame11_XP_Value_2 = Stream.Read.UInt();
                        Frame11_CurrentLevel = Stream.Read.Byte();
                        Frame11_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 12:
                        Frame12_ChassisID = Stream.Read.UInt();
                        Frame12_XP_Value_1 = Stream.Read.UInt();
                        Frame12_XP_Value_2 = Stream.Read.UInt();
                        Frame12_CurrentLevel = Stream.Read.Byte();
                        Frame12_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 13:
                        Frame13_ChassisID = Stream.Read.UInt();
                        Frame13_XP_Value_1 = Stream.Read.UInt();
                        Frame13_XP_Value_2 = Stream.Read.UInt();
                        Frame13_CurrentLevel = Stream.Read.Byte();
                        Frame13_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 14:
                        Frame14_ChassisID = Stream.Read.UInt();
                        Frame14_XP_Value_1 = Stream.Read.UInt();
                        Frame14_XP_Value_2 = Stream.Read.UInt();
                        Frame14_CurrentLevel = Stream.Read.Byte();
                        Frame14_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 15:
                        Frame15_ChassisID = Stream.Read.UInt();
                        Frame15_XP_Value_1 = Stream.Read.UInt();
                        Frame15_XP_Value_2 = Stream.Read.UInt();
                        Frame15_CurrentLevel = Stream.Read.Byte();
                        Frame15_Unk = Stream.Read.ByteArray(7);
                        break;
                    case 16:
                        Frame16_ChassisID = Stream.Read.UInt();
                        Frame16_XP_Value_1 = Stream.Read.UInt();
                        Frame16_XP_Value_2 = Stream.Read.UInt();
                        Frame16_CurrentLevel = Stream.Read.Byte();
                        Frame16_Unk = Stream.Read.ByteArray(7);
                        break;
                }
            }
        }
    }
}