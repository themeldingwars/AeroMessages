using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 130)]
    public partial class UnlocksUpdate
    {
        public sbyte ClearExistingData; // 1 for full update, 0 for partitial

        [AeroArray(typeof(byte))]
        public UnlockGroup[] Groups;
    }

    [AeroBlock]
    public struct UnlockGroup
    {
        [AeroString]
        public string Key;

        [AeroArray(typeof(byte))] // TODO: Aero needs support for handling additional bytes if size is 255
        public UnlockGroupEntry[] AddEntries;

        [AeroArray(typeof(byte))]
        public UnlockGroupEntrySmall[] RemEntries; // Guessing that this is for removing stuff
    }

    [AeroBlock]
    public struct UnlockGroupEntry
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;

        public byte HaveUnk1;
        [AeroIf(nameof(HaveUnk1), 1)] public uint Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)] public uint Unk2;
        public byte HaveUnk3;
        [AeroIf(nameof(HaveUnk3), 1)] [AeroString] public string Unk3;
    }

    [AeroBlock]
    public struct UnlockGroupEntrySmall
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;

        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)] public uint Unk2;
    }
}