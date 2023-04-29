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

        public ushort StreamingProtocol;
        public uint Unk1_2; // Very close to source_revision: 117123 reported by client vs 117237 in capture

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