using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 22, 3, true)]
    public class AreaVisualDataMapMarkerViewKeyframe : BaseScript
    {
        public byte[] Bitfield_MarkerData; // Assuming all 4 bytes are for markers but have only observed the first 2
        public byte? Unk1; // Always 7 in the captures, haven't played around with it.
        public float[] Position; // Used if the marker position is 0.

        public uint? MapMarker_00_MarkerType; // SDB Table 155
        public byte[] MapMarker_00_Unk3;
        public string MapMarker_00_EncounterId;
        public string MapMarker_00_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_00_HasDuration;
        public uint? MapMarker_00_ExpireAtTime; // Gametime ms
        public float[] MapMarker_00_Position;

        public uint? MapMarker_01_MarkerType; // SDB Table 155
        public byte[] MapMarker_01_Unk3;
        public string MapMarker_01_EncounterId;
        public string MapMarker_01_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_01_HasDuration;
        public uint? MapMarker_01_ExpireAtTime; // Gametime ms
        public float[] MapMarker_01_Position;

        public uint? MapMarker_02_MarkerType; // SDB Table 155
        public byte[] MapMarker_02_Unk3;
        public string MapMarker_02_EncounterId;
        public string MapMarker_02_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_02_HasDuration;
        public uint? MapMarker_02_ExpireAtTime; // Gametime ms
        public float[] MapMarker_02_Position;

        public uint? MapMarker_03_MarkerType; // SDB Table 155
        public byte[] MapMarker_03_Unk3;
        public string MapMarker_03_EncounterId;
        public string MapMarker_03_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_03_HasDuration;
        public uint? MapMarker_03_ExpireAtTime; // Gametime ms
        public float[] MapMarker_03_Position;

        public uint? MapMarker_04_MarkerType; // SDB Table 155
        public byte[] MapMarker_04_Unk3;
        public string MapMarker_04_EncounterId;
        public string MapMarker_04_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_04_HasDuration;
        public uint? MapMarker_04_ExpireAtTime; // Gametime ms
        public float[] MapMarker_04_Position;

        public uint? MapMarker_05_MarkerType; // SDB Table 155
        public byte[] MapMarker_05_Unk3;
        public string MapMarker_05_EncounterId;
        public string MapMarker_05_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_05_HasDuration;
        public uint? MapMarker_05_ExpireAtTime; // Gametime ms
        public float[] MapMarker_05_Position;

        public uint? MapMarker_06_MarkerType; // SDB Table 155
        public byte[] MapMarker_06_Unk3;
        public string MapMarker_06_EncounterId;
        public string MapMarker_06_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_06_HasDuration;
        public uint? MapMarker_06_ExpireAtTime; // Gametime ms
        public float[] MapMarker_06_Position;

        public uint? MapMarker_07_MarkerType; // SDB Table 155
        public byte[] MapMarker_07_Unk3;
        public string MapMarker_07_EncounterId;
        public string MapMarker_07_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_07_HasDuration;
        public uint? MapMarker_07_ExpireAtTime; // Gametime ms
        public float[] MapMarker_07_Position;

        public uint? MapMarker_08_MarkerType; // SDB Table 155
        public byte[] MapMarker_08_Unk3;
        public string MapMarker_08_EncounterId;
        public string MapMarker_08_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_08_HasDuration;
        public uint? MapMarker_08_ExpireAtTime; // Gametime ms
        public float[] MapMarker_08_Position;

        public uint? MapMarker_09_MarkerType; // SDB Table 155
        public byte[] MapMarker_09_Unk3;
        public string MapMarker_09_EncounterId;
        public string MapMarker_09_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_09_HasDuration;
        public uint? MapMarker_09_ExpireAtTime; // Gametime ms
        public float[] MapMarker_09_Position;

        public uint? MapMarker_0a_MarkerType; // SDB Table 155
        public byte[] MapMarker_0a_Unk3;
        public string MapMarker_0a_EncounterId;
        public string MapMarker_0a_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0a_HasDuration;
        public uint? MapMarker_0a_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0a_Position;

        public uint? MapMarker_0b_MarkerType; // SDB Table 155
        public byte[] MapMarker_0b_Unk3;
        public string MapMarker_0b_EncounterId;
        public string MapMarker_0b_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0b_HasDuration;
        public uint? MapMarker_0b_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0b_Position;

        public uint? MapMarker_0c_MarkerType; // SDB Table 155
        public byte[] MapMarker_0c_Unk3;
        public string MapMarker_0c_EncounterId;
        public string MapMarker_0c_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0c_HasDuration;
        public uint? MapMarker_0c_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0c_Position;

        public uint? MapMarker_0d_MarkerType; // SDB Table 155
        public byte[] MapMarker_0d_Unk3;
        public string MapMarker_0d_EncounterId;
        public string MapMarker_0d_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0d_HasDuration;
        public uint? MapMarker_0d_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0d_Position;

        public uint? MapMarker_0e_MarkerType; // SDB Table 155
        public byte[] MapMarker_0e_Unk3;
        public string MapMarker_0e_EncounterId;
        public string MapMarker_0e_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0e_HasDuration;
        public uint? MapMarker_0e_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0e_Position;

        public uint? MapMarker_0f_MarkerType; // SDB Table 155
        public byte[] MapMarker_0f_Unk3;
        public string MapMarker_0f_EncounterId;
        public string MapMarker_0f_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_0f_HasDuration;
        public uint? MapMarker_0f_ExpireAtTime; // Gametime ms
        public float[] MapMarker_0f_Position;

        public uint? MapMarker_10_MarkerType; // SDB Table 155
        public byte[] MapMarker_10_Unk3;
        public string MapMarker_10_EncounterId;
        public string MapMarker_10_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_10_HasDuration;
        public uint? MapMarker_10_ExpireAtTime; // Gametime ms
        public float[] MapMarker_10_Position;

        public uint? MapMarker_11_MarkerType; // SDB Table 155
        public byte[] MapMarker_11_Unk3;
        public string MapMarker_11_EncounterId;
        public string MapMarker_11_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_11_HasDuration;
        public uint? MapMarker_11_ExpireAtTime; // Gametime ms
        public float[] MapMarker_11_Position;

        public uint? MapMarker_12_MarkerType; // SDB Table 155
        public byte[] MapMarker_12_Unk3;
        public string MapMarker_12_EncounterId;
        public string MapMarker_12_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_12_HasDuration;
        public uint? MapMarker_12_ExpireAtTime; // Gametime ms
        public float[] MapMarker_12_Position;

        public uint? MapMarker_13_MarkerType; // SDB Table 155
        public byte[] MapMarker_13_Unk3;
        public string MapMarker_13_EncounterId;
        public string MapMarker_13_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_13_HasDuration;
        public uint? MapMarker_13_ExpireAtTime; // Gametime ms
        public float[] MapMarker_13_Position;

        public uint? MapMarker_14_MarkerType; // SDB Table 155
        public byte[] MapMarker_14_Unk3;
        public string MapMarker_14_EncounterId;
        public string MapMarker_14_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_14_HasDuration;
        public uint? MapMarker_14_ExpireAtTime; // Gametime ms
        public float[] MapMarker_14_Position;

        public uint? MapMarker_15_MarkerType; // SDB Table 155
        public byte[] MapMarker_15_Unk3;
        public string MapMarker_15_EncounterId;
        public string MapMarker_15_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_15_HasDuration;
        public uint? MapMarker_15_ExpireAtTime; // Gametime ms
        public float[] MapMarker_15_Position;

        public uint? MapMarker_16_MarkerType; // SDB Table 155
        public byte[] MapMarker_16_Unk3;
        public string MapMarker_16_EncounterId;
        public string MapMarker_16_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_16_HasDuration;
        public uint? MapMarker_16_ExpireAtTime; // Gametime ms
        public float[] MapMarker_16_Position;

        public uint? MapMarker_17_MarkerType; // SDB Table 155
        public byte[] MapMarker_17_Unk3;
        public string MapMarker_17_EncounterId;
        public string MapMarker_17_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_17_HasDuration;
        public uint? MapMarker_17_ExpireAtTime; // Gametime ms
        public float[] MapMarker_17_Position;

        public uint? MapMarker_18_MarkerType; // SDB Table 155
        public byte[] MapMarker_18_Unk3;
        public string MapMarker_18_EncounterId;
        public string MapMarker_18_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_18_HasDuration;
        public uint? MapMarker_18_ExpireAtTime; // Gametime ms
        public float[] MapMarker_18_Position;

        public uint? MapMarker_19_MarkerType; // SDB Table 155
        public byte[] MapMarker_19_Unk3;
        public string MapMarker_19_EncounterId;
        public string MapMarker_19_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_19_HasDuration;
        public uint? MapMarker_19_ExpireAtTime; // Gametime ms
        public float[] MapMarker_19_Position;

        public uint? MapMarker_1a_MarkerType; // SDB Table 155
        public byte[] MapMarker_1a_Unk3;
        public string MapMarker_1a_EncounterId;
        public string MapMarker_1a_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1a_HasDuration;
        public uint? MapMarker_1a_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1a_Position;

        public uint? MapMarker_1b_MarkerType; // SDB Table 155
        public byte[] MapMarker_1b_Unk3;
        public string MapMarker_1b_EncounterId;
        public string MapMarker_1b_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1b_HasDuration;
        public uint? MapMarker_1b_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1b_Position;

        public uint? MapMarker_1c_MarkerType; // SDB Table 155
        public byte[] MapMarker_1c_Unk3;
        public string MapMarker_1c_EncounterId;
        public string MapMarker_1c_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1c_HasDuration;
        public uint? MapMarker_1c_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1c_Position;

        public uint? MapMarker_1d_MarkerType; // SDB Table 155
        public byte[] MapMarker_1d_Unk3;
        public string MapMarker_1d_EncounterId;
        public string MapMarker_1d_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1d_HasDuration;
        public uint? MapMarker_1d_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1d_Position;

        public uint? MapMarker_1e_MarkerType; // SDB Table 155
        public byte[] MapMarker_1e_Unk3;
        public string MapMarker_1e_EncounterId;
        public string MapMarker_1e_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1e_HasDuration;
        public uint? MapMarker_1e_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1e_Position;

        public uint? MapMarker_1f_MarkerType; // SDB Table 155
        public byte[] MapMarker_1f_Unk3;
        public string MapMarker_1f_EncounterId;
        public string MapMarker_1f_EncounterMarkerId; // No controller specified.
        public byte? MapMarker_1f_HasDuration;
        public uint? MapMarker_1f_ExpireAtTime; // Gametime ms
        public float[] MapMarker_1f_Position;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield_MarkerData = Stream.Read.BitArray(32);
                Unk1 = Stream.Read.Byte();
                Position = Stream.Read.FloatArray(3);

                if (Bitfield_MarkerData[0] == 0x00) {
                    MapMarker_00_MarkerType = Stream.Read.UInt();
                    MapMarker_00_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_00_EncounterId = Stream.Read.Entity();
                    MapMarker_00_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_00_HasDuration = Stream.Read.Byte();
                    if (MapMarker_00_HasDuration != 0x00) {
                        MapMarker_00_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_00_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[1] == 0x00) {
                    MapMarker_01_MarkerType = Stream.Read.UInt();
                    MapMarker_01_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_01_EncounterId = Stream.Read.Entity();
                    MapMarker_01_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_01_HasDuration = Stream.Read.Byte();
                    if (MapMarker_01_HasDuration != 0x00) {
                        MapMarker_01_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_01_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[2] == 0x00) {
                    MapMarker_02_MarkerType = Stream.Read.UInt();
                    MapMarker_02_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_02_EncounterId = Stream.Read.Entity();
                    MapMarker_02_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_02_HasDuration = Stream.Read.Byte();
                    if (MapMarker_02_HasDuration != 0x00) {
                        MapMarker_02_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_02_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[3] == 0x00) {
                    MapMarker_03_MarkerType = Stream.Read.UInt();
                    MapMarker_03_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_03_EncounterId = Stream.Read.Entity();
                    MapMarker_03_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_03_HasDuration = Stream.Read.Byte();
                    if (MapMarker_03_HasDuration != 0x00) {
                        MapMarker_03_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_03_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[4] == 0x00) {
                    MapMarker_04_MarkerType = Stream.Read.UInt();
                    MapMarker_04_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_04_EncounterId = Stream.Read.Entity();
                    MapMarker_04_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_04_HasDuration = Stream.Read.Byte();
                    if (MapMarker_04_HasDuration != 0x00) {
                        MapMarker_04_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_04_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[5] == 0x00) {
                    MapMarker_05_MarkerType = Stream.Read.UInt();
                    MapMarker_05_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_05_EncounterId = Stream.Read.Entity();
                    MapMarker_05_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_05_HasDuration = Stream.Read.Byte();
                    if (MapMarker_05_HasDuration != 0x00) {
                        MapMarker_05_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_05_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[6] == 0x00) {
                    MapMarker_06_MarkerType = Stream.Read.UInt();
                    MapMarker_06_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_06_EncounterId = Stream.Read.Entity();
                    MapMarker_06_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_06_HasDuration = Stream.Read.Byte();
                    if (MapMarker_06_HasDuration != 0x00) {
                        MapMarker_06_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_06_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[7] == 0x00) {
                    MapMarker_07_MarkerType = Stream.Read.UInt();
                    MapMarker_07_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_07_EncounterId = Stream.Read.Entity();
                    MapMarker_07_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_07_HasDuration = Stream.Read.Byte();
                    if (MapMarker_07_HasDuration != 0x00) {
                        MapMarker_07_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_07_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[8] == 0x00) {
                    MapMarker_08_MarkerType = Stream.Read.UInt();
                    MapMarker_08_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_08_EncounterId = Stream.Read.Entity();
                    MapMarker_08_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_08_HasDuration = Stream.Read.Byte();
                    if (MapMarker_08_HasDuration != 0x00) {
                        MapMarker_08_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_08_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[9] == 0x00) {
                    MapMarker_09_MarkerType = Stream.Read.UInt();
                    MapMarker_09_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_09_EncounterId = Stream.Read.Entity();
                    MapMarker_09_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_09_HasDuration = Stream.Read.Byte();
                    if (MapMarker_09_HasDuration != 0x00) {
                        MapMarker_09_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_09_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[10] == 0x00) {
                    MapMarker_0a_MarkerType = Stream.Read.UInt();
                    MapMarker_0a_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0a_EncounterId = Stream.Read.Entity();
                    MapMarker_0a_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0a_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0a_HasDuration != 0x00) {
                        MapMarker_0a_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0a_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[11] == 0x00) {
                    MapMarker_0b_MarkerType = Stream.Read.UInt();
                    MapMarker_0b_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0b_EncounterId = Stream.Read.Entity();
                    MapMarker_0b_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0b_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0b_HasDuration != 0x00) {
                        MapMarker_0b_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0b_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[12] == 0x00) {
                    MapMarker_0c_MarkerType = Stream.Read.UInt();
                    MapMarker_0c_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0c_EncounterId = Stream.Read.Entity();
                    MapMarker_0c_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0c_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0c_HasDuration != 0x00) {
                        MapMarker_0c_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0c_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[13] == 0x00) {
                    MapMarker_0d_MarkerType = Stream.Read.UInt();
                    MapMarker_0d_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0d_EncounterId = Stream.Read.Entity();
                    MapMarker_0d_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0d_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0d_HasDuration != 0x00) {
                        MapMarker_0d_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0d_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[14] == 0x00) {
                    MapMarker_0e_MarkerType = Stream.Read.UInt();
                    MapMarker_0e_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0e_EncounterId = Stream.Read.Entity();
                    MapMarker_0e_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0e_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0e_HasDuration != 0x00) {
                        MapMarker_0e_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0e_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[15] == 0x00) {
                    MapMarker_0f_MarkerType = Stream.Read.UInt();
                    MapMarker_0f_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_0f_EncounterId = Stream.Read.Entity();
                    MapMarker_0f_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_0f_HasDuration = Stream.Read.Byte();
                    if (MapMarker_0f_HasDuration != 0x00) {
                        MapMarker_0f_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_0f_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[16] == 0x00) {
                    MapMarker_10_MarkerType = Stream.Read.UInt();
                    MapMarker_10_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_10_EncounterId = Stream.Read.Entity();
                    MapMarker_10_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_10_HasDuration = Stream.Read.Byte();
                    if (MapMarker_10_HasDuration != 0x00) {
                        MapMarker_10_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_10_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[17] == 0x00) {
                    MapMarker_11_MarkerType = Stream.Read.UInt();
                    MapMarker_11_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_11_EncounterId = Stream.Read.Entity();
                    MapMarker_11_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_11_HasDuration = Stream.Read.Byte();
                    if (MapMarker_11_HasDuration != 0x00) {
                        MapMarker_11_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_11_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[18] == 0x00) {
                    MapMarker_12_MarkerType = Stream.Read.UInt();
                    MapMarker_12_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_12_EncounterId = Stream.Read.Entity();
                    MapMarker_12_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_12_HasDuration = Stream.Read.Byte();
                    if (MapMarker_12_HasDuration != 0x00) {
                        MapMarker_12_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_12_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[19] == 0x00) {
                    MapMarker_13_MarkerType = Stream.Read.UInt();
                    MapMarker_13_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_13_EncounterId = Stream.Read.Entity();
                    MapMarker_13_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_13_HasDuration = Stream.Read.Byte();
                    if (MapMarker_13_HasDuration != 0x00) {
                        MapMarker_13_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_13_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[20] == 0x00) {
                    MapMarker_14_MarkerType = Stream.Read.UInt();
                    MapMarker_14_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_14_EncounterId = Stream.Read.Entity();
                    MapMarker_14_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_14_HasDuration = Stream.Read.Byte();
                    if (MapMarker_14_HasDuration != 0x00) {
                        MapMarker_14_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_14_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[21] == 0x00) {
                    MapMarker_15_MarkerType = Stream.Read.UInt();
                    MapMarker_15_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_15_EncounterId = Stream.Read.Entity();
                    MapMarker_15_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_15_HasDuration = Stream.Read.Byte();
                    if (MapMarker_15_HasDuration != 0x00) {
                        MapMarker_15_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_15_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[22] == 0x00) {
                    MapMarker_16_MarkerType = Stream.Read.UInt();
                    MapMarker_16_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_16_EncounterId = Stream.Read.Entity();
                    MapMarker_16_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_16_HasDuration = Stream.Read.Byte();
                    if (MapMarker_16_HasDuration != 0x00) {
                        MapMarker_16_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_16_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[23] == 0x00) {
                    MapMarker_17_MarkerType = Stream.Read.UInt();
                    MapMarker_17_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_17_EncounterId = Stream.Read.Entity();
                    MapMarker_17_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_17_HasDuration = Stream.Read.Byte();
                    if (MapMarker_17_HasDuration != 0x00) {
                        MapMarker_17_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_17_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[24] == 0x00) {
                    MapMarker_18_MarkerType = Stream.Read.UInt();
                    MapMarker_18_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_18_EncounterId = Stream.Read.Entity();
                    MapMarker_18_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_18_HasDuration = Stream.Read.Byte();
                    if (MapMarker_18_HasDuration != 0x00) {
                        MapMarker_18_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_18_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[25] == 0x00) {
                    MapMarker_19_MarkerType = Stream.Read.UInt();
                    MapMarker_19_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_19_EncounterId = Stream.Read.Entity();
                    MapMarker_19_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_19_HasDuration = Stream.Read.Byte();
                    if (MapMarker_19_HasDuration != 0x00) {
                        MapMarker_19_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_19_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[26] == 0x00) {
                    MapMarker_1a_MarkerType = Stream.Read.UInt();
                    MapMarker_1a_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1a_EncounterId = Stream.Read.Entity();
                    MapMarker_1a_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1a_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1a_HasDuration != 0x00) {
                        MapMarker_1a_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1a_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[27] == 0x00) {
                    MapMarker_1b_MarkerType = Stream.Read.UInt();
                    MapMarker_1b_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1b_EncounterId = Stream.Read.Entity();
                    MapMarker_1b_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1b_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1b_HasDuration != 0x00) {
                        MapMarker_1b_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1b_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[28] == 0x00) {
                    MapMarker_1c_MarkerType = Stream.Read.UInt();
                    MapMarker_1c_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1c_EncounterId = Stream.Read.Entity();
                    MapMarker_1c_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1c_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1c_HasDuration != 0x00) {
                        MapMarker_1c_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1c_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[29] == 0x00) {
                    MapMarker_1d_MarkerType = Stream.Read.UInt();
                    MapMarker_1d_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1d_EncounterId = Stream.Read.Entity();
                    MapMarker_1d_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1d_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1d_HasDuration != 0x00) {
                        MapMarker_1d_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1d_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[30] == 0x00) {
                    MapMarker_1e_MarkerType = Stream.Read.UInt();
                    MapMarker_1e_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1e_EncounterId = Stream.Read.Entity();
                    MapMarker_1e_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1e_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1e_HasDuration != 0x00) {
                        MapMarker_1e_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1e_Position = Stream.Read.HalfArray(3);
                }

                if (Bitfield_MarkerData[31] == 0x00) {
                    MapMarker_1f_MarkerType = Stream.Read.UInt();
                    MapMarker_1f_Unk3 = Stream.Read.ByteArray(6);
                    MapMarker_1f_EncounterId = Stream.Read.Entity();
                    MapMarker_1f_EncounterMarkerId = Stream.Read.Entity();
                    MapMarker_1f_HasDuration = Stream.Read.Byte();
                    if (MapMarker_1f_HasDuration != 0x00) {
                        MapMarker_1f_ExpireAtTime = Stream.Read.UInt();
                    }
                    MapMarker_1f_Position = Stream.Read.HalfArray(3);
                }
            }
            
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
            
        public enum Controller : byte
        {
            Generic = 0x00,
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            TinyObjectType = 0x29,
            CharacterAbilityPhysics = 0x2a,
            ProjectileObjectType = 0x2b,
            Outpost = 0x2c,
            ResourceArea = 0x2e,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
            LootStoreExtension = 0x34,
            TeamManager = 0x36,
        }
        
        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            if (controller == 0 && id == 0) return "None";
            return $"{controller}:{id}";
        }

        public static string[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }
    }
}