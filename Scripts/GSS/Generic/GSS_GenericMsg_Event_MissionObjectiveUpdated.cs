/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 64
    MsgName: MissionObjectiveUpdated
META_END
 */
[Aero]
public partial class Generic_Event_MissionObjectiveUpdated
{
    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;

    [AeroArray(8)]
    public byte[] Unk1;

    [AeroString]
    public string TextObjectiveTitle;

    [AeroString]
    public string TextObjectiveProgress;

    [AeroArray(5)]
    public byte[] Unk2;
}