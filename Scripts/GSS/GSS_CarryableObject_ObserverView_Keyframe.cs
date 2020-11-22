using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 3, true)]
    public class CarryableObjectObserverViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public uint CarryableTypeId; // Sdb table 480, id column.
        public byte Unk2;
        public float[] Position;
        public float[] MaybeRotation;
        public byte Unk3;
        public byte Unk3_Extra;
        public ushort[] Unk4_StatusEffectTimes;

        public float Unk_Float0;
        public float Unk_Float1;
        public float Unk_Float2;
        public float Unk_Float3;
        public float Unk_Float4;
        public float Unk_Float5;
        public float Unk_Float6;
        public float Unk_Float7;
        public float Unk_Float8;
        public float Unk_Float9;

        public ushort? StatusEffect_00_ShortTime;
        public uint? StatusEffect_00_Id;
        public byte[] StatusEffect_00_Unk1;
        public byte[] StatusEffect_00_Entity;
        public uint? StatusEffect_00_Time1;
        public byte? StatusEffect_00_MoreDataFlag;
        public byte? StatusEffect_00_Data1_Count;
        public byte[] StatusEffect_00_Data1_Entity;
        public byte[] StatusEffect_00_UnkData;
        public float? StatusEffect_00_Data_Float1;
        public float? StatusEffect_00_Data_Float2;
        public bool? StatusEffect_00_Cancel;

        public byte[] MaybeFaction; // Total guess

        public byte[] Unk6;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Unk1 = Stream.Read.ByteArray(8);
                CarryableTypeId = Stream.Read.UInt();
                Unk2 = Stream.Read.Byte();

                Position = Stream.Read.FloatArray(3);
                MaybeRotation = Stream.Read.FloatArray(4);

                Unk3 = Stream.Read.Byte(); // Does this indicate additional status effects??
                if (Unk3 > 0x00) {
                    Unk3_Extra = Stream.Read.Byte();
                }
                Unk4_StatusEffectTimes = Stream.Read.UShortArray(12); // Probably just 12, unk3 throws it off though so went with 14

                Unk_Float0 = Stream.Read.Float();
                Unk_Float1 = Stream.Read.Float();
                Unk_Float2 = Stream.Read.Float();
                Unk_Float3 = Stream.Read.Float();
                Unk_Float4 = Stream.Read.Float();
                Unk_Float5 = Stream.Read.Float();
                Unk_Float6 = Stream.Read.Float();
                Unk_Float7 = Stream.Read.Float();
                Unk_Float8 = Stream.Read.Float();
                Unk_Float9 = Stream.Read.Float();




                // Its a bit eeerily similar
                StatusEffect_00_Id     = Stream.Read.UInt();
                StatusEffect_00_Unk1   = Stream.Read.ByteArray(1);
                StatusEffect_00_Entity = Stream.Read.ByteArray(8);
                StatusEffect_00_Time1  = Stream.Read.UInt();
                StatusEffect_00_MoreDataFlag = Stream.Read.Byte();
                if (StatusEffect_00_MoreDataFlag == 0x01)
                {
                    StatusEffect_00_Data1_Count = Stream.Read.Byte();
                    if (StatusEffect_00_Data1_Count > 0) {
                        StatusEffect_00_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffect_00_Data1_Count);
                    }
                    StatusEffect_00_UnkData   = Stream.Read.ByteArray(29);
                    StatusEffect_00_Data_Float1 = Stream.Read.Float();
                    StatusEffect_00_Data_Float2 = Stream.Read.Float();
                }

                MaybeFaction = Stream.Read.ByteArray(2);

                Unk6 = Stream.Read.ByteArray(13);

            }
            
        }
    }
}