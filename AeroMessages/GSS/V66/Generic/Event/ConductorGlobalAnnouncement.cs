using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 122)]
    public partial class ConductorGlobalAnnouncement
    {
        public GlobalAnnouncementData Data;
        public byte Unk2;
    }

    [AeroBlock]
    public struct GlobalAnnouncementData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        [AeroString] public string Unk4;
        [AeroString] public string Unk5;
        public byte HaveUnk6;
        [AeroIf(nameof(HaveUnk6))] public GlobalAnnouncementDataType1 Unk6;
        public byte HaveUnk7;
        [AeroIf(nameof(HaveUnk7))] public GlobalAnnouncementDataType2 Unk7;
        [AeroString] public string Unk8;
        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9))] public GlobalAnnouncementDataType3 Unk9;
        public byte HaveUnk10;
        [AeroIf(nameof(HaveUnk10))] public GlobalAnnouncementDataType4 Unk10;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType1
    {
        // FUN_00c3bb10
        public uint Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2))] public uint Unk2;
    }

    [AeroBlock]
    public struct GlobalAnnouncementDataType2
    {
        // FUN_00c3bd50
        public uint Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2))] public uint Unk2;
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
        public uint Unk1;
        public uint Unk2;
        [AeroString] public string Unk3;
    }
}