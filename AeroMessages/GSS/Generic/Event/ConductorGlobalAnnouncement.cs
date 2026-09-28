using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ConductorGlobalAnnouncement, GssVersion.V1, GssVersion.V74)]
    public partial class ConductorGlobalAnnouncement
    {
        public GlobalAnnouncementData Data;
        public byte Activated; // [0,1]
    }

    [AeroBlock]
    public struct GlobalAnnouncementData
    {
        public uint StartTime;
        public uint EndTime;
        public uint ActionId;
        [AeroString] public string Unk4;
        [AeroString] public string Unk5;
        public byte HaveUnk6;
        [AeroIf(nameof(HaveUnk6), 1)] public GlobalAnnouncementDataType1 Unk6;
        public byte HaveUnk7;
        [AeroIf(nameof(HaveUnk7), 1)] public GlobalAnnouncementDataType2 Unk7;
        [AeroString] public string Unk8;
        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9), 1)] public GlobalAnnouncementDataType3 Unk9;
        public byte HaveAnnouncement;
        [AeroIf(nameof(HaveAnnouncement), 1)] public GlobalAnnouncementDataType4 Announcement;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType1
    {
        // FUN_00c3bb10
        public uint Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)] public uint Unk2;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType2
    {
        // FUN_00c3bd50
        public uint Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)] public uint Unk2;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType3
    {
        // FUN_00c3bfc0
        [AeroString] public string Unk1;
        [AeroArray(typeof(byte))] public uint[] Unk2;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType4
    {
        // FUN_00c3c280
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint ChatTextId;
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint BannerTextId;
        [AeroString] public string BannerStyle;
    }
}