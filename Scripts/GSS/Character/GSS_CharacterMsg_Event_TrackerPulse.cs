/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 135
    MsgName: TrackerEvent
META_END
 */
[Aero]
public partial class Character_Event_TrackerPulse
{
    public ulong Entity;

    [AeroArray(6)]
    public byte[] Unk1;

    [AeroString]
    public string Text;

    public byte Unk2;

    // Nothing concrete
    public ulong Entity;

    [AeroArray(28)]
    public byte[] Unk1;

    [AeroArray(3)]
    public float[] FloatArray1;

    [AeroArray(8)]
    public byte[] Unk2;
}