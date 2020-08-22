
using System.Collections.Generic;
using Bitter;

namespace PacketPeepScript {
	// Add "MyExtensions.BStream = Stream;" as first line in Packet Read function.
	public static class MyExtensions {
		public static Bitter.BinaryStream BStream;
		
		public static string StringZ(this Bitter.BinaryReader rdr) {
			string ret = "";
			
            do {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
				
				ret += (char)b;
            } while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            
			return ret;
        }
		
		public static void SkipZeros(this Bitter.BinaryReader rdr) {
			byte b;
			do {
				b = rdr.Byte();
			} while( b == 0 );
			
			BStream.baseStream.ByteOffset--;
		}
	}
	
	// This still needs MASSIVE work
	
    [Script(MessageType.GSS, 2, 129, true)]
    public class CharacterBaseControllerInventoryUpdate : BaseScript {
        // This message is used both when sending the full inventory on login as well as for partitial updates when playing.
        // There are different formats for items but they should be somewhat split into sections.
        // There is one format for items that have GUID, one format for currency and consumables items that are "stackable" and don't have GUID, and a format that describes battleframes, their loadouts and customization.
        // Could be more formats that we don't know about as well.
        // Currently, PacketPeep does not handle split messages, and it's not capable of displaying objects/structs. So this current implementation attempts to parse one example item of each kind, and then just shove the remaining ones into an unparsed array.
        // A lot of bytes are still unk so everything can get completely thrown off due to arrays of data.

        public byte Unk1_FirstByte; // Maybe full vs partial update?

        public byte NumUniqueItems;
		public List<UniqueItem> UniqueItems;
		
		public byte NumStackItems;
		public List<StackItem> StackItems;

        public byte NumLoadouts;
		public List<Loadout> Loadouts;

        public byte[] Unk_LastThree;

        public override void Read(Bitter.BinaryStream Stream) {
			MyExtensions.BStream = Stream;
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1_FirstByte = Stream.Read.Byte();

			var hackUniqueItems = new List<UniqueItem>();
			do {
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
            Loadouts = Stream.Read.TypeList<Loadout>(4);//(NumLoadouts);

            //Unk_LastThree = Stream.Read.ByteArray(3);
        }
    }
	
	public class UniqueItem : Bitter.BinaryWrapper.ReadWrite {
		public byte Unk1;
		public uint SdbId;
        public ulong GUID;
        public byte SubInventory;
        public byte[] Unk2;
        public byte Unk3_Count;
        public ulong[] Unk3_Data;
        public byte[] Unk4;
        public byte Unk5_Count;
        public uint[] Unk5_Data;
		
		public void Read(BinaryStream Stream) {
			Unk1 = Stream.Read.Byte();
			SdbId = Stream.Read.UInt();
			GUID = Stream.Read.ULong();
			SubInventory = Stream.Read.Byte();
			Unk2 = Stream.Read.ByteArray(12);
			
			Unk3_Count = Stream.Read.Byte();
			if (Unk3_Count > 0)
				Unk3_Data = Stream.Read.ULongArray(Unk3_Count);
			
			Unk4 = Stream.Read.ByteArray(2);
			
			Unk5_Count = Stream.Read.Byte();
			if (Unk5_Count > 0)
				Unk5_Data = Stream.Read.UIntArray(Unk5_Count);
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"{this.GetType().Name} SdbID: {SdbId}";
	}
	
	public class StackItem : Bitter.BinaryWrapper.ReadWrite {
		// SlotIdx is here somewhere
		public uint SdbId;
        public string TextKey; // Used for XP rewards?
        public uint Quantity;
        public byte[] Unk2;
		
		public void Read(BinaryStream Stream) {
			SdbId = Stream.Read.UInt();
			TextKey = Stream.Read.StringZ();
			Quantity = Stream.Read.UInt();
			Unk2 = Stream.Read.ByteArray(5);
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"{this.GetType().Name} SdbID: {SdbId} x{Quantity}";
	}
	
	public class Loadout : Bitter.BinaryWrapper.ReadWrite {
		public ulong FrameLoadoutGUID;
		public string LoadoutName;
		public string LoadoutType;
		public uint ChassisID;
		
		public byte NumConfigs;
		public List<LoadoutConfig> LoadoutConfigs;

		public void Read(BinaryStream Stream) {
			FrameLoadoutGUID = Stream.Read.ULong();
			LoadoutName = Stream.Read.StringZ();
			LoadoutType = Stream.Read.StringZ();
			ChassisID = Stream.Read.UInt();
			
			NumConfigs = Stream.Read.Byte();
			LoadoutConfigs = Stream.Read.TypeList<LoadoutConfig>(NumConfigs);
			
			_ = Stream.Read.ByteArray(14);
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"Loadout {LoadoutName} - {LoadoutType}";
	}
	
	public class LoadoutConfig : Bitter.BinaryWrapper.ReadWrite {
		public uint ConfigID;
		public string ConfigName;
		
		public byte NumItems;
		public List<LoadoutConfig_Item> Items;
		
		public byte Flags;
		
		public Visuals Visuals1;
		public Visuals Visuals2;
		public Visuals Visuals3;
		
		public byte NumPerks;
		public uint[] Perks;
		
		public byte[] UnkBytes;
		
