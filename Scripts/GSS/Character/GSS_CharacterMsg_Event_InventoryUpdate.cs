/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 129
    MsgName: InventoryUpdate
META_END
 */
[Aero]
public partial class Character_Event_InventoryUpdate
{
    public byte ClearExistingData; // 1 for full update, 0 for partitial

    [AeroArray(typeof(byte))] // TODO: Aero needs support for handling additional bytes if size is 255
    public List<Item> Items;

    [AeroArray(typeof(byte))]
    public List<Resource> Resources;

    [AeroArray(typeof(byte))]
    public List<Loadout> Loadouts;

    [AeroArray(3)]
    public byte[] Unk_LastThree;
}

[AeroBlock]
public struct Item
{
    public byte Unk1;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
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

public struct Resource 
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint SdbId;

    [AeroString]
    public string TextKey; // Used for XP rewards?

    public uint Quantity;
    public byte SubInventory;

    [AeroArray(4)]
    public byte[] Unk2;
}

public struct Loadout
{
    public uint FrameLoadoutId;

    [AeroArray(4)]
    public byte[] Unk; // The frame loadout id is used as a uint in other messages so these are unlikely to belong to it. Perhaps an internal loadout id?

    [AeroString]
    public string LoadoutName;

    [AeroString]
    public string LoadoutType;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ChassisID;
    
    [AeroArray(typeof(byte))]
    public LoadoutConfig[] LoadoutConfigs;
}

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
    
    [AeroArray(13)]
    public byte[] Unk;
}

public struct LoadoutConfig_Item
{
    [AeroSDB("dbitems::LoadoutSlot", "id")]
    public byte SlotIndex;
    public ulong ItemGUID;
}

public struct LoadoutConfig_Visual
{
    [Flags]
    public enum LoadoutVisualType : byte {
        Palette = 9,
        Pattern = 10,
        Decal = 11,

        Glider = 13,
        Vehicle = 14,
    };

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ItemSdbId;

    public LoadoutVisualType VisualType;

    [AeroArray(8)]
    public byte[] Unk1;

    [AeroIf(nameof(VisualType), Op.HasFlag, LoadoutVisualType.Palette)]
    public byte Palette_Unk;
    
    [AeroIf(nameof(VisualType), Op.HasFlag, LoadoutVisualType.Pattern)]
    [AeroArray(typeof(byte))]
    public float[] Pattern_Transform;

    [AeroIf(nameof(VisualType), Op.HasFlag, LoadoutVisualType.Decal)]
    [AeroArray(typeof(byte))]
    public float[] Decal_Transform;

    [AeroIf(nameof(VisualType), Op.HasFlag, LoadoutVisualType.Glider)]
    public byte Glider_Unk;

    [AeroIf(nameof(VisualType), Op.HasFlag, LoadoutVisualType.Vehicle)]
    public byte Vehicle_Unk;

}