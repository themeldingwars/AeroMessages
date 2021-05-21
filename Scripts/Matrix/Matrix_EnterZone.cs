[Aero(AeroType.Msg, MsgType.Matrix, 37, Ver: 1962)]
public partial class EnterZone : AeroBase
{
    public ulong InstanceId;
    public uint ZoneId;
    public ulong ZoneTimestamp;
    public byte PreviewModeFlag;

    [AeroNullTermString]
    public string ZoneOwner;

    [AeroArray(6)]
    public byte[] Unk1;

    public byte HotfixLevel;
    public ulong MatchId;

    [AeroArray(1)]
    public byte[] Unk2;
    public uint Unk3_Millis;

    [AeroNullTermString]
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