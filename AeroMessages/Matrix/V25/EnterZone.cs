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

        public ZoneTimeSyncData ZoneTimeSyncInfo;
        public GameClockInfoData GameClockInfo;
        public byte SpectatorModeFlag;
    }
}