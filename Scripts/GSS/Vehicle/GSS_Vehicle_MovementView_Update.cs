using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 31, 1, true)]
    public class VehicleMovementViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            CurrentPose = 0x00,
            SpawnVelocity = 0x01,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public float[] CurrentPose_Position;
        public float[] CurrentPose_Rotation;
        public float[] CurrentPose_Direction;
        public ushort CurrentPose_MovementState;
        public uint CurrentPose_Time;
        public float[] SpawnVelocity;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.CurrentPose:
                        CurrentPose_Position = Stream.Read.FloatArray(3);
                        CurrentPose_Rotation = Stream.Read.FloatArray(4);
                        CurrentPose_Direction = Stream.Read.FloatArray(3);
                        CurrentPose_MovementState = Stream.Read.UShort();
                        CurrentPose_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SpawnVelocity:
                        SpawnVelocity = Stream.Read.FloatArray(3);
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

    
        }



    }
}