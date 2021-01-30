using Bitter;
using System;
using System.Collections.Generic;
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

        public string PeepWarning;

        public byte[] Bitfield;
        public ushort VehicleType; // 0x00, Sdb table 47, id column.
        public byte[] Configuration;
        public byte[] Flags;
        public byte EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        public byte PathState;
        public string OwnerId; // 0x05
        public string OwnerName;
        public uint OwnerLocalString;
        public string OccupantIds_0; // 0x08
        public string OccupantIds_1; // 0x09
        public string OccupantIds_2; // 0x0a
        public string OccupantIds_3; // 0x0b
        public string OccupantIds_4; // 0x0c
        public string OccupantIds_5; // 0x0d
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
        public SinCardField SinCardFields_0;
        public SinCardField SinCardFields_1;
        public SinCardField SinCardFields_2;
        public SinCardField SinCardFields_3;
        public SinCardField SinCardFields_4;
        public SinCardField SinCardFields_5;
        public SinCardField SinCardFields_6;
        public SinCardField SinCardFields_7;
        public SinCardField SinCardFields_8;
        public SinCardField SinCardFields_9;
        public SinCardField SinCardFields_10;
        public SinCardField SinCardFields_11;
        public SinCardField SinCardFields_12;
        public SinCardField SinCardFields_13;
        public SinCardField SinCardFields_14;
        public SinCardField SinCardFields_15;
        public SinCardField SinCardFields_16;
        public SinCardField SinCardFields_17;
        public SinCardField SinCardFields_18;
        public SinCardField SinCardFields_19;
        public SinCardField SinCardFields_20;
        public SinCardField SinCardFields_21;
        public SinCardField SinCardFields_22;
        public byte[] ScopeBubbleInfo;
        public uint ScalingLevel;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield = Stream.Read.BitArray(32);
                VehicleType = Stream.Read.UShort();
                Configuration = Stream.Read.ByteArray(32);
                Flags = Stream.Read.ByteArray(4);
                EngineState = Stream.Read.Byte();
                PathState = Stream.Read.Byte();
                OwnerId = Stream.Read.Entity();
                OwnerName = Stream.Read.StringZ();
                OwnerLocalString = Stream.Read.UInt();
                OccupantIds_0 = Stream.Read.Entity();
                OccupantIds_1 = Stream.Read.Entity();
                OccupantIds_2 = Stream.Read.Entity();
                OccupantIds_3 = Stream.Read.Entity();
                OccupantIds_4 = Stream.Read.Entity();
                OccupantIds_5 = Stream.Read.Entity();
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
                    SinCardFields_0 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_1] == 0)
                {
                    SinCardFields_1 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_2] == 0)
                {
                    SinCardFields_2 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_3] == 0)
                {
                    SinCardFields_3 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_4] == 0)
                {
                    SinCardFields_4 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_5] == 0)
                {
                    SinCardFields_5 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_6] == 0)
                {
                    SinCardFields_6 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_7] == 0)
                {
                  SinCardFields_7 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_8] == 0)
                {
                    SinCardFields_8 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_9] == 0)
                {
                    SinCardFields_9 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_10] == 0)
                {
                    SinCardFields_10 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_11] == 0)
                {
                    SinCardFields_11 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_12] == 0)
                {
                    SinCardFields_12 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_13] == 0)
                {
                    SinCardFields_13 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_14] == 0)
                {
                    SinCardFields_14 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_15] == 0)
                {
                    SinCardFields_15 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_16] == 0)
                {
                    SinCardFields_16 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_17] == 0)
                {
                    SinCardFields_17 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_18] == 0)
                {
                    SinCardFields_18 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_19] == 0)
                {
                    SinCardFields_19 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_20] == 0)
                {
                    SinCardFields_20 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_21] == 0)
                {
                    SinCardFields_21 = Stream.Read.SinCardField();
                }
                if (Bitfield[(int)BitfieldIndex.SinCardFields_22] == 0)
                {
                    SinCardFields_22 = Stream.Read.SinCardField();
                }
                ScopeBubbleInfo = Stream.Read.ByteArray(8);
                ScalingLevel = Stream.Read.UInt();
            }
        }
    }

    public struct SinCardField
    {
        public enum SinCardFieldDataType : byte
        {
            LocalizationId = 0, // 4 bytes
            Integer = 1, // 4 bytes
            EntityId = 2, // 8 bytes
            UnkType_3 = 3, // 8 bytes
            Enum = 4, // stringz
            UnkType_5 = 5, // ?
            Short = 6, // 2 bytes
            Timer = 7, // 9 bytes
            Boolean = 8, // 0 bytes???
        }

        public SinCardFieldDataType DataType;

        public uint LocalizationId;
        public uint Integer;
        public string EntityId;
        public string Enum;
        public ushort Short;

        public byte[] UnkData;


        public SinCardField(Bitter.BinaryReader R)
        {
            // Sigh
            LocalizationId = 0;
            Integer = 0;
            EntityId = null;
            Enum = "";
            Short = 0;
            UnkData = null;

            // Parse
            DataType = (SinCardFieldDataType) R.Byte();

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    LocalizationId = R.UInt();
                    break;
                case SinCardFieldDataType.Integer:
                    Integer = R.UInt();
                    break;
                case SinCardFieldDataType.EntityId:
                    EntityId = R.Entity();
                    break;
                case SinCardFieldDataType.Enum:
                    Enum = R.StringZ();
                    break;
                case SinCardFieldDataType.Short:
                    Short = R.UShort();
                    break;
                case SinCardFieldDataType.Timer:
                    UnkData = R.ByteArray(9);
                    break;
            }
        }

        public override string ToString()
        {
            string result = $"{DataType}: ";

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    result += $"{LocalizationId}";
                    break;
                case SinCardFieldDataType.Integer:
                    result += $"{Integer}";
                    break;
                case SinCardFieldDataType.EntityId:
                    result += $"{EntityId}";
                    break;
                case SinCardFieldDataType.Enum:
                    result += $"{Enum}";
                    break;
                case SinCardFieldDataType.Short:
                    result += $"{Short}";
                    break;
                case SinCardFieldDataType.Timer:
                    result += $"[{(UnkData != null ? String.Join(", ", UnkData) : "null")}]";
                    break;
            }

            return result;
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

        public static SinCardField SinCardField(this Bitter.BinaryReader R)
        {
            return new SinCardField(R);
        }

        public static SinCardField[] SinCardFieldArray(this Bitter.BinaryReader R, int num)
        {
            List<SinCardField> list = new List<SinCardField>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.SinCardField());
            }
            return list.ToArray();
        }

    }
}