/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 118
    MsgName: DuelRequest
META_END
 */
[Aero]
public partial class Character_Command_DuelRequest
{
    [AeroArray(2)]
    public byte[] Unk1;

    public ulong RequestingEntity;

    [AeroArray(9)]
    public byte[] Unk2;

    [AeroString]
    public string TargetName;

    [AeroArray(20)]
    public byte[] Unk3;

    public ulong TargetEntity; // TODO: Verify this, might be in the Unk3
}