[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 88, Ver: 1962)]
public partial class CharacterBaseControllerRewardInfo : AeroBase
{
    public byte RewardType;
    public byte Bonus_RewardType; // Uncertain about this

    [AeroNullTermString]
    public string RelatedEntity;

    public uint Unk_RewardValue; // Not the value that is displayed?

    [AeroArray(4)]
    public byte[] Unk3;
    public uint Bonus_RewardValue; // Matches expectations
}