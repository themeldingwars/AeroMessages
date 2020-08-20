using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 35, 3, true)]
    public class DeployableObserverViewKeyframe : BaseScript
    {
        public byte[] Unk1;

        public uint DeployableTypeId; // Sdb table 187, id column.

        public byte[] OwnerEntity;
        public uint SourceAbilityId; // example in msgidx 123396

        public float[] Position1;
        public float[] Rotation1; // Not completely sold for all variations

        public float[] Position2;
        public float[] Rotation2; // Not completely sold for all variations

        public byte[] UnkAfterRot;

        public byte[] UnkExtraBeforeText;
        public byte[] UnkBeforeText;

        public string UnkText;

        public byte[] UnkAfterText;

        public byte[] UnkEntity1;
        public uint UnkTime1;
        public byte[] UnkBytes1;
        public byte[] UnkEntity2;
        public uint UnkTime2;
        public byte[] UnkBytes2;
        public byte[] UnkEntity3;
        public uint UnkTime3;
        public byte[] UnkBytes3;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(8); 

            DeployableTypeId = Stream.Read.UInt();

            OwnerEntity = Stream.Read.ByteArray(8);
            SourceAbilityId = Stream.Read.UInt();

            Position1 = Stream.Read.FloatArray(3);
            Rotation1 = Stream.Read.FloatArray(4);
            
            Position2 = Stream.Read.FloatArray(3);
            Rotation2 = Stream.Read.FloatArray(4);


            Stream.baseStream.ByteOffset += 6;
            // The bytes prior don't match up when looking through multiple messages even though it may look like they're part of the message in some.

            UnkAfterRot = Stream.Read.ByteArray(6);

            if (UnkAfterRot[4] != 0x00)
            {
                UnkExtraBeforeText = Stream.Read.ByteArray(58);
            }
            

            UnkBeforeText = Stream.Read.ByteArray(2);
            UnkText = Stream.Read.String(GetNullTerminatedStrSize(Stream));

            UnkAfterText = Stream.Read.ByteArray(2);


            UnkEntity1 = Stream.Read.ByteArray(8);
            UnkTime1 = Stream.Read.UInt();
            UnkBytes1 = Stream.Read.ByteArray(6);
            UnkEntity2 = Stream.Read.ByteArray(8);
            UnkTime2 = Stream.Read.UInt();
            UnkBytes2 = Stream.Read.ByteArray(6);
            UnkEntity3 = Stream.Read.ByteArray(8);
            UnkTime3 = Stream.Read.UInt();
            UnkBytes3 = Stream.Read.ByteArray(6);

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