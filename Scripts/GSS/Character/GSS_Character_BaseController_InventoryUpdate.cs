[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 129, Ver: 1962)]
public partial class CharacterBaseControllerInventoryUpdate : AeroBase
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

[Aero(AeroType.Block)]
public partial class Item : AeroBase
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

public partial class Resource : AeroBase 
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint SdbId;

    [AeroNullTermString]
    public string TextKey; // Used for XP rewards?

    public uint Quantity;
    public byte SubInventory;

    [AeroArray(4)]
    public byte[] Unk2;
}

public partial class Loadout : AeroBase
{
    public uint FrameLoadoutId;

    [AeroArray(4)]
    public byte[] Unk; // The frame loadout id is used as a uint in other messages so these are unlikely to belong to it. Perhaps an internal loadout id?

    [AeroNullTermString]
    public string LoadoutName;

    [AeroNullTermString]
    public string LoadoutType;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ChassisID;
    
    [AeroArray(typeof(byte))]
    public LoadoutConfig[] LoadoutConfigs;
}

public partial class LoadoutConfig : AeroBase
{
    public uint ConfigID;

    [AeroNullTermString]
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

public partial class LoadoutConfig_Item : AeroBase
{
    [AeroSDB("dbitems::LoadoutSlot", "id")]
    public byte SlotIndex;
    public ulong ItemGUID;
}

public partial class LoadoutConfig_Visual : AeroBase
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



    [AeroIf(nameof(VisualType), LoadoutVisualType.Palette)]
    
    public byte[] Unk1;

    public byte? Decal_TransformCount;
    public float[] Decal_Transform;
    public byte? Glider_Unk;
    public byte? Vehicle_Unk;
    public byte? Palette_Unk;
    public byte? Pattern_TransformCount;
    public float[] Pattern_Transform;
    
    public string UnknownTypeParsingError;

    public void Read(BinaryStream Stream)
    {
        ItemSdbId = Stream.Read.UInt();
        VisualType = (LoadoutVisualType) Stream.Read.Byte();
        Unk1 = Stream.Read.ByteArray(8);

        switch (VisualType)
        {
            case LoadoutVisualType.Palette:
                Palette_Unk = Stream.Read.Byte();
                break;

            case LoadoutVisualType.Pattern:
                Pattern_TransformCount = Stream.Read.Byte();
                Pattern_Transform = Stream.Read.FloatArray((int)Pattern_TransformCount);
                break;

            case LoadoutVisualType.Decal:
                Decal_TransformCount = Stream.Read.Byte();
                Decal_Transform = Stream.Read.FloatArray((int)Decal_TransformCount);
                break;

            case LoadoutVisualType.Glider:
                Glider_Unk = Stream.Read.Byte();
                break;

            case LoadoutVisualType.Vehicle:
                Vehicle_Unk = Stream.Read.Byte();
                break;
            
            default:
                UnknownTypeParsingError = "Dont know how to parse this visual type! Implement!";
                break;
        }
    }
    
    public void Write(BinaryStream Stream)
    {
        throw new System.NotImplementedException();
    }
    
    public override string ToString() => $"{this.GetType().Name} Slot: {ItemSdbId} => {VisualType}";
}
























