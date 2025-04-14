using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.Matrix.V25
{
    [AeroBlock]
    public struct DevZoneInfoData
    {
        // FUN_00755d40
        [AeroArray(typeof(byte))] public DevPortsData DevPorts;

        // FUN_00756a50
        [AeroArray(typeof(byte))] public DevPidsData DevPids;
    }   

    [AeroBlock]
    public struct DevPortsData
    {
        // FUN_00755d40
        [AeroString] public string Name;
        public ushort Port;
    }

    [AeroBlock]
    public struct DevPidsData
    {
        // FUN_00756a50
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
        public ulong MicroUnix_1;
        public ulong MicroUnix_2;
        public double Timescale;
        public ulong Unk3;
        public ulong Unk4;
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