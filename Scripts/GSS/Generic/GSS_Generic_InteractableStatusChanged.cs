[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 91, Ver: 1962)]
public partial class GenericInteractableStatusChanged : AeroBase
{
    public ulong EntityGUID;

    [AeroArray(5)]
    public byte[] Unk;

    public byte Interactable;
}