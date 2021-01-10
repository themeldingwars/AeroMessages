using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 116, true)]
    public class CharacterCombatControllerAbilityActivated : BaseScript
    {
        public uint Activated_AbilityId;
        public uint Activated_Time;
        public uint NumberOfActiveCooldowns_1; // Don't know the logic

        public uint? ActiveCooldown1_1_AbilityId;
        public uint? ActiveCooldown1_1_Activated_Time;
        public uint? ActiveCooldown1_1_ReadyAgain_Time;
        public byte[] ActiveCooldown1_1_Unk;
        public uint? ActiveCooldown1_2_AbilityId;
        public uint? ActiveCooldown1_2_Activated_Time;
        public uint? ActiveCooldown1_2_ReadyAgain_Time;
        public byte[] ActiveCooldown1_2_Unk;
        public uint? ActiveCooldown1_3_AbilityId;
        public uint? ActiveCooldown1_3_Activated_Time;
        public uint? ActiveCooldown1_3_ReadyAgain_Time;
        public byte[] ActiveCooldown1_3_Unk;
        public uint? ActiveCooldown1_4_AbilityId;
        public uint? ActiveCooldown1_4_Activated_Time;
        public uint? ActiveCooldown1_4_ReadyAgain_Time;
        public byte[] ActiveCooldown1_4_Unk;
        public uint? ActiveCooldown1_5_AbilityId;
        public uint? ActiveCooldown1_5_Activated_Time;
        public uint? ActiveCooldown1_5_ReadyAgain_Time;
        public byte[] ActiveCooldown1_5_Unk;

        public uint NumberOfActiveCooldowns_2; // Don't know the logic
        public uint? ActiveCooldown2_1_AbilityId;
        public uint? ActiveCooldown2_1_Activated_Time;
        public uint? ActiveCooldown2_1_ReadyAgain_Time;
        public byte[] ActiveCooldown2_1_Unk;
        public uint? ActiveCooldown2_2_AbilityId;
        public uint? ActiveCooldown2_2_Activated_Time;
        public uint? ActiveCooldown2_2_ReadyAgain_Time;
        public byte[] ActiveCooldown2_2_Unk;
        public uint? ActiveCooldown2_3_AbilityId;
        public uint? ActiveCooldown2_3_Activated_Time;
        public uint? ActiveCooldown2_3_ReadyAgain_Time;
        public byte[] ActiveCooldown2_3_Unk;
        public uint? ActiveCooldown2_4_AbilityId;
        public uint? ActiveCooldown2_4_Activated_Time;
        public uint? ActiveCooldown2_4_ReadyAgain_Time;
        public byte[] ActiveCooldown2_4_Unk;
        public uint? ActiveCooldown2_5_AbilityId;
        public uint? ActiveCooldown2_5_Activated_Time;
        public uint? ActiveCooldown2_5_ReadyAgain_Time;
        public byte[] ActiveCooldown2_5_Unk;

        public uint Unk_GlobalCooldown_Activated_Time; // Pretty sure
        public uint Unk_GlobalCooldown_ReadyAgain_Time; // Pretty sure
        public byte Unk_3;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Activated_AbilityId = Stream.Read.UInt();
            Activated_Time = Stream.Read.UInt();

            NumberOfActiveCooldowns_1 = Stream.Read.UInt();

            if (NumberOfActiveCooldowns_1 > 0)
            {
                uint index1 = 1;
                do
                {
                    switch(index1)
                    {
                        case 1:
                            ActiveCooldown1_1_AbilityId = Stream.Read.UInt();
                            ActiveCooldown1_1_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown1_1_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown1_1_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 2:
                            ActiveCooldown1_2_AbilityId = Stream.Read.UInt();
                            ActiveCooldown1_2_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown1_2_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown1_2_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 3:
                            ActiveCooldown1_3_AbilityId = Stream.Read.UInt();
                            ActiveCooldown1_3_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown1_3_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown1_3_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 4:
                            ActiveCooldown1_4_AbilityId = Stream.Read.UInt();
                            ActiveCooldown1_4_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown1_4_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown1_4_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 5:
                            ActiveCooldown1_5_AbilityId = Stream.Read.UInt();
                            ActiveCooldown1_5_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown1_5_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown1_5_Unk = Stream.Read.ByteArray(5);
                            break;
                        default:
                            break;
                    }
                    index1++;
                }
                while (index1 <= NumberOfActiveCooldowns_1 && Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            }


            NumberOfActiveCooldowns_2 = Stream.Read.UInt();


            if (NumberOfActiveCooldowns_2 > 0)
            {
                uint index2 = 1;
                do
                {
                    switch(index2)
                    {
                        case 1:
                            ActiveCooldown2_1_AbilityId = Stream.Read.UInt();
                            ActiveCooldown2_1_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown2_1_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown2_1_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 2:
                            ActiveCooldown2_2_AbilityId = Stream.Read.UInt();
                            ActiveCooldown2_2_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown2_2_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown2_2_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 3:
                            ActiveCooldown2_3_AbilityId = Stream.Read.UInt();
                            ActiveCooldown2_3_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown2_3_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown2_3_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 4:
                            ActiveCooldown2_4_AbilityId = Stream.Read.UInt();
                            ActiveCooldown2_4_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown2_4_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown2_4_Unk = Stream.Read.ByteArray(5);
                            break;
                        case 5:
                            ActiveCooldown2_5_AbilityId = Stream.Read.UInt();
                            ActiveCooldown2_5_Activated_Time = Stream.Read.UInt();
                            ActiveCooldown2_5_ReadyAgain_Time = Stream.Read.UInt();
                            ActiveCooldown2_5_Unk = Stream.Read.ByteArray(5);
                            break;
                        default:
                            break;
                    }
                    index2++;
                }
                while (index2 <= NumberOfActiveCooldowns_2 && Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            }

            Unk_GlobalCooldown_Activated_Time = Stream.Read.UInt();
            Unk_GlobalCooldown_ReadyAgain_Time = Stream.Read.UInt();
            Unk_3 = Stream.Read.Byte();
        }
    }
}