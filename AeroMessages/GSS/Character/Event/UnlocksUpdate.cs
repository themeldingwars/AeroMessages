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

        [AeroArray(typeof(byte), Chunked = true)]
        public UnlockGroupEntry[] AddEntries;

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
        [AeroIf(nameof(HaveItemSdbId), 1)] public uint ItemSdbId;
    }
}