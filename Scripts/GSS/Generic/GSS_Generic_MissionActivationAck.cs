[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 68, Ver: 1962)]
public partial class GenericMissionActivationAck : AeroBase
{
    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;

    [AeroArray(2)]
    public byte[] Unk1;
}