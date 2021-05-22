/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 116
    MsgName: AbilityActivated
META_END
 */
[Aero]
public partial class Character_Event_AbilityActivated
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

[AeroBlock]
public struct ActiveCooldown
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;
    public uint Activated_Time;
    public uint ReadyAgain_Time;

    [AeroArray(5)]
    public byte[] Unk;
}