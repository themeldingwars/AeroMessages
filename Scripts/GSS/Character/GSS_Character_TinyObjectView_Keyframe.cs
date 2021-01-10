using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 13, 3, true)]
    public class CharacterTinyObjectViewKeyframe : BaseScript
    {
        public byte[] Bitfield_TinyObjectData;

        // TypeIds are from SDB Table 152
        public ushort? TinyObject_00_TypeId;
        public float[] TinyObject_00_Position;
        public byte[] TinyObject_00_Faction;
        public ushort? TinyObject_01_TypeId;
        public float[] TinyObject_01_Position;
        public byte[] TinyObject_01_Faction;
        public ushort? TinyObject_02_TypeId;
        public float[] TinyObject_02_Position;
        public byte[] TinyObject_02_Faction;
        public ushort? TinyObject_03_TypeId;
        public float[] TinyObject_03_Position;
        public byte[] TinyObject_03_Faction;
        public ushort? TinyObject_04_TypeId;
        public float[] TinyObject_04_Position;
        public byte[] TinyObject_04_Faction;
        public ushort? TinyObject_05_TypeId;
        public float[] TinyObject_05_Position;
        public byte[] TinyObject_05_Faction;
        public ushort? TinyObject_06_TypeId;
        public float[] TinyObject_06_Position;
        public byte[] TinyObject_06_Faction;
        public ushort? TinyObject_07_TypeId;
        public float[] TinyObject_07_Position;
        public byte[] TinyObject_07_Faction;
        public ushort? TinyObject_08_TypeId;
        public float[] TinyObject_08_Position;
        public byte[] TinyObject_08_Faction;
        public ushort? TinyObject_09_TypeId;
        public float[] TinyObject_09_Position;
        public byte[] TinyObject_09_Faction;
        public ushort? TinyObject_0a_TypeId;
        public float[] TinyObject_0a_Position;
        public byte[] TinyObject_0a_Faction;
        public ushort? TinyObject_0b_TypeId;
        public float[] TinyObject_0b_Position;
        public byte[] TinyObject_0b_Faction;
        public ushort? TinyObject_0c_TypeId;
        public float[] TinyObject_0c_Position;
        public byte[] TinyObject_0c_Faction;
        public ushort? TinyObject_0d_TypeId;
        public float[] TinyObject_0d_Position;
        public byte[] TinyObject_0d_Faction;
        public ushort? TinyObject_0e_TypeId;
        public float[] TinyObject_0e_Position;
        public byte[] TinyObject_0e_Faction;
        public ushort? TinyObject_0f_TypeId;
        public float[] TinyObject_0f_Position;
        public byte[] TinyObject_0f_Faction;
        public ushort? TinyObject_10_TypeId;
        public float[] TinyObject_10_Position;
        public byte[] TinyObject_10_Faction;
        public ushort? TinyObject_11_TypeId;
        public float[] TinyObject_11_Position;
        public byte[] TinyObject_11_Faction;
        public ushort? TinyObject_12_TypeId;
        public float[] TinyObject_12_Position;
        public byte[] TinyObject_12_Faction;
        public ushort? TinyObject_13_TypeId;
        public float[] TinyObject_13_Position;
        public byte[] TinyObject_13_Faction;
        public ushort? TinyObject_14_TypeId;
        public float[] TinyObject_14_Position;
        public byte[] TinyObject_14_Faction;
        public ushort? TinyObject_15_TypeId;
        public float[] TinyObject_15_Position;
        public byte[] TinyObject_15_Faction;
        public ushort? TinyObject_16_TypeId;
        public float[] TinyObject_16_Position;
        public byte[] TinyObject_16_Faction;
        public ushort? TinyObject_17_TypeId;
        public float[] TinyObject_17_Position;
        public byte[] TinyObject_17_Faction;
        public ushort? TinyObject_18_TypeId;
        public float[] TinyObject_18_Position;
        public byte[] TinyObject_18_Faction;
        public ushort? TinyObject_19_TypeId;
        public float[] TinyObject_19_Position;
        public byte[] TinyObject_19_Faction;
        public ushort? TinyObject_1a_TypeId;
        public float[] TinyObject_1a_Position;
        public byte[] TinyObject_1a_Faction;
        public ushort? TinyObject_1b_TypeId;
        public float[] TinyObject_1b_Position;
        public byte[] TinyObject_1b_Faction;
        public ushort? TinyObject_1c_TypeId;
        public float[] TinyObject_1c_Position;
        public byte[] TinyObject_1c_Faction;
        public ushort? TinyObject_1d_TypeId;
        public float[] TinyObject_1d_Position;
        public byte[] TinyObject_1d_Faction;
        public ushort? TinyObject_1e_TypeId;
        public float[] TinyObject_1e_Position;
        public byte[] TinyObject_1e_Faction;
        public ushort? TinyObject_1f_TypeId;
        public float[] TinyObject_1f_Position;
        public byte[] TinyObject_1f_Faction;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield_TinyObjectData = Stream.Read.BitArray(32);

                if (Bitfield_TinyObjectData[0] == 0x00) {
                    TinyObject_00_TypeId = Stream.Read.UShort();
                    TinyObject_00_Position = Stream.Read.FloatArray(3);
                    TinyObject_00_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[1] == 0x00) {
                    TinyObject_01_TypeId = Stream.Read.UShort();
                    TinyObject_01_Position = Stream.Read.FloatArray(3);
                    TinyObject_01_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[2] == 0x00) {
                    TinyObject_02_TypeId = Stream.Read.UShort();
                    TinyObject_02_Position = Stream.Read.FloatArray(3);
                    TinyObject_02_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[3] == 0x00) {
                    TinyObject_03_TypeId = Stream.Read.UShort();
                    TinyObject_03_Position = Stream.Read.FloatArray(3);
                    TinyObject_03_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[4] == 0x00) {
                    TinyObject_04_TypeId = Stream.Read.UShort();
                    TinyObject_04_Position = Stream.Read.FloatArray(3);
                    TinyObject_04_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[5] == 0x00) {
                    TinyObject_05_TypeId = Stream.Read.UShort();
                    TinyObject_05_Position = Stream.Read.FloatArray(3);
                    TinyObject_05_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[6] == 0x00) {
                    TinyObject_06_TypeId = Stream.Read.UShort();
                    TinyObject_06_Position = Stream.Read.FloatArray(3);
                    TinyObject_06_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[7] == 0x00) {
                    TinyObject_07_TypeId = Stream.Read.UShort();
                    TinyObject_07_Position = Stream.Read.FloatArray(3);
                    TinyObject_07_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[8] == 0x00) {
                    TinyObject_08_TypeId = Stream.Read.UShort();
                    TinyObject_08_Position = Stream.Read.FloatArray(3);
                    TinyObject_08_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[9] == 0x00) {
                    TinyObject_09_TypeId = Stream.Read.UShort();
                    TinyObject_09_Position = Stream.Read.FloatArray(3);
                    TinyObject_09_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[10] == 0x00) {
                    TinyObject_0a_TypeId = Stream.Read.UShort();
                    TinyObject_0a_Position = Stream.Read.FloatArray(3);
                    TinyObject_0a_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[11] == 0x00) {
                    TinyObject_0b_TypeId = Stream.Read.UShort();
                    TinyObject_0b_Position = Stream.Read.FloatArray(3);
                    TinyObject_0b_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[12] == 0x00) {
                    TinyObject_0c_TypeId = Stream.Read.UShort();
                    TinyObject_0c_Position = Stream.Read.FloatArray(3);
                    TinyObject_0c_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[13] == 0x00) {
                    TinyObject_0d_TypeId = Stream.Read.UShort();
                    TinyObject_0d_Position = Stream.Read.FloatArray(3);
                    TinyObject_0d_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[14] == 0x00) {
                    TinyObject_0e_TypeId = Stream.Read.UShort();
                    TinyObject_0e_Position = Stream.Read.FloatArray(3);
                    TinyObject_0e_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[15] == 0x00) {
                    TinyObject_0f_TypeId = Stream.Read.UShort();
                    TinyObject_0f_Position = Stream.Read.FloatArray(3);
                    TinyObject_0f_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[16] == 0x00) {
                    TinyObject_10_TypeId = Stream.Read.UShort();
                    TinyObject_10_Position = Stream.Read.FloatArray(3);
                    TinyObject_10_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[17] == 0x00) {
                    TinyObject_11_TypeId = Stream.Read.UShort();
                    TinyObject_11_Position = Stream.Read.FloatArray(3);
                    TinyObject_11_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[18] == 0x00) {
                    TinyObject_12_TypeId = Stream.Read.UShort();
                    TinyObject_12_Position = Stream.Read.FloatArray(3);
                    TinyObject_12_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[19] == 0x00) {
                    TinyObject_13_TypeId = Stream.Read.UShort();
                    TinyObject_13_Position = Stream.Read.FloatArray(3);
                    TinyObject_13_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[20] == 0x00) {
                    TinyObject_14_TypeId = Stream.Read.UShort();
                    TinyObject_14_Position = Stream.Read.FloatArray(3);
                    TinyObject_14_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[21] == 0x00) {
                    TinyObject_15_TypeId = Stream.Read.UShort();
                    TinyObject_15_Position = Stream.Read.FloatArray(3);
                    TinyObject_15_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[22] == 0x00) {
                    TinyObject_16_TypeId = Stream.Read.UShort();
                    TinyObject_16_Position = Stream.Read.FloatArray(3);
                    TinyObject_16_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[23] == 0x00) {
                    TinyObject_17_TypeId = Stream.Read.UShort();
                    TinyObject_17_Position = Stream.Read.FloatArray(3);
                    TinyObject_17_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[24] == 0x00) {
                    TinyObject_18_TypeId = Stream.Read.UShort();
                    TinyObject_18_Position = Stream.Read.FloatArray(3);
                    TinyObject_18_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[25] == 0x00) {
                    TinyObject_19_TypeId = Stream.Read.UShort();
                    TinyObject_19_Position = Stream.Read.FloatArray(3);
                    TinyObject_19_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[26] == 0x00) {
                    TinyObject_1a_TypeId = Stream.Read.UShort();
                    TinyObject_1a_Position = Stream.Read.FloatArray(3);
                    TinyObject_1a_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[27] == 0x00) {
                    TinyObject_1b_TypeId = Stream.Read.UShort();
                    TinyObject_1b_Position = Stream.Read.FloatArray(3);
                    TinyObject_1b_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[28] == 0x00) {
                    TinyObject_1c_TypeId = Stream.Read.UShort();
                    TinyObject_1c_Position = Stream.Read.FloatArray(3);
                    TinyObject_1c_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[29] == 0x00) {
                    TinyObject_1d_TypeId = Stream.Read.UShort();
                    TinyObject_1d_Position = Stream.Read.FloatArray(3);
                    TinyObject_1d_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[30] == 0x00) {
                    TinyObject_1e_TypeId = Stream.Read.UShort();
                    TinyObject_1e_Position = Stream.Read.FloatArray(3);
                    TinyObject_1e_Faction = Stream.Read.ByteArray(2);
                }

                if (Bitfield_TinyObjectData[31] == 0x00) {
                    TinyObject_1f_TypeId = Stream.Read.UShort();
                    TinyObject_1f_Position = Stream.Read.FloatArray(3);
                    TinyObject_1f_Faction = Stream.Read.ByteArray(2);
                }
            }
        }
    }
}