[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 5, 116, Ver: 1962)]
public partial class CharacterCombatControllerAbilityActivated : AeroBase
{   
    [AeroSDB("apt::AbilityData", "id")]
    public uint Activated_AbilityId;
    public uint Activated_Time;

    [AeroArray(typeof(uint))]
    public ActiveCooldown[] ActiveCooldowns_Group1; // Don't know the logic

    [AeroArray(typeof(uint))]
    public ActiveCooldown[] ActiveCooldowns_Group2; // Don't know the logic

    public uint GlobalCooldown_Activated_Time;
    public uint GlobalCooldown_ReadyAgain_Time;

    public byte Unk;
}

[Aero(AeroType.Block)]
public partial class ActiveCooldown : AeroBase
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;
    public uint Activated_Time;
    public uint ReadyAgain_Time;

    [AeroArray(5)]
    public byte[] Unk;
}