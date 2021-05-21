[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 249, Ver: 1962)]
public partial class CharacterBaseControllerSlotGearRequest : AeroBase
{
    [AeroNullTermString]
    public string TargetName;

    [AeroArray(2)]
    public byte[] Unk_Status;
}