using System.Collections.Generic;
using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 129, true)]
    public class CharacterBaseControllerInventoryUpdate : BaseScript
    {
        // This message is used both when sending the full inventory on login as well as for partitial updates when playing.
        // There are different formats for items but they should be somewhat split into sections.
        // There is one format for items which have a GUID, one format for resources (currency and consumables items that are "stackable"), and a format that describes battleframes, their loadouts and customization.
        // Could be more formats that we don't know about as well.
        // Currently, PacketPeep does not handle split messages, and it's not really capable of displaying objects/structs. Hence this parser doesn't really work yet.
        // A lot of bytes are still unk so everything can get completely thrown off due to arrays of data.

        public byte Reset; // 1 for full update, 0 for partitial
        public string CantParseNotice;

        public byte NumUniqueItems;
        public List<UniqueItem> UniqueItems;

        public byte NumStackItems;
        public List<StackItem> StackItems;

        public byte NumLoadouts;
        public List<Loadout> Loadouts;

        public byte[] Unk_LastThree;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            Reset = Stream.Read.Byte();

            if (Reset == 0x01) {
                CantParseNotice = "This message is likely split, aborting parsing."; // Remove this when PacketPeep gets split message parsing.
                return;
            }
            
            var hackUniqueItems = new List<UniqueItem>();
            do
            {
                // Unique Items
                NumUniqueItems = Stream.Read.Byte();
                UniqueItems = Stream.Read.TypeList<UniqueItem>(NumUniqueItems);
                
                hackUniqueItems.AddRange(UniqueItems);
            } while( NumUniqueItems == 255 );
            
            UniqueItems = hackUniqueItems;
            
            // Stackable Items
            NumStackItems = Stream.Read.Byte();
            StackItems = Stream.Read.TypeList<StackItem>(NumStackItems);
            
            // Loadouts
            NumLoadouts = Stream.Read.Byte();
            Loadouts = Stream.Read.TypeList<Loadout>(NumLoadouts);

            Unk_LastThree = Stream.Read.ByteArray(3);
        }
    }


    public class UniqueItem : Bitter.BinaryWrapper.ReadWrite {
        public byte Unk1;
        public uint SdbId;
        public ulong GUID;
        public byte SubInventory;
        public byte[] Unk2;
        public byte DynamicFlags;
        public ushort Durability;
        public byte[] Unk3;
        public byte Unk4_Count;
        public ulong[] Unk4_Data;
        public byte[] Unk5;
        public byte Module_Count;
        public uint[] Modules;
        
        public void Read(BinaryStream Stream)
        {
            Unk1 = Stream.Read.Byte();
            SdbId = Stream.Read.UInt();
            GUID = Stream.Read.ULong();
            SubInventory = Stream.Read.Byte();
            Unk2 = Stream.Read.ByteArray(4);
            DynamicFlags = Stream.Read.Byte();
            Durability = Stream.Read.UShort();
            Unk3 = Stream.Read.ByteArray(5);
            Unk4_Count = Stream.Read.Byte();
            if (Unk4_Count > 0)
                Unk4_Data = Stream.Read.ULongArray(Unk4_Count);
            Unk5 = Stream.Read.ByteArray(2);
            Module_Count = Stream.Read.Byte();
            if (Module_Count > 0)
                Modules = Stream.Read.UIntArray(Module_Count);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => $"{this.GetType().Name} SdbID: {SdbId}";
    }

    public class StackItem : Bitter.BinaryWrapper.ReadWrite
    {
        public uint SdbId;
        public string TextKey; // Used for XP rewards?
        public uint Quantity;
        public byte SubInventory;
        public byte[] Unk2;
        
        public void Read(BinaryStream Stream)
        {
            SdbId = Stream.Read.UInt();
            TextKey = Stream.Read.StringZ();
            Quantity = Stream.Read.UInt();
            SubInventory = Stream.Read.Byte();
            Unk2 = Stream.Read.ByteArray(4);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"{this.GetType().Name} SdbID: {SdbId} x{Quantity}";
    }
    
    public class Loadout : Bitter.BinaryWrapper.ReadWrite
    {
        public uint FrameLoadoutId;
        public byte[] Unk; // The frame loadout id is used as a uint in other messages so these are unlikely to belong to it.
        public string LoadoutName;
        public string LoadoutType;
        public uint ChassisID;
        
        public byte NumConfigs;
        public List<LoadoutConfig> LoadoutConfigs;

        public void Read(BinaryStream Stream)
        {
            FrameLoadoutId = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(4);
            LoadoutName = Stream.Read.StringZ();
            LoadoutType = Stream.Read.StringZ();
            ChassisID = Stream.Read.UInt();
            NumConfigs = Stream.Read.Byte();
            LoadoutConfigs = Stream.Read.TypeList<LoadoutConfig>(NumConfigs);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"Loadout {LoadoutName} - {LoadoutType}";
    }
    
    public class LoadoutConfig : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ConfigID;
        public string ConfigName;
        
        public byte NumItems;
        public List<LoadoutConfig_Item> Items;
        
        public byte NumVisuals;
        public List<LoadoutConfig_Visual> Visuals;
        
        public byte NumPerks;
        public uint[] Perks;
        
        public byte[] Unk;
        
        public void Read(BinaryStream Stream)
        {
            ConfigID = Stream.Read.UInt();
            ConfigName = Stream.Read.StringZ();
            
            NumItems = Stream.Read.Byte();
            Items = Stream.Read.TypeList<LoadoutConfig_Item>(NumItems);
            
            NumVisuals = Stream.Read.Byte();
            Visuals = Stream.Read.TypeList<LoadoutConfig_Visual>(NumVisuals);
            
            Unk = Stream.Read.ByteArray(13);
        }
        
        public void Write(BinaryStream Stream) 
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"Config {ConfigName}";
    }
    
    public class LoadoutConfig_Item : Bitter.BinaryWrapper.ReadWrite
    {
        public byte SlotIndex;
        public ulong ItemGUID;
        
        public void Read(BinaryStream Stream)
        {
            SlotIndex = Stream.Read.Byte();
            ItemGUID = Stream.Read.ULong();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"{this.GetType().Name} Slot: {SlotIndex} => {ItemGUID}";
    }

    public class LoadoutConfig_Visual : Bitter.BinaryWrapper.ReadWrite
    {
        public enum LoadoutVisualType : byte {
            Palette = 9,
            Pattern = 10,
            Decal = 11,

            Glider = 13,
            Vehicle = 14,
        };

        public uint ItemSdbId;
        public LoadoutVisualType VisualType;
        
        public byte[] Unk1;

        public byte? Decal_TransformCount;
        public float[] Decal_Transform;
        public byte? Glider_Unk;
        public byte? Vehicle_Unk;
        public byte? Palette_Unk;
        public byte? Pattern_TransformCount;
        public float[] Pattern_Transform;
        
        public string UnknownTypeParsingError;

        public void Read(BinaryStream Stream)
        {
            ItemSdbId = Stream.Read.UInt();
            VisualType = (LoadoutVisualType) Stream.Read.Byte();
            Unk1 = Stream.Read.ByteArray(8);

            switch (VisualType)
            {
                case LoadoutVisualType.Palette:
                    Palette_Unk = Stream.Read.Byte();
                    break;

                case LoadoutVisualType.Pattern:
                    Pattern_TransformCount = Stream.Read.Byte();
                    Pattern_Transform = Stream.Read.FloatArray((int)Pattern_TransformCount);
                    break;

                case LoadoutVisualType.Decal:
                    Decal_TransformCount = Stream.Read.Byte();
                    Decal_Transform = Stream.Read.FloatArray((int)Decal_TransformCount);
                    break;

                case LoadoutVisualType.Glider:
                    Glider_Unk = Stream.Read.Byte();
                    break;

                case LoadoutVisualType.Vehicle:
                    Vehicle_Unk = Stream.Read.Byte();
                    break;
                
                default:
                    UnknownTypeParsingError = "Dont know how to parse this visual type! Implement!";
                    break;
            }
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"{this.GetType().Name} Slot: {ItemSdbId} => {VisualType}";
    }

    public static class MyExtensions {
        public static Bitter.BinaryStream Stream;
        
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
    }
}