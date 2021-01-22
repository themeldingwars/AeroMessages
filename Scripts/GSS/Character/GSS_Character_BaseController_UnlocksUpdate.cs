using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 130, true)]
    public class CharacterBaseControllerUnlocksUpdate : BaseScript
    {
        public byte UnkFirstByte; // Probably partitial vs full update, like InventoryUpdate.

        public byte NumberOfKeys;
        public string[] Keys;

            // Each key
            public string Key;

                // Each key entry
                public uint CertId;
                public byte Unk1_Count;
                public uint[] Unk1_Data;
                public byte Unk2_Count;
                public uint[] Unk2_Data;
                public byte Unk3_Count;
                public uint[] Unk3_Data;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            // Note: Needs split package support, so only half implemented
            // Format:
            // Unk: 1 byte (0x01), probably full/paritial update
            // NumberOfKeys: 1 byte
            // * for each Key
            //     Key: stringz
            //     NumberOfEntries: 1 byte (if 0xff -> after parsing 255 entries, go back and read another NumberOfEntries byte)
            //      * for each Entry
            //          Id: uint32le
            //          Unk1_Count: byte
            //              * for each Unk1_Count
            //              Unk1_Id: uint32le
            //          Unk2_Count: byte
            //              * for each Unk2_Count
            //              Unk2_Id: uint32le
            //          Unk3_Count: byte
            //              * for each Unk3_Count
            //              Unk3_Id: uint32le
            // 
            //     End of key: 1 byte (0x00)
            //     


            UnkFirstByte = Stream.Read.Byte();
            NumberOfKeys = Stream.Read.Byte();

            Key = Stream.Read.StringZ(Stream);

            byte NumberOfEntriesInSection;
            int totalAmountOfBytes;
            do
            {
                NumberOfEntriesInSection = Stream.Read.Byte();
                for (int i = 0; i < NumberOfEntriesInSection; i++)
                {
                    CertId = Stream.Read.UInt();
                    Unk1_Count = Stream.Read.Byte(); // Specifies a battleframe this cert is for
                    Unk1_Data = Stream.Read.UIntArray((int)Unk1_Count);
                    Unk2_Count = Stream.Read.Byte();
                    Unk2_Data = Stream.Read.UIntArray((int)Unk2_Count);
                    Unk3_Count = Stream.Read.Byte(); // Assumption
                    Unk3_Data = Stream.Read.UIntArray((int)Unk3_Count);
                }
            }
            while (NumberOfEntriesInSection == 255 && Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }


    public static class MyExtensions {
        public static string StringZ(this Bitter.BinaryReader rdr, Bitter.BinaryStream stream) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (stream.baseStream.ByteOffset < stream.baseStream.Length);
            return ret;
        }
    }
}