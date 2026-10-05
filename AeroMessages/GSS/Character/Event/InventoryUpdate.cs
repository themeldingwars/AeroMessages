using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.InventoryUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class InventoryUpdate
    {
        public sbyte ClearExistingData; // 1 for full, 0 for partitial

        [AeroArray(typeof(byte), Chunked = true)]
        public Item[] Items;

        [AeroArray(typeof(byte))]
        public Resource[] Resources;

        [AeroArray(typeof(byte))]
        public Loadout[] Loadouts;

        public sbyte UpdateMailInventory; // replaces the mail inventory with the two arrays below

        [AeroArray(typeof(byte))]
        public Item[] MailItems;

        [AeroArray(typeof(byte))]
        public Resource[] MailResources;
    }

    [AeroBlock]
    public struct Item
    {
        public byte ChangeType; // 0 or 1 add or update, 2 destroy

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public ulong GUID;
        public byte SubInventory;
        public uint TimestampEpoch; // Unix Seconds
        public byte DynamicFlags;
        public ushort Durability;
        public ushort DurabilityPool;
        public ushort Unk4;
        public byte Unk5;

        [AeroArray(typeof(byte))]
        public ItemUnkData[] Attributes;

        public ushort Quality;

        [AeroArray(typeof(byte))]
        public uint[] Modules;
    }

    [AeroBlock]
    public struct ItemUnkData
    {
        [AeroSdb("dbitems::AttributeDefinition", "id")]
        public uint AttributeId;
        public float Value;
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
        public uint TimestampEpoch; // Unix Seconds, 0 in full updates
    }

    [AeroBlock]
    public struct Loadout
    {
        public int PveLoadoutId;
        public uint PvpLoadoutId;

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

        public uint PerkRespecReferenceTime; // ms tick PerkRespecLockRemainingSeconds counts from
        public uint PerkRespecLockRemainingSeconds;
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