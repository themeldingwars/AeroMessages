/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 68
    MsgName: MissionActivationAck
META_END
 */
[Aero]
public partial class Generic_Event_MissionActivationAck
{
    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;

    [AeroArray(2)]
    public byte[] Unk1;
}