		public void Read(BinaryStream Stream) {
			ConfigID = Stream.Read.UInt();
			ConfigName = Stream.Read.StringZ();
			
			NumItems = Stream.Read.Byte();
			Items = Stream.Read.TypeList<LoadoutConfig_Item>(NumItems);
			
			Flags = Stream.Read.Byte();
			
			if( (Flags & 0x01) > 0 || (Flags & 0x04) > 0 ) {
				_ = Stream.Read.UInt();
			
				var f = Stream.Read.Byte();
				
				if( (f & 1) > 0 ) {
					_ = Stream.Read.ByteArray(9);
				}
				if( (f & 2) > 0 ) {
					//_ = Stream.Read.Byte();
					var cnt = Stream.Read.Byte();
					_ = Stream.Read.ByteArray(cnt);
				}
				if( (f & 4) > 0 ) {
					_ = Stream.Read.ByteArray(88);
				}
				if( (f & 8) > 0 ) {
					var cntAwards = Stream.Read.Byte();
					var awards = Stream.Read.UIntArray(cntAwards);
				}
				
				_ = Stream.Read.Byte();
			
				var unkints = Stream.Read.UIntArray(2);
				var unkints2 = Stream.Read.UIntArray(1);
			}
			
			if( (Flags & 0x02) > 0 ) {
				_ = Stream.Read.Byte();
				
				var cnt = Stream.Read.Byte();
				_ = Stream.Read.ByteArray(cnt);
				
				var unkints = Stream.Read.UIntArray(2);
				var unkints2 = Stream.Read.UIntArray(1);
			}
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"Config {ConfigName}";
	}
	
	public class LoadoutConfig_Item : Bitter.BinaryWrapper.ReadWrite {
		public byte SlotIndex;
		public ulong ItemGUID;
		
		public void Read(BinaryStream Stream) {
			SlotIndex = Stream.Read.Byte();
			ItemGUID = Stream.Read.ULong();
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"{this.GetType().Name} Slot: {SlotIndex} => {ItemGUID}";
	}
	
	public class Visuals : Bitter.BinaryWrapper.ReadWrite {
		public byte NumDecals;
		public IList<Decal> Decals;
		
		public byte NumDecalGradients;
		public IList<DecalGradient> DecalGradients;
		
		public ushort NumColors;
		public uint[] Colors;
		
		public byte NumPalettes;
		public IList<Palette> Palettes;
		
		public byte NumPatterns;
		public IList<Pattern> Patterns;
		
		public byte NumOrnamentGroups;
		public uint[] OrnamentGroups;
		
		public byte NumUnk1;
		public uint[] ItemsUnk1;
		
		public byte NumUnk2;
		public uint[] ItemsUnk2;
		
		public byte NumUnk3;
		public uint[] ItemsUnk3;
		
		public void Read(BinaryStream Stream) {
			NumDecals = Stream.Read.Byte();
			Decals = Stream.Read.TypeList<Decal>(NumDecals);
			
			//NumDecalGradients = Stream.Read.Byte();
			//DecalGradients = Stream.Read.TypeList<DecalGradient>(NumDecalGradients);
			
			//NumColors = Stream.Read.UShort();
			//Colors = Stream.Read.UIntArray((int)NumColors);
			
			//NumPalettes = Stream.Read.Byte();
			//Palettes = Stream.Read.TypeList<Palette>((int)NumPalettes);
			
			//NumPatterns = Stream.Read.Byte();
			//Patterns = Stream.Read.TypeList<Pattern>((int)NumPatterns);
			
			//NumOrnamentGroups = Stream.Read.Byte();
			//OrnamentGroups = Stream.Read.UIntArray((int)NumOrnamentGroups);
			
			//NumUnk1 = Stream.Read.Byte();
			//if( NumUnk1 > 0 )
			//	throw new System.NotImplementedException();
			//ItemsUnk1 = Stream.Read.UIntArray((int)NumUnk1);
			
			//NumUnk2 = Stream.Read.Byte();
			//if( NumUnk2 > 0 )
			//	throw new System.NotImplementedException();
			//ItemsUnk2 = Stream.Read.UIntArray((int)NumUnk2);
			
			//NumUnk3 = Stream.Read.Byte();
			//if( NumUnk3 > 0 )
			//	throw new System.NotImplementedException();
			//ItemsUnk3 = Stream.Read.UIntArray((int)NumUnk3);
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"Colors: {Colors}, Palettes: {Palettes}, Patterns: {Patterns}";
	}
	
	public class Palette : Bitter.BinaryWrapper.ReadWrite {
		public byte Type;
		public uint ID;
		
		public void Read(BinaryStream Stream) {
			Type = Stream.Read.Byte();
			ID = Stream.Read.UInt();
		}
		
        public void Write(BinaryStream Stream) {
			Stream.Write.Byte(Type);
			Stream.Write.UInt(ID);
		}
		
		public override string ToString() => $"Type: {Type}, ID: {ID}";
	}
	
	public class Pattern : Bitter.BinaryWrapper.ReadWrite {
		public uint ID;
		public ushort[] Transform;
		public byte Usage;
		
		
		public void Read(BinaryStream Stream) {
			ID = Stream.Read.UInt();
			Transform = Stream.Read.UShortArray(4);
			Usage = Stream.Read.Byte();
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"ID: {ID}, Usage: {Usage}";
	}
	
	public class Decal : Bitter.BinaryWrapper.ReadWrite {
		public uint ID;
		public uint Color;
		public ushort[] Transform;
		public byte Usage;
		
		public void Read(BinaryStream Stream) {
			ID = Stream.Read.UInt();
			Color = Stream.Read.UInt();
			Transform = Stream.Read.UShortArray(12);
			Usage = Stream.Read.Byte();
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"ID: {ID}, Color: {Color}, Usage: {Usage}";
	}
	
	public class DecalGradient : Bitter.BinaryWrapper.ReadWrite {
		
		
		public void Read(BinaryStream Stream) {
			_ = Stream.Read.ByteArray(1);
		}
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"ID: ";
	}
}