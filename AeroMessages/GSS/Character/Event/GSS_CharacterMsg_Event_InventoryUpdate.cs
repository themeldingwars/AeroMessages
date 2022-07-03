using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 129)]
    public partial class Character_Event_InventoryUpdate
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

        [AeroArray(3)]
        public byte[] Unk_LastThree; // Could it be that they are used to remove Items, Resources and Loadouts? Since the first ones are used to add/update.
    }

    [AeroBlock]
    public struct Item
    {
        public byte Unk1;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public ulong GUID;
        public byte SubInventory;

        [AeroArray(4)]
        public byte[] Unk2;

        public byte DynamicFlags;
        public ushort Durability;

        [AeroArray(5)]
        public byte[] Unk3;

        [AeroArray(typeof(byte))]
        public ulong[] Unk4_Data;

        [AeroArray(2)]
        public byte[] Unk5;

        [AeroArray(typeof(byte))]
        public uint[] Modules;
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

        [AeroArray(4)]
        public byte[] Unk2;
    }

    [AeroBlock]
    public struct Loadout
    {
        public uint FrameLoadoutId;

        [AeroArray(4)]
        public byte[] Unk; // The frame loadout id is used as a uint in other messages so these are unlikely to belong to it. Perhaps an internal loadout id?

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
        
        [AeroArray(4)]
        public byte[] Unk1; // Feels like it should be related to perks, but couldn't find anything.

        public uint PerkBandwidth;
        public uint PerkRespecLockRemainingSeconds;

        public byte Unk2; // Throws unpack error, maybe visual overrides
    }

    [AeroBlock]
    public struct LoadoutConfig_Item
    {
        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIndex;
        public ulong ItemGUID;
    }
}