[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 118, Ver: 1962)]
public partial class CharacterBaseControllerDuelRequest : AeroBase
{
    [AeroArray(2)]
    public byte[] Unk1;

    public ulong RequestingEntity;

    [AeroArray(9)]
    public byte[] Unk2;

    [AeroNullTermString]
    public string TargetName;

    [AeroArray(20)]
    public byte[] Unk3;

    public ulong TargetEntity; // TODO: Verify this, might be in the Unk3
}