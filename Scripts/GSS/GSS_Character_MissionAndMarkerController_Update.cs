using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 4, 1, true)]
    public class CharacterMissionAndMarkerControllerRequestAchievementStatus : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            PersonalMapMarkers_0 = 0x00,
            PersonalMapMarkers_1 = 0x01,
            PersonalMapMarkers_2 = 0x02,
            PersonalMapMarkers_3 = 0x03,
            PersonalMapMarkers_4 = 0x04,
            PersonalMapMarkers_5 = 0x05,
            PersonalMapMarkers_6 = 0x06,
            PersonalMapMarkers_7 = 0x07,
            PersonalMapMarkers_8 = 0x08,
            PersonalMapMarkers_9 = 0x09,
            PersonalMapMarkers_10 = 0x10,
            PersonalMapMarkers_11 = 0x0b,
            PersonalMapMarkers_12 = 0x0c,
            PersonalMapMarkers_13 = 0x0d,
            PersonalMapMarkers_14 = 0x0e,
            PersonalMapMarkers_15 = 0x0f,
            PersonalMapMarkers_16 = 0x10,
            PersonalMapMarkers_17 = 0x11,
            PersonalMapMarkers_18 = 0x12,
            PersonalMapMarkers_19 = 0x13,
            PersonalMapMarkers_20 = 0x14,
            PersonalMapMarkers_21 = 0x15,
            PersonalMapMarkers_22 = 0x16,
            PersonalMapMarkers_23 = 0x17,
            PersonalMapMarkers_24 = 0x18,
            PersonalMapMarkers_25 = 0x19,
            PersonalMapMarkers_26 = 0x1a,
            PersonalMapMarkers_27 = 0x1b,
            PersonalMapMarkers_28 = 0x1c,
            PersonalMapMarkers_29 = 0x1d,
            PersonalMapMarkers_30 = 0x1e,
            PersonalMapMarkers_31 = 0x1f,
            PersonalMapMarkers_32 = 0x20,
            PersonalMapMarkers_33 = 0x21,
            PersonalMapMarkers_34 = 0x22,
            PersonalMapMarkers_35 = 0x23,
            PersonalMapMarkers_36 = 0x24,
            PersonalMapMarkers_37 = 0x25,
            PersonalMapMarkers_38 = 0x26,
            PersonalMapMarkers_39 = 0x27,
            PersonalMapMarkers_40 = 0x28,
            PersonalMapMarkers_41 = 0x29,
            PersonalMapMarkers_42 = 0x2a,
            PersonalMapMarkers_43 = 0x2b,
            PersonalMapMarkers_44 = 0x2c,
            PersonalMapMarkers_45 = 0x2d,
            PersonalMapMarkers_46 = 0x2e,
            PersonalMapMarkers_47 = 0x2f,
            PersonalMapMarkers_48 = 0x30,
            PersonalMapMarkers_49 = 0x31,
            PersonalMapMarkers_50 = 0x32,
            PersonalMapMarkers_51 = 0x33,
            PersonalMapMarkers_52 = 0x34,
            PersonalMapMarkers_53 = 0x35,
            PersonalMapMarkers_54 = 0x36,
            PersonalMapMarkers_55 = 0x37,
            PersonalMapMarkers_56 = 0x38,
            PersonalMapMarkers_57 = 0x39,
            PersonalMapMarkers_58 = 0x3a,
            PersonalMapMarkers_59 = 0x3b,
            PersonalMapMarkers_60 = 0x3c,
            PersonalMapMarkers_61 = 0x3d,
            PersonalMapMarkers_62 = 0x3e,
            PersonalMapMarkers_63 = 0x3f,
            AreaMapMarkers_0 = 0x40,
            AreaMapMarkers_1 = 0x41,
            AreaMapMarkers_2 = 0x42,
            AreaMapMarkers_3 = 0x43,
            AreaMapMarkers_4 = 0x44,
            AreaMapMarkers_5 = 0x45,
            AreaMapMarkers_6 = 0x46,
            AreaMapMarkers_7 = 0x47,
            ContextFlags_0 = 0x48,
            ContextFlags_1 = 0x49,
            ContextFlags_2 = 0x4a,
            ContextFlags_3 = 0x4b,
            ContextFlags_4 = 0x4c,
            ContextFlags_5 = 0x4d,
            ContextFlags_6 = 0x4e,
            ContextFlags_7 = 0x4f,
            ContextFlags_8 = 0x50,
            ContextFlags_9 = 0x51,
            ContextFlags_10 = 0x52,
            ContextFlags_11 = 0x53,
            ContextFlags_12 = 0x54,
            ContextFlags_13 = 0x55,
            ContextFlags_14 = 0x56,
            ContextFlags_15 = 0x57,
            ContextFlags_16 = 0x58,
            ContextFlags_17 = 0x59,
            ContextFlags_18 = 0x5a,
            ContextFlags_19 = 0x5b,
            ContextFlags_20 = 0x5c,
            ContextFlags_21 = 0x5d,
            ContextFlags_22 = 0x5e,
            ContextFlags_23 = 0x5f,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
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