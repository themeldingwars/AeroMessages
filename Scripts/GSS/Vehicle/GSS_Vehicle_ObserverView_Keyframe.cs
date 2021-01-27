using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 29, 3, true)]
    public class VehicleObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            PersonalFactionStance,
            SinFactionsAcquiredBy,
            SinTeamsAcquiredBy,
            SinCardFields_0,
            SinCardFields_1,
            SinCardFields_2,
            SinCardFields_3,
            SinCardFields_4,
            SinCardFields_5,
            SinCardFields_6,
            SinCardFields_7,
            SinCardFields_8,
            SinCardFields_9,
            SinCardFields_10,
            SinCardFields_11,
            SinCardFields_12,
            SinCardFields_13,
            SinCardFields_14,
            SinCardFields_15,
            SinCardFields_16,
            SinCardFields_17,
            SinCardFields_18,
            SinCardFields_19,
            SinCardFields_20,
            SinCardFields_21,
            SinCardFields_22,
        }

        public string Warning;

        public byte[] Bitfield;
        public ushort VehicleType; // 0x00, Sdb table 47, id column.
        public byte[] Configuration;
        public byte[] Flags;
        public byte EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        public byte PathState;
        public byte[] OwnerId; // 0x05
        public string OwnerName;
        public uint OwnerLocalString;
        public byte[] OccupantIds_0; // 0x08
        public byte[] OccupantIds_1; // 0x09
        public byte[] OccupantIds_2; // 0x0a
        public byte[] OccupantIds_3; // 0x0b
        public byte[] OccupantIds_4; // 0x0c
        public byte[] OccupantIds_5; // 0x0d
        public byte[] DeployableIds_0;
        public byte[] DeployableIds_1;
        public byte[] DeployableIds_2;
        public byte[] DeployableIds_3;
        public byte[] DeployableIds_4;
        public byte[] DeployableIds_5;
        public byte[] DeployableIds_6;
        public byte[] DeployableIds_7;
        public byte[] DeployableIds_8;
        public byte[] DeployableIds_9;
        public byte SnapMount;
        public uint ProcessDelay;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public uint CurrentHealth;
        public uint MaxHealth;
        public uint CurrentShields;
        public uint MaxShields;
        public byte SinFlags;
        public byte SinFlagsPrivate;
        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;
        public byte WaterLevelAndDesc;
        public byte EffectsFlags;
        public uint SinCardType;
        public byte[] ScopeBubbleInfo;
        public uint ScalingLevel;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield = Stream.Read.BitArray(32);
                VehicleType = Stream.Read.UShort();
                Configuration = Stream.Read.ByteArray(32);
                Flags = Stream.Read.ByteArray(4);
                EngineState = Stream.Read.Byte();
                PathState = Stream.Read.Byte();
                OwnerId = Stream.Read.ByteArray(8);
                OwnerName = Stream.Read.StringZ(Stream);
                OwnerLocalString = Stream.Read.UInt();
                OccupantIds_0 = Stream.Read.ByteArray(8);
                OccupantIds_1 = Stream.Read.ByteArray(8);
                OccupantIds_2 = Stream.Read.ByteArray(8);
                OccupantIds_3 = Stream.Read.ByteArray(8);
                OccupantIds_4 = Stream.Read.ByteArray(8);
                OccupantIds_5 = Stream.Read.ByteArray(8);
                DeployableIds_0 = Stream.Read.ByteArray(13);
                DeployableIds_1 = Stream.Read.ByteArray(13);
                DeployableIds_2 = Stream.Read.ByteArray(13);
                DeployableIds_3 = Stream.Read.ByteArray(13);
                DeployableIds_4 = Stream.Read.ByteArray(13);
                DeployableIds_5 = Stream.Read.ByteArray(13);
                DeployableIds_6 = Stream.Read.ByteArray(13);
                DeployableIds_7 = Stream.Read.ByteArray(13);
                DeployableIds_8 = Stream.Read.ByteArray(13);
                DeployableIds_9 = Stream.Read.ByteArray(13);
                SnapMount = Stream.Read.Byte();
                ProcessDelay = Stream.Read.UInt();
                HostilityInfo = Stream.Read.ByteArray(2);

                if (Bitfield[(int)BitfieldIndex.PersonalFactionStance] == 0)
                {
                    PersonalFactionStance = Stream.Read.ByteArray(5*4);
                }

                CurrentHealth = Stream.Read.UInt();
                MaxHealth = Stream.Read.UInt();
                CurrentShields = Stream.Read.UInt();
                MaxShields = Stream.Read.UInt();
                SinFlags = Stream.Read.Byte();
                if (Bitfield[(int)BitfieldIndex.SinFactionsAcquiredBy] == 0)
                {
                    SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                }

                if (Bitfield[(int)BitfieldIndex.SinTeamsAcquiredBy] == 0)
                {
                    SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                }
                WaterLevelAndDesc = Stream.Read.Byte();
                EffectsFlags = Stream.Read.Byte();

                SinCardType = Stream.Read.UInt();

                if (Bitfield[(int)BitfieldIndex.SinCardFields_0] == 0)
                {
                    Warning += "SinCardFields_0;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_1] == 0)
                {
                    Warning += "SinCardFields_1;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_2] == 0)
                {
                    Warning += "SinCardFields_2;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_3] == 0)
                {
                    Warning += "SinCardFields_3;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_4] == 0)
                {
                    Warning += "SinCardFields_4;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_5] == 0)
                {
                    Warning += "SinCardFields_5;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_6] == 0)
                {
                    Warning += "SinCardFields_6;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_7] == 0)
                {
                    Warning += "SinCardFields_7;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_8] == 0)
                {
                    Warning += "SinCardFields_8;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_9] == 0)
                {
                    Warning += "SinCardFields_9;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_10] == 0)
                {
                    Warning += "SinCardFields_10;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_11] == 0)
                {
                    Warning += "SinCardFields_11;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_12] == 0)
                {
                    Warning += "SinCardFields_12;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_13] == 0)
                {
                    Warning += "SinCardFields_13;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_14] == 0)
                {
                    Warning += "SinCardFields_14;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_15] == 0)
                {
                    Warning += "SinCardFields_15;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_16] == 0)
                {
                    Warning += "SinCardFields_16;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_17] == 0)
                {
                    Warning += "SinCardFields_17;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_18] == 0)
                {
                    Warning += "SinCardFields_18;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_19] == 0)
                {
                    Warning += "SinCardFields_19;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_20] == 0)
                {
                    Warning += "SinCardFields_20;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_21] == 0)
                {
                    Warning += "SinCardFields_21;";
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_22] == 0)
                {
                    Warning += "SinCardFields_22;";
                }
                ScopeBubbleInfo = Stream.Read.ByteArray(8);
                ScalingLevel = Stream.Read.UInt();
            }
        }
    }

    public static class MyExtensions
    {
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