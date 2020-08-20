using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 169, true)]
    public class CharacterBaseControllerChatPartyUpdate : BaseScript
    {
        public byte[] Begin_Entity;
        public string Begin_Name;

        public byte[] Unk1;

        public byte NumberOfMembers;

        public byte[] Member_01_Entity;
        public string? Member_01_Name;
        public byte? Member_01_Unk;
        public byte[] Member_02_Entity;
        public string? Member_02_Name;
        public byte? Member_02_Unk;
        public byte[] Member_03_Entity;
        public string? Member_03_Name;
        public byte? Member_03_Unk;
        public byte[] Member_04_Entity;
        public string? Member_04_Name;
        public byte? Member_04_Unk;
        public byte[] Member_05_Entity;
        public string? Member_05_Name;
        public byte? Member_05_Unk;

        public byte[] End_Entity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Begin_Entity = Stream.Read.ByteArray(8);
            Begin_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));

            Unk1 = Stream.Read.ByteArray(10);

            NumberOfMembers = Stream.Read.Byte();

            if (NumberOfMembers > 0)
            {
                Member_01_Entity = Stream.Read.ByteArray(8);
                Member_01_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Member_01_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 1)
            {
                Member_02_Entity = Stream.Read.ByteArray(8);
                Member_02_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Member_02_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 2)
            {
                Member_03_Entity = Stream.Read.ByteArray(8);
                Member_03_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Member_03_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 3)
            {
                Member_04_Entity = Stream.Read.ByteArray(8);
                Member_04_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Member_04_Unk = Stream.Read.Byte();
            }
            if (NumberOfMembers > 5)
            {
                Member_05_Entity = Stream.Read.ByteArray(8);
                Member_05_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Member_05_Unk = Stream.Read.Byte();
            }




            End_Entity = Stream.Read.ByteArray(8);
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