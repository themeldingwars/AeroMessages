using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 1, true)]
    public class CarryableObjectObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position = 0x02,
            Unk_0x06 = 0x06,

            StatusEffect_08_ShortTime = 0x08,
            StatusEffect_08_Data = 0x28,
            StatusEffect_08_Cancel = 0xa8,

            Unk_0x65 = 0x65,

            Unk_0x86 = 0x86, // not sure if call with no data or if just a byte that belonged elsewhere
        }

        public float[] Position;
        public byte[] Unk_0x06;

        public float[] Unk_0x65_Position;
        public float[] Unk_0x65_MaybeVelocity;
        public uint? Unk_0x65_Time;


        public ushort? StatusEffect_08_ShortTime;
        public uint? StatusEffect_08_Id; 
        public byte[] StatusEffect_08_Unk1;
        public byte[] StatusEffect_08_Entity;
        public uint? StatusEffect_08_Time1;
        public byte? StatusEffect_08_MoreDataFlag;
        public byte? StatusEffect_08_Data1_Count;
        public byte[] StatusEffect_08_Data1_Entity;
        public byte[] StatusEffect_08_UnkData;
        public float? StatusEffect_08_Data_Float1;
        public float? StatusEffect_08_Data_Float2;
        public bool? StatusEffect_08_Cancel;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;

                    case ShadowFieldIndex.Unk_0x06:
                        //Unk_0x06 = Stream.Read.ByteArray(3);
                        break;

                    case ShadowFieldIndex.Unk_0x65:
                        Unk_0x65_Position = Stream.Read.FloatArray(3);
                        Unk_0x65_MaybeVelocity = Stream.Read.FloatArray(3);
                        Unk_0x65_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.StatusEffect_08_ShortTime:
                        StatusEffect_08_ShortTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffect_08_Data:
                        StatusEffect_08_Id     = Stream.Read.UInt();
                        StatusEffect_08_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffect_08_Entity = Stream.Read.ByteArray(8);
                        StatusEffect_08_Time1  = Stream.Read.UInt();
                        StatusEffect_08_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffect_08_MoreDataFlag == 0x01)
                        {
                            StatusEffect_08_Data1_Count = Stream.Read.Byte();
                            if (StatusEffect_08_Data1_Count > 0) {
                                StatusEffect_08_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_08_Data1_Count);
                            }
                            StatusEffect_08_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffect_08_Data_Float1 = Stream.Read.Float();
                            StatusEffect_08_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffect_08_Cancel:
                        StatusEffect_08_Cancel = true;
                        break;


                    case ShadowFieldIndex.Unk_0x86:
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