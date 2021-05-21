[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 65, Ver: 1962)]
public partial class GenericMissionStatusChanged : AeroBase
{
    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;

    [AeroArray(5)]
    public byte[] Unk1;
}