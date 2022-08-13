using System;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 37)]
    public partial class EnterZone
    {
        // -- FUN_00757370
        public ulong InstanceId;
        public uint ZoneId;
        public ulong ZoneTimestamp;
        public byte PreviewModeFlag;
        [AeroString] public string ZoneOwner;
        public ushort Unk1_1; // Looks like Build Number
        public uint Unk1_2; // Looks like Build Source Revision
        public byte HotfixLevel;
        public ulong MatchId;
        public byte Unk2;
        public uint Unk3_Millis;
        [AeroString] public string ZoneName;

        public byte HaveDevZoneInfo;
        [AeroIf(nameof(HaveDevZoneInfo), 1)]
        public DevZoneInfoData DevZoneInfo;
        // --

        public ulong ZoneTime_Unk1;
        public float ZoneTime_Unk2;
        public float ZoneTime_Unk3;

        // -- FUN_00757770
        public ulong Unk5_MicroUnix;
        public ulong Unk6_MicroUnix;
        [AeroArray(4)] public byte[] Timescale_1;
        public float Timescale_2;
        public ulong Unk7;
        public ulong Unk8;
        public byte Unk9;
        // --

        public byte SpectatorModeFlag;
    }
}