/*
META_BEGIN
    MsgType: Matrix
    MsgId: 37
    MsgName: EnterZone
META_END
 */
using System;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 37)]
    public partial class Matrix_EnterZone
    {
        public ulong InstanceId;
        public uint ZoneId;
        public ulong ZoneTimestamp;
        public byte PreviewModeFlag;

        [AeroString]
        public string ZoneOwner;

        [AeroArray(6)]
        public byte[] Unk1;

        public byte HotfixLevel;
        public ulong MatchId;

        [AeroArray(1)]
        public byte[] Unk2;
        public uint Unk3_Millis;

        [AeroString]
        public string ZoneName;

        public byte Unk4;

        [AeroArray(16)]
        public byte[] Unk_ZoneTime;

        public ulong Unk5_MicroUnix;
        public ulong Unk6_MicroUnix;

        [AeroArray(4)]
        public byte[] Unk7;
        public float Timescale;

        [AeroArray(17)]
        public byte[] Unk8;

        public byte SpectatorModeFlag;
    }
}