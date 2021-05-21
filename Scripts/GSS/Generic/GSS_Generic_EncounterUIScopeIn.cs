[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 100, Ver: 1962)]
public partial class GenericEncounterUIScopeIn : AeroBase
{
    public ulong EncounterId;

    [AeroArray(typeof(ushort))]
    public byte[] TextData; // Text keys with values inbetween or?

    [AeroArray(-1)]
    public byte[] Unk;
}