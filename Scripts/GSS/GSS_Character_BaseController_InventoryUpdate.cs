using Bitter;

namespace PacketPeepScript {
    public static class MyExtensions {
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
    }
    
    [Script(MessageType.GSS, 2, 129, true)]
    public class CharacterBaseControllerInventoryUpdate : BaseScript {
        // This message is used both when sending the full inventory on login as well as for partitial updates when playing.
        // There are different formats for items but they should be somewhat split into sections.
        // There is one format for items that have GUID, one format for currency and consumables items that are "stackable" and don't have GUID, and a format that describes battleframes, their loadouts and customization.
        // Could be more formats that we don't know about as well.
        // Currently, PacketPeep does not handle split messages, and it's not capable of displaying objects/structs. So this current implementation attempts to parse one example item of each kind, and then just shove the remaining ones into an unparsed array.
        // A lot of bytes are still unk so everything can get completely thrown off due to arrays of data.

        public byte Unk1_FirstByte; // Don't know what this byte is for yet.

        public byte CountItemsGUID;

        // Format for guid items
        public byte? GuidItem1_Unk1;
        public uint? GuidItem1_SdbId;
        public ulong? GuidItem1_GUID;
        public byte? GuidItem1_SubInventory;
        public byte[] GuidItem1_Unk2;
        public byte? GuidItem1_Unk3_Count;
        public byte[] GuidItem1_Unk3_Data;
        public byte[] GuidItem1_Unk4;
        public byte? GuidItem1_Unk5_Count;
        public byte[] GuidItem1_Unk5_Data;

        public byte[] RemainingGUIDItemsData;

        public byte CountItemsStackable;

        // Format for stackable items
        public uint? StackItem1_SdbId;
        public string? StackItem1_TextKey; // Used for XP rewards?
        public uint? StackItem1_Quantity;
        public byte[] StackItem1_Unk2;

        public byte[] RemainingStackableItemsData;

        public byte NYI_CountLoadouts;

        public byte[] Unk_LastThree;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1_FirstByte = Stream.Read.Byte();


            // GUID Items
            CountItemsGUID = Stream.Read.Byte();
            if (CountItemsGUID > 0)
            {
                // Parse first
                GuidItem1_Unk1 = Stream.Read.Byte();
                GuidItem1_SdbId = Stream.Read.UInt();
                GuidItem1_GUID = Stream.Read.ULong();
                GuidItem1_SubInventory = Stream.Read.Byte();
                GuidItem1_Unk2 = Stream.Read.ByteArray(12);
                GuidItem1_Unk3_Count = Stream.Read.Byte();
                if (GuidItem1_Unk3_Count > 0)
                {
                    GuidItem1_Unk3_Data = Stream.Read.ByteArray(8*(int)GuidItem1_Unk3_Count);
                }
                GuidItem1_Unk4 = Stream.Read.ByteArray(2);
                GuidItem1_Unk5_Count = Stream.Read.Byte();
                if (GuidItem1_Unk5_Count > 0)
                {
                    GuidItem1_Unk5_Data = Stream.Read.ByteArray(4*(int)GuidItem1_Unk5_Count);
                }

                // Consume remaining
                if (CountItemsGUID > 1)
                {
                    int remainingGuidItems = CountItemsGUID - 1;
                    int initialOffset = (int) Stream.baseStream.ByteOffset;
                    do
                    {
                        Stream.Read.Byte();
                        Stream.Read.UInt();
                        Stream.Read.ULong();
                        Stream.Read.Byte();
                        Stream.Read.ByteArray(12);
                        byte unk3Count = Stream.Read.Byte();
                        if (unk3Count > 0)
                        {
                            Stream.Read.ByteArray(8*unk3Count);
                        }
                        Stream.Read.ByteArray(2);
                        byte unk5Count = Stream.Read.Byte();
                        if (unk5Count > 0)
                        {
                            Stream.Read.ByteArray(4*unk5Count);
                        }
                        remainingGuidItems--;
                    }
                    while(remainingGuidItems > 0 && Stream.baseStream.ByteOffset < Stream.baseStream.Length);
                    int endOffset = (int) Stream.baseStream.ByteOffset;
                    int parsedBytes = (endOffset - initialOffset);
                    Stream.baseStream.ByteOffset = initialOffset;
                    RemainingGUIDItemsData = Stream.Read.ByteArray(parsedBytes);
                }
            }

            // Stackable Items
            CountItemsStackable = Stream.Read.Byte();
            if (CountItemsStackable > 0)
            {
                // Parse first
                StackItem1_SdbId = Stream.Read.UInt();
                StackItem1_TextKey = Stream.Read.StringZ(Stream);
                StackItem1_Quantity = Stream.Read.UInt();
                StackItem1_Unk2 = Stream.Read.ByteArray(5);

                // Consume remaining
                if (CountItemsStackable > 1)
                {
                    int remainingStackItems = CountItemsStackable - 1;
                    int initialOffset = (int) Stream.baseStream.ByteOffset;
                    do
                    {
                        Stream.Read.UInt();
                        Stream.Read.StringZ(Stream);
                        Stream.Read.UInt();
                        Stream.Read.ByteArray(5);
                        remainingStackItems--;
                    }
                    while(remainingStackItems > 0 && Stream.baseStream.ByteOffset < Stream.baseStream.Length);
                    int endOffset = (int) Stream.baseStream.ByteOffset;
                    int parsedBytes = (endOffset - initialOffset);
                    Stream.baseStream.ByteOffset = initialOffset;
                    RemainingStackableItemsData = Stream.Read.ByteArray(parsedBytes);
                }
            }

            // Loadouts
            NYI_CountLoadouts = Stream.Read.Byte();

            // Outline of loadouts for when PacketPeep gets split message support
            /*
            frame_loadout_id: uint32
            unk_data_1: 4 bytes
            frame_loadout_name: stringz
            frame_loadout_type: stringz
            chassis_id: uint32
            number_of_configs: byte
            * for each config
                config_id: uint32
                config_name: stringz
                number_of_items: byte
                * for each item
                    slot_idx: byte
                    item_guid: uint64
                unk_flags1: byte
                * unk_flags1 >= 0x04
                    decal_id: uint32
                    unk1: 9 bytes
                    decal_transform_count: byte
                    * for each decal_transform
                        value: float32
                    glider: uint32
                    unk2: 10 bytes
                    vehicle: uint32
                    unk3: 10 bytes
                    warpaint_palette: uint32
                    unk4: 10 bytes
                * unk_flags1 >= 0x05
                    warpaint_pattern: uint32
                    unk5: 9 bytes
                    pattern_transform_count: byte
                    * for each pattern_transform
                        value: float32
                number_of_perks: byte
                * for each perk
                    id: uint32
                unk6: 4 bytes
                unk7: 9 bytes
             */

            // Last four
            Unk_LastThree = Stream.Read.ByteArray(3);
        }
    }
}