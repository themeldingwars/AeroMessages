/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 101
    MsgName: EncounterUIUpdate
META_END
 */
[Aero]
public partial class Generic_Event_EncounterUIUpdate
{
    public ulong EncounterId;

    [AeroArray(-1)]
    public byte[] Unk;
}