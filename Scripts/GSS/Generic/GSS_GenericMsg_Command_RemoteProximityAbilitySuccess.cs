/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 21
    MsgName: RemoteProximityAbilitySuccess
META_END
 */
[Aero]
public partial class Generic_Command_RemoteProximityAbilitySuccess
{
    public ulong SourceEntityGUID;
    public byte Unk;
    public uint ClientProximityCommandId;

    [AeroArray(typeof(byte))]
    public ulong[] TargetsGUIDs;

    public uint Time;
}