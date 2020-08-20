using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 184, true)]
    public class CharacterBaseControllerPostStatEvent : BaseScript
    {
        
        public uint StatEventId; // Sdb table 11, id column.
        public uint ParamCount;

        //public string Key;
        public string? Key1;
        public string? Key2;
        public string? Key3;
        public string? Key4;
        public string? Key5;

        public byte[] Data_AbilityId_Unk1;
        public uint Data_AbilityId_Id;
        public byte[] Data_Distance;
        public byte[] Data_FrameTypeId;
        public byte[] Data_PlayerGUID_Unk1;
        public byte[] Data_PlayerGUID_Entity; // The actual guid
        public byte[] Data_TargetGUID_Unk1;
        public byte[] Data_TargetGUID_Entity; // The actual guid
        public byte[] Data_Value;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            StatEventId = Stream.Read.UInt();
            ParamCount = Stream.Read.UInt();

            int index = 1;
            do
            {
                // Dealing with packet peep
                string Key;
                switch(index)
                {
                    case 1:
                        Key1 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                        Key = Key1;
                        break;
                    case 2:
                        Key2 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                        Key = Key2;
                        break;
                    case 3:
                        Key3 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                        Key = Key3;
                        break;
                    case 4:
                        Key4 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                        Key = Key4;
                        break;
                    case 5:
                        Key5 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                        Key = Key5;
                        break;
                    default:
                        Key = "rip";
                        break;
                }

                // Parsing data
                if (String.Equals(Key, "AbilityId", StringComparison.InvariantCulture)) {
                    Data_AbilityId_Unk1 = Stream.Read.ByteArray(4);
                    Data_AbilityId_Id = Stream.Read.UInt();
                }
                else if (String.Equals(Key, "Distance", StringComparison.InvariantCulture)) {
                    Data_Distance = Stream.Read.ByteArray(8);
                }
                else if (String.Equals(Key, "FrameTypeId", StringComparison.InvariantCulture)) {
                    Data_FrameTypeId = Stream.Read.ByteArray(8);
                }
                else if (String.Equals(Key, "PlayerGUID", StringComparison.InvariantCulture)) {
                    Data_PlayerGUID_Unk1 = Stream.Read.ByteArray(4);
                    Data_PlayerGUID_Entity = Stream.Read.ByteArray(8);
                }
                else if (String.Equals(Key, "TargetGUID", StringComparison.InvariantCulture)) {
                    Data_TargetGUID_Unk1 = Stream.Read.ByteArray(4);
                    Data_TargetGUID_Entity = Stream.Read.ByteArray(8);
                }
                else if (String.Equals(Key, "Value", StringComparison.InvariantCulture)) {
                    Data_Value = Stream.Read.ByteArray(8);
                }
                
                index++;
            }
            while (index <= ParamCount && Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }

        // Reads until we find 0x00, then resets the head and returns the number of bytes read.
        private int GetNullTerminatedStrSize(Bitter.BinaryStream Stream)
        {
            long StartOffset = Stream.baseStream.ByteOffset;
            do
            {
                byte b = Stream.Read.Byte();
                if (b == 0x00)
                {
                    break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            long EndOffset = Stream.baseStream.ByteOffset;
            Stream.baseStream.ByteOffset = StartOffset;
            return (int)(EndOffset - StartOffset);
        }
    }
}