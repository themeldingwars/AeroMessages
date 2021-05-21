[Aero(AeroType.Msg, MsgType.GSS, 0, 71, Ver: 1962)]
public partial class GenericBountyActivationAck : AeroBase
{
    public uint BountyId; // Unsure how this id works

    [AeroArray(7)]
    public byte[] Unk1;

    [AeroSDB("clientmissions::Mission","id")]
    [AeroSDB("clientmissions::MissionObjective","mission_id")]
    public uint MissionId;
    [AeroArray(9)]
    public byte[] Unk2;

    [AeroNullTermString]
    public string Name;

}