using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
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

    [Script(MessageType.GSS, 8, 3, true)]
    public class CharacterObserverViewKeyframe : BaseScript
    {
        public byte[] Unk_Contents;

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
        // --        
        public byte[] Unk4;
        // --
        
        public string ArmyTag;

        // Beyond here it will not match well for NPCs
        // This section needs some work, too many varied length unks

        public uint Time1;
        public byte EffectsFlag;
        public byte[] Unk5;
        public uint Time2;
        public byte[] Unk6;
        public byte CharacterState;
        public uint CharacterStateTime;
        public byte[] Faction; // Left Byte is Mode: 1 = Factions, 2 = Teams. Right byte is the Faction or Team Id respectively.
        public byte[] Unk7;

        public byte[] Unk9;
        public byte HealthPercent;
        public uint HealthMax;
        public uint HealthTime;
        public ushort EmoteId; // Sdb table 73, id column
        public uint EmoteTime;

        public byte[] Mounted_Unk_VehicleEntity1; // Couldnt get this to actually work in the client
        public byte[] Mounted_Unk_VehicleEntity2;
        public byte[] Mounted_Unk_Bytes;

        public byte Unk11;
        public ulong ArmyGUID;

        public byte[] Unk_Remaining;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;


            if (true)
            {
                Unk_Contents = Stream.Read.ByteArray(4);
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
                Time1 = Stream.Read.UInt();
                EffectsFlag = Stream.Read.Byte();
                Unk5 = Stream.Read.ByteArray(4);
                Time2 = Stream.Read.UInt();
                Unk6 = Stream.Read.ByteArray(4);
                CharacterState = Stream.Read.Byte();
                CharacterStateTime = Stream.Read.UInt();
                Faction = Stream.Read.ByteArray(2);
                if (IsNpc == 0x00)
                {
                    Unk7 = Stream.Read.ByteArray(5*4);
                }
                HealthPercent = Stream.Read.Byte();
                HealthMax = Stream.Read.UInt();
                HealthTime = Stream.Read.UInt();
                EmoteId = Stream.Read.UShort();
                EmoteTime = Stream.Read.UInt();
                //byte LookaheadVehicle = Stream.Read.Byte();
                //Stream.baseStream.ByteOffset -= 1;
                //if (LookaheadVehicle > 0)
                //{
                //    Mounted_Unk_VehicleEntity1 = Stream.Read.ByteArray(8);
                //    Mounted_Unk_VehicleEntity2 = Stream.Read.ByteArray(8);
                //    Mounted_Unk_Bytes = Stream.Read.ByteArray(3);
                //}
                Unk11 = Stream.Read.Byte();
                ArmyGUID = Stream.Read.ULong();
                /*
                */
                
                int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                Unk_Remaining = Stream.Read.ByteArray(remaining);
            }
        }
    }
}