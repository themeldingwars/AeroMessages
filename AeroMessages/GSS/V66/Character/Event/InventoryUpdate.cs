using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 129)]
    public partial class InventoryUpdate
    {
        public byte ClearExistingData; // 1 for full update, 0 for partitial


        // TODO: Aero needs support for handling additional entries if size is 255
        // TEMP: Hack that supports up to 765 items
        public byte ItemsPart1Length;
        [AeroIf(nameof(ItemsPart1Length), Ops.Equal, 255)]
        [AeroArray(255)]
        public Item[] ItemsPart1Full;

        [AeroIf(nameof(ItemsPart1Length), Ops.NotEqual, 255)]
        [AeroArray(nameof(ItemsPart1Length))] 
        public Item[] ItemsPart1;

        [AeroIf(nameof(ItemsPart1Length), Ops.Equal, 255)]
        public byte ItemsPart2Length;

        [AeroIf(nameof(ItemsPart2Length), Ops.Equal, 255)]
        [AeroArray(255)]
        public Item[] ItemsPart2Full;

        [AeroIf(nameof(ItemsPart2Length), Ops.NotEqual, 255)]
        [AeroArray(nameof(ItemsPart2Length))] 
        public Item[] ItemsPart2;

        [AeroIf(nameof(ItemsPart2Length), Ops.Equal, 255)]
        public byte ItemsPart3Length;

        [AeroIf(nameof(ItemsPart3Length), Ops.NotEqual, 255)]
        [AeroArray(nameof(ItemsPart3Length))] 
        public Item[] ItemsPart3;
        // ---

        [AeroArray(typeof(byte))]
        public Resource[] Resources;

        [AeroArray(typeof(byte))]
        public Loadout[] Loadouts;

        public byte Unk;

        [AeroArray(typeof(byte))]
        public Item[] SecondItems; // ?

        [AeroArray(typeof(byte))]
        public Resource[] SecondResources; // ?
    }

    [AeroBlock]
    public struct Item
    {
        public byte Unk1;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public ulong GUID;
        public byte SubInventory;
        public uint Unk2;
        public byte DynamicFlags;
        public ushort Durability;
        public ushort Unk3;
        public ushort Unk4;
        public byte Unk5;

        [AeroArray(typeof(byte))]
        public ItemUnkData[] Unk6;

        public ushort Unk7;

        [AeroArray(typeof(byte))]
        public uint[] Modules;
    }

    [AeroBlock]
    public struct ItemUnkData
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct Resource 
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        [AeroString]
        public string TextKey; // Used for XP rewards?

        public uint Quantity;
        public byte SubInventory;
        public uint Unk2;
    }

    [AeroBlock]
    public struct Loadout
    {
        public uint FrameLoadoutId;
        public uint Unk; // The frame loadout id is used as a uint in other messages so these are unlikely to belong to it. Perhaps an internal loadout id?

        [AeroString]
        public string LoadoutName;

        [AeroString]
        public string LoadoutType;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ChassisID;
        
        [AeroArray(typeof(byte))]
        public LoadoutConfig[] LoadoutConfigs;
    }

    [AeroBlock]
    public struct LoadoutConfig
    {
        public uint ConfigID;

        [AeroString]
        public string ConfigName;
        
        [AeroArray(typeof(byte))]
        public LoadoutConfig_Item[] Items;
        
        [AeroArray(typeof(byte))]
        public LoadoutConfig_Visual[] Visuals;
        
        [AeroArray(typeof(byte))]
        public uint[] Perks;

        public uint Unk1; // Feels like it should be related to perks, but couldn't find anything.
        public uint PerkBandwidth;
        public uint PerkRespecLockRemainingSeconds;

        public byte HaveExtraData;
        [AeroIf(nameof(HaveExtraData), Ops.Equal, 1)]
        public LoadoutConfig_Extra ExtraData;
    }

    [AeroBlock]
    public struct LoadoutConfig_Item
    {
        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIndex;
        public ulong ItemGUID;
    }

    [AeroBlock]
    public struct LoadoutConfig_Extra
    {
        // FUN_009e9fa0
        public int Unk1_1;
        public byte Unk1_2;
        public byte Unk1_3;
        public uint Unk1_4;
        public uint Unk1_5;
        public uint Unk1_6;

        [AeroArray(typeof(byte))]
        public uint[] Unk2;

        public VisualsBlock UnkVisualsBlock;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint VehicleId;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint GliderId;

        [AeroArray(typeof(byte))]
        public LoadoutConfig_Extra_UnkThing[] Unk3;

        [AeroSdb("dbvisualrecords::WarpaintPalette", "id")]
        public uint OverrideWeaponsPaletteId;

        [AeroArray(typeof(byte))]
        public uint[] Unk4;

        public uint Unk5_1;
        public uint Unk5_2;
        public uint Unk5_3;
        // --

        public SlottedItem Chassis;

        [AeroArray(typeof(byte))]
        public SlottedItem[] Weapons;

        [AeroArray(typeof(byte))]
        public VisualOverridesData[] VisualOverrides;

        public SlottedItem Backpack;

        public uint Unk6;
        public uint UnkPerkRespecRemainingSecRelated;
        public byte ArchetypeLevel;
        public uint Unk7;
    }

    [AeroBlock]
    public struct LoadoutConfig_Extra_UnkThing
    {
        public uint Unk1;
        public uint Unk2;
    }
}