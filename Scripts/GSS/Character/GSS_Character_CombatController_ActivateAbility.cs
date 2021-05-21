[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 5, 134, Ver: 1962)]
public partial class CharacterCombatControllerActivateAbility : AeroBase
{   
    public uint Time;
    public byte AbilitySlotIndex;

    public byte HaveTargetEntity;

    [AeroIf(HaveTargetEntity, true)]
    public TargetData APTTargetingData;

    [AeroIf(HaveTargetEntity, false)]
    public Vector3 UnkVector;
}

[Aero(AeroType.Block)]
public partial class TargetData : AeroBase
{
    public ulong TargetEntity;
    public ulong InitiatorEntity;

    [AeroArray(5)]
    public byte[] Unk_1;
}