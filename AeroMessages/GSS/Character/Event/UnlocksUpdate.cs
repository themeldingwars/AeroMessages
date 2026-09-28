using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.UnlocksUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class UnlocksUpdate
    {
        public sbyte ClearExistingData; // 1 for full update, 0 for partitial

        [AeroArray(typeof(byte))]
        public UnlockGroup[] Groups;
    }

    [AeroBlock]
    public struct UnlockGroup
    {
        // Values: certificate, titles, market_slots, inventory_expansions,
        // decals, czi_patterns, visual_overrides, warpaints
        [AeroString]
        public string Key;

        // TODO: Aero needs support for handling additional entries if size is 255
        // TEMP: Hack that supports up to 2040 entries
        public byte AddEntriesCount;
        [AeroArray(nameof(AddEntriesCount))]
        public UnlockGroupEntry[] AddEntries;

        [AeroIf(nameof(AddEntriesCount), 255)]
        public byte AddEntriesCount2;
        [AeroArray(nameof(AddEntriesCount2))]
        public UnlockGroupEntry[] AddEntries2;

        [AeroIf(nameof(AddEntriesCount2), 255)]
        public byte AddEntriesCount3;
        [AeroArray(nameof(AddEntriesCount3))]
        public UnlockGroupEntry[] AddEntries3;

        [AeroIf(nameof(AddEntriesCount3), 255)]
        public byte AddEntriesCount4;
        [AeroArray(nameof(AddEntriesCount4))]
        public UnlockGroupEntry[] AddEntries4;

        [AeroIf(nameof(AddEntriesCount4), 255)]
        public byte AddEntriesCount5;
        [AeroArray(nameof(AddEntriesCount5))]
        public UnlockGroupEntry[] AddEntries5;

        [AeroIf(nameof(AddEntriesCount5), 255)]
        public byte AddEntriesCount6;
        [AeroArray(nameof(AddEntriesCount6))]
        public UnlockGroupEntry[] AddEntries6;

        [AeroIf(nameof(AddEntriesCount6), 255)]
        public byte AddEntriesCount7;
        [AeroArray(nameof(AddEntriesCount7))]
        public UnlockGroupEntry[] AddEntries7;

        [AeroIf(nameof(AddEntriesCount7), 255)]
        public byte AddEntriesCount8;
        [AeroArray(nameof(AddEntriesCount8))]
        public UnlockGroupEntry[] AddEntries8;

        [AeroArray(typeof(byte))]
        public UnlockGroupEntrySmall[] RemEntries; // unlocks taken away
    }

    [AeroBlock]
    public struct UnlockGroupEntry
    {
        [AeroSdb("dbitems::Certificate", "id")]
        [AeroSdb("dbcharacter::MonsterTitle", "id")]
        public uint UnlockId;

        public byte HaveItemSdbId;
        [AeroIf(nameof(HaveItemSdbId), 1)]
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId; // certificates that are tracked per item, e.g. per battleframe
        public byte HaveExpirationTime;
        [AeroIf(nameof(HaveExpirationTime), 1)] public uint ExpirationTime; // unix seconds
        public byte HaveUnk3;
        [AeroIf(nameof(HaveUnk3), 1)] [AeroString] public string Unk3;
    }

    [AeroBlock]
    public struct UnlockGroupEntrySmall
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;

        public byte HaveItemSdbId;
        [AeroIf(nameof(HaveItemSdbId), 1)]
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}