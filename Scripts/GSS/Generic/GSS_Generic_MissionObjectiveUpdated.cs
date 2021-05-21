[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 64, Ver: 1962)]
public partial class GenericMissionObjectiveUpdated : AeroBase
{
    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;

    [AeroArray(8)]
    public byte[] Unk1;

    [AeroNullTermString]
    public string TextObjectiveTitle;

    [AeroNullTermString]
    public string TextObjectiveProgress;

    [AeroArray(5)]
    public byte[] Unk2;
}