/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 20
    MsgName: LocalProximityAbilitySuccess
META_END
 */
[Aero]
public partial class Generic_Command_LocalProximityAbilitySuccess
{
    public ulong SourceEntityGUID;
    public byte Unk;
    public uint ClientProximityCommandId;

    [AeroArray(typeof(byte))]
    public ulong[] TargetsGUIDs;

    public uint Time;
}