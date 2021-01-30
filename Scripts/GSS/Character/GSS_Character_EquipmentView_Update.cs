using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 9, 1, true)]
    public class CharacterEquipmentViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            VisualOverrides = 0x00,
            CurrentEquipment = 0x01,
            Level = 0x02,
            EffectiveLevel = 0x03,
            LevelResetCount = 0x04,
            CurrentDurabilityPct = 0x05,
            CharacterStats = 0x06,
            ScalingLevel = 0x07,
            PvPRank = 0x08,
            EliteLevel = 0x09,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield
        
        // VisualOverrides, references a visual group?
        public byte VisualOverrides_HaveData;
        public byte VisualOverrides_UnkByte;
        public uint VisualOverrides_VisualsGroupId;
        
        // -- CurrentEquipment --
            // Chassis
            public EquippedItemData Chassis;
            public byte NumberOfChassisModules;
            public EquippedItemData[] Chassis_Modules; // Gear, 4 byte id, 3 byte unk item data 
            
            // Chassis Visuals
            public byte NumberOfChassisVisualsDecals;
            public DecalData[] Chassis_Visuals_Decals;

            public byte NumberOfChassisVisualsUnk1;
            public byte[] Chassis_Visuals_Unk1_Data; // (idk if this is right, parsing as 4 byte int)

            public byte NumberOfChassisVisualsColors;
            public ColorData[] Chassis_Visuals_Colors;

            public byte NumberOfChassisVisualsPalettes;
            public PaletteData[] Chassis_Visuals_Palettes;

            public byte NumberOfChassisVisualsPatterns;
            public PatternData[] Chassis_Visuals_Patterns;
            // --

            public byte[] CurrentEquipment_Unk2;

            public EquippedItemData Backpack; // Reactor
            public byte NumberOfBackpackModules;
            public EquippedItemData[] Backpack_Modules;

            public byte[] CurrentEquipment_Unk3;

            public uint PrimaryWeapon;
            public byte[] Unk_PrimaryWeapon_ItemData;
            public byte NumberOfPrimaryWeaponVisualsColors;
            public ColorData[] PrimaryWeapon_Visuals_Colors;
            public byte NumberOfPrimaryWeaponVisualsPalettes;
            public PaletteData[] PrimaryWeapon_Visuals_Palettes;
            public byte NumberOfPrimaryWeaponVisualsPatterns;
            public PatternData[] PrimaryWeapon_Visuals_Patterns; 
            public byte NumberOfPrimaryWeaponVisualsOrnaments;
            public uint[] PrimaryWeapon_Visuals_Ornaments;

            public byte[] CurrentEquipment_Unk4;

            public uint SecondaryWeapon;
            public byte[] Unk_SecondaryWeapon_ItemData;
            public byte NumberOfSecondaryWeaponVisualsColors;
            public ColorData[] SecondaryWeapon_Visuals_Colors;
            public byte NumberOfSecondaryWeaponVisualsPalettes;
            public PaletteData[] SecondaryWeapon_Visuals_Palettes;
            public byte NumberOfSecondaryWeaponVisualsPatterns;
            public PatternData[] SecondaryWeapon_Visuals_Patterns;
            public byte NumberOfSecondaryWeaponVisualsOrnaments;
            public uint[] SecondaryWeapon_Visuals_Ornaments;

            public byte[] CurrentEquipment_Unk5;
        // -- --

        public byte Level;
        public byte EffectiveLevel;
        public byte LevelResetCount;
        public byte CurrentDurabilityPct;

        // -- CharacterStats --
            public ushort NumberOfItemAttributeCharacterStats;
            public StatData[] ItemAttribute_CharacterStats; // (6 byte, ushort id, float value)
            public byte[] CharacterStats_Unk7;
            public ushort NumberOfPrimaryWeaponCharacterStats;
            public StatData[] PrimaryWeapon_CharacterStats;
            public byte[] CharacterStats_Unk8;
            public ushort NumberOfSecondaryWeaponCharacterStats;
            public StatData[] SecondaryWeapon_CharacterStats;
            public byte[] CharacterStats_Unk9;
            public ushort NumberOfAttributeCategories1CharacterStats;
            public StatData[] AttributeCategories_1_CharacterStats; // Yeah, there are two.
            public ushort NumberOfAttributeCategories2CharacterStats;
            public StatData[] AttributeCategories_2_CharacterStats; // Maybe one for elite ranks and one for normal progression.
        // -- --

        public uint ScalingLevel;
        public uint PvP_Rank;
        public uint Elite_Rank;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
            
                    case ShadowFieldIndex.VisualOverrides:
                        VisualOverrides_HaveData = Stream.Read.Byte();
                        if (VisualOverrides_HaveData == 0x01)
                        {
                            VisualOverrides_UnkByte = Stream.Read.Byte();
                            VisualOverrides_VisualsGroupId = Stream.Read.UInt();
                        }
                        break;

                    case ShadowFieldIndex.CurrentEquipment:
                        Chassis = Stream.Read.EquippedItemData();
                        NumberOfChassisModules = Stream.Read.Byte();
                        Chassis_Modules = Stream.Read.EquippedItemDataArray(NumberOfChassisModules);
                        NumberOfChassisVisualsDecals = Stream.Read.Byte();
                        Chassis_Visuals_Decals = Stream.Read.DecalDataArray(NumberOfChassisVisualsDecals);

                        NumberOfChassisVisualsUnk1 = Stream.Read.Byte();
                        if (NumberOfChassisVisualsUnk1 > 0)
                        {
                            Chassis_Visuals_Unk1_Data = Stream.Read.ByteArray(4 * NumberOfChassisVisualsUnk1);
                        }

                        NumberOfChassisVisualsColors = Stream.Read.Byte();
                        Chassis_Visuals_Colors = Stream.Read.ColorDataArray(NumberOfChassisVisualsColors);

                        NumberOfChassisVisualsPalettes = Stream.Read.Byte();
                        Chassis_Visuals_Palettes = Stream.Read.PaletteDataArray(NumberOfChassisVisualsPalettes);

                        NumberOfChassisVisualsPatterns = Stream.Read.Byte();
                        Chassis_Visuals_Patterns = Stream.Read.PatternDataArray( NumberOfChassisVisualsPatterns);
                        CurrentEquipment_Unk2 = Stream.Read.ByteArray(4);
                        Backpack = Stream.Read.EquippedItemData();
                        NumberOfBackpackModules = Stream.Read.Byte();
                        Backpack_Modules = Stream.Read.EquippedItemDataArray(NumberOfBackpackModules);
                        CurrentEquipment_Unk3 = Stream.Read.ByteArray(9);
                        PrimaryWeapon = Stream.Read.UInt();

                        // TODO: Fix this, its fixed in the keyframe I think
                        Stream.baseStream.ByteOffset += 3;
                        byte LookaheadByte1 = Stream.Read.Byte(); 
                        Stream.baseStream.ByteOffset -= 4;
                        if (LookaheadByte1 != 0x00)
                        {
                            Unk_PrimaryWeapon_ItemData = Stream.Read.ByteArray(13);
                        }
                        else
                        {
                            Unk_PrimaryWeapon_ItemData = Stream.Read.ByteArray(6);
                        }

                        NumberOfPrimaryWeaponVisualsColors = Stream.Read.Byte();
                        PrimaryWeapon_Visuals_Colors = Stream.Read.ColorDataArray(NumberOfPrimaryWeaponVisualsColors);
                        
                        NumberOfPrimaryWeaponVisualsPalettes = Stream.Read.Byte();
                        PrimaryWeapon_Visuals_Palettes = Stream.Read.PaletteDataArray(NumberOfPrimaryWeaponVisualsPalettes);

                        NumberOfPrimaryWeaponVisualsPatterns = Stream.Read.Byte();
                        PrimaryWeapon_Visuals_Patterns = Stream.Read.PatternDataArray( NumberOfPrimaryWeaponVisualsPatterns);

                        NumberOfPrimaryWeaponVisualsOrnaments = Stream.Read.Byte();
                        PrimaryWeapon_Visuals_Ornaments = Stream.Read.UIntArray(NumberOfPrimaryWeaponVisualsOrnaments);

                        CurrentEquipment_Unk4 = Stream.Read.ByteArray(11);

                        SecondaryWeapon = Stream.Read.UInt();

                        Stream.baseStream.ByteOffset += 3;
                        byte LookaheadByte2 = Stream.Read.Byte(); 
                        Stream.baseStream.ByteOffset -= 4;
                        if (LookaheadByte2 != 0x00)
                        {
                            Unk_SecondaryWeapon_ItemData = Stream.Read.ByteArray(13);
                        }
                        else
                        {
                            Unk_SecondaryWeapon_ItemData = Stream.Read.ByteArray(6);
                        }

                        NumberOfSecondaryWeaponVisualsColors = Stream.Read.Byte();
                        SecondaryWeapon_Visuals_Colors = Stream.Read.ColorDataArray( NumberOfSecondaryWeaponVisualsColors);

                        NumberOfSecondaryWeaponVisualsPalettes = Stream.Read.Byte();
                        SecondaryWeapon_Visuals_Palettes = Stream.Read.PaletteDataArray( NumberOfSecondaryWeaponVisualsPalettes);

                        NumberOfSecondaryWeaponVisualsPatterns = Stream.Read.Byte();
                        SecondaryWeapon_Visuals_Patterns = Stream.Read.PatternDataArray( NumberOfSecondaryWeaponVisualsPatterns);

                        NumberOfSecondaryWeaponVisualsOrnaments = Stream.Read.Byte();
                        SecondaryWeapon_Visuals_Ornaments = Stream.Read.UIntArray(NumberOfSecondaryWeaponVisualsOrnaments);

                        CurrentEquipment_Unk5 = Stream.Read.ByteArray(11+5); // Not sure how much of this belongs to the weapon
                        break;

                    case ShadowFieldIndex.Level:
                        Level = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.EffectiveLevel:
                        EffectiveLevel = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.LevelResetCount:
                        LevelResetCount = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.CurrentDurabilityPct:
                        CurrentDurabilityPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.CharacterStats:
                        NumberOfItemAttributeCharacterStats = Stream.Read.UShort();
                        ItemAttribute_CharacterStats = Stream.Read.StatDataArray(NumberOfItemAttributeCharacterStats);
                        CharacterStats_Unk7 = Stream.Read.ByteArray(4);

                        NumberOfPrimaryWeaponCharacterStats = Stream.Read.UShort();
                        PrimaryWeapon_CharacterStats = Stream.Read.StatDataArray(NumberOfPrimaryWeaponCharacterStats);

                        CharacterStats_Unk8 = Stream.Read.ByteArray(4);

                        NumberOfSecondaryWeaponCharacterStats = Stream.Read.UShort();
                        SecondaryWeapon_CharacterStats = Stream.Read.StatDataArray(NumberOfSecondaryWeaponCharacterStats);
                        CharacterStats_Unk9 = Stream.Read.ByteArray(4);

                        NumberOfAttributeCategories1CharacterStats = Stream.Read.UShort();
                        AttributeCategories_1_CharacterStats = Stream.Read.StatDataArray(NumberOfAttributeCategories1CharacterStats);

                        NumberOfAttributeCategories2CharacterStats = Stream.Read.UShort();
                        AttributeCategories_2_CharacterStats = Stream.Read.StatDataArray(NumberOfAttributeCategories2CharacterStats);

                        break;

                    case ShadowFieldIndex.ScalingLevel:
                        ScalingLevel = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PvPRank:
                        PvP_Rank = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EliteLevel:
                        Elite_Rank = Stream.Read.UInt();
                        break;

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

    public struct EquippedItemData
    {
        public uint SdbId;
        public byte SlotIdx;
        public byte[] UnkData;

        public EquippedItemData(Bitter.BinaryReader R)
        {
            SdbId = R.UInt();
            SlotIdx = R.Byte();
            UnkData = R.ByteArray(2);
        }

        public override string ToString() => $"SdbId: {SdbId}, SlotIdx: {SlotIdx}, Unk: [{(UnkData != null ? String.Join(", ", UnkData) : "null")}]";
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

    // (6 byte, ushort id, float value)
    public struct StatData
    {
        public ushort Id;
        public float Value;

        public StatData(Bitter.BinaryReader R)
        {
            Id = R.UShort();
            Value = R.Float();
        }

        public override string ToString() => $"Id: {Id}, Value: {Value}";
    }

    public static class MyExtensions
    {
        public static EquippedItemData EquippedItemData(this Bitter.BinaryReader R)
        {
            return new EquippedItemData(R);
        }

        public static EquippedItemData[] EquippedItemDataArray(this Bitter.BinaryReader R, int num)
        {
            List<EquippedItemData> list = new List<EquippedItemData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.EquippedItemData());
            }
            return list.ToArray();
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

        public static StatData StatData(this Bitter.BinaryReader R)
        {
            return new StatData(R);
        }

        public static StatData[] StatDataArray(this Bitter.BinaryReader R, int num)
        {
            List<StatData> list = new List<StatData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.StatData());
            }
            return list.ToArray();
        }
    }
}