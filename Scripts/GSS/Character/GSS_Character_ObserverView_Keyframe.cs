using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 3, true)]
    public class CharacterObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            PersonalFactionStance,
            AttachedTo,
            SinFactionsAcquiredBy,
            SinTeamsAcquiredBy,
            LookAtTarget,
            CarryableObjects_0,
            CarryableObjects_1,
            CarryableObjects_2,
            RespawnTimes,
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

        // -- Begin StaticInfo --
        public string DisplayName;
        public string UniqueName;
        public byte Gender;
        public byte Race;

        public uint CharInfoId; // Sdb table 240
        public uint Head;
        public uint Eyes;

        public byte Unk2;

        public byte IsNpc;
        public byte StaffFlags;
        public uint CharacterTypeId; // Sdb table 280

        public uint Voice;
        public ushort TitleId;

        public uint NameLocalizationId; // Sdb table 31
        public byte NumberOfHeadAccessories;
        public uint[] HeadAccessories;

        public uint Vehicle;
        public uint Glider;

        public byte[] Unk3;

        public byte NumberOfCharacterVisualsDecals;
        public DecalData[] Character_Visuals_Decals;

        public byte NumberOfCharacterVisualsDecalGradients;
        public DecalGradientData[] Character_Visuals_DecalGradients;

        public byte NumberOfCharacterVisualsColors;
        public ColorData[] Character_Visuals_Colors;

        public byte NumberOfCharacterVisualsPalettes;
        public PaletteData[] Character_Visuals_Palettes;

        public byte NumberOfCharacterVisualsPatterns;
        public PatternData[] Character_Visuals_Patterns;

        public byte NumberOfCharacterVisualsOrnaments;
        public uint[] Character_Visuals_Ornaments;
        public byte[] Unk4;
        public string ArmyTag;
        // -- End StaticInfo? -- 

        // Beyond here it will not match well for NPCs
        // This section needs some work, too many varied length unks

        public uint SpawnTime;
        public byte EffectsFlags;
        public uint GibVisualsID;
        public uint GibVisualsID_Time;
        public uint ProcessDelay;
        public byte CharacterState;
        public uint CharacterState_Time;
        public byte[] HostilityInfo; // Left Byte is Mode: 1 = Factions, 2 = Teams. Right byte is the Faction or Team Id respectively.

        public byte[] PersonalFactionStance;

        public byte CurrentHealthPct;
        public uint MaxHealth;
        public uint MaxHealth_Time;
        public ushort EmoteID; // Sdb table 73, id column
        public uint EmoteID_Time;

        public byte[] AttachedTo_VehicleEntity1;
        public byte[] AttachedTo_VehicleEntity2;
        public byte[] AttachedTo_Bytes;

        public byte SnapMount; // guess
        public byte SinFlags; // guess

        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;

        public ulong ArmyGUID;
        public ulong OwnerId;
        public uint NPCType; // guess
        public byte[] DockedParams; // guess

        public byte[] LookAtTarget_TargetId;
        public float[] LookAtTarget_Position;
        public byte[] LookAtTarget_UnkBytes;

        public byte WaterLevelAndDesc;

        // CarryableObjects_0      = 0x16,
        // CarryableObjects_1      = 0x17,
        // CarryableObjects_2      = 0x18,

        public uint? RespawnTimes_Time1;
        public uint? RespawnTimes_Time2;

        public uint SinCardType;

        // SinCardFields_0 
        // SinCardFields_1 
        // SinCardFields_2 
        // SinCardFields_3 
        // SinCardFields_4 
        // SinCardFields_5 
        // SinCardFields_6 
        // SinCardFields_7 
        // SinCardFields_8 
        // SinCardFields_9 
        // SinCardFields_10
        // SinCardFields_11
        // SinCardFields_12
        // SinCardFields_13
        // SinCardFields_14
        // SinCardFields_15
        // SinCardFields_16
        // SinCardFields_17
        // SinCardFields_18
        // SinCardFields_19
        // SinCardFields_20
        // SinCardFields_21
        // SinCardFields_22

        public byte AssetOverrides;

        public byte[] Unk_Remaining;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true)
            {
                Bitfield = Stream.Read.BitArray(32);

                // Static Info Begin
                DisplayName = Stream.Read.StringZ(Stream);
                UniqueName = Stream.Read.StringZ(Stream);

                Gender = Stream.Read.Byte();
                Race = Stream.Read.Byte();
                CharInfoId = Stream.Read.UInt();
                Head = Stream.Read.UInt();
                Eyes = Stream.Read.UInt();
                Unk2 = Stream.Read.Byte();
                IsNpc = Stream.Read.Byte();
                StaffFlags = Stream.Read.Byte(); // 1=dev,2=mentor,4=ranger,8=publisher
                CharacterTypeId = Stream.Read.UInt();
                Voice = Stream.Read.UInt();
                TitleId = Stream.Read.UShort();
                NameLocalizationId = Stream.Read.UInt();
                NumberOfHeadAccessories = Stream.Read.Byte();
                if (NumberOfHeadAccessories > 0)
                {
                    HeadAccessories = Stream.Read.UIntArray(NumberOfHeadAccessories);
                }
                Vehicle = Stream.Read.UInt();
                Glider = Stream.Read.UInt();

                NumberOfCharacterVisualsDecals = Stream.Read.Byte();
                Character_Visuals_Decals = Stream.Read.DecalDataArray(NumberOfCharacterVisualsDecals);

                NumberOfCharacterVisualsDecalGradients = Stream.Read.Byte();
                Character_Visuals_DecalGradients = Stream.Read.DecalGradientDataArray(NumberOfCharacterVisualsDecalGradients);
                
                NumberOfCharacterVisualsColors = Stream.Read.Byte();
                Character_Visuals_Colors = Stream.Read.ColorDataArray(NumberOfCharacterVisualsColors);
                NumberOfCharacterVisualsPalettes = Stream.Read.Byte();
                Character_Visuals_Palettes = Stream.Read.PaletteDataArray(NumberOfCharacterVisualsPalettes);
                NumberOfCharacterVisualsPatterns = Stream.Read.Byte();
                Character_Visuals_Patterns = Stream.Read.PatternDataArray( NumberOfCharacterVisualsPatterns);
                NumberOfCharacterVisualsOrnaments = Stream.Read.Byte();
                Character_Visuals_Ornaments = Stream.Read.UIntArray(NumberOfCharacterVisualsOrnaments);
                Unk4 = Stream.Read.ByteArray(3);
                ArmyTag = Stream.Read.StringZ(Stream);
                // Static Info End

                SpawnTime = Stream.Read.UInt();
                EffectsFlags = Stream.Read.Byte();
                GibVisualsID = Stream.Read.UInt();
                GibVisualsID_Time = Stream.Read.UInt();
                ProcessDelay = Stream.Read.UInt();
                CharacterState = Stream.Read.Byte();
                CharacterState_Time = Stream.Read.UInt();
                HostilityInfo = Stream.Read.ByteArray(2);

                if (Bitfield[(int)BitfieldIndex.PersonalFactionStance] == 0)
                {
                    PersonalFactionStance = Stream.Read.ByteArray(5*4);
                }
                CurrentHealthPct = Stream.Read.Byte();
                MaxHealth = Stream.Read.UInt();
                MaxHealth_Time = Stream.Read.UInt();
                EmoteID = Stream.Read.UShort();
                EmoteID_Time = Stream.Read.UInt();

                if (Bitfield[(int)BitfieldIndex.AttachedTo] == 0)
                {
                    AttachedTo_VehicleEntity1 = Stream.Read.ByteArray(8);
                    AttachedTo_VehicleEntity2 = Stream.Read.ByteArray(8);
                    AttachedTo_Bytes = Stream.Read.ByteArray(3);
                }
                
                SnapMount = Stream.Read.Byte();
                SinFlags = Stream.Read.Byte();

                if (Bitfield[(int)BitfieldIndex.SinFactionsAcquiredBy] == 0)
                {
                    SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                }

                if (Bitfield[(int)BitfieldIndex.SinTeamsAcquiredBy] == 0)
                {
                    SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                }
                
                ArmyGUID = Stream.Read.ULong();
                OwnerId = Stream.Read.ULong();
                
                NPCType = Stream.Read.UInt();
                DockedParams = Stream.Read.ByteArray(19);

                if (Bitfield[(int)BitfieldIndex.LookAtTarget] == 0)
                {
                    LookAtTarget_TargetId = Stream.Read.ByteArray(8);
                     LookAtTarget_Position = Stream.Read.FloatArray(3);
                     LookAtTarget_UnkBytes = Stream.Read.ByteArray(4);
                }
       
                WaterLevelAndDesc = Stream.Read.Byte();

       
                if (Bitfield[(int)BitfieldIndex.CarryableObjects_0] == 0)
                {
                    Warning += "CarryableObjects_0;";
                }
                if (Bitfield[(int)BitfieldIndex.CarryableObjects_1] == 0)
                {
                    Warning += "CarryableObjects_1;";
                }
                if (Bitfield[(int)BitfieldIndex.CarryableObjects_2] == 0)
                {
                    Warning += "CarryableObjects_2;";
                }

                // RespawnTimes Bitfield
                if (Bitfield[(int)BitfieldIndex.RespawnTimes] == 0)
                {
                    RespawnTimes_Time1 = Stream.Read.UInt();
                    RespawnTimes_Time2 = Stream.Read.UInt();
                }

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

                // AssetOverrides 
                AssetOverrides = Stream.Read.Byte();

                int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                if (remaining > 0) {
                    Unk_Remaining = Stream.Read.ByteArray(remaining);
                }
            }
        }
    }

    // (4 byte id, 4 byte color, 12*2 half transform, 1 byte "usage")
    public struct DecalData
    {
        public uint SdbId;
        public uint Color;
        public float[] HalfTransform;
        public byte Usage;

        public DecalData(Bitter.BinaryReader R)
        {
            SdbId = R.UInt();
            Color = R.UInt();
            HalfTransform = R.HalfArray(12);
            Usage = R.Byte();

        }

        public override string ToString() => $"SdbId: {SdbId}, Color: {Color}, HalfTransform: [{(HalfTransform != null ? String.Join(", ", HalfTransform) : "null")}], Usage: {Usage}";
    }

    public struct DecalGradientData
    {
        public uint Unk;

        public DecalGradientData(Bitter.BinaryReader R)
        {
            Unk = R.UInt();
        }

        public override string ToString() => $"?";
    }

    // 4 byte color
    public struct ColorData
    {
        public uint Color;

        public ColorData(Bitter.BinaryReader R)
        {
            Color = R.UInt();
        }

        public override string ToString() => $"Color: {Color}";
    }

    // (1 byte type, 4 byte id)
    public struct PaletteData
    {
        public byte Type;
        public uint SdbId;

        public PaletteData(Bitter.BinaryReader R)
        {
            Type = R.Byte();
            SdbId = R.UInt();
        }

        public override string ToString() => $"Type: {Type}, SdbId: {SdbId}";
    }

    // (4 byte id,  4*2 byte transform (halfs), 1 byte "usage")
    public struct PatternData
    {
        public uint SdbId;
        public float[] HalfTransform;
        public byte Usage;

        public PatternData(Bitter.BinaryReader R)
        {
            SdbId = R.UInt();
            HalfTransform = R.HalfArray(4);
            Usage = R.Byte();
        }

        public override string ToString() => $"SdbId: {SdbId}, HalfTransform: [{(HalfTransform != null ? String.Join(", ", HalfTransform) : "null")}], Usage: {Usage}";
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

        public static DecalData DecalData(this Bitter.BinaryReader R)
        {
            return new DecalData(R);
        }

        public static DecalData[] DecalDataArray(this Bitter.BinaryReader R, int num)
        {
            List<DecalData> list = new List<DecalData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.DecalData());
            }
            return list.ToArray();
        }

        public static DecalGradientData DecalGradientData(this Bitter.BinaryReader R)
        {
            return new DecalGradientData(R);
        }

        public static DecalGradientData[] DecalGradientDataArray(this Bitter.BinaryReader R, int num)
        {
            List<DecalGradientData> list = new List<DecalGradientData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.DecalGradientData());
            }
            return list.ToArray();
        }

        public static ColorData ColorData(this Bitter.BinaryReader R)
        {
            return new ColorData(R);
        }

        public static ColorData[] ColorDataArray(this Bitter.BinaryReader R, int num)
        {
            List<ColorData> list = new List<ColorData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ColorData());
            }
            return list.ToArray();
        }

        public static PaletteData PaletteData(this Bitter.BinaryReader R)
        {
            return new PaletteData(R);
        }

        public static PaletteData[] PaletteDataArray(this Bitter.BinaryReader R, int num)
        {
            List<PaletteData> list = new List<PaletteData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.PaletteData());
            }
            return list.ToArray();
        }

        public static PatternData PatternData(this Bitter.BinaryReader R)
        {
            return new PatternData(R);
        }

        public static PatternData[] PatternDataArray(this Bitter.BinaryReader R, int num)
        {
            List<PatternData> list = new List<PatternData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.PatternData());
            }
            return list.ToArray();
        }
    }
}