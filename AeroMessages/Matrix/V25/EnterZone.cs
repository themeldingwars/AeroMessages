using System;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 37)]
    public partial class EnterZone
    {
        // -- ZoneInfo
        public ulong InstanceId;
        public uint ZoneId;
        public long ZoneTimestamp;
        public ZoneFlags ZoneFlags;
        [AeroString] public string ZoneOwner;
        public ushort StreamingProtocol;
        public uint SvnRevision;
        public byte HotfixLevel;
        public ulong MatchId;
        public sbyte Unk2;
        public uint SimulationSeedMs;
        [AeroString] public string ZoneName;
        public byte HaveDevZoneInfo;
        [AeroIf(nameof(HaveDevZoneInfo), 1)]
        public DevZoneInfoData DevZoneInfo;
        // --

        public ZoneTimeSyncData ZoneTimeSyncInfo;
        public GameClockInfoData GameClockInfo;
        public sbyte SpectatorModeFlag;
    }

    [Flags]
    public enum ZoneFlags : byte
    {
        ZonePreview = 1 << 0,
        DataPreview = 1 << 1,
        AssetPreview = 1 << 2,
    }
}