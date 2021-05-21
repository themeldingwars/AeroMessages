[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 185, Ver: 1962)]
public partial class CharacterBaseControllerSlotGearRequest : AeroBase
{
    [AeroArray(9)]
    public byte[] Unk1;

    [AeroNullTermString]
    public string InvitedCharacterName;

    public byte Unk2; // I'm seeing 0b, it could be chat channel for squad
    public ulong InvitingEntity;
}