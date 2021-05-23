/*
META_BEGIN
    MsgType: Matrix
    MsgId: 37
    MsgName: EnterZone
META_END
 */
[Aero]
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

    public DateTimeOffset Unk5_MicroUnix;
    public DateTimeOffset Unk6_MicroUnix;

    [AeroArray(4)]
    public byte[] Unk7;
    public float Timescale;

    [AeroArray(17)]
    public byte[] Unk8;

    public byte SpectatorModeFlag;
}