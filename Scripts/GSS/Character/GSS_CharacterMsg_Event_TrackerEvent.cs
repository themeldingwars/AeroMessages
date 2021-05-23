/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 134
    MsgName: TrackerEvent
META_END
 */
[Aero]
public partial class Character_Event_TrackerEvent
{
    public ulong Entity;

    [AeroArray(6)]
    public byte[] Unk1;

    [AeroString]
    public string Text;

    public byte Unk2;
}