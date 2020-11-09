using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 22, 3, true)]
    public class AreaVisualDataMapMarkerViewKeyframe : BaseScript
    {
        public byte[] Bitfield_MarkerData; // Assuming all 4 bytes are for markers but have only observed the first 2
        public byte? Unk1; // Always 7 in the captures, haven't played around with it.
        public float[] Position;

        public float[] MapMarker_00_Position;
        public uint? MapMarker_00_MarkerType; // SDB Table 155
        public byte[] MapMarker_00_Unk3;
        public byte[] MapMarker_00_EncounterId;
        public byte[] MapMarker_00_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_00_HasDuration;
        public uint? MapMarker_00_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_00_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_01_Position;
        public uint? MapMarker_01_MarkerType; // SDB Table 155
        public byte[] MapMarker_01_Unk3;
        public byte[] MapMarker_01_EncounterId;
        public byte[] MapMarker_01_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_01_HasDuration;
        public uint? MapMarker_01_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_01_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_02_Position;
        public uint? MapMarker_02_MarkerType; // SDB Table 155
        public byte[] MapMarker_02_Unk3;
        public byte[] MapMarker_02_EncounterId;
        public byte[] MapMarker_02_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_02_HasDuration;
        public uint? MapMarker_02_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_02_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_03_Position;
        public uint? MapMarker_03_MarkerType; // SDB Table 155
        public byte[] MapMarker_03_Unk3;
        public byte[] MapMarker_03_EncounterId;
        public byte[] MapMarker_03_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_03_HasDuration;
        public uint? MapMarker_03_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_03_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_04_Position;
        public uint? MapMarker_04_MarkerType; // SDB Table 155
        public byte[] MapMarker_04_Unk3;
        public byte[] MapMarker_04_EncounterId;
        public byte[] MapMarker_04_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_04_HasDuration;
        public uint? MapMarker_04_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_04_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_05_Position;
        public uint? MapMarker_05_MarkerType; // SDB Table 155
        public byte[] MapMarker_05_Unk3;
        public byte[] MapMarker_05_EncounterId;
        public byte[] MapMarker_05_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_05_HasDuration;
        public uint? MapMarker_05_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_05_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_06_Position;
        public uint? MapMarker_06_MarkerType; // SDB Table 155
        public byte[] MapMarker_06_Unk3;
        public byte[] MapMarker_06_EncounterId;
        public byte[] MapMarker_06_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_06_HasDuration;
        public uint? MapMarker_06_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_06_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_07_Position;
        public uint? MapMarker_07_MarkerType; // SDB Table 155
        public byte[] MapMarker_07_Unk3;
        public byte[] MapMarker_07_EncounterId;
        public byte[] MapMarker_07_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_07_HasDuration;
        public uint? MapMarker_07_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_07_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_08_Position;
        public uint? MapMarker_08_MarkerType; // SDB Table 155
        public byte[] MapMarker_08_Unk3;
        public byte[] MapMarker_08_EncounterId;
        public byte[] MapMarker_08_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_08_HasDuration;
        public uint? MapMarker_08_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_08_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_09_Position;
        public uint? MapMarker_09_MarkerType; // SDB Table 155
        public byte[] MapMarker_09_Unk3;
        public byte[] MapMarker_09_EncounterId;
        public byte[] MapMarker_09_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_09_HasDuration;
        public uint? MapMarker_09_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_09_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0a_Position;
        public uint? MapMarker_0a_MarkerType; // SDB Table 155
        public byte[] MapMarker_0a_Unk3;
        public byte[] MapMarker_0a_EncounterId;
        public byte[] MapMarker_0a_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0a_HasDuration;
        public uint? MapMarker_0a_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0a_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0b_Position;
        public uint? MapMarker_0b_MarkerType; // SDB Table 155
        public byte[] MapMarker_0b_Unk3;
        public byte[] MapMarker_0b_EncounterId;
        public byte[] MapMarker_0b_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0b_HasDuration;
        public uint? MapMarker_0b_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0b_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0c_Position;
        public uint? MapMarker_0c_MarkerType; // SDB Table 155
        public byte[] MapMarker_0c_Unk3;
        public byte[] MapMarker_0c_EncounterId;
        public byte[] MapMarker_0c_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0c_HasDuration;
        public uint? MapMarker_0c_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0c_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0d_Position;
        public uint? MapMarker_0d_MarkerType; // SDB Table 155
        public byte[] MapMarker_0d_Unk3;
        public byte[] MapMarker_0d_EncounterId;
        public byte[] MapMarker_0d_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0d_HasDuration;
        public uint? MapMarker_0d_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0d_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0e_Position;
        public uint? MapMarker_0e_MarkerType; // SDB Table 155
        public byte[] MapMarker_0e_Unk3;
        public byte[] MapMarker_0e_EncounterId;
        public byte[] MapMarker_0e_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0e_HasDuration;
        public uint? MapMarker_0e_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0e_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_0f_Position;
        public uint? MapMarker_0f_MarkerType; // SDB Table 155
        public byte[] MapMarker_0f_Unk3;
        public byte[] MapMarker_0f_EncounterId;
        public byte[] MapMarker_0f_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0f_HasDuration;
        public uint? MapMarker_0f_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_0f_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_10_Position;
        public uint? MapMarker_10_MarkerType; // SDB Table 155
        public byte[] MapMarker_10_Unk3;
        public byte[] MapMarker_10_EncounterId;
        public byte[] MapMarker_10_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_10_HasDuration;
        public uint? MapMarker_10_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_10_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_11_Position;
        public uint? MapMarker_11_MarkerType; // SDB Table 155
        public byte[] MapMarker_11_Unk3;
        public byte[] MapMarker_11_EncounterId;
        public byte[] MapMarker_11_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_11_HasDuration;
        public uint? MapMarker_11_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_11_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_12_Position;
        public uint? MapMarker_12_MarkerType; // SDB Table 155
        public byte[] MapMarker_12_Unk3;
        public byte[] MapMarker_12_EncounterId;
        public byte[] MapMarker_12_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_12_HasDuration;
        public uint? MapMarker_12_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_12_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_13_Position;
        public uint? MapMarker_13_MarkerType; // SDB Table 155
        public byte[] MapMarker_13_Unk3;
        public byte[] MapMarker_13_EncounterId;
        public byte[] MapMarker_13_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_13_HasDuration;
        public uint? MapMarker_13_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_13_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_14_Position;
        public uint? MapMarker_14_MarkerType; // SDB Table 155
        public byte[] MapMarker_14_Unk3;
        public byte[] MapMarker_14_EncounterId;
        public byte[] MapMarker_14_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_14_HasDuration;
        public uint? MapMarker_14_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_14_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_15_Position;
        public uint? MapMarker_15_MarkerType; // SDB Table 155
        public byte[] MapMarker_15_Unk3;
        public byte[] MapMarker_15_EncounterId;
        public byte[] MapMarker_15_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_15_HasDuration;
        public uint? MapMarker_15_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_15_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_16_Position;
        public uint? MapMarker_16_MarkerType; // SDB Table 155
        public byte[] MapMarker_16_Unk3;
        public byte[] MapMarker_16_EncounterId;
        public byte[] MapMarker_16_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_16_HasDuration;
        public uint? MapMarker_16_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_16_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_17_Position;
        public uint? MapMarker_17_MarkerType; // SDB Table 155
        public byte[] MapMarker_17_Unk3;
        public byte[] MapMarker_17_EncounterId;
        public byte[] MapMarker_17_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_17_HasDuration;
        public uint? MapMarker_17_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_17_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_18_Position;
        public uint? MapMarker_18_MarkerType; // SDB Table 155
        public byte[] MapMarker_18_Unk3;
        public byte[] MapMarker_18_EncounterId;
        public byte[] MapMarker_18_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_18_HasDuration;
        public uint? MapMarker_18_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_18_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_19_Position;
        public uint? MapMarker_19_MarkerType; // SDB Table 155
        public byte[] MapMarker_19_Unk3;
        public byte[] MapMarker_19_EncounterId;
        public byte[] MapMarker_19_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_19_HasDuration;
        public uint? MapMarker_19_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_19_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1a_Position;
        public uint? MapMarker_1a_MarkerType; // SDB Table 155
        public byte[] MapMarker_1a_Unk3;
        public byte[] MapMarker_1a_EncounterId;
        public byte[] MapMarker_1a_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1a_HasDuration;
        public uint? MapMarker_1a_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1a_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1b_Position;
        public uint? MapMarker_1b_MarkerType; // SDB Table 155
        public byte[] MapMarker_1b_Unk3;
        public byte[] MapMarker_1b_EncounterId;
        public byte[] MapMarker_1b_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1b_HasDuration;
        public uint? MapMarker_1b_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1b_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1c_Position;
        public uint? MapMarker_1c_MarkerType; // SDB Table 155
        public byte[] MapMarker_1c_Unk3;
        public byte[] MapMarker_1c_EncounterId;
        public byte[] MapMarker_1c_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1c_HasDuration;
        public uint? MapMarker_1c_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1c_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1d_Position;
        public uint? MapMarker_1d_MarkerType; // SDB Table 155
        public byte[] MapMarker_1d_Unk3;
        public byte[] MapMarker_1d_EncounterId;
        public byte[] MapMarker_1d_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1d_HasDuration;
        public uint? MapMarker_1d_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1d_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1e_Position;
        public uint? MapMarker_1e_MarkerType; // SDB Table 155
        public byte[] MapMarker_1e_Unk3;
        public byte[] MapMarker_1e_EncounterId;
        public byte[] MapMarker_1e_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1e_HasDuration;
        public uint? MapMarker_1e_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1e_Offset_AsUShort; // Not sure about the format.

        public float[] MapMarker_1f_Position;
        public uint? MapMarker_1f_MarkerType; // SDB Table 155
        public byte[] MapMarker_1f_Unk3;
        public byte[] MapMarker_1f_EncounterId;
        public byte[] MapMarker_1f_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1f_HasDuration;
        public uint? MapMarker_1f_ExpireAtTime; // Gametime ms
        public ushort[] MapMarker_1f_Offset_AsUShort; // Not sure about the format.


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield_MarkerData = Stream.Read.BitArray(32);
                Unk1 = Stream.Read.Byte();
                Position = Stream.Read.FloatArray(3);

                if (Bitfield_MarkerData[0] == 0x00) {
                    MapMarker_00_MarkerType = Stream.Read.UInt();
                    MapMarker_00_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_00_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_00_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_00_HasDuration = Stream.Read.Byte();
                    if (MapMarker_00_HasDuration != 0x00) {
                        MapMarker_00_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_00_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[1] == 0x00) {
                    MapMarker_01_MarkerType = Stream.Read.UInt();
                    MapMarker_01_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_01_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_01_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_01_HasDuration = Stream.Read.Byte();
                    if (MapMarker_01_HasDuration != 0x00) {
                        MapMarker_01_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_01_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[2] == 0x00) {
                    MapMarker_02_MarkerType = Stream.Read.UInt();
                    MapMarker_02_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_02_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_02_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_02_HasDuration = Stream.Read.Byte();
                    if (MapMarker_02_HasDuration != 0x00) {
                        MapMarker_02_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_02_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[3] == 0x00) {
                    MapMarker_03_MarkerType = Stream.Read.UInt();
                    MapMarker_03_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_03_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_03_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_03_HasDuration = Stream.Read.Byte();
                    if (MapMarker_03_HasDuration != 0x00) {
                        MapMarker_03_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_03_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[4] == 0x00) {
                    MapMarker_04_MarkerType = Stream.Read.UInt();
                    MapMarker_04_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_04_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_04_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_04_HasDuration = Stream.Read.Byte();
                    if (MapMarker_04_HasDuration != 0x00) {
                        MapMarker_04_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_04_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[5] == 0x00) {
                    MapMarker_05_MarkerType = Stream.Read.UInt();
                    MapMarker_05_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_05_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_05_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_05_HasDuration = Stream.Read.Byte();
                    if (MapMarker_05_HasDuration != 0x00) {
                        MapMarker_05_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_05_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[6] == 0x00) {
                    MapMarker_06_MarkerType = Stream.Read.UInt();
                    MapMarker_06_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_06_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_06_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_06_HasDuration = Stream.Read.Byte();
                    if (MapMarker_06_HasDuration != 0x00) {
                        MapMarker_06_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_06_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[7] == 0x00) {
                    MapMarker_07_MarkerType = Stream.Read.UInt();
                    MapMarker_07_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_07_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_07_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_07_HasDuration = Stream.Read.Byte();
                    if (MapMarker_07_HasDuration != 0x00) {
                        MapMarker_07_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_07_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[8] == 0x00) {
                    MapMarker_08_MarkerType = Stream.Read.UInt();
                    MapMarker_08_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_08_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_08_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_08_HasDuration = Stream.Read.Byte();
                    if (MapMarker_08_HasDuration != 0x00) {
                        MapMarker_08_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_08_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[9] == 0x00) {
                    MapMarker_09_MarkerType = Stream.Read.UInt();
                    MapMarker_09_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_09_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_09_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_09_HasDuration = Stream.Read.Byte();
                    if (MapMarker_09_HasDuration != 0x00) {
                        MapMarker_09_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_09_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[10] == 0x00) {
                    MapMarker_0a_MarkerType = Stream.Read.UInt();
                    MapMarker_0a_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0a_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0a_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0a_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0a_HasDuration != 0x00) {
                        MapMarker_0a_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0a_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[11] == 0x00) {
                    MapMarker_0b_MarkerType = Stream.Read.UInt();
                    MapMarker_0b_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0b_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0b_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0b_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0b_HasDuration != 0x00) {
                        MapMarker_0b_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0b_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[12] == 0x00) {
                    MapMarker_0c_MarkerType = Stream.Read.UInt();
                    MapMarker_0c_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0c_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0c_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0c_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0c_HasDuration != 0x00) {
                        MapMarker_0c_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0c_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[13] == 0x00) {
                    MapMarker_0d_MarkerType = Stream.Read.UInt();
                    MapMarker_0d_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0d_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0d_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0d_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0d_HasDuration != 0x00) {
                        MapMarker_0d_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0d_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[14] == 0x00) {
                    MapMarker_0e_MarkerType = Stream.Read.UInt();
                    MapMarker_0e_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0e_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0e_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0e_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0e_HasDuration != 0x00) {
                        MapMarker_0e_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0e_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[15] == 0x00) {
                    MapMarker_0f_MarkerType = Stream.Read.UInt();
                    MapMarker_0f_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0f_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_0f_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_0f_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0f_HasDuration != 0x00) {
                        MapMarker_0f_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0f_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[16] == 0x00) {
                    MapMarker_10_MarkerType = Stream.Read.UInt();
                    MapMarker_10_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_10_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_10_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_10_HasDuration = Stream.Read.Byte();
                    if (MapMarker_10_HasDuration != 0x00) {
                        MapMarker_10_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_10_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[17] == 0x00) {
                    MapMarker_11_MarkerType = Stream.Read.UInt();
                    MapMarker_11_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_11_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_11_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_11_HasDuration = Stream.Read.Byte();
                    if (MapMarker_11_HasDuration != 0x00) {
                        MapMarker_11_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_11_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[18] == 0x00) {
                    MapMarker_12_MarkerType = Stream.Read.UInt();
                    MapMarker_12_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_12_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_12_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_12_HasDuration = Stream.Read.Byte();
                    if (MapMarker_12_HasDuration != 0x00) {
                        MapMarker_12_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_12_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[19] == 0x00) {
                    MapMarker_13_MarkerType = Stream.Read.UInt();
                    MapMarker_13_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_13_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_13_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_13_HasDuration = Stream.Read.Byte();
                    if (MapMarker_13_HasDuration != 0x00) {
                        MapMarker_13_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_13_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[20] == 0x00) {
                    MapMarker_14_MarkerType = Stream.Read.UInt();
                    MapMarker_14_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_14_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_14_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_14_HasDuration = Stream.Read.Byte();
                    if (MapMarker_14_HasDuration != 0x00) {
                        MapMarker_14_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_14_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[21] == 0x00) {
                    MapMarker_15_MarkerType = Stream.Read.UInt();
                    MapMarker_15_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_15_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_15_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_15_HasDuration = Stream.Read.Byte();
                    if (MapMarker_15_HasDuration != 0x00) {
                        MapMarker_15_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_15_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[22] == 0x00) {
                    MapMarker_16_MarkerType = Stream.Read.UInt();
                    MapMarker_16_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_16_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_16_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_16_HasDuration = Stream.Read.Byte();
                    if (MapMarker_16_HasDuration != 0x00) {
                        MapMarker_16_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_16_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[23] == 0x00) {
                    MapMarker_17_MarkerType = Stream.Read.UInt();
                    MapMarker_17_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_17_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_17_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_17_HasDuration = Stream.Read.Byte();
                    if (MapMarker_17_HasDuration != 0x00) {
                        MapMarker_17_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_17_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[24] == 0x00) {
                    MapMarker_18_MarkerType = Stream.Read.UInt();
                    MapMarker_18_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_18_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_18_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_18_HasDuration = Stream.Read.Byte();
                    if (MapMarker_18_HasDuration != 0x00) {
                        MapMarker_18_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_18_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[25] == 0x00) {
                    MapMarker_19_MarkerType = Stream.Read.UInt();
                    MapMarker_19_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_19_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_19_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_19_HasDuration = Stream.Read.Byte();
                    if (MapMarker_19_HasDuration != 0x00) {
                        MapMarker_19_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_19_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[26] == 0x00) {
                    MapMarker_1a_MarkerType = Stream.Read.UInt();
                    MapMarker_1a_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1a_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1a_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1a_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1a_HasDuration != 0x00) {
                        MapMarker_1a_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1a_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[27] == 0x00) {
                    MapMarker_1b_MarkerType = Stream.Read.UInt();
                    MapMarker_1b_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1b_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1b_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1b_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1b_HasDuration != 0x00) {
                        MapMarker_1b_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1b_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[28] == 0x00) {
                    MapMarker_1c_MarkerType = Stream.Read.UInt();
                    MapMarker_1c_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1c_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1c_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1c_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1c_HasDuration != 0x00) {
                        MapMarker_1c_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1c_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[29] == 0x00) {
                    MapMarker_1d_MarkerType = Stream.Read.UInt();
                    MapMarker_1d_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1d_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1d_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1d_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1d_HasDuration != 0x00) {
                        MapMarker_1d_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1d_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[30] == 0x00) {
                    MapMarker_1e_MarkerType = Stream.Read.UInt();
                    MapMarker_1e_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1e_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1e_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1e_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1e_HasDuration != 0x00) {
                        MapMarker_1e_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1e_Offset_AsUShort = Stream.Read.UShortArray(3);
                }

                if (Bitfield_MarkerData[31] == 0x00) {
                    MapMarker_1f_MarkerType = Stream.Read.UInt();
                    MapMarker_1f_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1f_EncounterId = Stream.Read.ByteArray(8);
                    MapMarker_1f_EncounterMarkerId = Stream.Read.ByteArray(8);
                    MapMarker_1f_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1f_HasDuration != 0x00) {
                        MapMarker_1f_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1f_Offset_AsUShort = Stream.Read.UShortArray(3);
                }
            }
            
        }
    }
}