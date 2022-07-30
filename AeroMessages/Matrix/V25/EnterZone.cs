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

        public byte HaveUnk4; // Seems to be a big thing when not 0
        [AeroIf(nameof(HaveUnk4), 1)]
        public EZU4Data Unk4;
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

    [AeroBlock]
    public struct EZU4Data
    {
        // FUN_00755d40
        [AeroArray(typeof(byte))] EZU4Data_00755d40 Unk1;

        // FUN_00756a50
        [AeroArray(typeof(byte))] EZU4Data_00756a50 Unk2;
    }   

    [AeroBlock]
    public struct EZU4Data_00755d40
    {
        [AeroString] public string A1;
        public ushort A2;
    }

    [AeroBlock]
    public struct EZU4Data_00756a50
    {
        [AeroString] public string B1;
        public uint B2;
    }
}