/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 134
    MsgName: ActivateAbility
META_END
 */
[Aero]
public partial class Character_Command_ActivateAbility
{   
    public uint Time;
    public byte AbilitySlotIndex;

    public byte HaveTargetEntity;

    [AeroIf(HaveTargetEntity, true)]
    public TargetData APTTargetingData;

    [AeroIf(HaveTargetEntity, false)]
    public Vector3 UnkVector;
}

[AeroBlock]
public struct TargetData
{
    public ulong TargetEntity;
    public ulong InitiatorEntity;

    [AeroArray(5)]
    public byte[] Unk_1;
}