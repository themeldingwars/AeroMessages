using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{

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

    [Script(MessageType.GSS, 9, 3, true)]
    public class CharacterEquipmentViewKeyframe : BaseScript
    {
        // "Visual group"?
        public byte Unk_HaveVisualsGroupData;
        public byte Unk_VisualsGroupWeirdByte;
        public uint VisualsGroupId;
        
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

        public byte[] Unk2;

        public EquippedItemData Backpack; // Reactor
        public byte NumberOfBackpackModules;
        public EquippedItemData[] Backpack_Modules;

        public byte[] Unk3;

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

        public byte[] Unk4;

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

        public byte[] Unk5;

        public byte Level;
        public byte Effective_Level;
        public byte[] Unk6;

        public ushort NumberOfItemAttributeStats;
        public StatData[] ItemAttribute_Stats; // (6 byte, ushort id, float value)
        public byte[] Unk7;
        public ushort NumberOfPrimaryWeaponStats;
        public StatData[] PrimaryWeapon_Stats;
        public byte[] Unk8;
        public ushort NumberOfSecondaryWeaponStats;
        public StatData[] SecondaryWeapon_Stats;
        public byte[] Unk9;
        public ushort NumberOfAttributeCategories1Stats;
        public StatData[] AttributeCategories_1_Stats; // Yeah, there are two.
        public ushort NumberOfAttributeCategories2Stats;
        public StatData[] AttributeCategories_2_Stats; // Maybe one for elite ranks and one for normal progression.

        public byte[] Unk10;
        public uint PvP_Rank;
        public uint Elite_Rank;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk_HaveVisualsGroupData = Stream.Read.Byte();
            if (Unk_HaveVisualsGroupData == 0x01)
            {
                Unk_VisualsGroupWeirdByte = Stream.Read.Byte();
                VisualsGroupId = Stream.Read.UInt();
            }

            if (true) // Keeping this because it somehow fixes highlighting issues
            {
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

                Unk2 = Stream.Read.ByteArray(4);


                Backpack = Stream.Read.EquippedItemData();
                NumberOfBackpackModules = Stream.Read.Byte();
                Backpack_Modules = Stream.Read.EquippedItemDataArray(NumberOfBackpackModules);

                Unk3 = Stream.Read.ByteArray(9);

                PrimaryWeapon = Stream.Read.UInt();

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

                Unk4 = Stream.Read.ByteArray(11);

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

                Unk5 = Stream.Read.ByteArray(11+5); // Not sure how much of this belongs to the weapon

                Level = Stream.Read.Byte();
                Effective_Level = Stream.Read.Byte();

                Unk6 = Stream.Read.ByteArray(2);

                NumberOfItemAttributeStats = Stream.Read.UShort();
                ItemAttribute_Stats = Stream.Read.StatDataArray(NumberOfItemAttributeStats);

                Unk7 = Stream.Read.ByteArray(4);

                NumberOfPrimaryWeaponStats = Stream.Read.UShort();
                PrimaryWeapon_Stats = Stream.Read.StatDataArray(NumberOfPrimaryWeaponStats);

                Unk8 = Stream.Read.ByteArray(4);
                
                NumberOfSecondaryWeaponStats = Stream.Read.UShort();
                SecondaryWeapon_Stats = Stream.Read.StatDataArray(NumberOfSecondaryWeaponStats);

                Unk9 = Stream.Read.ByteArray(4);
                
                NumberOfAttributeCategories1Stats = Stream.Read.UShort();
                AttributeCategories_1_Stats = Stream.Read.StatDataArray(NumberOfAttributeCategories1Stats);

                NumberOfAttributeCategories2Stats = Stream.Read.UShort();
                AttributeCategories_2_Stats = Stream.Read.StatDataArray(NumberOfAttributeCategories2Stats);

                Unk10 = Stream.Read.ByteArray(4);
                PvP_Rank = Stream.Read.UInt();
                Elite_Rank = Stream.Read.UInt();
            }

        }
    }
}