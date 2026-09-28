using Aero.Gen.Attributes;

namespace AeroMessages.Matrix
{
    [AeroBlock]
    public struct DevZoneInfoData
    {
        // Read_EnterZoneDevData 0x00755d40
        [AeroArray(typeof(byte))] public DevPortsData[] DevPorts;

        // ReadArray_String_And_Int 0x00756a50
        [AeroArray(typeof(byte))] public DevPidsData[] DevPids;
    }

    [AeroBlock]
    public struct DevPortsData
    {
        [AeroString] public string Name;
        public ushort Port;
    }

    [AeroBlock]
    public struct DevPidsData
    {
        [AeroString] public string Name;
        public uint Pid;
    }

    [AeroBlock]
    public struct ZoneTimeSyncData
    {
        public long FictionDateTimeOffsetMicros; // Adds onto the servertime, changing the fiction date zone_time.
        public float DayLengthFactor; // Default 12.0. Higher values make the day phase shorter. Probably how many seconds of daytime per realtime second.
        public float DayPhaseOffset; // This modifier changes the time of day but not on reset.
    }

    [AeroBlock]
    public struct GameClockInfoData
    {
        public ulong MicroUnix_1; // with ClockOffsetMicros the lower limit of the game clock
        public ulong MicroUnix_2; // Server unix time when the GSS game time was EnterZone.SimulationSeedMs
        public double Timescale;
        public ulong PausedAtMicros; // the clock stays at this value while Paused is set
        public ulong ClockOffsetMicros; // added to every computed game clock time
        public byte Paused;
    }

    [AeroBlock]
    public struct ClientPreferencesData
    {
        public uint MaxBytesPerSecond; // network.maxKBitPerSecond, value is sent as bytes rather than bits
        public uint MinBatchDelay; // network.minBatchDelay
        public ushort TargetMTU; // network.targetMTU, value sent caps at 1168 which is equiv to setting 1492 in the console.
        public byte MatrixDebugFlags; // When debuglag.matrixDev is set to 1, MatrixDebugFlags -> 2. Otherwise -> 0.
    }
}